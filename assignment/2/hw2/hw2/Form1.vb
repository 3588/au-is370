Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "Bedroom"
        Button2.Text = "Bathroom"
        Button3.Text = "Kitchen"
        Button4.Text = "Outside"
        Button5.Text = "Hide"
        Button6.Text = "Exit"
        PictureBox1.Visible = True
        Me.Text = "Room Show"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = My.Resources.Resources.bedroom
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = My.Resources.Resources.Bathroom
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = My.Resources.Resources.kitchen
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image = My.Resources.Resources.outside
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (PictureBox1.Visible) Then
            PictureBox1.Visible = False
            Button5.Text = "View"
        Else
            PictureBox1.Visible = True
            Button5.Text = "Hide"
        End If

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class
