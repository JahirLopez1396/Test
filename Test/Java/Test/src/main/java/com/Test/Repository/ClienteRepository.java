package com.Test.Repository;

import java.util.List;
import org.springframework.data.repository.CrudRepository;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;
import com.Test.Model.Cliente;

@Repository
public interface ClienteRepository extends JpaRepository<Cliente, Integer> {
	
	//Cliente getById(@Param("idCliente") int idCliente);	
	//List<Cliente> findAll();
	//Cliente save(Cliente cliente);
	//void deleteById(Cliente cliente);
	
}
