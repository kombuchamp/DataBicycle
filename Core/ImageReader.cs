using System.Drawing;
using System.IO;


namespace DataBicycle.Core
{
    static class ImageReader
    {
        public static Image GetImage(byte[] image) 
        {
            if (image == null)
                return null;

            MemoryStream stream = new MemoryStream(image);
            Image picture = Image.FromStream(stream);
            return picture;
        }
    }
}
