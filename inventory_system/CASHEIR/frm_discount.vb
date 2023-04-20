Imports MySql.Data.MySqlClient

Public Class frm_discount
    Private Sub frm_discount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

    End Sub
    Private Sub btn_updatediscount_Click(sender As Object, e As EventArgs) Handles btn_updatediscount.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE `tbldiscount` SET `discount`=@discount WHERE `disid`=@disid", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@discount", txt_discount.Text)
            cmd.Parameters.AddWithValue("@disid", "1001")
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Disount Update Success!", vbInformation)
            Else
                MsgBox("Disount Update Failed!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        txt_discount.Clear()
        frm_mainCashier.load_discount()
    End Sub
End Class