-- Query normalizada
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
    method_id int,
    medicine_id int,
    medicine_quantity int,
	total float,
    CONSTRAINT PK_billing_id PRIMARY KEY (id)
)
GO

-- | Normalización (Foreign Keys & PK) |
ALTER TABLE patient
ADD CONSTRAINT FK_patient_user_id FOREIGN KEY ([user_id]) REFERENCES [user](id)
ON DELETE CASCADE
ON UPDATE CASCADE
GO

ALTER TABLE appointments 
ADD CONSTRAINT FK_dentist_id FOREIGN KEY (dentist_id) REFERENCES dentist(id)
ON DELETE CASCADE
ON UPDATE CASCADE
GO

ALTER TABLE appointments
ADD CONSTRAINT FK_patient_id FOREIGN KEY (patient_id) REFERENCES patient(id)
ON DELETE CASCADE
ON UPDATE CASCADE
GO

ALTER TABLE appointments
ADD CONSTRAINT FK_method_id FOREIGN KEY (method_id) REFERENCES methods(id)
ON DELETE CASCADE
ON UPDATE CASCADE
GO

ALTER TABLE billing
ADD CONSTRAINT FK_billing_patient_id FOREIGN KEY (patient_id) REFERENCES patient(id)
ON DELETE CASCADE
ON UPDATE CASCADE
GO

ALTER TABLE billing
ADD CONSTRAINT FK_billing_method_id FOREIGN KEY (method_id) REFERENCES methods(id)
ON DELETE CASCADE
ON UPDATE CASCADE
GO


ALTER TABLE billing
ADD CONSTRAINT FK_billing_medicine_id FOREIGN KEY (medicine_id) REFERENCES inventory(id)
ON DELETE CASCADE
ON UPDATE CASCADE
GO

-- | Inserts |
INSERT INTO [user] (username, [password], [role_id]) VALUES
('admin', 'password', 1)
GO 

-- Insertar procedimientos
INSERT INTO methods VALUES
('Just buying with no method', 'No appointment created.', 0.0),
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

INSERT INTO [user] (username, [password])
VALUES
('Avram0494','FJG04BPG6GH'),
  ('Dorothy0302','DQY31LNK7SB'),
  ('Amity0574','JHI03QWU8LS'),
  ('Kylan0596','IDY43RNT3DX'),
  ('Olivia0777','CIC32PCZ7VY'),
  ('Marny1101','QFG53KFL6QB'),
  ('Charles1296','GPT05TVI8MZ'),
  ('Lars1184','YUV77NHO3BQ'),
  ('Thaddeus0871','LSZ35UZG1RF'),
  ('Barrett1195','CUT41LVR2SH');
GO
  INSERT INTO [user] (username, [password])
VALUES
('Alika1198', 'MRX34BXX6LU'),
  ('Kenneth0388','YPG93YIC9LA'),
  ('Yael0690','GOM35TLS7EU'),
   ('Chloe0690','MDO34EDY7OA'),
  ('Zeph0974','MXD93VOZ3MG'),
  ('Sasha1273','OQX40XXJ0FL'),
  ('Giselle0102','XTI70KDU0HT'),
  ('Scarlet0673','KIW13MTZ2EP'),
  ('Robert0802','CMW28YUV6SP'),
  ('Tashya1184','EQS27HKG8VD');
GO
INSERT INTO [user] (username, [password])
VALUES
('Erin1277','KHZ16CDN0VB'),
  ('Adrienne1074','UBJ47NOO8LR'),
  ('Jameson0978','VQG88QXS4CF'),
  ('Quinn0188','ANL70BSL0ZL'),
  ('Hammett0803','DEC07JVZ8GD'),
  ('Cameron0981','TKD25OZT1WS'),
  ('Alea0291','EXF62YUL4UJ'),
  ('Odessa0197','WQG78CRO7CC'),
  ('Andrew0887','ACH14JOE4OW'),
  ('George0785','DVG86TCY1CO');
GO
INSERT INTO [user] (username, [password])
VALUES
('Mufutau1285','TVN45CEK5LF'),
  ('Drew0175','QPV83AJC4HD'),
  ('Ahmed1202','KSN44YCL1HL'),
  ('Diana0673','BJG50DNB5GC'),
  ('Nissim0587','LWA07KBZ3BI'),
  ('Fitzgerald0397','HFK14QGN2HG'),
  ('Richard0470','LUD59LVC5GV'),
  ('Robin0975','STU82ETT3DG'),
  ('Gillian0485','FQL96RHY4MC'),
  ('Nathaniel0780','AOW37EJY2JR');
GO
INSERT INTO [user] (username, [password])
VALUES
('Buckminster0875','HYY72BHV5NI'),
  ('Rylee0494','IXN25LJZ7II'),
  ('Jerry0185','XAB54WKF6OC'),
  ('Tanek0588','XHP56QDR7QF'),
  ('Damon0499','SLW66HRL4CK'),
  ('Aidan0387','RAV11FYO8BX'),
  ('Marshall0102','USL64EMH4RP'),
  ('Maggie0577','YEN50NGO3GV'),
  ('Susana0382','GMJ96CLO7TD'),
  ('Brenna0975','WUS37QSR6ZT');
GO
INSERT INTO [user] (username, [password])
VALUES
('Megan0597','LQB27RNX2YI'),
  ('Elias0282','HVA46DIU1TB'),
  ('Blake0284',	'GJN62GKU7JZ'),
  ('Sigourney1085','GGE05ZBL9HL'),
  ('Paula0998','EMQ82OWW9SB'),
  ('Judith0184','FRU21QGL6EY'),
  ('Maris0875','RAN34SSR4TC'),
  ('Jade0588','SUY24FDJ6CF'),
  ('Valentine0796','VSW60ALJ2BQ'),
  ('Vera0475','UZP17XJO5YP');
