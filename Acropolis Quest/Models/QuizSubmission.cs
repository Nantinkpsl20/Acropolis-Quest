using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acropolis_Quest.Models
{
    public class QuizSubmission
    {
        public int submissionId { get; set; }
        public int username { get; set; }
        public int quizId { get; set; }
        public int score { get; set; }
        public DateTime submittedAt { get; set; }
        
        public User User { get; set; }
        public Quiz Quiz { get; set; }
        public List<UserAnswer> userAswers { get; set; }
    }
}
