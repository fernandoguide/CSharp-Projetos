CREATE DATABASE sidOdonto
GO

USE sidOdonto
GO

CREATE TABLE FichaMed(
idFichaMed INT PRIMARY KEY,
observacoesDentes VARCHAR(500)
)
GO

CREATE TABLE Convenio(
idConvenio INT PRIMARY KEY,
nomeConvenio VARCHAR(50),
enderecoConvenio VARCHAR(100)
)
GO

CREATE TABLE Contato(
idContato INT PRIMARY KEY,
idConvenio INT FOREIGN KEY REFERENCES Convenio(idConvenio),
telResidencia INT,
celular INT,
email VARCHAR(100)
)
GO

CREATE TABLE Funcionario(
idFunc INT PRIMARY KEY,
idContato INT FOREIGN KEY REFERENCES Contato(idContato),
nomeFunc VARCHAR(50),
enderecoFunc VARCHAR(100),
cpfFunc INT,
rgFunc VARCHAR(9)
)
GO

CREATE TABLE Paciente(
idPaciente INT PRIMARY KEY,
idConvenio INT FOREIGN KEY REFERENCES Convenio(idConvenio),
idFichaMed INT FOREIGN KEY REFERENCES FichaMed(idFichaMed),
idContato INT FOREIGN KEY REFERENCES Contato(idContato),
nomePaciente VARCHAR(50),
cpfPaciente INT,
enderecoPaciente VARCHAR(100)
)
GO
select * from Paciente
select * from FichaMed
select * from Funcionario