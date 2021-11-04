USE ClinicaPOO
GO

INSERT INTO [user] (username, [password], [role_id]) VALUES
('admin', 'password', 1)
GO 

-- inserts into methods table
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

