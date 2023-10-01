using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO.Ports;
using System.Configuration;

namespace TrialSensor
{
    public partial class LiveData : Form
    {
        private SerialPort serialPort;
        private SqlConnection sqlConnection;

        public LiveData()
        {
            InitializeComponent();
            InitializeSerialPort();
            InitializeDatabaseConnection();
        }

        private void InitializeSerialPort()
        {
            serialPort = new SerialPort
            {
                PortName = "COM3", 
                BaudRate = 9600 
            };

            serialPort.DataReceived += DataReceivedHandler;

            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port: " + ex.Message);
            }
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening database connection: " + ex.Message);
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadLine(); 
                Console.WriteLine("Received data: " + data);
                UpdateTemperatureAndHumidity(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error processing data: " + ex.Message);
            }
        }

        private void UpdateTemperatureAndHumidity(string data)
        {
            string[] parts = data.Split(' ');

            if (parts.Length == 14 && parts[0] == "Temperature:" && parts[2] == "Humidity:" && parts[6] == "Temperature" && parts[9] == "Humidity")
            {
                string temperature1 = parts[1];
                string humidity1 = parts[3];
                string temperature2 = parts[8];
                string humidity2 = parts[11];
                string date = parts[12];
                string time = parts[5];
                string[] tparts = time.Split(':');
                string MTime = $"{tparts[0]}:{tparts[1]}";

                string insertQuery = "INSERT INTO SensorData (SensorName, Temperature, Humidity, Temperature_1, Humidity_1, Date, Time) VALUES(@SensorName, @Temperature, @Humidity, @Temperature_1, @Humidity_1, @Date, @Time)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@SensorName", "Logger_1");
                    cmd.Parameters.AddWithValue("@Temperature", temperature1);
                    cmd.Parameters.AddWithValue("@Humidity", humidity1);
                    cmd.Parameters.AddWithValue("@Temperature_1", temperature2);
                    cmd.Parameters.AddWithValue("@Humidity_1", humidity2);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@Time", time);

                    cmd.ExecuteNonQuery();
                }

                Invoke((MethodInvoker)delegate
                {
                    temperatureTextBox.Text = temperature1;
                    humidityTextBox.Text = humidity1;
                    temperatureTextBox2.Text = temperature2;
                    humidityTextBox2.Text = humidity2;
                    lb_date.Text = date;
                    lb_time.Text = MTime;
                });
            }
        }
    }
}
