/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package BdOracle;

import Modelos.Cliente;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;

/**
 *
 * @author DELL
 */
public class ClientesDB {
    
    public ArrayList<Cliente> consultarClientes(){
    ArrayList<Cliente> resultado = new ArrayList();
        try {
            String query = "SELECT * FROM TELCLIENTE";
            PreparedStatement stmt = BD.conectar().prepareStatement(query);
            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {
                resultado.add(new Cliente(rs.getString("nit"), rs.getString("nombres"), rs.getString("apellidos")));
            }
            stmt.close();
            rs.close();;
            BD.desconectar();
        } catch (Exception e) {
            try {
                System.out.println("error query: " + e.getMessage());
                e.printStackTrace();
                BD.desconectar();
            } catch (Exception e1) {
                System.out.println("error cierre: " + e1.getMessage());
            }
        }
    return resultado;
    }
    
    public Cliente consultarCliente(String nit){
    Cliente resultado = null;
        try {
            String query = "SELECT * FROM TELCLIENTE WHERE NIT=?";
            PreparedStatement stmt = BD.conectar().prepareStatement(query);
            stmt.setString(1, nit);
            
            ResultSet rs = stmt.executeQuery();
            
            while (rs.next()) {
                resultado = new Cliente(rs.getString("nit"), rs.getString("Direccion"),
                        rs.getString("Nombres"), rs.getString("Apellido"), rs.getBoolean("Genero"));
            }
            stmt.close();
            rs.close();
            BD.desconectar();
        } catch (Exception e) {
            try {
                System.out.println("error query" + e.getMessage());
                e.printStackTrace();
                BD.desconectar();
            } catch (Exception e1) {
                System.out.println("error cierre" + e1.getMessage());
            }
            resultado = null;
        }
    return resultado;
    }
    
    public boolean insertarDatos(){
    return false;
    }
    
}
