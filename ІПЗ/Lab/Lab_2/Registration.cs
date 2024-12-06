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
    public partial class Registration : Form
    {
        String newLoginUser { get; set; }
        String newPasswordUser { get ;set; }
        String cheakPassUser { get; set; }

        public Registration()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            newLoginUser = newLoginField.Text;
            newPasswordUser = newPassField.Text;
            cheakPassUser = checkPassField.Text;

            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `my_users` (`login`, `pass`) VALUES (@uL, @uP)", dB.getConnection());

            if (newPasswordUser == "" || newLoginUser == "")
            {
                MessageBox.Show("Fields empty");
            }
            else if (newPasswordUser != cheakPassUser)
            {
                MessageBox.Show("Passes is not same");
            }
            else
            {
                if (isUserExcist(newLoginUser))
                    return;

                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = newLoginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = newPasswordUser;

                dB.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Користувач успішно доданий");

                    MessageBox.Show("User succses added");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Користувач не був доданий");

                    MessageBox.Show("User DONT addes");
                }
                
                dB.closeConnection();

                this.Hide();
                Login login = new Login();
                login.Show();
            }

        }

        public Boolean isUserExcist(String userLogin)
        {
            DB dB = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Перевірка користувача");

            MySqlCommand command = new MySqlCommand("SELECT * FROM `my_users` WHERE `login` = @uL", dB.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Користувач ввів не коректне імя");

                MessageBox.Show("Name is already used");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
