Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        If IsNumeric(txtSideOne.Text) = False Or IsNumeric(txtSideTwo.Text) = False Then
            MessageBox.Show("Pleas enter numbers only", "Error", MessageBoxButtons.OK)
        Else

            Dim a As Double = CDbl(txtSideOne.Text)
            Dim b As Double = CDbl(txtSideTwo.Text)


            txtHyp.Text = CStr(Pythagorean(a, b))
        End If
    End Sub

    Function Pythagorean(ByVal a As Double, ByVal b As Double) As Double
        Dim c As Double
        c = (a ^ 2 + b ^ 2) ^ 0.5


        Return c
    End Function
End Class
