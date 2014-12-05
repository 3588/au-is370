' Name:         Covington Resort Project
' Purpose:      Display the total room charge, tax, 
'               total resort fee, and total due
' Programmer:   <junjun huang> on <10/23/2014>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtRooms_Enter(sender As Object,
                               e As EventArgs) Handles txtRooms.Enter
        txtRooms.SelectAll()
    End Sub
    Private Sub txtNights_Enter(sender As Object,
                               e As EventArgs) Handles txtNights.Enter
        txtNights.SelectAll()
    End Sub
    Private Sub txtAdults_Enter(sender As Object,
                               e As EventArgs) Handles txtAdults.Enter
        txtAdults.SelectAll()
    End Sub
    Private Sub txtChildren_Enter(sender As Object,
                               e As EventArgs) Handles txtChildren.Enter
        txtChildren.SelectAll()
    End Sub
    Private Sub CancelKeys(sender As Object,
                           e As KeyPressEventArgs) Handles txtRooms.KeyPress, txtAdults.KeyPress, txtChildren.KeyPress, txtNights.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtRooms.TextChanged, txtNights.TextChanged,
        txtAdults.TextChanged, txtChildren.TextChanged
        ' clear calculated amounts
        lblRoomChg.Text = String.Empty
        lblTax.Text = String.Empty
        lblResortFee.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const MaxPerRoom As Integer = 6
        Const DiltRoomChg As Integer = 284
        Const TaxRate As Double = 0.1525
        Const DailyResoryFee As Integer = 15
        Const Msg As String = "You have exceeded the maximum guests per room."
        Dim Rooms As Integer
        Dim Nights As Integer
        Dim Adults As Integer
        Dim Children As Integer
        Integer.TryParse(txtRooms.Text, Rooms)
        Integer.TryParse(txtNights.Text, Nights)
        Integer.TryParse(txtAdults.Text, Adults)
        Integer.TryParse(txtChildren.Text, Children)

        Dim NumGuests As Integer = Adults + Children
        Dim RoomsRequired As Double = NumGuests / MaxPerRoom

        If Rooms < RoomsRequired Then
            MessageBox.Show(Msg, "Covington Resort", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim TotalRoomChg As Integer = Rooms * Nights * DiltRoomChg
            Dim Tax As Double = TotalRoomChg * TaxRate
            Dim TotalResortFee As Integer = Rooms * Nights * DailyResoryFee
            Dim TotalDue As Double = TotalRoomChg + Tax + TotalResortFee

            lblRoomChg.Text = TotalRoomChg.ToString("N2")
            lblTax.Text = Tax.ToString("N2")
            lblResortFee.Text = TotalResortFee.ToString("N2")
            lblTotalDue.Text = TotalDue.ToString("N2")
        End If

    End Sub
End Class
