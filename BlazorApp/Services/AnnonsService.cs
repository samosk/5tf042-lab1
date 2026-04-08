public class AnnonsService
{
    private readonly AnnonsContext _db;

    public AnnonsService(AnnonsContext db)
    {
        _db = db;
    }

    public async Task SparaAnnonsAsync(Annonsor annonsor, AdFormModel form)
    {
        var befintlig = annonsor.Id > 0
            ? await _db.Annonsorer.FindAsync(annonsor.Id)
            : null;

        if (befintlig is null)
        {
            _db.Annonsorer.Add(annonsor);
            await _db.SaveChangesAsync();
            befintlig = annonsor;
        }

        var ad = new Ad
        {
            AnnonsorId = befintlig.Id,
            Rubrik = form.Rubrik,
            Innehall = form.Innehall,
            Varupris = form.Varupris,
            Annonspris = annonsor.Typ == "prenumerant" ? 0m : 40m
        };

        _db.Ads.Add(ad);
        await _db.SaveChangesAsync();
    }
}