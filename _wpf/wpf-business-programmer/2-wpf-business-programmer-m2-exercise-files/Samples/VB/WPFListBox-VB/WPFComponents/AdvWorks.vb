


Partial Class AdvWorksDataContext
   Public Function GetAllCustomers() As IOrderedQueryable(Of Customer)
      Dim items = From cust In Me.Customers _
                    Order By cust.LastName _
                   Select cust

      Return items
   End Function

   Public Function GetAllCustomersAsList() As IEnumerable(Of Customer)
      Dim items = From cust In Me.Customers _
                   Order By cust.LastName _
                   Select cust

      Return items.ToList()
   End Function
End Class



