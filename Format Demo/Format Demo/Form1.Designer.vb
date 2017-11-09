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
        Me.lblFormatted = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFullDateTime = New System.Windows.Forms.Button()
        Me.btnLongTime = New System.Windows.Forms.Button()
        Me.btnShortTime = New System.Windows.Forms.Button()
        Me.btnLongDate = New System.Windows.Forms.Button()
        Me.btnShortDate = New System.Windows.Forms.Button()
        Me.btnPercentFormat = New System.Windows.Forms.Button()
        Me.btnCurrencyFormat = New System.Windows.Forms.Button()
        Me.btnExponentialFormat = New System.Windows.Forms.Button()
        Me.btnFixedPointFormat = New System.Windows.Forms.Button()
        Me.btnNumberFormat = New System.Windows.Forms.Button()
        Me.txtUserEntery = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number or date:"
        '
        'lblFormatted
        '
        Me.lblFormatted.AutoSize = True
        Me.lblFormatted.Location = New System.Drawing.Point(51, 133)
        Me.lblFormatted.Name = "lblFormatted"
        Me.lblFormatted.Size = New System.Drawing.Size(54, 13)
        Me.lblFormatted.TabIndex = 1
        Me.lblFormatted.Text = "Formatted"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(186, 132)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(161, 28)
        Me.lblResult.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFullDateTime)
        Me.GroupBox1.Controls.Add(Me.btnLongTime)
        Me.GroupBox1.Controls.Add(Me.btnShortTime)
        Me.GroupBox1.Controls.Add(Me.btnLongDate)
        Me.GroupBox1.Controls.Add(Me.btnShortDate)
        Me.GroupBox1.Controls.Add(Me.btnPercentFormat)
        Me.GroupBox1.Controls.Add(Me.btnCurrencyFormat)
        Me.GroupBox1.Controls.Add(Me.btnExponentialFormat)
        Me.GroupBox1.Controls.Add(Me.btnFixedPointFormat)
        Me.GroupBox1.Controls.Add(Me.btnNumberFormat)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 208)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Format"
        '
        'btnFullDateTime
        '
        Me.btnFullDateTime.Location = New System.Drawing.Point(223, 146)
        Me.btnFullDateTime.Name = "btnFullDateTime"
        Me.btnFullDateTime.Size = New System.Drawing.Size(102, 23)
        Me.btnFullDateTime.TabIndex = 14
        Me.btnFullDateTime.Text = "Full date/time (F)"
        Me.btnFullDateTime.UseVisualStyleBackColor = True
        '
        'btnLongTime
        '
        Me.btnLongTime.Location = New System.Drawing.Point(223, 117)
        Me.btnLongTime.Name = "btnLongTime"
        Me.btnLongTime.Size = New System.Drawing.Size(102, 23)
        Me.btnLongTime.TabIndex = 13
        Me.btnLongTime.Text = "Long Time (T)"
        Me.btnLongTime.UseVisualStyleBackColor = True
        '
        'btnShortTime
        '
        Me.btnShortTime.Location = New System.Drawing.Point(223, 91)
        Me.btnShortTime.Name = "btnShortTime"
        Me.btnShortTime.Size = New System.Drawing.Size(102, 23)
        Me.btnShortTime.TabIndex = 12
        Me.btnShortTime.Text = "Short Time (t)"
        Me.btnShortTime.UseVisualStyleBackColor = True
        '
        'btnLongDate
        '
        Me.btnLongDate.Location = New System.Drawing.Point(223, 62)
        Me.btnLongDate.Name = "btnLongDate"
        Me.btnLongDate.Size = New System.Drawing.Size(102, 23)
        Me.btnLongDate.TabIndex = 11
        Me.btnLongDate.Text = "Long Date (D)"
        Me.btnLongDate.UseVisualStyleBackColor = True
        '
        'btnShortDate
        '
        Me.btnShortDate.Location = New System.Drawing.Point(223, 33)
        Me.btnShortDate.Name = "btnShortDate"
        Me.btnShortDate.Size = New System.Drawing.Size(102, 23)
        Me.btnShortDate.TabIndex = 10
        Me.btnShortDate.Text = "Short Date (d) "
        Me.btnShortDate.UseVisualStyleBackColor = True
        '
        'btnPercentFormat
        '
        Me.btnPercentFormat.Location = New System.Drawing.Point(18, 146)
        Me.btnPercentFormat.Name = "btnPercentFormat"
        Me.btnPercentFormat.Size = New System.Drawing.Size(119, 23)
        Me.btnPercentFormat.TabIndex = 9
        Me.btnPercentFormat.Text = "Percent Format (p)"
        Me.btnPercentFormat.UseVisualStyleBackColor = True
        '
        'btnCurrencyFormat
        '
        Me.btnCurrencyFormat.Location = New System.Drawing.Point(18, 117)
        Me.btnCurrencyFormat.Name = "btnCurrencyFormat"
        Me.btnCurrencyFormat.Size = New System.Drawing.Size(119, 23)
        Me.btnCurrencyFormat.TabIndex = 8
        Me.btnCurrencyFormat.Text = "Currency Format (c)"
        Me.btnCurrencyFormat.UseVisualStyleBackColor = True
        '
        'btnExponentialFormat
        '
        Me.btnExponentialFormat.Location = New System.Drawing.Point(18, 91)
        Me.btnExponentialFormat.Name = "btnExponentialFormat"
        Me.btnExponentialFormat.Size = New System.Drawing.Size(119, 23)
        Me.btnExponentialFormat.TabIndex = 7
        Me.btnExponentialFormat.Text = "Exponential format (e)"
        Me.btnExponentialFormat.UseVisualStyleBackColor = True
        '
        'btnFixedPointFormat
        '
        Me.btnFixedPointFormat.Location = New System.Drawing.Point(18, 62)
        Me.btnFixedPointFormat.Name = "btnFixedPointFormat"
        Me.btnFixedPointFormat.Size = New System.Drawing.Size(119, 23)
        Me.btnFixedPointFormat.TabIndex = 6
        Me.btnFixedPointFormat.Text = "Fixed-Point format(f)"
        Me.btnFixedPointFormat.UseVisualStyleBackColor = True
        '
        'btnNumberFormat
        '
        Me.btnNumberFormat.Location = New System.Drawing.Point(18, 33)
        Me.btnNumberFormat.Name = "btnNumberFormat"
        Me.btnNumberFormat.Size = New System.Drawing.Size(119, 23)
        Me.btnNumberFormat.TabIndex = 5
        Me.btnNumberFormat.Text = "Number Format (n)"
        Me.btnNumberFormat.UseVisualStyleBackColor = True
        '
        'txtUserEntery
        '
        Me.txtUserEntery.Location = New System.Drawing.Point(209, 59)
        Me.txtUserEntery.Name = "txtUserEntery"
        Me.txtUserEntery.Size = New System.Drawing.Size(100, 20)
        Me.txtUserEntery.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(157, 445)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 497)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtUserEntery)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblFormatted)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFormatted As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFullDateTime As System.Windows.Forms.Button
    Friend WithEvents btnLongTime As System.Windows.Forms.Button
    Friend WithEvents btnShortTime As System.Windows.Forms.Button
    Friend WithEvents btnLongDate As System.Windows.Forms.Button
    Friend WithEvents btnShortDate As System.Windows.Forms.Button
    Friend WithEvents btnPercentFormat As System.Windows.Forms.Button
    Friend WithEvents btnCurrencyFormat As System.Windows.Forms.Button
    Friend WithEvents btnExponentialFormat As System.Windows.Forms.Button
    Friend WithEvents btnFixedPointFormat As System.Windows.Forms.Button
    Friend WithEvents btnNumberFormat As System.Windows.Forms.Button
    Friend WithEvents txtUserEntery As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
