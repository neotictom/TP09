using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TP09.Models;
public class BD{

    private static string _connectionString = @"Server=.; Database=Usuario; Trusted_Connection=True";
    
    public static void AgregarUsuario (Usuario u){
        string sql = "INSERT INTO Usuario (NombreUsuario, Contraseña, Email, Telefono, Nombre, Apellido)" + "VALUES (@Usuario, @Contraseña, @Email, @Telefono, @Nombre, @Apellido);";
        using(SqlConnection conexion = new SqlConnection(_connectionString)){
            conexion.Execute(sql,u);
        }
    }
    public static void cambiarContrasena (Usuario u, string user)
    {
        string sql = "UPDATE Usuario SET Contraseña = @contrasena, Contraseña = @nuevaContrasena2 WHERE @Usuario = user;"; 
        using(SqlConnection conexion = new SqlConnection(_connectionString))
        {
            conexion.Execute(sql, u);
        }
    }
}