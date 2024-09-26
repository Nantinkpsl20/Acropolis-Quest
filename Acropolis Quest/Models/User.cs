using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acropolis_Quest.Models
{
    public class User
    {
        public String fullname {get; set;}
        public String username {get; set;}
        public String password {get; set;}
        public String level {get; set;}

        List<QuizSubmission> quizSubmissions {get; set;}
    }
}
