using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace 图片压缩小工具
{
    /// <summary>
    /// SaveType:保存方式 LimitSize：限制大小
    /// </summary>
    public enum SetKey
    {
        SaveType, LimitSize, Percent
    }

    public class CommonHelper
    {
        /// <summary>
        /// 得到注册表中配置信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetValue(string item, SetKey key)
        {
            RegisterHelper rh = new RegisterHelper();

            if (!rh.isExist(RegisterHelper.keyType.HKEY_CURRENT_USER, item))
            {
                rh.setValue(RegisterHelper.keyType.HKEY_CURRENT_USER, item, "SaveType", "1");//保存方式：1，保存到另一个文件夹  2，覆盖
                rh.setValue(RegisterHelper.keyType.HKEY_CURRENT_USER, item, "LimitSize", "512");//图片上限
                rh.setValue(RegisterHelper.keyType.HKEY_CURRENT_USER, item, "Percent", "0.95");//压缩率
            }
            return rh.getValue(RegisterHelper.keyType.HKEY_CURRENT_USER, item, key.ToString());
        }

        /// <summary>
        /// 保存配置信息到注册表
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetValue(string item, SetKey key, string value)
        {
            RegisterHelper rh = new RegisterHelper();
            rh.setValue(RegisterHelper.keyType.HKEY_CURRENT_USER, item, key.ToString(), value);
        }

    }
}
