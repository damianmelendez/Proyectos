/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Modelos;

/**
 *
 * @author DELL
 */
public class Cliente extends Persona{

    public static String ge;
    private String Nit;
    private String Direccion;
    
    

    public Cliente() {
    }
    
    public Cliente(String Nit, String Nombre, String Apellido) {
        super(Nit, Nombre, false);
        this.Nit = Nit;
        this.Direccion = Direccion;
    }

    public Cliente(String Nit, String Direccion) {
        this.Nit = Nit;
        this.Direccion = Direccion;
    }

    public Cliente(String Nit, String Direccion, String Nombre, String Apellido, boolean Genero) {
        super(Nombre, Apellido, Genero);
        this.Nit = Nit;
        this.Direccion = Direccion;
    }
    

    public String getNit() {
        return Nit;
    }

    public void setNit(String Nit) {
        this.Nit = Nit;
    }

    public String getDireccion() {
        return Direccion;
    }

    public void setDireccion(String Direccion) {
        this.Direccion = Direccion;
    }

    @Override
    public String toString() {
        return "Cliente{" + "Nit=" + Nit + ", Nombres=" + getNombre() + ", Apellidos=" + getApellido() + ", Genero=" + isGenero() + ", Direccion=" + Direccion + '}';
    }

    @Override
    public String darNombreCompleto() {
        return getNombre()+" "+getApellido();
    }

    @Override
    public boolean darGenero() {
        return isGenero();
    }
    
    public String darNit(){
    return Nit;
    }
    
    public String darDireccion(){
    return Direccion;
    }
    
}
