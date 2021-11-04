-- Query actualizada hasta el 50% para creación de la base de datos 
-- Integrantes: 
--	Fernando Josué Montano González. MG210111 | Andrea Guadalupe Velásquez Joyar. VJ210576 |
--	Kallahan Andrea Salas Bojórquez. SB210537 | Ivania María Lebrón Flores. LF212591 | 
--	Luciana María Munguía Villacorta. MV210941 |

USE master
GO

CREATE DATABASE ClinicaPOO
GO

USE ClinicaPOO
GO

CREATE TABLE [user] (
    id int IDENTITY(1,1) NOT NULL,  --(PK)
    username varchar(255) NOT NULL,
    [role_id] int DEFAULT (0),
    [password] varchar(MAX) NOT NULL,
    CONSTRAINT PK_user_id PRIMARY KEY (id),
    CONSTRAINT CHK_password CHECK(DATALENGTH([password]) >= 8),
    CONSTRAINT UNQ_username UNIQUE(username)
)

CREATE TABLE patient ( 
	id int IDENTITY(1,1) NOT NULL, --(PK)
    [user_id] int,
    dui varchar(10), 
    [name] varchar(50),
    lastname varchar(50),
    email varchar(255) NOT NULL,
    phone varchar(9),
    birthdate date,
    CONSTRAINT PK_patient_id PRIMARY KEY (id),
    CONSTRAINT UNQ_email UNIQUE(email)
)
GO

CREATE TABLE dentist (
	id int IDENTITY(1,1) NOT NULL, --(PK)
    [name] varchar(50),
    specialty varchar(25),
    [status] int DEFAULT (1), -- available: 1, busy : 2, disabled: 0
    email varchar(255),
    phone varchar(9),
    CONSTRAINT PK_dentist_id PRIMARY KEY (id),
    CONSTRAINT UNQ_dentist_email UNIQUE(email)
)

CREATE TABLE appointments (
	id int IDENTITY(1,1) NOT NULL, --(PK)
	dentist_id int,
	patient_id int, 
	appointment_time datetime,
	method_id int,
	CONSTRAINT PK_appointment_id PRIMARY KEY (id)
)
GO

CREATE TABLE inventory (
	id int IDENTITY(1,1) NOT NULL, --(PK)
	product varchar(100),
	quantity int,
	price float,
	CONSTRAINT PK_inventory_id PRIMARY KEY (id)
)
GO

CREATE TABLE methods (
	id int IDENTITY(1,1) NOT NULL, --(PK)
    [name] varchar(50),
    [description] varchar(max),
    price float,
    CONSTRAINT PK_methods_id PRIMARY KEY(id),
    CONSTRAINT UNQ_methods_name UNIQUE([name])
)
GO

CREATE TABLE billing (
    id int IDENTITY(1,1) NOT NULL, --(PK)
    patient_id int,
    appointment_id int,
    method_id int,
    medicine_id int,
    quantity int,
	total float,
    CONSTRAINT PK_billing_id PRIMARY KEY (id)
)
GO

-- | Normalización (Foreign Keys) |
ALTER TABLE patient
ADD CONSTRAINT FK_patient_user_id FOREIGN KEY ([user_id]) REFERENCES [user](id)
GO

ALTER TABLE appointments 
ADD CONSTRAINT FK_dentist_id FOREIGN KEY (dentist_id) REFERENCES dentist(id)
GO

ALTER TABLE appointments
ADD CONSTRAINT FK_patient_id FOREIGN KEY (patient_id) REFERENCES patient(id)
GO

ALTER TABLE appointments
ADD CONSTRAINT FK_method_id FOREIGN KEY (method_id) REFERENCES methods(id)
GO

ALTER TABLE billing
ADD CONSTRAINT FK_billing_patient_id FOREIGN KEY (patient_id) REFERENCES patient(id)
GO

ALTER TABLE billing
ADD CONSTRAINT FK_billing_method_id FOREIGN KEY (method_id) REFERENCES methods(id)
GO

ALTER TABLE billing
ADD CONSTRAINT FK_billing_appointment_id FOREIGN KEY (appointment_id) REFERENCES appointments(id)
GO

ALTER TABLE billing
ADD CONSTRAINT FK_billing_medicine_id FOREIGN KEY (medicine_id) REFERENCES inventory(id)
GO

-- | Inserts |

INSERT INTO [user] (username, [password], [role_id]) VALUES
('admin', 'password', 1)
GO 

-- Insertar procedimientos
INSERT INTO methods VALUES
('Dental Exam', 'Regular dental exams are essential and can help your dentist detect and treat problems such as gum disease, tooth decay, or oral cancer early.', 90),
('Professional Teeth cleaning', 'Getting your teeth professionally cleaned every six months will help you keep your teeth and gums healthy.', 30),
('Tooth Fillings', 'Our dental team can help you go metal-free with tooth-colored fillings that ensure your teeth remain strong, healthy and intact for years to come.', 125),
('Dental Sealants', 'A dental sealant is a thin, plastic coating painted on the chewing surfaces of teeth to help prevent tooth decay.', 20),
('Dental Bridges', 'You may require dental bridges if you are experiencing tooth loss.', 3000),
('Root Canal Treatment', 'If tooth decay has reached your tooth’s pulp, then your dentist will recommend root canal treatment.', 600),
('Custom Mouth Guards', 'Your dentist may recommend a custom mouth guard for you to wear at night if you grind your teeth, clench your teeth, or have TMJ issues.', 400),
('Dental Implants', 'Dental implants are fixed in place and a permanent tooth replacement option.', 1000),
('Dental Implants with Dental Crown/Abutment', 'The cost varies widely for dental implants and crowns/abutments as the price is dependent on the type of implant, graphing, and restorative materials used in your unique case.', 2500),
('Dental Crowns, Inlays or Onlays', 'If you have a dental implant, a broken tooth, a severely decayed tooth, or other dental restoration options such as tooth fillings aren’t possible, your dentist may recommend a dental crown, inlay or onlay.', 1000),
('Dentures', 'When you are missing all or several of your teeth, full or partial dentures may be a good option.', 1200),
('Tooth Extraction', 'Sometimes, you may have a severely sick or injured tooth that may require your dentist to extract it.', 125),
('Professional Teeth Whitening', 'Professional teeth whitening is a wonderful option for people who have yellowed teeth or teeth stains.', 100),
('Dental Veneers', 'Dental veneers are a permanent tooth replacement option that can be used to replace missing teeth.', 500),  
('Dental Botox', 'Dental Botox can be a great TMJ treatment option for people who experience teeth grinding and facial or jaw pain.', 12),
('Clear Correct', 'Clear Correct clear braces are a wonderful option for patients who want to straighten their teeth in an inconspicuous manner.', 3500),
('Braces/Invisalign', 'Most practices are moving away from traditional braces and towards Invisalign, but they both serve the same purpose. The goal is to straighten and correct crooked teeth.', 5000),
('Bonding', 'This is another way to repair damaged or chipped teeth. It involves a resin – a sort of plastic – that your dentists tints to match the natural shade of your teeth.', 200)
GO

-- Extra inserts