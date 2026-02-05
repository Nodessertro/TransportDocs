namespace TransportDocs.Services
{
    public static class RussianNumberService
    {
        private static readonly string[] UnitsMale =
        {
            "", "один", "два", "три", "четыре",
            "пять", "шесть", "семь", "восемь", "девять"
        };

        private static readonly string[] UnitsFemale =
        {
            "", "одна", "две", "три", "четыре",
            "пять", "шесть", "семь", "восемь", "девять"
        };

        private static readonly string[] Teens =
        {
            "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать",
            "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать"
        };

        private static readonly string[] Tens =
        {
            "", "десять", "двадцать", "тридцать", "сорок",
            "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто"
        };

        private static readonly string[] Hundreds =
        {
            "", "сто", "двести", "триста", "четыреста",
            "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот"
        };

        public static string ToWords(int value, bool capitalize = true)
        {
            if (value == 0) return capitalize ? "Ноль" : "ноль";

            var parts = new List<string>();

            int millions = value / 1_000_000;
            int thousands = (value / 1_000) % 1_000;
            int rest = value % 1_000;

            if (millions > 0)
            {
                parts.Add(ConvertBelowThousand(millions, false));
                parts.Add(ChooseForm(millions, "миллион", "миллиона", "миллионов"));
            }

            if (thousands > 0)
            {
                parts.Add(ConvertBelowThousand(thousands, true));
                parts.Add(ChooseForm(thousands, "тысяча", "тысячи", "тысяч"));
            }

            if (rest > 0)
            {
                parts.Add(ConvertBelowThousand(rest, false));
            }

            var result = string.Join(" ", parts.Where(p => !string.IsNullOrWhiteSpace(p)));
            result = result.Trim();

            if (!capitalize) return result;

            return char.ToUpper(result[0]) + result[1..];
        }

        private static string ConvertBelowThousand(int value, bool female)
        {
            var parts = new List<string>();

            int h = value / 100;
            int t = (value / 10) % 10;
            int u = value % 10;

            if (h > 0) parts.Add(Hundreds[h]);

            if (t == 1)
            {
                parts.Add(Teens[u]);
            }
            else
            {
                if (t > 0) parts.Add(Tens[t]);
                if (u > 0) parts.Add((female ? UnitsFemale : UnitsMale)[u]);
            }

            return string.Join(" ", parts);
        }

        private static string ChooseForm(int value, string form1, string form2, string form5)
        {
            int n = value % 100;
            if (n >= 11 && n <= 19) return form5;
            int n1 = value % 10;
            if (n1 == 1) return form1;
            if (n1 >= 2 && n1 <= 4) return form2;
            return form5;
        }
    }
}
