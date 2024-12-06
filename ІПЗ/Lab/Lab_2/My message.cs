using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class My_message : Form
    {
        String first_name { get; set; }
        String last_name { get; set; }

        public My_message()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            first_name = Login.currentLog;
            last_name = user_name.Text;

            DB dB = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT CONCAT('        ', cur_time) AS cur_time, text " +
                "FROM massages " +
                "WHERE first_name = @l_name AND last_name = @f_name", dB.getConnection());

            if (isUserExcist(last_name))
                return;

            command.Parameters.Add("@f_name", MySqlDbType.VarChar).Value = first_name;
            command.Parameters.Add("@l_name", MySqlDbType.VarChar).Value = last_name;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                string tableContent = "";

                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        tableContent += row[column].ToString();
                        tableContent += Environment.NewLine;
                    }
                    tableContent += Environment.NewLine;
                }

                user_text.Text = tableContent;

            }
            else if(first_name == last_name)
            {
                MessageBox.Show("It's YOU!!!!");
            }
            else
            { 
                MessageBox.Show("You dont have massage");
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
