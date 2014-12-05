' junjun huang is370
Option Explicit On
Option Infer Off
Option Strict On
Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tboxOwed.Text = String.Empty
        tboxPaid.Text = String.Empty
        labDue.Text = String.Empty
        labDollar.Text = String.Empty
        labQuarter.Text = String.Empty
        labDime.Text = String.Empty
        labNickel.Text = String.Empty
        labPennie.Text = String.Empty
    End Sub

    Private Sub bton_Click(sender As Object, e As EventArgs) Handles bton.Click
        Dim due As Double
        Dim Dollar As Double
        Dim Quarter As Double
        Dim Dime As Double
        Dim Nickel As Double
        Dim Pennie As Double
        due = Val(tboxPaid.Text) - Val(tboxOwed.Text)
        'due = Val(tboxOwed.Text) - Val(tboxPaid.Text)
        labDue.Text = due.ToString("C2")
        Dollar = due - (due Mod 1)
        due -= Dollar

        Quarter = (due - due Mod 0.25) / 0.25
        due -= Quarter * 0.25
        Dime = (due - due Mod 0.1) / 0.1
        due -= Dime * 0.1
        Nickel = (due - due Mod 0.05) / 0.05
        due -= Nickel * 0.05
        Pennie = (due - due Mod 0.01) / 0.01


        If (Dollar < 0) Then
            Quarter = 0
        End If
        If (Quarter < 0) Then
            Quarter = 0
        End If
        If (Dime < 0) Then
            Dime = 0
        End If
        If (Nickel < 0) Then
            Nickel = 0
        End If
        If (Pennie < 0) Then
            Pennie = 0
        End If



        labDollar.Text = Dollar.ToString()
        labQuarter.Text = Quarter.ToString()
        labDime.Text = Dime.ToString()
        labNickel.Text = Nickel.ToString()
        labPennie.Text = Pennie.ToString()
    End Sub
End Class
