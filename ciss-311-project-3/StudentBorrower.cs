using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciss_311_project_3
{
    class StudentBorrower : Borrower
    {
        public StudentBorrower(string first_name, string last_name) : base (first_name, last_name, "Student", 2)
        {
            //
        }
    }
}
