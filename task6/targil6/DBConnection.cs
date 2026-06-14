using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil6
{
    class DBConnection
    {
        string stc = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBTargil7;Integrated Security=True;Encrypt=False";
        string strCmd;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public DBConnection()
        {
            con = new SqlConnection(stc);

        }
        public string ReadItemsTable()
        {
            string res = "";
            cmd.CommandText = "SELECT * " +
                  "FROM TB_ITEM ";
            cmd.Connection.Open();
            reader= cmd.ExecuteReader();
            while (reader.Read())
            {
                res+=
                    reader["Code"].ToString() + " --- " +
                    reader["Name"].ToString() + " --- " +
                    reader["Price"].ToString() + " --- " +
                    reader["Description"].ToString() + "\n";
            }
            cmd.Connection.Close();
            return res;

        }
        public int AddItemToDB(Item item)
        {
            cmd.CommandText= "INSERT INTO TB_ITEM (Code, Name, Price, Description) "+
                $"VALUES ( '{item.id}' , '{item.name}' , '{item.price}' , '{item.description}' )";
            cmd.Connection.Open();
            int res = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return res;
        }
        public int DeleteItemFromDB(int code)
        {
            cmd.CommandText = "DELETE FROM DB_ITEM " +
                $"WHERE Code ='{code}' ";
            cmd.Connection.Open();
            int res = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return res;
        }
    }
}
