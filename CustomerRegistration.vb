Imports System.Data.SqlClient
Public Class CustomerRegistration
    Dim connection As New SqlConnection("Server = CHEEHIINDECOMP; Database = APU_Cafeteria; Integrated security = True")
    Public Property StaffID2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStaff.Text = "Staff ID : " & StaffLogin.txtStaff.Text
        Dim ID As String = "SELECT CustomerID FROM CUSTOMER_T ORDER BY CustomerID DESC"
        Dim command As SqlCommand = New SqlCommand(ID, connection)
        Dim adapter As New SqlDataAdapter
        connection.Open()
        Dim dbs As New DataTable
        adapter.SelectCommand = command
        adapter.Fill(dbs)
        txtCustno.Text = (dbs.Rows(0)(0) + 1)
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CustomerLogin.Show()
        CustomerLogin.txtCustno.Text = ""
        CustomerLogin.lblStaff.Text = "Staff ID : " & StaffLogin.txtStaff.Text
        Me.Hide()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim create As New SqlCommand("INSERT INTO CUSTOMER_T(CustomerID, Name, Gender, TelNum, Address) VALUES('" & txtCustno.Text & "', '" & txtName.Text & "', '" & cboGender.Text & "', '" & txtTelNum.Text & "', '" & txtAddress.Text & "')", connection)
        If txtName.Text = "" Then
            MsgBox("Please Insert Your Name.")
        ElseIf cboGender.Text = "" Then
            MsgBox("Please Select Your Gender.")
        ElseIf txtTelNum.Text = "" Then
            MsgBox("Please Insert Your Telephone Number.")
        ElseIf txtAddress.Text = "" Then
            MsgBox("Please Insert Your Address.")
        Else
            create.ExecuteNonQuery()
            MsgBox("Registered Successfully!")
            btnSubmit.Enabled = False
            txtAddress.Enabled = False
            txtTelNum.Enabled = False
            cboGender.Enabled = False
            txtName.Enabled = False
            txtCustno.Enabled = False
            connection.Close()
        End If
    End Sub
End Class