
namespace Infrastructure.Models
{
    public class CourseModel
    {
        public string? Id { get; set; }

        public string? Title { get; set; }

        public string? ImageUri { get; set; }

        public string? Author { get; set; }

        public bool IsBestseller { get; set; }

        public int Hours { get; set; }

        public decimal OriginalPrice { get; set; }

        public decimal DiscountPrice { get; set; }

        public string? LikesInProcent { get; set; }

        public string? LikesInNumbers { get; set; }

        public string? Category { get; set; }
    } 
}
