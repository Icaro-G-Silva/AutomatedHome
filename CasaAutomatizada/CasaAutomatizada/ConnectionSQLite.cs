using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace CasaAutomatizada
{
    class ConnectionSQLite
    {

        public SQLiteConnection connection;
        public ConnectionSQLite()
        {
            connection = new SQLiteConnection("Data Source=CasaAutomatizada.sqlite");
        }

        public void connect()
        {
            this.connection.Open();
        }

        public void disconnect()
        {
            this.connection.Close();
        }

        public DataTable getData()
        {
            const string query = "SELECT * FROM Instrucoes;";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, this.connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

    }
}
