using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KSUID;

namespace Apollo.Misc
{
    public static class Helpers
    {

        public static List<string> ReturnCheckboxCheckedTextFromControl(Control control)
        {
            List<string> result = new List<string>();

            foreach (CheckBox checkBox in control.Controls)
            {
                if (checkBox.Checked)
                {
                    result.Add(checkBox.Text);
                }
            }

            return result;
        }

        public static void CreateOrReplaceFile(string path, string content)
        {
            File.WriteAllText(path, content);
        }

        public static void CreateDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        public static string GetMD5File(string file)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(file))
                {
                    var hashBytes = md5.ComputeHash(stream);
                    var sb = new StringBuilder();
                    foreach (var t in hashBytes)
                    {
                        sb.Append(t.ToString("X2"));
                    }
                    return sb.ToString();
                }
            }
        }

        public static string SanitizeObjectToString(object value)
        {
            if (value != null)
            {

                return value.ToString();
            }

            return string.Empty;
        }

        public static string GenerateUID()
        {
            return Ksuid.Generate().ToString();
        }

        public static void CreateLog(string content, bool isError = false)
        {
            string typeLine = isError ? "[ X ]" : "[ * ]";

            content = string.Format("\n\n{0} {1} [{2}-{3}]", typeLine, content, DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
            File.AppendAllText(string.Format(@"Logs\{0}\Log.txt", DateTime.Now.ToShortDateString().Replace("/", null)), content);
        }
    }
}

public static class ISynchronizeInvokeExtensions
{
    public static void InvokeEx<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke
    {
        try
        {
            if (@this.InvokeRequired)
            {
                @this.Invoke(action, new object[] { @this });
            }
            else
            {
                action(@this);
            }
        }
        catch (Exception)
        {

        }
    }
}