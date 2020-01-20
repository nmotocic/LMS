namespace LMS.Domain.ViewModels
{
    public class BookViewModel
    {
        public int Serial_Number { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string Publisher { get; set; }
        public int? Year_Of_Publishing { get; set; }
        public string Genre { get; set; }
        public string Status { get; set; }
    }
}
