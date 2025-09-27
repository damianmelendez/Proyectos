/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.formulario13;

/**
 *
 * @author DELL
 */
public abstract class Persona {
    private String Nombre;
    private String Apellido;
    private Boolean Genero;

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public String getApellido() {
        return Apellido;
    }

    public void setApellido(String Apellido) {
        this.Apellido = Apellido;
    }

    public Boolean isGenero() {
        return Genero;
    }

    public void setGenero(Boolean Genero) {
        this.Genero = Genero;
    }

    public Persona() {
    }

    public Persona(String Nombre, String Apellido, Boolean Genero) {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Genero = Genero;
    }
    
    public abstract String darNombreCompleto();
    public abstract Boolean darGenero();
    
}
