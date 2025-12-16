using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON1
{
    internal class pos_dbconnection
    {
        public string pos_connectionString = null;
        public SqlConnection pos_sql_connection;
        public SqlCommand pos_sql_command;
        public DataSet pos_sql_dataset;
        public SqlDataAdapter pos_sql_dataadapter;
        public string pos_sql = null;

    public void pos_connString()
        {
            pos_sql_connection = new SqlConnection();
            //pos_connectionString = "Data Source = C203-36; Initial Catalog = SampleDB; user id = SA; password = B1Admin123@";
            pos_connectionString = "Data Source = LAPTOP-8COQ8R8Q\\SQLEXPRESS; Initial Catalog = POSDB; trusted_connection = True";
            pos_sql_connection = new SqlConnection(pos_connectionString);
            pos_sql_connection.ConnectionString = pos_connectionString;
            pos_sql_connection.Open();
        }

    public void pos_cmd()
        {
            pos_sql_command = new SqlCommand(pos_sql, pos_sql_connection);
            pos_sql_command.CommandType = CommandType.Text;
        }

    public void pos_sqladapterSelect()
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.SelectCommand = pos_sql_command;
           
        }
    public void pos_sqladapterInsert()
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.InsertCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }
    public void pos_sqladapterDelete()
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.DeleteCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }
    public void pos_sqladapterUpdate()
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.UpdateCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }
    public void pos_sqldatasetSELECT()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "pos_nameTbl");

        }
    public void pos_sqldatasetSELECTSALES()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "salesTbl");
        }
    public void pos_select()
        {
            pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id";
                
        }
    public void pos_select_cashier()
        {
            pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id " + 
               "WHERE pos_nameTbl.pos_id = 2";
        }
    public void pos_select_cashier1()
        {
            pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id " + 
               "WHERE pos_nameTbl.pos_id = 2";
        }
    public void pos_select_cashier_display(string terminalNo = "1")
        {
       // FIXED: Use LIKE to match both 'Cashier1' and 'Cashier2'
        pos_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_surname, " +
        "pos_terminal_no, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl " +
        "ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE account_type LIKE '%Cashier%' AND pos_terminal_no = '" + terminalNo + "'";
        }
    public void pos_select_cashier_SELECTdisplay()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadapter = new SqlDataAdapter(pos_sql, pos_sql_connection);
            pos_sql_dataadapter.Fill(pos_sql_dataset, "pos_empRegTbl");
        }

    public void pos_add_param(string paramName, object paramValue)
        {
            // This checks if the command is ready, then adds the data safely
            if (pos_sql_command != null)
            {
                // If the value is null, we send DBNull, otherwise we send the value
                pos_sql_command.Parameters.AddWithValue(paramName, paramValue ?? DBNull.Value);
            }
        }
    }
    
}
