Imports System.Diagnostics.Eventing.Reader
Imports MySql.Data.MySqlClient

Public Class frm_mainCashier

    Private Sub frm_mainCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        txt_searchProduct_barcode.Focus()
        total()
        btn_Pay.Enabled = False
        load_discount()

        txt_billno.Text = Getbillno()

    End Sub

    Public Sub ADDLIST()
        Dim exist As Boolean = False, numrow As Integer = 0, numtext As Integer
        For Each itm As DataGridViewRow In DataGridView1.Rows
            If itm.Cells(0).Value IsNot Nothing Then
                If itm.Cells(1).Value.ToString = txt_searchProduct_barcode.Text Then
                    exist = True
                    numrow = itm.Index
                    numtext = CInt(itm.Cells(8).Value)
                    Exit For
                End If
            End If
        Next
        If exist = False Then
            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM `tblproduct` WHERE `procode`='" & txt_searchProduct_barcode.Text & "'", conn)
                dr = cmd.ExecuteReader
                While dr.Read()
                    If txt_searchProduct_barcode.Text = String.Empty Then
                        Return
                    Else
                        'create new row
                        '`procode`, `proname`, `progroup`, `uom`, `location`, `price`, `tax`, `totalprice`
                        Dim procode As String = dr.Item("procode")
                        Dim proname As String = dr.Item("proname")
                        Dim progroup As String = dr.Item("progroup")
                        Dim uom As String = dr.Item("uom")
                        Dim location As String = dr.Item("location")
                        Dim price As Decimal = dr.Item("price")
                        Dim tax As Decimal = dr.Item("tax")
                        Dim totalprice As Decimal = dr.Item("totalprice")

                        Dim totalqtyprice As New Decimal
                        totalqtyprice = price * tax / 100 + price

                        DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, procode, proname, progroup, uom, location, price, tax, totalprice, 1, totalqtyprice)

                        txt_searchProduct_barcode.Clear()
                        txt_searchProduct_barcode.Focus()

                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()

            End Try
        Else
            DataGridView1.Rows(numrow).Cells(8).Value = CInt("1") + numtext
            DataGridView1.Rows(numrow).Cells(9).Value = DataGridView1.Rows(numrow).Cells(7).Value * DataGridView1.Rows(numrow).Cells(8).Value

        End If

    End Sub

    Private Sub txt_searchProduct_barcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_searchProduct_barcode.KeyDown
        If txt_searchProduct_barcode.Text = Nothing Then
        Else
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                ADDLIST()

                txt_searchProduct_barcode.Clear()
                txt_searchProduct_barcode.Focus()
            End If
        End If
    End Sub

    Public Sub total()
        lbl_NoOfItems.Text = DataGridView1.Rows.Count - 1 + 1

        Dim sum As Double = 0
        Dim subtotal As Double = 0
        Dim tax As Double = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(9).Value
            tax = tax + DataGridView1.Rows(i).Cells(5).Value * DataGridView1.Rows(i).Cells(6).Value / 100 * DataGridView1.Rows(i).Cells(8).Value
            subtotal = subtotal + DataGridView1.Rows(i).Cells(5).Value * DataGridView1.Rows(i).Cells(8).Value

        Next
        Try
            lbl_subtotalPrice.Text = Format(CDec(subtotal), "#,##0.00")
            lbl_TotalTax.Text = Format(CDec(tax), "#,##0.00")
            lbl_totalPrice.Text = Format(CDec(subtotal + tax), "#,##0.00")
            lbl_discount.Text = Format(CDec(txt_discount.Text * lbl_totalPrice.Text / 100), "#,##0.00")
            lbl_GrandTotal.Text = Format(CDec(lbl_totalPrice.Text - lbl_discount.Text), "#,##0.00")


            lbl_OverAllGrandTotal.Text = Format(CDec(lbl_OverAllGrandTotal.Text), "#,##0.00")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        total()
    End Sub

    Private Sub txt_AmountReceived_TextChanged(sender As Object, e As EventArgs) Handles txt_AmountReceived.TextChanged
        Try
            lbl_Change.Text = Format(CDec(txt_AmountReceived.Text - lbl_GrandTotal.Text), "#,##0.00")
        Catch ex As Exception

        End Try
        btn_Pay.Enabled = True

    End Sub

    Sub load_discount()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM 'tbldiscount'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                txt_discount.Text = dr.Item("discount")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_setDiscount_Click(sender As Object, e As EventArgs) Handles btn_setDiscount.Click
        frm_discount.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
        lbl_date.Text = Date.Now.ToString("dd-MMMM-yyyy dddd")

    End Sub
    Sub Save_bill()
        If cbo_payMode.Text = String.Empty Then
            MsgBox("Please Select a Payment Mode!", vbInformation)
            Return
        ElseIf txt_AmountReceived.Text = String.Empty Then
            MsgBox("Please Enter Recieved Amount!", vbInformation)
            Return
        ElseIf lbl_GrandTotal.Text > txt_AmountReceived.Text Then
            MsgBox("Infinity Balance!", vbExclamation)
            Return
        Else
            Try
                conn.Open()
                For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                    cmd = New MySqlCommand("INSERT INTO `tbl_pos`(`billno`, `billdate`, `bmonth`, `bmonthyear`, `procode`, `proname`, `progroup`, `uom`, `price`, `tax`, `totalproductprice`, `qty`, `totalpriceqty`, `subtotal`, `totaltax`, `discount`, `grandtotal`, `paymode`, `receiveamount`, `balance`) VALUES (@billno, @billdate, @bmonth, @bmonthyear, @procode, @proname, @progroup, @uom, @price, @tax, @totalproductprice, @qty, @totalpriceqty, @subtotal, @totaltax, @discount, @grandtotal, @paymode, @receiveamount, @balance)", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@billno", txt_billno.Text)
                    cmd.Parameters.AddWithValue("@billdate", CDate(btp_billdate.Text))
                    cmd.Parameters.AddWithValue("@bmonth", Date.Now.ToString("MM"))
                    cmd.Parameters.AddWithValue("@bmonthyear", Date.Now.ToString("MMMM-yyyy"))

                    cmd.Parameters.AddWithValue("@procode", DataGridView1.Rows(j).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@proname", DataGridView1.Rows(j).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@progroup", DataGridView1.Rows(j).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@uom", DataGridView1.Rows(j).Cells(4).Value)
                    cmd.Parameters.AddWithValue("@price", DataGridView1.Rows(j).Cells(5).Value)
                    cmd.Parameters.AddWithValue("@tax", DataGridView1.Rows(j).Cells(6).Value)
                    cmd.Parameters.AddWithValue("@totalproductprice", DataGridView1.Rows(j).Cells(7).Value)
                    cmd.Parameters.AddWithValue("@qty", DataGridView1.Rows(j).Cells(8).Value)
                    cmd.Parameters.AddWithValue("@totalpriceqty", DataGridView1.Rows(j).Cells(9).Value)


                    cmd.Parameters.AddWithValue("@subtotal", lbl_subtotalPrice.Text)
                    cmd.Parameters.AddWithValue("@totaltax", lbl_TotalTax.Text)
                    cmd.Parameters.AddWithValue("@totalprice", lbl_totalPrice.Text)
                    cmd.Parameters.AddWithValue("@discount", lbl_discount.Text)
                    cmd.Parameters.AddWithValue("@grandtotal", lbl_GrandTotal.Text)
                    cmd.Parameters.AddWithValue("@paymode", cbo_payMode.Text)
                    cmd.Parameters.AddWithValue("@receiveamount", txt_AmountReceived.Text)
                    cmd.Parameters.AddWithValue("@balance", lbl_Change.Text)

                    i = cmd.ExecuteNonQuery
                Next
                If i > 0 Then
                    MsgBox("New Transaction Save Success!" & vbNewLine & "Bill no:" & txt_billno.Text, vbInformation)
                    Clear()
                Else
                    MsgBox("Last Transaction Failed!", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            txt_billno.Text = Getbillno()
        End If
        Try
            conn.Open()
            For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                cmd = New MySqlCommand("INSERT INTO `tbl_pos`(`billno`, `billdate`, `bmonth`, `bmonthyear`, `procode`, `proname`, `progroup`, `uom`, `price`, `tax`, `totalproductprice`, `qty`, `totalpriceqty`, `subtotal`, `totaltax`, `discount`, `grandtotal`, `paymode`, `receiveamount`, `balance`) VALUES (@billno, @billdate, @bmonth, @bmonthyear, @procode, @proname, @progroup, @uom, @price, @tax, @totalproductprice, @qty, @totalpriceqty, @subtotal, @totaltax, @discount, @grandtotal, @paymode, @receiveamount, @balance)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@billno", txt_billno.Text)
                cmd.Parameters.AddWithValue("@billdate", CDate(btp_billdate.Text))
                cmd.Parameters.AddWithValue("@bmonth", CDate(Date.Now.ToString("MM")))
                cmd.Parameters.AddWithValue("@bmonthyear", CDate(Date.Now.ToString("MMMM-yyyy")))

                cmd.Parameters.AddWithValue("@procode", DataGridView1.Rows(j).Cells(1).Value)
                cmd.Parameters.AddWithValue("@proname", DataGridView1.Rows(j).Cells(1).Value)
                cmd.Parameters.AddWithValue("@progroup", DataGridView1.Rows(j).Cells(1).Value)
                cmd.Parameters.AddWithValue("@uom", DataGridView1.Rows(j).Cells(1).Value)
                cmd.Parameters.AddWithValue("@price", DataGridView1.Rows(j).Cells(1).Value)
                cmd.Parameters.AddWithValue("@tax", DataGridView1.Rows(j).Cells(1).Value)
                cmd.Parameters.AddWithValue("@totalproductprice", DataGridView1.Rows(j).Cells(1).Value)
                cmd.Parameters.AddWithValue("@qty", DataGridView1.Rows(j).Cells(1).Value)
                cmd.Parameters.AddWithValue("@totalpriceqty", DataGridView1.Rows(j).Cells(1).Value)


                cmd.Parameters.AddWithValue("@subtotal", lbl_subtotalPrice.Text)
                cmd.Parameters.AddWithValue("@totaltax", lbl_TotalTax.Text)
                cmd.Parameters.AddWithValue("@totalprice", lbl_totalPrice.Text)
                cmd.Parameters.AddWithValue("@discount", lbl_discount.Text)
                cmd.Parameters.AddWithValue("@grandtotal", lbl_GrandTotal.Text)
                cmd.Parameters.AddWithValue("@paymode", cbo_payMode.Text)
                cmd.Parameters.AddWithValue("@receiveamount", txt_AmountReceived.Text)
                cmd.Parameters.AddWithValue("@balance", lbl_Change.Text)

                i = cmd.ExecuteNonQuery
            Next
            If i > 0 Then
                MsgBox("New Transaction Save Success!" & vbNewLine & "Bill no:" & txt_billno.Text, vbInformation)
            Else
                MsgBox("Last Transaction Failed!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub


    Sub Clear()

        btp_billdate.Text = Now
        txt_searchProduct_barcode.Clear()
        DataGridView1.Rows.Clear()
        lbl_Change.Text = "0.00"
        lbl_discount.Text = "0.00"
        lbl_GrandTotal.Text = "0.00"
        lbl_NoOfItems.Text = "0"
        lbl_OverAllGrandTotal.Text = "0.00"
        lbl_subtotalPrice.Text = "0.00"
        lbl_totalPrice.Text = "0.00"
        lbl_TotalTax.Text = "0.00"
        cbo_payMode.SelectedIndex = -1
        txt_AmountReceived.Clear()

    End Sub
    Private Sub btn_Pay_Click(sender As Object, e As EventArgs) Handles btn_Pay.Click
        Save_bill()
        txt_searchProduct_barcode.Focus()
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Clear()
        txt_billno.Text = Getbillno()
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        DataGridView1.Rows.Remove(DataGridView1.SelectedRows.Item(0))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_ChangePassword.ShowDialog()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        frm_login.ShowDialog()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        frm_CancleOrder.ShowDialog()
    End Sub
End Class