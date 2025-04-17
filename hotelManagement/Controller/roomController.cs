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
    internal class roomController : IController
    {
        SqlConnection conn = connectDBS.getConnection();

        private List<IModel> _items;

        public List<IModel> Items => this._items;

        public roomController()
        {
        
        }

        public bool Load()
        {
            try
            {
                conn.Open();
                _items = new List<IModel>();
                string query = "SELECT * FROM Room";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roomModel roomM = new roomModel(
                        reader["id"].ToString(),
                        reader["room_type"].ToString(),
                        reader["price_per_night"].ToString(),
                        reader["capacity"].ToString(),
                        reader["status"].ToString()
                    );
                    _items.Add(roomM);
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
            roomModel roomM = (roomModel)model;

            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Room WHERE id = '" + roomM.id + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

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
            roomModel roomM = (roomModel)model;
            try
            {
                conn.Open();
                string query = "INSERT INTO Room (id, room_type, price_per_night, capacity,status) VALUES ('" +
                              roomM.id + "', '" +
                               roomM.room_type + "', '" +
                               roomM.price_per_night + "', '" +
                               roomM.capacity + "', '" +
                               roomM.status + "')";
                SqlCommand cmd = new SqlCommand(query, conn);

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
            roomModel roomM = (roomModel)model;
            try
            {
                conn.Open();
                string query = "UPDATE Room SET room_type = '" + roomM.room_type +
                               "', price_per_night = '" + roomM.price_per_night +
                               "', capacity = '" + roomM.capacity +
                               "', status = '" + roomM.status +
                               "' WHERE id = '" + roomM.id + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

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
            roomModel roomM = (roomModel)model;
            try
            {
                conn.Open();
                string query = "DELETE FROM Room WHERE id = '" + roomM.id + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

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
