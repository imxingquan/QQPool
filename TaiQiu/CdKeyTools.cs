﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Security.Cryptography;
using Microsoft.Win32;

namespace TQ
{
    public interface ICkKey
    {
        string GetCdKey(string key);
        string Seeds {get;set;} //密钥
    }

    public class CdKeyTools : ICkKey
    {
                
        public string GetCdKey()
        {   
            string key = "";
            if (!string.IsNullOrEmpty(Seeds))
                key = Seeds.Substring(0, 6);

            return getMd5Hash(getMd5Hash(getMd5Hash(key)));

        }

        public string GetCdKey(string key)
        {
            if (!string.IsNullOrEmpty(key))
                key = key.Substring(0, 6);
            return getMd5Hash(getMd5Hash(getMd5Hash(key)));
        }
               
        private string[] GetMoc()
        {
            string[] str = new string[3];
            ManagementClass mcCpu = new ManagementClass("win32_Processor");
            ManagementObjectCollection mocCpu = mcCpu.GetInstances();
            foreach (ManagementObject m in mocCpu)
            {
                str[0] = m["ProcessorId"].ToString();
            }
            
            ManagementClass mcHD = new ManagementClass("win32_logicaldisk");
            ManagementObjectCollection mocHD = mcHD.GetInstances();
            foreach (ManagementObject m in mocHD)
            {
                if (m["DeviceID"].ToString() == "C:")
                {
                    str[1] = m["VolumeSerialNumber"].ToString();
                    break;
                }
            }

            ManagementClass mcMAC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection mocMAC = mcMAC.GetInstances();
            foreach (ManagementObject m in mocMAC)
            {
                if ((bool)m["IPEnabled"])
                {
                    str[2] = m["MacAddress"].ToString();
                    break;
                }
            }
            
            return str;
        }


        public string Seeds
        {
            get
            {
                return GetMoc()[1];
            }
            set { }
            
        }

        public string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        public bool verifyMd5Hash(string input, string hash)
        {
            // Hash the input.
            string hashOfInput = getMd5Hash(input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void WriteRegister(string cdkey)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("tq");
            key.SetValue("cdkey", cdkey);
            key.Close();
        }

        public string GetRegisterCdkey()
        {
            RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("tq");
            if(key != null)
            {
                object obj = key.GetValue("cdkey");
                if (obj != null)
                    return obj.ToString();
            }
           
            return null;
        }
    }
}
