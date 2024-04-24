using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using TESTER.Models;

namespace TESTER.Data
{
    public class LeaveRangesData
    {
        

        //METODO DE EJEMPLO PARA OBTENER TODOS LOS DATOS DE UNA TABLA.
        public List<LeaveRanges> GetListaAll()
        {

            List<LeaveRanges> lista = new List<LeaveRanges>();

            //PASO LA CONEXIÓN  
            using (SqlConnection conn = new SqlConnection("Data Source=172.16.10.239\\THESPIDERSERVER; Initial Catalog=TalentoHumano; user=Usuario1; pwd=Bioflex24#; trustServerCertificate=true"))
            {

                conn.Open();
                                                  //INSERTO LA CONSULTA Ó LLAMO EL PROCEDIMIENTO ALMACENADO CAPTURANDO EL NOMBRE ENTRE LAS COMILLAS ("")
                SqlCommand cmd = new SqlCommand("SELECT [Id] ,[Years] ,[Days] FROM [TalentoHumano].[BioFlex].[LeaveRanges]", conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {
                    //declaro variables que capturaran los datos de la consulta (arreglo)
                    int Id = dr.GetInt32(0);
                    int Years = dr.GetInt32(1);
                    int Days = dr.GetInt32(2);
                  



                    LeaveRanges listar = new LeaveRanges(

                         Id ,
                         Years ,
                         Days 
                           );

                    lista.Add(listar);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

    }
}
