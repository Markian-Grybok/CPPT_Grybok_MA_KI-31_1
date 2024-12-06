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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_mymessage_Click(object sender, EventArgs e)
        {
            this.Hide();
            My_message my_Message = new My_message();
            my_Message.Show();
        }

        private void btn_messenger_Click(object sender, EventArgs e)
        {
            this.Hide();
            Messenger messenger = new Messenger();
            messenger.Show();
        }
    }
}
