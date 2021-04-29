<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerLogin))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVtitle = New System.Windows.Forms.Label()
        Me.txtCustno = New System.Windows.Forms.TextBox()
        Me.lblCustno = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblStaff = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Snow
        Me.lblTitle.Font = New System.Drawing.Font("Nirmala UI", 35.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTitle.Image = CType(resources.GetObject("lblTitle.Image"), System.Drawing.Image)
        Me.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitle.Location = New System.Drawing.Point(121, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(563, 93)
        Me.lblTitle.TabIndex = 26
        Me.lblTitle.Text = "APU CAFETERIA"
        '
        'lblVtitle
        '
        Me.lblVtitle.AutoSize = True
        Me.lblVtitle.BackColor = System.Drawing.Color.Snow
        Me.lblVtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblVtitle.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblVtitle.Image = CType(resources.GetObject("lblVtitle.Image"), System.Drawing.Image)
        Me.lblVtitle.Location = New System.Drawing.Point(278, 125)
        Me.lblVtitle.Name = "lblVtitle"
        Me.lblVtitle.Size = New System.Drawing.Size(225, 36)
        Me.lblVtitle.TabIndex = 25
        Me.lblVtitle.Text = "Customer Login"
        '
        'txtCustno
        '
        Me.txtCustno.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCustno.Location = New System.Drawing.Point(380, 238)
        Me.txtCustno.Name = "txtCustno"
        Me.txtCustno.Size = New System.Drawing.Size(213, 26)
        Me.txtCustno.TabIndex = 30
        '
        'lblCustno
        '
        Me.lblCustno.AutoSize = True
        Me.lblCustno.BackColor = System.Drawing.Color.Snow
        Me.lblCustno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCustno.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblCustno.Image = CType(resources.GetObject("lblCustno.Image"), System.Drawing.Image)
        Me.lblCustno.Location = New System.Drawing.Point(191, 233)
        Me.lblCustno.Name = "lblCustno"
        Me.lblCustno.Size = New System.Drawing.Size(158, 29)
        Me.lblCustno.TabIndex = 29
        Me.lblCustno.Text = "Customer ID :"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLogout.Location = New System.Drawing.Point(57, 378)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(150, 40)
        Me.btnLogout.TabIndex = 31
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCreate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCreate.Location = New System.Drawing.Point(317, 302)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(150, 40)
        Me.btnCreate.TabIndex = 32
        Me.btnCreate.Text = "Create New"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLogin.Location = New System.Drawing.Point(575, 378)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(150, 40)
        Me.btnLogin.TabIndex = 33
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblStaff
        '
        Me.lblStaff.AutoSize = True
        Me.lblStaff.BackColor = System.Drawing.Color.Snow
        Me.lblStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblStaff.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblStaff.Image = CType(resources.GetObject("lblStaff.Image"), System.Drawing.Image)
        Me.lblStaff.Location = New System.Drawing.Point(278, 200)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(101, 29)
        Me.lblStaff.TabIndex = 34
        Me.lblStaff.Text = "Staff ID :"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblStaff)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.txtCustno)
        Me.Controls.Add(Me.lblCustno)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblVtitle)
        Me.Name = "Form5"
        Me.Text = "Customer Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblVtitle As Label
    Friend WithEvents txtCustno As TextBox
    Friend WithEvents lblCustno As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblStaff As Label
End Class
