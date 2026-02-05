using System.IO.Compression;
using System.Text;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using TransportDocs.Models;
using TransportDocs.Repositories;

namespace TransportDocs.Services
{
    public class DocumentGenerator
    {
        private readonly string _templatesDir;
        private readonly string _outputRootDir;
        private string? _runOutputDir;
        private DateTime? _runTimestamp;

        public string? LastOutputDir => _runOutputDir;

        public DocumentGenerator()
        {
            _templatesDir = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Templates"
            );
            _outputRootDir = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Documents"
            );
        }

        public void StartRun(AllDocumentsRequest req)
        {
            _runTimestamp = DateTime.Now;
            _runOutputDir = null;
        }

        public string GenerateActAndRequest(
            AllDocumentsRequest req,
            string actNumber,
            string requestNumber
        )
        {
            var data = BuildCommonData(req, actNumber, requestNumber);
            string outputDir = EnsureRunOutputDir(data);
            Directory.CreateDirectory(outputDir);

            string actTemplate = Path.Combine(_templatesDir, "Акт.docx");
            string requestTemplate = Path.Combine(
                _templatesDir,
                "Заявка на перевозку грузов.docx"
            );

            string actOut = Path.Combine(
                outputDir,
                $"Акт_{data.DateShort}_{SafeFileName(data.CustomerName)}.docx"
            );
            string requestOut = Path.Combine(
                outputDir,
                $"Заявка_{data.DateShort}_{SafeFileName(data.CustomerName)}.docx"
            );
            string mergedOut = Path.Combine(
                outputDir,
                $"Акт_и_Заявка_{data.DateShort}_{SafeFileName(data.CustomerName)}.docx"
            );

            RenderDocxTemplate(actTemplate, actOut, BuildActPlaceholders(data));
            RenderDocxTemplate(
                requestTemplate,
                requestOut,
                BuildRequestPlaceholders(data)
            );

            MergeDocx(actOut, requestOut, mergedOut);
            EnsureFileExists(mergedOut);

            return mergedOut;
        }

        public string GenerateTransportationBill(
            AllDocumentsRequest req,
            string invoiceNumber,
            string requestNumber
        )
        {
            var data = BuildCommonData(req, invoiceNumber, requestNumber);
            string outputDir = EnsureRunOutputDir(data);
            Directory.CreateDirectory(outputDir);

            string xlsTemplate = Path.Combine(
                _templatesDir,
                "Транспортная накладная.xls"
            );

            if (!File.Exists(xlsTemplate))
            {
                throw new FileNotFoundException(
                    "XLS шаблон транспортной накладной не найден.",
                    xlsTemplate
                );
            }

            string billOut = Path.Combine(
                outputDir,
                $"Транспортная_накладная_{data.DateShort}_{SafeFileName(data.CustomerName)}.xls"
            );

            GenerateTransportationBillXls(
                xlsTemplate,
                billOut,
                BuildBillPlaceholders(data),
                data
            );
            EnsureFileExists(billOut);
            return billOut;
        }

        private TemplateData BuildCommonData(
            AllDocumentsRequest req,
            string actOrInvoiceNumber,
            string requestNumber
        )
        {
            var customer = new CustomerRepository().GetById(req.CustomerId);
            var carrier = new CarrierRepository().GetById(req.CarrierId);

            Contractor? contractor = null;
            if (!req.IsPhysicalPerson && req.ContractorId.HasValue)
            {
                contractor = new ContractorRepository().GetById(
                    req.ContractorId.Value
                );
            }

            string contractDate = new ContractRepository()
                .GetLatestDate(req.CustomerId, req.CarrierId);

            string dateShort = req.Date.ToString("dd.MM.yyyy");
            string dateLong = FormatDateLong(req.Date);
            string requestDateShort = dateShort;

            int costInt = (int)Math.Round(req.Cost);
            string costWords = RussianNumberService.ToWords(costInt);

            return new TemplateData
            {
                CustomerId = customer.Id,
                DateShort = dateShort,
                DateLong = dateLong,
                RequestDateShort = requestDateShort,
                ActNumber = actOrInvoiceNumber,
                RequestNumber = requestNumber,
                City = req.City,
                Cost = costInt.ToString(),
                CostWords = costWords,
                CostWordsShort = costWords,
                CustomerName = customer.Name ?? string.Empty,
                CustomerOgrn = customer.Ogrn ?? string.Empty,
                CustomerInn = customer.Inn ?? string.Empty,
                CustomerKpp = string.IsNullOrWhiteSpace(customer.Kpp)
                    ? "-"
                    : customer.Kpp,
                CustomerAddress = customer.Address ?? string.Empty,
                CustomerDirector = customer.DirectorName ?? string.Empty,
                CarrierName = carrier.Name ?? string.Empty,
                CarrierOgrn = carrier.Ogrn ?? string.Empty,
                CarrierInn = carrier.Inn ?? string.Empty,
                CarrierAddress = carrier.Address ?? string.Empty,
                CarrierCarNumber = carrier.CarNumber ?? string.Empty,
                CarrierCarModel = carrier.CarModel ?? string.Empty,
                CarrierPhone = carrier.Phone ?? string.Empty,
                CarrierTonnage = carrier.Tonnage ?? string.Empty,
                CarrierNameShort = ToShortName(carrier.Name ?? string.Empty),
                ContractorName = contractor?.Name ?? req.Whom ?? string.Empty,
                ContractorType = contractor?.Type ?? string.Empty,
                ContractorInn = contractor?.Inn ?? string.Empty,
                ContractorAddress = contractor?.Address ?? req.Address ?? string.Empty,
                SupportingDocuments = string.Empty,
                Responsible = string.Empty,
                ContractDateLong = contractDate
            };
        }

        private static Dictionary<string, string> BuildActPlaceholders(
            TemplateData d
        )
        {
            return new Dictionary<string, string>
            {
                ["{{CARRIER_NAME}}"] = d.CarrierName,
                ["{{CARRIER_NAME_SHORT}}"] = d.CarrierNameShort,
                ["{{CARRIER_OGRN}}"] = d.CarrierOgrn,
                ["{{CARRIER_INN}}"] = d.CarrierInn,
                ["{{CARRIER_ADDRESS}}"] = d.CarrierAddress,
                ["{{CARRIER_CAR_NUMBER}}"] = d.CarrierCarNumber,
                ["{{CARRIER_TONNAGE}}"] = d.CarrierTonnage,
                ["{{CUSTOMER_NAME}}"] = d.CustomerName,
                ["{{CUSTOMER_OGRN}}"] = d.CustomerOgrn,
                ["{{CUSTOMER_INN}}"] = d.CustomerInn,
                ["{{CUSTOMER_KPP}}"] = d.CustomerKpp,
                ["{{CUSTOMER_ADDRESS}}"] = d.CustomerAddress,
                ["{{CUSTOMER_DIRECTOR}}"] = d.CustomerDirector,
                ["{{CONTRACT_DATE_LONG}}"] = d.ContractDateLong,
                ["{{ACT_NUMBER}}"] = d.ActNumber,
                ["{{ACT_DATE_LONG}}"] = d.DateLong,
                ["{{ACT_DATE_SHORT}}"] = d.DateShort,
                ["{{CITY}}"] = d.City,
                ["{{COST}}"] = d.Cost,
                ["{{COST_WORDS}}"] = d.CostWords
            };
        }

        private static Dictionary<string, string> BuildRequestPlaceholders(
            TemplateData d
        )
        {
            return new Dictionary<string, string>
            {
                ["{{REQUEST_NUMBER}}"] = d.RequestNumber,
                ["{{REQUEST_DATE_SHORT}}"] = d.RequestDateShort,
                ["{{CUSTOMER_NAME}}"] = d.CustomerName,
                ["{{CARRIER_NAME}}"] = d.CarrierName,
                ["{{CITY}}"] = d.City,
                ["{{COST}}"] = d.Cost,
                ["{{COST_WORDS_SHORT}}"] = d.CostWordsShort,
                ["{{CARRIER_CAR_MODEL}}"] = d.CarrierCarModel,
                ["{{CARRIER_CAR_NUMBER}}"] = d.CarrierCarNumber,
                ["{{CARRIER_PHONE}}"] = d.CarrierPhone,
                ["{{CARRIER_NAME_SHORT}}"] = d.CarrierNameShort
            };
        }

        private static Dictionary<string, string> BuildBillPlaceholders(
            TemplateData d
        )
        {
            string whomLine = string.IsNullOrWhiteSpace(d.ContractorName)
                ? "Физическое лицо"
                : d.ContractorName;
            string contractorsType = string.IsNullOrWhiteSpace(d.ContractorType)
                ? ""
                : d.ContractorType;
            string inn = string.IsNullOrWhiteSpace(d.ContractorInn)
                ? string.Empty
                : $"ИНН {d.ContractorInn}";

            string customerSection1 = d.CustomerId == 1
                ? "Обособленное подразделение ООО \"Стройинвест-2\", ИНН 6147042032, ЛНР г. Луганск, ул. Фабричная 2Ж"
                : $"{d.CustomerName}, ИНН {d.CustomerInn}, {d.CustomerAddress}";

            string customerSection2 = d.CustomerId == 1
                ? "Обособленное подразделение ООО \"Стройинвест-2\", ИНН 6147042032, ЛНР г. Луганск, ул. Фабричная 2Ж"
                : $"{d.CustomerName}, ИНН {d.CustomerInn}, ЛНР г. Луганск, ул. Фабричная 2Ж";

            return new Dictionary<string, string>
            {
                ["{{DATE}}"] = d.DateShort,
                ["{{INVOICE_NUMBER}}"] = d.ActNumber,
                ["{{REQUEST_NUMBER}}"] = d.RequestNumber,
                ["{{CUSTOMER_NAME}}"] = d.CustomerName,
                ["{{CUSTOMER_INN}}"] = d.CustomerInn,
                ["{{CUSTOMER_ADDRESS}}"] = d.CustomerAddress,
                ["{{CUSTOMER_SECTION_1}}"] = customerSection1,
                ["{{CUSTOMER_SECTION_2}}"] = customerSection2,
                ["{{CARRIER_NAME}}"] = d.CarrierName,
                ["{{CARRIER_INN}}"] = d.CarrierInn,
                ["{{CARRIER_ADDRESS}}"] = d.CarrierAddress,
                ["{{CARRIER_CAR_MODEL}}"] = d.CarrierCarModel,
                ["{{CARRIER_CAR_NUMBER}}"] = d.CarrierCarNumber,
                ["{{WHOM}}"] = whomLine,
                ["{{CONTRACTORS_TYPE}}"] = contractorsType,
                ["{{CONTRACTOR_INN}}"] = inn,
                ["{{ADDRESS}}"] = d.ContractorAddress,
                ["{{SUPPORTING_DOCUMENTS}}"] = d.SupportingDocuments,
                ["{{RESPONSIBLE}}"] = d.Responsible,
                ["{{COST}}"] = d.Cost,
                ["{{CARRIER_TONNAGE}}"] = d.CarrierTonnage
            };
        }

        private static void GenerateTransportationBillXls(
            string templatePath,
            string outputPath,
            Dictionary<string, string> replacements,
            TemplateData data
        )
        {
            using var fs = File.OpenRead(templatePath);
            var workbook = new HSSFWorkbook(fs);
            var formatter = new DataFormatter();

            for (int s = 0; s < workbook.NumberOfSheets; s++)
            {
                var sheet = workbook.GetSheetAt(s);
                if (sheet == null) continue;

                foreach (IRow row in sheet)
                {
                    foreach (ICell cell in row.Cells)
                    {
                        string value = formatter.FormatCellValue(cell);
                        if (string.IsNullOrWhiteSpace(value)) continue;

                        string updated = ApplyXlsReplacements(
                            value,
                            replacements,
                            data
                        );

                        if (!ReferenceEquals(value, updated)
                            && value != updated)
                        {
                            cell.SetCellType(CellType.String);
                            cell.SetCellValue(updated);
                        }
                    }
                }
            }

            using var outFs = File.Create(outputPath);
            workbook.Write(outFs);
        }

        private static string ApplyXlsReplacements(
            string value,
            Dictionary<string, string> replacements,
            TemplateData d
        )
        {
            if (string.IsNullOrWhiteSpace(value)) return value;

            string updated = value;

            foreach (var (key, val) in replacements)
            {
                if (updated.Contains(key))
                {
                    updated = updated.Replace(key, val);
                }
            }

            updated = updated.Replace(
                "Обособленное подразделение ООО \"Стройинвест-2\", ИНН 6147042032, ЛНР г. Луганск, ул. Фабричная 2Ж",
                d.CustomerId == 1
                    ? "Обособленное подразделение ООО \"Стройинвест-2\", ИНН 6147042032, ЛНР г. Луганск, ул. Фабричная 2Ж"
                    : $"{d.CustomerName}, ИНН {d.CustomerInn}, {d.CustomerAddress}"
            );

            updated = updated.Replace(
                "Обособленное подразделение ООО \"Стройинвест-2\", ИНН 6147042032",
                d.CustomerId == 1
                    ? "Обособленное подразделение ООО \"Стройинвест-2\", ИНН 6147042032"
                    : $"{d.CustomerName}, ИНН {d.CustomerInn}"
            );

            updated = updated.Replace(
                "ИП Высотин Сергей Викторович",
                $"ИП {d.CarrierName}"
            );
            updated = updated.Replace(
                "Высотин Сергей Викторович",
                d.CarrierName
            );
            updated = updated.Replace(
                "ИП Старкова Светлана Анатольевна",
                d.CustomerName
            );
            updated = updated.Replace(
                "Старкова Светлана Анатольевна",
                d.CustomerName
            );

            updated = Regex.Replace(
                updated,
                @"\b\\d{2}/\\d{2}/\\d{2}-\\d+\\b",
                d.RequestNumber
            );

            updated = Regex.Replace(
                updated,
                @"\b\\d{2}/\\d{2}/\\d{4}\\b",
                d.ActNumber
            );

            updated = Regex.Replace(
                updated,
                @"\b\\d{2}[./]\\d{2}[./]\\d{4}\\b",
                d.DateShort
            );

            updated = Regex.Replace(
                updated,
                @"Нетто:\\s*\\d+",
                $"Нетто: {d.CarrierTonnage}"
            );

            updated = Regex.Replace(
                updated,
                @"\\b\\d+[\\.,]\\d{2}\\s*руб\\.",
                $"{d.Cost} руб."
            );

            if (updated.Contains("ИНН") && updated.Contains(d.CustomerName))
            {
                updated = Regex.Replace(
                    updated,
                    @"ИНН\\s*\\d+",
                    $"ИНН {d.CustomerInn}"
                );
            }

            if (updated.Contains("ИНН") && updated.Contains(d.CarrierName))
            {
                updated = Regex.Replace(
                    updated,
                    @"ИНН\\s*\\d+",
                    $"ИНН {d.CarrierInn}"
                );
            }

            if (updated.Contains("Нетто:") && !string.IsNullOrWhiteSpace(d.CarrierTonnage))
            {
                updated = Regex.Replace(
                    updated,
                    @"Нетто:\\s*\\d+",
                    $"Нетто: {d.CarrierTonnage}"
                );
            }

            if (!string.IsNullOrWhiteSpace(d.ContractorName))
            {
                updated = updated.Replace("Физическое лицо", d.ContractorName);
            }

            return updated;
        }

        private static void RenderDocxTemplate(
            string templatePath,
            string outputPath,
            Dictionary<string, string> replacements
        )
        {
            using var input = ZipFile.OpenRead(templatePath);
            using var output = ZipFile.Open(
                outputPath,
                ZipArchiveMode.Create
            );

            foreach (var entry in input.Entries)
            {
                using var entryStream = entry.Open();
                var outEntry = output.CreateEntry(entry.FullName);

                using var outStream = outEntry.Open();

                if (entry.FullName.StartsWith("word/")
                    && entry.FullName.EndsWith(".xml"))
                {
                    using var reader = new StreamReader(entryStream);
                    string text = reader.ReadToEnd();

                    text = ReplacePlaceholders(text, replacements);

                    using var writer = new StreamWriter(outStream);
                    writer.Write(text);
                }
                else
                {
                    entryStream.CopyTo(outStream);
                }
            }
        }

        private static void MergeDocx(
            string firstPath,
            string secondPath,
            string outputPath
        )
        {
            File.Copy(firstPath, outputPath, true);

            using var mainDoc = WordprocessingDocument.Open(
                outputPath,
                true
            );
            using var addDoc = WordprocessingDocument.Open(
                secondPath,
                false
            );

            var body = mainDoc.MainDocumentPart!.Document.Body!;

            body.AppendChild(
                new Paragraph(new Run(new Break { Type = BreakValues.Page }))
            );

            foreach (var element in addDoc.MainDocumentPart!.Document.Body!
                         .Elements())
            {
                body.Append(element.CloneNode(true));
            }

            mainDoc.MainDocumentPart.Document.Save();
        }


        private static string ReplacePlaceholders(
            string text,
            Dictionary<string, string> replacements
        )
        {
            foreach (var (key, value) in replacements)
            {
                text = text.Replace(key, value ?? string.Empty);
            }

            return text;
        }

        private static string FormatDateLong(DateTime date)
        {
            string[] months =
            {
                "января", "февраля", "марта", "апреля",
                "мая", "июня", "июля", "августа",
                "сентября", "октября", "ноября", "декабря"
            };

            string day = date.Day.ToString("00");
            string month = months[date.Month - 1];
            return $"«{day}» {month} {date:yyyy} г.";
        }

        private static string ToShortName(string fullName)
        {
            var parts = fullName
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 0) return string.Empty;
            if (parts.Length == 1) return parts[0];

            var lastName = parts[0];
            var initials = string.Join(
                " ",
                parts.Skip(1)
                    .Where(p => p.Length > 0)
                    .Select(p => $"{p[0]}.")
            );

            return $"{lastName} {initials}".Trim();
        }

        private static string SafeFileName(string name)
        {
            foreach (var c in Path.GetInvalidFileNameChars())
            {
                name = name.Replace(c, '_');
            }

            return name;
        }

        private string EnsureRunOutputDir(TemplateData data)
        {
            if (!string.IsNullOrWhiteSpace(_runOutputDir))
            {
                return _runOutputDir;
            }

            DateTime ts = _runTimestamp ?? DateTime.Now;
            string folderName = $"{data.CustomerName} {data.CarrierName} {ts:yyyy-MM-dd HH-mm-ss}";
            folderName = SafeFileName(folderName);

            _runOutputDir = Path.Combine(_outputRootDir, folderName);
            return _runOutputDir;
        }

        private static void EnsureFileExists(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException(
                    "Файл не был создан.",
                    path
                );
            }
        }

        private class TemplateData
        {
            public int CustomerId { get; set; }
            public string DateShort { get; set; } = string.Empty;
            public string DateLong { get; set; } = string.Empty;
            public string RequestDateShort { get; set; } = string.Empty;
            public string ActNumber { get; set; } = string.Empty;
            public string RequestNumber { get; set; } = string.Empty;
            public string City { get; set; } = string.Empty;
            public string Cost { get; set; } = string.Empty;
            public string CostWords { get; set; } = string.Empty;
            public string CostWordsShort { get; set; } = string.Empty;
            public string CustomerName { get; set; } = string.Empty;
            public string CustomerOgrn { get; set; } = string.Empty;
            public string CustomerInn { get; set; } = string.Empty;
            public string CustomerKpp { get; set; } = string.Empty;
            public string CustomerAddress { get; set; } = string.Empty;
            public string CustomerDirector { get; set; } = string.Empty;
            public string CarrierName { get; set; } = string.Empty;
            public string CarrierOgrn { get; set; } = string.Empty;
            public string CarrierInn { get; set; } = string.Empty;
            public string CarrierAddress { get; set; } = string.Empty;
            public string CarrierCarNumber { get; set; } = string.Empty;
            public string CarrierCarModel { get; set; } = string.Empty;
            public string CarrierPhone { get; set; } = string.Empty;
            public string CarrierTonnage { get; set; } = string.Empty;
            public string CarrierNameShort { get; set; } = string.Empty;
            public string ContractorName { get; set; } = string.Empty;
            public string ContractorType { get; set; } = string.Empty;
            public string ContractorInn { get; set; } = string.Empty;
            public string ContractorAddress { get; set; } = string.Empty;
            public string SupportingDocuments { get; set; } = string.Empty;
            public string Responsible { get; set; } = string.Empty;
            public string ContractDateLong { get; set; } = string.Empty;
        }
    }
}
