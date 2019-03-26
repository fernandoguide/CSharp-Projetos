using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            Thread t = new Thread(new  ThreadStart (Splash));
            t.Start();
            InitializeComponent();
            //Loading
            string str = string.Empty;
            for (int i = 0; i < 100000; i++)
            {
                str += i.ToString(); // iniciando
            }

        }
        void Splash()
        {
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "Carregando";
            Application.Run(frm);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
