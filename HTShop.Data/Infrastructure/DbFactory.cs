namespace HTShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HTShopDbContext dbContext;

        public HTShopDbContext Init()
        {
            return dbContext ?? (dbContext = new HTShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}