using System;
using System.Collections.Generic;

namespace EntityFrameworkQuiz.Models
{
    public class Quiz
    {
        public Guid Id { get; set; }
        public List<Question> Questions { get; set; }
        public string Topic { get; set; }
    }
}