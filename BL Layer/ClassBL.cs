using DAL_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Layer
{
    public class ClassBL
    {
        ClassDAL dal = new ClassDAL();//generate a ClassDAL class to access list in ClassDAL
        public List<string> GetCustomer_BLL()//public function to consume the list that was created inside ClassDAL
        {
            var lst = dal.GetCustomer_DAL();//consume list inside ClassDAL
            return GetCustomer_BLL();//return list for HomeController usage
        }
    }
}
