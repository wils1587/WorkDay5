Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim name As String
        name = txtFullName.Text
        txtFirstName.Text = FirstName(name)
    End Sub

    Function FirstName(ByVal name As String) As String
        Dim first As String
        Dim x As Integer
        first = name.Trim
        x = first.IndexOf(" ")
        first = first.Substring(0, x)

        Return first
    End Function

End Class
