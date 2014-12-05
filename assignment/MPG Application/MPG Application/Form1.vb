Public Class Form1

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BtonExit_Click(sender As Object, e As EventArgs) Handles BtonExit.Click
        Me.Close()
    End Sub

    Private Sub BtonClean_Click(sender As Object, e As EventArgs) Handles BtonClean.Click
        TboxEndingMiles.Text = String.Empty
        TboxGallonsUsed.Text = String.Empty
        TboxStartingMiles.Text = String.Empty
        LabelMilesTraveled.Text = String.Empty
        LabelMPG.Text = String.Empty
        TboxMilesTraveled.Text = String.Empty
    End Sub

    Private Sub BtonCalculate_Click(sender As Object, e As EventArgs) Handles BtonCalculate.Click
        If (Val(TboxEndingMiles.Text) > 0 And Val(TboxGallonsUsed.Text) > 0 And Val(TboxStartingMiles.Text) > 0) Then ' check the wrong data like not number or the number less then 1
            LabelMilesTraveled.Text = Val(TboxEndingMiles.Text) - Val(TboxStartingMiles.Text)
            LabelMPG.Text = Val(LabelMilesTraveled.Text) / Val(TboxGallonsUsed.Text)
        Else ' invalid data
            TboxEndingMiles.Text = String.Empty
            TboxGallonsUsed.Text = String.Empty
            TboxStartingMiles.Text = String.Empty
            LabelMilesTraveled.Text = String.Empty
            LabelMPG.Text = String.Empty
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TboxMilesTraveled.Visible = False
        BtonCalculateMileKnow.Visible = False
        BtonswitchToDontKnow.Visible = False
    End Sub

    Private Sub Btonswitch_Click(sender As Object, e As EventArgs) Handles BtonswitchToKnow.Click
        TboxStartingMiles.Visible = False
        TboxEndingMiles.Visible = False
        BtonCalculate.Visible = False
        LabelMilesTraveled.Visible = False
        BtonswitchToKnow.Visible = False
        TboxMilesTraveled.Visible = True
        BtonCalculateMileKnow.Visible = True
        BtonCalculateMileKnow.Text = "Cal&culate"
        BtonCalculate.Text = ""
        BtonswitchToDontKnow.Visible = True
    End Sub

    Private Sub BtonswitchToDontKnow_Click(sender As Object, e As EventArgs) Handles BtonswitchToDontKnow.Click
        TboxStartingMiles.Visible = True
        TboxEndingMiles.Visible = True
        BtonCalculate.Visible = True
        BtonCalculate.Text = "Cal&culate"
        BtonCalculateMileKnow.Text = ""
        LabelMilesTraveled.Visible = True
        BtonswitchToKnow.Visible = True
        TboxMilesTraveled.Visible = False
        BtonCalculateMileKnow.Visible = False
        BtonswitchToDontKnow.Visible = False
    End Sub

    Private Sub BtonCalculateMileKnow_Click(sender As Object, e As EventArgs) Handles BtonCalculateMileKnow.Click
        If (Val(TboxEndingMiles.Text) > 0 And Val(TboxGallonsUsed.Text) > 0 And Val(TboxStartingMiles.Text) > 0) Then ' check the wrong data like not number or the number less then 1

            LabelMPG.Text = Val(LabelMilesTraveled.Text) / Val(TboxGallonsUsed.Text)
        Else ' invalid data
            TboxStartingMiles.Text = String.Empty
            LabelMilesTraveled.Text = String.Empty
            LabelMPG.Text = String.Empty
        End If
    End Sub
End Class
