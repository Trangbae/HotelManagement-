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
    internal class serviceController : IController
    {
        SqlConnection conn = connectDBS.getConnection();

        private List<IModel> _items;

        public List<IModel> Items => this._items;

        //public serviceController()
        //{
        //    _items = new List<IModel>();
        //}

        public bool Load()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Serviceb";
                SqlCommand cmd = new SqlCommand(query, conn);
                _items = new List<IModel>();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    serviceModel serviceM = new serviceModel(
                        reader["id"].ToString(),
                        reader["name"].ToString(),
                        reader["description"].ToString(),
                        reader["price"].ToString()

                    );
                    _items.Add(serviceM);
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
            serviceModel serviceM = (serviceModel)model;

            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Serviceb WHERE id = '" + serviceM.id + "'";
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
            serviceModel serviceM = (serviceModel)model;
            try
            {
                conn.Open();
                string query = "INSERT INTO Serviceb (id, name, description, price) VALUES ('" +
                               serviceM.id + "', '" +
                               serviceM.name + "', '" +
                               serviceM.description + "', '" +

                               serviceM.price + "')";
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
            serviceModel serviceM = (serviceModel)model;
            try
            {
                conn.Open();
                string query = "UPDATE Serviceb SET name = '" + serviceM.name +
                               "', description = '" + serviceM.description +
                               "', price = '" + serviceM.price +
                              
                               "' WHERE id = '" + serviceM.id + "'";
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
            serviceModel serviceM = (serviceModel)model;
            try
            {
                conn.Open();
                string query = "DELETE FROM serviceb WHERE id = '" + serviceM.id + "'";
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
