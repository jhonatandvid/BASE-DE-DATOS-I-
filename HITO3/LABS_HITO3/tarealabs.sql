use EMPRESA;
create table tabla_a(
letras_a varchar(50) primary key not null
);
create table tabla_b(
letras_b varchar(50) primary key not null
);
insert into tabla_a(letras_a)values('D');
insert into tabla_a(letras_a)values('E');
insert into tabla_a(letras_a)values('F');
insert into tabla_a(letras_a)values('G');
insert into tabla_a(letras_a)values('H');
insert into tabla_b(letras_b)values('A');
insert into tabla_b(letras_b)values('B');
insert into tabla_b(letras_b)values('E');
insert into tabla_b(letras_b)values('H');
--------------------------------------------------------------------------
select taba.letras_a,tabb.letras_b
from tabla_a AS taba
INNER JOIN tabla_b AS tabb ON tabb.letras_b = taba.letras_a
-------------------------------------------------------------------------------------
create table numeros_a(
num_a integer primary key not null
);
create table numeros_b(
num_b integer primary key not null
);
--primera forma
insert into numeros_a(num_a)values(1);
insert into numeros_a(num_a)values(2);
insert into numeros_a(num_a)values(3);
insert into numeros_a(num_a)values(4);
insert into numeros_a(num_a)values(5);
insert into numeros_a(num_a)values(6);
insert into numeros_a(num_a)values(7);
--SEGUNDA FORMA 
insert into numeros_a(num_a)values(1),
(2),
(3),
(4),
(5),
(6),
(7);
----------------------------
insert into numeros_b(num_b)values(4);
insert into numeros_b(num_b)values(5);
insert into numeros_b(num_b)values(6);
insert into numeros_b(num_b)values(7);
insert into numeros_b(num_b)values(8);
insert into numeros_b(num_b)values(9);
--------------------------------------
--MOSTRAR ELEMENTOS EN COMUN Y MAYORES A 5
select nua.num_a , nub.num_b
from numeros_a AS nua
INNER JOIN numeros_b AS nub ON nub.num_b = nua.num_a;

select nua.num_a , nub.num_b
from numeros_a AS nua
INNER JOIN numeros_b AS nub ON nua.num_a = nub.num_b
where nua.num_a > 5 and nub.num_b >5;
---------------------------------------
--INTERSECCION ENTRE 3 TABLAS
create table NOTAS_a(
notas integer primary key not null
);
create table NOTAS_b(
notas integer primary key not null
);
create table NOTAS_c(
notas integer primary key not null
);

insert into NOTAS_a(notas)values(51),
(40),
(75),
(60),
(30);
insert into NOTAS_b(notas)values(60),
(51),
(100);

insert into NOTAS_c(notas)values(20),
(21),
(23),
(48),
(51),
(60);
select noa.notas,nob.notas,noc.notas
from NOTAS_a AS noa
INNER JOIN NOTAS_b AS nob ON noa.notas = nob.notas
inner join NOTAS_c AS noc on noa.notas = noc.notas;

-----------------------------------------------------------
--NOTAS MAYORES A 50 Y MENORES QUE 100
select noa.notas,nob.notas,noc.notas
from NOTAS_a AS noa
INNER JOIN NOTAS_b AS nob ON noa.notas = nob.notas
inner join NOTAS_c AS noc on nob.notas = noc.notas
where noa.notas > 50 and nob.notas >50 and noc.notas>50 and 
 noa.notas <100 and nob.notas <100 and noc.notas<100;
----------------------------------------------------------
