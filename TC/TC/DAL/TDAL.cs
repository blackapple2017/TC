using MvvmCross.Platform;
using MvvmCross.Plugins.Sqlite;
using SQLite;
using TC.Plugins;

namespace TC.DAL
{
    public class TDAL
    {
        private IMvxSqliteConnectionFactory _IMvxSqliteConnectionFactory;
        private SQLiteConnection dbConnection;

        public TDAL()
        {
            _IMvxSqliteConnectionFactory = Mvx.Resolve<IMvxSqliteConnectionFactory>();

            IFilePath fp = Mvx.Resolve<IFilePath>();
            var dbPath = fp.DbPath();
            dbConnection = _IMvxSqliteConnectionFactory.GetConnection(dbPath);
        }

    }
}