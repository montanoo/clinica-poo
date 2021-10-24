-- Query actualizada hasta el 50% para creación de la base de datos 
-- Integrantes: 
--	Fernando Josué Montano González. MG210111 | Andrea Guadalupe Velásquez Joyar. VJ210576 |
--	Kallahan Andrea Salas Bojórquez. SB210537 | Ivania María Lebrón Flores. LF212591 | 
--	Luciana María Munguía Villacorta. MV210941 |

USE ClinicaPOO
GO

CREATE TABLE appointments (
	id int IDENTITY(1,1) NOT NULL, 
	dentist_id int,
	patient_id int, 
	appointment_time datetime,
	method_id int,
	CONSTRAINT PK_appointmentID PRIMARY KEY (id)
)
GO

CREATE TABLE patient( 
	id int IDENTITY(1,1) NOT NULL,
    dui varchar(10), 
    [name] varchar(50),
    lastname varchar(50),
    email varchar(255),
    phone varchar(9),
    birthdate date,
    [password] varchar(max),
    CONSTRAINT chk_password CHECK(DATALENGTH([password]) >= 8),
    CONSTRAINT PK_patientID PRIMARY KEY (id)
)
GO

CREATE TABLE dentist(
	id int IDENTITY(1,1) NOT NULL,
    [name] varchar(50),
    specialty varchar(25),
    schedule datetime,
    email varchar(255),
    phone varchar(9),
    CONSTRAINT PK_dentistID PRIMARY KEY (id)
)

CREATE TABLE inventory(
	id int IDENTITY(1,1) NOT NULL,
	product varchar(100),
	quantity int,
	price decimal(18, 2),
	CONSTRAINT PK_inventoryID PRIMARY KEY (id)
)
GO

CREATE TABLE methods(
	id int IDENTITY(1,1) NOT NULL,
    [name] varchar(50),
    [description] varchar(max),
    price decimal(18, 2),
    duration int,
    CONSTRAINT PK_methodsID PRIMARY KEY(id)
)
GO

CREATE TABLE doctor_status(
	dentist_id int,
    dentist_status varchar(8)
)
GO