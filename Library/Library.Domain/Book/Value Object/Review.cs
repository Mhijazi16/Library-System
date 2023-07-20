namespace Library.Domain.Book.Value_Object;
using Library.Domain.Patrion.Aggregate;

public record Review
{
    public Patrion Patrion { get; init; }
    public string Descriptoin { get; init; }
    public decimal Rating { get; init; }

    public Review(Patrion patrion, string Descriptoin, decimal Rating)
    {
        if (Rating > 5 || Rating < 0)
        {
            throw new ArgumentException("Rating Out Of Bound!!");
        }

        this.Patrion = patrion;
        this.Descriptoin = Descriptoin;
        this.Rating = Rating;
    }
}