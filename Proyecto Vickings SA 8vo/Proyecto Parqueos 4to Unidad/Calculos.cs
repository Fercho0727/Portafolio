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
    public partial class Calculos : Form
    {
        public int num, motor, llanta, cilindro;
        public double precio, precioF, total, descuento, PrecioInicial, PrecioV;

  

        public Calculos()
        {
            InitializeComponent();
        }
        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(txtAnio.Text);
            PrecioV = Convert.ToInt32(txtPrecio.Text);
            motor = Convert.ToInt32(txtMotor.Text);
            llanta = Convert.ToInt32(txtLlanta.Text);
            cilindro = Convert.ToInt32(txtCilindro.Text);
            if (num >= 2012 && num <= 2021)
            {
                if (num > 2019 && num <= 2021) 
                {
                    StreamReader lector;
                    lector = File.OpenText("C:\\Users\\DELL\\Desktop\\Proyecto Parqueos 4to Unidad - Definitivo 2\\Información\\MayorA2019.txt");
                    while (!lector.EndOfStream)
                    {
                        listBox1.Items.Add(lector.ReadLine());
                    }
                    //Calculos
                    int a = 2019, b;
                    precio = PrecioV + (PrecioV * 0.03);
                    listBox2.Items.Add("Se aumenta el 3% al precio inicial: " + Math.Round(precio, 2));
                    b = num - a;
                    PrecioInicial = precio + (precio * 0.07*b);
                    listBox2.Items.Add("Se aumenta el 7% por año exponencial: " + Math.Round(PrecioInicial, 2));
                    Motor(motor);
                    Llanta(llanta);
                    Cilindro(cilindro);
                    //Total del deducible
                    total = PrecioInicial;
                    listBox2.Items.Add("El total del deducible es de: " + Math.Round(total, 2));
                    
                } //LISTO
                if (num < 2019 && num >= 2012)
                {
                    StreamReader lector;
                    lector = File.OpenText("C:\\Users\\DELL\\Desktop\\Proyecto Parqueos 4to Unidad - Definitivo 2\\Información\\MenorA2019.txt");
                    while (!lector.EndOfStream)
                    {
                        listBox1.Items.Add(lector.ReadLine());
                    }
                    //Calculos
                    int a = 2019, b;
                    precio = PrecioV + (PrecioV * 0.03);
                    listBox2.Items.Add("Se aumenta el 3% al precio inicial: " + Math.Round(precio, 2));
                    b = num - a;
                    PrecioInicial = precio + (precio * 0.03 * b);
                    listBox2.Items.Add("Se descuenta el 3% por año exponencial: " + Math.Round(PrecioInicial, 2));
                    Motor(motor);
                    Llanta(llanta);
                    Cilindro(cilindro);
                    //Total del deducible
                    total = PrecioInicial;
                    listBox2.Items.Add("El total del deducible es de: " + Math.Round(total, 2));
                } //LISTO
            } //LISTO
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
                //Calculos
                int a = 2022, b;
                precio = PrecioV + (PrecioV * 0.03);
                listBox2.Items.Add("Se aumenta el 3% al precio inicial: " + Math.Round(precio, 2));
                b = num - a;
                PrecioInicial = precio + (precio * 0.11 * b);
                listBox2.Items.Add("Se aumenta el 11% por año exponencial: " + Math.Round(PrecioInicial, 2));
                Motor(motor);
                Llanta(llanta);
                Cilindro(cilindro);
                //Total del deducible
                total = PrecioInicial;
                listBox2.Items.Add("El total del deducible es de: " + Math.Round(total, 2));
            } //LISTO
            if (num == 2004)
            {
                MessageBox.Show("Por politicas de la empresa no se cuenta " +
                    "con modelos de vehículos inferiores a 10 años " +
                    "de vida útil.");
                StreamReader lector;
                lector = File.OpenText("C:\\Users\\DELL\\Desktop\\Proyecto Parqueos 4to Unidad - Definitivo 2\\Información\\2004.txt");
                while (!lector.EndOfStream)
                {
                    listBox1.Items.Add(lector.ReadLine());
                }
                //Calculos
                int a = 2019, b;
                precio = PrecioV + (PrecioV * 0.03);
                listBox2.Items.Add("Se aumenta el 3% al precio inicial: " + Math.Round(precio, 2));
                b = num - a;
                PrecioInicial = precio + (precio * 0.03 * b);
                listBox2.Items.Add("Se descuenta el 3% por año exponencial: " + Math.Round(PrecioInicial, 2));
                Motor(motor);
                Llanta(llanta);
                Cilindro(cilindro);
                //Total del deducible
                total = PrecioInicial;
                listBox2.Items.Add("El total del deducible es de: " + Math.Round(total, 2));
            } //LISTO
            if (num < 2012)
            {
                MessageBox.Show("Por politicas de la empresa no se cuenta " +
                    "con modelos de vehículos inferiores a 10 años " +
                    "de vida útil.");
            }
        }
        private void Motor(int motor)
        {
            if (motor >= 2000 && motor <= 3500)
            {
                PrecioInicial = PrecioInicial + (PrecioInicial * 0.045);
                listBox2.Items.Add("Por motor de 2000 a 3500 cc, se aumenta el 4.5% = "+Math.Round(PrecioInicial, 2));
            }
            if (motor < 2000 && motor >= 1500)
            {
                PrecioInicial = PrecioInicial + (PrecioInicial * 0.013);
                listBox2.Items.Add("Por motor de 1500 a 1999 cc, se aumenta el 1.3% = " + Math.Round(PrecioInicial, 2));
            }
            if (motor < 1500)
            {
                PrecioInicial = PrecioInicial - (PrecioInicial * 0.057);
                listBox2.Items.Add("Por motor menor de 1500 cc, se aumenta el 5.7% = " + Math.Round(PrecioInicial, 2));
            }
            if (motor >= 3500)
            {
                MessageBox.Show("No se trabaja con motores mayores a 3500 cc.");
            }
        }
        private void Llanta(int llanta)
        {
            if (llanta == 4)
            {
                PrecioInicial = PrecioInicial + (PrecioInicial * 0.07);
                listBox2.Items.Add("Por 4 llantas, se aumenta el 7% = " + Math.Round(PrecioInicial, 2));
            }
            if (llanta == 6)
            {
                PrecioInicial = PrecioInicial + (PrecioInicial * 0.15);
                listBox2.Items.Add("Por 6 llantas, se aumenta el 15% = " + Math.Round(PrecioInicial, 2));
            }
            if (llanta > 6)
            {
                PrecioInicial = PrecioInicial + (PrecioInicial * 0.17);
                listBox2.Items.Add("Por más de 6 llantas, se aumenta el 17% = " + Math.Round(PrecioInicial, 2));
            }
            if (llanta < 4)
            {
                MessageBox.Show("No se trabaja con vehículos de 2 llantas.");
            }
        }
        private void Cilindro(int cilindro)
        {
            if (cilindro == 2)
            {
                PrecioInicial = PrecioInicial + (PrecioInicial * 0.04);
                listBox2.Items.Add("Por 2 cilindros, se aumenta el 4% = " + Math.Round(PrecioInicial, 2));
            }
            if (cilindro == 4)
            {
                PrecioInicial = PrecioInicial + (PrecioInicial * 0.08);
                listBox2.Items.Add("Por 4 cilindros, se aumenta el 8% = " + Math.Round(PrecioInicial, 2));
            }
            if (cilindro == 6)
            {
                PrecioInicial = PrecioInicial + (PrecioInicial * 0.12);
                listBox2.Items.Add("Por 6 cilindros, se aumenta el 12% = " + Math.Round(PrecioInicial, 2));
            }
            if (cilindro == 8)
            {
                PrecioInicial = PrecioInicial + (PrecioInicial * 0.16);
                listBox2.Items.Add("Por 8 cilindros, se aumenta el 16% = " + Math.Round(PrecioInicial, 2));
            }
            if (cilindro > 8)
            {
                MessageBox.Show("No se trabaja con vehículos de más de 8 cilindros.");
            }
        }
    }
}
