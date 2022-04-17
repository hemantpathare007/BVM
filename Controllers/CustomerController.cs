using BVM.Models;
using BVM.Models.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BVM.Controllers
{
    public class CustomerController : Controller
    {
        string cons = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        // GET: Customer
        public ActionResult ViewCustomers()
        {
            return View();
        }

        public ActionResult AddCustomers()
        {
            

            return View();
        }
        [HttpPost]
        public ActionResult AddCustomers(Customers  customer)
        {
            SqlConnection con = new SqlConnection(cons);
            SqlCommand cmd = new SqlCommand(StoredProcedures.USP_CRUD_CUSTOMERS, con);
            RootObject rootObject = new RootObject();
            rootObject.OPERATION = "CREATE";
            rootObject.SENDERID = "ADMIN";
            rootObject.VALUES.Add(customer);
            string data = JsonConvert.SerializeObject(rootObject);
            cmd.Parameters.AddWithValue("@JSON",data);
            cmd.CommandType = CommandType.StoredProcedure;
            
            con.Open();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return View();
        }
    }
}