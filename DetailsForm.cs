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
    public partial class DetailsForm : Form
    {
        // Properties for external access
        public string TextName
        {
            get
            {
                return textName.Text;
            }
            set
            {
                textName.Text = value;
            }
        }

        public string TextCountry
        {
            get
            {
                return textCountry.Text;
            }
            set
            {
                textCountry.Text = value;
            }
        }

        public string TextEffects
        {
            get
            {
                return textEffects.Text;
            }
            set
            {
                textEffects.Text = value;
            }
        }

        public Image PictureBox
        {
            get
            {
                return pictureBox.Image;
            }
            set
            {
                string currentFolder = Directory.GetCurrentDirectory();
                pictureBox.Image = value ?? Image.FromFile(currentFolder + "\\about.jpg");
            }
        }

        public string Title
        {
            set
            {
                Text = value;
            }
        }

        public DetailsForm()
        {
            InitializeComponent();
        }


    }
}
