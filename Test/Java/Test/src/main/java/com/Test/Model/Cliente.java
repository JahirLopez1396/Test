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
@Table(name = "cliente")
@EntityListeners(AuditingEntityListener.class)
public class Cliente{
	
	@Column(name = "id_Cliente")
	@Id	
	@GeneratedValue(strategy = GenerationType.IDENTITY)	
	private int idCliente;
	
	@Column(name = "nombre")
	private String nombre;
	
	@Column(name = "apellido")
	private String apellido;
	
	@Column(name = "direccion")
	private String direccion;
	
	@Column(name = "telefono")
	private String telefono;
	
	@Column(name = "email")
	private String email;
	
	@Column(name = "esFrecuente")
	private Boolean esFrecuente;
	
	public Cliente() {
		
	}	
	
	public Cliente(int idCliente, String nombre, String apellido, String direccion, String telefono, String email,
			Boolean esFrecuente) {
		super();
		this.idCliente = idCliente;
		this.nombre = nombre;
		this.apellido = apellido;
		this.direccion = direccion;
		this.telefono = telefono;
		this.email = email;
		this.esFrecuente = esFrecuente;
	}	

	public int getIdCliente() {
		return idCliente;
	}

	public void setIdCliente(int idCliente) {
		this.idCliente = idCliente;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getApellido() {
		return apellido;
	}

	public void setApellido(String apellido) {
		this.apellido = apellido;
	}

	public String getDireccion() {
		return direccion;
	}

	public void setDireccion(String direccion) {
		this.direccion = direccion;
	}

	public String getTelefono() {
		return telefono;
	}

	public void setTelefono(String telefono) {
		this.telefono = telefono;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public Boolean getEsFrecuente() {
		return esFrecuente;
	}

	public void setEsFrecuente(Boolean esFrecuente) {
		this.esFrecuente = esFrecuente;
	}

	@Override
	public String toString() {
		return "Cliente [idCliente=" + idCliente + ", nombre=" + nombre + ", apellido=" + apellido + ", direccion="
				+ direccion + ", telefono=" + telefono + ", email=" + email + ", esFrecuente=" + esFrecuente + "]";
	}	

}
