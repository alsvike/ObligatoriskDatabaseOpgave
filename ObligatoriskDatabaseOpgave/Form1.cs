using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data;

namespace ObligatoriskDatabaseOpgave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=HotelDatabase;Integrated Security=True;TrustServerCertificate=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void CheckConnection()
        {
            //Det her var bare en for sjov ting hvor jeg begav mig ud i exceptions
            try
            {
                // Attempting to establish a connection to the database...

                // Opening the connection...
                conn.Open();

                // Connection status:
                if (conn.State == ConnectionState.Open)
                {
                    // Connection successful!
                    MessageBox.Show("Connection to the database was successful.", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Connection failed!
                    MessageBox.Show("Failed to establish a connection to the database.", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Connection failed, displaying error message...
                MessageBox.Show("An error occurred while trying to connect to the database: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Closing the connection...
                conn.Close();
            }
        }

        private void ViewTables_Click(object sender, EventArgs e)
        {
            conn.Open();

            DataTable dt = conn.GetSchema("Tables");

            DataGridView dataGridView = new DataGridView();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            conn.Close();
        }

        private void ClearDataHoteller()
        {
            TextHotelId.Clear();
            TextHotelNavn.Clear();
            TextHotelAdresse.Clear();
        }

        private void DisplayDataHoteller()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Hoteller";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void ClearDataKunder()
        {
            TextKundeID.Clear();
            TextKundeNavn.Clear();
            TextKundeAdresse.Clear();
        }

        private void DisplayDataKunder()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Kunder";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void DisplayDataVærelser()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Værelser";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void ClearDataVærelser()
        {
            TextVærelsesID.Clear();
            TextVHotelID.Clear();
            TextVærelsesNo.Clear();
        }

        private void DisplayDataReservationer()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Reservationer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void ClearDataReservationer()
        {
            TextResID.Clear();
            TextRKundeID.Clear();
            TextRVærelsesID.Clear();
            TextResFind.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InsertHoteller_Click(object sender, EventArgs e)
        {
            string query = $"insert into Hoteller values('{TextHotelId.Text.ToString()}','{TextHotelNavn.Text.ToString()}','{TextHotelAdresse.Text.ToString()}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            ClearDataHoteller();
            conn.Close();
            DisplayDataHoteller();
        }

        private void UpdateHoteller_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Hoteller set HotelNavn='" + TextHotelNavn.Text + "',Adresse='" + TextHotelAdresse.Text + "' where HotelID='" + TextHotelId.Text.ToString() + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();
            DisplayDataHoteller();
            ClearDataHoteller();
        }

        private void ShowAllHoteller_Click(object sender, EventArgs e)
        {
            DisplayDataHoteller();
        }

        private void DeleteHoteller_Click(object sender, EventArgs e)
        {
            string query = $"delete Hoteller where HotelID='{TextHotelId.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = query;
            ClearDataHoteller();
            conn.Close();
            DisplayDataHoteller();
        }
        private void FindHoteller_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Hoteller where HotelID='" + TextFindHoteller.Text + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            TextHotelId.Text = dt.ToString();
            TextHotelNavn.Text = dt.ToString();
            TextHotelAdresse.Text = dt.ToString();
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void InsertKunder_Click(object sender, EventArgs e)
        {
            string query = $"insert into Kunder values('{TextKundeID.Text.ToString()}','{TextKundeNavn.Text.ToString()}','{TextKundeAdresse.Text.ToString()}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            ClearDataKunder();
            conn.Close();
            DisplayDataKunder();
        }

        private void ShowAllKunder_Click(object sender, EventArgs e)
        {
            DisplayDataKunder();
        }

        private void UpdateKunder_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Kunder set KundeNavn='" + TextKundeNavn.Text + "',Adresse='" + TextKundeAdresse.Text + "' where KundeID='" + TextKundeID.Text.ToString() + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();
            DisplayDataKunder();
            ClearDataKunder();
        }

        private void DeleteKunder_Click(object sender, EventArgs e)
        {
            string query = $"delete Kunder where KundeID='{TextKundeID.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = query;
            ClearDataKunder();
            conn.Close();
            DisplayDataKunder();
        }

        private void FindKunder_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Kunder where KundeID='" + TextFindKunder.Text + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            TextKundeID.Text = dt.ToString();
            TextKundeNavn.Text = dt.ToString();
            TextKundeAdresse.Text = dt.ToString();
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void InsertVærelser_Click(object sender, EventArgs e)
        {
            string query = $"insert into Værelser values('{TextVærelsesID.Text.ToString()}','{TextVHotelID.Text.ToString()}','{TextVærelsesNo.Text.ToString()}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            ClearDataVærelser();
            conn.Close();
            DisplayDataVærelser();
        }

        private void UpdateVærelser_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Værelser SET VærelsesNummer='" + TextVærelsesNo.Text + "' WHERE VærelsesID='" + TextVærelsesID.Text + "' AND HotelID='" + TextVHotelID.Text + "'";

            cmd.ExecuteNonQuery();
            conn.Close();
            DisplayDataVærelser();
            ClearDataVærelser();
        }

        private void DeleteVærelser_Click(object sender, EventArgs e)
        {
            string query = $"delete Værelser where KundeID='{TextVærelsesID.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = query;
            ClearDataVærelser();
            conn.Close();
            DisplayDataVærelser();
        }

        private void FindVærelser_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Værelser where VærelsesID='" + TextFindVærelser.Text + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            TextVærelsesID.Text = dt.ToString();
            TextVHotelID.Text = dt.ToString();
            TextVærelsesNo.Text = dt.ToString();
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void ShowAllVærelser_Click(object sender, EventArgs e)
        {
            DisplayDataVærelser();
        }

        private void ResInsert_Click(object sender, EventArgs e)
        {
            string tjekIndDatoStr = TjekIndDato.Value.ToString("yyyy-MM-dd");
            string tjekUdDatoStr = TjekUdDato.Value.ToString("yyyy-MM-dd");

            string query = $"insert into Reservationer values('{TextResID.Text.ToString()}','{TextRKundeID.Text.ToString()}','{TextRVærelsesID.Text.ToString()}','{tjekIndDatoStr}','{tjekUdDatoStr}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            ClearDataReservationer();
            conn.Close();
            DisplayDataReservationer();
        }
        private void ResShowAll_Click(object sender, EventArgs e)
        {
            DisplayDataReservationer();
        }

        private void ResUpdate_Click(object sender, EventArgs e)
        {
            string tjekIndDatoStr = TjekIndDato.Value.ToString("yyyy-MM-dd");
            string tjekUdDatoStr = TjekUdDato.Value.ToString("yyyy-MM-dd");

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Reservationer SET TjekIndDato='" + tjekIndDatoStr + "', TjekUdDato='" + tjekUdDatoStr + "' WHERE ReservationsID='" + TextResID.Text + "' AND KundeID='" + TextRKundeID.Text + "' AND VærelsesID='" + TextRVærelsesID.Text + "'";

            cmd.ExecuteNonQuery();
            conn.Close();
            DisplayDataReservationer();
            ClearDataReservationer();
        }
    }
}
