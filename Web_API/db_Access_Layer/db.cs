using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Web_API.Models;

namespace Web_API.db_Access_Layer
{
    public class db
    {
        /// <summary>The con</summary>
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        /// <summary>Adds the points.</summary>
        /// <param name="ponit">The ponit.</param>
        public void addPoints(Points ponit)
        {
            SqlCommand com = new SqlCommand("post_UserPointsId", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@userName_", ponit.User_Id);
            com.Parameters.AddWithValue("@date_", DateTime.Now.Date);
            com.Parameters.AddWithValue("@points_", ponit.Quantity_Points);
            com.Parameters.AddWithValue("@TypePoint_", ponit.TyPo_Id);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}