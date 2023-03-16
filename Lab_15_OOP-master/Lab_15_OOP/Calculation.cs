using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_15_OOP
{
    public partial class Calculation : Form
    {
        public Calculation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            task1 tascOne = new task1();
            tascOne.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HeightLabel1.Text = "Висота";
            SpeedLabel2.Text = "Швидкість";
            MassLabel3.Text = "Маса";
            valueLabel.Text = "С/І";
            MassLabel3.Show();
            MassTextBox.Show();
            Height.Text = "";
            Speed.Text = "";
            MassTextBox.Text = "";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Height = 0.0;
            double Speed = 0.0;
            double Mass = 0.0;
            double Gravity = 9.8;

            try
            {
                Height = double.Parse(this.Height.Text);
                Speed = double.Parse(this.Speed.Text);
                Mass = double.Parse(this.MassTextBox.Text);

            }
            catch 
            {
                this.Height.Text = "";
                this.Speed.Text = "";
                this.MassTextBox.Text = "";
            }
            this.Height.Text = "";
            this.Speed.Text = "";
            this.MassTextBox.Text = "";

            double PotentialEnergy = 0.0;
            double Kinetic = 0.0;


            if( Height < 0)
            {
                MessageBox.Show("Висота не може бути від'ємною не може бути меншою 0.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Mass <= 0)
            {
                MessageBox.Show("Маса не може бути від'ємною", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HeightLabel1.Text = "Потенційна енергія";
                SpeedLabel2.Text = "Кінетична енергія";
                MassLabel3.Hide();
                MassTextBox.Hide();

                PotentialEnergy = Height * Gravity * Mass;
                Kinetic = (Mass * Math.Pow(Speed,2))/2;

                this.Height.Text = Math.Round(PotentialEnergy, 2).ToString();
                this.Speed.Text = Math.Round(Kinetic, 2).ToString();
            }
        }

        private void valueLabel_Click(object sender, EventArgs e)
        {

        }

        private void HeightLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SpeedLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
