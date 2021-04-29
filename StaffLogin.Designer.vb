<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffLogin))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtStaff = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblStaff = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ckbPass = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLogin.Location = New System.Drawing.Point(551, 365)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(150, 40)
        Me.btnLogin.TabIndex = 13
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancel.Location = New System.Drawing.Point(99, 365)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 40)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtPassword.Location = New System.Drawing.Point(346, 255)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(245, 35)
        Me.txtPassword.TabIndex = 11
        '
        'txtStaff
        '
        Me.txtStaff.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtStaff.Location = New System.Drawing.Point(346, 184)
        Me.txtStaff.Name = "txtStaff"
        Me.txtStaff.Size = New System.Drawing.Size(245, 35)
        Me.txtStaff.TabIndex = 10
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPassword.Image = CType(resources.GetObject("lblPassword.Image"), System.Drawing.Image)
        Me.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPassword.Location = New System.Drawing.Point(155, 252)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(163, 36)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Password :"
        '
        'lblStaff
        '
        Me.lblStaff.AutoSize = True
        Me.lblStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblStaff.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblStaff.Image = CType(resources.GetObject("lblStaff.Image"), System.Drawing.Image)
        Me.lblStaff.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStaff.Location = New System.Drawing.Point(190, 181)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(128, 36)
        Me.lblStaff.TabIndex = 8
        Me.lblStaff.Text = "Staff ID :"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Nirmala UI", 35.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTitle.Image = CType(resources.GetObject("lblTitle.Image"), System.Drawing.Image)
        Me.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitle.Location = New System.Drawing.Point(114, 46)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(563, 93)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "APU CAFETERIA"
        '
        'ckbPass
        '
        Me.ckbPass.AutoSize = True
        Me.ckbPass.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ckbPass.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.ckbPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ckbPass.Location = New System.Drawing.Point(346, 307)
        Me.ckbPass.Name = "ckbPass"
        Me.ckbPass.Size = New System.Drawing.Size(148, 24)
        Me.ckbPass.TabIndex = 14
        Me.ckbPass.Text = "Show Password"
        Me.ckbPass.UseVisualStyleBackColor = False
        '
        'StaffLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ckbPass)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtStaff)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblStaff)
        Me.Controls.Add(Me.lblTitle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "StaffLogin"
        Me.Text = "Staff Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtStaff As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblStaff As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents ckbPass As CheckBox
End Class