GO
INSERT INTO [user] (username, [password])
VALUES
('Mollie0992','WFX24TPO6BH'),
  ('Sawyer0483','EYB64QVV2BQ'),
  ('Cullen0194','WQQ20XLZ3GD'),
  ('Ariel1271','WQJ34CFN4MY'),
  ('Len0793','FHI48PLH2BR'),
  ('Seth1097','XJB49WVJ2NX'),
  ('Eliana1282','GYC56BWD5UX'),
  ('Zelenia1203','DFD15ROF8OW'),
  ('Ezekiel0487','CRF76TFN5GX'),
  ('Rose0782','CYB84LOR0IC');
GO
INSERT INTO [user] (username, [password])
VALUES
 ('Raya0692','UME81STK4LH'),
  ('Molly1187','WKL11FOT7DO'),
  ('Laith0273',	'KJM14WVY3SI'),
  ('Dennis0602','ZSX68YZA8XY'),
  ('Brielle0890','ZLU54TYQ3PS'),
  ('Zephania0795','SHO94IXF0ZX'),
  ('Nomlanga1201','NOO56LVM2EG'),
  ('James0702','LJW56LIO2UO'),
  ('Debra0802',	'NVV97CZU5WO'),
  ('Cadman0679','IMM89TJH6CY');
GO
INSERT INTO [user] (username, [password])
VALUES
('Dennis0978','QJD44ZST2WF'),
  ('Clinton0200','AYQ31UOD7WD'),
  ('Orla0270','MTL64MXG7FY'),
  ('Ila1073','ZLE65XTH3CV'),
  ('Ruby0583','RRF58IYV5QJ'),
  ('Wang1100','IUR73WVK7ZP'),
  ('Sopoline1002','IHC79GCF3YL'),
  ('Charity0289','VNH84WUY8FF'),
  ('Kane1198','UYL71YTG2IJ'),
  ('Cheyenne0480','YDG44CDM4JV');
GO
INSERT INTO [user] (username, [password])
VALUES
('Tara0201','YPG17GTT1PK'),
  ('Michael0487','FII62BJB4EJ'),
  ('Akeem0196','CBB03MOM6HV'),
  ('Molly0687','UJS48GGJ8PY'),
  ('Janna0493','GRS65FTO8MM'),
  ('Eagan0584',	'OOL58MJE2CN'),
  ('Bertha0186','TKC94DSH8JH'),
  ('Bevis0703','EXJ88YDC7GW'),
  ('Alfonso0882','NSY81GTG2EE'),
  ('Nasim1297','IKH76SXQ2CB');
GO
-- INSERTS PATIENT
INSERT INTO patient (user_id,dui,[name],lastname,email,phone,birthdate)
VALUES
  (2,'87221256-9','Avram','Becker','sollicitudin.adipiscing@interdumenim.co.uk','7572 8893','1994-04-07'),
  (3,'18874657-8','Dorothy','Callahan','fringilla.ornare.placerat@arcuvivamus.org','7552 2611','2002-03-19'),
  (4,'12941854-0','Amity','Rosales','sodales.mauris.blandit@penatibuset.ca','7240 4554','1974-05-29'),
  (5,'29535969-2','Kylan','Kent','leo.morbi.neque@mollisnoncursus.net','7589 9385','1996-05-12'),
  (6,'11151589-4','Olivia','Goodwin','molestie@tincidunt.edu','7178 2116','1977-07-08'),
  (7,'44807251-7','Marny','Mcbride','dictum@tristique.co.uk','7146 4846','2001-11-19'),
  (8,'27507167-6','Charles','Gordon','tempor.est@faucibus.com','7348 0242','1996-12-14'),
  (9,'38207205-7','Lars','Dudley','sit@enimnec.co.uk','7305 2821','1984-11-11'),
  (10,'20434355-1','Thaddeus','Gonzales','sociis@adipiscing.co.uk','7185 7551','1971-08-15'),
  (11,'34659123-4','Barrett','Salinas','massa.non@nunc.co.uk','7877 6785','1995-11-06');
GO
INSERT INTO patient (user_id,dui,[name],lastname,email,phone,birthdate)
VALUES
  (12,'07453998-7','Alika','Hamilton','fringilla.ornare.placerat@odioetiam.edu','7487 5704','1998-11-27'),
  (13,'24215124-0','Kenneth','Rose','nostra.per.inceptos@egestasfusce.edu','7371 9384','1988-03-23'),
  (14,'14237581-8','Yael','Espinoza','morbi.non@sed.org','7707 2186','1974-04-01'),
  (15,'09259498-1','Chloe','Colon','pharetra.quisque@torquentperconubia.org','7255 1720','1990-06-01'),
  (16,'42640462-1','Zeph','Mayo','integer@vulputateullamcorpermagna.ca','7780 8786','1974-09-25'),
  (17,'33812429-5','Sasha','Fletcher','nunc.id@mauriseu.net','7234 5888','1973-12-16'),
  (18,'47419830-8','Giselle','Anderson','amet.luctus@sedhendrerit.com','7915 3195','2002-01-27'),
  (19,'32495968-8','Scarlet','Baxter','rutrum@nonummyut.org','6104 3962','1973-06-03'),
  (20,'29986730-7','Robert','Landry','tempor.augue@nibhenim.net','7877 7816','2002-08-13'),
  (21,'37498497-7','Tashya','Dalton','pretium.et@tellusjusto.ca','7657 3008','1984-11-25');
