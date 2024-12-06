using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Login : Form
    {
        public static String currentLog;
        String loginUser {  get; set; }
        String passUser { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void btn_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            loginUser = loginField.Text;
            passUser = passField.Text;

            DB dB = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `login`, `pass` FROM `my_users` WHERE `login` = @uL AND `pass` = @uP", dB.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            

            if(table.Rows.Count > 0 )
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Користувач ввів правильні дані");

                currentLog = loginField.Text;

                this.Hide();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Користувач успішно увійшов в свій акаунт");

                Menu menu = new Menu();
                menu.Show();



            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Користувач ввів не вірні дані");

                MessageBox.Show("Incorrect data");        
            }

        }

    }
}
