using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class Messenger : Form
    {
        String first_name { get; set; }
        String text { get; set; }
        String last_name { get; set; }
        public Messenger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            first_name = Login.currentLog;
            text = user_text.Text;
            last_name = user_name.Text;

            DB dB = new DB();
            MySqlCommand command = new MySqlCommand(" INSERT INTO `massages` (`first_name`, `text`, `last_name`) VALUES (@f_name, @u_text, @l_name)", dB.getConnection());

            if (text == "" || last_name == "")
            {
                MessageBox.Show("Fields empty");
            }
            else if(last_name == first_name)
            {
                MessageBox.Show("You cant send massage to yourself!");
            }
            else
            {
                if (isUserExcist(last_name))
                    return;

                command.Parameters.Add("@f_name", MySqlDbType.VarChar).Value = first_name;
                command.Parameters.Add("@u_text", MySqlDbType.VarChar).Value = text;
                command.Parameters.Add("@l_name", MySqlDbType.VarChar).Value = last_name;

                dB.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Massage succses send");
                }
                else
                {
                    MessageBox.Show("Massage DONT send");
                }

                dB.closeConnection();
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
                return false;
            }
            else
            {
                MessageBox.Show("Incorrect user");
                return true;
            }
        }
    }
}
