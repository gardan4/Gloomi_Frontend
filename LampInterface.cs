using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.IO.Ports;
using System.Threading.Tasks;
using System;
using System.Timers;
using System.Data.SqlClient;

namespace Gloomi
{
    public partial class LampInterface : Form
    {
        static readonly int bufferSize = 8;
        static readonly SerialPort serialPort = new SerialPort("COM5", 9600);
        static readonly bool useSerialPort = false;
        static string connectionString;

        public LampInterface(Lamp targetLamp, Form originForm)
        {
            connectionString = "Data Source=DESKTOP-SPGGB7R;Initial Catalog=gloomi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            InitializeComponent();
            Target = targetLamp;
            this.Text = "Lamp interface voor lamp [" + targetLamp.apparaatid + "]";

            parent = (LampenMenu)originForm;

            Dummylamp = new Lamp();
            Dummylamp.provincie = Target.provincie;
            Dummylamp.stad = Target.stad;
            Dummylamp.postcode = Target.postcode;
            Dummylamp.SQLindex = Target.SQLindex;
            Dummylamp.apparaatid = Target.apparaatid;
            Dummylamp.lichtintensiteit = Target.lichtintensiteit;
            Dummylamp.kleur = Target.kleur;

            //numericLichtIntensiteit.Value = Convert.ToDecimal(Target.lichtintensiteit);

            //panelKleurWeergave.BackColor = Color.FromArgb(255, Target.kleur.R, Target.kleur.G, Target.kleur.B);

            //if (useSerialPort)
            //{
            //    serialPort.ReadTimeout = 1000;
            //    serialPort.WriteTimeout = 1000;
            //    serialPort.Open();
            //}

            aTimer = new System.Timers.Timer(250);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private Lamp Target;
        private Lamp Dummylamp;
        private LampenMenu parent;

        private System.Timers.Timer aTimer;
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            //byte[] message;

            //if (useSerialPort)
            //{
            // Read the message from serial port with a timeout.
            //var readMessageTask = ReadMessage();
            //readMessageTask.Wait(2000);
            //message = readMessageTask.Result;
            //}
            //else
            //{
            // Use a fixed message for usage without serial port.
            //    message = new byte[] { 34, 161, 9, 254, 37, 244, 233, 228 };
            //}

            //if (message == null)
            //{
            //    Console.WriteLine("Invalid message");
            //}
            //else
            //{
            //var serialMessage = DecodeMessage(message);
            /*
            Console.WriteLine("HEX: {0}", BitConverter.ToString(message));
            Console.WriteLine(
                "H: {0}%, T: {1}C, B: {2}%, Lamp Code: {3}",
                serialMessage.Humidity, serialMessage.Temperature,
                serialMessage.Brightness, serialMessage.LampCode
            );
            */
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var id = Dummylamp.apparaatid;
                

                SqlCommand command = new SqlCommand("Select lichtintensiteit, temperatuur, vochtigheidsgraad, luxgraad from dbo.lampen where apparaatid=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Connection.Open();
                //command.ExecuteReader();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    Label.CheckForIllegalCrossThreadCalls = false;

                    labelLichtIntensiteit.Text = Convert.ToString(reader.GetValue(0)) + "%";                            
                        labelTemperatuur.Text = Convert.ToString(reader.GetInt32(1)) + "°C";
                        labelLuchtVochtigheid.Text = Convert.ToString(reader.GetInt32(2)) + "%";                                                                    
                        labelOphaaldatum.Text = DateTime.Today.ToString();
                       
                    }
                    reader.Close();
                }
                                      
                
            }
                //Console.WriteLine();
            
        }

        // Read bytes from the serial port until an EOL byte is found.
        // When the EOL byte is found before enough bytes are read,
        // the returned value will be null.
        static Task<byte[]> ReadMessage()
        {
            var source = new TaskCompletionSource<byte[]>();
            var buffer = new byte[bufferSize];
            int writtenBytes = 0;
            byte lastByte = 0;

            // Read until the byte is an EOL byte.
            while (lastByte != '\n')
            {
                if (writtenBytes < bufferSize)
                {
                    // Write byte to the buffer after the last byte.
                    buffer[writtenBytes] = lastByte;
                    writtenBytes++;
                }
                else
                {
                    // Remove the first byte of the buffer.
                    for (int i = 0; i < bufferSize - 1; i++)
                    {
                        buffer[i] = buffer[i + 1];
                    }


                    buffer[bufferSize - 1] = lastByte;
                }

                // Read a new byte from the serial port.
                lastByte = (byte)serialPort.ReadByte();
            }

            if (writtenBytes < bufferSize)
            {
                // Not enough written bytes, null indicates an invalid buffer.
                source.SetResult(null);
            }
            else
            {
                source.SetResult(buffer);
            }

            return source.Task;
        }

        static SerialMessage DecodeMessage(byte[] message)
        {
            return new SerialMessage
            {
                Humidity = (float)BytesToInt16(message.Skip(0).Take(2).ToArray()) / 100,
                Temperature = (float)BytesToInt16(message.Skip(2).Take(2).ToArray()) / 100,
                Brightness = (float)BytesToInt16(message.Skip(4).Take(2).ToArray()) / 100,
                LampCode = BytesToUint16(message.Skip(6).Take(2).ToArray()),
            };
        }

        // Converts two bytes (LSB first) to int16.
        static int BytesToInt16(byte[] buffer)
        {
            // Left and immediate right shift to allow negative values.
            return (buffer[0] << 24 >> 16) | buffer[1];
        }

        // Converts two bytes (LSB first) to uint16.
        static int BytesToUint16(byte[] buffer)
        {
            return (buffer[0] << 8) | buffer[1];
        }


        //Winforms

        private void buttonVerwijderen_Click(object sender, System.EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Bent u ervan zeker met het verwijderen van deze lamp?", "Verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                parent.SQLDeleteLamp(Target.SQLindex);
                parent.SQLReRunLastSearchQueryAndUpdateList();
                this.Hide();
            }
        }

        private void buttonToepassen_Click(object sender, System.EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Bent u zeker met het opslaan van uw wijzigingen?", "Opslaan", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //parent.SQLUpdateLamp(Dummylamp,Target.SQLindex);
                //parent.SQLReRunLastSearchQueryAndUpdateList();
                this.Hide();
            }
        }

        private void buttonSluiten_Click(object sender, System.EventArgs e)
        {
            if( System.Windows.Forms.MessageBox.Show("Als u niet opslaat, worden alle wijzigingen verwijderd. Wilt u het scherm sluiten zonder eerst op te slaan?", "Sluiten", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                aTimer.Stop();
                this.Hide();
            }
        }

        //private void buttonKleurVeranderen_Click(object sender, System.EventArgs e)
        //{
        //    if (colorDialogKleur.ShowDialog() == DialogResult.OK)
        //    {
        //        Color c = colorDialogKleur.Color;
        //        Dummylamp.kleur = Color.FromArgb(0, c.R, c.G, c.B);
        //        panelKleurWeergave.BackColor = colorDialogKleur.Color;
        //    }
        //}

        //private void numericLichtIntensiteit_ValueChanged(object sender, System.EventArgs e)
        //{
        //    if (Dummylamp != null)
        //    {
        //        Dummylamp.lichtintensiteit = decimal.ToSingle(numericLichtIntensiteit.Value);
        //    }
        //}

        private void LampInterface_Close(object sender, FormClosingEventArgs e)
        {
            //if (System.Windows.Forms.MessageBox.Show("Als u niet opslaat, worden alle wijzigingen verwijderd. Wilt u het scherm sluiten zonder eerst op te slaan?", "Sluiten", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            e.Cancel = true;
            //}
            //else
            //{
            //    aTimer.Stop();
            //    if (useSerialPort)
            //    {
            //        serialPort.Close();
            //    }
            //}
        }
    }
}
