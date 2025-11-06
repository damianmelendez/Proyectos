/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package BdOracle;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 *
 * @author DELL
 */
public class BD {
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
            if (conexion != null && !conexion.isClosed()) {
                conexion.close(); 
                System.out.println("Conexión cerrada.");
            }
        } catch (SQLException e) {
            System.err.println("Error al cerrar la conexión.");
            e.printStackTrace();
        }
    }
    
}
