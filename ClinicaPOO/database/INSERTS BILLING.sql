--INSERTS BILLING
INSERT INTO billing (patient_id,method_id,medicine_id,medicine_quantity)
VALUES
  (19,1,72,5),
  (5,1,86,10),
  (55,1,42,8),
  (8,1,90,7),
  (71,1,10,4),
  (31,1,46,9),
  (84,1,50,5),
  (75,1,41,2),
  (22,1,1,7),
  (89,1,59,7);
INSERT INTO billing (patient_id,method_id,medicine_id,medicine_quantity)
VALUES
  (98,1,68,2),
  (96,1,86,8),
  (49,1,71,10),
  (36,1,93,4),
  (73,1,11,6),
  (23,1,61,2),
  (85,1,89,3),
  (38,1,6,2),
  (64,1,86,8),
  (3,1,15,3);
INSERT INTO billing (patient_id,method_id,medicine_id,medicine_quantity)
VALUES
  (85,1,57,6),
  (17,1,44,6),
  (10,1,11,2),
  (27,1,65,4),
  (41,1,83,5),
  (44,1,93,2),
  (8,1,48,5),
  (73,1,55,4),
  (17,1,32,10),
  (18,1,76,6);
INSERT INTO billing (patient_id,method_id,medicine_id,medicine_quantity)
VALUES
  (67,1,22,5),
  (1,1,84,10),
  (24,1,68,9),
  (80,1,5,7),
  (63,1,98,8),
  (74,1,46,3),
  (96,1,47,6),
  (64,1,78,1),
  (33,1,94,6),
  (87,1,48,9);
INSERT INTO billing (patient_id,method_id,medicine_id,medicine_quantity)
VALUES
  (32,1,89,8),
  (90,1,8,9),
  (28,1,42,9),
  (85,1,42,4),
  (22,1,89,8),
  (77,1,9,6),
  (91,1,71,9),
  (17,1,45,4),
  (57,1,30,9),
  (41,1,10,3);
INSERT INTO billing (patient_id,method_id,medicine_id,medicine_quantity)
VALUES
  (46,1,28,4),
  (55,1,91,1),
  (65,1,36,10),
  (46,1,41,1),
  (53,1,51,7),
  (58,1,15,1),
  (33,1,52,10),
  (17,1,12,9),
  (15,1,61,4),
  (57,1,5,2);
INSERT INTO billing (patient_id,method_id,medicine_id,medicine_quantity)
VALUES
  (88,1,31,10),
  (9,1,55,6),
  (59,1,30,8),
  (34,1,62,9),
  (53,1,62,10),
  (83,1,46,6),
  (96,1,4,7),
  (14,1,25,9),
  (24,1,79,8),
  (43,1,88,4);
INSERT INTO billing (patient_id,method_id,medicine_id,medicine_quantity)
VALUES
  (44,1,42,3),
  (59,1,51,7),
  (12,1,19,8),
  (3,1,63,10),
  (80,1,37,6),
  (13,1,94,5),
  (17,1,11,8),
  (65,1,52,9),
  (95,1,96,7),
  (91,1,86,6);
INSERT INTO billing (patient_id,method_id,medicine_id,medicine_quantity)
VALUES
  (93,1,54,9),
  (34,1,54,6),
  (66,1,42,9),
  (98,1,71,5),
  (86,1,2,6),
  (7,1,24,4),
  (81,1,71,2),
  (29,1,73,7),
  (17,1,59,7),
  (44,1,94,4);
INSERT INTO billing (patient_id,method_id,medicine_id,medicine_quantity)
VALUES
  (6,1,63,3),
  (30,1,20,3),
  (55,1,57,7),
  (61,1,11,7),
  (36,1,8,9),
  (53,1,82,8),
  (87,1,90,8),
  (94,1,4,7),
  (26,1,77,4),
  (28,1,88,3);

UPDATE B SET B.total =B.medicine_quantity*I.price
FROM billing B
INNER JOIN inventory I ON B.medicine_id=I.id