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
public class ClientesBD {
    public ArrayList<Cliente> consultarClientes(){
    ArrayList<Cliente> resultado = new ArrayList();
        try {
            String query = "SELECT * FROM TELCLIENTE";
            PreparedStatement stmt = BD.conectar().prepareStatement(query);
            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {                
                resultado.add(new Cliente(
                        rs.getString("Nit"),
                        rs.getString("Nombres"),
                        rs.getString("Apellidos")));
            }
            stmt.close();
            rs.close();
            BD.desconectar();
        } catch (Exception e) {
            try {
                System.out.println("error query"+e.getMessage());
                e.printStackTrace();
                BD.desconectar();
            } catch (Exception e1) {
                System.out.println("error cliente"+e1.getMessage());
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
                resultado = new Cliente(
                        rs.getString("nit"),
                        rs.getString("Direccion"),
                        rs.getString("Nombres"),
                        rs.getString("Apellidos"),
                        rs.getBoolean("Genero")
                        
                );
            }
            stmt.close();
            rs.close();
            BD.desconectar();
        } catch (Exception e) {
            try {
                System.out.println("Error query");
                e.printStackTrace();
                BD.desconectar();
            } catch (Exception e1) {
                System.out.println("Error cierre");
            }
            resultado = null;
        }
        return resultado;
    }
    
    public boolean insertarDatos(Cliente Cliente){
        try {
            String query = "INSERT INTO TELCLIENTE(NIT, NOMBRES, APELLIDOS, GENERO, DIRECCION) VALUES(?, ?, ?, ?, ?)";
            PreparedStatement stmt = BD.conectar().prepareStatement(query);
            stmt.setString(1, Cliente.getNit());
            stmt.setString(2, Cliente.getNombre());
            stmt.setString(3, Cliente.getApellido());
            stmt.setBoolean(4, Cliente.isGenero());
            stmt.setString(5, Cliente.getDireccion());
            
            stmt.executeQuery();
            
            stmt.close();
            BD.desconectar();
            return true;
        } catch (Exception e) {
            try {
                System.out.println("error query"+e.getMessage());
                e.printStackTrace();
                BD.desconectar();
            } catch (Exception e1) {
                System.out.println("errror cliente"+e1.getMessage());
            }
            return false;
        }
    }
    
    public boolean actualizarCliente(Cliente Cliente, String nitAnterior){
        try {
            String query = "UPDATE TELCLIENTE SET NIT = ?, NOMBRES = ?, APELLIDOS = ?, GENERO = ?, DIRECCION = ? WHERE NIT = ?";
            PreparedStatement stmt = BD.conectar().prepareStatement(query);
            stmt.setString(1, Cliente.getNit());
            stmt.setString(2, Cliente.getNombre());
            stmt.setString(3, Cliente.getApellido());
            stmt.setBoolean(4, Cliente.isGenero());
            stmt.setString(5, Cliente.getDireccion());
            
            stmt.setString(6, nitAnterior);
            
            stmt.close();
            BD.desconectar();
            return true;
        } catch (Exception e) {
            try {
                System.out.println("errror query"+e.getMessage());
                e.printStackTrace();
                BD.desconectar();
            } catch (Exception e1) {
                System.out.println("error cliente"+e.getMessage());
            }
            return false;
        }
    }
    public int eliminarCliente(String nit){
        try {
            String query = "DELETE TELCLIENTE WHERE NIT=?";
            PreparedStatement stmt = BD.conectar().prepareStatement(query);
            stmt.setString(1, nit);
            
            int cantidad = stmt.executeUpdate();
            
            stmt.close();
            BD.desconectar();
            return cantidad;
            
        } catch (Exception e) {
            try {
                System.out.println("error query"+e.getMessage());
                e.printStackTrace();
                BD.desconectar();
            } catch (Exception e1) {
                System.out.println("error cliente"+e1.getMessage());
            }
            return -1;
        }
    }
}
