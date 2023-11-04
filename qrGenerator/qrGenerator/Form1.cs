using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
namespace qrGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text + ":" + textBox2.Text;
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap bitmap = encoder.Encode(message);
            pictureBox1.Image = bitmap as Image;
            SaveFileDialog save = new SaveFileDialog(); 
            save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp"; 
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                pictureBox1.Image.Save(save.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Andrews Chat config file|*.andrewschatconfig"; 
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                string filename = save.FileName;
                System.IO.File.WriteAllText(filename, textBox1.Text + ":" + textBox2.Text);
      
            }
        }
    }
}
