using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            float d = 91.5f;
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);

        }
    }
}
