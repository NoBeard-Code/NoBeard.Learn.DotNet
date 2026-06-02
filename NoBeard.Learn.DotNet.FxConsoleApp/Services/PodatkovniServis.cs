using System.Linq;

namespace NoBeard.Learn.DotNet.FxConsoleApp.Services
{
    internal class PodatkovniServis
    {
        private readonly DataClassesDataContext _dbContext;

        public PodatkovniServis(DataClassesDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Zaposlenik DohvatiZaposlenika(int id)
        {
            return _dbContext.Zaposleniks.SingleOrDefault(_ => _.ID == id);
        }

        public Zaposlenik DohvatiZaposlenika(string imePrezime)
        {
            return _dbContext.Zaposleniks
                .Where(_ => _.ImePrezime.Contains(imePrezime))
                .FirstOrDefault();
        }

        public void UnosZaposlenika(Zaposlenik zaposlenik)
        {
            // INSERT INTO Zaposlenik VALUES ...
            _dbContext.Zaposleniks.InsertOnSubmit(zaposlenik);

            _dbContext.SubmitChanges();
        }

        public void UrediZaposlenika(Zaposlenik zaposlenik)
        {
            // UPDATE Zaposlenik SET ... WHERE ...

            _dbContext.SubmitChanges();
        }

        public void UrediZaposlenika(int id, string adresa, string telefon)
        {
            var zaposlenik = DohvatiZaposlenika(id);

            // promijeniti svojstva
            zaposlenik.Adresa = adresa;
            zaposlenik.Telefon = telefon;

            _dbContext.SubmitChanges();
        }

        public void ObrisiZaposlenika(int id)
        {
            // DELETE FROM Zaposlenik WHERE Id = ...

            var zaposlenik = DohvatiZaposlenika(id);

            _dbContext.Zaposleniks.DeleteOnSubmit(zaposlenik);
            _dbContext.SubmitChanges();
        }

        public void ObrisiZaposlenika(Zaposlenik zaposlenik)
        {
            // DELETE FROM Zaposlenik WHERE Id = ...

            _dbContext.Zaposleniks.DeleteOnSubmit(zaposlenik);
            _dbContext.SubmitChanges();
        }
    }
}
