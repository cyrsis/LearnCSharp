Imports System.Collections.ObjectModel
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Xml.Linq

Public Class EmployeeManager
#Region "GetEmployees Methods"
  Public Function GetEmployees() As ObservableCollection(Of Employee)
    Dim ret As ObservableCollection(Of Employee)
    Dim fileName As String

    Try
      fileName = WPFCommon.GetCurrentDirectory() & "\Xml\Employee.xml"

      If File.Exists(fileName) Then
        ret = GetEmployees(fileName)
      Else
        ret = GetEmployeeMocks()
      End If
    Catch ex As Exception
      Debug.WriteLine(ex.ToString())
      ' Still return some data
      ret = GetEmployeeMocks()
    End Try

    Return ret
  End Function

  Protected Function GetEmployees(ByVal fileName As String) As ObservableCollection(Of Employee)
    Dim ret As ObservableCollection(Of Employee)
    Dim elem As XElement = XElement.Load(fileName)

    Dim items = From emp In elem.Descendants("Employee")
               Select New Employee() With { _
    .EmployeeNumber = Convert.ToInt32(emp.Element("EmployeeNumber").Value), _
    .FirstName = emp.Element("FirstName").Value, _
    .LastName = emp.Element("LastName").Value, _
    .SSN = emp.Element("SSN").Value _
   }

    ret = New ObservableCollection(Of Employee)(items)

    Return ret
  End Function
#End Region

#Region "Insert Method"
  Public Function Insert(ByVal entity As Employee) As Integer
    Dim ret As Integer = 0

    ' TODO: Insert Data Here

    Return ret
  End Function
#End Region

#Region "Update Method"
  Public Function Update(ByVal entity As Employee) As Integer
    Dim ret As Integer = 0

    ' TODO: Update Data Here

    Return ret
  End Function
#End Region

#Region "Delete Method"
  Public Function Delete(ByVal entity As Employee) As Integer
    Dim ret As Integer = 0

    ' TODO: Delete Data Here

    Return ret
  End Function
#End Region

#Region "Mock Data"
  Protected Overridable Function GetEmployeeMocks() As ObservableCollection(Of Employee)
    Dim entity As Employee
    Dim ret As New ObservableCollection(Of Employee)()

    entity = New Employee()
    entity.EmployeeNumber = 1
    entity.FirstName = "(Mock) John"
    entity.LastName = "(Mock) Doe"
    entity.SSN = "(Mock) 111-11-1111"
    ret.Add(entity)

    entity = New Employee()
    entity.EmployeeNumber = 2
    entity.FirstName = "(Mock) Sally"
    entity.LastName = "(Mock) Smith"
    entity.SSN = "(Mock) 222-22-2222"
    ret.Add(entity)

    entity = New Employee()
    entity.EmployeeNumber = 3
    entity.FirstName = "(Mock) Bill"
    entity.LastName = "(Mock) Jones"
    entity.SSN = "(Mock) 333-33-3333"
    ret.Add(entity)

    Return ret
  End Function
#End Region
End Class
