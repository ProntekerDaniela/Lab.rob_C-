using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab6_2
{
    public partial class Form1 : Form
    {
        struct Handbook
        {
            public int number_car;
            public string car_owner;
            public int year;
            public string car_brand;

            public string Car()
            {
                return $"Номер автомобіля: {number_car}  Власник: { car_owner}  Рік випуску: {year}  Марка автомобіля: {car_brand};";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Handbook car;
            car.number_car = Convert.ToInt32(textBox1.Text);
            car.car_owner = textBox2.Text;
            car.year = Convert.ToInt32( textBox3.Text);
            car.car_brand = textBox4.Text;
            listBox1.Items.Add(car.Car());
        }
    }
}
