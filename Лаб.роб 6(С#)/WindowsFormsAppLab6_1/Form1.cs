using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab6_1
{
    public partial class Form1 : Form
    {
        struct Timetable
        {
            public string first_lesson;
            public string second_lesson;
            public string third_lesson;
            public string fourth_lesson;
            public string section;

            public string Lessons()
            {
                return $"Перша пара: {first_lesson}  Друга пара: { second_lesson}  Третя пара: {third_lesson}  Четверта пара: {fourth_lesson}  Секція: {section};";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timetable les;
            les.first_lesson = textBox1.Text;
            les.second_lesson = textBox2.Text;
            les.third_lesson = textBox3.Text;
           les.fourth_lesson = textBox4.Text;
            les.section = textBox5.Text;
            listBox1.Items.Add ( les.Lessons());

        }
    }
}
