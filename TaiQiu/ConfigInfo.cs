using System;
using System.Collections.Generic;
using System.Text;

namespace TQ
{
    public class ConfigInfo
    {
        public const string subkey = "tq";
        Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subkey);

        public void WriteOpacity(int value)
        {
            if(key !=null)
                key.SetValue("opacity", value);
           
        }

        public int GetOpacity()
        {
            if (key != null)
                return (int)key.GetValue("opacity",80);
            return 80;
        }

        public void WriteLineWidth(int value)
        {
            if(key!=null)
                key.SetValue("linewidth", value);
        }

        public int GetLineWidth()
        {
            if (key != null)
                return (int)key.GetValue("linewidth", 5);
            return 5;
        }

        public void WriteBallSize(int value)
        {
            if (key != null)
                key.SetValue("ballsize", value);
        }

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
