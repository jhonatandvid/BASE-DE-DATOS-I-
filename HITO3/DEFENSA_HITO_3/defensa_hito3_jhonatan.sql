create database defensa_hito3_unifranzitos;
use defensa_hito3_unifranzitos;
create table CAMPEONATO(
id_CAMPEONATO VARCHAR(50) PRIMARY KEY NOT NULL,
NOMBRE_CAMPEONATO VARCHAR(50) NOT NULL,
SEDE VARCHAR(50) NOT NULL
);
INSERT INTO CAMPEONATO (id_CAMPEONATO,NOMBRE_CAMPEONATO,SEDE)
VALUES('camp-111','Campeonato Unifranz','El Alto'),('camp-222','Campeonato Unifranz','Cochabamba');
create table EQUIPO(
ID_EQUIPO VARCHAR(50)PRIMARY KEY NOT NULL,
NOMBRE_EQUIPO VARCHAR(50) NOT NULL,
CATEGORIA VARCHAR(50) NOT NULL,
id_CAMPEONATO VARCHAR(50) NOT NULL,
FOREIGN KEY (id_CAMPEONATO) REFERENCES CAMPEONATO (id_CAMPEONATO),
);
INSERT INTO EQUIPO(ID_EQUIPO,NOMBRE_EQUIPO,CATEGORIA,id_CAMPEONATO)
VALUES('equ-111','Google','varones','camp-111'),('equ-222','404 Not found','varones','camp-111'),
('equ-333','girls unifranz','mujeres','camp-111');
CREATE TABLE JUGADOR(
id_JUDAGOR VARCHAR(50) PRIMARY KEY NOT NULL,
NOMBRES VARCHAR(50) not null,
APELLIDOS VARCHAR(50) not null,
CI   varchar(50) not null,
EDAD INTEGER not null,
ID_EQUIPO VARCHAR(50) not null,
FOREIGN KEY (ID_EQUIPO) REFERENCES EQUIPO (ID_EQUIPO)
);
INSERT INTO JUGADOR (id_JUDAGOR,NOMBRES,APELLIDOS,CI,EDAD,ID_EQUIPO)
VALUES('jug-111','Carlos','Villa','8997811LP',19,'equ-222'),
('jug-222','Pedro','Salas','8997822LP',20,'equ-222'),
('jug-333','Saul','Araj','8997833LP',21,'equ-222'),
('jug-444','Sandra','Solis','8997844LP',20,'equ-333'),
('jug-555','Ana','Mica','8997855LP',23,'equ-333');
--mostrar todos los juadores en donde su nombre empieze son s y su apellido termina con s
select *--jug.NOMBRES, jug.APELLIDOS
from JUGADOR as jug
where jug.NOMBRES like 'S%' and jug.APELLIDOS like '%s';
--mostrar todos los jugadores del equip not foung aiempre y cuando la edad sea menor igual a 20 años
select jug.NOMBRES, jug.APELLIDOS, jug.EDAD
from JUGADOR as jug
inner join EQUIPO as eq on eq.ID_EQUIPO = jug.ID_EQUIPO
where jug.EDAD<=20 and eq.NOMBRE_EQUIPO='404 not found';
--mostrar todoslos jugadores  mayores de 20
select jug.NOMBRES, jug.APELLIDOS, jug.EDAD, eq.ID_EQUIPO, eq.NOMBRE_EQUIPO
from JUGADOR as jug
inner join EQUIPO as eq on eq.ID_EQUIPO = jug.ID_EQUIPO
inner join CAMPEONATO as ca on eq.id_CAMPEONATO = ca.id_CAMPEONATO
where ca.SEDE ='El Alto' and  jug.EDAD>20 and eq.ID_EQUIPO ='equ-333';
--CUANTOS JUGADORES FORMAN DEL EQUIPO EQU-222
--1ER forma
select count (*) numero_de_jugadrres_escritos
from JUGADOR
WHERE ID_EQUIPO = 'equ-222';
---2DA forma
SELECT COUNT(*) numero_de_jugadrres_escritos
FROM JUGADOR AS JUG
INNER JOIN EQUIPO AS eq on jug.ID_EQUIPO = eq.ID_EQUIPO
where eq.ID_EQUIPO = 'equ-222';
--agregar tabla premios y analizar que campos deve tener esta tabla
create table PREMIOS(
id_premio  varchar(50) primary key not null,
ID_EQUIPO VARCHAR(50) not null,
id_CAMPEONATO VARCHAR(50) NOT NULL,
PREMIO varchar(50) not null,
PODIO varchar(50) not null
FOREIGN KEY (id_CAMPEONATO) REFERENCES CAMPEONATO (id_CAMPEONATO),
FOREIGN KEY (ID_EQUIPO) REFERENCES EQUIPO (ID_EQUIPO)
);
insert into PREMIOS(id_premio,ID_EQUIPO,id_CAMPEONATO,PREMIO,PODIO)
values('1111','equ-222','camp-111','un cheque 1000','primer puesto');
insert into PREMIOS(id_premio,ID_EQUIPO,id_CAMPEONATO,PREMIO,PODIO)
values('2222','equ-333','camp-111','un cheque de 500','segundo puesto');
--MOSTRAR LOS JUGADORES 
select JUG.NOMBRES, JUG.APELLIDOS, pre.PREMIO,pre.PODIO,eq.CATEGORIA
from JUGADOR AS JUG
inner join  EQUIPO AS EQ ON EQ.ID_EQUIPO = JUG.ID_EQUIPO
INNER JOIN  PREMIOS AS PRE ON PRE.ID_EQUIPO = EQ.ID_EQUIPO
where PRE.PODIO = 'primer puesto' and eq.CATEGORIA = 'varones' ;
select * from CAMPEONATO;
select * from EQUIPO;
select * from JUGADOR;
select * from PREMIOS;



