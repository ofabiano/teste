using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_BD.Pages
{
    public class IndexModel : PageModel
    {
        public List<string> Messages { get; set; }
        public string EnvironmentData1 { get; set; }
        public string EnvironmentData2 { get; set; }
        public void OnGet()
        {
            EnvironmentData1 = Environment.GetEnvironmentVariable("PATH");
            EnvironmentData2 = Environment.GetEnvironmentVariable("XPTO");

            Messages = new List<string>();
            string connectionString = "Server=CPCLSSQL02\\DEVQA;Database=PortalColeta;User Id=appColeta;Password=appColetadev;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT TOP 10 * FROM TB_FRETE", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Messages.Add(reader["nm_frete"].ToString());
                    }
                }
                connection.Close();
            }
        }
    }
}
