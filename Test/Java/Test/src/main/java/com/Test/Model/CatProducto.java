package com.Test.Model;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.EntityListeners;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Table;


//import org.springframework.data.annotation.CreatedDate;
import org.springframework.data.jpa.domain.support.AuditingEntityListener;

@Entity
@Table(name = "catproducto")
@EntityListeners(AuditingEntityListener.class)
public class CatProducto {
	
	
	@Column(name = "idProducto")
	@Id	
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int idProducto;
	
	@Column(name = "nombre")
	private String nombre;
	
	@Column(name = "precio")
	private double precio;
	
	@Column(name = "stock")
	private int stock;	
	
	public CatProducto() {
		
	}

	public CatProducto(int idProducto, String nombre, double precio, int stock) {
		this.idProducto = idProducto;
		this.nombre = nombre;
		this.precio = precio;
		this.stock = stock;
	}

	public int getIdProducto() {
		return idProducto;
	}

	public void setIdProducto(int idProducto) {
		this.idProducto = idProducto;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public double getPrecio() {
		return precio;
	}

	public void setPrecio(double precio) {
		this.precio = precio;
	}

	public int getStock() {
		return stock;
	}

	public void setStock(int stock) {
		this.stock = stock;
	}

	@Override
	public String toString() {
		return "CatProducto [idProducto=" + idProducto + ", nombre=" + nombre + ", precio=" + precio + ", stock="
				+ stock + "]";
	}
	
	
}
