Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim add As Double
        Dim addSt As String
        Dim total As Double
        Label2.Text = String.Empty
        addSt = InputBox("Enter item's price (0 to end):", "")
        Double.TryParse(addSt.ToString, add)
        Do While add <> 0.0
            total = total + add
            addSt = InputBox("Enter item's price (0 to end):", "")
            Double.TryParse(addSt.ToString, add)
        Loop
        Label2.Text = (total * 1.05).ToString("C2")
    End Sub
End Class
