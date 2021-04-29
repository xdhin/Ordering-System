Imports System.Data.SqlClient
Public Class CafeteriaMenu
    Public Property CustID As String
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Dim f5 As New CustomerLogin
        f5.Show()
        f5.lblStaff.Text = "Staff ID : " & StaffLogin.txtStaff.Text
        Me.Hide()
    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim item As Integer
        item = Val(txtF1.Text) + Val(txtF2.Text) + Val(txtF3.Text) + Val(txtF4.Text) + Val(txtF5.Text) + Val(txtF6.Text) + Val(txtF7.Text) + Val(txtB1.Text) + Val(txtB2.Text) + Val(txtB3.Text) + Val(txtB4.Text) + Val(txtB5.Text)
        txtItem.Text = item
        Dim ftotal, btotal, alltotal As Double
        ftotal = (txtF1.Text * 3.0) + (txtF2.Text * 1.5) + (txtF3.Text * 4.0) + (txtF4.Text * 4.0) + (txtF5.Text * 3.0) + (txtF6.Text * 8.0) + (txtF7.Text * 3.5)
        btotal = (txtB1.Text * 2.5) + (txtB2.Text * 1.8) + (txtB3.Text * 3.0) + (txtB4.Text * 2.5) + (txtB5.Text * 1.5)
        alltotal = (ftotal + btotal)
        txtTotal.Text = "RM" & Format(Val(alltotal), "0.00")
        Dim tax As Double
        tax = ((alltotal) * 0.1)
        txtTax.Text = "RM" & Format(Val(tax), "0.00")
        Dim amount As Double
        amount = alltotal + tax
        txtAmount.Text = "RM" & Format(Val(amount), "0.00")
        Dim rounding As Double
        rounding = Math.Round(Val(amount), 1)
        txtRounding.Text = "RM" & Format(Val(rounding), "0.00")
    End Sub
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim f4 As New PaymentForm
        If txtF1.Text > 0 Then
            f4.itemBox.Items.Add(lblF1.Text & vbTab & "x" & txtF1.Text & vbTab & "= RM" & Format(3 * txtF1.Text, "0.00"))
        End If
        If txtF2.Text > 0 Then
            f4.itemBox.Items.Add(lblF2.Text & vbTab & "x" & txtF2.Text & vbTab & "= RM" & Format(1.5 * txtF2.Text, "0.00"))
        End If
        If txtF3.Text > 0 Then
            f4.itemBox.Items.Add(lblF3.Text & vbTab & "x" & txtF3.Text & vbTab & "= RM" & Format(4 * txtF3.Text, "0.00"))
        End If
        If txtF4.Text > 0 Then
            f4.itemBox.Items.Add(lblF4.Text & vbTab & "x" & txtF4.Text & vbTab & "= RM" & Format(4 * txtF4.Text, "0.00"))
        End If
        If txtF5.Text > 0 Then
            f4.itemBox.Items.Add(lblF5.Text & vbTab & "x" & txtF5.Text & vbTab & "= RM" & Format(3 * txtF5.Text, "0.00"))
        End If
        If txtF6.Text > 0 Then
            f4.itemBox.Items.Add(lblF6.Text & vbTab & "x" & txtF6.Text & vbTab & "= RM" & Format(8 * txtF6.Text, "0.00"))
        End If
        If txtF7.Text > 0 Then
            f4.itemBox.Items.Add(lblF7.Text & "  " & vbTab & "x" & txtF7.Text & vbTab & "= RM" & Format(3.5 * txtF7.Text, "0.00"))
        End If
        If txtB1.Text > 0 Then
            f4.itemBox.Items.Add(lblB1.Text & " x" & txtB1.Text & "   " & vbTab & "= RM" & Format(2.5 * txtB1.Text, "0.00"))
        End If
        If txtB2.Text > 0 Then
            f4.itemBox.Items.Add(lblB2.Text & " x" & txtB2.Text & "   " & vbTab & "= RM" & Format(1.8 * txtB2.Text, "0.00"))
        End If
        If txtB3.Text > 0 Then
            f4.itemBox.Items.Add(lblB3.Text & " x" & txtB3.Text & "   " & vbTab & "= RM" & Format(3 * txtB3.Text, "0.00"))
        End If
        If txtB4.Text > 0 Then
            f4.itemBox.Items.Add(lblB4.Text & vbTab & " x" & txtB4.Text & "   " & vbTab & "= RM" & Format(2.5 * txtB4.Text, "0.00"))
        End If
        If txtB5.Text > 0 Then
            f4.itemBox.Items.Add(lblB5.Text & vbTab & " x" & txtB5.Text & "   " & vbTab & "= RM" & Format(1.5 * txtB5.Text, "0.00"))
        End If
        f4.itemBox.Items.Add("Service Tax(10%)" & vbTab & vbTab & vbTab & "= " & txtTax.Text)
        f4.itemBox.Items.Add("------------------------------------------------------------------------------------------")
        f4.itemBox.Items.Add("Total Amount" & vbTab & vbTab & vbTab & "   " & txtAmount.Text)
        f4.itemBox.Items.Add("Rounding" & vbTab & vbTab & vbTab & "   " & txtRounding.Text)
        f4.custID = CustID
        f4.item = txtItem.Text
        f4.final = txtRounding.Text
        f4.Show()
        f4.F1 = txtF1.Text
        f4.F2 = txtF2.Text
        f4.F3 = txtF3.Text
        f4.F4 = txtF4.Text
        f4.F5 = txtF5.Text
        f4.F6 = txtF6.Text
        f4.F7 = txtF7.Text
        f4.B1 = txtB1.Text
        f4.B2 = txtB2.Text
        f4.B3 = txtB3.Text
        f4.B4 = txtB4.Text
        f4.B5 = txtB5.Text
        Me.Hide()
    End Sub
    Private Sub btnF1min_Click(sender As Object, e As EventArgs) Handles btnF1min.Click
        txtF1.Text = txtF1.Text - 1
    End Sub
    Private Sub btnF1add_Click(sender As Object, e As EventArgs) Handles btnF1add.Click
        txtF1.Text = txtF1.Text + 1
    End Sub
    Private Sub btnF2min_Click(sender As Object, e As EventArgs) Handles btnF2min.Click
        txtF2.Text = txtF2.Text - 1
    End Sub
    Private Sub btnF2add_Click(sender As Object, e As EventArgs) Handles btnF2add.Click
        txtF2.Text = txtF2.Text + 1
    End Sub
    Private Sub btnF3min_Click(sender As Object, e As EventArgs) Handles btnF3min.Click
        txtF3.Text = txtF3.Text - 1
    End Sub
    Private Sub btnF3add_Click(sender As Object, e As EventArgs) Handles btnF3add.Click
        txtF3.Text = txtF3.Text + 1
    End Sub
    Private Sub btnF4min_Click(sender As Object, e As EventArgs) Handles btnF4min.Click
        txtF4.Text = txtF4.Text - 1
    End Sub
    Private Sub btnF4add_Click(sender As Object, e As EventArgs) Handles btnF4add.Click
        txtF4.Text = txtF4.Text + 1
    End Sub
    Private Sub btnF5min_Click(sender As Object, e As EventArgs) Handles btnF5min.Click
        txtF5.Text = txtF5.Text - 1
    End Sub
    Private Sub btnF5add_Click(sender As Object, e As EventArgs) Handles btnF5add.Click
        txtF5.Text = txtF5.Text + 1
    End Sub
    Private Sub btnF6min_Click(sender As Object, e As EventArgs) Handles btnF6min.Click
        txtF6.Text = txtF6.Text - 1
    End Sub
    Private Sub btnF6add_Click(sender As Object, e As EventArgs) Handles btnF6add.Click
        txtF6.Text = txtF6.Text + 1
    End Sub
    Private Sub btnF7min_Click(sender As Object, e As EventArgs) Handles btnF7min.Click
        txtF7.Text = txtF7.Text - 1
    End Sub
    Private Sub btnF7add_Click(sender As Object, e As EventArgs) Handles btnF7add.Click
        txtF7.Text = txtF7.Text + 1
    End Sub
    Private Sub btnB1min_Click(sender As Object, e As EventArgs) Handles btnB1min.Click
        txtB1.Text = txtB1.Text - 1
    End Sub
    Private Sub btnB1add_Click(sender As Object, e As EventArgs) Handles btnB1add.Click
        txtB1.Text = txtB1.Text + 1
    End Sub
    Private Sub btnB2min_Click(sender As Object, e As EventArgs) Handles btnB2min.Click
        txtB2.Text = txtB2.Text - 1
    End Sub
    Private Sub btnB2add_Click(sender As Object, e As EventArgs) Handles btnB2add.Click
        txtB2.Text = txtB2.Text + 1
    End Sub
    Private Sub btnB3min_Click(sender As Object, e As EventArgs) Handles btnB3min.Click
        txtB3.Text = txtB3.Text - 1
    End Sub
    Private Sub btnB3add_Click(sender As Object, e As EventArgs) Handles btnB3add.Click
        txtB3.Text = txtB3.Text + 1
    End Sub
    Private Sub btnB4min_Click(sender As Object, e As EventArgs) Handles btnB4min.Click
        txtB4.Text = txtB4.Text - 1
    End Sub
    Private Sub btnB4add_Click(sender As Object, e As EventArgs) Handles btnB4add.Click
        txtB4.Text = txtB4.Text + 1
    End Sub
    Private Sub btnB5min_Click(sender As Object, e As EventArgs) Handles btnB5min.Click
        txtB5.Text = txtB5.Text - 1
    End Sub
    Private Sub btnB5add_Click(sender As Object, e As EventArgs) Handles btnB5add.Click
        txtB5.Text = txtB5.Text + 1
    End Sub


    Private Sub txtF1_TextChanged(sender As Object, e As EventArgs) Handles txtF1.TextChanged
        If txtF1.Text = 0 Then
            btnF1min.Enabled = False
        Else
            btnF1min.Enabled = True
        End If
    End Sub
    Private Sub txtF2_TextChanged(sender As Object, e As EventArgs) Handles txtF2.TextChanged
        If txtF2.Text = 0 Then
            btnF2min.Enabled = False
        Else
            btnF2min.Enabled = True
        End If
    End Sub
    Private Sub txtF3_TextChanged(sender As Object, e As EventArgs) Handles txtF3.TextChanged
        If txtF3.Text = 0 Then
            btnF3min.Enabled = False
        Else
            btnF3min.Enabled = True
        End If
    End Sub
    Private Sub txtF4_TextChanged(sender As Object, e As EventArgs) Handles txtF4.TextChanged
        If txtF4.Text = 0 Then
            btnF4min.Enabled = False
        Else
            btnF4min.Enabled = True
        End If
    End Sub
    Private Sub txtF5_TextChanged(sender As Object, e As EventArgs) Handles txtF5.TextChanged
        If txtF5.Text = 0 Then
            btnF5min.Enabled = False
        Else
            btnF5min.Enabled = True
        End If
    End Sub
    Private Sub txtF6_TextChanged(sender As Object, e As EventArgs) Handles txtF6.TextChanged
        If txtF6.Text = 0 Then
            btnF6min.Enabled = False
        Else
            btnF6min.Enabled = True
        End If
    End Sub
    Private Sub txtF7_TextChanged(sender As Object, e As EventArgs) Handles txtF7.TextChanged
        If txtF7.Text = 0 Then
            btnF7min.Enabled = False
        Else
            btnF7min.Enabled = True
        End If
    End Sub
    Private Sub txtB1_TextChanged(sender As Object, e As EventArgs) Handles txtB1.TextChanged
        If txtB1.Text = 0 Then
            btnB1min.Enabled = False
        Else
            btnB1min.Enabled = True
        End If
    End Sub
    Private Sub txtB2_TextChanged(sender As Object, e As EventArgs) Handles txtB2.TextChanged
        If txtB2.Text = 0 Then
            btnB2min.Enabled = False
        Else
            btnB2min.Enabled = True
        End If
    End Sub
    Private Sub txtB3_TextChanged(sender As Object, e As EventArgs) Handles txtB3.TextChanged
        If txtB3.Text = 0 Then
            btnB3min.Enabled = False
        Else
            btnB3min.Enabled = True
        End If
    End Sub
    Private Sub txtB4_TextChanged(sender As Object, e As EventArgs) Handles txtB4.TextChanged
        If txtB4.Text = 0 Then
            btnB4min.Enabled = False
        Else
            btnB4min.Enabled = True
        End If
    End Sub
    Private Sub txtB5_TextChanged(sender As Object, e As EventArgs) Handles txtB5.TextChanged
        If txtB5.Text = 0 Then
            btnB5min.Enabled = False
        Else
            btnB5min.Enabled = True
        End If
    End Sub
    Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
        If txtItem.Text = 0 Then
            btnProceed.Enabled = False
        Else
            btnProceed.Enabled = True
        End If
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Server = CHEEHIINDECOMP; Database = APU_Cafeteria; Integrated security = True")
        Dim ID As String = "SELECT OrderID FROM ORDER_T ORDER BY OrderID DESC"
        Dim command As SqlCommand = New SqlCommand(ID, connection)
        Dim adapter As New SqlDataAdapter
        connection.Open()
        Dim dbs As New DataTable
        adapter.SelectCommand = command
        adapter.Fill(dbs)
        lblorder.Text = "OrderID : " & (dbs.Rows(0)(0) + 1)
    End Sub
End Class
