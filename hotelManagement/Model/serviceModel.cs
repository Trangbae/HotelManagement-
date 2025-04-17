using hotelManagement.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagement.Model
{
    internal class serviceModel : IModel
    {


        public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string price { get; set; }

          

            public bool IsValidate()
            {
                return true;
            }

        internal static Reservations? GetReservationById(object? reservationId)
        {
            throw new NotImplementedException();
        }

        public serviceModel() { }
            public serviceModel(string id, string name, string description, string price)
            {
                this.id = id;
                this.name = name;
                this.description = description;
                this.price = price;
                
            }


        
    }

    }