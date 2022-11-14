--FUNCIONES DE AGREGACION
--UNA FUNCION DE AGREGACION SE USAN DENTRO DE LA CLAUSULA SELECT Y EL NOMBRE DE LA FUNCION 
--VA A DEVOLVER UN UNICO VALOR (UNA FILA) Y ES APLICADO A UN GRUPO DE REGISTROS (A UNA COLUMNA DE LA TABLA).
--COUNT: DEVUELVE EL NUMERO DE REGISTROS DE LA SELECCION "COUNT(COLUMNA)"
--MAX: DEVUELVE EL VALOR MAS ALTO DE UN CAMPO ESPECIFICO "MAX(COL)"
--MIN: DEVUELVE EL VALOR MAS BAJO DE UN CAMPO ESPECIFICADO "MIN(COL)"
--AVG: CALCULA EL PROMEDIO DE LOS VALORES DE UN CAMPO DETERMINADO "AVG(COL)"
--SUM: SUMA TODOS LOS VALORES DE UN CAMPO DETERMINADO "SUM(COL)"
CREATE DATABASE hito_4_FUNCIONES;
USE hito_4_FUNCIONES;
CREATE TABLE ESTUDIATES(
ID_EST INT IDENTITY PRIMARY KEY NOT NULL,
NOMBRES VARCHAR(25) NOT NULL,
APELLIDOS VARCHAR(30) NOT NULL,
EDAD INT NOT NULL,
FONO INT NOT NULL,
EMAIL VARCHAR(100) NOT NULL,
DIRECCION VARCHAR(200) NOT NULL,
GENERO VARCHAR(15) NOT NULL,
ID_ES INT NOT NULL,
FOREIGN KEY (ID_ES) REFERENCES ESCUELA (ID_ES)
);
INSERT INTO ESTUDIATES(NOMBRES,APELLIDOS,EDAD,FONO,EMAIL,DIRECCION,GENERO,ID_ES)
VALUES('Miguel' ,'Gonzales Veliz', 20, 2832115, 'miguel@gmail.com', 'Av. 6 de Agosto', 'masculino',1)
,('Sandra' ,'Mavir Uria', 25, 2832116, 'sandra@gmail.com', 'Av. 6 de Agosto', 'femenino',1)
,('Joel' ,'Adubiri Mondar', 30, 2832117, 'joel@gmail.com', 'Av. 6 de Agosto', 'masculino',1),
('Andrea' ,'Arias Ballesteros', 21, 2832118, 'andrea@gmail.com', 'Av. 6 de Agosto', 'femenino',2),
('Santos' ,'Montes Valenzuela', 24, 2832119, 'santos@gmail.com', 'Av. 6 de Agosto', 'masculino',2);
------------------------------------------------------------
alter table ESTUDIATES ADD LICENCIA_DE_CONDUCIR BIT;

INSERT INTO ESTUDIATES(NOMBRES,APELLIDOS,EDAD,FONO,EMAIL,DIRECCION,GENERO,ID_ES,LICENCIA_DE_CONDUCIR)
VALUES('Anna' ,'Gonzales Veliz', 20, 2832115, 'miguel@gmail.com', 'Av. 6 de Agosto', 'femenino',1,1),
('Pepito' ,'Gonzales Veliz', 20, 2832115, 'miguel@gmail.com', 'Av. 6 de Agosto', 'masculino',2,0);
--------------------------------------------------------------

select * from ESTUDIATES
--uso del count
select COUNT(est.ID_EST) estudiantes_mujeres
from ESTUDIATES as est
where est.GENERO='femenino'
-----------------------------------------------------------
select AVG(est.EDAD) promedio_de_edad
from ESTUDIATES as est
------------------------------------------------------------
--EDAD USANDO EL MAX-----------------------
select max(est.EDAD) numero_de_estudiantes
from ESTUDIATES as est
where est.GENERO='masculino' or est.GENERO='femenino'
-----------------------------------------------
--EDAD USANDO EL MIN
select min(est.EDAD) EDAD_minima_DE_ESTUDIANTES
from ESTUDIATES AS est;
------------------------------------------------------------
select sum(EDAD) numero_de_estudiantes
from ESTUDIATES 
------------------------------------------------------------
--DETERMINAR LA CANTIDAD DE ESTUDIANTES
select COUNT(est.LICENCIA_DE_CONDUCIR) 
from ESTUDIATES as est
select COUNT(est.ID_EST) --SIEMPRE USAR EL PRIMARY KEY
from ESTUDIATES as est
-----------------------------------------------------------
--Determinar cuántos estudiantes hay en donde su apellido contenga la palabra el y ademas sea del genero
select COUNT(est.ID_EST)
from ESTUDIATES as est
where est.APELLIDOS like '%el%' AND est.GENERO='masculino';
--------------------------------------------------------------------------------
--Determinar cuántos estudiantes tiene una edad de 20
select COUNT(est.ID_EST)
from ESTUDIATES as est
where est.EDAD > 20 AND est.EDAD < 30 AND est.LICENCIA_DE_CONDUCIR = 1;
------------------------------------------------------------------------------
--USO DEL BETWEEN ESTE MIDE EL RANGO
select COUNT(est.ID_EST)
from ESTUDIATES as est
where est.EDAD BETWEEN 21 AND 29 AND est.LICENCIA_DE_CONDUCIR = 1;
--------------------------------------------------------------------------------
--Manejo de ER con funciones de agregación
CREATE TABLE ESCUELA(
ID_ES INT IDENTITY PRIMARY KEY NOT NULL,
NOMBRE VARCHAR(25) NOT NULL,
DIRECCION VARCHAR(50) NOT NULL,
TURNO VARCHAR(25) NOT NULL
);
INSERT INTO ESCUELA(NOMBRE,DIRECCION,TURNO)
VALUES('UESMA','6 DE AGOSTO/AV.SAVEDRA ','MAÑANA'),('CEFAE','6 DE MARZO/AV.JUAN PABLO II ','NOCHE');
SELECT * FROM ESCUELA
SELECT * FROM ESTUDIATES


--ESTUDIANTES QUE ESTEN INSCRITOS EN UESMA
SELECT COUNT(EST.ID_EST) ESTUDIANTES_DEL_COLEGIO_UESMA
FROM ESCUELA AS ESC
INNER JOIN ESTUDIATES AS EST ON ESC.ID_ES = EST.ID_ES
WHERE ESC.NOMBRE ='UESMA';
