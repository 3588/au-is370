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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelMPG = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtonCalculate = New System.Windows.Forms.Button()
        Me.BtonClean = New System.Windows.Forms.Button()
        Me.BtonExit = New System.Windows.Forms.Button()
        Me.TboxStartingMiles = New System.Windows.Forms.TextBox()
        Me.TboxEndingMiles = New System.Windows.Forms.TextBox()
        Me.TboxGallonsUsed = New System.Windows.Forms.TextBox()
        Me.LabelMilesTraveled = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtonswitchToKnow = New System.Windows.Forms.Button()
        Me.BtonCalculateMileKnow = New System.Windows.Forms.Button()
        Me.TboxMilesTraveled = New System.Windows.Forms.TextBox()
        Me.BtonswitchToDontKnow = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TboxGallonsUsed)
        Me.GroupBox1.Controls.Add(Me.TboxEndingMiles)
        Me.GroupBox1.Controls.Add(Me.TboxStartingMiles)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 174)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LabelMPG
        '
        Me.LabelMPG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMPG.Location = New System.Drawing.Point(26, 112)
        Me.LabelMPG.Name = "LabelMPG"
        Me.LabelMPG.Size = New System.Drawing.Size(61, 22)
        Me.LabelMPG.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MPG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gallons Used"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ending Miles"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Starting Miles"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TboxMilesTraveled)
        Me.GroupBox2.Controls.Add(Me.LabelMPG)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LabelMilesTraveled)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(207, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(109, 174)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Miles Traveled"
        '
        'BtonCalculate
        '
        Me.BtonCalculate.Location = New System.Drawing.Point(37, 241)
        Me.BtonCalculate.Name = "BtonCalculate"
        Me.BtonCalculate.Size = New System.Drawing.Size(75, 23)
        Me.BtonCalculate.TabIndex = 2
        Me.BtonCalculate.Text = "&Calculate"
        Me.BtonCalculate.UseVisualStyleBackColor = True
        '
        'BtonClean
        '
        Me.BtonClean.Location = New System.Drawing.Point(137, 241)
        Me.BtonClean.Name = "BtonClean"
        Me.BtonClean.Size = New System.Drawing.Size(75, 23)
        Me.BtonClean.TabIndex = 3
        Me.BtonClean.Text = "C&lean"
        Me.BtonClean.UseVisualStyleBackColor = True
        '
        'BtonExit
        '
        Me.BtonExit.Location = New System.Drawing.Point(233, 241)
        Me.BtonExit.Name = "BtonExit"
        Me.BtonExit.Size = New System.Drawing.Size(75, 23)
        Me.BtonExit.TabIndex = 4
        Me.BtonExit.Text = "&Exit"
        Me.BtonExit.UseVisualStyleBackColor = True
        '
        'TboxStartingMiles
        '
        Me.TboxStartingMiles.Location = New System.Drawing.Point(27, 33)
        Me.TboxStartingMiles.Name = "TboxStartingMiles"
        Me.TboxStartingMiles.Size = New System.Drawing.Size(100, 20)
        Me.TboxStartingMiles.TabIndex = 3
        '
        'TboxEndingMiles
        '
        Me.TboxEndingMiles.Location = New System.Drawing.Point(25, 79)
        Me.TboxEndingMiles.Name = "TboxEndingMiles"
        Me.TboxEndingMiles.Size = New System.Drawing.Size(100, 20)
        Me.TboxEndingMiles.TabIndex = 4
        '
        'TboxGallonsUsed
        '
        Me.TboxGallonsUsed.Location = New System.Drawing.Point(25, 133)
        Me.TboxGallonsUsed.Name = "TboxGallonsUsed"
        Me.TboxGallonsUsed.Size = New System.Drawing.Size(100, 20)
        Me.TboxGallonsUsed.TabIndex = 5
        '
        'LabelMilesTraveled
        '
        Me.LabelMilesTraveled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMilesTraveled.Location = New System.Drawing.Point(26, 62)
        Me.LabelMilesTraveled.Name = "LabelMilesTraveled"
        Me.LabelMilesTraveled.Size = New System.Drawing.Size(61, 22)
        Me.LabelMilesTraveled.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(134, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Junjun@IS371"
        '
        'BtonswitchToKnow
        '
        Me.BtonswitchToKnow.Location = New System.Drawing.Point(100, 212)
        Me.BtonswitchToKnow.Name = "BtonswitchToKnow"
        Me.BtonswitchToKnow.Size = New System.Drawing.Size(155, 23)
        Me.BtonswitchToKnow.TabIndex = 6
        Me.BtonswitchToKnow.Text = "I &know Miles Traveled"
        Me.BtonswitchToKnow.UseVisualStyleBackColor = True
        '
        'BtonCalculateMileKnow
        '
        Me.BtonCalculateMileKnow.Location = New System.Drawing.Point(37, 242)
        Me.BtonCalculateMileKnow.Name = "BtonCalculateMileKnow"
        Me.BtonCalculateMileKnow.Size = New System.Drawing.Size(75, 23)
        Me.BtonCalculateMileKnow.TabIndex = 7
        Me.BtonCalculateMileKnow.Text = "&Calculate"
        Me.BtonCalculateMileKnow.UseVisualStyleBackColor = True
        '
        'TboxMilesTraveled
        '
        Me.TboxMilesTraveled.Location = New System.Drawing.Point(6, 62)
        Me.TboxMilesTraveled.Name = "TboxMilesTraveled"
        Me.TboxMilesTraveled.Size = New System.Drawing.Size(100, 20)
        Me.TboxMilesTraveled.TabIndex = 6
        '
        'BtonswitchToDontKnow
        '
        Me.BtonswitchToDontKnow.Location = New System.Drawing.Point(100, 212)
        Me.BtonswitchToDontKnow.Name = "BtonswitchToDontKnow"
        Me.BtonswitchToDontKnow.Size = New System.Drawing.Size(155, 23)
        Me.BtonswitchToDontKnow.TabIndex = 8
        Me.BtonswitchToDontKnow.Text = "I do&n't  know Miles Traveled"
        Me.BtonswitchToDontKnow.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 314)
        Me.Controls.Add(Me.BtonswitchToDontKnow)
        Me.Controls.Add(Me.BtonCalculateMileKnow)
        Me.Controls.Add(Me.BtonswitchToKnow)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtonExit)
        Me.Controls.Add(Me.BtonClean)
        Me.Controls.Add(Me.BtonCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "MPG Application"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelMPG As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtonCalculate As System.Windows.Forms.Button
    Friend WithEvents BtonClean As System.Windows.Forms.Button
    Friend WithEvents BtonExit As System.Windows.Forms.Button
    Friend WithEvents TboxGallonsUsed As System.Windows.Forms.TextBox
    Friend WithEvents TboxEndingMiles As System.Windows.Forms.TextBox
    Friend WithEvents TboxStartingMiles As System.Windows.Forms.TextBox
    Friend WithEvents LabelMilesTraveled As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtonswitchToKnow As System.Windows.Forms.Button
    Friend WithEvents BtonCalculateMileKnow As System.Windows.Forms.Button
    Friend WithEvents TboxMilesTraveled As System.Windows.Forms.TextBox
    Friend WithEvents BtonswitchToDontKnow As System.Windows.Forms.Button

End Class
