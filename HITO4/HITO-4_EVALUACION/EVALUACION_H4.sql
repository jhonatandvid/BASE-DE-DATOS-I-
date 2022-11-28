CREATE DATABASE DEFENSA_HITO3_UNIFRANZITOS;
USE DEFENSA_HITO3_UNIFRANZITOS;

CREATE TABLE CAMPEONATO(
id_CAMPEONATO VARCHAR(12) PRIMARY KEY,
NOMBRE_CAMPEONATO VARCHAR(30) NOT NULL,
SEDE VARCHAR(20) NOT NULL
);

CREATE TABLE EQUIPO(
id_EQUIPO VARCHAR(12) PRIMARY KEY,
NOMBRE_EQUIPO VARCHAR(30) NOT NULL,
CATEGORIA VARCHAR(15) NOT NULL,
id_CAMPEONATO VARCHAR(12),
FOREIGN KEY (id_CAMPEONATO) REFERENCES CAMPEONATO (id_CAMPEONATO)
);

CREATE TABLE JUGADOR(
id_JUGADOR VARCHAR(12) PRIMARY KEY,
NOMBRES VARCHAR(30) NOT NULL,
APELLIDOS VARCHAR(30) NOT NULL,
ci VARCHAR(15) NOT NULL,
EDAD INTEGER,
id_EQUIPO VARCHAR(12),
FOREIGN KEY (id_EQUIPO) REFERENCES EQUIPO (id_EQUIPO)
);

INSERT INTO CAMPEONATO (id_CAMPEONATO,NOMBRE_CAMPEONATO,SEDE)
VALUES('camp-111','Campeonato Unifranz','El Alto')
,('camp-222','Campeonato Unifranz','Cochabamba');

INSERT INTO EQUIPO(id_EQUIPO,NOMBRE_EQUIPO,CATEGORIA,id_CAMPEONATO)
VALUES('equ-111','Google','varones','camp-111')
,('equ-222','404 Not found','varones','camp-111'),
('equ-333','girls unifranz','mujeres','camp-111');

INSERT INTO JUGADOR (id_JUGADOR,NOMBRES,APELLIDOS,CI,EDAD,id_EQUIPO)
VALUES('jug-111','Carlos','Villa','8997811LP',19,'equ-222'),
('jug-222','Pedro','Salas','8997822LP',20,'equ-222'),
('jug-333','Saul','Araj','8997833LP',21,'equ-222'),
('jug-444','Sandra','Solis','8997844LP',20,'equ-333'),
('jug-555','Ana','Mica','8997855LP',23,'equ-333');

select* from CAMPEONATO;
select* from EQUIPO;
select* from JUGADOR;

--EJEMPLOS
--MIN Y MAX
select min(jug.EDAD) EDAD_minima_DE_JUGADORES
from JUGADOR AS jug;
--MAX
select MAX(jug.EDAD) EDAD_minima_DE_JUGADORES
from JUGADOR AS jug;

--CONSULTAS
--EJERCICIO 1
select *
from JUGADOR as jug
where jug.id_EQUIPO = 'equ-333';
--EJERCICIO 2
ALTER function F1_CantidadJugadores ()
returns integer as 
begin
declare @resp int
		select @resp = count (jug.id_JUGADOR)
		from JUGADOR as jug
		return @resp
end;
select dbo.F1_CantidadJugadores() as Cantidad_jugadores
--EJERCICIO 3
ALTER function F2_CantidadJugadoresParam(@GENERO varchar(50))
returns int as 
begin
declare @resp int
		select @resp = count (jug.id_JUGADOR)
		from JUGADOR as jug
		inner join EQUIPO as eq on eq.id_EQUIPO=jug.id_EQUIPO
		where eq.CATEGORIA = @GENERO
		return @resp
end;
select dbo.F2_CantidadJugadoresParam('mujeres') as Cantidad_jugadores_v2
--EJERCICIO 4
ALTER function F3_PromedioEdades(@EDAD varchar(50),@GENERO varchar(50))
returns int as 
begin
declare @resp int
		select @resp = avg (jug.EDAD)
		from JUGADOR as jug
		inner join EQUIPO as eq on eq.id_EQUIPO=jug.id_EQUIPO
		where eq.CATEGORIA = @GENERO and jug.EDAD >@EDAD;
		return @resp
end;
select dbo.F3_PromedioEdades(21,'varones') as jugadores
select dbo.F3_PromedioEdades(21,'mujeres') as jugadores
--EJERCICIO 5
create function F4_ConcatItems(@nombre varchar(50),@equipo varchar(50),@sede varchar(50))
returns varchar(200) as 
begin
declare @respuesta varchar(200)
		select @respuesta = jug.NOMBRES +' ' + eq.NOMBRE_EQUIPO+' ' + cam.SEDE
		from JUGADOR as jug
		inner join EQUIPO as eq on eq.id_EQUIPO=jug.id_EQUIPO
		inner join CAMPEONATO AS cam on  cam.id_CAMPEONATO=eq.id_CAMPEONATO
		where jug.NOMBRES = @nombre and eq.NOMBRE_EQUIPO = @equipo and cam.SEDE=@sede
		return @respuesta
end;
--v2 concatenar
alter function F4_ConcatItems_v2(@nombre varchar(50),@equipo varchar(50),@sede varchar(50))
returns varchar(200) as 
begin
declare @respuesta varchar(200)
		select @respuesta = concat( jug.NOMBRES ,' ', eq.NOMBRE_EQUIPO,' ', cam.SEDE)
		from JUGADOR as jug
		inner join EQUIPO as eq on eq.id_EQUIPO=jug.id_EQUIPO
		inner join CAMPEONATO AS cam on  cam.id_CAMPEONATO=eq.id_CAMPEONATO
		where jug.NOMBRES = @nombre and eq.NOMBRE_EQUIPO = @equipo and cam.SEDE=@sede
		return @respuesta
end;
select dbo.F4_ConcatItems_v2('Carlos','404 Not found','El Alto') as jugadores
--FIBONACCI
create function fibo(@N int )
returns int as
begin
		declare @i int =3;
		declare @a int = 1;
		declare @b int = 1;
		while @i <= @N
		begin 
		declare @aux int = @a
		set @a = @b+@a
		set @b=@aux 
		set @i = @i + 1
		end 
		return @a
end;
select dbo.fibo(7) as fibonacci
alter function fibo_v2(@N int )
returns varchar(50) as
begin
      declare @resp varchar(50)
	  declare @aux int = 0;
	  while @aux <= @N
	  begin
	  set @aux = @aux + 1
	  set @resp = dbo.fibo(@aux)
	  end
      return  CONCAT( @resp,',') 
end;
select dbo.fibo_v2(6) as fibonacci
