/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.formulario12;

/**
 *
 * @author DELL
 */
public class Cliente extends Persona{
    private String Nit;
    private String Direccion;

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

    public Cliente() {
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

    @Override
    public String toString() {
        return "Cliente{" + "Nit=" + Nit + ", Nombre=" + getNombre() + ", Apellido=" + getApellido() + ", Genero=" + isGenero() + ", Direccion=" + Direccion + '}';
    }

    @Override
    public String darNombreCompleto() {
        return getNombre()+""+getApellido();
    }

    @Override
    public boolean darGenero() {
        return isGenero();
    }
    
    private String darNit(){
    return Nit;
    }
    
    private String darDireccion(){
    return Direccion;
    }
    
}
