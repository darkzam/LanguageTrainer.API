﻿namespace LanguageTrainer.API.Models
{
    public class Mistake
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Source Source { get; set; }
        public string Error { get; set; }
        public string Answer { get; set; }
    }
}
