
CREATE DATABASE UNIVERSIDAD;
USE UNIVERSIDAD;
CREATE TABLE materias(
id_mat  integer identity primary key not null,
nombre_mat varchar(100)not null,
cod_mat    varchar(100)not null
);
CREATE TABLE escuela(
id_esc  integer identity primary key not null,
nombre  varchar(100) not null,
direccion varchar(100) not null
);
CREATE TABLE periodo(
id_per  integer identity primary key not null,
año_gestion integer not null,
semestre varchar(50) not null
);

CREATE TABLE estudiantes(
id_est_cedula integer identity primary key not null,
nombres  varchar(100) not null,
apellidos  varchar(100) not null,
sexo  varchar(10) not null,
direccion varchar(100) not null,
telefono  integer not null,
email  varchar(50) not null,
edad integer not null,
id_esc integer
foreign key(id_esc) references escuela(id_esc),
);

CREATE TABLE kardex(
id_kar  integer identity primary key not null,
nota_num  integer not null,
mota_alfabe varchar(100) not null,
estado varchar(10) not null,
id_mat integer not null,
id_est_cedula integer not null,
id_per integer not null
foreign key(id_mat) references materias(id_mat),
foreign key(id_est_cedula) references estudiantes(id_est_cedula),
foreign key(id_per) references periodo(id_per)

);
INSERT INTO escuela (nombre, direccion) 
VALUES ('San Felipe Asturias II', 'Zona Illampu Av. Prol. San Lorenzo');
INSERT INTO estudiantes ( nombres, apellidos, sexo, direccion, telefono, email, edad, id_esc)
VALUES ( 'Ximena', 'Arias Ballesteros', 'femenino', 'Av. 6 de Agosto', 79617575, 'xime@gmail.com', 25, 1);
INSERT INTO estudiantes ( nombres, apellidos, sexo, direccion, telefono, email, edad, id_esc)
VALUES ( 'Saul', 'Montes Valenzuela', 'masculino', 'Av. 6 de Agosto', 79617576, 'saul@gmail.com', 24, 1);
INSERT INTO estudiantes ( nombres, apellidos, sexo, direccion, telefono, email, edad, id_esc) 
VALUES ( 'Carla', 'Mavir Uria', 'femenino', 'Av. 6 de Agosto', 79617577, 'carla@gmail.com', 28, 1);
INSERT INTO estudiantes ( nombres, apellidos, sexo, direccion, telefono, email, edad, id_esc)
VALUES ( 'Joel', 'Castillo Fuentes', 'masculino', 'Av. 6 de Agosto', 79617578, 'joel@gmail.com', 21, 1);
INSERT INTO estudiantes ( nombres, apellidos, sexo, direccion, telefono, email, edad, id_esc) 
VALUES ( 'Augusto', 'Copar Copar', 'femenino', 'Av. 6 de Agosto', 79617579, 'augusto@gmail.com', 20, 1);
INSERT INTO materias (nombre_mat, cod_mat) 
VALUES ('Introduccion a la Arquitectura','ARQ-101');
INSERT INTO materias (nombre_mat, cod_mat) 
VALUES ('Urbanismo y Diseno','ARQ-102');
INSERT INTO materias (nombre_mat, cod_mat) 
VALUES ('Dibujo y Pintura Arquitectonico','ARQ-103');
INSERT INTO materias (nombre_mat, cod_mat) 
VALUES ('Matematica discreta','ARQ-104');
INSERT INTO materias (nombre_mat, cod_mat) 
VALUES ('Fisica Basica','ARQ-105');
INSERT INTO periodo (año_gestion, semestre) 
VALUES (2016, 'Semestre 1');
INSERT INTO periodo (año_gestion, semestre) 
VALUES (2016, 'Semestre 2');
INSERT INTO periodo (año_gestion, semestre) 
VALUES (2017, 'Semestre 1');
INSERT INTO periodo (año_gestion, semestre) 
VALUES (2017, 'Semestre 2');
INSERT INTO periodo (año_gestion, semestre) 
VALUES (2018, 'Semestre 1');
insert into kardex (nota_num,mota_alfabe,estado,id_mat,id_est_cedula,id_per) 
values(51,'cincuenta y uno','aprovado',1,1,1);
insert into kardex (nota_num,mota_alfabe,estado,id_mat,id_est_cedula,id_per) 
values(31,'treinta y uno','reprovado',2,2,2);
insert into kardex (nota_num,mota_alfabe,estado,id_mat,id_est_cedula,id_per) 
values(61,'sesenta y uno','aprovado',1,3,1);
insert into kardex (nota_num,mota_alfabe,estado,id_mat,id_est_cedula,id_per) 
values(41,'cuarenta y uno','reprovado',2,4,2);
insert into kardex (nota_num,mota_alfabe,estado,id_mat,id_est_cedula,id_per) 
values(81,'ochenta y uno','aprovado',4,5,4);
--Mostrar los nombres y apellidos de los estudiantes mayores a 24 anhos y que sean del sexo masculino/femenino.
select est.nombres, est.apellidos
FROM estudiantes AS est
where sexo = 'masculino' and
edad>=24;
--o
select est.nombres, est.apellidos
FROM estudiantes AS est
where sexo = 'masculino' and
edad>24;
--Mostrar los nombres y apellidos de todos los estudiantes aprobados.
select est.nombres, est.apellidos
FROM kardex AS kar, estudiantes AS est
where kar.id_est_cedula = est.id_est_cedula and
kar.nota_num >= 51;
------INNER JOIN--------------------------------------------------------------------------------
--PARA RELACIONAR UNA TABLA CON UNA TABLA SE USA UN INNER JOIN

