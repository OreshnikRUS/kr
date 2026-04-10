using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace KR_akimov
{
    internal static class ProductImageHelper
    {
        private static Image _defaultImage;

        public static Image GetProductImage(byte[] imageBytes)
        {
            Image image = TryCreateImage(imageBytes);
            if (image != null)
            {
                return image;
            }

            return new Bitmap(GetDefaultImage());
        }

        private static Image TryCreateImage(byte[] imageBytes)
        {
            if (imageBytes == null || imageBytes.Length == 0)
            {
                return null;
            }

            try
            {
                using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                using (Image image = Image.FromStream(memoryStream, true, true))
                {
                    return new Bitmap(image);
                }
            }
            catch
            {
                return null;
            }
        }

        private static Image GetDefaultImage()
        {
            if (_defaultImage != null)
            {
                return _defaultImage;
            }

            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Default.png");

            if (File.Exists(imagePath))
            {
                using (FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                using (Image image = Image.FromStream(fileStream, true, true))
                {
                    _defaultImage = new Bitmap(image);
                }
            }
            else
            {
                _defaultImage = CreatePlaceholderImage();
            }

            return _defaultImage;
        }

        private static Image CreatePlaceholderImage()
        {
            Bitmap bitmap = new Bitmap(220, 220);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            using (Font font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold))
            using (SolidBrush brush = new SolidBrush(Color.DimGray))
            using (StringFormat format = new StringFormat())
            {
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.Clear(Color.Gainsboro);
                graphics.DrawString("РќРµС‚ РёР·РѕР±СЂР°Р¶РµРЅРёСЏ", font, brush, new RectangleF(0, 0, bitmap.Width, bitmap.Height), format);
            }

            return bitmap;
        }
    }
}
