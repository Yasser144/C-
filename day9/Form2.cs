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
    public delegate void OnColorChange(Color color, Font f);
    public delegate FontStyle OnstyleChange();

    public partial class Form2 : Form
    {
        // public delegate void OnFontChange(int font);
        //  public delegate void OnColorChange(Color color);
        ///   public event OnColorChange ColorChanged;
        //  public event OnFontChange FontChanged;

        public event OnColorChange FormatChanged;
        public event OnstyleChange StyleChange;
        public FontStyle style { get; set; }
        //FontStyle[] s = new FontStyle[3];

        public Form2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color color = getColor();
            Font f = getFontFormat();
            FormatChanged.Invoke(color, f);
            style = StyleChange.Invoke();
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        public Color getColor()
        {

            if (radioButton1.Checked)
            {
                return Color.Red;
            }
            else if (radioButton2.Checked)
            {
                return Color.Blue;
            }
            else if (radioButton3.Checked)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    return colorDialog1.Color;
                }
                //Calnce
                return Color.Black;
            }
            else
            {
                return Color.Black;
            }


        }






        public FontStyle GetStyle()
        {
            
            if (bBtn.Checked)
            {
                return FontStyle.Bold | style;
            }
            else if (uBtn.Checked)
            {
                return FontStyle.Underline | style;
            }
            else if (iBtn.Checked)
            {
                return FontStyle.Italic | style;
            }
            else
            {
                //nothing cheked
                return FontStyle.Regular;
            }

        }

        public Font getFontFormat()
        {
            string fontName = "";
            if (comboBox2.SelectedItem == null)
            {
                fontName = "Times New Roman";
            }
            else
            {
                fontName = comboBox2.SelectedItem.ToString();
            }
            float size = (float)numericUpDown1.Value;
            FontStyle s = GetStyle();
            
            Font f = new Font(fontName, size, s);
            return f;
        }


        private void bBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void uBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
