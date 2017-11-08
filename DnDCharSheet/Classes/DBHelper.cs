using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using SQLite;

namespace DnDCharSheet.Classes
{
    public class DBHelper
    {
        public static string STORAGE_PATH = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public static string DB_FILE = "db.db.";

        private static SQLiteAsyncConnection GetDatabaseContext()
        {
            string databasePath = Path.Combine(STORAGE_PATH, DB_FILE);
            return new SQLiteAsyncConnection(databasePath);
        }

        public static void CreateTable<T>() where T : new()
        {
            GetDatabaseContext().CreateTableAsync<T>();
        }
    }
}