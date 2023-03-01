using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LACO_DE_REPETICAO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listarFor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listarFor.Items.Add(1);
            //listarFor.Items.Add(2);
            //listarFor.Items.Add(3);
            //listarFor.Items.Add(4);
            //listarFor.Items.Add(5);
            //listarFor.Items.Add(6);
            //listarFor.Items.Add(7);
            //listarFor.Items.Add(8);
            //listarFor.Items.Add(9);
            //listarFor.Items.Add(10);

            //for (int valor = 0; valor <= 10; valor++)
            //{
            //    listarFor.Items.Add(valor);

            for (int valor = 0; valor <= 10; valor += 2)
            {
                listarFor.Items.Add(valor);
            }
            

        }
    }
}