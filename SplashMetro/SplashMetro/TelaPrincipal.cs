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

namespace SplashMetro
{
    public partial class TelaPrincipal : MetroFramework.Forms.MetroForm
    {
        public TelaPrincipal()
        {
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start();
            InitializeComponent();
            for(int i = 0; i <= 1000; i++)
                Thread.Sleep(10);  //Demo
             t.Abort(); //Completo       
            

        }

        void Loading()
        {
            MetroSplash frm = new MetroSplash();
            Application.Run(frm);

        }
    }
}
