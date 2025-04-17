using hotelManagement.Controller;
using hotelManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagement.Controller
{
    internal class customerController : IController
    {
            SqlConnection conn = connectDBS.getConnection();
            private List<IModel> _items;
            public List<IModel> Items => this._items;

            public customerController()
        {
        }

        public bool Load()
        {
            try
            {
                conn.Open();
                _items = new List<IModel>();

                string query = "SELECT * FROM Customer";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customerModel customerM = new customerModel(
                        reader["id"].ToString(),
                        reader["name"].ToString(),
                        reader["phone"].ToString(),
                        reader["email"].ToString(),
                        reader["address"].ToString(),
                        reader["city"].ToString(),
                        reader["id_card"].ToString()
                    );
                    _items.Add(customerM);
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
            customerModel customerM = (customerModel)model;

            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Customer WHERE id = '" + customerM.id + "'";
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
            customerModel customerM = (customerModel)model;
            try
            {
                conn.Open();
                string query = "INSERT INTO Customer (id, name, phone, email, address, city, id_card) VALUES ('" +
                               customerM.id + "', '" +
                               customerM.name + "', '" +
                               customerM.phone + "', '" +
                               customerM.email + "', '" +
                               customerM.address + "', '" +
                               customerM.city + "', '" +
                               customerM.id_card + "')";
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
            customerModel customerM = (customerModel)model;
            try
            {
                conn.Open();
                string query = "UPDATE Customer SET name = '" + customerM.name +
                               "', phone = '" + customerM.phone +
                               "', email = '" + customerM.email +
                               "', address = '" + customerM.address +
                               "', city = '" + customerM.city +
                               "', id_card = '" + customerM.id_card +
                               "' WHERE id = '" + customerM.id + "'";
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
            customerModel customerM = (customerModel)model;
            try
            {
                conn.Open();
                string query = "DELETE FROM Customer WHERE id = '" + customerM.id + "'";
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
