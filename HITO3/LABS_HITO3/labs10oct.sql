use UNIVERSIDAD
create table nombre_dba_I(
sis_est varchar(25) primary key,
nombre varchar(25),
);
create table nombre_dba_II(
sis_est varchar(25) primary key,
nombre varchar(25),
);
insert into nombre_dba_I(nombre,sis_est)values('william','sis347617'),('victor','sis347627'),('mijail','sis347637'),('karen','sis347647'),('brayan','sis347657'),('ariel','sis347327');
insert into nombre_dba_II(nombre,sis_est)values('victor','sis347627'),('brayan','sis347657'),('samuel','sis523637'),('ana','sis353447');

select no2.nombre, no1.nombre
from nombre_dba_I AS no1
inner join nombre_dba_II as no2 on no1.sis_est = no2.sis_est;
