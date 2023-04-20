Imports MySql.Data.MySqlClient
Imports System.IO
Imports MessagingToolkit.Barcode
Public Class frm_ManageProduct

    Private Sub frm_ManageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        DataGridView1.RowTemplate.Height = 30
        load_ProductGroup()
        load_product()
    End Sub
    Private Sub btn_AddGroup_Click(sender As Object, e As EventArgs) Handles btn_AddGroup.Click
        frm_addGroup.ShowDialog()
    End Sub
    Sub load_ProductGroup()
        cbo_group.Items.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tblgroup`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                cbo_group.Items.Add(dr.Item("progroup").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub load_product()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `procode`, `proname`, `progroup`, `uom`, `location`, `price`, `tax`, `totalprice`, `stock`, `barcode`  FROM 'tblproduct' group by procode", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("uom"), dr.Item("location"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"), dr.Item("stock"), dr.Item("barcode"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub clear()
        txt_location.Clear()
        txt_price.Clear()
        txt_procode.Clear()
        txt_proname.Clear()
        txt_totalprice.Clear()
        cbo_group.SelectedIndex = -1
        cbo_tax.SelectedIndex = -1
        cbo_uom.SelectedIndex = -1
        pic_barcode.Image = Nothing
    End Sub

    Private Sub txt_procode_TextChanged(sender As Object, e As EventArgs) Handles txt_procode.TextChanged
        'Barcode Generate
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White
        Try
            pic_barcode.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, txt_procode.Text))
        Catch ex As Exception
            pic_barcode.Image = Nothing
        End Try

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            conn.Open()

            'img convert to binary format
            Dim FileSize As UInt32
            Dim mstream As New System.IO.MemoryStream
            pic_barcode.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            FileSize = mstream.Length
            mstream.Close()

            cmd = New MySqlCommand("INSERT INTO `tblproduct`( `procode`, `proname`, `progroup`, `uom`, `location`, `price`, `tax`, `totalprice`,  `barcode`) VALUES (@procode,@proname,@progroup,@uom,@location,@price,@tax,@totalprice,@barcode)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@procode", txt_procode.Text)
            cmd.Parameters.AddWithValue("@proname", txt_proname.Text)
            cmd.Parameters.AddWithValue("@progroup", cbo_group.Text)
            cmd.Parameters.AddWithValue("@uom", cbo_uom.Text)
            cmd.Parameters.AddWithValue("@location", txt_location.Text)
            cmd.Parameters.AddWithValue("@price", CDec(txt_price.Text))
            cmd.Parameters.AddWithValue("@tax", CDec(cbo_tax.Text))
            cmd.Parameters.AddWithValue("@totalprice", CDec(txt_totalprice.Text))
            cmd.Parameters.AddWithValue("@barcode", arrImage)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Product Added Successfully!", vbInformation)
            Else
                MsgBox("New Product Save Failed!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
        load_product()

    End Sub

    Private Sub cbo_tax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tax.SelectedIndexChanged
        Try
            txt_totalprice.Text = CDec(txt_price.Text * cbo_tax.Text / 100) + txt_price.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        'Search Product
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM 'tblproduct' WHERE procode like '%" & txt_Search.Text & "%' or proname like '%" & txt_Search.Text & "%' or progroup like '%" & txt_Search.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("uom"), dr.Item("location"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"), dr.Item("stock"), dr.Item("barcode"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        txt_procode.ReadOnly = True
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `procode`, `proname`, `progroup`, `uom`, `location`, `price`, `tax`, `totalprice`, `stock`, `barcode`  FROM 'tblproduct' WHERE procode like '%" & txt_SearchProcode.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                txt_procode.Text = dr.Item("procode")
                txt_proname.Text = dr.Item("proname")
                cbo_group.Text = dr.Item("progroup")
                cbo_uom.Text = dr.Item("uom")
                txt_location.Text = dr.Item("location")
                txt_price.Text = dr.Item("price")
                cbo_tax.Text = dr.Item("tax")
                txt_totalprice.Text = dr.Item("totalprice")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE `tblproduct` SET `proname`=@proname,`progroup`=@progroup,`uom`=@uom,`location`=@location,`price`=@price,`tax`=@tax,`totalprice`=@totalprice WHERE `procode`=@procode", conn)

            cmd.Parameters.AddWithValue("@proname", txt_proname.Text)
            cmd.Parameters.AddWithValue("@progroup", cbo_group.Text)
            cmd.Parameters.AddWithValue("@uom", cbo_uom.Text)
            cmd.Parameters.AddWithValue("@location", txt_location.Text)
            cmd.Parameters.AddWithValue("@price", CDec(txt_price.Text))
            cmd.Parameters.AddWithValue("@tax", CDec(cbo_tax.Text))
            cmd.Parameters.AddWithValue("@totalprice", CDec(txt_totalprice.Text))
            cmd.Parameters.AddWithValue("@procode", txt_procode.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Product Updated Successfully!", vbInformation)
            Else
                MsgBox("Product Update Failed!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
        txt_SearchProcode.Clear()
        load_product()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Are You Sure You Want To Delete This Product", vbExclamation + vbYesNo) = vbYes Then
            Try
                conn.Open()
                cmd = New MySqlCommand("DELETE FROM `tblproduct` WHERE `procode`=@procode", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@procode", txt_procode.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Product Delete Successfully!", vbInformation)
                Else
                    MsgBox("Product Delete Failed!", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            clear()
            txt_SearchProcode.Clear()
            load_product()
        Else
            Return
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
        txt_SearchProcode.Clear()
    End Sub
End Class