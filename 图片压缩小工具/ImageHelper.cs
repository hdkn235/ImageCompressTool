using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

namespace 图片压缩小工具
{
    public class ImageHelper
    {
        public Image ResourceImage;
        private ImageFormat imageFormat = ImageFormat.Jpeg;//输出图片的格式
        public string ErrMessage;

        /// <summary>
        /// 类的构造函数
        /// </summary>
        /// <param name="ImageFileName">图片文件的全路径名称</param>
        public ImageHelper(string ImageFileName)
        {
            //使用文件流读取图片 这样可以释放进程  不建议使用Image.FromFile()  读取后 释放不了进程
            using (FileStream fs = new FileStream(ImageFileName, FileMode.Open, FileAccess.Read))
            {
                ResourceImage = Image.FromStream(fs);
            }

            ErrMessage = "";
        }

        /// <summary> 
        /// 按照比例缩小图片 
        /// </summary> 
        /// <param name="srcImage">要缩小的图片</param> 
        /// <param name="percent">缩小比例</param> 
        /// <returns>缩小后的结果</returns> 
        public bool PercentImage(double percent, string targetFilePath)
        {
            // 缩小后的高度 
            int newH = int.Parse(Math.Round(ResourceImage.Height * percent).ToString());
            // 缩小后的宽度 
            int newW = int.Parse(Math.Round(ResourceImage.Width * percent).ToString());

            try
            {
                // 要保存到的图片 
                using (Bitmap b = new Bitmap(newW, newH))
                {
                    using (Graphics g = Graphics.FromImage(b))
                    {
                        // 设置画布的描绘质量
                        //g.CompositingQuality = CompositingQuality.HighQuality;
                        //g.SmoothingMode = SmoothingMode.HighQuality;

                        // 插值算法的质量 
                        g.InterpolationMode = InterpolationMode.Default;

                        g.DrawImage(ResourceImage, new Rectangle(0, 0, newW, newH), new Rectangle(0, 0, ResourceImage.Width, ResourceImage.Height), GraphicsUnit.Pixel);
                    }

                    ResourceImage.Dispose();
                    Image tempImage = (Image)b;
                    tempImage.Save(targetFilePath, ImageFormat.Jpeg);
                    tempImage.Dispose();
                }
                return true;
            }
            catch (Exception ex)
            {
                ErrMessage = ex.Message;
                return false;
            }
        }
    }
}
