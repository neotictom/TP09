using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TP09.Models;
public class BD{

    private static string _connectionString = @"Server=.; Database=Usuarios; Trusted_Connection=True";
    
    public static void AgregarUsuario (Usuarios u){
        string sql = "INSERT INTO Usuario (NombreUsuario, Contraseña, Email, Telefono, Nombre, Apellido)" + "VALUES (@Usuario, @Contraseña, @Email, @Telefono, @Nombre, @Apellido);";
        using(SqlConnection conexion = new SqlConnection(_connectionString)){
            conexion.Execute(sql,new{
                NombreUsuario = u.Usuario,
                Contraseña = u.Contraseña,
                Email = u.Email,
                Telefono = u.Telefono,
                Nombre = u.Nombre,
                Apellido = u.Apellido
            });
        }
    }
    public static void cambiarContraseña (Usuarios u,string user)
    {
        string sql = "UPDATE Usuario SET Contraseña = @contrasena, Contraseña = @nuevaContrasena2 WHERE @NombreUsuario = user;"; 
        using(SqlConnection conexion = new SqlConnection(_connectionString))
        {
            conexion.Execute(sql, u);
        }
    }
    public static Usuarios GetUsuarioByUser(string id)
    {
        Usuarios user = null;
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Usuario WHERE Usuario = @Usuario";
            user = db.QueryFirstOrDefault<Usuarios>(sql, new { Usuario = id });
        }
        return user;
    }

}