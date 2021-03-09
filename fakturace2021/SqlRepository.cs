using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace fakturace2021
{
    public class SqlRepository
    {
        public string ConnString { get; set; }
        public SqlRepository(string connectionString)
        {
            ConnString = connectionString;
        }

        public List<Zakaznik> nactiZakazniky(string trideni,bool sestupne, string filter )
        {
            List<Zakaznik> zakaznici = new List<Zakaznik>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                {
                    sqlCommand.CommandText = $"select * from Zakaznici where Typzakaznika like @Filtr order by {trideni}{(sestupne ? " desc" : "")}";
                    sqlCommand.Parameters.AddWithValue("Filtr", "%" + filter + "%");
                    sqlConnection.Open();
                    //jmeno like @Hledani or prijmeni like @Hledani 
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            zakaznici.Add(new Zakaznik(Convert.ToInt32(dataReader["IdZakaznici"]),
                                                   dataReader["Nazev"].ToString(),
                                                   dataReader["TypZakaznika"].ToString(),
                                                   dataReader["Adresa"].ToString(),
                                                   Convert.ToInt32(dataReader["Ico"]),
                                                   dataReader["Email"].ToString(),
                                                   Convert.ToInt32(dataReader["Telefon"])
                                                  ));
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return zakaznici;
        }
    }
}
