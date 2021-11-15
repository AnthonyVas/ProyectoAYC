using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserSQL
{
    public partial class Inicio : Form
    {
        int total = 0;
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progressBar1.Step = 5;
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = progressBar1.Minimum;

            total = total + 1;
            if (total == 2 && i < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                iniciando.Text = "Cargando complementos.";
            }

            if (total == 3 && i < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                iniciando.Text = "Cargando complementos..";
            }

            if (total == 4 && i < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                iniciando.Text = "Cargando complementos...";
            }

            if (total == 5 && i < progressBar1.Maximum)
            {
                iniciando.Text = "Carga Finalizada";

                for (int isf = i; isf < progressBar1.Maximum; isf = isf + progressBar1.Step)
                {
                    progressBar1.PerformStep();
                    iniciando.Text = "Carga Finalizada";

                }


            }

            if (total == 6)
            {
                IDE id = new IDE();
                this.Hide();
                id.Show();
            }




        }
    }
}
