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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTestScore1 = New System.Windows.Forms.TextBox()
        Me.txtTestScore5 = New System.Windows.Forms.TextBox()
        Me.txtTestScore4 = New System.Windows.Forms.TextBox()
        Me.txtTestScore2 = New System.Windows.Forms.TextBox()
        Me.txtTestScore3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAverageScore = New System.Windows.Forms.Label()
        Me.btnClaculateAverage = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Test Score 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Test Score 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Test Score 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Test Score 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Test Score 5"
        '
        'txtTestScore1
        '
        Me.txtTestScore1.Location = New System.Drawing.Point(130, 26)
        Me.txtTestScore1.Name = "txtTestScore1"
        Me.txtTestScore1.Size = New System.Drawing.Size(100, 20)
        Me.txtTestScore1.TabIndex = 5
        '
        'txtTestScore5
        '
        Me.txtTestScore5.Location = New System.Drawing.Point(130, 181)
        Me.txtTestScore5.Name = "txtTestScore5"
        Me.txtTestScore5.Size = New System.Drawing.Size(100, 20)
        Me.txtTestScore5.TabIndex = 6
        '
        'txtTestScore4
        '
        Me.txtTestScore4.Location = New System.Drawing.Point(131, 137)
        Me.txtTestScore4.Name = "txtTestScore4"
        Me.txtTestScore4.Size = New System.Drawing.Size(100, 20)
        Me.txtTestScore4.TabIndex = 8
        '
        'txtTestScore2
        '
        Me.txtTestScore2.Location = New System.Drawing.Point(130, 64)
        Me.txtTestScore2.Name = "txtTestScore2"
        Me.txtTestScore2.Size = New System.Drawing.Size(100, 20)
        Me.txtTestScore2.TabIndex = 7
        '
        'txtTestScore3
        '
        Me.txtTestScore3.Location = New System.Drawing.Point(130, 103)
        Me.txtTestScore3.Name = "txtTestScore3"
        Me.txtTestScore3.Size = New System.Drawing.Size(100, 20)
        Me.txtTestScore3.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Average"
        '
        'lblAverageScore
        '
        Me.lblAverageScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageScore.Location = New System.Drawing.Point(130, 215)
        Me.lblAverageScore.Name = "lblAverageScore"
        Me.lblAverageScore.Size = New System.Drawing.Size(100, 23)
        Me.lblAverageScore.TabIndex = 10
        '
        'btnClaculateAverage
        '
        Me.btnClaculateAverage.Location = New System.Drawing.Point(12, 271)
        Me.btnClaculateAverage.Name = "btnClaculateAverage"
        Me.btnClaculateAverage.Size = New System.Drawing.Size(75, 43)
        Me.btnClaculateAverage.TabIndex = 11
        Me.btnClaculateAverage.Text = "Calculate Average"
        Me.btnClaculateAverage.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(104, 271)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 43)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 271)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 43)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 315)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClaculateAverage)
        Me.Controls.Add(Me.lblAverageScore)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTestScore3)
        Me.Controls.Add(Me.txtTestScore4)
        Me.Controls.Add(Me.txtTestScore2)
        Me.Controls.Add(Me.txtTestScore5)
        Me.Controls.Add(Me.txtTestScore1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTestScore1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore5 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore4 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblAverageScore As System.Windows.Forms.Label
    Friend WithEvents btnClaculateAverage As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
