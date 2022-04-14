using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Layer
{
    public partial class ClassDAL
    {
        public List<string> GetCustomer_DAL()//public function to create a list
        {
            var list = new List<string>();//create a list
            return list;//return the list for ClassBL useage
        }
    }
}
