using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using iTextSharp.text;
using iTextSharp;
using iTextSharp.text.pdf;

namespace Kurs
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        list_of_Booking b = new list_of_Booking();
        Rooms r = new Rooms();
        private void button_reservation_complete_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\reservations1.sqlite; Version=3");
            sql.Open();
            //генерация id
            SQLiteCommand sc1 = new SQLiteCommand(@"select max(id) from Reservations", sql);
            SQLiteDataReader sdr = sc1.ExecuteReader();

            sdr.Read();
            string id1 = sdr.GetValue(0).ToString();
            if (id1.Length < 1)
                id1 = "0";
            //string id_r = "";
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Name == "Rooms")
            //    {
            //        id_r = r.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //        return;
            //    }
            //    //else
            //    //     id_r = this.dataGridView_rooms.CurrentRow.Cells[0].Value.ToString();
            //}

            SQLiteCommand sc = new SQLiteCommand(@"INSERT INTO Reservations(id,dateReserv,reservEnd,status,info,clientID,roomID ) values(" + (Convert.ToInt32(id1) + 1) + @",'" + dateTimePicker1.Value.ToShortDateString() + @"', '" + dateTimePicker2.Value.ToShortDateString() + @"', '" + comboBox_status.SelectedItem.ToString() + @"', '" + textBox_info.Text + @"', '" + dataGridView_clients.CurrentRow.Cells[0].Value.ToString() + @"', '" + dataGridView_rooms.CurrentRow.Cells[0].Value.ToString() + @"')", sql);

            sc.ExecuteNonQuery();
            sql.Close();
            // Booking b = new Booking();
            b.ShowDialog();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            comboBox_status.SelectedIndex = 0;
            if (!File.Exists(@"D:\reservations1.sqlite"))
            {
                SQLiteConnection.CreateFile(@"D:\reservations1.sqlite");
                SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\reservations1.sqlite; Version=3");
                SQLiteCommand sc = new SQLiteCommand("create table Reservations(id INTEGER PIMARY KEY, dateReserv TEXT, reservEnd TEXT, status TEXT, info TEXT, clientID INTEGER, roomID INTEGER)", sql);

                sql.Open(); sc.ExecuteNonQuery(); sql.Close();
            }

            SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\clients1.sqlite; Version=3");
            sqlcon.Open();

            SQLiteCommand sс = new SQLiteCommand(sqlcon);
            sс.CommandText = @"SELECT * FROM Clients;";

            SQLiteDataReader sdr = sс.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dataGridView_clients.DataSource = dt;

            sdr.Close();
            sqlcon.Close();

            SQLiteConnection sqlcon1 = new SQLiteConnection(@"Data Source=D:\rooms1.sqlite; Version=3");
            sqlcon1.Open();

            SQLiteCommand sс1 = new SQLiteCommand(sqlcon1);
            sс1.CommandText = @"SELECT * FROM Rooms;";

            SQLiteDataReader sdr1 = sс1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(sdr1);
            dataGridView_rooms.DataSource = dt1;

            sdr1.Close();
            sqlcon1.Close();
        }
    }
}
