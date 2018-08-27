using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//libraries for db con
using System.Data;
using System.Data.SqlClient;
//define namespace for webconfig
using System.Configuration;

namespace Demolab2
{
    public class Datos
    {
        //define the connection to tecsup
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["tecsup"].ConnectionString);
        //list the providers
        public DataTable ListaProveedores()
        {
            //do read & destroy requirements
            using (SqlDataAdapter da = new SqlDataAdapter("usp_listaProveedores", cn))
            {
                //object read
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    //fill dataTable
                    da.Fill(dt);
                    return dt;
                }

            }
        }

        public DataTable ListaPaises()
        {
            //do read & destroy requirements
            using (SqlDataAdapter da = new SqlDataAdapter("usp_listapais", cn))
            {
                //object read
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    //fill dataTable
                    da.Fill(dt);
                    return dt;
                }

            }
        }
        //client by country list
        public DataTable ListaClientesPais(string p)
        {
            //do read & destroy requirements
            using (SqlDataAdapter da = new SqlDataAdapter("usp_ListaClientesPais", cn))
            {
                //object read
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //add param
                da.SelectCommand.Parameters.AddWithValue("@pais", p);
                using (DataTable dt = new DataTable())
                {
                    //fill dataTable
                    da.Fill(dt);
                    return dt;
                }

            }
        }


    }
}