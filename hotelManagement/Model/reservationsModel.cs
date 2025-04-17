using hotelManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagement.Model
{
    internal class reservationsModel : IModel
    {
        public string id { get; set; }
        public customerModel customer_id { get; set; }
        public roomModel room_id  { get; set; }
        public DateTime check_in_date { get; set; }
        public DateTime check_out_date { get; set; }
        public string total_amount { get; set; }
        public employeeModel employee_id { get; set; }
        
        // Tạo thêm thuộc tính, để lấy giá trị từ customer
        public string CustomerID => customer_id?.id;
        public string roomID => room_id?.id;
        public string employeeID => employee_id?.id;
        public bool IsValidate()
        {
            return true;
        }

        public reservationsModel() { }
        // Constructor nhận 4 tham số
        public reservationsModel(string id, customerModel customer_id, roomModel room_id, DateTime check_in_date, DateTime check_out_date, string total_amount, employeeModel employee_id)
        {
            this.id = id;
            this.customer_id = customer_id;
            this.room_id = room_id;
            this.check_in_date = check_in_date;
            this.check_out_date = check_out_date;
            this.total_amount = total_amount;
            this.employee_id = employee_id;
       
        }
    }
}
