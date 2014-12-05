Public Class Form1
    Private total As Double
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim add As Double
        Double.TryParse(tboxPrice.Text, add)
        Dim listNu As Integer
        Dim addST As String
        Do While add <> 0.0
            listNu = listNu + 1
            total = total + add
            TextBox1.Text = TextBox1.Text &
                listNu.ToString & " : " &
                add.ToString("C2") & ControlChars.NewLine
            addST = InputBox("Enter item's price (0 to end):", "")
            Double.TryParse(addST.ToString, add)
        Loop

        lbaDue.Text = (total * 1.03).ToString("C2")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        tboxPrice.Text = String.Empty
        lbaDue.Text = String.Empty
        TextBox1.Text = String.Empty
        Add.Focus()
        total = 0
  
    End Sub

End Class
