using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kunstbryan
{
    internal class dbConnectie
    {
        private OleDbConnection connection;

        public dbConnectie()
        {
            String pad;
            String provider;
            String applicatiePad;
            String connectionString;

            provider = "Provider=Microsoft.ACE.OLEDB.12.0"; //voor een accdb-database.

            applicatiePad = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\"));
            pad = "Data Source=C:/Users/Janssensj/Desktop/Kunst/HetVrijeWoordKunstGenerator/HetVrijeWoordDB.accdb";

            connectionString = provider + ";" + pad;
            connection = new OleDbConnection(connectionString);
        }

        public List<Figuur> AlleFiguren()
        {
            String sql = "SELECT * FROM Figuur";
            OleDbCommand command = new OleDbCommand(sql, connection);

            List<Figuur> alleFiguren;
            alleFiguren = new List<Figuur>();

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                //MessageBox.Show("ja");
                string soort;
                int x;
                int y;
                int width;
                int height;
                while (reader.Read())
                {
                    soort = Convert.ToString(reader["Soort"]);
                    x = Convert.ToInt32(reader["X"]);
                    y = Convert.ToInt32(reader["Y"]);
                    width = Convert.ToInt32(reader["W"]);
                    height = Convert.ToInt32(reader["H"]);
                    alleFiguren.Add(new Figuur(soort, x, y, width, height));
                   
                }
            }
            catch
            {
                MessageBox.Show("nee");
            }
            finally
            {
                connection.Close();
            }
            return alleFiguren;
        }

        public void nieuwFiguur(String soort, int x, int y, int width, int height)
        {
            String sql = "INSERT INTO Figuur VALUES ('" + soort + "'," + x + "," + y + "," + width + "," + height + ")";
            OleDbCommand command = new OleDbCommand(sql, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("nee");
            }
            finally
            {
                connection.Close();
            }
        }

        public void tabelWissen()
        {
            String sql = "DELETE * FROM Figuur";
            OleDbCommand command = new OleDbCommand(sql, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("nee");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}