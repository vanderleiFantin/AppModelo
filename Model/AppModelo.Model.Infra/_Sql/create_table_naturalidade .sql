CREATE TABLE nacionalidades (
	id int NOT NULL AUTO_INCREMENT,
	descricao VARCHAR(250) NOT NULL,
	CONSTRAINT pk_nacionalidades_id PRIMARY KEY (id)
);
CREATE TABLE naturalidade (
Id int NOT NULL AUTO_INCREMENT,
descricao varchar (100) NOT NULL,
dataCriacao DATETIME NOT NULL,
dataAlteracao DATETIME NOT NULL,
ativo BOOLEAN NOT NULL,
Constraint pk_naturalidade_id PRIMARY KEY (id)
);
