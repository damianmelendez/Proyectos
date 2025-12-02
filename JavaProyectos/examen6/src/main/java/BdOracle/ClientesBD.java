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
                resultado.add(new Cliente(rs.getString("Nit"), rs.getString("Nombres"), rs.getString("Apellidos")));
            }
            stmt.close();
            rs.close();
            BD.desconectar();
        } catch (Exception e) {
            try {
                System.out.println("errror qquery");
                e.printStackTrace();
                BD.desconectar();
            } catch (Exception e1) {
                System.out.println("error ao buscar");
                e1.printStackTrace();
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
                        rs.getString("Nit"),
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
                System.out.println("error query");
                e.printStackTrace();
                BD.desconectar();
            } catch (Exception e1) {
                System.out.println("error buscar");
                e1.printStackTrace();
            }
        }
    return resultado;
    }
    
    public boolean insertarDato(Cliente Cliente){
        try {
            String query = "INSERT INTO TELCLIENTE(NIT, NOMBRES, APELLIDOS, GENERO, DIRECCION)VALUES(?, ?, ?, ?, ?)";
            PreparedStatement stmt = BD.conectar().prepareStatement(query);
            stmt.setString(1, Cliente.getNit());
            stmt.setString(2, Cliente.getNombre());
            stmt.setString(3, Cliente.getApellido());
            stmt.setBoolean(4, Cliente.isGenero());
            stmt.setString(5, Cliente.getDireccion());
            stmt.executeUpdate();
            stmt.close();
            BD.desconectar();
            return true;
        } catch (Exception e) {
            try {
                System.out.println("error query");
                e.printStackTrace();
                BD.desconectar();
            } catch (Exception e1) {
                System.out.println("error insertar");
                e1.printStackTrace();
            }
        }
    return false;
    }
    public boolean actualizarDato(Cliente Cliente, String nitAnterior){
        try {
            String query = "UPDATE TELCLIENTE SET NIT=?, NOMBRES=?, APELLIDOS=?, GENERO=?, DIRECCION=?, WHERE NIT=?";
            PreparedStatement stmt = BD.conectar().prepareStatement(query);
            stmt.setString(1, Cliente.getNit());
            stmt.setString(2, Cliente.getNombre());
            stmt.setString(3, Cliente.getApellido());
            stmt.setBoolean(4, Cliente.isGenero());
            stmt.setString(5, Cliente.getDireccion());
            stmt.setString(6, nitAnterior);
            stmt.executeUpdate();
            stmt.close();
            BD.desconectar();
            return true;
        } catch (Exception e) {
            try {
                System.out.println("error query");
                e.printStackTrace();
                BD.desconectar();
            } catch (Exception e1) {
                System.out.println("error al actulizar");
                e1.printStackTrace();
            }
        }
    return false;
    }
    
    public int eliminarDato(String nit){
    int pocicion = -1;
        try {
            String query = "DELETE TELCLIENTE WHERE NIT=?";
            PreparedStatement stmt = BD.conectar().prepareStatement(query);
            stmt.setString(1, nit);
            pocicion = stmt.executeUpdate();
            
            stmt.close();
            BD.desconectar();
            return pocicion;
            
        } catch (Exception e) {
            try {
                System.out.println("error query");
                e.printStackTrace();
                BD.desconectar();
            } catch (Exception e1) {
                System.out.println("error al eliminar");
                e1.printStackTrace();
            }
        }
    return pocicion;
    }
}
