using System;
namespace EntityFrameworkQuiz.Models
{
    public class Options
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public string ChoiceOne { get; set; }
        public string ChoiceTwo { get; set; }
        public string ChoiceThree { get; set; }
        public string ChoiceFour { get; set; }
    }
}