' Program Name: Ice Skating Ring
' Date: September 23, 2024
' Author: K Bola
' Purpose: This program allows users to compute how much cubic feet of ice that the ice ring can hold
Public Class frmSkating
    Dim strLength As String
    Dim strWidth As String
    Dim strDepth As String
    Dim dblLength As Double
    Dim dblWidth As Double
    Dim dblDepth As Double
    Dim decVolume As Decimal
    Private Sub btnVolume_Click(sender As Object, e As EventArgs) Handles btnVolume.Click
        strLength = txtLength.Text
        dblLength = Convert.ToDouble(strLength)
        strWidth = txtWidth.Text
        dblWidth = Convert.ToDouble(strWidth)
        strDepth = txtDepth.Text
        dblDepth = Convert.ToDouble(strDepth)
        decVolume = dblLength * dblWidth * dblDepth
        lblVolumeDetermined.Text = decVolume.ToString("N")
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLength.Clear()
        txtWidth.Clear()
        txtDepth.Clear()
        lblVolumeDetermined.Text = ""
        txtLength.Focus()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
