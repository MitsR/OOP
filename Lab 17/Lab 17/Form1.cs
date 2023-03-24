using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lab_17
{
    public partial class Form1 : Form
    {
        Romb romb;
        Graphics graphics;
        Pen pen;
        int xShift = 10, yShift = 10;
        public Form1()
        {
            InitializeComponent();

            graphics = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black, 2);
            romb = new Romb();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            foreach(char i in textBox1.Text)
            {
                if (!Char.IsDigit(i))
                    return;
            }

            if (textBox1.Text != "")
            {
                romb.diagonal = Convert.ToInt32(textBox1.Text);
                graphics.Clear(Color.White);
                romb.DrawRomb(graphics, pen, xShift, yShift);
            }

            
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (char i in textBox2.Text)
            {
                if (!Char.IsDigit(i))
                    return;
            }

            if (textBox2.Text != "")
            {
                romb.side = Convert.ToInt32(textBox2.Text);
                graphics.Clear(Color.White);
                romb.DrawRomb(graphics, pen, xShift, yShift);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var xmlSerializer = new XmlSerializer(typeof(Romb));
            var fs = new FileStream("RombSave.xml", FileMode.OpenOrCreate);

            xmlSerializer.Serialize(fs, romb);
            fs.Close();
        }

        private void LoadSerializableRomb()
        {
            if(File.Exists("RombSave.xml"))
            {
                var xmlSerializer = new XmlSerializer(typeof(Romb));
                var fs = new FileStream("RombSave.xml", FileMode.Open);

                romb = (Romb)xmlSerializer.Deserialize(fs);
                fs.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadSerializableRomb();

            graphics.Clear(Color.White);

            textBox1.Text = romb.diagonal.ToString();
            textBox2.Text = romb.side.ToString();

            romb.DrawRomb(graphics, pen, xShift, yShift);
        }
    }

    [Serializable]
    public class Romb
    {
        public float diagonal { get; set; }
        public float side { get; set; }

        public Romb()
        {
            diagonal = 0;
            side = 0;
        }

        public Romb(float Diagonal = 0, float Side = 0)
        {
            diagonal = Diagonal;
            side = Side;
        }

        public void DrawRomb(Graphics graphics, Pen pen, float xShift = 0, float yShift = 0)
        {
            if(side<=diagonal/2 || side == 0 || diagonal == 0) { return; }

            float height = (float)Math.Sqrt(Math.Pow(side, 2) - Math.Pow(diagonal / 2, 2));

                graphics.DrawLine(pen, diagonal / 2 + xShift, 0 + yShift, diagonal + xShift, height + yShift);
                graphics.DrawLine(pen, diagonal + xShift, height + yShift, diagonal / 2 + xShift, 2 * height + yShift);
                graphics.DrawLine(pen, diagonal / 2 + xShift, 2 * height + yShift, xShift, height + yShift);
                graphics.DrawLine(pen, xShift, height + yShift, diagonal / 2 + xShift, 0 + yShift);
  


        }
    }
}
