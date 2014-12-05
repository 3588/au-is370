' Name:         Sunnyside Project
' Purpose:      Displays the total price of an order
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtUnits_Enter(sender As Object, e As EventArgs) Handles txtUnits.Enter
        txtUnits.SelectAll()
    End Sub

    Private Sub txtUnits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnits.KeyPress
        ' accept only numbers and the Backspace key
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs
                           ) Handles txtUnits.TextChanged, radRetailer.Click, radWholesaler.Click
        lblOrder.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates the total price of an order

        Dim intUnits As Integer
        Dim intUnitPrice As Integer
        Dim intTotalPrice As Integer
        Integer.TryParse(txtUnits.Text, intUnits)

        If radWholesaler.Checked = True Then
            If intUnits > 10 Then
                intUnitPrice = 15
            End If
            If intUnits < 11 And intUnits > 0 Then
                intUnitPrice = 20
            End If
        End If
        If radRetailer.Checked = True Then
            If intUnits > 15 Then
                intUnitPrice = 25
            End If
            If intUnits < 16 And intUnits > 5 Then
                intUnitPrice = 28
            End If
            If intUnits < 6 And intUnits > 0 Then
                intUnitPrice = 30
            End If
        End If




        intTotalPrice = intUnits * intUnitPrice
        Label3.Text = intTotalPrice.ToString
        txtUnits.Focus()
    End Sub
End Class
