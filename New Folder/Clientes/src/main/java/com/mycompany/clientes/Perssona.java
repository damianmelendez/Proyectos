/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.clientes;

/**
 *
 * @author DELL
 */
public class Perssona {
    public String nombre;
    private String apellidos;
    private boolean genero;

    public Perssona() {
    }

    public Perssona(String nombre, String apellidos, boolean genero) {
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.genero = genero;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellidos() {
        return apellidos;
    }

    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public boolean isGenero() {
        return genero;
    }

    public void setGenero(boolean genero) {
        this.genero = genero;
    }
    public boolean getGenero() {
        return genero;
    }
    
    public boolean darGenero(){
    return genero;
    }
}
