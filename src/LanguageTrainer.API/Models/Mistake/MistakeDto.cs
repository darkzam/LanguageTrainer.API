namespace LanguageTrainer.API.Models
{
    public class MistakeDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Error { get; set; }
        public string Answer { get; set; }
    }
}
