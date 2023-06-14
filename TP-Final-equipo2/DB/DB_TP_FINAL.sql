CREATE DATABASE TP_FINAL
go
use TP_FINAL
create table Usuarios(
    ID int not null PRIMARY KEY IDENTITY (1,1),
    Usuario VARCHAR(50) not null,
    Clave varchar(50) not null,
    TipoUsuario int not null
)
go
create table Medicos(
    ID int not null PRIMARY KEY IDENTITY (1,1),
    Nombre VARCHAR(100) not null,
    Apellido VARCHAR(100) not null,
    IDEspecialidad int not null
)
GO
create table Pacientes(
    ID int not null PRIMARY KEY IDENTITY (1,1),
    Nombre VARCHAR(100) not null,
    Apellido VARCHAR(100) not null
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