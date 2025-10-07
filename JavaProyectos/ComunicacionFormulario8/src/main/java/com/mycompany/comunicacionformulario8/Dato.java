/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.comunicacionformulario8;

/**
 *
 * @author DELL
 */
public class Dato {
   private String texto;

    public Dato() {
    }

    public Dato(String texto) {
        this.texto = texto;
    }

    public String getTexto() {
        return texto;
    }

    public void setTexto(String texto) {
        this.texto = texto;
    }

    @Override
    public String toString() {
        return "Dato{" + "texto=" + texto + '}';
    }
   
   
    
}
