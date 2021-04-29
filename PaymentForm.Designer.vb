<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentForm))
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtMoney = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.txt50 = New System.Windows.Forms.TextBox()
        Me.btn50add = New System.Windows.Forms.Button()
        Me.btn50min = New System.Windows.Forms.Button()
        Me.txt20 = New System.Windows.Forms.TextBox()
        Me.btn20add = New System.Windows.Forms.Button()
        Me.btn20min = New System.Windows.Forms.Button()
        Me.txt10 = New System.Windows.Forms.TextBox()
        Me.btn10add = New System.Windows.Forms.Button()
        Me.btn10min = New System.Windows.Forms.Button()
        Me.txt5000 = New System.Windows.Forms.TextBox()
        Me.btn5000add = New System.Windows.Forms.Button()
        Me.btn5000min = New System.Windows.Forms.Button()
        Me.txt2000 = New System.Windows.Forms.TextBox()
        Me.btn2000add = New System.Windows.Forms.Button()
        Me.btn2000min = New System.Windows.Forms.Button()
        Me.txt1000 = New System.Windows.Forms.TextBox()
        Me.btn1000add = New System.Windows.Forms.Button()
        Me.btn1000min = New System.Windows.Forms.Button()
        Me.txt500 = New System.Windows.Forms.TextBox()
        Me.btn500add = New System.Windows.Forms.Button()
        Me.btn500min = New System.Windows.Forms.Button()
        Me.txt100 = New System.Windows.Forms.TextBox()
        Me.btn100add = New System.Windows.Forms.Button()
        Me.btn100min = New System.Windows.Forms.Button()
        Me.lbl50 = New System.Windows.Forms.Label()
        Me.lbl20 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl5000 = New System.Windows.Forms.Label()
        Me.lbl2000 = New System.Windows.Forms.Label()
        Me.lbl1000 = New System.Windows.Forms.Label()
        Me.lbl500 = New System.Windows.Forms.Label()
        Me.lbl100 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.itemBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnCalc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCalc.Location = New System.Drawing.Point(600, 426)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(133, 34)
        Me.btnCalc.TabIndex = 105
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtMoney
        '
        Me.txtMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtMoney.Location = New System.Drawing.Point(307, 428)
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.ReadOnly = True
        Me.txtMoney.Size = New System.Drawing.Size(270, 30)
        Me.txtMoney.TabIndex = 104
        Me.txtMoney.Text = "RM0.00"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtAmount.Location = New System.Drawing.Point(307, 475)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(270, 30)
        Me.txtAmount.TabIndex = 103
        Me.txtAmount.Text = "RM0.00"
        '
        'txtChange
        '
        Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtChange.Location = New System.Drawing.Point(307, 522)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(270, 30)
        Me.txtChange.TabIndex = 102
        Me.txtChange.Text = "RM0.00"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.BackColor = System.Drawing.Color.Transparent
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblChange.ForeColor = System.Drawing.Color.Black
        Me.lblChange.Location = New System.Drawing.Point(75, 523)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(196, 29)
        Me.lblChange.TabIndex = 101
        Me.lblChange.Text = "Change Amount :"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblAmount.ForeColor = System.Drawing.Color.Black
        Me.lblAmount.Location = New System.Drawing.Point(75, 476)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(167, 29)
        Me.lblAmount.TabIndex = 100
        Me.lblAmount.Text = "Total Amount :"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.BackColor = System.Drawing.Color.Transparent
        Me.lblMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblMoney.ForeColor = System.Drawing.Color.Black
        Me.lblMoney.Location = New System.Drawing.Point(75, 429)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(205, 29)
        Me.lblMoney.TabIndex = 99
        Me.lblMoney.Text = "Money Received :"
        '
        'txt50
        '
        Me.txt50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt50.Location = New System.Drawing.Point(634, 274)
        Me.txt50.Name = "txt50"
        Me.txt50.ReadOnly = True
        Me.txt50.Size = New System.Drawing.Size(30, 26)
        Me.txt50.TabIndex = 98
        Me.txt50.Text = "0"
        Me.txt50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn50add
        '
        Me.btn50add.Location = New System.Drawing.Point(672, 274)
        Me.btn50add.Name = "btn50add"
        Me.btn50add.Size = New System.Drawing.Size(30, 30)
        Me.btn50add.TabIndex = 97
        Me.btn50add.Text = "+"
        Me.btn50add.UseVisualStyleBackColor = True
        '
        'btn50min
        '
        Me.btn50min.Location = New System.Drawing.Point(595, 274)
        Me.btn50min.Name = "btn50min"
        Me.btn50min.Size = New System.Drawing.Size(30, 30)
        Me.btn50min.TabIndex = 96
        Me.btn50min.Text = "-"
        Me.btn50min.UseVisualStyleBackColor = True
        '
        'txt20
        '
        Me.txt20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt20.Location = New System.Drawing.Point(634, 214)
        Me.txt20.Name = "txt20"
        Me.txt20.ReadOnly = True
        Me.txt20.Size = New System.Drawing.Size(30, 26)
        Me.txt20.TabIndex = 95
        Me.txt20.Text = "0"
        Me.txt20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn20add
        '
        Me.btn20add.Location = New System.Drawing.Point(672, 214)
        Me.btn20add.Name = "btn20add"
        Me.btn20add.Size = New System.Drawing.Size(30, 30)
        Me.btn20add.TabIndex = 94
        Me.btn20add.Text = "+"
        Me.btn20add.UseVisualStyleBackColor = True
        '
        'btn20min
        '
        Me.btn20min.Location = New System.Drawing.Point(595, 214)
        Me.btn20min.Name = "btn20min"
        Me.btn20min.Size = New System.Drawing.Size(30, 30)
        Me.btn20min.TabIndex = 93
        Me.btn20min.Text = "-"
        Me.btn20min.UseVisualStyleBackColor = True
        '
        'txt10
        '
        Me.txt10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt10.Location = New System.Drawing.Point(634, 158)
        Me.txt10.Name = "txt10"
        Me.txt10.ReadOnly = True
        Me.txt10.Size = New System.Drawing.Size(30, 26)
        Me.txt10.TabIndex = 92
        Me.txt10.Text = "0"
        Me.txt10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn10add
        '
        Me.btn10add.Location = New System.Drawing.Point(672, 158)
        Me.btn10add.Name = "btn10add"
        Me.btn10add.Size = New System.Drawing.Size(30, 30)
        Me.btn10add.TabIndex = 91
        Me.btn10add.Text = "+"
        Me.btn10add.UseVisualStyleBackColor = True
        '
        'btn10min
        '
        Me.btn10min.Location = New System.Drawing.Point(595, 158)
        Me.btn10min.Name = "btn10min"
        Me.btn10min.Size = New System.Drawing.Size(30, 30)
        Me.btn10min.TabIndex = 90
        Me.btn10min.Text = "-"
        Me.btn10min.UseVisualStyleBackColor = True
        '
        'txt5000
        '
        Me.txt5000.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt5000.Location = New System.Drawing.Point(280, 323)
        Me.txt5000.Name = "txt5000"
        Me.txt5000.ReadOnly = True
        Me.txt5000.Size = New System.Drawing.Size(30, 26)
        Me.txt5000.TabIndex = 89
        Me.txt5000.Text = "0"
        Me.txt5000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn5000add
        '
        Me.btn5000add.Location = New System.Drawing.Point(318, 323)
        Me.btn5000add.Name = "btn5000add"
        Me.btn5000add.Size = New System.Drawing.Size(30, 30)
        Me.btn5000add.TabIndex = 88
        Me.btn5000add.Text = "+"
        Me.btn5000add.UseVisualStyleBackColor = True
        '
        'btn5000min
        '
        Me.btn5000min.Location = New System.Drawing.Point(241, 323)
        Me.btn5000min.Name = "btn5000min"
        Me.btn5000min.Size = New System.Drawing.Size(30, 30)
        Me.btn5000min.TabIndex = 87
        Me.btn5000min.Text = "-"
        Me.btn5000min.UseVisualStyleBackColor = True
        '
        'txt2000
        '
        Me.txt2000.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt2000.Location = New System.Drawing.Point(280, 270)
        Me.txt2000.Name = "txt2000"
        Me.txt2000.ReadOnly = True
        Me.txt2000.Size = New System.Drawing.Size(30, 26)
        Me.txt2000.TabIndex = 86
        Me.txt2000.Text = "0"
        Me.txt2000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn2000add
        '
        Me.btn2000add.Location = New System.Drawing.Point(318, 270)
        Me.btn2000add.Name = "btn2000add"
        Me.btn2000add.Size = New System.Drawing.Size(30, 30)
        Me.btn2000add.TabIndex = 85
        Me.btn2000add.Text = "+"
        Me.btn2000add.UseVisualStyleBackColor = True
        '
        'btn2000min
        '
        Me.btn2000min.Location = New System.Drawing.Point(241, 270)
        Me.btn2000min.Name = "btn2000min"
        Me.btn2000min.Size = New System.Drawing.Size(30, 30)
        Me.btn2000min.TabIndex = 84
        Me.btn2000min.Text = "-"
        Me.btn2000min.UseVisualStyleBackColor = True
        '
        'txt1000
        '
        Me.txt1000.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt1000.Location = New System.Drawing.Point(280, 216)
        Me.txt1000.Name = "txt1000"
        Me.txt1000.ReadOnly = True
        Me.txt1000.Size = New System.Drawing.Size(30, 26)
        Me.txt1000.TabIndex = 83
        Me.txt1000.Text = "0"
        Me.txt1000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn1000add
        '
        Me.btn1000add.Location = New System.Drawing.Point(318, 216)
        Me.btn1000add.Name = "btn1000add"
        Me.btn1000add.Size = New System.Drawing.Size(30, 30)
        Me.btn1000add.TabIndex = 82
        Me.btn1000add.Text = "+"
        Me.btn1000add.UseVisualStyleBackColor = True
        '
        'btn1000min
        '
        Me.btn1000min.Location = New System.Drawing.Point(241, 216)
        Me.btn1000min.Name = "btn1000min"
        Me.btn1000min.Size = New System.Drawing.Size(30, 30)
        Me.btn1000min.TabIndex = 81
        Me.btn1000min.Text = "-"
        Me.btn1000min.UseVisualStyleBackColor = True
        '
        'txt500
        '
        Me.txt500.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt500.Location = New System.Drawing.Point(280, 166)
        Me.txt500.Name = "txt500"
        Me.txt500.ReadOnly = True
        Me.txt500.Size = New System.Drawing.Size(30, 26)
        Me.txt500.TabIndex = 80
        Me.txt500.Text = "0"
        Me.txt500.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn500add
        '
        Me.btn500add.Location = New System.Drawing.Point(318, 166)
        Me.btn500add.Name = "btn500add"
        Me.btn500add.Size = New System.Drawing.Size(30, 30)
        Me.btn500add.TabIndex = 79
        Me.btn500add.Text = "+"
        Me.btn500add.UseVisualStyleBackColor = True
        '
        'btn500min
        '
        Me.btn500min.Location = New System.Drawing.Point(241, 166)
        Me.btn500min.Name = "btn500min"
        Me.btn500min.Size = New System.Drawing.Size(30, 30)
        Me.btn500min.TabIndex = 78
        Me.btn500min.Text = "-"
        Me.btn500min.UseVisualStyleBackColor = True
        '
        'txt100
        '
        Me.txt100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt100.Location = New System.Drawing.Point(280, 113)
        Me.txt100.Name = "txt100"
        Me.txt100.ReadOnly = True
        Me.txt100.Size = New System.Drawing.Size(30, 26)
        Me.txt100.TabIndex = 77
        Me.txt100.Text = "0"
        Me.txt100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn100add
        '
        Me.btn100add.Location = New System.Drawing.Point(318, 113)
        Me.btn100add.Name = "btn100add"
        Me.btn100add.Size = New System.Drawing.Size(30, 30)
        Me.btn100add.TabIndex = 76
        Me.btn100add.Text = "+"
        Me.btn100add.UseVisualStyleBackColor = True
        '
        'btn100min
        '
        Me.btn100min.Location = New System.Drawing.Point(241, 113)
        Me.btn100min.Name = "btn100min"
        Me.btn100min.Size = New System.Drawing.Size(30, 30)
        Me.btn100min.TabIndex = 75
        Me.btn100min.Text = "-"
        Me.btn100min.UseVisualStyleBackColor = True
        '
        'lbl50
        '
        Me.lbl50.AutoSize = True
        Me.lbl50.BackColor = System.Drawing.Color.Transparent
        Me.lbl50.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lbl50.ForeColor = System.Drawing.Color.Black
        Me.lbl50.Location = New System.Drawing.Point(454, 274)
        Me.lbl50.Name = "lbl50"
        Me.lbl50.Size = New System.Drawing.Size(129, 36)
        Me.lbl50.TabIndex = 74
        Me.lbl50.Text = "RM 0.50"
        '
        'lbl20
        '
        Me.lbl20.AutoSize = True
        Me.lbl20.BackColor = System.Drawing.Color.Transparent
        Me.lbl20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lbl20.ForeColor = System.Drawing.Color.Black
        Me.lbl20.Location = New System.Drawing.Point(454, 214)
        Me.lbl20.Name = "lbl20"
        Me.lbl20.Size = New System.Drawing.Size(129, 36)
        Me.lbl20.TabIndex = 73
        Me.lbl20.Text = "RM 0.20"
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.BackColor = System.Drawing.Color.Transparent
        Me.lbl10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lbl10.ForeColor = System.Drawing.Color.Black
        Me.lbl10.Location = New System.Drawing.Point(454, 152)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(129, 36)
        Me.lbl10.TabIndex = 72
        Me.lbl10.Text = "RM 0.10"
        '
        'lbl5000
        '
        Me.lbl5000.AutoSize = True
        Me.lbl5000.BackColor = System.Drawing.Color.Transparent
        Me.lbl5000.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lbl5000.ForeColor = System.Drawing.Color.Black
        Me.lbl5000.Location = New System.Drawing.Point(67, 323)
        Me.lbl5000.Name = "lbl5000"
        Me.lbl5000.Size = New System.Drawing.Size(146, 36)
        Me.lbl5000.TabIndex = 71
        Me.lbl5000.Text = "RM 50.00"
        '
        'lbl2000
        '
        Me.lbl2000.AutoSize = True
        Me.lbl2000.BackColor = System.Drawing.Color.Transparent
        Me.lbl2000.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lbl2000.ForeColor = System.Drawing.Color.Black
        Me.lbl2000.Location = New System.Drawing.Point(67, 270)
        Me.lbl2000.Name = "lbl2000"
        Me.lbl2000.Size = New System.Drawing.Size(146, 36)
        Me.lbl2000.TabIndex = 70
        Me.lbl2000.Text = "RM 20.00"
        '
        'lbl1000
        '
        Me.lbl1000.AutoSize = True
        Me.lbl1000.BackColor = System.Drawing.Color.Transparent
        Me.lbl1000.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lbl1000.ForeColor = System.Drawing.Color.Black
        Me.lbl1000.Location = New System.Drawing.Point(67, 216)
        Me.lbl1000.Name = "lbl1000"
        Me.lbl1000.Size = New System.Drawing.Size(146, 36)
        Me.lbl1000.TabIndex = 69
        Me.lbl1000.Text = "RM 10.00"
        '
        'lbl500
        '
        Me.lbl500.AutoSize = True
        Me.lbl500.BackColor = System.Drawing.Color.Transparent
        Me.lbl500.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lbl500.ForeColor = System.Drawing.Color.Black
        Me.lbl500.Location = New System.Drawing.Point(67, 166)
        Me.lbl500.Name = "lbl500"
        Me.lbl500.Size = New System.Drawing.Size(145, 36)
        Me.lbl500.TabIndex = 68
        Me.lbl500.Text = "RM   5.00"
        '
        'lbl100
        '
        Me.lbl100.AutoSize = True
        Me.lbl100.BackColor = System.Drawing.Color.Transparent
        Me.lbl100.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lbl100.ForeColor = System.Drawing.Color.Black
        Me.lbl100.Location = New System.Drawing.Point(67, 113)
        Me.lbl100.Name = "lbl100"
        Me.lbl100.Size = New System.Drawing.Size(145, 36)
        Me.lbl100.TabIndex = 67
        Me.lbl100.Text = "RM   1.00"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(397, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(403, 62)
        Me.lblTitle.TabIndex = 66
        Me.lblTitle.Text = "Payment Form"
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnPay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPay.Location = New System.Drawing.Point(1037, 608)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(133, 38)
        Me.btnPay.TabIndex = 107
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnPrev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrev.Location = New System.Drawing.Point(57, 608)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(133, 38)
        Me.btnPrev.TabIndex = 106
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.BackColor = System.Drawing.Color.Transparent
        Me.lblCustID.ForeColor = System.Drawing.Color.Black
        Me.lblCustID.Location = New System.Drawing.Point(280, 394)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(107, 20)
        Me.lblCustID.TabIndex = 108
        Me.lblCustID.Text = "Customer ID :"
        '
        'itemBox
        '
        Me.itemBox.FormattingEnabled = True
        Me.itemBox.ItemHeight = 20
        Me.itemBox.Location = New System.Drawing.Point(760, 125)
        Me.itemBox.Name = "itemBox"
        Me.itemBox.Size = New System.Drawing.Size(410, 424)
        Me.itemBox.TabIndex = 109
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1217, 681)
        Me.Controls.Add(Me.itemBox)
        Me.Controls.Add(Me.lblCustID)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtMoney)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.txt50)
        Me.Controls.Add(Me.btn50add)
        Me.Controls.Add(Me.btn50min)
        Me.Controls.Add(Me.txt20)
        Me.Controls.Add(Me.btn20add)
        Me.Controls.Add(Me.btn20min)
        Me.Controls.Add(Me.txt10)
        Me.Controls.Add(Me.btn10add)
        Me.Controls.Add(Me.btn10min)
        Me.Controls.Add(Me.txt5000)
        Me.Controls.Add(Me.btn5000add)
        Me.Controls.Add(Me.btn5000min)
        Me.Controls.Add(Me.txt2000)
        Me.Controls.Add(Me.btn2000add)
        Me.Controls.Add(Me.btn2000min)
        Me.Controls.Add(Me.txt1000)
        Me.Controls.Add(Me.btn1000add)
        Me.Controls.Add(Me.btn1000min)
        Me.Controls.Add(Me.txt500)
        Me.Controls.Add(Me.btn500add)
        Me.Controls.Add(Me.btn500min)
        Me.Controls.Add(Me.txt100)
        Me.Controls.Add(Me.btn100add)
        Me.Controls.Add(Me.btn100min)
        Me.Controls.Add(Me.lbl50)
        Me.Controls.Add(Me.lbl20)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl5000)
        Me.Controls.Add(Me.lbl2000)
        Me.Controls.Add(Me.lbl1000)
        Me.Controls.Add(Me.lbl500)
        Me.Controls.Add(Me.lbl100)
        Me.Controls.Add(Me.lblTitle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "PaymentForm"
        Me.Text = "Payment Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents txtMoney As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtChange As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblMoney As Label
    Friend WithEvents txt50 As TextBox
    Friend WithEvents btn50add As Button
    Friend WithEvents btn50min As Button
    Friend WithEvents txt20 As TextBox
    Friend WithEvents btn20add As Button
    Friend WithEvents btn20min As Button
    Friend WithEvents txt10 As TextBox
    Friend WithEvents btn10add As Button
    Friend WithEvents btn10min As Button
    Friend WithEvents txt5000 As TextBox
    Friend WithEvents btn5000add As Button
    Friend WithEvents btn5000min As Button
    Friend WithEvents txt2000 As TextBox
    Friend WithEvents btn2000add As Button
    Friend WithEvents btn2000min As Button
    Friend WithEvents txt1000 As TextBox
    Friend WithEvents btn1000add As Button
    Friend WithEvents btn1000min As Button
    Friend WithEvents txt500 As TextBox
    Friend WithEvents btn500add As Button
    Friend WithEvents btn500min As Button
    Friend WithEvents txt100 As TextBox
    Friend WithEvents btn100add As Button
    Friend WithEvents btn100min As Button
    Friend WithEvents lbl50 As Label
    Friend WithEvents lbl20 As Label
    Friend WithEvents lbl10 As Label
    Friend WithEvents lbl5000 As Label
    Friend WithEvents lbl2000 As Label
    Friend WithEvents lbl1000 As Label
    Friend WithEvents lbl500 As Label
    Friend WithEvents lbl100 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents lblCustID As Label
    Friend WithEvents itemBox As ListBox
End Class
