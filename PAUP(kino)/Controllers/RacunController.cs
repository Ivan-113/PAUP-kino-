using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PAUP_kino_.Models;
using System.Data.SqlClient;

namespace PAUP_kino_.Controllers
{
    public class RacunController : Controller
    {

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Racun
        [HttpGet]

      public ActionResult Index() 
        {
            return View();
        }
        public ActionResult Prijava()
        {
            return View();
        }

        void povezivanjeSBazom() 
        {
            con.ConnectionString = "data source=potrebno unijeti source baze;database=WPF; integrated security=SSPI;";
        
        }
        [HttpPost]
        public ActionResult Potvrda(Racun rac)
        {
            povezivanjeSBazom();
            con.Open();
            com.Connection = con;
            com.CommandText = "Potrebno unijeti putanju baze ";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                con.Close();
                return View("UspjesnaPrijava");
            }
            else
            {
                con.Close();
                return View("Error");
            }
      
           
        }

       
    }
}