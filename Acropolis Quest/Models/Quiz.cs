using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acropolis_Quest.Models
{
    public class Quiz
    {
        public int quizId { get; set; }
        public String Title { get; set; }

        public List<Question> questions { get; set; }
    }
}
