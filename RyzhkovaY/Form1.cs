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

namespace RyzhkovaY
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

        }


        private void butStart_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Raschet);
            thread.Start();

             
        }
        private void Raschet(object input) 
        {
            Invoke(new Action(() =>
              {
                  Double x = Convert.ToInt32(tbVoltage.Text);
                  Double y = Convert.ToInt32(tbResistance.Text);

                  tbAmperage.Text = Convert.ToString(Math.Round(x / y, 2));
              }));
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            Double x = Convert.ToInt32(tbVoltage.Text);
            Double y = Convert.ToInt32(tbResistance.Text);

        }
    }
}
