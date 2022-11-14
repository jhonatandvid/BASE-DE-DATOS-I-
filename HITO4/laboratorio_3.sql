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
LICENCIA_DE_CONDUCIR BIT not null,
FOREIGN KEY (ID_ES) REFERENCES ESCUELA (ID_ES)
);
INSERT INTO ESTUDIATES(NOMBRES,APELLIDOS,EDAD,FONO,EMAIL,DIRECCION,GENERO,ID_ES,LICENCIA_DE_CONDUCIR)
VALUES('Miguel' ,'Gonzales Veliz', 20, 2832115, 'miguel@gmail.com', 'Av. 6 de Agosto', 'masculino',1,0)
,('Sandra' ,'Mavir Uria', 25, 2832116, 'sandra@gmail.com', 'Av. 6 de Agosto', 'femenino',2,0)
,('Joel' ,'Adubiri Mondar', 30, 2832117, 'joel@gmail.com', 'Av. 6 de Agosto', 'masculino',3,0),
('Andrea' ,'Arias Ballesteros', 21, 2832118, 'andrea@gmail.com', 'Av. 6 de Agosto', 'femenino',4,0),
('Santos' ,'Montes Valenzuela', 24, 2832119, 'santos@gmail.com', 'Av. 6 de Agosto', 'masculino',1,0),
('Anna' ,'Gonzales Veliz', 20, 2832115, 'miguel@gmail.com', 'Av. 6 de Agosto', 'femenino',2,1),
('Pepito' ,'Gonzales Veliz', 20, 2832115, 'miguel@gmail.com', 'Av. 6 de Agosto', 'masculino',3,0);
------------------------------------------------------------

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
VALUES('San Simos','Cochabamba','mañana')
,('Andres Bello','El Alto','mañana-tarde')
,('Amor de Dios Fe y Alegria','El Alto','mañana-tarde')
,('Don Bosco','La paz','mañana-tarde-noche');

--MUESTRA EL VALOR DE PI
select pi() as PI;

SELECT * FROM ESCUELA
SELECT * FROM ESTUDIATES

--determinar cuantos estudiantes tienen licencia de conducir
select count(est.ID_EST)
from ESTUDIATES as est
where est.LICENCIA_DE_CONDUCIR =1;
--2
select count(est.ID_EST)
from ESTUDIATES as est
where est.EDAD < 20 AND est.LICENCIA_DE_CONDUCIR =1;
--3
select count(est.ID_EST)
from ESTUDIATES as est
INNER JOIN ESCUELA AS esc on esc.ID_ES=est.ID_ES
where esc.NOMBRE='Amor de Dios Fe y Alegria';
--4
select count(est.ID_EST)
from ESTUDIATES as est
INNER JOIN ESCUELA AS esc on esc.ID_ES=est.ID_ES
where esc.TURNO='mañana-tarde';
--5
select count(est.ID_EST)
from ESTUDIATES as est
INNER JOIN ESCUELA AS esc on esc.ID_ES=est.ID_ES
where est.EDAD>25 and esc.TURNO='tarde';
--6
select count(est.ID_EST)
from ESTUDIATES as est
INNER JOIN ESCUELA AS esc on esc.ID_ES=est.ID_ES
where est.EDAD>25 and esc.TURNO like '%tarde%';

--CREACION DE FUNCIONES EN SQL 

create function retorna_nombre_materia () 
returns varchar(20) as 
begin
RETURN 'BASE DE DATOS I'
end;
-------------------------------------------------------
create function retorna_nombre_materia_V2 () 
returns varchar(25) as 
begin
		DECLARE @NOMBRE VARCHAR(25);
		SET @NOMBRE ='BASE DE DATOS I';
		RETURN @NOMBRE;
end;
-------------------------------------------------------
create function retorna_nombre_materia_V3 (@NOMBREMATERIA VARCHAR(25)) 
returns varchar(25) as 
begin
		DECLARE @NOMBRE VARCHAR(25);
		SET @NOMBRE =@NOMBREMATERIA;
		RETURN @NOMBRE;
end;
--verificar si esta bien-------------------------------
select dbo.retorna_nombre_materia() as DBA;
select dbo.retorna_nombre_materia_V2() as DBA;
select dbo.retorna_nombre_materia_V3('base de datos II') as DBA;
--SE PUEDE USAR ALTER Y DROP---------------------------
ALTER function retorna_nombre_materia_V2 () 
returns varchar(25) as 
begin
		DECLARE @NOMBRE VARCHAR(25);
		SET @NOMBRE ='BASE DE DATOS II';
		RETURN @NOMBRE;
end;
--EJERCICIO 1------------------------------------------
create function SUMA_DE_3_NUMEROSS (@NUM1 INTEGER, @NUM2 INTEGER,@NUM3 INTEGER) 
returns INTEGER as 
begin
		DECLARE @RESPUESTA INTEGER;
		SET @RESPUESTA = @NUM1 + @NUM2+@NUM3;
		RETURN @RESPUESTA;
