using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBicycle
{
    public partial class Form2 : Form
    {



        // Свойства для доступа к элементам формы извне
        public string PropTextBox1
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        public string PropTextBox2
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }

        public string PropTextBox3
        {
            get
            {
                return textBox3.Text;
            }
            set
            {
                textBox3.Text = value;
            }
        }

        public Image PropPictureBox1Image
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                string currentFolder = Directory.GetCurrentDirectory();
                pictureBox1.Image = value ?? Image.FromFile(currentFolder + "\\about.jpg");
            }
        }

        public string PropTitle
        {
            set
            {
                Text = value;
            }
        }

        public Form2()
        {
            InitializeComponent();

        }


    }
}
