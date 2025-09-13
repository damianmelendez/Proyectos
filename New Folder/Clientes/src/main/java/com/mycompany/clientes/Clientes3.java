/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.clientes;

/**
 *
 * @author DELL
 */
public class Clientes3 extends Perssona {
    private String nit;
    private String direccion;

    public Clientes3() {
    }

    public Clientes3(String nit, String nombre, String apellidos, boolean genero) {
        super(nombre, apellidos, genero);
        this.nit = nit;
    }
    @Override
    public String toString() {
        return "Cliente{" + "nit=" + nit + ", nombres=" + nombre + ", apellidos=" + getApellidos() + ", direccion=" + direccion + ", genero=" + getGenero() + '}';
    }

    public String getNit() {
        return nit;
    }

    public void setNit(String nit) {
        this.nit = nit;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }
    
    public String darNit(){
    return nit;
    }
}
    