using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TP09.Models;
public class BD{

    private static string _connectionString = @"Server=.; Database=Login; Trusted_Connection=True";
    
 public static void AgregarUsuario(Usuarios u)
{
    string sql = "INSERT INTO Usuario (NombreUsuario, Contraseña, Email, Telefono, Nombre, Apellido)" + 
                 "VALUES (@NombreUsuario, @Contraseña, @Email, @Telefono, @Nombre, @Apellido);";
    using (SqlConnection conexion = new SqlConnection(_connectionString))
    {
        conexion.Execute(sql, new
        {
            NombreUsuario = u.NombreUsuario,
            Contraseña = u.Contraseña,
            Email = u.Email,
            Telefono = u.Telefono,
            Nombre = u.Nombre,
            Apellido = u.Apellido
        });
    }
}

    public static void CambiarContraseña(string user, string contrasena, string nuevaContrasena)
    {
    string sql = "UPDATE Usuario SET Contraseña = @nuevaContrasena WHERE NombreUsuario = @NombreUsuario;";
    using (SqlConnection conexion = new SqlConnection(_connectionString))
    {
        conexion.Execute(sql, new { NombreUsuario = user, nuevaContrasena });
    }
    }

    public static Usuarios GetUsuarioByUserName(Usuarios u)
{
    Usuarios user = null;
    using (SqlConnection db = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM Usuario WHERE NombreUsuario = @NombreUsuario";
        user = db.QueryFirstOrDefault<Usuarios>(sql, new { NombreUsuario = u.NombreUsuario });
    }
    return user;
}


}


