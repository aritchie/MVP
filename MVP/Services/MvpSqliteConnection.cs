using System;
using System.IO;
using SQLite;


namespace MVP.Services
{
    public class MvpSqliteConnection : SQLiteConnection
    {
        public MvpSqliteConnection() : base(Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "mvp.db"))
        {
        }
    }
}
