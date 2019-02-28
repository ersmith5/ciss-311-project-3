using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciss_311_project_3
{
    class FacultyBorrower : Borrower
    {
        public FacultyBorrower(int id, string first_name, string last_name) : base(id, first_name, last_name, "Faculty", 3)
        {
            //
        }
    }
}