GO
INSERT INTO patient (user_id,dui,[name],lastname,email,phone,birthdate)
VALUES
  (22,'13255701-2','Erin','Cook','pede.suspendisse@idmollis.co.uk','7485 6488','1977-12-28'),
  (23,'34417661-2','Adrienne','Reed','duis.at@non.ca','7116 3218','1974-10-23'),
  (24,'14974202-6','Jameson','Wood','et.netus.et@diamluctus.edu','7351 1691','1978-09-06'),
  (25,'47679743-8','Quinn','Heath','egestas.rhoncus@nullain.ca','7624 4117','1988-01-25'),
  (26,'10663700-8','Hammett','Mcleod','tempor.bibendum@blanditat.ca','7284 1228','2003-08-11'),
  (27,'40310992-4','Cameron','Moore','neque.venenatis.lacus@velest.ca','7315 7310','1981-09-01'),
  (28,'41202221-1','Alea','Pate','tristique@tellusnunc.com','6572 1883','1991-02-22'),
  (29,'02116981-1','Odessa','Wright','donec@nam.co.uk','6127 5585','1997-01-15'),
  (30,'04542154-6','Andrew','Fuller','libero.dui@ipsum.com','6683 8426','1987-08-07'),
  (31,'03222444-9','George','Hart','nibh.quisque@ullamcorper.co.uk','7707 5843','1985-07-29');
GO
INSERT INTO patient (user_id,dui,[name],lastname,email,phone,birthdate)
VALUES
  (32,'19582692-7','Mufutau','Leonard','in@necimperdiet.com','7230 1803','1985-12-18'),
  (33,'44548890-9','Drew','Clayton','amet@sed.org','7786 1562','1975-01-01'),
  (34,'30408400-6','Ahmed','Watkins','a.dui.cras@nullatemporaugue.org','7445 8141','2002-12-08'),
  (35,'48175602-2','Diana','Hayden','posuere.cubilia@magnapraesentinterdum.org','7305 2661','1973-06-04'),
  (36,'16308618-2','Nissim','Weaver','nunc.pulvinar@utnisia.net','7534 6258','1987-05-04'),
  (37,'12967407-5','Fitzgerald','Mcintyre','elit.erat@inmolestie.edu','7861 7531','1997-03-19'),
  (38,'01862119-3','Richard','Eaton','ante@incursus.org','7398 1763','1970-04-01'),
  (39,'10961245-7','Robin','Bennett','ultrices.posuere@quisque.org','6672 4863','1975-09-02'),
  (40,'24234791-9','Gillian','Mejia','praesent.eu@magnisdisparturient.edu','7605 2325','1985-04-08'),
  (41,'11820727-0','Nathaniel','Dudley','massa.vestibulum@morbiquis.ca','6556 2157','1980-07-15');
GO
INSERT INTO patient (user_id,dui,[name],lastname,email,phone,birthdate)
VALUES
  (42,'50375178-5','Buckminster','Torres','rutrum.magna@temporbibendum.co.uk','7773 3779','1975-08-02'),
  (43,'42364324-2','Rylee','Vargas','cum@mitempor.ca','6515 7112','1994-04-30'),
  (44,'28698150-4','Jerry','Tucker','odio@posuere.org','7271 5411','1985-01-25'),
  (45,'73713070-2','Tanek','Calhoun','cras.convallis.convallis@sedpede.edu','7891 7792','1988-05-03'),
  (46,'40185370-7','Damon','Noel','integer.eu@nonummyipsum.ca','7232 1285','1999-04-24'),
  (47,'41463369-2','Aidan','Golden','placerat.orci@pede.ca','7336 2136','1987-03-12'),
  (48,'32787013-4','Marshall','Nieves','mauris.eu@ipsumporta.co.uk','6438 6415','2002-01-19'),
  (49,'16668664-4','Maggie','Dunlap','nec.malesuada@malesuadafames.com','6364 4643','1977-05-14'),
  (50,'49602575-8','Susana','Burke','ultricies.sem.magna@eu.com','7386 7440','1982-03-23'),
  (51,'40777318-7','Brenna','Rios','et.magnis@suspendissesed.com','7451 6212','1975-09-17');
GO
INSERT INTO patient (user_id,dui,[name],lastname,email,phone,birthdate)
VALUES
  (52,'34584518-6','Megan','Shaffer','sit.amet.consectetuer@sapiennunc.edu','7684 5436','1997-05-16'),
  (53,'23195621-2','Elias','Collins','hendrerit.consectetuer.cursus@vitaealiquet.ca','7528 3858','1982-02-01'),
  (54,'48609505-9','Blake','Greer','mattis.semper.dui@arcumorbisit.com','7269 5064','1984-02-29'),
  (55,'13270662-5','Sigourney','Glover','tellus@scelerisquemollisphasellus.net','7317 7182','1985-10-17'),
  (56,'26100185-3','Paula','Rocha','ullamcorper.magna@risusquisque.co.uk','7916 5726','1998-09-29'),
  (57,'10959922-0','Judith','Hammond','id.libero.donec@vivamusnibhdolor.com','7872 2263','1984-01-08'),
  (58,'04486261-1','Maris','Park','posuere.enim@telluseu.net','7953 2151','1975-08-27'),
  (59,'22103903-3','Jade','Mclaughlin','et.arcu.imperdiet@craseget.ca','7727 6162','1988-05-16'),
  (60,'01634182-7','Valentine','Walker','id.sapien@nunc.com','7834 9373','1996-07-22'),
  (61,'32280832-1','Vera','Patel','molestie.pharetra@cumsociisnatoque.org','7751 9848','1975-04-20');
