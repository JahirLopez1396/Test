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
public class ClienteController{
	
	@Autowired
	private ClienteRepository repository;
	
	@GetMapping("/cliente/{idCliente}")
	public Cliente obtenerCliente(@PathVariable("idCliente") int idCliente){
		return repository.getById(idCliente);
	}
	
	@GetMapping("/cliente/getAll")
	public List<Cliente> obtenerClientes(){
		return repository.findAll();
	}
	
	@PostMapping("/cliente")
	public Cliente createCliente(@RequestBody Cliente cliente) {
		return repository.save(cliente);
	}
	
	@PutMapping("/cliente/{id}")
	public Cliente updateCliente(@PathVariable int id ,@RequestBody Cliente cliente) {
		return repository.save(cliente);
	}
	
	@DeleteMapping("/cliente/{id}")
	public void deleteCliente(@PathVariable("idCliente") int idCliente) {
		repository.deleteById(idCliente);
	}
	
}