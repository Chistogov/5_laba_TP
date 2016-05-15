using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int t = 0; t < numericUpDown1.Value; t++)
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
                NpgsqlCommand command = new NpgsqlCommand();
                string SQL = "INSERT INTO public.computer(name, id_videocard, id_powersupply, id_housing, id_harddrive, id_diskstorage, id_processor, id_ram, id_motherboard, is_del) VALUES(@name, @id_videocard, @id_powersupply, @id_housing, @id_harddrive, @id_diskstorage, @id_processor, @id_ram, @id_motherboard, false); ";
                command.CommandText = SQL;
                int id_videocard = 1;
                int id_powersupply = 1;
                int id_housing = 1;
                int id_harddrive = 1;
                int id_diskstorage = 1;
                int id_processor = 1;
                int id_ram = 1;
                int id_motherboard = 1;
                string name = DateTime.Now.ToString("hh:mm:ss:fff");
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@id_videocard", id_videocard);
                command.Parameters.AddWithValue("@id_powersupply", id_powersupply);
                command.Parameters.AddWithValue("@id_housing", id_housing);
                command.Parameters.AddWithValue("@id_harddrive", id_harddrive);
                command.Parameters.AddWithValue("@id_diskstorage", id_diskstorage);
                command.Parameters.AddWithValue("@id_processor", id_processor);
                command.Parameters.AddWithValue("@id_ram", id_ram);
                command.Parameters.AddWithValue("@id_motherboard", id_motherboard);
                command.Connection = conn;
                NpgsqlDataReader reader = null;
                try
                {
                    conn.Open();
                    reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception m)
                {
                    throw new Exception(m.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
