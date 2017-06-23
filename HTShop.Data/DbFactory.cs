using HTShop.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTShop.Data
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