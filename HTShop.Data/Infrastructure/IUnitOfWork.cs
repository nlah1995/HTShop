namespace HTShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}