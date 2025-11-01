/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.mavenproject2;

/**
 *
 * @author DELL
 */
public class Dato {
    private String Texto;

    public Dato() {
    }

    public Dato(String Texto) {
        this.Texto = Texto;
    }

    public String getTexto() {
        return Texto;
    }

    public void setTexto(String Texto) {
        this.Texto = Texto;
    }

    @Override
    public String toString() {
        return "Dato{" + "Texto=" + Texto + '}';
    }
    
}
