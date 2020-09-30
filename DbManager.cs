using System;
using Npgsql;

namespace database.manager {
    public class DbManager {

        public string ConnectionString { get; set; }
        public NpgsqlConnection Connection { get; set; }

        public DbManager () {
            this.ConnectionString = "Host=127.0.0.1;Username=postgres;Password=postgres;Database=postgres";
            this.Connection = new NpgsqlConnection (this.ConnectionString);
            this.Connect ();
        }

        public void Connect () => this.Connection.Open ();

        public void INSERTINTOMENU (int weekday, string name, string ingredients, int price, int restaurantId) {

            var sql = $"INSERT INTO MENU (WEEKDAY, MENU_NAME, INGREDIENTS, PRICE, RESTAURANT_ID) VALUES ({weekday}, '{name}', '{ingredients}', {price}, {restaurantId})";

            System.Console.WriteLine (sql);

            var cmd = new NpgsqlCommand (sql, this.Connection);

            /* var result =  */cmd.ExecuteScalar ()/* .ToString () */;
/* 
            System.Console.WriteLine ("RESULTAS: " + result); */
        }

    }
}