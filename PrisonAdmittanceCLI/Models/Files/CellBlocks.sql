create table CellBlocks (
	CellBlock_ID INT PRIMARY KEY,
	CrimeCategory VARCHAR(20),
	Gender VARCHAR(10),
	Prison_ID INT FOREIGN KEY REFERENCES Prisons(Prison_ID)
);
insert into CellBlocks (CellBlock_ID, CrimeCategory, Gender, Prison_ID)
values (1, 'fraud', 'Male', 001);
insert into CellBlocks (CellBlock_ID, CrimeCategory, Gender, Prison_ID)
values (2, 'robbery', 'Male', 001);
insert into CellBlocks (CellBlock_ID, CrimeCategory, Gender, Prison_ID)
values (3, 'fraud', 'Female', 001);
insert into CellBlocks (CellBlock_ID, CrimeCategory, Gender, Prison_ID)
values (4, 'phishing', 'Female', 001);
insert into CellBlocks (CellBlock_ID, CrimeCategory, Gender, Prison_ID)
values (5, 'homicide', 'Male', 001);
insert into CellBlocks (CellBlock_ID, CrimeCategory, Gender, Prison_ID)
values (6, 'homicide', 'Female', 001);
insert into CellBlocks (CellBlock_ID, CrimeCategory, Gender, Prison_ID)
values (7, 'sexual assault', 'Female', 001);
insert into CellBlocks (CellBlock_ID, CrimeCategory, Gender, Prison_ID)
values (8, 'drug trafficking', 'Male', 001);
insert into CellBlocks (CellBlock_ID, CrimeCategory, Gender, Prison_ID)
values (9, 'fraud', 'Male', 001);
insert into CellBlocks (CellBlock_ID, CrimeCategory, Gender, Prison_ID)
values (10, 'phishing', 'Male', 001);
insert into CellBlocks (CellBlock_ID, CrimeCategory, Gender, Prison_ID)
values (11, 'phishing', 'Male', 001);
insert into CellBlocks (CellBlock_ID, CrimeCategory, Gender, Prison_ID)
values (12, 'homicide', 'Female', 001);