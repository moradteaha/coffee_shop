﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using coffee_shop.Models;
namespace coffee_shop.viewmodels
{
    public class ViewProductModel
    {
        public product myprod { get; set; }
        public List<product> products { get; set; }

        
        public void updateprice(product prod ) {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDal"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString)) {

                SqlCommand cmd = new SqlCommand("updateandswapPrice", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                decimal oldprice = prod.productPrice;


                SqlParameter parampId = new SqlParameter();
                parampId.ParameterName = "@Id";
                parampId.Value = prod.productId;
                cmd.Parameters.Add(parampId);

           
                SqlParameter newPricee = new SqlParameter();
                newPricee.ParameterName = "@newPrice";
                newPricee.Value = prod.productPrice;
                cmd.Parameters.Add(newPricee);


                con.Open();
                cmd.ExecuteNonQuery();

            }
        
        }
    }
}