
select count(*)
from [master].[dbo].[sysprocesses]
where program_name = 'psod-disposable'

select *
from bookfeed

select *
from bookline

/*
truncate table bookline
delete bookfeed
*/