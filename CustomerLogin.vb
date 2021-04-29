Imports System.Data.SqlClient
Public Class CustomerLogin
    Public Property StaffID As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        StaffLogin.Show()
        StaffLogin.txtPassword.Text = ""
        Me.Hide()
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim f2 As New CustomerRegistration
        f2.StaffID2 = StaffID
        f2.Show()
        Me.Hide()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connection As New SqlConnection("Server = CHEEHIINDECOMP; Database = APU_Cafeteria; Integrated security = True")
        Dim command As New SqlCommand("select * from CUSTOMER_T where CustomerID = @CustomerID", connection)
        command.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = txtCustno.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Invalid Customer ID", "Try Again")
        Else
            Dim f3 As New CafeteriaMenu
            f3.CustID = txtCustno.Text
            MessageBox.Show("Welcome, " & table.Rows(0)(1) & "!", "Welcome!")
            f3.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStaff.Text = "Staff ID : " & StaffID
    End Sub
End Class