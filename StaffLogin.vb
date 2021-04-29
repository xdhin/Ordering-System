Imports System.Data.SqlClient
Public Class StaffLogin
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.UseSystemPasswordChar = True
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connection As New SqlConnection("Server = CHEEHIINDECOMP; Database = APU_Cafeteria; Integrated security = True")
        Dim command As New SqlCommand("select * from STAFFID_T where StaffID = @StaffID and Password = @Password", connection)
        command.Parameters.Add("@StaffID", SqlDbType.VarChar).Value = txtStaff.Text
        command.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtPassword.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If txtStaff.Text = "" Then
            MessageBox.Show("Please enter your Staff ID.", "Try Again")
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please enter your Password.", "Try Again")
        Else
            If table.Rows.Count() <= 0 Then
                MessageBox.Show("Invalid ID or Password", "Try Again")
            Else
                Dim ID As New CustomerLogin
                MessageBox.Show("Welcome Back, " & table.Rows(0)(1) & "!", "Welcome")
                ID.StaffID = txtStaff.Text
                ID.Show()
                Me.Hide()
            End If
        End If
    End Sub


    Private Sub ckbPass_CheckedChanged(sender As Object, e As EventArgs) Handles ckbPass.CheckedChanged
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
