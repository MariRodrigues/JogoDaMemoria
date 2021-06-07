using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace JogoDaMemoria
{
    public partial class Form2 : Form
    {
        Thread jogo;
        string nick;

        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nick = nic.Text;
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=jogomemoria;uid=root;pwd=mariana;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                string commandStr = "INSERT INTO usuario (nome,nick)" +
                            "VALUES('" + nome.Text + "','" + nic.Text + "')";
                MySqlCommand command = new MySqlCommand(commandStr, cnn);

                int value = command.ExecuteNonQuery();
                Console.WriteLine("ExecuteNonQuery : " + value);
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex);
            }
            this.Close();
            jogo = new Thread(NovoJogo);
            jogo.SetApartmentState(ApartmentState.STA);
            jogo.Start();

        }
        private void NovoJogo()
        {
            //Console.WriteLine("nome digitado : "+ nickGL);
            Application.Run(new Form1(nick));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
