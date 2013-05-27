using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication5
{
    class ADOTest
    {
        private SqlConnection con = null;
        
        private string constr = "Driver={SQLServer};Server=your_server_name;" +
        "Database=your_database_name;Uid=your_username;Pwd=your_password;";
        public string SqlTest(string SQLQuery)
        {
            SqlConnectionStringBuilder conbuilder = new SqlConnectionStringBuilder();
            conbuilder["Data Source"] = "(local)";
            conbuilder["Initial Catalog"] = "AdventureWorks";
            conbuilder["Integrated Security"] = true;
            conbuilder["Trusted_Connection"] = true;
            
            MessageBox.Show(conbuilder.ConnectionString);
            try
            {
                SqlConnection sqlcon = new SqlConnection(conbuilder.ConnectionString);
                sqlcon.Open();
                SqlDataReader sqlrd = null;
                SqlCommand sqlcommand = new SqlCommand(SQLQuery, sqlcon);
                //sqlrd = sqlcommand.ExecuteReader();   
                SqlDataAdapter sqladap = new SqlDataAdapter("Select * from HumanResources.Department", sqlcon);
               /* while(sqlrd.Read())
                {
                    MessageBox.Show(sqlrd["Column1"].ToString());
                }*/

                
                System.Data.DataTable dt = new System.Data.DataTable();
                sqladap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    
                    //for (int j = 0; j < dt.Columns.Count; j++)
                    //{
                    //    DataColumn col = dt.Columns[j];
                    //    MessageBox.Show(row[col.ColumnName].ToString());
                    //    //MessageBox.Show(col.ColumnName);
                    //}
                }

            }
            catch(Exception e)
            {
                MessageBox.Show("Error in connection : " + e.Message);

            }
            return conbuilder.ConnectionString;
        }

        
    }
}
