using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagement.Model
{
    internal class employeeModel : IModel
    {
     

        public string id { get; set; }
        public string name { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string ID { get; internal set; }

        public bool IsValidate()
        {
            return true;
        }
        public employeeModel() { }
        public employeeModel(string id, string name, string userName, string password, string role)
        {
            this.id = id;
            this.name = name;
            this.userName = userName;
            this.password = password;
            this.role = role;
        }


    }
}
