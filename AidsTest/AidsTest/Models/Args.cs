using System;
using System.Collections.Generic;
using System.Text;

namespace AidsTest.Models
{
    class Args
    {
       public Question question { get; set; }
       public Answer answer { get; set; }

        public Args(Question qu, Answer an)
        {
            question = qu;
            answer = an;
        }
    }
}
