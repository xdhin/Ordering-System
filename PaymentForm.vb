Imports System.Data.SqlClient
Public Class PaymentForm
    Public Property final As String
    Public Property custID As String
    Public Property item As Integer
    Public Property F1 As Integer
    Public Property F2 As Integer
    Public Property F3 As Integer
    Public Property F4 As Integer
    Public Property F5 As Integer
    Public Property F6 As Integer
    Public Property F7 As Integer
    Public Property B1 As Integer
    Public Property B2 As Integer
    Public Property B3 As Integer
    Public Property B4 As Integer
    Public Property B5 As Integer
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        CafeteriaMenu.Show()
        Me.Hide()
    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim note, coin, totalmoney As Double
        note = (txt100.Text * 1) + (txt500.Text * 5) + (txt1000.Text * 10) + (txt2000.Text * 20) + (txt5000.Text * 50)
        coin = (txt10.Text * 0.1) + (txt20.Text * 0.2) + (txt50.Text * 0.5)
        totalmoney = (note + coin)
        txtMoney.Text = "RM" & Format(Val(totalmoney), "0.00")
        Dim change, cmoney As Double
        change = final.Remove(0, 2)
        cmoney = totalmoney - change
        txtChange.Text = "RM" & Format((cmoney), "0.00")
        Dim pay, money As Double
        pay = txtAmount.Text.Remove(0, 2)
        money = txtMoney.Text.Remove(0, 2)
        If money >= pay Then
            btnPay.Enabled = True
        Else
            btnPay.Enabled = False
        End If
    End Sub
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim connection As New SqlConnection("Server = CHEEHIINDECOMP; Database = APU_Cafeteria; Integrated security = True")
        Dim ID As String = "SELECT OrderID FROM ORDER_T ORDER BY OrderID DESC"
        Dim command As SqlCommand = New SqlCommand(ID, connection)
        Dim adapter As New SqlDataAdapter
        Dim todayDate As Date
        todayDate = Today
        Dim time As Date
        time = TimeOfDay
        connection.Open()
        Dim dbs As New DataTable
        Dim orderID As String
        adapter.SelectCommand = command
        adapter.Fill(dbs)
        orderID = (dbs.Rows(0)(0) + 1)
        Dim order As New SqlCommand("INSERT INTO ORDER_T (OrderID, StaffID, Item_F1, Item_F2, Item_F3, Item_F4, Item_F5, Item_F6, Item_F7, Item_B1, Item_B2, Item_B3, Item_B4, Item_B5, Total_Item) VALUES('" & orderID & "', '" & StaffLogin.txtStaff.Text & "','" & F1 & "', '" & F2 & "' , '" & F3 & "' , '" & F4 & "' , '" & F5 & "' , '" & F6 & "' , '" & F7 & "' , '" & B1 & "' , '" & B2 & "' , '" & B3 & "' , '" & B4 & "' , '" & B5 & "' ,'" & item & "')", connection)
        Dim payment As New SqlCommand("INSERT INTO PAYMENT_T (OrderID, Date, CustomerID, Amount, Time) VALUES('" & orderID & "',  '" & todayDate & " ', '" & custID & " ',  '" & txtAmount.Text & " ', '" & time & "')", connection)
        order.ExecuteNonQuery()
        payment.ExecuteNonQuery()
        MessageBox.Show("Ordered Succesfully, Thank you very much!!", "Thank You!")
        CustomerLogin.Show()
        CustomerLogin.lblStaff.Text = "Staff ID : " & StaffLogin.txtStaff.Text
        CustomerLogin.txtCustno.Text = ""
        Me.Hide()
    End Sub
    Private Sub btn100min_Click(sender As Object, e As EventArgs) Handles btn100min.Click
        txt100.Text = txt100.Text - 1
    End Sub
    Private Sub btn100add_Click(sender As Object, e As EventArgs) Handles btn100add.Click
        txt100.Text = txt100.Text + 1
    End Sub
    Private Sub btn500min_Click(sender As Object, e As EventArgs) Handles btn500min.Click
        txt500.Text = txt500.Text - 1
    End Sub
    Private Sub btn500add_Click(sender As Object, e As EventArgs) Handles btn500add.Click
        txt500.Text = txt500.Text + 1
    End Sub
    Private Sub btn1000min_Click(sender As Object, e As EventArgs) Handles btn1000min.Click
        txt1000.Text = txt1000.Text - 1
    End Sub
    Private Sub btn1000add_Click(sender As Object, e As EventArgs) Handles btn1000add.Click
        txt1000.Text = txt1000.Text + 1
    End Sub
    Private Sub btn2000min_Click(sender As Object, e As EventArgs) Handles btn2000min.Click
        txt2000.Text = txt2000.Text - 1
    End Sub
    Private Sub btn2000add_Click(sender As Object, e As EventArgs) Handles btn2000add.Click
        txt2000.Text = txt2000.Text + 1
    End Sub
    Private Sub btn5000min_Click(sender As Object, e As EventArgs) Handles btn5000min.Click
        txt5000.Text = txt5000.Text - 1
    End Sub
    Private Sub btn5000add_Click(sender As Object, e As EventArgs) Handles btn5000add.Click
        txt5000.Text = txt5000.Text + 1
    End Sub
    Private Sub btn10min_Click(sender As Object, e As EventArgs) Handles btn10min.Click
        txt10.Text = txt10.Text - 1
    End Sub
    Private Sub btn10add_Click(sender As Object, e As EventArgs) Handles btn10add.Click
        txt10.Text = txt10.Text + 1
    End Sub
    Private Sub btn20min_Click(sender As Object, e As EventArgs) Handles btn20min.Click
        txt20.Text = txt20.Text - 1
    End Sub
    Private Sub btn20add_Click(sender As Object, e As EventArgs) Handles btn20add.Click
        txt20.Text = txt20.Text + 1
    End Sub
    Private Sub btn50min_Click(sender As Object, e As EventArgs) Handles btn50min.Click
        txt50.Text = txt50.Text - 1
    End Sub
    Private Sub btn50add_Click(sender As Object, e As EventArgs) Handles btn50add.Click
        txt50.Text = txt50.Text + 1
    End Sub


    Private Sub txt100_TextChanged(sender As Object, e As EventArgs) Handles txt100.TextChanged
        If txt100.Text = 0 Then
            btn100min.Enabled = False
        Else
            btn100min.Enabled = True
        End If
    End Sub
    Private Sub txt500_TextChanged(sender As Object, e As EventArgs) Handles txt500.TextChanged
        If txt500.Text = 0 Then
            btn500min.Enabled = False
        Else
            btn500min.Enabled = True
        End If
    End Sub
    Private Sub txt1000_TextChanged(sender As Object, e As EventArgs) Handles txt1000.TextChanged
        If txt1000.Text = 0 Then
            btn1000min.Enabled = False
        Else
            btn1000min.Enabled = True
        End If
    End Sub
    Private Sub txt2000_TextChanged(sender As Object, e As EventArgs) Handles txt2000.TextChanged
        If txt2000.Text = 0 Then
            btn2000min.Enabled = False
        Else
            btn2000min.Enabled = True
        End If
    End Sub
    Private Sub txt5000_TextChanged(sender As Object, e As EventArgs) Handles txt5000.TextChanged
        If txt5000.Text = 0 Then
            btn5000min.Enabled = False
        Else
            btn5000min.Enabled = True
        End If
    End Sub
    Private Sub txt10_TextChanged(sender As Object, e As EventArgs) Handles txt10.TextChanged
        If txt10.Text = 0 Then
            btn10min.Enabled = False
        Else
            btn10min.Enabled = True
        End If
    End Sub
    Private Sub txt20_TextChanged(sender As Object, e As EventArgs) Handles txt20.TextChanged
        If txt20.Text = 0 Then
            btn20min.Enabled = False
        Else
            btn20min.Enabled = True
        End If
    End Sub
    Private Sub txt50_TextChanged(sender As Object, e As EventArgs) Handles txt50.TextChanged
        If txt50.Text = 0 Then
            btn50min.Enabled = False
        Else
            btn50min.Enabled = True
        End If
    End Sub


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAmount.Text = final
        btnPay.Enabled = False
        lblCustID.Text = "Customer ID : " & custID
    End Sub
End Class