SELECT est.nombres, est.apellidos
FROM kardex AS kar
INNER JOIN estudiantes AS est ON kar.id_est_cedula = est.id_est_cedula
WHERE kar.nota_num >= 51;
----EJERCICIO:

--Mostrar los nombres y apellidos de los estudiantes aprobados y que tengan mayor a 25 años.
SELECT est.nombres, est.apellidos
FROM kardex AS kar
INNER JOIN estudiantes AS est ON kar.id_est_cedula = est.id_est_cedula
WHERE kar.nota_num >= 51 and est.edad > 25;

--Mostrar los nombres y apellidos y edad de los estudiantes reprobados y que tengan mayor a 25 años.
SELECT est.nombres, est.apellidos, est.edad
FROM kardex AS kar
INNER JOIN estudiantes AS est ON kar.id_est_cedula = est.id_est_cedula
WHERE kar.nota_num < 51 and est.sexo='masculino';

--Mostrar el semestre  y año del estudiante con cédula sea igual a “6775688”
SELECT per.semestre, per.año_gestion
FROM periodo AS per, estudiantes AS est
INNER JOIN kardex AS kar ON kar.id_est_cedula = est.id_est_cedula
WHERE kar.id_est_cedula = 4;
--Mostrar el nombre de la materia, nombre y apellido del estudiante con ID_EST (cédula) sea igual a “6775677” 
SELECT mat.nombre_mat, est.nombres, est.apellidos
FROM kardex AS kar, materias AS mat
INNER JOIN estudiantes AS est ON est.id_est_cedula = est.id_est_cedula
WHERE est.id_est_cedula = 4;
--determinar que materias tomaron los estudiantes(nombres y apellidos)que  aprobaron en la gestión 2016
--QUE ESTUDIANTES FORMAN PARTE DE LA ESCUELA "SAN FELIPE ASTURIAS"
SELECT est.direccion, est.nombres, est.apellidos
FROM estudiantes AS est
INNER JOIN escuela AS esc ON esc.id_esc = est.id_esc
where esc.nombre ='San Felipe Asturias II';
--mostrar todos los estudiantes que forma parte de la escuela siempre y cuando la edad sea mayor a 22 y sea masculino
SELECT est.nombres, est.apellidos,est.edad,est.sexo,esc.direccion
FROM estudiantes AS est
INNER JOIN escuela AS esc ON esc.id_esc = est.id_esc
where esc.nombre ='San Felipe Asturias II' and est.edad >22 and est.sexo ='masculino';
--mostrar todos los estudiantes aprovador en fisica basica
SELECT est.nombres, est.apellidos,kar.nota_num,mat.nombre_mat
FROM kardex AS kar
INNER JOIN estudiantes AS est ON  kar.id_est_cedula= est.id_est_cedula
INNER JOIN materias AS mat ON   kar.id_mat = mat.id_mat
where mat.nombre_mat = 'Fisica Basica' and kar.nota_num >51 AND kar.estado ='aprovado' ;
--mostrarlos nombres y apellidos de los estudiantes aprovados y mayores de 25
SELECT est.nombres, est.apellidos
FROM kardex AS kar
INNER JOIN estudiantes AS est ON est.id_est_cedula = kar.id_est_cedula
where est.edad >25 and kar.nota_num >=51;
--mostrar semestre y año del estudiante con cedula sea igual a 6775688
SELECT per.semestre, per.año_gestion
FROM periodo AS per
inner join kardex as kar on kar.id_per = per.id_per
where kar.id_est_cedula = 2;
--determinar las materias tomadas por los estudiantes (nombres apellidos) que aprovaron la gestion 2019
SELECT est.nombres,est.apellidos,per.año_gestion
FROM periodo AS per
inner join kardex as kar on kar.id_per = per.id_per
inner join estudiantes as est on kar.id_est_cedula = est.id_est_cedula
--inner join materias as mat on est.i = mat.id_mat
where per.año_gestion=2016 and kar.estado = 'aprovado';
--materias,escuela,periodo,estudiantes,kardex+
select* from materias;
select* from kardex;
select* from escuela;
select* from periodo;
select* from estudiantes;