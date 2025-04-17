﻿using hotelManagement.Controller;
using hotelManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagement.Controller
{
    internal class employeeController : IController
    {
        SqlConnection conn = connectDBS.getConnection();

        private List<IModel> _items;

        public List<IModel> Items => this._items;

        public employeeController()
        {
       
        }

        public bool Load()
        {
            try
            {
                conn.Open();
                _items = new List<IModel>();

                string query = "SELECT * FROM Employee";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    employeeModel employeeM = new employeeModel(

                        reader["id"].ToString(),
                        reader["name"].ToString(),
                        reader["userName"].ToString(),
                        reader["password"].ToString(),
                        reader["role"].ToString()
                    );
                    _items.Add(employeeM);
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
            employeeModel employeeM = (employeeModel)model;

            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Employee WHERE id = '" + employeeM.id + "'";
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
            employeeModel employeeM = (employeeModel)model;
            try
            {
                conn.Open();
                string query = "INSERT INTO Employee (id, name, userName, password, role) VALUES ('" +
                               employeeM.id + "', '" +
                               employeeM.name + "', '" +
                               employeeM.userName + "', '" +
                               employeeM.password + "', '" +
                               employeeM.role + "')";
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
            employeeModel employeeM = (employeeModel)model;
            try
            {
                conn.Open();
                string query = "UPDATE Employee SET name = '" + employeeM.name +
                               "', userName = '" + employeeM.userName +
                               "', password = '" + employeeM.password +
                               "', role = '" + employeeM.role +
                               "' WHERE id = '" + employeeM.id + "'";
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
            employeeModel employeeM = (employeeModel)model;
            try
            {
                conn.Open();
                string query = "DELETE FROM Employee WHERE id = '" + employeeM.id + "'";
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
