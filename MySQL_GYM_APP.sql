
/*Base de datos creada en MySQL con MySQL Workbench*/

/*Se ha utilizado los siguientes parámetros para la conexión*/
-- localhost  
-- username: root  
-- password: root


CREATE SCHEMA `GYM_APP` ;

CREATE TABLE `GYM_APP`.`EJERCICIOS` (
  `nombre` VARCHAR(45) NOT NULL,
  `tipo` VARCHAR(45) NOT NULL,
  `comentarios` VARCHAR(255) NULL,
  `img_ejercicio` LONGBLOB NULL,
  PRIMARY KEY (`nombre`));
  
  CREATE TABLE `GYM_APP`.`USUARIOS` (
  `usuario` VARCHAR(45) NOT NULL,
  `contrasena` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`USUARIO`));
  
CREATE TABLE `GYM_APP`.`PLANING` (
   `usuario` VARCHAR(20) NOT NULL,
   `dia` VARCHAR(10) NOT NULL,
   `ejercicio` VARCHAR(45) NOT NULL,
   `repes` VARCHAR(45) NOT NULL,
   `Comentarios` VARCHAR(45) NULL,
   CONSTRAINT `fk_planing_ejercicio` FOREIGN KEY (`ejercicio`)
     REFERENCES `GYM_APP`.`Ejercicios` (`nombre`)
     ON DELETE CASCADE,
   CONSTRAINT `fk_planing_usuarios` FOREIGN KEY (`usuario`)
     REFERENCES `GYM_APP`.`USUARIOS` (`usuario`)
     ON DELETE CASCADE);    

 
 /*Introducir las imagenes manualmente. Están en la carpeta imágenes del proyecto*/
     
     
 /***********************Procedimiento para CREAR USUARIO***********************/
USE `GYM_APP`;
DROP procedure IF EXISTS `CrearUsuario`;

DELIMITER $$
USE `GYM_APP`$$
CREATE PROCEDURE `CrearUsuario`(
		IN `Inombre` VARCHAR(45),
		IN `Icontrasena` VARCHAR(45)
    )
BEGIN
  DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        ROLLBACK;
        RESIGNAL;
    END;

    START TRANSACTION;
  
    SET @sql = CONCAT('CREATE USER ''', Inombre, ''' IDENTIFIED BY ''', Icontrasena, '''');
    PREPARE stmt FROM @sql;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
    
    SET @sql = CONCAT('GRANT SELECT ON GYM_APP.PLANING TO ''', Inombre, '''');
    PREPARE stmt FROM @sql;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
    
    SET @sql = CONCAT('GRANT SELECT ON GYM_APP.EJERCICIOS TO ''', Inombre, '''');
    PREPARE stmt FROM @sql;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
    
	INSERT INTO `GYM_APP`.`USUARIOS` (USUARIO, CONTRASENA) VALUES (Inombre, Icontrasena);
	COMMIT;
END;$$
DELIMITER ;

 /**********************Procedimiento para ELIMINAR USUARIO************************/
USE `GYM_APP`;
DROP procedure IF EXISTS `EliminarUsuario`;

DELIMITER $$
USE `GYM_APP`$$
CREATE PROCEDURE `EliminarUsuario`(
    IN `Inombre` VARCHAR(45)
)
BEGIN
    DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        ROLLBACK;
        RESIGNAL;
    END;

    START TRANSACTION;
  
    SET @sql = CONCAT('DROP USER IF EXISTS ''', Inombre, '''@''%''');
    PREPARE stmt FROM @sql;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;

    DELETE FROM `GYM_APP`.`USUARIOS` WHERE USUARIO = Inombre;

    COMMIT;
END;$$
DELIMITER ;

