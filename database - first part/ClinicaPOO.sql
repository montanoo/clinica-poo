-- Query para creacion de la base de datos 
-- Integrantes: 
--	Fernando Josué Montano González. MG210111 | Andrea Guadalupe Velásquez Joyar. VJ210576 |
--	Kallahan Andrea Salas Bojórquez. SB210537 | Ivania María Lebrón Flores. LF212591 | 
--	Luciana María Munguía Villacorta. MV210941

USE master
GO

CREATE DATABASE ClinicaPOO
GO

USE ClinicaPOO
GO

-- Creación de tabla 'appointments'
CREATE TABLE appointments (
	id int IDENTITY(1,1) NOT NULL, --Se utiliza la sintaxis IDENTITY para que la variable se auto increment
	dentist_id int,
	patient_id int,
	appointment_time datetime,
	reason varchar(max),
	method_id int
)
GO

-- Creación de tabla 'patient'
CREATE TABLE patient(
	id int IDENTITY(1,1) NOT NULL,
	dui varchar(10),
	[name] varchar(50),
	lastname varchar(50),
	email varchar(255),
	phone varchar(9),
	birthdate date,
	[password] varchar(max)
	CONSTRAINT chk_password CHECK (DATALENGTH([password])>=8)
)
GO

-- Creación de tabla 'dentist'
CREATE TABLE dentist(
	id int IDENTITY(1,1) NOT NULL,
	[name] varchar(50),
	specialty varchar(25),
	schedule datetime,
	email varchar(255),
	phone varchar(9)
)
GO

-- Creación de tabla 'inventory'
CREATE TABLE inventory(
	id int IDENTITY(1,1) NOT NULL,
	product varchar(100),
	quantity int,
	price decimal(18,2)
)
GO

-- Creación de tabla 'methods'
CREATE TABLE methods(
	id int IDENTITY(1,1) NOT NULL,
	[name] varchar(50),
	[description] varchar(max),
	price decimal (18,2),
	duration int
)

-- Creación de tabla 'doctor_status'
CREATE TABLE doctor_status(
	dentist_id int,
	dentist_status varchar(8)
)
GO

