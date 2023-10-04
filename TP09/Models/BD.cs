using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TP09.Models;
public class BD{

    private static string _connectionString = @"Server=A-PHZ2-CIDI-049; Database=Usuario; Trusted_Connection=True";
    
    public static void AgregarUsuario (Usuario u){
        string sql = "INSERT INTO Usuario (NombreUsuario, Contraseña, Email, Telefono, Nombre, Apellido)" + "VALUES (@Usuario, @Contraseña, @Email, @Telefono, @Nombre, @Apellido);";
        using(SqlConnection conexion = new SqlConnection(_connectionString)){
            conexion.Execute(sql,new{
                Usuario = u.NombreUsuario,
                Contraseña = u.Contraseña,
                Email = u.Email,
                Telefono = u.Telefono,
                Nombre = u.Nombre,
                Apellido = u.Apellido
            });
        }
    }
    public static void cambiarContraseña (Usuario u,string user)
    {
        string sql = "UPDATE Usuario SET Contraseña = @contrasena, Contraseña = @nuevaContrasena2 WHERE @Usuario = user;"; 
        using(SqlConnection conexion = new SqlConnection(_connectionString))
        {
            conexion.Execute(sql, u);
        }
    }
}