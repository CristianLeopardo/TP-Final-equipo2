CREATE DATABASE TP_FINAL
go
use TP_FINAL
create table Usuarios(
    ID int not null PRIMARY KEY IDENTITY (1,1),
    Usuario VARCHAR(50) not null,
    Clave varchar(50) not null,
    Email VARCHAR(50)  not null,
    TipoUsuario int not null
)
go
create table Medicos(
    ID int not null PRIMARY KEY IDENTITY (1,1),
    Nombre VARCHAR(100) not null,
    Apellido VARCHAR(100) not null,
    Sexo VARCHAR(20) not null,
    DNI int not null,
    Telefono int,
    Celular int,
    Email VARCHAR(50) not null,
    FechaIngreso DATETIME not null,
    FechaNacimiento DATETIME not null,
    Jornada varchar(20) not null,
    Estado bit not null default 1
)
GO
create table Pacientes(
    ID int not null PRIMARY KEY IDENTITY (1,1),
    Nombre VARCHAR(100) not null,
    Apellido VARCHAR(100) not null,
    Sexo VARCHAR(20) not null,
    DNI int not null,
    Telefono int,
    Celular int,
    Email VARCHAR(50) not null,
    Domicilio VARCHAR(100) not null,
    Localidad VARCHAR(100) not null,
    Provincia VARCHAR(100) not null,
    FechaNacimiento DATETIME not null,
    Estado bit not null default 1
)
GO
create table Turnos(
    ID int not null PRIMARY KEY IDENTITY (1,1),
    IDPaciente int not null,
    IDMedico int  not null,
    IDEspecialidad int not null,
    Fecha datetime not null,
    Estado int not null
)
create table Especialidad(
    ID int not null PRIMARY KEY IDENTITY (1,1),
    Nombre VARCHAR(100) not null
)

CREATE TABLE Medico_x_Especialidad(
    IdMedico int,
    IDEspecialidad INT
)

create table Horarios(
    IDHorario int IDENTITY(1,1) NOT NULL,
	IDMedico int NOT NULL,
	IDHoraInicio int NOT NULL,
	Fecha Datetime NOT NULL,
	Estado bit NOT NULL default 1
)

create table Hora(
    IDHora int not null PRIMARY KEY identity (1,1),
    Hora varchar(5) not null,
)

CREATE TABLE Observaciones(
    ID int PRIMARY KEY IDENTITY(1,1) not null,
    IDTurno int not NULL,
    Observaciones VARCHAR(800) not NULL
    FOREIGN KEY (IDTurno) REFERENCES Turnos (ID)
)

insert into Hora(Hora)
  values ('09:00')
insert into Hora(Hora)
  values ('09:30')
insert into Hora(Hora)
  values ('10:00')
insert into Hora(Hora)
  values ('10:30')
insert into Hora(Hora)
  values ('11:00')
    insert into Hora(Hora)
  values ('11:30')
  insert into Hora(Hora)
  values ('12:00')
    insert into Hora(Hora)
  values ('12:30')
    insert into Hora(Hora)
  values ('13:00')
    insert into Hora(Hora)
  values ('13:30')
    insert into Hora(Hora)
  values ('14:00')
    insert into Hora(Hora)
  values ('14:30')
    insert into Hora(Hora)
  values ('15:00')
    insert into Hora(Hora)
  values ('15:30')
    insert into Hora(Hora)
  values ('16:00')
    insert into Hora(Hora)
  values ('16:30')
    insert into Hora(Hora)
  values ('17:00')
    insert into Hora(Hora)
  values ('17:30')
    insert into Hora(Hora)
  values ('18:00')
    insert into Hora(Hora)
  values ('18:30')
    insert into Hora(Hora)
  values ('19:00')
    insert into Hora(Hora)
  values ('19:30')

insert into Especialidad(Nombre)
values ('Dentista');
insert into Especialidad(Nombre)
values ('Otorrino');
insert into Especialidad(Nombre)
values ('Cardiologo');
insert into Especialidad(Nombre)
values ('Clinico');
insert into Pacientes(Nombre, Apellido)
values ('Jose', 'Gomez')
insert into Pacientes(Nombre, Apellido)
values ('Ricardo', 'Gutierrez')
insert into Pacientes(Nombre, Apellido)
values ('Juan', 'Perez')


drop table Pacientes
drop table Medicos


insert into Usuarios(Usuario, Clave, TipoUsuario)
values('admin', 'admin', 1)
insert into Usuarios(Usuario, Clave, TipoUsuario)
values('recepcion', 'recepcion', 2)
insert into Usuarios(Usuario, Clave, TipoUsuario)
values('medico', 'medico', 3)
insert into Usuarios(Usuario, Clave, TipoUsuario)
values('cliente', 'cliente', 4)