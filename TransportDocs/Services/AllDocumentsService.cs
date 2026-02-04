using TransportDocs.Data;
using TransportDocs.Models;

namespace TransportDocs.Services
{
    public class AllDocumentsService
    {
        public void CreateAll(AllDocumentsRequest req)
        {
            using var con = Db.GetConnection();
            con.Open();

            using var tx = con.BeginTransaction();

            try
            {
                const int PHYSICAL_PERSON_CONTRACTOR_ID = 1;
                // -----------------------------
                // 1. Генерация номеров
                // -----------------------------
                var numbering = new NumberingService(con, tx);

                string actNumber = req.ActWithoutNumber
                    ? "б/н"
                    : numbering.GetNextSimpleNumber(req.CarrierId, req.Date.Year);

                string tripNumber = numbering.GetNextTripNumber(
                    req.CarrierId,
                    req.Date
                );

                // -----------------------------
                // 2. FinishedDocument
                // -----------------------------
                var finishedCmd = con.CreateCommand();
                finishedCmd.Transaction = tx;
                finishedCmd.CommandText = @"
                    INSERT INTO FinishedDocuments
                    (CustomerId, CarrierId, Date, City, Cost, ActNumber, TripNumber)
                    VALUES
                    (@cust, @car, @date, @city, @cost, @act, @trip)
                ";

                finishedCmd.Parameters.AddWithValue("@cust", req.CustomerId);
                finishedCmd.Parameters.AddWithValue("@car", req.CarrierId);
                finishedCmd.Parameters.AddWithValue(
                    "@date",
                    req.Date.ToString("yyyy-MM-dd")
                );
                finishedCmd.Parameters.AddWithValue("@city", req.City);
                finishedCmd.Parameters.AddWithValue("@cost", req.Cost);
                finishedCmd.Parameters.AddWithValue("@act", actNumber);
                finishedCmd.Parameters.AddWithValue("@trip", tripNumber);

                finishedCmd.ExecuteNonQuery();

                // -----------------------------
                // 3. TransportationBill
                // -----------------------------
                var billCmd = con.CreateCommand();
                billCmd.Transaction = tx;
                billCmd.CommandText = @"
                    INSERT INTO TransportationBills
                    (Date, CustomerId, CarrierId, ContractorId,
                     InvoiceNumber, RequestNumber,
                     Responsible, SupportingDocuments,
                     Cost, Whom, Address)
                    VALUES
                    (@date, @cust, @car, @contr,
                     @inv, @req,
                     @resp, @docs,
                     @cost, @whom, @addr)
                ";

                billCmd.Parameters.AddWithValue(
                    "@date",
                    req.Date.ToString("yyyy-MM-dd")
                );
                billCmd.Parameters.AddWithValue("@cust", req.CustomerId);
                billCmd.Parameters.AddWithValue("@car", req.CarrierId);
                billCmd.Parameters.AddWithValue(
                    "@contr",
                    req.IsPhysicalPerson
                        ? PHYSICAL_PERSON_CONTRACTOR_ID
                        : req.ContractorId
                );
                billCmd.Parameters.AddWithValue("@inv", actNumber);
                billCmd.Parameters.AddWithValue("@req", tripNumber);
                billCmd.Parameters.AddWithValue("@resp", string.Empty);
                billCmd.Parameters.AddWithValue("@docs", string.Empty);
                billCmd.Parameters.AddWithValue("@cost", req.Cost);
                billCmd.Parameters.AddWithValue("@whom", req.Whom);
                billCmd.Parameters.AddWithValue("@addr", req.Address);

                billCmd.ExecuteNonQuery();

                // -----------------------------
                // 4. Фиксируем
                // -----------------------------
                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }
    }
}
