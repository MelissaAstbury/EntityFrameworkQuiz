using System;
using System.Collections.Generic;

namespace EntityFrameworkQuiz.Models
{
    public class Question
    {
        public Guid Id { get; set; }
        public Guid QuizId { get; set; }
        public string Text { get; set; }
        public List<Options> Answer { get; set; }
    }
}