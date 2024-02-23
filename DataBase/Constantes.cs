using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://learn.microsoft.com/es-es/dotnet/maui/data-cloud/database-sqlite?view=net-maui-8.0

namespace TesisApp.DataBase
{
    //Clase: Proporciona datos de configuración comunes
    //Constante almacena datos de configuración, como el nombre de archivo y
    //la ruta de acceso de la base de datos
    public static class Constantes
    {
        public const string DatabaseFilename = "TesisAppTodoSQLite.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath =>
        Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);



    }
}
