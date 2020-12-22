namespace Nagarro.BookReading.Core.Base
{
    public interface IEntityBase<TId>
    {
        TId Id { get; }
    }
}
