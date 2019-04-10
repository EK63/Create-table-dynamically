if exists(select * from sys.tables where name like 'Colour')
drop table Colour
Create table Colour1(
	ColourId int identity(1,1) not null,
	ColourName varchar(50) not null,
	)
