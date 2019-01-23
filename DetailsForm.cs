using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DataBicycle
{
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }

        // Properties for external access
        public string TextName
        {
            get => textName.Text;
            set => textName.Text = value;
        }

        public string TextCountry
        {
            get => textCountry.Text;
            set => textCountry.Text = value;
        }

        public string TextEffects
        {
            get => textEffects.Text;
            set => textEffects.Text = value;
        }

        public Image PictureBox
        {
            get => pictureBox.Image;
            set
            {
                var currentFolder = Directory.GetCurrentDirectory();
                pictureBox.Image = value ?? Properties.Resources.about;
            }
        }

        public string Title
        {
            set
            {
                Text = value;
            }
        }
    }
}
