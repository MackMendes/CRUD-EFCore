CREATE TABLE Customers(
	CustomerId UNIQUEIDENTIFIER NOT NULL, 
    FirstName varchar(255) NOT NULL,
	LastName varchar(255) NOT NULL,
    Age int
	PRIMARY KEY (CustomerId)
);

CREATE TABLE Contacts(
	ContactId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ContactType varchar(20) NOT NULL,
	Content varchar(255) NOT NULL,
	CustomerId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Customers(CustomerId) ON DELETE CASCADE
);