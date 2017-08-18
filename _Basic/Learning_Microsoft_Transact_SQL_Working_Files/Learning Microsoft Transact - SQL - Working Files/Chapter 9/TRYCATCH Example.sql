
-- Unstructured error handling
-- Running this command generates an error that
-- would appear in a client application
SELECT 1/0


-- Structured error handling using TRY/CATCH
-- The error is caught in the CATCH block
-- The program continues with an error appearing
BEGIN TRY
	SELECT 1/0
END TRY
BEGIN CATCH
  IF ERROR_NUMBER()=8134 
	PRINT 'Divide by zero error...logging this error.'
  ELSE
	PRINT 'Unknown error...logging the event.'
END CATCH

PRINT 'Continuing the program'

