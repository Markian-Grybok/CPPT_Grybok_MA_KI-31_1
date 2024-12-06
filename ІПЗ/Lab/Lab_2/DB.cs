using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace Lab_2
{

    public class DB
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=my_messenger");

        public void openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("З'єднання з базою даних відкрите.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Помилка при відкритті з'єднання з БД: " + ex.Message);
            }
        }

        public void closeConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("З'єднання з базою даних закрите.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Помилка при закритті з'єднання з БД: " + ex.Message);
            }
        }

        public MySqlConnection getConnection()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Отримання даних з БД");
            return connection;
        }

        
        
    }

   
}
