Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq

Public Class MyCustomers
  Inherits List(Of MyCustomer)

  Public Function GetCustomerList() As IEnumerable(Of MyCustomer)
    Dim dc As New AdvWorksDataContext()

    Dim items = From cust In dc.Customers _
                       Order By cust.LastName _
                       Select New MyCustomer()

    Return items
  End Function
End Class