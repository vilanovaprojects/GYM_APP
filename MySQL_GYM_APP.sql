
/*Base de datos creada en MySQL con MySQL Workbench*/

/*Se ha utilizado los siguientes parámetros para la conexión*/
-- localhost  
-- username: root  
-- password: root


CREATE SCHEMA `GYM_APP` ;

CREATE TABLE `GYM_APP`.`Ejercicio` (
  `nombre` VARCHAR(45) NOT NULL,
  `tipo` VARCHAR(45) NOT NULL,
  `comentarios` VARCHAR(255) NULL,
  `img_ejercicio` LONGBLOB NULL,
  PRIMARY KEY (`nombre`));
  
CREATE TABLE `GYM_APP`.`PLANING` (
   `dia` VARCHAR(10) NOT NULL,
   `ejercicio` VARCHAR(45) NOT NULL,
   `repes` VARCHAR(45) NOT NULL,
   `Comentarios` VARCHAR(45) NULL);
   
/*TRUNCATE `GYM_APP`.`PLANING`;
Commit;*/
 
 /*Introducir las imagenes manualmente. Están en la carpeta imágenes del proyecto*/
     
     
 /*--------------------Insertar/Actualizar contacto-----------------------*/
USE `GYM_APP`;
DROP procedure IF EXISTS `IARegistro`;

DELIMITER $$
USE `GYM_APP`$$
CREATE PROCEDURE `IARegistro` (
  IN `operacion` VARCHAR(1),
  IN `Inombre` VARCHAR(45),
  IN `Itipo` VARCHAR(45),
  IN `Icomentarios` VARCHAR(255),
  IN `Iimagen` LONGBLOB
)
BEGIN
  IF operacion = 'I' THEN      /* Insertar */
    INSERT INTO Ejercicio (nombre, tipo, comentarios, img_ejercicio)
    VALUES (Inombre, Itipo, Icomentarios, Iimagen);
  ELSEIF operacion = 'A' THEN /* Actualizar */
    UPDATE Ejercicio
    SET nombre = Inombre, tipo = Itipo, comentarios = Icomentarios, img_ejercicio = Iimagen
    WHERE nombre = Inombre ;
  END IF;
END;$$

DELIMITER ;
/*--------------------Insertar/Actualizar contacto-----------------------*/

/*--------------------Seleccionar/Eliminar contacto-----------------------*/
USE `GYM_APP`;
DROP procedure IF EXISTS `BERegistro`;
DELIMITER $$
USE `GYM_APP`$$
CREATE PROCEDURE `BERegistro`(
	   IN `operacion` VARCHAR(1),
       IN `Inombre` VARCHAR(45)
    )
BEGIN
    IF operacion = 'S' THEN        /*Seleccionar un Registro*/
		SELECT * FROM Ejercicio WHERE nombre = Inombre;
    ELSEIF operacion = 'E'  THEN       /*Eliminar*/
		DELETE FROM Ejercicio WHERE nombre = Inombre;
    ELSE 
		SELECT * FROM Ejercicio;
    END IF;
END;$$

DELIMITER ;

/*--------------------Seleccionar/Eliminar contacto-----------------------*/


/*--------------------Read-----------------------*/
USE `GYM_APP`;
DROP procedure IF EXISTS `Readonly`;

DELIMITER $$
USE `GYM_APP`$$
CREATE PROCEDURE `Readonly`()
BEGIN
	SELECT * FROM Ejercicio;
END;$$

DELIMITER ;
/*--------------------Read-----------------------*/

/*--------------------Read PLANING-----------------------*/
USE `GYM_APP`;
DROP procedure IF EXISTS `Readplan`;

DELIMITER $$
USE `GYM_APP`$$
CREATE PROCEDURE `Readplan`(
		IN `Idia` VARCHAR(10)
		)
BEGIN
    SELECT e.nombre, e.tipo, p.repes, p.Comentarios, e.img_ejercicio
	FROM Ejercicio e
	INNER JOIN PLANING p ON e.nombre = p.ejercicio
	WHERE p.dia = Idia;
END;$$

DELIMITER ;
/*--------------------Read PLANING-----------------------*/


