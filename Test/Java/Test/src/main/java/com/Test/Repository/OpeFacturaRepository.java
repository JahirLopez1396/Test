package com.Test.Repository;

import java.util.List;
import org.springframework.data.repository.CrudRepository;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;
import com.Test.Model.OpeFactura;


@Repository
public interface OpeFacturaRepository extends JpaRepository<OpeFactura, Integer>{

}
