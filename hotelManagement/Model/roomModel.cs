using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagement.Model
{

        internal class roomModel : IModel
        {
        internal roomModel room_id;

        public string id { get; set; }
            public string room_type { get; set; }
            public string price_per_night { get; set; }
            public string capacity { get; set; }

            public string status { get; set; }

            public bool IsValidate()
            {
                return true;
            }
            public roomModel() { }
            public roomModel(string id, string room_type, string price_per_night, string capacity, string status)
            {
                this.id = id;
                this.room_type = room_type;
                this.price_per_night = price_per_night;
                this.capacity = capacity;
                this.status = status;
            }
        }
    
}