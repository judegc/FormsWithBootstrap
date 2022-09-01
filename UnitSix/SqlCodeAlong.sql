--CREATE TABLE delete_me(
--	Id INT NOT NULL,
--	Name NVARCHAR(50)
--)

--DROP TABLE IF EXISTS delete_me

--CREATE TABLE SuperHeroes(
--	Id INT NOT NULL IDENTITY,
--	RealName NVARCHAR(50),
--	SuperHeroName NVARCHAR(50),
--	Power NVARCHAR(50),
--	Popularity TINYINT
--)

--add new data
--INSERT INTO SuperHeroes (RealName, SuperHeroName, Power, Popularity)
--VALUES ('Peter Parker', 'Spider-Man', 'Web-slinging', 83)

--selects ALL data from a given table
--select * from SuperHeroes

--INSERT INTO SuperHeroes (RealName, SuperHeroName, Power, Popularity)
--VALUES ('Bruce Banner', 'The Hulk', 'Strength', 61),
--('Tony Stark', 'Iron Man', 'Flying and general gadgetry', 98),
--('Bruce Wayne', 'Batman', 'Intimidating voice', 95),
--('Clark Kent', 'Superman', 'Alien stuff', 50)

--select certain columns by specifying them after the SELECT keyword
--SELECT RealName, SuperHeroName
--FROM SuperHeroes

--SELECT *
--FROM SuperHeroes
--WHERE SuperHeroName = 'Spider-Man'