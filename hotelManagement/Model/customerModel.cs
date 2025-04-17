using hotelManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagement.Model
{
    internal class customerModel : IModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string id_card { get; set; }
        public bool IsValidate()
        {
            return true;
        }
        public customerModel() { }
        // Constructor nhận 4 tham số
        public customerModel(string id, string name, string phone, string email, string address, string city, string id_card )
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.city = city;
            this.id_card = id_card;
        }
    }
}
