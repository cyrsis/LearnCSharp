
-- GOTO Example

DECLARE @Counter int;
SET @Counter = 6;

IF @Counter < 3 GOTO Completed
IF @Counter = 3 GOTO Branch_One  --Jumps Branch_One
IF @Counter = 4 GOTO Branch_Two  --Jumps Branch_Two
IF @Counter = 5 GOTO Branch_Three  --Jumps Branch_Three
IF @Counter > 5 GOTO Completed

Branch_One:
    Print 'Hello from Branch One.'
    GOTO Completed; --This will prevent Branch_Two and Three from executing.
Branch_Two:
    PRINT 'Hello from Branch Two.'
	GOTO Completed; --This will prevent Branch_Three from executing.
Branch_Three:
    PRINT 'Hello from Branch Three.'

Completed:
PRINT 'Continue with code...'