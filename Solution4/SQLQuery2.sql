

SELECT * FROM Players

INSERT INTO Players (first_name, last_name) values ('john', 'smith')

INSERT INTO Players (id, first_name, last_name) values (18 , 'john', 'smith')

CREATE TABLE Persons (
Id INT PRIMARY KEY IDENTITY(1,1),
FirstName NVARCHAR(50) NOT NULL,
LastName NVARCHAR(50) NOT NULL
);

INSERT INTO Persons (FirstName, LastName) values ('john', 'smith')

INSERT INTO Persons values ('john', 'smith') -- but the values sequence has to be exactly as in first query

SELECT * FROM Persons

UPDATE Persons set FirstName = 'x'

DELETE Players WHERE id IS NULL