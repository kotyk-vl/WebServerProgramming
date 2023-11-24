using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.Versioning;

namespace SageBook.Common.Helpers
{
    public static class ImageHelper
    {
        [SupportedOSPlatform("windows")]
        public static byte[]? ImageToByteArray(Image imageIn)
        {
            if (imageIn != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageIn.Save(ms, ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            else
                return null;
        }

        [SupportedOSPlatform("windows")]
        public static Image? ImageFromByteArray(byte[] imageBytes)
        {
            if (imageBytes != null && imageBytes.Length > 0)
            {
                using var ms = new MemoryStream(imageBytes);
                return Image.FromStream(ms);
            }

            return null;
        }
    }
}