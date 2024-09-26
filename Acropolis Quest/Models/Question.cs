using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acropolis_Quest.Models
{
    public class Question
    {
        public int questionId { get; set; }
        public String text { get; set; }
        public int quizId { get; set; }

        public Quiz Quiz { get; set; }

        //list that contains the answers of question
        public List<Answer> Answers { get; set; }
    }
}
