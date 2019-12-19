using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace PreAccountancy.Functions
{
    class Photos
    {
        public byte[] AddPhoto(System.Drawing.Image Photo)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Photo.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public Image GetPhoto(byte[] ComingByteArray)
        {
            using (MemoryStream ms = new MemoryStream(ComingByteArray))
            {
                Image Photo = Image.FromStream(ms);
                return Photo;
            }
        }
    }
}
