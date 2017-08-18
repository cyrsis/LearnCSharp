-- Using EXECUTE

-- Using a variable in the WHERE clause
-- is not a problem
DECLARE @Dept varchar(20);
SET @Dept='Sales';

SELECT * FROM NewData
WHERE Department=@Dept;

-- Using a variable for the table name
-- causes and error
DECLARE @tbl varchar(20);
SET @tbl='NewData'


GO;


-- You can use the EXECUTE command
DECLARE @tbl varchar(20);
DECLARE @dept varchar(20);
DECLARE @cmd varchar(200);
SET @tbl='NewData';
SET @dept='Sales';

SET @cmd='SELECT * FROM ' + @tbl + ' Where Department=' + '''' + @dept +  ''''
PRINT @cmd;

EXECUTE(@cmd);