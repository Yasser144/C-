using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormatChanged += FormatText;
            form2.StyleChange += getOldStyle;
            form2.Show();

           // Form2 f = new Form2();
           // f.FormatChanged += FormatText;
           // f.StyleChange += getOldStyle;
          
        }



        private FontStyle getOldStyle()
        {
            FontStyle oldStyle = textBox1.Font.Style;
            return oldStyle;
        }

        private void FormatText(Color c, Font f)
        {
            textBox1.ForeColor = c;
            textBox1.Font = f;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Trainees trainees = new Trainees();
            //  trainees.Name = textBox1.Text;
            Form2 form2 = new Form2();
            form2.FormatChanged += FormatText;
            form2.StyleChange += getOldStyle;
            form2.Show();

            

            //form2.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
