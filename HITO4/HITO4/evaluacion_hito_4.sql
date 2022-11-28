create database defensa_hito4;
use defensa_hito4;
--recrear la base de datos unifranzitos
create table CAMPEONATO(
id_CAMPEONATO VARCHAR(12) PRIMARY KEY NOT NULL,
NOMBRE_CAMPEONATO VARCHAR(30) NOT NULL,
SEDE VARCHAR(20) NOT NULL
);

create table EQUIPO(
ID_EQUIPO VARCHAR(12)PRIMARY KEY NOT NULL,
NOMBRE_EQUIPO VARCHAR(30) NOT NULL,
CATEGORIA VARCHAR(8) NOT NULL,
id_CAMPEONATO VARCHAR(12) NOT NULL,
FOREIGN KEY (id_CAMPEONATO) REFERENCES CAMPEONATO (id_CAMPEONATO),
);

CREATE TABLE JUGADOR(
id_JUDAGOR VARCHAR(12) PRIMARY KEY NOT NULL,
NOMBRES VARCHAR(30) not null,
APELLIDOS VARCHAR(50) not null,
CI   varchar(15) not null,
EDAD INTEGER not null,
ID_EQUIPO VARCHAR(12) not null,
FOREIGN KEY (ID_EQUIPO) REFERENCES EQUIPO (ID_EQUIPO)
);
--insertando valores
INSERT INTO CAMPEONATO (id_CAMPEONATO,NOMBRE_CAMPEONATO,SEDE)
VALUES('camp-111','Campeonato Unifranz','El Alto'),
      ('camp-222','Campeonato Unifranz','Cochabamba');
INSERT INTO EQUIPO(ID_EQUIPO,NOMBRE_EQUIPO,CATEGORIA,id_CAMPEONATO)
VALUES('equ-111','Google','varones','camp-111'),
      ('equ-222','404 Not found','varones','camp-111'),
      ('equ-333','girls unifranz','mujeres','camp-111');
INSERT INTO JUGADOR (id_JUDAGOR,NOMBRES,APELLIDOS,CI,EDAD,ID_EQUIPO)
VALUES('jug-111','Carlos','Villa','8997811LP',19,'equ-222'),
	  ('jug-222','Pedro','Salas','8997822LP',20,'equ-222'),
	  ('jug-333','Saul','Araj','8997833LP',21,'equ-222'),
	  ('jug-444','Sandra','Solis','8997844LP',20,'equ-333'),
	  ('jug-555','Ana','Mica','8997855LP',23,'equ-333');
--EJERCICIO 1
--INCISO A)
select jug.NOMBRES, jug.APELLIDOS,eq.CATEGORIA, cam.NOMBRE_CAMPEONATO,cam.SEDE
from EQUIPO as eq
inner join CAMPEONATO as cam on cam.id_CAMPEONATO=eq.id_CAMPEONATO
inner join JUGADOR as jug on jug.ID_EQUIPO=eq.ID_EQUIPO
where eq.CATEGORIA='mujeres' and cam.SEDE='El Alto' AND cam.id_CAMPEONATO='camp-111' 
--INSISO B)
select COUNT(jug.id_JUDAGOR)
from EQUIPO as eq
inner join JUGADOR as jug on jug.ID_EQUIPO=eq.ID_EQUIPO
where eq.NOMBRE_EQUIPO='Google' and eq.CATEGORIA='varones' and jug.APELLIDOS like 'M%'
--EJERCICIO 2

alter function type_client (@credit_number integer) 
returns varchar(15) as 
begin
		DECLARE @RESPUESTA VARCHAR(15);
		IF @credit_number > 50000
			SET @RESPUESTA = 'PLATINIUM';
		IF @credit_number >= 10000 and @credit_number<= 50000
			SET @RESPUESTA = 'GOLD';
		IF @credit_number <= 10000
			SET @RESPUESTA = 'SILVER';
			RETURN (@RESPUESTA);

end;
--v2 
alter function type_client_v2 (@credit_number integer) 
returns varchar(15) as 
begin
	   
		IF @credit_number > 50000
			return 'PLATINIUM';
		IF @credit_number >= 10000 and @credit_number<= 50000
			return 'GOLD';
		IF @credit_number <= 10000
			return 'SILVER';
			RETURN 'none';
end;
--verificar si esta bien-------------------------------
select dbo.type_client_v2(12000) as DBA;
select dbo.type_client_v2(60000) as DBA;
select dbo.type_client_v2(200) as DBA;
--con la v1
select dbo.type_client(1000000)as DBA;
select dbo.type_client(1) as DBA;
select dbo.type_client(10000) as DBA;


--EJERCICIO 3

select COUNT(jug.id_JUDAGOR)
from EQUIPO as eq
inner join JUGADOR as jug on jug.ID_EQUIPO=eq.ID_EQUIPO
inner join CAMPEONATO as cam on cam.id_CAMPEONATO=eq.id_CAMPEONATO
where jug.NOMBRES like 'S%' and jug.APELLIDOS like 'M%' and  cam.SEDE='El Alto' 

--funcion 1
CREATE function ejercicio1 (@sede varchar(50)) 
returns varchar(50) as 
begin
		declare @respuesta varchar(50)
	    select @respuesta=COUNT(jug.id_JUDAGOR)
        from EQUIPO as eq
        inner join JUGADOR as jug on jug.ID_EQUIPO=eq.ID_EQUIPO
        inner join CAMPEONATO as cam on cam.id_CAMPEONATO=eq.id_CAMPEONATO
        where jug.NOMBRES like 'S%' and jug.APELLIDOS like 'M%' and  cam.SEDE=@sede 
		return (@respuesta);
		
end;
--funcion 2
select COUNT(jug.id_JUDAGOR)
from EQUIPO as eq
inner join JUGADOR as jug on jug.ID_EQUIPO=eq.ID_EQUIPO
where eq.NOMBRE_EQUIPO='Google' and eq.CATEGORIA='mujeres'

CREATE function ejercicio2 (@equipo varchar(50), @categoria varchar(50)) 
returns varchar(50) as 
begin
		declare @respuesta varchar(50)
		select @respuesta = COUNT(jug.id_JUDAGOR)
        from EQUIPO as eq
        inner join JUGADOR as jug on jug.ID_EQUIPO=eq.ID_EQUIPO
        where eq.NOMBRE_EQUIPO=@equipo and eq.CATEGORIA=@categoria
		return (@respuesta);
	 
end;
--testeo
--ejercicio1
select dbo.ejercicio1 ('El Alto') as DBA;
select dbo.ejercicio1 ('Cochabamba') as DBA;
--ejercicio2
select dbo.ejercicio2 ('404 Not found','varones') as DBA;
select dbo.ejercicio2 ('girls unifranz','mujeres') as DBA;

score jhontatan   4500
score victor      4600
select *from CAMPEONATO
select *from JUGADOR
select *from EQUIPO
