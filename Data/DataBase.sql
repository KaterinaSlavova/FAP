USE [shkoloButBetter];

-- Create table
CREATE TABLE [people] 
(
	[id] INT IDENTITY PRIMARY KEY, 
	[name] VARCHAR(50), 
	[age] INT,
	[height] INT,
	[weight] INT,
	[gender] VARCHAR(50),
	[birthDate] Date
);

CREATE TABLE [infs] 
(
	[id] INT IDENTITY PRIMARY KEY, 
	[id_user] INT, 
	[workout] VARCHAR(50),
	[calories] INT, 
	[protein] INT,
	[fat] INT,
	[carbs] INT,
	CONSTRAINT [fk_people_id_infs] FOREIGN KEY([id_user]) REFERENCES [people]([Id])
);

