using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

/*
 * USE:
 * Creates or loads an INI file in the same directory as your executable
 * named EXE.ini (where EXE is the name of your executable)
 * var MyIni = new IniFile();
 * 
 * Or specify a specific name in the current dir
 * var MyIni = new IniFile("Settings.ini");
 * 
 * Or specify a specific name in a specific dir
 * var MyIni = new IniFile(@"C:\Settings.ini");
 * 
 * 
 */

namespace Desktop_Organizer
{
    class IniSettings
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniSettings(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}