<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tboxOwed = New System.Windows.Forms.TextBox()
        Me.tboxPaid = New System.Windows.Forms.TextBox()
        Me.labDue = New System.Windows.Forms.Label()
        Me.labDollar = New System.Windows.Forms.Label()
        Me.labQuarter = New System.Windows.Forms.Label()
        Me.labDime = New System.Windows.Forms.Label()
        Me.labNickel = New System.Windows.Forms.Label()
        Me.labPennie = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bton
        '
        Me.bton.Location = New System.Drawing.Point(269, 31)
        Me.bton.Name = "bton"
        Me.bton.Size = New System.Drawing.Size(138, 23)
        Me.bton.TabIndex = 0
        Me.bton.Text = "&Calculate Change"
        Me.bton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(269, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Clea&r Screen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(269, 126)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "E&xit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Amount &owed"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Amount &paid"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Change due:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dollars:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(110, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 12)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Quarters:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(188, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Dimes:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(257, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Nickels:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(336, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Pennies:"
        '
        'tboxOwed
        '
        Me.tboxOwed.Location = New System.Drawing.Point(114, 33)
        Me.tboxOwed.Name = "tboxOwed"
        Me.tboxOwed.Size = New System.Drawing.Size(100, 21)
        Me.tboxOwed.TabIndex = 11
        '
        'tboxPaid
        '
        Me.tboxPaid.Location = New System.Drawing.Point(114, 80)
        Me.tboxPaid.Name = "tboxPaid"
        Me.tboxPaid.Size = New System.Drawing.Size(100, 21)
        Me.tboxPaid.TabIndex = 12
        '
        'labDue
        '
        Me.labDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labDue.Location = New System.Drawing.Point(115, 126)
        Me.labDue.Name = "labDue"
        Me.labDue.Size = New System.Drawing.Size(100, 23)
        Me.labDue.TabIndex = 13
        '
        'labDollar
        '
        Me.labDollar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labDollar.Location = New System.Drawing.Point(43, 220)
        Me.labDollar.Name = "labDollar"
        Me.labDollar.Size = New System.Drawing.Size(51, 23)
        Me.labDollar.TabIndex = 14
        '
        'labQuarter
        '
        Me.labQuarter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labQuarter.Location = New System.Drawing.Point(112, 220)
        Me.labQuarter.Name = "labQuarter"
        Me.labQuarter.Size = New System.Drawing.Size(51, 23)
        Me.labQuarter.TabIndex = 15
        '
        'labDime
        '
        Me.labDime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labDime.Location = New System.Drawing.Point(178, 220)
        Me.labDime.Name = "labDime"
        Me.labDime.Size = New System.Drawing.Size(51, 23)
        Me.labDime.TabIndex = 16
        '
        'labNickel
        '
        Me.labNickel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labNickel.Location = New System.Drawing.Point(259, 220)
        Me.labNickel.Name = "labNickel"
        Me.labNickel.Size = New System.Drawing.Size(51, 23)
        Me.labNickel.TabIndex = 17
        '
        'labPennie
        '
        Me.labPennie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labPennie.Location = New System.Drawing.Point(338, 220)
        Me.labPennie.Name = "labPennie"
        Me.labPennie.Size = New System.Drawing.Size(51, 23)
        Me.labPennie.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 279)
        Me.Controls.Add(Me.labPennie)
        Me.Controls.Add(Me.labNickel)
        Me.Controls.Add(Me.labDime)
        Me.Controls.Add(Me.labQuarter)
        Me.Controls.Add(Me.labDollar)
        Me.Controls.Add(Me.labDue)
        Me.Controls.Add(Me.tboxPaid)
        Me.Controls.Add(Me.tboxOwed)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bton)
        Me.Name = "Form1"
        Me.Text = "Change Solution"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bton As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tboxOwed As System.Windows.Forms.TextBox
    Friend WithEvents tboxPaid As System.Windows.Forms.TextBox
    Friend WithEvents labDue As System.Windows.Forms.Label
    Friend WithEvents labDollar As System.Windows.Forms.Label
    Friend WithEvents labQuarter As System.Windows.Forms.Label
    Friend WithEvents labDime As System.Windows.Forms.Label
    Friend WithEvents labNickel As System.Windows.Forms.Label
    Friend WithEvents labPennie As System.Windows.Forms.Label

End Class
