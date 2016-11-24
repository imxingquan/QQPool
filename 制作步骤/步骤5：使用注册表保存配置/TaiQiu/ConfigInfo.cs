using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaiQiu
{
    public class ConfigInfo
    {
        public const string subkey = "TaiQiu";
        Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subkey);

        //写入透明度
        public void WriteOpacity(int value)
        {
            if (key != null)
                key.SetValue("opacity", value);
        }
        //获取透明度
        public int GetOpacity()
        {
            if (key != null)
                return (int)key.GetValue("opacity", 80);
            return 80;
        }
        //写入线宽
        public void WriteLineWidth(int value)
        {
            if (key != null)
                key.SetValue("linewidth", value);
        }
        //获取线宽
        public int GetLineWidth()
        {
            if (key != null)
                return (int)key.GetValue("linewidth", 5);
            return 5;
        }
        //写入球体大小
        public void WriteBallSize(int value)
        {
            if (key != null)
                key.SetValue("ballsize", value);
        }
        //获取球体大小
        public int GetBallSize()
        {
            if (key != null)
                return (int)key.GetValue("ballsize", 30);
            return 30;
        }
        ~ConfigInfo()
        {
            Close();
        }

        public void Close()
        {
            if (key != null)
                key.Close();
        }
    }
}