GO
INSERT INTO patient (user_id,dui,[name],lastname,email,phone,birthdate)
VALUES
  (62,'15145662-6','Mollie','Byers','nunc.mauris@ultrices.net','7702 1585','1992-09-13'),
  (63,'36693328-3','Sawyer','Zimmerman','vitae.aliquam.eros@aliquamnec.org','7052 0603','1983-04-23'),
  (64,'16567357-3','Cullen','Sanchez','eget.metus.in@suspendissesed.com','7143 7271','1994-01-08'),
  (65,'24572831-8','Ariel','Hernandez','viverra.donec@adipiscingfringillaporttitor.ca','7052 9210','1971-12-01'),
  (66,'23877307-5','Len','Hatfield','nunc.in@aliquetmolestie.net','7216 7661','1993-07-27'),
  (67,'69935045-2','Seth','Rivers','pharetra.sed@dictumsapien.ca','7778 5276','1997-10-16'),
  (68,'97515721-2','Eliana','Boyer','aenean@aliquamadipiscinglacus.com','7234 5300','1982-12-26'),
  (69,'41484521-6','Zelenia','Vargas','nunc.in.at@liberoestcongue.org','7723 4545','2003-12-17'),
  (70,'16272489-4','Ezekiel','Richardson','ridiculus.mus.proin@sedtortor.ca','7611 0476','1987-04-03'),
  (71,'17536856-6','Rose','Peck','quam.pellentesque.habitant@sodalesnisimagna.net','7340 2331','1982-07-27');
GO
INSERT INTO patient (user_id,dui,[name],lastname,email,phone,birthdate)
VALUES
  (72,'41571703-2','Raya','Fry','blandit@sed.edu','7536 2535','1992-06-27'),
  (73,'47277216-3','Molly','Ball','nunc.sed.pede@orcilacus.co.uk','7076 7582','1987-11-13'),
  (74,'28296848-7','Laith','Nash','sit@ultricesposuere.org','7970 8418','1973-02-17'),
  (75,'17456417-5','Dennis','Douglas','taciti.sociosqu@egestashendrerit.co.uk','7429 6688','2002-06-21'),
  (76,'11675314-6','Brielle','Spence','sit.amet.risus@lobortis.org','7141 5216','1990-08-08'),
  (77,'45133435-2','Zephania','Terrell','sit.amet.risus@ullamcorpervelitin.edu','7712 7546','1995-07-18'),
  (78,'20832068-1','Nomlanga','Moore','ipsum@et.net','7551 6138','2001-12-05'),
  (79,'26782584-2','James','Becker','a.auctor.non@auguesed.org','7771 2149','2002-07-28'),
  (80,'42959674-2','Debra','Brooks','vitae@euismodin.org','7194 7148','2002-08-31'),
  (81,'29271918-3','Cadman','Barker','suspendisse.dui@egetvariusultrices.co.uk','7486 0698','1979-06-30');
GO
INSERT INTO patient (user_id,dui,[name],lastname,email,phone,birthdate)
VALUES
  (82,'22892599-3','Dennis','Richard','ultrices.posuere@aenean.com','7939 5342','1978-09-04'),
  (83,'50997631-4','Clinton','Wilkinson','purus@anteipsum.edu','7312 9819','2000-02-28'),
  (84,'43189076-6','Orla','Bates','augue@idliberodonec.org','7894 5538','1970-02-12'),
  (85,'16447146-2','Ila','Duran','aliquam.auctor@auctorvitae.com','7516 4127','1973-10-14'),
  (86,'22821778-6','Ruby','Hurst','non@semut.org','7583 4753','1983-05-27'),
  (87,'62480206-0','Wang','Moreno','mauris.quis.turpis@cras.edu','7183 5012','2000-11-09'),
  (88,'43638219-7','Sopoline','Stout','quisque.fringilla.euismod@iderat.edu','7634 1450','2002-10-30'),
  (89,'25668693-7','Charity','Richards','nunc.in@nunc.org','7638 1168','1989-02-10'),
  (90,'73915624-2','Kane','Schneider','mus.donec.dignissim@hendrerita.edu','7795 2842','1998-11-05'),
  (91,'19688740-7','Cheyenne','Beard','sapien@lectusantedictum.com', '7323 3614','1980-04-15');
GO
INSERT INTO patient (user_id,dui,[name],lastname,email,phone,birthdate)
VALUES
  (92,'41105489-6','Tara','Barry','ante.lectus@maecenasiaculis.net','7647 0841','2001-02-08'),
  (93,'73119073-1','Michael','Rasmussen','pede@venenatisa.net','7211 8342','1987-04-29'),
  (94,'14947823-5','Akeem','Wilkerson','quis.diam@nibhvulputate.ca','7051 5191','1996-01-03'),
  (95,'41206437-2','Molly','Francis','fermentum.risus.at@magnaet.org','7588 1310','1987-06-02'),
  (96,'62563326-2','Janna','Wiley','interdum@donecat.co.uk','7321 0848','1993-04-14'),
  (97,'45829132-2','Eagan','Buckner','fusce@lectusconvallisest.net','6355 1489','1984-05-29'),
  (98,'15399278-3','Bertha','Yates','sodales@ligulaeu.org','7474 3632','1986-01-25'),
  (99,'41782995-4','Bevis','Tate','dictum.phasellus@quisquelibero.net','7394 6877','2003-07-13'),
  (100,'21144971-3','Alfonso','Crane','eu.nibh.vulputate@felispurus.org','7386 7367','1982-08-17'),
  (101,'54728546-1','Nasim','Koch','leo.cras@miduisrisus.co.uk','7593 8164','1997-12-05');
  GO

