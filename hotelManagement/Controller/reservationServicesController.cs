using hotelManagement.Controller;
using hotelManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotelManagement.Controller
{
    internal class reservationServicesController : IController
    {
        private SqlConnection conn = connectDBS.getConnection();
        private List<IModel> _items;

        public List<IModel> Items => _items;

        public reservationServicesController()
        {
            _items = new List<IModel>();
        }

        public bool Load()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Reservation_Service";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var reservationService = new reservationsServiceModel
                    {
                        reservation_id = new reservationsModel { id = reader["reservation_id"].ToString() },
                        service_id = new serviceModel { id = reader["serviceb_id"].ToString() },
                        quantity = reader["quantity"].ToString()
                    };

                    _items.Add(reservationService);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool IsExist(object model)
        {
            var reservationService = (reservationsServiceModel)model;
            
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) as count FROM Reservation_Service WHERE reservation_id = 1 AND serviceb_id = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
               //// cmd.Parameters.AddWithValue("@reservation_id", reservationService.reservation_id);
               // cmd.Parameters.AddWithValue("@serviceb_id", reservationService.serviceb_id);
               // Console.Write(cmd);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking existence: {ex.Message}");
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

       

        public bool Create(IModel model)
        {
            var reservationService = (reservationsServiceModel)model;

            try
            {
                conn.Open();
                string query = @"INSERT INTO Reservation_Service (reservation_id, serviceb_id, quantity) 
                                 VALUES (@reservation_id, @serviceb_id, @quantity)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@reservation_id", reservationService.reservation_id);
                cmd.Parameters.AddWithValue("@serviceb_id", reservationService.service_id);
                cmd.Parameters.AddWithValue("@quantity", reservationService.quantity);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating record: {ex.Message}");
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Update(IModel model)
        {
            var reservationService = (reservationsServiceModel)model;

            try
            {
                conn.Open();
                string query = @"UPDATE Reservation_Service
                                 SET quantity = @quantity 
                                 WHERE reservation_id = @reservation_id AND serviceb_id = @serviceb_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@quantity", reservationService.quantity);
                cmd.Parameters.AddWithValue("@reservation_id", reservationService.reservation_id.id);
                cmd.Parameters.AddWithValue("@serviceb_id", reservationService.service_id.id);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating record: {ex.Message}");
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Delete(IModel model)
        {
            var reservationService = (reservationsServiceModel)model;

            try
            {
                conn.Open();
                string query = @"DELETE FROM Reservation_Service
                                 WHERE reservation_id = @reservation_id AND serviceb_id = @serviceb_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@reservation_id", reservationService.reservation_id.id);
                cmd.Parameters.AddWithValue("@serviceb_id", reservationService.service_id.id);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}");
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
