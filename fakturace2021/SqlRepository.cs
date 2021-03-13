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
        public string connString { get; set; }
        public SqlRepository(string connectionString)
        {
            connString = connectionString;
        }

        public List<Zakaznik> nactiZakazniky(string trideni,bool sestupne, string filter )
        {
            List<Zakaznik> zakaznici = new List<Zakaznik>();
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                {
                    sqlCommand.CommandText = $"select * from Zakaznici where Typzakaznika like @Filter order by {trideni}{(sestupne ? " desc" : "")}";
                    sqlCommand.Parameters.AddWithValue("Filter", "%" + filter + "%");
                    sqlConnection.Open();
                    
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            zakaznici.Add(new Zakaznik(Convert.ToInt32(sqlDataReader["IdZakaznici"]),
                                                   sqlDataReader["Nazev"].ToString(),
                                                   sqlDataReader["TypZakaznika"].ToString(),
                                                   sqlDataReader["Adresa"].ToString(),
                                                   Convert.ToInt32(sqlDataReader["Ico"]),
                                                   sqlDataReader["Email"].ToString(),
                                                   Convert.ToInt32(sqlDataReader["Telefon"])
                                                   ));
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return zakaznici;
        }

        public List<Zbozi> nactiZbozi(string trideni,bool sestupne,string filter)
        {
            List<Zbozi> zbozis = new List<Zbozi>();
            using(SqlConnection sqlConnection = new SqlConnection(connString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                {
                    sqlCommand.CommandText = $"select * from Zbozi where Nazev like @Filter order by {trideni}{(sestupne ? " desc" : "")}";
                    sqlCommand.Parameters.AddWithValue("Filter", "%" + filter + "%");
                    

                    sqlConnection.Open();
                    using(SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while(sqlDataReader.Read())
                        {
                            zbozis.Add(new Zbozi(Convert.ToInt32(sqlDataReader["IdZbozi"]),
                                                sqlDataReader["Nazev"].ToString(),
                                                Convert.ToInt32(sqlDataReader["cenaBezDph"]),
                                                Convert.ToBoolean(sqlDataReader["NaSklade"])                              
                                                )) ;
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return zbozis;
        }
    }
}
