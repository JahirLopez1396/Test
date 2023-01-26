package com.Test.Model;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.EntityListeners;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Table;

import java.util.Date;

//import org.springframework.data.annotation.CreatedDate;
import org.springframework.data.jpa.domain.support.AuditingEntityListener;


@Entity
@Table(name = "opefactura")
@EntityListeners(AuditingEntityListener.class)
public class OpeFactura {
	
	@Column(name = "idFactura")
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int idFactura;
	
	@Column(name = "idClienteRegistro")
	private int idClienteRegistro;
	
	@Column(name = "fechaRegistro")
	private Date fechaRegistro;
	
	@Column(name = "idProducto")
	private int idProducto;
	
	public OpeFactura() {
		
	}

	public OpeFactura(int idFactura, int idClienteRegistro, Date fechaRegistro, int idProducto) {
		this.idFactura = idFactura;
		this.idClienteRegistro = idClienteRegistro;
		this.fechaRegistro = fechaRegistro;
		this.idProducto = idProducto;
	}

	public int getIdFactura() {
		return idFactura;
	}

	public void setIdFactura(int idFactura) {
		this.idFactura = idFactura;
	}

	public int getIdClienteRegistro() {
		return idClienteRegistro;
	}

	public void setIdClienteRegistro(int idClienteRegistro) {
		this.idClienteRegistro = idClienteRegistro;
	}

	public Date getFechaRegistro() {
		return fechaRegistro;
	}

	public void setFechaRegistro(Date fechaRegistro) {
		this.fechaRegistro = fechaRegistro;
	}

	public int getIdProducto() {
		return idProducto;
	}

	public void setIdProducto(int idProducto) {
		this.idProducto = idProducto;
	}

	@Override
	public String toString() {
		return "OpeFactura [idFactura=" + idFactura + ", idClienteRegistro=" + idClienteRegistro + ", fechaRegistro="
				+ fechaRegistro + ", idProducto=" + idProducto + "]";
	}
	
	
}
