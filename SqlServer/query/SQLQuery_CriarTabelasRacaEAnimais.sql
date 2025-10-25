USE HARAS_3D87
CREATE TABLE Raca
(
	Raca_Id int IDENTITY PRIMARY KEY,
	Registro int NOT NULL,
	Descricao varchar(30) NOT NULL, 
	Data datetime NULL,
	hora varchar(5) NULL
)
CREATE TABLE Animais
(
	Animais_Id int IDENTITY PRIMARY KEY,
	nrchip int NOT NULL,
	nome varchar (40) NOT NULL,
	dtNascimento datetime NULL,
	valor decimal(10, 2) NULL,
	vendido bit NULL,
	Raca_Id int NOT NULL
)
ALTER TABLE Animais ADD CONSTRAINT FK_animais_Raca
FOREIGN KEY (Raca_Id) REFERENCES Raca (Raca_Id)