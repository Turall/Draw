using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color[] color = new Color[3] { Color.Red, Color.Green, Color.Blue };

        IFiqur fiqur = new Fiqur();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("Red");
            comboBox1.Items.Add("Green");
            comboBox1.Items.Add("Blue");

            comboBox2.Items.Add("Rectangle");
            comboBox2.Items.Add("Circle");
            comboBox2.Items.Add("Romb");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = comboBox1.SelectedIndex;
            if (comboBox2.Text == "Rectangle")
                fiqur.Rectangle(color[c]);
            else if (comboBox2.Text == "Circle")
                fiqur.Circle(color[c]);
        }
    }
}
