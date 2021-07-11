using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Projekt3
{
    class dbconnect
    {
        SqlConnection connection;
        public dbconnect()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DOME-PC\\MSSQLSERVER01";
            builder.UserID = "dominik";
            builder.Password = "Dopechillz1602102";
            builder.InitialCatalog = "projekt3";
            connection = new SqlConnection(builder.ConnectionString);
        }

        internal void dbwrite(string sql, Dictionary<string, object> parameters = null)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                if (parameters != null)
                {
                    foreach (var item in parameters)
                    {
                        command.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("" + e);
            }
            finally
            {
                connection.Close();
            }
        }

        internal DataSet dbread(string sql, Dictionary<string, object> parameters = null)
        {
            DataSet result = new DataSet();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                if (parameters != null)
                {
                    foreach (var item in parameters)
                    {
                        command.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }
                SqlDataAdapter data = new SqlDataAdapter(command);
                data.Fill(result);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("" + e);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
    }
}
