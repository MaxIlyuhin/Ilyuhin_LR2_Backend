namespace Ilyuhin_LR2_Backend.Models
{
    public class Book
    {
        public int id { get; set; }

        public int author_id { get; set; }

        public int amount { get; set; }

        public decimal price { get; set; }

        public string? title { get; set; }

    }
}
