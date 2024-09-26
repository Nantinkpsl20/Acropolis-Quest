using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acropolis_Quest.Models
{
    public class Answer
    {
        public int answerId { get; set; }
        public String text { get; set; }
        public int QuestionId { get; set; }
        public bool isCorrect { get; set; }

        public Question Question { get; set; }
    }
}
