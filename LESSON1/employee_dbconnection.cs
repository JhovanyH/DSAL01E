using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON1
{
    internal class employee_dbconnection
    {
        public string employee_connectionString = null;
        public SqlConnection employee_sql_connection;
        public SqlCommand employee_sql_command;
        public DataSet employee_sql_dataset;
        public SqlDataAdapter employee_sql_dataadapter;
        public string employee_sql = null;

        public void employee_connString()
        {
            employee_sql_connection = new SqlConnection();
            //employee_connectionString = "Data Source = C203-36; Initial Catalog = SampleDB; user id = SA; password = B1Admin123@";
            employee_connectionString = "Data Source = LAPTOP-8COQ8R8Q\\SQLEXPRESS; Initial Catalog = POSDB; trusted_connection = True";
            employee_sql_connection = new SqlConnection(employee_connectionString);
            employee_sql_connection.ConnectionString = employee_connectionString;
            employee_sql_connection.Open();

        }
        public void employee_cmd()
        {
            employee_sql_command = new SqlCommand(employee_sql, employee_sql_connection);
            employee_sql_command.CommandType = CommandType.Text;
        }

        public void employee_sqladapterSelect()
        {
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.SelectCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqladapterInsert()
        {
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.InsertCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqladapterDelete()
        {
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.DeleteCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqladapterUpdate()
        {
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.UpdateCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqldatasetSELECT()
        {
            employee_sql_dataset = new DataSet();
            employee_sql_dataadapter.Fill(employee_sql_dataset, "pos_empRegTbl");
        }


    }
}