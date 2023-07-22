namespace Casgem_CQRS.CQRS.Queries
{
    public class GetProductUpdateByIDQuery
    {
        public GetProductUpdateByIDQuery(int ıd)
        {
            Id = ıd;
        }
        public int Id { get; set; }
    }
}
