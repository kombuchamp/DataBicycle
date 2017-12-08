using System.Drawing;
using System.IO;


namespace DataBicycle.Core
{
    static class ImageReader
    {
        // Преобразует байт-код изображения
        // в объект класса Image
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
