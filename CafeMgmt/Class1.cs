﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMgmt
{
       
        public class Class1
        {
            private readonly string connectionString = "Data Source=DESKTOP-5MTJMJG\\SQLEXPRESS;" + "Initial Catalog=Spotify;" + "Integrated Security=SSPI;";

            public DataTable ExecuteQuery(string query)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        return table;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

            public int ExecuteNonQuery(string query)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);
                        return cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    
}
