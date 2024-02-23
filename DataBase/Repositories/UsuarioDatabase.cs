using SQLite;

namespace TesisApp.DataBase.Repositories
{
    public class UsuarioDatabase
    {
        SQLiteAsyncConnection Database;

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constantes.DatabasePath, Constantes.Flags);
            var result = await Database.CreateTableAsync<TblUsuario>();
        }

        public async Task<List<TblUsuario>> ObtenerUsuariosAsync()
        {
            await Init();
            return await Database.Table<TblUsuario>().ToListAsync();
        }

        public async Task<TblUsuario> ObtenerUsuarioAsync(int id)
        {
            await Init();
            return await Database.Table<TblUsuario>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public async Task<int> GuardarUsuarioAsync(TblUsuario usuario)
        {
            await Init();
            if (usuario.ID != 0)
                return await Database.UpdateAsync(usuario);
            else
                return await Database.InsertAsync(usuario);
        }

        public async Task<int> borrarUsuarioAsync(TblUsuario usuario)
        {
            await Init();
            return await Database.DeleteAsync(usuario);
        }

    }
}
