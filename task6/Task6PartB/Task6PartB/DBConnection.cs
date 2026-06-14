using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;

namespace Task6PartB
{
    internal class DBConnection
    {
      
        string strCon = @"Data Source=IdanG\SQLEXPRESS01;Initial Catalog=D;Integrated Security=True;Trust Server Certificate=True";
        string strCmd;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adtr;
        DataSet ds;
        DataTable dt;

    
        public DBConnection()
        {
          con = new SqlConnection(strCon);
        }

       
        public DataTable ItemsTable()
        {
        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBItem", con);

        DataSet ds = new DataSet();

        da.Fill(ds, "TBItem");

        return ds.Tables["TBItems"];

        }
        public DataTable FilterByAbovePrice(int price)
        {
            SqlCommand cmd = new SqlCommand("P_Item_By_Above_Price", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@price", price);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "TBItems");

            return ds.Tables["TBItems"];
        }

        public DataTable InsertItem(Item item)
        {
            SqlCommand cmd = new SqlCommand(
        @"INSERT INTO TBItems
          (Name,Price,Description)
          VALUES
          (@name,@price,@description)", con);

            cmd.Parameters.AddWithValue("@name", item.Name);
            cmd.Parameters.AddWithValue("@price", item.Price);
            cmd.Parameters.AddWithValue("@description",item.Description);
            con.Open();
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            if (rows > 0)
                return ItemsTable();
            return null;

        }
        public DataTable DeleteItem(int code)
        {
            SqlCommand cmd =
             new SqlCommand(
             "DELETE FROM TBItems WHERE Code=@code",
             con);

            cmd.Parameters.AddWithValue("@code", code);

            con.Open();

            int rows = cmd.ExecuteNonQuery();

            con.Close();

            if (rows > 0)
                return ItemsTable();

            return null;
        }
    
        public void UpdateDB(DataTable table)
        {
            string cmd = "SELECT * FROM tbUser";
            SqlDataAdapter adptr = new SqlDataAdapter(cmd, con);
            SqlCommandBuilder comb = new SqlCommandBuilder(adptr);
            adptr.Update(table); 
        }
    }
}
