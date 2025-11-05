package com.mycompany.formulario13;

// 1. Importaciones necesarias para SQL
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 * Esta clase maneja la conexión a la BD de Oracle.
 * Está basada en el código de tu imagen.
 *
 * @author DELL (¡y tu ayuda!)
 */
public class BDjava {

    private static String url = "jdbc:oracle:thin:@localhost:1521/XEPDB1";
    private static String usuario = "APP_FACTURACION";
    private static String pass = "654321";
    private static String clase = "oracle.jdbc.OracleDriver";
    public static Connection conexion = null;
    

    public static Connection conectar() {
        conexion = null;
        
        try {
            Class.forName(clase);
            conexion = DriverManager.getConnection(url, usuario, pass);
            System.out.println("¡CONEXIÓN EXITOSA a APP_FACTURACION!");

        } catch (ClassNotFoundException e) {
            System.err.println("Error: No se encontró el driver de Oracle.");
            e.printStackTrace();
        } catch (SQLException e) {
            System.err.println("Error: Fallo al conectarse a la base de datos.");
            e.printStackTrace();
        }
        return conexion;
    }

    public static void desconectar() {
        try {
            // Verifica si la conexión existe Y no está ya cerrada
            if (conexion != null && !conexion.isClosed()) {
                conexion.close(); // Cierra la conexión
                System.out.println("Conexión cerrada.");
            }
        } catch (SQLException e) {
            // Error al intentar cerrar
            System.err.println("Error al cerrar la conexión.");
            e.printStackTrace();
        }
    }
}