Imports MySql.Data.MySqlClient
Public Class frm_ChangePassword
    Private Sub frm_ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btn_ChangePassword_Click(sender As Object, e As EventArgs) Handles btn_ChangePassword.Click
        If txt_oldpassword.Text = String.Empty Then
            MsgBox("Please enter your old password!", vbExclamation)
            Return
        ElseIf txt_newpassword.Text = String.Empty Or txt_reenterpassword.Text = String.Empty Then
            MsgBox("Please enter your new password!", vbExclamation)
            Return
        ElseIf StrComp(txt_newpassword.Text, txt_reenterpassword.Text, CompareMethod.Binary) Then
            MsgBox("Password does not match!", vbExclamation)
            Return
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand("UPDATE `tbluser` SET `password`=@password WHERE `password`=@password1", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@password", txt_reenterpassword.Text)
                cmd.Parameters.AddWithValue("@password1", txt_oldpassword.Text)
                i = cmd.ExecuteNonQuery
                If i >= 0 Then
                    MsgBox("Password Change Successful!", vbInformation)
                Else
                    MsgBox("Password Change Failed!", vbExclamation)

                End If
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            conn.Close()
        End If
        txt_newpassword.Clear()
        txt_oldpassword.Clear()
        txt_reenterpassword.Clear()
        Me.Close()
        frm_login.Show()
    End Sub
End Class