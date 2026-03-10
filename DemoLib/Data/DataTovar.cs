using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLib.Repository;
using Npgsql;
using DemoLib.Tovars;
using DemoLib.Data;



namespace DemoLib.Data
{
    public class DataTovar : TovarRepository
    {
        string connectionString = "Host=192.168.1.48; Port=5432; Username=st50-7; Password=507; Database=demoEX";

        public List<Tovar> GetAllTovars()
        {
            List<Tovar> tovars = new List<Tovar>();
            
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string readSql = "SELECT * FROM tovar";
                NpgsqlCommand command = new NpgsqlCommand(readSql, connection);

                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tovar tovar = new Tovar(reader.GetString(0));


                        tovar.tovar_name = reader.GetString(1);
                        tovar.price = reader.GetInt32(3);
                        tovar.count = reader.GetInt32(8);
                        tovar.tovar_category = reader.GetString(6);
                        tovar.postavshik = reader.GetString(4);
                        tovar.proizvoditel = reader.GetString(5);
                        tovar.opisanie = reader.GetString(9);
                        tovar.skidka = reader.GetInt32(7);                 
                        tovar.edinitsa_izmere = reader.GetString(2);
                        tovars.Add(tovar);
                        tovar.photo = reader.IsDBNull(10) ? "" : reader.GetString(9);




                    }
                }

            }
            return tovars;
        }
        


    }
}
