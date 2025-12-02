/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package bdOracle;

import java.sql.Connection;
import java.sql.DriverManager;

/**
 *
 * @author DELL
 */
public class BD {
    private static String url = "jdbc:oracle:thin:@localhost:1521/XEPDB1";
    private static String usuario = "APP_FACTURACION";
    private static String pass = "654321";
    private static String clase = "oracle.jdbc.OracleDriver";
    private static Connection conexion = null;
    
    public static Connection conectar(){
    conexion = null;
        try {
            Class.forName(clase);
            conexion = DriverManager.getConnection(url, usuario, pass);
            System.out.println("coneccion exitosa");
        } catch (ClassNotFoundException e) {
            System.out.println("no se encontro en driver de oracle");
            e.printStackTrace();
        } catch (Exception e){
            System.out.println("conexion fallo");
            e.printStackTrace();
        }
    return conexion;
    }
    
    public static void desconectar(){
        try {
            if (conexion != null && !conexion.isClosed()) {
                conexion.close();
                System.out.println("desconectado");
            }
        } catch (Exception e) {
            System.out.println("error desconectar");
        }
    }
}
