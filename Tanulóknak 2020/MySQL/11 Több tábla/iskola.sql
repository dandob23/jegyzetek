CREATE TABLE osztalyok (osztaly VARCHAR(2) PRIMARY KEY,of VARCHAR(20));
INSERT INTO `osztalyok` VALUES ('1A','Nagy Andrea');
INSERT INTO `osztalyok` VALUES ('1B','Kovács Edit');
INSERT INTO `osztalyok` VALUES ('2A','Tóth Lajos');
INSERT INTO `osztalyok` VALUES ('2B','Kovács Géza');
CREATE TABLE diakok (
  az INT PRIMARY KEY,
  nev VARCHAR(20),
  osztaly VARCHAR(2), 
  atlag DOUBLE
);
INSERT INTO `diakok` VALUES (1,'Kiss László','1A',3.25);
INSERT INTO `diakok` VALUES (2,'Kádár Judit','1A',4.68);
INSERT INTO `diakok` VALUES (3,'Szűcs János','1B',3.55);
INSERT INTO `diakok` VALUES (4,'Boros Ilona','1B',2.35);
INSERT INTO `diakok` VALUES (5,'Szabó Sándor','2A',4.1);
INSERT INTO `diakok` VALUES (6,'Koltai Judit','2A',4.4);
