' Name:         Kettleson Project
' Purpose:      Display a bonus amount
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub



    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates and displays a bonus 

        If IsNumeric(txtSales.Text()) = False Then
            MsgBox("Accept numbers only")
            txtSales.Focus()
        Else

            Dim dblSales As Double
            Dim dblBonus As Double

            Double.TryParse(txtSales.Text, dblSales)
            Select Case dblSales


                Case 15000.01 To 25000
                    dblBonus = dblSales * 0.02
                Case 25000.01 To 50000
                    dblBonus = dblSales * 0.03
                Case Is > 50000
                    dblBonus = dblSales * 0.04
                Case Is < 15000
                    dblBonus = dblSales * 0.015
            End Select

            lblBonus.Text = dblBonus.ToString("C2")

        End If

    End Sub
End Class
