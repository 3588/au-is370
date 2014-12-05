' Name:         Turner Project
' Purpose:      Displays the new hourly pay for each of 3 job codes
' Programmer:   <your name> on <current date>

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
  
    Dim dblRaiseRate1 As Double
    Dim dblRaiseRate2 As Double
    Dim dblRaiseRate3 As Double

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' get the raise percentages
        Dim strRaise1 As String
        Dim strRaise2 As String
        Dim strRaise3 As String
        strRaise1 = InputBox("Job code 1 raise percentage in decimal form:", "Raise Rate 1")
        strRaise2 = InputBox("Job code 2 raise percentage in decimal form:", "Raise Rate 2")
        strRaise3 = InputBox("Job code 3 raise percentage in decimal form:", "Raise Rate 3")
        Double.TryParse(strRaise1, dblRaiseRate1)
        dblRaiseRate1 = dblRaiseRate1 / 100
        Double.TryParse(strRaise2, dblRaiseRate2)
        dblRaiseRate2 = dblRaiseRate2 / 100
        Double.TryParse(strRaise3, dblRaiseRate3)
        dblRaiseRate3 = dblRaiseRate3 / 100
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate the new hourly pay for each of 3 job codes
        Dim dblCurrent1 As Double
        Dim dblCurrent2 As Double
        Dim dblCurrent3 As Double
        Dim dblNew1 As Double
        Dim dblNew2 As Double
        Dim dblNew3 As Double

        Double.TryParse(txtCurrent1.Text, dblCurrent1)
        Double.TryParse(txtCurrent2.Text, dblCurrent2)
        Double.TryParse(txtCurrent3.Text, dblCurrent3)

        dblNew1 = dblCurrent1 * dblRaiseRate1 + dblCurrent1
        dblNew2 = dblCurrent2 * dblRaiseRate2 + dblCurrent2
        dblNew3 = dblCurrent3 * dblRaiseRate3 + dblCurrent3

        lblNew1.Text = dblNew1.ToString("N2")
        lblNew2.Text = dblNew2.ToString("N2")
        lblNew3.Text = dblNew3.ToString("N2")
        lblMessage.Text = "Job Code 1:    " & dblRaiseRate1.ToString("P0") &
            ControlChars.NewLine & "Job Code 2:    " & dblRaiseRate2.ToString("P0") &
            ControlChars.NewLine & "Job Code 3:    " & dblRaiseRate3.ToString("P0")
        btnCalc.Focus()
    End Sub

End Class
