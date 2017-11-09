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
        Me.lblDateToday = New System.Windows.Forms.Label()
        Me.lblTimeToday = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.txtNightlyCharge = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMisc = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtRoomService = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblRoomCharges = New System.Windows.Forms.Label()
        Me.lblAddCharges = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Highlander Hotel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Today's Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Time:"
        '
        'lblDateToday
        '
        Me.lblDateToday.Location = New System.Drawing.Point(212, 52)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(211, 23)
        Me.lblDateToday.TabIndex = 3
        '
        'lblTimeToday
        '
        Me.lblTimeToday.Location = New System.Drawing.Point(212, 78)
        Me.lblTimeToday.Name = "lblTimeToday"
        Me.lblTimeToday.Size = New System.Drawing.Size(191, 13)
        Me.lblTimeToday.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNights)
        Me.GroupBox1.Controls.Add(Me.txtNightlyCharge)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nightly Charge:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nights:"
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(94, 31)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(100, 20)
        Me.txtNights.TabIndex = 5
        '
        'txtNightlyCharge
        '
        Me.txtNightlyCharge.Location = New System.Drawing.Point(94, 57)
        Me.txtNightlyCharge.Name = "txtNightlyCharge"
        Me.txtNightlyCharge.Size = New System.Drawing.Size(100, 20)
        Me.txtNightlyCharge.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMisc)
        Me.GroupBox2.Controls.Add(Me.txtTelephone)
        Me.GroupBox2.Controls.Add(Me.txtRoomService)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(270, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Adiitonal Charges"
        '
        'txtMisc
        '
        Me.txtMisc.Location = New System.Drawing.Point(89, 72)
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(100, 20)
        Me.txtMisc.TabIndex = 9
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(89, 45)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(100, 20)
        Me.txtTelephone.TabIndex = 8
        '
        'txtRoomService
        '
        Me.txtRoomService.Location = New System.Drawing.Point(89, 16)
        Me.txtRoomService.Name = "txtRoomService"
        Me.txtRoomService.Size = New System.Drawing.Size(100, 20)
        Me.txtRoomService.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Misc:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Room Service:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Telephone:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.lblTax)
        Me.GroupBox3.Controls.Add(Me.lblSubtotal)
        Me.GroupBox3.Controls.Add(Me.lblAddCharges)
        Me.GroupBox3.Controls.Add(Me.lblRoomCharges)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(36, 237)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(434, 171)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Charges"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(97, 131)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Total Charges:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(97, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Room Charges:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(145, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Tax:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(124, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Subtotal:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(79, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Additional Charges:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(93, 414)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(101, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate Charges"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(215, 414)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(314, 414)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblRoomCharges
        '
        Me.lblRoomCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomCharges.Location = New System.Drawing.Point(209, 15)
        Me.lblRoomCharges.Name = "lblRoomCharges"
        Me.lblRoomCharges.Size = New System.Drawing.Size(187, 23)
        Me.lblRoomCharges.TabIndex = 15
        '
        'lblAddCharges
        '
        Me.lblAddCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddCharges.Location = New System.Drawing.Point(209, 47)
        Me.lblAddCharges.Name = "lblAddCharges"
        Me.lblAddCharges.Size = New System.Drawing.Size(187, 23)
        Me.lblAddCharges.TabIndex = 16
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(209, 75)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(187, 23)
        Me.lblSubtotal.TabIndex = 17
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(209, 102)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(187, 23)
        Me.lblTax.TabIndex = 18
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(209, 131)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(187, 23)
        Me.lblTotal.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 461)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTimeToday)
        Me.Controls.Add(Me.lblDateToday)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Room Charge Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDateToday As System.Windows.Forms.Label
    Friend WithEvents lblTimeToday As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtNights As System.Windows.Forms.TextBox
    Friend WithEvents txtNightlyCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtMisc As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomService As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblAddCharges As System.Windows.Forms.Label
    Friend WithEvents lblRoomCharges As System.Windows.Forms.Label

End Class
