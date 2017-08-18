General rules about explicit transactions
Keep transactions as short as possible to reduce locking contention
Avoid grouping many operations within transactions
Collect all user input before beginning the transaction
Work with as few rows as possible during a transaction

Separate data read actions from data modifications and only include the modifications in a transaction
