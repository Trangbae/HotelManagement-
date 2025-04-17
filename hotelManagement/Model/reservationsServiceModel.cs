using hotelManagement.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hotelManagement.Model
{
    internal class reservationsServiceModel : IModel
    {


        public reservationsModel reservation_id { get; set; }
        public serviceModel service_id { get; set; }
        public string quantity { get; set; }


        // Tạo thêm thuộc tính, để lấy giá trị
        public string reservationsID => reservation_id?.id;
        public string serviceID => service_id?.id;

        public bool IsValidate()
        {
            return true;
        }
        //public reservationsServiceModel(reservationsModel reservationsModel, serviceModel serviceModel) { }
        public reservationsServiceModel(reservationsModel reservation_id, serviceModel service_id, string quantity)
        {
            this.reservation_id = reservation_id;
            this.service_id = service_id;
            this.quantity = quantity;
           

        }

        public reservationsServiceModel()
        {
        }
    }

}
