using hotelManagement.Controller;
using hotelManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagement.Controller
{
    internal class reservationsController : IController
    {
        private readonly SqlConnection conn = connectDBS.getConnection();
        private List<IModel> _items;

        public List<IModel> Items => _items;

        public reservationsController()
        {
            _items = new List<IModel>();
        }

        public bool Load()
        {
            try
            {
                conn.Open();
                _items = new List<IModel>();

                // Fixed JOIN query syntax
                string query = @"
                    SELECT 
                        Reservations.id AS reservationsID,
                        Customer.id AS customerID,
                        Room.id AS roomID,
                        Reservations.check_in_date, 
                        Reservations.check_out_date,
                        Reservations.total_amount,
                        Employee.id AS employeeID
                    FROM 
                        Reservations
                    JOIN 
                        Customer ON Reservations.customer_id = Customer.id
                    JOIN 
                        Room ON Reservations.room_id = Room.id
                    JOIN 
                        Employee ON Reservations.employee_id = Employee.id";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Create instances of associated models
                    customerModel customer = new customerModel
                    {
                        id = reader["customerID"].ToString(),
                    };

                    roomModel room = new roomModel
                    {
                        id = reader["roomID"].ToString(),
                    };

                    employeeModel employee = new employeeModel
                    {
                        id = reader["employeeID"].ToString(),
                    };

                    // Create reservation model and populate list
                    reservationsModel reservations = new reservationsModel
                    {
                        id = reader["reservationsID"].ToString(),
                        customer_id = customer,
                        room_id = room,
                        check_in_date = Convert.ToDateTime(reader["check_in_date"]),
                        check_out_date = Convert.ToDateTime(reader["check_out_date"]),
                        total_amount = reader["total_amount"].ToString(),
                        employee_id = employee
                    };

                    _items.Add(reservations);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool IsExist(object model)
        {
            reservationsModel reservationsM = (reservationsModel)model;

            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Reservations WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", reservationsM.id);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Create(IModel model)
        {
            reservationsModel reservationsM = (reservationsModel)model;

            try
            {
                conn.Open();

                string query = @"
                    INSERT INTO Reservations 
                        (id, customer_id, room_id, check_in_date, check_out_date, total_amount, employee_id) 
                    VALUES 
                        (@id, @customer_id, @room_id, @check_in_date, @check_out_date, @total_amount, @employee_id)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", reservationsM.id);
                cmd.Parameters.AddWithValue("@customer_id", reservationsM.customer_id.id);
                cmd.Parameters.AddWithValue("@room_id", reservationsM.room_id.id);
                cmd.Parameters.AddWithValue("@check_in_date", reservationsM.check_in_date);
                cmd.Parameters.AddWithValue("@check_out_date", reservationsM.check_out_date);
                cmd.Parameters.AddWithValue("@total_amount", reservationsM.total_amount);
                cmd.Parameters.AddWithValue("@employee_id", reservationsM.employee_id.id);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Update(IModel model)
        {
            reservationsModel reservationsM = (reservationsModel)model;

            try
            {
                conn.Open();

                string query = @"
                    UPDATE Reservations 
                    SET 
                        customer_id = @customer_id,
                        room_id = @room_id,
                        check_in_date = @check_in_date,
                        check_out_date = @check_out_date,
                        total_amount = @total_amount,
                        employee_id = @employee_id
                    WHERE id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", reservationsM.id);
                cmd.Parameters.AddWithValue("@customer_id", reservationsM.customer_id.id);
                cmd.Parameters.AddWithValue("@room_id", reservationsM.room_id.id);
                cmd.Parameters.AddWithValue("@check_in_date", reservationsM.check_in_date);
                cmd.Parameters.AddWithValue("@check_out_date", reservationsM.check_out_date);
                cmd.Parameters.AddWithValue("@total_amount", reservationsM.total_amount);
                cmd.Parameters.AddWithValue("@employee_id", reservationsM.employee_id.id);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Delete(IModel model)
        {
            reservationsModel reservationsM = (reservationsModel)model;

            try
            {
                conn.Open();
                string query = "DELETE FROM Reservations WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", reservationsM.id);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Load(object id)
        {
            throw new NotImplementedException();
        }

        public IModel Read(object id)
        {
            throw new NotImplementedException();
        }
    }
}
