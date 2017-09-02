using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayImage.Copy
{
    public class ImageConvert
    {
        public static System.Drawing.Image ByteToImage(byte[] btImage)
        {
            System.Drawing.Image image = null;
            if (btImage.Length == 0)
                return null;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(btImage);
            if (ms == null)
            {
                Console.Write("null");
                
            } else
            {
                image = System.Drawing.Image.FromStream(ms);
            }
            
            return image;
        }
    }
}
