<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerRegistration))
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtTelNum = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCustno = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblTelnum = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCustno = New System.Windows.Forms.Label()
        Me.lblStaff = New System.Windows.Forms.Label()
        Me.lblVtitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSubmit.Location = New System.Drawing.Point(314, 502)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(150, 40)
        Me.btnSubmit.TabIndex = 32
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancel.Location = New System.Drawing.Point(51, 560)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 40)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "Return"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'cboGender
        '
        Me.cboGender.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(374, 323)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboGender.Size = New System.Drawing.Size(213, 28)
        Me.cboGender.TabIndex = 29
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtAddress.Location = New System.Drawing.Point(374, 408)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(213, 77)
        Me.txtAddress.TabIndex = 28
        '
        'txtTelNum
        '
        Me.txtTelNum.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtTelNum.Location = New System.Drawing.Point(374, 367)
        Me.txtTelNum.Name = "txtTelNum"
        Me.txtTelNum.Size = New System.Drawing.Size(213, 26)
        Me.txtTelNum.TabIndex = 27
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtName.Location = New System.Drawing.Point(374, 277)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(213, 26)
        Me.txtName.TabIndex = 26
        '
        'txtCustno
        '
        Me.txtCustno.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCustno.Enabled = False
        Me.txtCustno.Location = New System.Drawing.Point(374, 233)
        Me.txtCustno.Name = "txtCustno"
        Me.txtCustno.Size = New System.Drawing.Size(213, 26)
        Me.txtCustno.TabIndex = 25
        Me.txtCustno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblTitle.Font = New System.Drawing.Font("Nirmala UI", 35.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTitle.Image = CType(resources.GetObject("lblTitle.Image"), System.Drawing.Image)
        Me.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitle.Location = New System.Drawing.Point(114, 33)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(563, 93)
        Me.lblTitle.TabIndex = 24
        Me.lblTitle.Text = "APU CAFETERIA"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblAddress.Image = CType(resources.GetObject("lblAddress.Image"), System.Drawing.Image)
        Me.lblAddress.Location = New System.Drawing.Point(185, 408)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(114, 29)
        Me.lblAddress.TabIndex = 23
        Me.lblAddress.Text = "Address :"
        '
        'lblTelnum
        '
        Me.lblTelnum.AutoSize = True
        Me.lblTelnum.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblTelnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblTelnum.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTelnum.Image = CType(resources.GetObject("lblTelnum.Image"), System.Drawing.Image)
        Me.lblTelnum.Location = New System.Drawing.Point(185, 363)
        Me.lblTelnum.Name = "lblTelnum"
        Me.lblTelnum.Size = New System.Drawing.Size(154, 29)
        Me.lblTelnum.TabIndex = 22
        Me.lblTelnum.Text = "Tel Number :"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblGender.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblGender.Image = CType(resources.GetObject("lblGender.Image"), System.Drawing.Image)
        Me.lblGender.Location = New System.Drawing.Point(185, 318)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(106, 29)
        Me.lblGender.TabIndex = 21
        Me.lblGender.Text = "Gender :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblName.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblName.Image = CType(resources.GetObject("lblName.Image"), System.Drawing.Image)
        Me.lblName.Location = New System.Drawing.Point(185, 273)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(90, 29)
        Me.lblName.TabIndex = 20
        Me.lblName.Text = "Name :"
        '
        'lblCustno
        '
        Me.lblCustno.AutoSize = True
        Me.lblCustno.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblCustno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCustno.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblCustno.Image = CType(resources.GetObject("lblCustno.Image"), System.Drawing.Image)
        Me.lblCustno.Location = New System.Drawing.Point(185, 228)
        Me.lblCustno.Name = "lblCustno"
        Me.lblCustno.Size = New System.Drawing.Size(158, 29)
        Me.lblCustno.TabIndex = 19
        Me.lblCustno.Text = "Customer ID :"
        '
        'lblStaff
        '
        Me.lblStaff.AutoSize = True
        Me.lblStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblStaff.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblStaff.Image = CType(resources.GetObject("lblStaff.Image"), System.Drawing.Image)
        Me.lblStaff.Location = New System.Drawing.Point(272, 189)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(101, 29)
        Me.lblStaff.TabIndex = 18
        Me.lblStaff.Text = "Staff ID :"
        '
        'lblVtitle
        '
        Me.lblVtitle.AutoSize = True
        Me.lblVtitle.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblVtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblVtitle.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblVtitle.Image = CType(resources.GetObject("lblVtitle.Image"), System.Drawing.Image)
        Me.lblVtitle.Location = New System.Drawing.Point(224, 122)
        Me.lblVtitle.Name = "lblVtitle"
        Me.lblVtitle.Size = New System.Drawing.Size(310, 36)
        Me.lblVtitle.TabIndex = 17
        Me.lblVtitle.Text = "Customer Registration"
        '
        'CustomerRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 651)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtTelNum)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCustno)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblTelnum)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCustno)
        Me.Controls.Add(Me.lblStaff)
        Me.Controls.Add(Me.lblVtitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CustomerRegistration"
        Me.Text = "Customer Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtTelNum As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCustno As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblTelnum As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblCustno As Label
    Friend WithEvents lblStaff As Label
    Friend WithEvents lblVtitle As Label
End Class
