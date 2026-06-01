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

            var upit = dbContext.Zaposleniks.FirstOrDefault();
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

            dbContext.Zaposleniks.InsertOnSubmit(zaposlenik);

            dbContext.SubmitChanges();

        }
    }
}
