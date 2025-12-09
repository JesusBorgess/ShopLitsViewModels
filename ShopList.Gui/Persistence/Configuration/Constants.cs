using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopList.Gui.Persistence.Configuration
{
    public static class Constants
    {
        public const string DatabaseFileName =
            "ShopListDB.db3";
        public static string DatabasePath
            => Path.Combine(FileSystem.AppDataDirectory,
                DatabaseFileName);
        public const SQLite.SQLiteOpenFlags flags =
            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;
    }
}
