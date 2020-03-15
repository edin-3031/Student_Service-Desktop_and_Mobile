USE master
CREATE DATABASE [Studentski servis 2]
USE [Studentski servis 2]

CREATE TABLE Profesor(
ProfesorID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Ime NVARCHAR(MAX),
Prezime NVARCHAR(MAX),
Zvanje NVARCHAR(MAX),
DatumRodjenja DATETIME,
DatumZaposlenja DATETIME,
Adresa NVARCHAR(MAX),
Mail NVARCHAR(500) UNIQUE,
Spol bit,
Staz INT,
VrstaUgovora NVARCHAR(MAX),
Kancelarija NVARCHAR(MAX),
Slika VARBINARY(MAX) NULL,
KorisnickoIme NVARCHAR(MAX),
LozinkaHash NVARCHAR(MAX),
LozinkaSalt NVARCHAR(MAX)
);

CREATE TABLE Administracija(
AdministracijaID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Ime NVARCHAR(MAX),
Prezime NVARCHAR(MAX),
KorisnickoIme NVARCHAR(500) UNIQUE,
LozinkaHash NVARCHAR(MAX),
LozinkaSalt NVARCHAR(MAX),
DatumRodjenja DATETIME,
DatumZaposlenja DATETIME,
Adresa NVARCHAR(MAX),
Mail NVARCHAR(500) UNIQUE,
Spol bit,
Staz INT,
VrstaUgovora NVARCHAR(MAX),
Kancelarija NVARCHAR(MAX),
Slika VARBINARY(MAX) NULL
);

CREATE TABLE Student(
StudentID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Ime NVARCHAR(MAX),
Prezime NVARCHAR(MAX),
KorisnickoIme NVARCHAR(500) UNIQUE,
LozinkaHash NVARCHAR(MAX),
LozinkaSalt NVARCHAR(MAX),
DatumRodjenja DATETIME,
DatumUpisa DATETIME,
Mail NVARCHAR(500) UNIQUE,
Adresa NVARCHAR(MAX),
Telefon NVARCHAR(MAX),
Spol bit,
Indeks NVARCHAR(500) UNIQUE,
[Status] NVARCHAR(MAX),
NacinStudiranja NVARCHAR(MAX),
UpisanSemestar INT,
OvjerenSemestar INT NULL,
ObnavljaGodinu bit,
ProsjecnaOcjena FLOAT NULL,
Slika VARBINARY(MAX) NULL
);

CREATE TABLE Uloge(
UlogaID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Naziv NVARCHAR(MAX) NOT NULL,
Opis NVARCHAR(MAX) NULL
);

CREATE TABLE KorisniciUloge(
KorisnikUlogaID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ProfesorID INT FOREIGN KEY REFERENCES Profesor(ProfesorID) NULL,
StudentID INT FOREIGN KEY REFERENCES Student(StudentID) NULL,
AdministracijaID INT FOREIGN KEY REFERENCES Administracija(AdministracijaID) NULL,
DatumIzmjene DATETIME NULL,
UlogaID INT FOREIGN KEY REFERENCES Uloge(UlogaID) NULL
);

CREATE TABLE Obavijest(
ObavijestID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ProfesorID INT FOREIGN KEY REFERENCES Profesor(ProfesorID) NULL,
Sadrzaj NVARCHAR(MAX),
DatumObjave DATETIME,
Naslov NVARCHAR(MAX)
);

CREATE TABLE Uplata(
UplataID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
AdministracijaID INT FOREIGN KEY REFERENCES Administracija(AdministracijaID),
StudentID INT FOREIGN KEY REFERENCES Student(StudentID),
Iznos FLOAT,
Svrha NVARCHAR(MAX),
DatumUplate DATETIME,
Ovjereno bit,
Slika VARBINARY(MAX) NULL
);

CREATE TABLE Kurs(
KursID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Naziv NVARCHAR(MAX),
ECTS INT,
PosjedujeSeminarski bit,
PosjedujePraksu bit
);

CREATE TABLE Ispit(
IspitID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ProfesorID INT FOREIGN KEY REFERENCES Profesor(ProfesorID),
KursID INT FOREIGN KEY REFERENCES Kurs(KursID),
Datum DATETIME,
Trajanje INT,
BrojPitanja INT,
MaxBodova INT,
ParcijalnoBodovanje bit,
Ucionica NVARCHAR(MAX)
);

CREATE TABLE Raspored(
RasporedID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,           
StudentID INT FOREIGN KEY REFERENCES Student(StudentID),
Naslov NVARCHAR(MAX),
Opis NVARCHAR(MAX),
Datum DATETIME,
Vazno bit
);

CREATE TABLE predaje(
predajeID INT PRIMARY KEY IDENTITY(1,1),
ProfesorID INT FOREIGN KEY REFERENCES Profesor(ProfesorID),
KursID INT FOREIGN KEY REFERENCES Kurs(KursID),
DatumPredavanja DATETIME,
Odrzano bit NULL,
Vrsta NVARCHAR(MAX),
Opis NVARCHAR(MAX) NULL
);

CREATE TABLE pohadja(
pohadjaID INT PRIMARY KEY IDENTITY(1,1),
StudentID INT FOREIGN KEY REFERENCES Student(StudentID),
KursID INT FOREIGN KEY REFERENCES Kurs(KursID),
Obnavlja bit,
BrojObnavljanja INT NULL,
Aktivan bit,
Polozio bit NULL,
Ocjena INT NULL,
DatumPohadjanja Datetime NULL
);