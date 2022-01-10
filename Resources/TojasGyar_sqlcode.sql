create table Nyul(
Id int primary key,
Nev varchar(30),
Nem bit);
--

create table Tojas(
Id int primary key,
Szin varchar(10),
Suly int);

--

create table Termeles(
Id int primary key identity,
Datum date,
TipusId int foreign key references Tojas(Id),
NyulId int foreign key references Nyul(Id),
Mennyiseg int);

Insert into Nyul values
(1, 'Mr. Alfie McWiggles', 1),
(2, 'Queen Lolly Palomino', 0),
(3, 'Mistress Hoppy Chinnington', 0),
(4, 'Duke Cricket Bun', 1),
(5, 'Mrs. Fuzzle Cottontail', 0),
(6, 'Viscount Tweetie Hopper', 1);

Insert into Tojas values
(1, 'kék', 51),
(2, 'cián', 62),
(3, 'zöld', 55),
(4, 'piros', 70),
(5, 'sárga', 65),
(6, 'magenta', 58);

Insert into Termeles values
('2021-03-19', 1, 1, 42),
('2021-03-28', 2, 5, 43),
('2021-03-21', 4, 4, 46),
('2021-03-17', 5, 3, 39),
('2021-03-06', 5, 1, 36),
('2021-03-15', 4, 1, 10),
('2021-03-05', 6, 4, 56),
('2021-03-27', 1, 3, 87),
('2021-03-05', 1, 5, 81),
('2021-03-30', 5, 4, 95),
('2021-03-25', 1, 4, 84),
('2021-03-05', 2, 6, 96),
('2021-03-01', 4, 1, 62),
('2021-03-05', 6, 3, 93),
('2021-03-29', 1, 2, 96),
('2021-03-18', 2, 4, 53),
('2021-03-08', 5, 2, 52),
('2021-03-29', 4, 3, 47),
('2021-03-07', 1, 4, 43),
('2021-03-02', 2, 6, 93),
('2021-03-02', 4, 3, 28),
('2021-03-05', 5, 5, 36),
('2021-03-20', 6, 6, 82),
('2021-03-17', 4, 3, 56),
('2021-03-19', 1, 4, 43),
('2021-03-30', 3, 1, 46),
('2021-03-09', 4, 3, 99),
('2021-03-12', 1, 6, 64),
('2021-03-09', 2, 6, 94),
('2021-03-25', 2, 3, 52),
('2021-03-02', 6, 6, 11),
('2021-03-23', 4, 6, 68),
('2021-03-25', 6, 5, 91),
('2021-03-23', 3, 6, 65),
('2021-03-19', 1, 6, 60),
('2021-03-13', 5, 6, 60),
('2021-03-01', 2, 4, 30),
('2021-03-20', 3, 5, 35),
('2021-03-25', 1, 2, 99),
('2021-03-18', 1, 5, 75),
('2021-03-23', 5, 2, 43),
('2021-03-09', 6, 6, 80),
('2021-03-11', 2, 3, 72),
('2021-03-13', 5, 1, 41),
('2021-03-01', 2, 1, 49),
('2021-03-01', 4, 1, 41),
('2021-03-08', 3, 1, 66),
('2021-03-06', 6, 1, 60),
('2021-03-13', 2, 6, 70),
('2021-03-16', 4, 2, 12),
('2021-03-13', 5, 6, 40),
('2021-03-03', 1, 6, 11),
('2021-03-01', 6, 6, 36),
('2021-03-01', 2, 5, 15),
('2021-03-23', 6, 1, 82),
('2021-03-27', 2, 4, 42),
('2021-03-08', 5, 2, 27),
('2021-03-29', 3, 6, 51),
('2021-03-01', 6, 1, 34),
('2021-03-24', 5, 2, 30),
('2021-03-19', 1, 4, 31),
('2021-03-01', 5, 4, 25),
('2021-03-16', 5, 6, 66),
('2021-03-15', 3, 1, 21),
('2021-03-05', 4, 1, 36),
('2021-03-24', 5, 1, 67),
('2021-03-03', 3, 2, 13),
('2021-03-06', 3, 2, 13),
('2021-03-19', 6, 2, 80),
('2021-03-21', 3, 3, 54),
('2021-03-08', 1, 5, 23),
('2021-03-14', 2, 1, 58),
('2021-03-26', 6, 1, 32),
('2021-03-19', 6, 3, 89),
('2021-03-31', 6, 1, 57),
('2021-03-15', 3, 6, 17),
('2021-03-16', 6, 1, 60),
('2021-03-08', 3, 3, 82),
('2021-03-06', 4, 1, 66),
('2021-03-01', 6, 2, 87),
('2021-03-15', 5, 2, 33),
('2021-03-10', 1, 3, 67),
('2021-03-13', 3, 5, 73),
('2021-03-07', 5, 1, 78),
('2021-03-04', 4, 4, 56),
('2021-03-07', 3, 2, 49),
('2021-03-15', 2, 1, 10),
('2021-03-29', 6, 6, 15),
('2021-03-24', 2, 1, 75),
('2021-03-09', 5, 5, 51),
('2021-03-15', 3, 1, 92),
('2021-03-19', 5, 4, 42),
('2021-03-18', 2, 4, 46),
('2021-03-09', 5, 4, 13),
('2021-03-15', 5, 5, 98),
('2021-03-31', 3, 5, 59),
('2021-03-15', 5, 6, 93),
('2021-03-24', 2, 3, 44),
('2021-03-26', 2, 1, 83),
('2021-03-09', 3, 6, 74),
('2021-03-23', 5, 3, 67),
('2021-03-11', 3, 5, 16),
('2021-03-20', 1, 2, 53),
('2021-03-30', 5, 3, 13),
('2021-03-22', 4, 3, 88),
('2021-03-25', 4, 4, 35),
('2021-03-25', 1, 4, 18),
('2021-03-21', 6, 5, 19),
('2021-03-30', 1, 2, 33),
('2021-03-31', 1, 2, 12),
('2021-03-30', 6, 2, 78),
('2021-03-01', 1, 3, 13),
('2021-03-22', 6, 1, 71),
('2021-03-29', 6, 6, 16),
('2021-03-04', 1, 6, 28),
('2021-03-28', 5, 3, 81),
('2021-03-09', 1, 4, 88),
('2021-03-17', 2, 1, 65),
('2021-03-12', 3, 6, 92),
('2021-03-11', 5, 2, 81),
('2021-03-22', 4, 3, 68),
('2021-03-22', 1, 2, 98),
('2021-03-05', 2, 1, 84),
('2021-03-08', 1, 1, 33),
('2021-03-15', 4, 4, 86),
('2021-03-15', 4, 4, 52),
('2021-03-30', 4, 2, 54),
('2021-03-02', 6, 5, 35),
('2021-03-28', 1, 4, 39),
('2021-03-10', 5, 1, 27),
('2021-03-31', 4, 5, 40),
('2021-03-03', 2, 3, 43);
