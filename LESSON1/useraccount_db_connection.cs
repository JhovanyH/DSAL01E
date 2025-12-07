using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON1
{
    internal class useraccount_db_connection
    {
        // Declaration of variables for database connections and queries
        public String useraccount_connectionString = null;
        public SqlConnection useraccount_sql_connection;
        public SqlCommand useraccount_sql_command;
        public DataSet useraccount_sql_dataset;
        public SqlDataAdapter useraccount_sql_dataadapter;
        public string useraccount_sql = null; // This likely holds your query string

        public void useraccount_connString()
        {
            // Codes to establish connection from C# forms to the SQL Server database
            // NOTE: Ideally, credentials should not be hardcoded in the code for security.
            useraccount_sql_connection = new SqlConnection();
            useraccount_connectionString = "Data Source = LAPTOP-8COQ8R8Q\\SQLEXPRESS; Initial Catalog = POSDB; trusted_connection = True";

            useraccount_sql_connection = new SqlConnection(useraccount_connectionString);
            useraccount_sql_connection.ConnectionString = useraccount_connectionString;
            useraccount_sql_connection.Open();
        }
        public void useraccount_cmd() // Public function codes that support the mssql query
        {
            useraccount_sql_command = new SqlCommand(useraccount_sql, useraccount_sql_connection);
            useraccount_sql_command.CommandType = CommandType.Text;
        }

        public void useraccount_sqladapterSelect() // Mediating between C# and MSSQL SELECT
        {
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.SelectCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqladapterInsert() // Mediating between C# and MSSQL INSERT
        {
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.InsertCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqladapterDelete() // Mediating between C# and MSSQL DELETE
        {
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.DeleteCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqladapterUpdate() // Mediating between C# and MSSQL UPDATE
        {
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.UpdateCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqldatasetSELECT() // Mirroring contents inside MSSQL to C#
        {
            useraccount_sql_dataset = new DataSet();
            // Assuming "pos_empRegTbl" is the table name in your database
            useraccount_sql_dataadapter.Fill(useraccount_sql_dataset, "pos_empRegTbl");
        }

        public void useraccount_sqldatasetSELECT_Account() // Mirroring useraccountTbl
        {
            useraccount_sql_dataset = new DataSet();
            useraccount_sql_dataadapter.Fill(useraccount_sql_dataset, "useraccountTbl");
        }
    
}
}
