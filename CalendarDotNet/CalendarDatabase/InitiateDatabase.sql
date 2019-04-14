CREATE PROCEDURE [dbo].[InitiateDatabase]
AS
	insert into dbo.TestTable(TestParameter)
	values(30)
go;
