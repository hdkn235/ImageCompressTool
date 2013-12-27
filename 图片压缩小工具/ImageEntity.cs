using System;
using System.Collections.Generic;
using System.Text;

namespace 图片压缩小工具
{
    public class ImageEntity
    {
        private string imgName;

        public string ImgName
        {
            get { return imgName; }
            set { imgName = value; }
        }

        private string imgPath;

        public string ImgPath
        {
            get { return imgPath; }
            set { imgPath = value; }
        }

    }
}
