using NoBeard.Learn.DotNet.FxConsoleApp.Services;
using System.Configuration;
using System.Linq;

namespace NoBeard.Learn.DotNet.FxConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var connStr = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=linq_to_sql;Integrated Security=True;TrustServerCertificate=True";
            var connStr = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;

            var dbContext = new DataClassesDataContext(connStr);

            // DML:
            // UnosZaposlenika(dbContext);

            //var pero = dbContext.Zaposleniks.FirstOrDefault();

            //pero.Adresa = "Trg Pere Perića";
            //pero.Telefon = "231232312";

            //UrediZaposlenika(dbContext, pero);

            var servis = new PodatkovniServis(dbContext);

            var pero = servis.DohvatiZaposlenika(2);

            pero.Email = "pero2@test.me";

            servis.UrediZaposlenika(pero);

            servis.ObrisiZaposlenika(pero);
        }

        private static void UnosZaposlenika(DataClassesDataContext dbContext)
        {
            var zaposlenik = new Zaposlenik
            {
                ImePrezime = "Pero Perić",
                Email = "pero@algebra.hr",
                Telefon = "+385 (99) 1231232",
                Adresa = "Vrtna bb",
                OdjelID = 1
            };

            // INSERT INTO Zaposlenik VALUES ...
            dbContext.Zaposleniks.InsertOnSubmit(zaposlenik);

            dbContext.SubmitChanges();
        }

        private static void UrediZaposlenika(DataClassesDataContext dbContext, Zaposlenik zaposlenik)
        {
            // UPDATE Zaposlenik SET ... WHERE ...

            dbContext.SubmitChanges();
        }
    }
}
