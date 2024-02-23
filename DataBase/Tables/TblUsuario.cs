using SQLite;

[Table("TBL_USUARIO")]

public class TblUsuario
{
    [PrimaryKey,AutoIncrement]
    public int ID { get; set; }

    public string USUARIO { get; set; }

    public string CONTRASENA {  get; set; }

    public string CORREO { get; set; }
}
