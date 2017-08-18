-- WHILE Example

DECLARE @Amt int=1;

WHILE @Amt/@Amt =1
	BEGIN
	 PRINT @Amt;
	 SET @Amt=@Amt+1;
		If @Amt >10
			BREAK
		ELSE
			CONTINUE
	END

PRINT 'DONE! '

