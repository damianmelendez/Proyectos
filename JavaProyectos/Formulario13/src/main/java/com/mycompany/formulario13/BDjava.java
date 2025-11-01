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

    // --- DATOS DE TU CONEXIÓN (Tomados de tu imagen) ---
    
    // URL de conexión: apunta a tu máquina (localhost), al puerto 1521, 
    // y al servicio (SID) "XEPDB1".
    private static String url = "jdbc:oracle:thin:@localhost:1521/XEPDB1";
    
    // Usuario de la base de datos
    private static String usuario = "APP_FACTURACION";
    
    // Contraseña del usuario
    private static String pass = "123456"; // ¡Asegúrate que esta sea tu contraseña correcta!
    
    // El nombre de la clase del driver de Oracle
    private static String clase = "oracle.jdbc.OracleDriver";
    
    // Esta variable estática guardará la conexión para usarla en toda la app
    public static Connection conexion = null;
    
    // --------------------------------------------------


    /**
     * Método para establecer la conexión con la base de datos.
     * @return un objeto Connection (la conexión) o null si falla.
     */
    public static Connection conectar() {
        
        // Reiniciamos la conexión a null por si había un intento fallido
        conexion = null;
        
        try {
            // 1. Cargamos el driver de Oracle.
            // Le decimos a Java "prepárate para usar Oracle".
            Class.forName(clase);
            
            // 2. Intentamos obtener la conexión usando los datos
            // (url, usuario y contraseña)
            conexion = DriverManager.getConnection(url, usuario, pass);
            
            System.out.println("¡CONEXIÓN EXITOSA a APP_FACTURACION!");

        } catch (ClassNotFoundException e) {
            // Este error pasa si NO encuentra el driver (el .jar ojdbc8)
            // Pero como ya lo tienes en 'Dependencies', no debería pasar.
            System.err.println("Error: No se encontró el driver de Oracle.");
            e.printStackTrace();
        } catch (SQLException e) {
            // Este es el error más común:
            // - Contraseña incorrecta (ORA-01017)
            // - Base de datos no disponible (Listener refused)
            // - Usuario no existe, etc.
            System.err.println("Error: Fallo al conectarse a la base de datos.");
            e.printStackTrace();
        }
        
        // 3. Devolvemos la conexión (será 'null' si falló)
        return conexion;
    }

    /**
     * Método para cerrar la conexión a la base de datos.
     * Es MUY importante llamarlo cuando ya no uses la BD.
     */
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

    /**
     * Este es un método main para probar la conexión rápidamente.
     * Puedes ejecutar este archivo para ver si se conecta.
     */
    public static void main(String[] args) {
        
        System.out.println("--- Probando Conexión ---");
        
        // 1. Intenta conectar
        conectar();
        
        // 2. Pequeña pausa
        try {
            Thread.sleep(1000); // Espera 1 segundo
        } catch (InterruptedException e) {}
        
        // 3. Intenta desconectar
        desconectar();
        
        System.out.println("--- Fin de la Prueba ---");
    }
}