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
public class ProductoController {
	
	@Autowired
	private CatProductoRepository repository;
	
	@GetMapping("/producto/{idProducto}")
	public CatProducto obtenerProducto(@PathVariable("idProducto") int idProducto){
		return repository.getById(idProducto);
	}
	
	@GetMapping("/producto/getAll")
	public List<CatProducto> obtenerProdcutos(){
		return repository.findAll();
	}
	
	@PostMapping("/producto")
	public CatProducto createProducto(@RequestBody CatProducto producto) {
		return repository.save(producto);
	}
	
	@PutMapping("/producto/{id}")
	public CatProducto updateProducto(@PathVariable int id ,@RequestBody CatProducto producto) {
		return repository.save(producto);
	}
	
	@DeleteMapping("/producto/{id}")
	public void deleteProducto(@PathVariable("idProducto") int idProducto) {
		repository.deleteById(idProducto);
	}
}
