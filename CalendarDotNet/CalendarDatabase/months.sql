/*
The database must have a MEMORY_OPTIMIZED_DATA filegroup
before the memory optimized object can be created.

The bucket count should be set to about two times the 
maximum expected number of distinct values in the 
index key, rounded up to the nearest power of two.
*/

CREATE TABLE [dbo].[Table2]
(
	[monthId] INT NOT NULL PRIMARY KEY NONCLUSTERED HASH WITH (BUCKET_COUNT = 131072), 
    [year] INT NULL, 
    [calendarDate] VARCHAR(50) NULL, 
    [monthName] CHAR(10) NULL
) WITH (MEMORY_OPTIMIZED = ON)