end;
SELECT dbo.SUMA_DE_3_NUMEROSS(5,5,5) AS SUMA;
---SUMA DE 2 NUMEROS
create function SUMA_DE_2_NUMEROSS () 
returns INTEGER as 
begin
		DECLARE @RESPUESTA INTEGER;
		SET @RESPUESTA = 10 + 5;
		RETURN @RESPUESTA;
end;
SELECT dbo.SUMA_DE_2_NUMEROSS() AS SUMA;
--RETORNE UN NOMBRE COMPLETO
ALTER function NOMBRE_COMPLETO (@NOMBRE VARCHAR(25), @APELLIDO VARCHAR(25)) 
returns VARCHAR(50) as 
begin
		DECLARE @RESPUESTA VARCHAR(50);
		SET @RESPUESTA = @NOMBRE +' '+ @APELLIDO;
		RETURN @RESPUESTA;
end;
SELECT dbo.NOMBRE_COMPLETO('JUAN','PEREZ') AS NOMBRE;
--PARA CASA HACER CALCULAR OPERACIONES ARITMETICAS 
CREATE FUNCTION OPERACION (@NUM1 INT, @NUM2 INT, @ACTION VARCHAR(25) ) 
RETURNS INTEGER AS
BEGIN
		DECLARE @RESPUESTA INTEGER;
		IF @ACTION = 'SUMA'
			SET @RESPUESTA = @NUM1 + @NUM2;
		IF @ACTION = 'RESTA'
			SET @RESPUESTA = @NUM1 - @NUM2;
		IF @ACTION = 'MULTIPLICACION'
			SET @RESPUESTA = @NUM1 * @NUM2;
		IF @ACTION = 'DIVICION'
			SET @RESPUESTA = @NUM1 / @NUM2;
			RETURN (@RESPUESTA);
END;
select dbo.OPERACION (4,8,'SUMA') Suma;
select dbo.OPERACION (4,0,'DIVICION') DIVICION;
--OTRO METODO V2
CREATE FUNCTION OPERACION_V2 (@NUM1 INT, @NUM2 INT, @ACTION VARCHAR(25) ) 
RETURNS INTEGER AS
BEGIN

		IF @ACTION = 'SUMA'
			RETURN  @NUM1 + @NUM2;
		IF @ACTION = 'RESTA'
			RETURN @NUM1 - @NUM2;
		IF @ACTION = 'MULTIPLICACION'
			RETURN @NUM1 * @NUM2;
		IF @ACTION = 'DIVICION'
			RETURN @NUM1 / @NUM2;
			RETURN 1;
END;
select dbo.OPERACION_V2 (4,8,'SUMA') Suma;
--OTRO METODO V3
CREATE FUNCTION OPERACION_V3 (@NUM1 INT, @NUM2 INT, @ACTION VARCHAR(25) ) 
RETURNS INTEGER AS
BEGIN

		IF @ACTION = 'SUMA'
			RETURN  @NUM1 + @NUM2;
		IF @ACTION = 'RESTA'
			RETURN @NUM1 - @NUM2;
		IF @ACTION = 'MULTIPLICACION'
			RETURN @NUM1 * @NUM2;
		IF @ACTION = 'DIVICION'
			RETURN @NUM1 / @NUM2;
			RETURN 1;
END;
---------------
--FUNCIONES DE AGREGACION 
SELECT COUNT(est.ID_ES) estudiantes
FROM ESTUDIATES as est
where est.EDAD > 25;
-----------------------------------
--crear una funcion que me permita saber cuantos estudiantes son mayores de cierta edad
create function mayores_a_cierta_edad (@EDAD INTEGER)
returns integer as
begin
	declare @RESPONSE INTEGER = 0;
	SELECT @RESPONSE = COUNT(est.ID_ES) 
    FROM ESTUDIATES as est
    where est.EDAD > @EDAD;
	RETURN @RESPONSE; 
end;
select dbo.mayores_a_cierta_edad (25) estudiantes;
----------------------------------
SELECT * FROM ESCUELA;
SELECT * FROM ESTUDIATES

----------------------------
--ejercicio 1

alter function mayores_a_cierta_edad_y_genero (@EDAD INTEGER,@genero varchar(25),@col varchar(25))
returns integer as
begin
	declare @RESPONSE INTEGER = 0;
	SELECT @RESPONSE = COUNT(est.ID_est) 
    FROM ESTUDIATES as est
	inner join ESCUELA as esc on est.ID_ES = esc.ID_ES
    where est.EDAD > @EDAD and est.GENERO = @genero and esc.NOMBRE = @col;
	RETURN @RESPONSE; 
end;
select dbo.mayores_a_cierta_edad_y_genero (20,'femenino','Andres Bello') estudiantes;
--ejercicio 2
--mostrar el ultimo registro de la tabla estudiantes
--v1
alter function estudiante_final ()
returns integer as
begin
	declare @RESPONSE INTEGER = 0;
	SELECT @RESPONSE = max(est.ID_est) 
    FROM ESTUDIATES as est
	RETURN @RESPONSE; 
end;
select dbo.estudiante_final();
---solo con condicion
	SELECT est.* 
    FROM ESTUDIATES as est
	where est.ID_EST = dbo.estudiante_final(); 


