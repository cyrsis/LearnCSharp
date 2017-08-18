Public Class PersonControl
    Private _person As Person

    Public Property Person() As Person
        Get
            _person.FirstName = FirstTextBox.Text
            _person.LastName = LastNameTextBox.Text
            _person.Age = CInt(AgeTextBox.Text)
            Return _person
        End Get
        Set(ByVal value As Person)
            FirstTextBox.Text = value.FirstName
            LastNameTextBox.Text = value.LastName
            AgeTextBox.Text = value.Age
            _person = value
        End Set
    End Property

End Class
