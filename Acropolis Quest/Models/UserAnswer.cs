using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acropolis_Quest.Models
{
    public class UserAnswer
    {
        public int userAswerId { get; set; }
        public int submissionId { get; set; }   
        public int questionId { get; set; } 
        public int answerId { get; set; }  

        public QuizSubmission QuizSubmission { get; set; }
        public Question Question { get; set; }
        public Answer Answer { get; set; }
    }
}
