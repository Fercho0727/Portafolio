using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Parqueos_4to_Unidad
{
    public partial class Datos : Form
    {
        public int num;
        public Datos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Datos_Load(object sender, EventArgs e)
        {

        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(txtAnio.Text);
            if (num >= 2012 && num <= 2021)
            {
                MessageBox.Show("Por politicas de la empresa no se cuenta " +
                    "con modelos de vehículos inferiores a 10 años " + 
                    "de vida útil.");

                if (num >= 2019 && num <= 2021)
                {
                    StreamReader lector;
                    lector = File.OpenText("C:\\Users\\DELL\\Desktop\\Proyecto Parqueos 4to Unidad - Definitivo 2\\Información\\MayorA2019.txt");
                    while (!lector.EndOfStream)
                    {
                        listBox1.Items.Add(lector.ReadLine());
                    }
                }
                if (num <= 2019)
                {
                    StreamReader lector;
                    lector = File.OpenText("C:\\Users\\DELL\\Desktop\\Proyecto Parqueos 4to Unidad - Definitivo 2\\Información\\MenorA2019.txt");
                    while (!lector.EndOfStream)
                    {
                        listBox1.Items.Add(lector.ReadLine());
                    }
                }

            }
            if (num == 2022)
            {
                MessageBox.Show("Por politicas de la empresa no se realizan " +
                    "compras a modelos de vehículos del año en curso.");
            }
            if (num > 2022)
            {
                StreamReader lector;
                lector = File.OpenText("C:\\Users\\DELL\\Desktop\\Proyecto Parqueos 4to Unidad - Definitivo 2\\Información\\MayorA2022.txt");
                while (!lector.EndOfStream)
                {
                    listBox1.Items.Add(lector.ReadLine());
                }
            }


        }

        private void Limpiar()
        {
            listBox1.Items.Clear();
        }
    }
}
