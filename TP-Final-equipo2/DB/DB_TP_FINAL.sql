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


insert into Usuarios(Usuario, Clave, TipoUsuario)
values('admin', 'admin', 1)
insert into Usuarios(Usuario, Clave, TipoUsuario)
values('recepcion', 'recepcion', 2)
insert into Usuarios(Usuario, Clave, TipoUsuario)
values('medico', 'medico', 3)
insert into Usuarios(Usuario, Clave, TipoUsuario)
values('cliente', 'cliente', 4)