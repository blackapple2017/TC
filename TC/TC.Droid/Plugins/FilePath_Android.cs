using System.IO;
using TC.Plugins;

namespace TC.Droid.Plugins
{
    public class FilePath_Android : IFilePath
    {
        public string DbPath()
        {
            return Path.Combine("/sdcard/Download/", "testdb.sql");
        }
    }
}