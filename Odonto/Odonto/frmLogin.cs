using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odonto
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == "admin") && (textBox2.Text == "123"))
            {
                frmSplash frmsplash = new frmSplash();
                frmsplash.Show();
                this.Visible = false;
               
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos", "Ocorreu um Erro ao Autenticar",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.To.Add("EmailDoUsuario@email.com.br");
            message.Subject = "Assunto";
            message.From = new System.Net.Mail.MailAddress("SeuEmail@email.com");
            message.Body = "Corpo da mensagem - Coloque a senha e bla bla";
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("yoursmtphost");
            smtp.Send(message);
            */

        }
    }
}
