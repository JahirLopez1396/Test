package com.Test.Controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.Test.Model.*;
import com.Test.Repository.*;

@RestController
@RequestMapping("/api")
public class FacturaController {

	@Autowired
	private OpeFacturaRepository repository;
	
	@GetMapping("/factura/{idFactura}")
	public OpeFactura obtenerFactura(@PathVariable("idFactura") int idFactura){
		return repository.getById(idFactura);
	}
	
	@GetMapping("/factura/getAll")
	public List<OpeFactura> obtenerFacutras(){
		return repository.findAll();
	}
	
	@PostMapping("/factura")
	public OpeFactura createFactura(@RequestBody OpeFactura factura) {
		return repository.save(factura);
	}
	
	@PutMapping("/factura/{id}")
	public OpeFactura updateProducto(@PathVariable int id ,@RequestBody OpeFactura factura) {
		return repository.save(factura);
	}
	
	@DeleteMapping("/factura/{id}")
	public void deleteFactura(@PathVariable("idFactura") int idFactura) {
		repository.deleteById(idFactura);
	}
	
}
