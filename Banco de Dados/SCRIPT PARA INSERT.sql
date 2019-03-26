select *from Consulta

select *from Paciente

select *from Medico

select * from Convenio

select * from Contato

select * from Usuario

select * from Especialidades

-- INSERT DAS TABELAS

insert into Usuario(nomeUsuario,senhaUsuario,nivelAcesso)values('Rodrigo','rodrigo','Administrador');

insert into Contato values('3333','3333','334');

insert into Convenio (idContato,nomeConvenio,enderecoConvenio) values(1,'11111','22222');

INSERT INTO Especialidades VALUES('Rodrigo');

INSERT INTO Medico(idEspecialidade,idContato,idUsuario,nomeMedico,numCROMedico,enderecoMedico) 
VALUES(1,1,1,'Rodrigo',45787,'rua das lagrimas');

INSERT INTO Paciente(idConvenio,idContato,nomePaciente,cpfPaciente,enderecoPaciente) 
VALUES(2,1,'Rodrigo','45787912354','rua das lagrimas');

INSERT INTO Consulta(idPaciente,idMedico,dataConsulta,horarioConsulta,observacoesProcedimento) 
VALUES(2,1,'23-05-2010','1300','abc');


