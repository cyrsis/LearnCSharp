Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_StartupNextInstance(sender As Object, e As ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            DocForm.CreateForm()
        End Sub

    End Class


End Namespace