--inserting values into inventory
insert into inventory values ('Ibuprofeno',200, 40);
insert into inventory values ('Naproxeno',200, 30);
insert into inventory values ('Acetaminofen',200,10);
insert into inventory values ('Tylenol',200,15.50);
insert into inventory values ('Vicodin',200,30.45);
insert into inventory values ('Percocet',200,11.35);
insert into inventory values ('Artroben',200,49.99);
insert into inventory values ('Lincocin',200,30.55);
insert into inventory values ('Dalacin',200,25.99);
insert into inventory values ('Binotal',200,14.55);
insert into inventory values ('Amosan',200,67.70);
insert into inventory values ('Ectaprim',200,75.90);
insert into inventory values ('Bexident encías',200,25.90);
insert into inventory values ('Cefalver',200,37.90);
insert into inventory values ('Diclofenac',200,30);
insert into inventory values ('Metamizol',200,45.99);
insert into inventory values ('Amoxicilina',200,19.99);
insert into inventory values ('Clindamicina',200,35.80);
insert into inventory values ('Azitromicina',200,10.99);
insert into inventory values ('Cefalexina',200,15.67);
insert into inventory values ('Ceftriaxona',200,19.99);
insert into inventory values ('Claritromicina',200,29.99);
insert into inventory values ('Penicilina',200,15.75);
insert into inventory values ('Metronidazol',200,25.89);
insert into inventory values ('Peroxido de hidrogeno',200,15.67);
insert into inventory values ('Agua oxigenada',200,9.75);
insert into inventory values ('Yodo',200,6.75);
insert into inventory values ('Actron Suspensión Infantil',200,20.99);
insert into inventory values ('Advil',200,10.99);
insert into inventory values ('Advil Suspensión Pediátrica',200,23.45);
insert into inventory values ('Tylenol Infantil',200,15.79);
insert into inventory values ('Clendix',200,19.75);
insert into inventory values ('Tempra Forte',200,10.99);
insert into inventory values ('AmoBay CL',200,15.79);
insert into inventory values ('Clauvin 12H',200,29.99);
insert into inventory values ('Polymox',200,57.99);
insert into inventory values ('Dermocleen',200,16.89);
insert into inventory values ('Bexident',200,14.79);
insert into inventory values ('Perio Dentyl',200,23.90);
insert into inventory values ('Augmentin',200,30.60);
insert into inventory values ('Dalacin C',200,49.99);
insert into inventory values ('Voltraren',200,55.49);
insert into inventory values ('Rapiclav',200,67.99);
insert into inventory values ('Baby predental solucion',200,6.71);
insert into inventory values ('Bluclorhex pasta',200,6.50);
insert into inventory values ('Bluclorhex plus spray',200,7.75);
insert into inventory values ('Bluclorhex solucion',200,4.95);
insert into inventory values ('Cariax gingival colutorio',200,11.24);
insert into inventory values ('Cariax gingival enjuague',200,15.94);
insert into inventory values ('Cariax gingival pasta',200,11.24);
insert into inventory values ('Cepillo eldgydium blanqueo',200,3.40);
insert into inventory values ('Cepillo eldgydium periodental',200,3.40);
insert into inventory values ('Cepillo eldgydium postoperatorio',200,3.40);
insert into inventory values ('Cepillo kin post-quirurgico',200,3.44);
insert into inventory values ('Cepillo interdental trio mix',200,5.52);
insert into inventory values ('Cepillo kin protesis',200,3.44);
insert into inventory values ('Clorhexidina lacer colutorio',200,7.22);
insert into inventory values ('Clorhexidina lacer gel tubo',200,9.31);
insert into inventory values ('Clorhexidina lacer pasta',200,7.87);
insert into inventory values ('Clorhexidina lacer spray',200,11.47);
insert into inventory values ('Corega x30 tabletas',200,6.11);
insert into inventory values ('Corsy-dent 12% mk solucion',200,6.82);
insert into inventory values ('Elgydium sensitive gel',200,11.04);
insert into inventory values ('Eudril active enjuague',200,11.04);
insert into inventory values ('Eugel gel bucal',200,9.02);
insert into inventory values ('Fkd dentrifico blank',200,14.40);
insert into inventory values ('Fluor kin bifluor',200,8.87);
insert into inventory values ('Fluor kin calcium enjuague',200,12.51);
insert into inventory values ('Fluor kin enjuague bucal infantil',200,11.26);
insert into inventory values ('Fluor lacer x100 tabletas',200,6.66);
insert into inventory values ('Gingi-dent mk solucion',200,8.38);
insert into inventory values ('Gingilacer colutorio enjuague',200,12.76);
insert into inventory values ('Gingilacer pasta tubo',200,11.29);
insert into inventory values ('Hilo dental elgydium',200,4.47);
insert into inventory values ('Kin b5 0.05% enjuague',200,20.33);
insert into inventory values ('Kin baby gel',200,9.78);
insert into inventory values ('Kin care gel',200,20.65);
insert into inventory values ('Kin hidrat pasta',200,11.96);
insert into inventory values ('Crema fijadora protesis dental',200,8.68);
insert into inventory values ('Kin hidrat spray',200,14.53);
insert into inventory values ('Cariax desensibilizante',200,12.91);
insert into inventory values ('Oddent acido hialuronico fluido',200,26.68);
insert into inventory values ('Oddent gingival gel',200,9.02);
insert into inventory values ('Oddent acido hialuronico baby',200,26.68);
insert into inventory values ('Oddent acido hialuronico junior gel',200,20.01);
insert into inventory values ('Oralexina solucion',200,6.97);
insert into inventory values ('Perio kin enjuague',200,14.17);
insert into inventory values ('Perio kin hyaluronic 1% gel tubo',200,9.02);
insert into inventory values ('Tapa protectora para cepillo',200,1.75);
insert into inventory values ('Gum hilo dental con menta',200,5.60);
insert into inventory values ('Oral b superfloss',200,4.10);
insert into inventory values ('Cepillo infantil hello kitty',200,1.25);
insert into inventory values ('Cepillo infantil batman',200,1.25);
insert into inventory values ('Acla-med bid x14 tabletas',200,21.87);
insert into inventory values ('Activ ozone solucion oral',200,43.95);
insert into inventory values ('Ambigram x20 tabletas',200,10.53);
insert into inventory values ('Avelox x20 comprimidos',200,123.42);
insert into inventory values ('Baclosef x10 tabletas',200,12.92);
insert into inventory values ('Bredelin x7 tabletas',200,28.05);
insert into inventory values ('Cefadroxilo x30 capsulas',200,20.11);

