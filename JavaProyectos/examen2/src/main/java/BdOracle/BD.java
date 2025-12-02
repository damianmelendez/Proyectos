/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package BdOracle;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
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
    static PreparedStatement c;
    
    public static Connection Conectar(){
        try {
            Class.forName(clase);
            conexion = DriverManager.getConnection(url, usuario, pass);
            System.out.println("Coneccion exitosa a APP_FACTURACION");
        } catch (ClassNotFoundException e) {
            System.out.println("error no se encontro el driver de oracle");
            e.printStackTrace();
        } catch(SQLException e){
            System.out.println("error de coneccion a base de datos");
            e.printStackTrace();
        }
        return conexion;
    }
    
    public static void desconectar(){
        try {
            if (conexion != null && !conexion.isClosed()) {
                conexion.close();
                System.out.println("coneccion cerrada.");
            }
        } catch (Exception e) {
            System.out.println("error al cerrar la coneccion");
            e.printStackTrace();
        }
    }
    
}
