namespace Library.Domain.Book.Value_Object;
using Library.Domain.Patrion.Aggregate;

public record Review
{
    public Guid Id { get; init; }
    public Guid PatrionId { get; init; }
    public string Descriptoin { get; init; }
    public decimal Rating { get; init; }

    public Review(Guid patrionId, string Descriptoin, decimal Rating)
    {
        if (Rating > 5 || Rating < 0)
        {
            throw new ArgumentException("Rating Out Of Bound!!");
        }

        Id = Guid.NewGuid();
        PatrionId = patrionId;
        this.Descriptoin = Descriptoin;
        this.Rating = Rating;
    }
}