--Insertando Dentistas
insert into dentist
values ('Josue Montano', 'General', '1', 'Josuemontano@gmail.com', '78398474');
insert into dentist
values ('Andrea Guadalupe', 'Endodontist', '1', 'Andreaguadalupe@gmail.com', ' 79097543');
insert into dentist
values ('Ivania Lebron', 'Maxillofacial', '1', 'Ivanialebron@gmail.com', '78907644');
insert into dentist
values ('Luciana Munguia', 'Orthodontist', '1', 'Luciana_@gmail.com', '76543567');
insert into dentist
values ('Kallahan Salas', 'Prosthodontist', '2', 'Andyysalasb@gmail.com', '75830124');
insert into dentist
values ('Luis Gonzales', 'General', '1', 'Luis12@gmail.com', '79097543');
insert into dentist
values ('Juan Lopez', 'General', '1', 'Juan2243@gmail.com', '79879099');
insert into dentist
values ('Juan Ramos', 'Endodontist', '1', 'Juanra@gmail.com', '79035162 ');
insert into dentist
values ('José Cuellar', 'General', '1', 'JJCuellar@gmail.com', '79821274' );
insert into dentist
values ('Marta Estevez', 'Maxillofacial', '1', 'Estevzz@gmail.com',  '64456723 ');
insert into dentist
values ('Alma Duarte', 'Orthodontist', '1', 'AMD35@gmail.com',  '75433467 ');
insert into dentist
values ('Estephanie Vasquez', 'General', '1', 'Vasquez14@gmail.com',  '76531356');
insert into dentist
values ('Jaime Portal', 'Pediatric Dentist', '1', 'Portalportal@gmail.com',  '76512343 ');
insert into dentist
values ('Eduardo Lemus', 'Maxillofacial', '1', 'Eduele@gmail.com',  '76543212 ');
insert into dentist
values ('Rebecca Ibarra', 'Pediatric Dentist', '1', 'RebeIb@gmail.com',  '74454321 ');
insert into dentist
values ('Roberto Salazar', 'Prosthodontist', '0', 'Salazarr@gmail.com',  '67876432 ');
insert into dentist
values ('Roberto Salazar', 'Prosthodontist', '1', 'Salazarrs@gmail.com',  '67876432 ');
insert into dentist
values ('Pedro Lopez', 'General', '1', 'JPLzz@gmail.com', '76543445');
insert into dentist
values ('Martina Flamenco', 'Endodontist', '1', 'MartinaFF@gmail.com', ' 76532344');
insert into dentist
values ('Ivan Cabreara', 'Maxillofacial', '1', 'Cabreraivan@gmail.com', '76533343');
insert into dentist
values ('Patricia Alvarez', 'Orthodontist', '1', 'Patyalvarez@gmail.com', '70816389');
insert into dentist
values ('José  Osorio', 'Prosthodontist', '1', 'Osorioguapo@gmail.com', '65414253');
insert into dentist
values ('Maria Hernandez', 'General', '1', 'Mhernandez@gmail.com', '72645363');
insert into dentist
values ('Gabriela Hernandez', 'General', '1', 'gmh15@gmail.com', '78987667');
insert into dentist
values ('Rodrigo Portillo', 'Endodontist', '1', 'Rportillo@gmail.com', '77087667 ');
insert into dentist
values ('Luciana Sandoval', 'General', '2', 'Sandovall43@gmail.com', '61524353' );
insert into dentist
values ('Nicolle Gavidia', 'Maxillofacial', '1', 'Gavidia654@gmail.com',  '78765654 ');
insert into dentist
values ('Juan José Cristales', 'Orthodontist', '1', 'JJcristales@gmail.com',  '61425363 ');
insert into dentist
values ('Lucia Cabrera', 'General', '1', 'cabreralucia12@gmail.com',  '6524152');
insert into dentist
values ('Alfonso Ayala', 'Pediatric Dentist', '1', 'ayala5433@gmail.com',  '76567654 ');
insert into dentist
values ('José Bojorquez', 'Maxillofacial', '1', 'joseroberto@gmail.com',  '71633526 ');
insert into dentist
values ('Alexander Siguenza', 'Pediatric Dentist', '1', 'alexsiguenza@gmail.com',  '74454321 ');
insert into dentist
values ('Maria Portillo', 'Prosthodontist', '1', 'portillomm12@gmail.com',  '66728273 ');
insert into dentist
values ('Ivonne Dueñas', 'Prosthodontist', '1', 'dueñasi12@gmail.com',  '76817263 ');
insert into dentist
values ('Jaime Camil', 'General', '1', 'camilJaime89@gmail.com', '65262535');
insert into dentist
values ('Paulina Rubio', 'Endodontist', '1', 'RUBIIO11@gmail.com', ' 74747474');
insert into dentist
values ('Adriana Hasbun', 'Maxillofacial', '0', 'adrihasbun@gmail.com', '79340606');
insert into dentist
values ('Drake Bell', 'Orthodontist', '0', 'Belllll__@gmail.com', '77656524');
insert into dentist
values ('Fivel Stewart', 'Prosthodontist', '1', 'heyfivel@gmail.com', '65654342');
insert into dentist
values ('Erika Contreras', 'General', '1', 'contreraserika@gmail.com', '82728373');
insert into dentist
values ('Osiris Zarahi', 'General', '1', 'Osirisbqdl@gmail.com', '76567615');
insert into dentist
values ('Carlos Linqui', 'Endodontist', '1', 'LinquiCarlos__@gmail.com', '67628163 ');
insert into dentist
values ('Rene Vega', 'General', '1', 'Rrrrene@gmail.com', '61524242' );
insert into dentist
values ('Emiliano Cuellar', 'Maxillofacial', '1', 'Cuellar.cuellar@gmail.com',  '78786565 ');
insert into dentist
values ('Francis Trujillo', 'Orthodontist', '1', 'Dulcefrancis@gmail.com',  '65467876 ');
insert into dentist
values ('Melvin Peñate', 'General', '1', 'peñatep@gmail.com',  '72836545');
insert into dentist
values ('Sara Matamoros', 'Pediatric Dentist', '1', 'matamoros333@gmail.com',  '76767676 ');
insert into dentist
values ('Isabel Salinas', 'Maxillofacial', '1', 'isalinas@gmail.com',  '78765654 ');
insert into dentist
values ('Alvaro Torres', 'Pediatric Dentist', '1', 'torresz.53@gmail.com',  '65455433 ');
insert into dentist
values ('Arianne Saade', 'Prosthodontist', '1', 'saadeari@gmail.com',  '76542343 ');
insert into dentist
values ('Yanira Ibañez', 'Prosthodontist', '2', 'ibañez@gmail.com',  '7665454 ');
insert into dentist
values ('Manuel  Salazar', 'General', '1', 'massercrack@gmail.com', '783984748');
insert into dentist
values ('Jessica Martinez', 'Endodontist', '1', 'MMjessica@gmail.com', ' 79097543');
insert into dentist
values ('Ana Guerrero', 'Maxillofacial', '1', 'anitagpl@gmail.com', '78907644');
insert into dentist
values ('David Hernandez', 'Orthodontist', '1', 'cumpledavid@gmail.com', '76543567');
insert into dentist
values ('Fatima Menendez', 'Prosthodontist', '1', 'mendendezff@gmail.com', '75830124');
insert into dentist
values ('Federico Heymann', 'General', '1', 'Heymann@gmail.com', '79097543');
insert into dentist
values ('Diego Orantes', 'General', '1', 'orantesdiego@gmail.com', '79879099');
insert into dentist
values ('Paola Argueta', 'Endodontist', '1', 'riarenne@gmail.com', '79035162 ');
insert into dentist
values ('Abigail Toledo', 'General', '1', 'exabigail@gmail.com', '79821274' );
insert into dentist
values ('Nestor Linares', 'Maxillofacial', '1', 'roboticlover@gmail.com',  '64456723 ');
insert into dentist
values ('Carlos Francia', 'Orthodontist', '0', 'franciaquimico@gmail.com',  '75433467 ');
insert into dentist
values ('Elsy Cisneros', 'General', '1', 'CisnerosElsy@gmail.com',  '76531356');
insert into dentist
values ('Jaime Cisneros', 'Pediatric Dentist', '1', 'Cisnefamily@gmail.com',  '76512343 ');
insert into dentist
values ('Elsa Lemus', 'Maxillofacial', '1', 'lemusela@gmail.com',  '76543212 ');
insert into dentist
values ('Juan Ortiz', 'Pediatric Dentist', '1', 'ortiszszsz@gmail.com',  '74454321 ');
insert into dentist
values ('Rebecca Salas', 'Prosthodontist', '1', 'rebeb.salas@gmail.com',  '67876432 ');
insert into dentist
values ('Gladys Hernandez', 'Prosthodontist', '1', 'gladyssss.h@gmail.com',  '67876432 ');
insert into dentist
values ('Freddy Salas', 'General', '1', 'salassss12@gmail.com', '783984748');
insert into dentist
values ('Fatima Ayala', 'Endodontist', '1', 'ayalaff@gmail.com', ' 79097543');
insert into dentist
values ('Kath Ordoñez', 'Maxillofacial', '1', 'ootarhkath@gmail.com', '78907644');
insert into dentist
values ('Carlos Salas', 'Orthodontist', '1', 'cmanfredo@gmail.com', '76543567');
insert into dentist
values ('Mauricio Amaya', 'Prosthodontist', '1', 'maauamaya@gmail.com', '75830124');
insert into dentist
values ('Michelle Gomez', 'General', '1', 'claudia1212@gmail.com', '79097543');
insert into dentist
values ('Lourdes Cuellar', 'General', '1', 'locuellar@gmail.com', '79879099');
insert into dentist
values ('Daniela Batarse', 'Endodontist', '1', 'danibatarse@gmail.com', '79035162 ');
insert into dentist
values ('Joel Cardona', 'General', '1', 'elchicky12@gmail.com', '79821274' );
insert into dentist
values ('Valeria Urrutia', 'Maxillofacial', '1', 'urrutiavaleria@gmail.com',  '64456723 ');
insert into dentist
values ('Mariana Salazar', 'Orthodontist', '1', 'marianasalazar@gmail.com',  '75433467 ');
insert into dentist
values ('Andrea María Contreras', 'General', '1', 'AMC23@gmail.com',  '76531356');
insert into dentist
values ('Sara Lopez', 'Pediatric Dentist', '1', 'sarilopez@gmail.com',  '76512343 ');
insert into dentist
values ('Geoffrey Rios', 'Maxillofacial', '1', 'geofrios@gmail.com',  '76543212 ');
insert into dentist
values ('Alexa Maria Granados', 'Pediatric Dentist', '1', 'aletasker@gmail.com',  '74454321 ');
insert into dentist
values ('Ana María Aguilar', 'Prosthodontist', '1', 'anadibujos@gmail.com',  '67876432 ');
insert into dentist
values ('Angel Lopez', 'Prosthodontist', '1', 'angelitoo@gmail.com',  '67876432 ');
insert into dentist
values ('Diego Mendoza', 'General', '1', 'dieogmendoza@gmail.com', '76543445');
insert into dentist
values ('Alejandro Buendia', 'Endodontist', '1', 'gooday@gmail.com', ' 76532344');
insert into dentist
values ('Fernando Manzano', 'Maxillofacial', '1', 'applefernando@gmail.com', '76533343');
insert into dentist
values ('Juan Carlos Ayala', 'Orthodontist', '1', 'juancolombia@gmail.com', '70816389');
insert into dentist
values ('Ivan Saraverria', 'Prosthodontist', '1', 'donivan@gmail.com', '65414253');
insert into dentist
values ('Eduardo Avila', 'General', '1', 'eduavila@gmail.com', '72645363');
insert into dentist
values ('Fabrizio Corletto', 'General', '1', 'corlettooof@gmail.com', '78987667');
insert into dentist
values ('Frida Serrano', 'Endodontist', '1', 'serranofrida@gmail.com', '77087667 ');
insert into dentist
values ('Fabiola Serrano', 'General', '1', 'fabiserrano@gmail.com', '61524353' );
insert into dentist
values ('Gustavo Lopez', 'Maxillofacial', '1', 'GLMP72@gmail.com',  '78765654 ');
insert into dentist
values ('Juan José Cristales', 'Orthodontist', '1', 'JJcristaless@gmail.com',  '61425363 ');
insert into dentist
values ('Karla Hernandez', 'General', '1', 'exkarlah12@gmail.com',  '6524152');
insert into dentist
values ('Madelin Portillo', 'Pediatric Dentist', '1', 'portillomade@gmail.com',  '76567654 ');
insert into dentist
values ('Damaris Alas', 'Maxillofacial', '1', 'alasdamaris@gmail.com',  '71633526 ');
insert into dentist
values ('Paul Cohen', 'Pediatric Dentist', '1', 'drcohen@gmail.com',  '74454321 ');
insert into dentist
values ('Michelle Moran', 'Prosthodontist', '1', 'Michimoran@gmail.com',  '66728273 ');
insert into dentist
values ('Juan Calros Oporto', 'Prosthodontist', '1', 'oportojuan@gmail.com',  '76817263 ');
insert into dentist
values ('Pamela Hernandez', 'General', '1', 'crazypamela@gmail.com', '65262535');
insert into dentist
values ('Geraldine Toledo', 'Endodontist', '1', 'eltunquitofreson@gmail.com', ' 74747474');
insert into dentist
values ('Loelia Chaverria', 'Maxillofacial', '1', 'loeliach@gmail.com', '79340606');
insert into dentist
values ('Rachel Rodriguez', 'Orthodontist', '1', 'brachel@gmail.com', '77656524');
insert into dentist
values ('Sofia Falla', 'Prosthodontist', '1', 'fallaloca@gmail.com', '65654342');
insert into dentist
values ('Hazel Alissette', 'General', '1', 'hazzel_alizzete@gmail.com', '82728373');
insert into dentist
values ('Willson Carbajal', 'General', '1', 'will_carbajal_@gmail.com', '76567615');
insert into dentist
values ('Giselle Hernandez', 'Endodontist', '1', 'i4mgigi@gmail.com', '67628163 ');
insert into dentist
values ('Oscar Arana', 'General', '1', 'kxarana17@gmail.com', '61524242' );
insert into dentist
values ('Katherinne Baires', 'Maxillofacial', '1', '_kthm_.cuellar@gmail.com',  '78786565 ');
insert into dentist
values ('Ricardo Arevalo', 'Orthodontist', '1', 'richitoh@gmail.com',  '65467876 ');
insert into dentist
values ('Atenea Wings', 'General', '1', 'onlydama@gmail.com',  '72836545');
insert into dentist
values ('Robert Monterrosa', 'Pediatric Dentist', '1', 'roberttt@gmail.com',  '76767676 ');
insert into dentist
values ('Fatima Reyes', 'Maxillofacial', '1', 'ifatimareyes@gmail.com',  '78765654 ');
insert into dentist
values ('Melissa Mendoza', 'Pediatric Dentist', '1', '_mendozamelissa.53@gmail.com',  '65455433 ');
insert into dentist
values ('Sarah Blake', 'Prosthodontist', '1', 'blakesarah@gmail.com',  '76542343 ');
insert into dentist
values ('Diego Figueroa', 'Prosthodontist', '1', 'figueroa_1005@gmail.com',  '7665454 ');
insert into dentist
values ('Zahid Ranger', 'General', '1', 'itsranger@gmail.com', '783984748');
insert into dentist
values ('Luisa Maria', 'Endodontist', '1', 'luisamaria17@gmail.com', ' 79097543');
insert into dentist
values ('Jose Jordan', 'Maxillofacial', '1', 'mjordan.x@gmail.com', '78907644');
insert into dentist
values ('Claudia Estrada', 'Orthodontist', '1', 'estradaclau@gmail.com', '76543567');
insert into dentist
values ('Oscar Flores', 'Prosthodontist', '1', 'floflo@gmail.com', '75830124');
insert into dentist
values ('Brandon Montoya', 'General', '1', 'montoy_29@gmail.com', '79097543');
insert into dentist
values ('Andrea Salndoval', 'General', '1', 'ansandoval@gmail.com', '79879099');
insert into dentist
values ('Erika Zaldaña', 'Endodontist', '1', 'erika.zaldanaaa@gmail.com', '79035162 ');
insert into dentist
values ('Natalia Polanco', 'General', '1', 'natpolanco16@gmail.com', '79821274' );
insert into dentist
values ('Antonio Gil', 'Maxillofacial', '1', '_gil.700@gmail.com',  '64456723 ');
insert into dentist
values ('Natalia Chacon', 'Orthodontist', '1', 'n4tt.03_@gmail.com',  '75433467 ');
insert into dentist
values ('Mariana Gonzales', 'General', '1', 'marygonza@gmail.com',  '76531356');
insert into dentist
values ('Axcel Escobar', 'Pediatric Dentist', '1', 'axcelescobar@gmail.com',  '76512343 ');
insert into dentist
values ('Francis Cabrerar', 'Maxillofacial', '1', 'francisdecabrera@gmail.com',  '76543212 ');
insert into dentist
values ('Juan Victoria Aguirre', 'Pediatric Dentist', '1', 'vict_07@gmail.com',  '74454321 ');
insert into dentist
values ('Olvier Avendaño', 'Prosthodontist', '1', 'avendaño__.@gmail.com',  '67876432 ');
insert into dentist
values ('Josue Orellana', 'Prosthodontist', '1', 'balmo.ore@gmail.com',  '67876432 ');