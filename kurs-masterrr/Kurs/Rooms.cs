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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

     

        private void Rooms_Load(object sender, EventArgs e)
        {
            comboBox_type.SelectedIndex = 0;
            //button_book.Enabled = false;

            if (!File.Exists(@"D:\rooms1.sqlite"))
            {
                SQLiteConnection.CreateFile(@"D:\rooms1.sqlite");
                SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\rooms1.sqlite; Version=3");
                SQLiteCommand sc = new SQLiteCommand("create table Rooms(id INTEGER PIMARY KEY, number INTEGER, type TEXT, status TEXT, cost INTEGER)", sql);

                sql.Open();
                //     sc.CommandText ="INSERT INTO Rooms (id, type, status, cost) VALUES(1,'sdas', 'sqq', 1000)";
                sc.ExecuteNonQuery();
                sql.Close();
            }
            SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\rooms1.sqlite; Version=3");


            SQLiteCommand sql1 = new SQLiteCommand(sqlcon);
            // sql1.CommandText = "INSERT INTO Rooms (id, type, status, cost) VALUES(1,'sdas', 'sqq', 1000)";
            sqlcon.Open();
            sql1.CommandText = @"SELECT * FROM Rooms;";


            SQLiteDataReader sdr = sql1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;

            sdr.Close();
            sqlcon.Close();
        }

        private void button_book_Click(object sender, EventArgs e)
        {

            Booking res = new Booking();

            //res.label5.Visible = false;
            //res.dataGridView_rooms.Visible = false;
            res.ShowDialog();


            SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\rooms1.sqlite;Version=3");
            SQLiteCommand sc = new SQLiteCommand(string.Format(@"update Rooms set status = 'бронь'  WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value.ToString()), sql);
            sql.Open();
            sc.ExecuteNonQuery();
            sql.Close();

            MessageBox.Show("Номер забронирован");

            SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\rooms1.sqlite; Version=3");


            SQLiteCommand sql1 = new SQLiteCommand(sqlcon);

            sqlcon.Open();
            sql1.CommandText = @"SELECT * FROM Rooms;";


            SQLiteDataReader sdr1 = sql1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr1);
            dataGridView1.DataSource = dt;

            sdr1.Close();
            sqlcon.Close();


        }

        private void button_addRoom_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\rooms1.sqlite; Version=3");
            sql.Open();

            //генерация id     


            SQLiteCommand sc1 = new SQLiteCommand(@"select max(id) from Rooms", sql);
            SQLiteDataReader sdr = sc1.ExecuteReader();

            sdr.Read();
            string id1 = sdr.GetValue(0).ToString();
            if (id1.Length < 1)
                id1 = "0";
            string status = "свободен";

            SQLiteCommand sc = new SQLiteCommand(@" INSERT INTO Rooms(id,number,type,status,cost) values(" + (Convert.ToInt32(id1) + 1) + @", '" + textBox_number.Text + @"', '" + comboBox_type.SelectedItem.ToString() + @"', '" + status + "', '" + textBox_cost.Text + "')", sql);
            textBox_cost.Clear();
            textBox_number.Clear();
           
            comboBox_type.SelectedIndex = 0;
            sc.ExecuteNonQuery();
            sql.Close();
            SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\rooms1.sqlite; Version=3");

       
            SQLiteCommand sql1 = new SQLiteCommand(sqlcon);
            // sql1.CommandText = "INSERT INTO Rooms (id, type, status, cost) VALUES(1,'sdas', 'sqq', 1000)";
            sqlcon.Open();
            sql1.CommandText = @"SELECT * FROM Rooms;";


            SQLiteDataReader sdr1 = sql1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr1);
            dataGridView1.DataSource = dt;

            sdr1.Close();
            sqlcon.Close();
            MessageBox.Show("Номер добавлен в БД");

        }

        private void button_del_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\rooms1.sqlite;Version=3");

            SQLiteCommand sc = new SQLiteCommand("DELETE FROM Rooms WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value.ToString(), sql);
            // sc.CommandText = "select * from Clients";
            sql.Open();
            sc.ExecuteNonQuery();
            sql.Close();

            MessageBox.Show("Номер удален из БД");
            SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\rooms1.sqlite; Version=3");


            SQLiteCommand sql1 = new SQLiteCommand(sqlcon);

            sqlcon.Open();
            sql1.CommandText = @"SELECT * FROM Rooms;";


            SQLiteDataReader sdr1 = sql1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr1);
            dataGridView1.DataSource = dt;

            sdr1.Close();
            sqlcon.Close();
        }

        private void button_checkedout_Click(object sender, EventArgs e)
        {
           
            SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\rooms1.sqlite;Version=3");
            SQLiteCommand sc = new SQLiteCommand(string.Format(@"update Rooms set status = 'свободен'  WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value.ToString()),sql);
            sql.Open();
            sc.ExecuteNonQuery();
            sql.Close();

            MessageBox.Show("Номер освобожден");

            SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\rooms1.sqlite; Version=3");


            SQLiteCommand sql1 = new SQLiteCommand(sqlcon);

            sqlcon.Open();
            sql1.CommandText = @"SELECT * FROM Rooms;";


            SQLiteDataReader sdr1 = sql1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr1);
            dataGridView1.DataSource = dt;

            sdr1.Close();
            sqlcon.Close();

        }

        private void button_checkedin_Click(object sender, EventArgs e)
        {
            //Clients cl = new Clients();
            //cl.ShowDialog();

            MessageBox.Show("Нужно, наверное, чтобы открывалась форма клиенты и там выбирать клиента,"+Environment.NewLine+" а потом это все пойдет сразу в счет, но я хз как это сделать, поэтому просто меняю статус номера на занят");


            SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\rooms1.sqlite;Version=3");
            SQLiteCommand sc = new SQLiteCommand(string.Format(@"update Rooms set status = 'занят'  WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value.ToString()), sql);
            sql.Open();
            sc.ExecuteNonQuery();
            sql.Close();

            //MessageBox.Show("Номер сдан");

            SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\rooms1.sqlite; Version=3");


            SQLiteCommand sql1 = new SQLiteCommand(sqlcon);

            sqlcon.Open();
            sql1.CommandText = @"SELECT * FROM Rooms;";


            SQLiteDataReader sdr1 = sql1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr1);
            dataGridView1.DataSource = dt;

            sdr1.Close();
            sqlcon.Close();



        }
    }
}
