using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Gloomi
{
    public partial class LampenMenu : Form
    {
        public LampenMenu(Form parent)
        {
            InitializeComponent();
            this.Text = "Gloomi - Lampen";
            connectionString = "Data Source=DESKTOP-SPGGB7R;Initial Catalog=gloomi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            parentForm = parent as MainMenu;

            //populate list by default
            List<Lamp> allResults = SQLCommandReader("SELECT * FROM dbo.lampen;");
            foreach (Lamp result in allResults)
            {
                new LampPanel(panelLampen, result);
            }
        }
        public Button OriginButton;
        private MainMenu parentForm;
        private string lastQuery;

        static string defaultTableName = "dbo.lampen";
        static string connectionString;
        public List<Lamp> SQLCommandReader(string queryString)
        {
            List<Lamp> lampenData = new List<Lamp>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                //command.ExecuteReader();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Lamp lamp = new Lamp();
                        lamp.SQLindex = reader.GetInt32(0);
                        lamp.provincie = reader.GetString(1);
                        lamp.stad = reader.GetString(2);
                        lamp.postcode = reader.GetString(3);
                        lamp.apparaatid = reader.GetString(4);
                        lamp.lichtintensiteit = (float)reader.GetDouble(5);
                        lamp.kleur = Color.FromArgb(reader.GetInt32(6));
                        lamp.temperatuur = reader.GetInt32(7);
                        lamp.vochtigheidsgraad = reader.GetInt32(8);
                        lamp.luxgraad = reader.GetInt32(9);
                        Console.WriteLine(lamp.lichtintensiteit);
                        lampenData.Add(lamp);
                    }
                    reader.Close();
                }
            }
            lastQuery = queryString;
            return lampenData;
        }

        public int SQLInsertLamp(Lamp lamp)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string SQLQ = "INSERT INTO " + defaultTableName + " ";
                SQLQ += "VALUES (";
                SQLQ += "'" + lamp.provincie.Trim().ToLower() + "',";
                SQLQ += "'" + lamp.stad.Trim().ToLower() + "',";
                SQLQ += "'" + lamp.postcode.Trim().ToLower() + "',";
                SQLQ += "'" + lamp.apparaatid.Trim().ToLower() + "',";
                SQLQ += "" + lamp.lichtintensiteit + ",";
                SQLQ += "" + lamp.kleur.ToArgb() + ",";
                SQLQ += "" + lamp.temperatuur + ",";
                SQLQ += "" + lamp.vochtigheidsgraad + ",";
                SQLQ += "" + lamp.luxgraad + "";
                SQLQ += ");";
                SqlCommand command = new SqlCommand(SQLQ, connection);
                command.Connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected;
            }
        }

        public int SQLUpdateLamp(Lamp lampTemplate, int id)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string SQLQ = "UPDATE " + defaultTableName + " ";
                SQLQ += "SET ";
                SQLQ += "provincie = '" + lampTemplate.provincie + "',";
                SQLQ += "stad = '" + lampTemplate.stad + "',";
                SQLQ += "postcode = '" + lampTemplate.postcode + "',";
                SQLQ += "lampcodenummer = " + lampTemplate.apparaatid + ",";
                SQLQ += "lichtintensiteit = " + lampTemplate.lichtintensiteit + ",";
                SQLQ += "kleur = " + lampTemplate.kleur.ToArgb() + " ";
                SQLQ += "WHERE id = " + id + ";";
                SqlCommand command = new SqlCommand(SQLQ, connection);
                command.Connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected;
            }
        }

        public int SQLDeleteLamp(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string SQLQ = "DELETE FROM " + defaultTableName + " WHERE id = " + id + ";"; 
                SqlCommand command = new SqlCommand(SQLQ, connection);
                command.Connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected;
            }
        }

        public void SQLReRunLastSearchQueryAndUpdateList()
        {
            panelLampen.Controls.Clear();

            List<Lamp> allResults = SQLCommandReader(lastQuery);
            foreach (Lamp result in allResults)
            {
                new LampPanel(panelLampen, result);
            }
        }

        private void buttonAddLamp_Click(object sender, System.EventArgs e)
        {

            LampenAdd lampenAdd = new LampenAdd(this);
            lampenAdd.Show();

        }

        private void buttonZoek_Click(object sender, System.EventArgs e)
        {
            
            bool isQuery = false;
            string zoekOpdracht = "SELECT * FROM dbo.lampen ";

            string provincieInput = textBoxProvincie.Text.Trim().ToLower();
            string stadInput = textBoxStad.Text.Trim().ToLower();
            string postcodeInput = textBoxPostcode.Text.Trim().ToLower();
            string lampcodeInput = textBoxLampCodeNum.Text.Trim().ToLower();

            if (provincieInput != "" & provincieInput.Length > 0 )
            {
                if (isQuery == false)
                {
                    zoekOpdracht += "WHERE provincie=N'" + provincieInput + "' ";
                    isQuery = true;
                }
                else
                {
                    zoekOpdracht += "AND provincie=N'" + provincieInput + "' ";
                }
            }
            if (stadInput != "" & stadInput.Length > 0)
            {
                if (isQuery == false)
                {
                    zoekOpdracht += "WHERE stad=N'" + stadInput + "' ";
                    isQuery = true;
                }
                else
                {
                    zoekOpdracht += "AND stad=N'" + stadInput + "' ";
                }
            }
            if (postcodeInput != "" & postcodeInput.Length > 0)
            {
                if (isQuery == false)
                {
                    zoekOpdracht += "WHERE postcode=N'" + postcodeInput + "' ";
                    isQuery = true;
                }
                else
                {
                    zoekOpdracht += "AND postcode=N'" + postcodeInput + "' ";
                }
            }
            if (lampcodeInput != "" & lampcodeInput.Length > 0)
            {
                if (isQuery == false)
                {
                    zoekOpdracht += "WHERE lampcodenummer=" + lampcodeInput + "";
                    isQuery = true;
                }
                else
                {
                    zoekOpdracht += "AND lampcodenummer=" + lampcodeInput + "";
                }
            }
            zoekOpdracht += ";";

            //Panel notif = parentForm.AddNotificationFromOutside();
            //parentForm.NotificationMessage(notif, "SQLquery", "check");
            //parentForm.NotificationContent(notif, zoekOpdracht);

            //Console.WriteLine(zoekOpdracht);
            panelLampen.Controls.Clear();

            List<Lamp> allResults = SQLCommandReader(zoekOpdracht);
            foreach (Lamp result in allResults)
            {
                new LampPanel(panelLampen, result);
            }
        }
    }
}
