using System;

namespace HTShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        HTShopDbContext Init();
    }
}