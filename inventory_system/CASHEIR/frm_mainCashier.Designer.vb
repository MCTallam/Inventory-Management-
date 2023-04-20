<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainCashier
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        lbl_time = New Label()
        lbl_loginUser = New Label()
        lbl_logintime = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lbl_date = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        Label20 = New Label()
        btp_billdate = New DateTimePicker()
        txt_searchProduct_barcode = New TextBox()
        txt_billno = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Button1 = New Button()
        btn_logout = New Button()
        btn_report = New Button()
        btn_setDiscount = New Button()
        btn_cancel = New Button()
        btn_new = New Button()
        btn_remove = New Button()
        Panel3 = New Panel()
        lbl_subtotalPrice = New Label()
        Label8 = New Label()
        cbo_payMode = New ComboBox()
        txt_AmountReceived = New TextBox()
        lbl_Change = New Label()
        lbl_discount = New Label()
        lbl_GrandTotal = New Label()
        lbl_TotalTax = New Label()
        lbl_totalPrice = New Label()
        lbl_NoOfItems = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        txt_discount = New TextBox()
        Label12 = New Label()
        btn_Pay = New Button()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        lbl_OverAllGrandTotal = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lbl_time)
        Panel1.Controls.Add(lbl_loginUser)
        Panel1.Controls.Add(lbl_logintime)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1132, 58)
        Panel1.TabIndex = 0
        ' 
        ' lbl_time
        ' 
        lbl_time.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_time.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_time.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lbl_time.Location = New Point(799, 7)
        lbl_time.Name = "lbl_time"
        lbl_time.Size = New Size(330, 51)
        lbl_time.TabIndex = 30
        lbl_time.Text = "00.00"
        lbl_time.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_loginUser
        ' 
        lbl_loginUser.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_loginUser.AutoSize = True
        lbl_loginUser.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_loginUser.Location = New Point(645, 4)
        lbl_loginUser.Name = "lbl_loginUser"
        lbl_loginUser.Size = New Size(116, 17)
        lbl_loginUser.TabIndex = 3
        lbl_loginUser.Text = "Inventory System"' 
        ' lbl_logintime
        ' 
        lbl_logintime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_logintime.AutoSize = True
        lbl_logintime.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_logintime.Location = New Point(645, 34)
        lbl_logintime.Name = "lbl_logintime"
        lbl_logintime.Size = New Size(116, 17)
        lbl_logintime.TabIndex = 2
        lbl_logintime.Text = "Inventory System"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(43, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 17)
        Label2.TabIndex = 1
        Label2.Text = "Inventory System"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label1.Location = New Point(71, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 0
        Label1.Text = "P O S"' 
        ' lbl_date
        ' 
        lbl_date.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_date.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_date.ForeColor = Color.Cyan
        lbl_date.Location = New Point(799, 3)
        lbl_date.Name = "lbl_date"
        lbl_date.Size = New Size(330, 51)
        lbl_date.TabIndex = 31
        lbl_date.Text = "00.00"
        lbl_date.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(lbl_date)
        Panel2.Controls.Add(Label20)
        Panel2.Controls.Add(btp_billdate)
        Panel2.Controls.Add(txt_searchProduct_barcode)
        Panel2.Controls.Add(txt_billno)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 58)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1132, 97)
        Panel2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(12, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 17)
        Label3.TabIndex = 32
        Label3.Text = "Product/Barcode"' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.Location = New Point(34, 60)
        Label20.Name = "Label20"
        Label20.Size = New Size(0, 17)
        Label20.TabIndex = 10
        ' 
        ' btp_billdate
        ' 
        btp_billdate.Format = DateTimePickerFormat.Short
        btp_billdate.Location = New Point(490, 14)
        btp_billdate.Name = "btp_billdate"
        btp_billdate.Size = New Size(168, 25)
        btp_billdate.TabIndex = 9
        ' 
        ' txt_searchProduct_barcode
        ' 
        txt_searchProduct_barcode.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        txt_searchProduct_barcode.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_searchProduct_barcode.ForeColor = Color.Black
        txt_searchProduct_barcode.Location = New Point(130, 60)
        txt_searchProduct_barcode.Name = "txt_searchProduct_barcode"
        txt_searchProduct_barcode.Size = New Size(528, 25)
        txt_searchProduct_barcode.TabIndex = 8
        ' 
        ' txt_billno
        ' 
        txt_billno.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_billno.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        txt_billno.Location = New Point(130, 17)
        txt_billno.Name = "txt_billno"
        txt_billno.Size = New Size(243, 25)
        txt_billno.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(34, 51)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 17)
        Label7.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(424, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 17)
        Label6.TabIndex = 5
        Label6.Text = "Bill Date:"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(34, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 17)
        Label5.TabIndex = 4
        Label5.Text = "Bill NO:"' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 7
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.Controls.Add(Button1, 5, 0)
        TableLayoutPanel1.Controls.Add(btn_logout, 6, 0)
        TableLayoutPanel1.Controls.Add(btn_report, 3, 0)
        TableLayoutPanel1.Controls.Add(btn_setDiscount, 2, 0)
        TableLayoutPanel1.Controls.Add(btn_cancel, 1, 0)
        TableLayoutPanel1.Controls.Add(btn_new, 0, 0)
        TableLayoutPanel1.Controls.Add(btn_remove, 4, 0)
        TableLayoutPanel1.Dock = DockStyle.Bottom
        TableLayoutPanel1.Location = New Point(0, 610)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(1132, 56)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.HotTrack
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(808, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 50)
        Button1.TabIndex = 18
        Button1.Text = "[F6 - CHANGE PASSWORD]"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btn_logout
        ' 
        btn_logout.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btn_logout.Cursor = Cursors.Hand
        btn_logout.FlatAppearance.BorderSize = 0
        btn_logout.FlatStyle = FlatStyle.Flat
        btn_logout.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_logout.ForeColor = Color.White
        btn_logout.Location = New Point(969, 3)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(160, 50)
        btn_logout.TabIndex = 16
        btn_logout.Text = "[F7 - LOGOUT]"
        btn_logout.UseVisualStyleBackColor = False
        ' 
        ' btn_report
        ' 
        btn_report.BackColor = SystemColors.HotTrack
        btn_report.Cursor = Cursors.Hand
        btn_report.FlatAppearance.BorderSize = 0
        btn_report.FlatStyle = FlatStyle.Flat
        btn_report.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_report.ForeColor = Color.White
        btn_report.Location = New Point(486, 3)
        btn_report.Name = "btn_report"
        btn_report.Size = New Size(155, 50)
        btn_report.TabIndex = 13
        btn_report.Text = "[F4 - REPORT]"
        btn_report.UseVisualStyleBackColor = False
        ' 
        ' btn_setDiscount
        ' 
        btn_setDiscount.BackColor = SystemColors.HotTrack
        btn_setDiscount.Cursor = Cursors.Hand
        btn_setDiscount.FlatAppearance.BorderSize = 0
        btn_setDiscount.FlatStyle = FlatStyle.Flat
        btn_setDiscount.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_setDiscount.ForeColor = Color.White
        btn_setDiscount.Location = New Point(325, 3)
        btn_setDiscount.Name = "btn_setDiscount"
        btn_setDiscount.Size = New Size(155, 50)
        btn_setDiscount.TabIndex = 12
        btn_setDiscount.Text = "[F3 - SET DISCOUNT]"
        btn_setDiscount.UseVisualStyleBackColor = False
        ' 
        ' btn_cancel
        ' 
        btn_cancel.BackColor = SystemColors.HotTrack
        btn_cancel.Cursor = Cursors.Hand
        btn_cancel.FlatAppearance.BorderSize = 0
        btn_cancel.FlatStyle = FlatStyle.Flat
        btn_cancel.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_cancel.ForeColor = Color.White
        btn_cancel.Location = New Point(164, 3)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(155, 50)
        btn_cancel.TabIndex = 11
        btn_cancel.Text = "[F2 - CANCEL]"
        btn_cancel.UseVisualStyleBackColor = False
        ' 
        ' btn_new
        ' 
        btn_new.BackColor = SystemColors.HotTrack
        btn_new.Cursor = Cursors.Hand
        btn_new.FlatAppearance.BorderSize = 0
        btn_new.FlatStyle = FlatStyle.Flat
        btn_new.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_new.ForeColor = Color.White
        btn_new.Location = New Point(3, 3)
        btn_new.Name = "btn_new"
        btn_new.Size = New Size(155, 50)
        btn_new.TabIndex = 10
        btn_new.Text = "[F1 - NEW]"
        btn_new.UseVisualStyleBackColor = False
        ' 
        ' btn_remove
        ' 
        btn_remove.BackColor = SystemColors.HotTrack
        btn_remove.Cursor = Cursors.Hand
        btn_remove.FlatAppearance.BorderSize = 0
        btn_remove.FlatStyle = FlatStyle.Flat
        btn_remove.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_remove.ForeColor = Color.White
        btn_remove.Location = New Point(647, 3)
        btn_remove.Name = "btn_remove"
        btn_remove.Size = New Size(155, 50)
        btn_remove.TabIndex = 14
        btn_remove.Text = "[F5 - REMOVE]"
        btn_remove.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(lbl_subtotalPrice)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(cbo_payMode)
        Panel3.Controls.Add(txt_AmountReceived)
        Panel3.Controls.Add(lbl_Change)
        Panel3.Controls.Add(lbl_discount)
        Panel3.Controls.Add(lbl_GrandTotal)
        Panel3.Controls.Add(lbl_TotalTax)
        Panel3.Controls.Add(lbl_totalPrice)
        Panel3.Controls.Add(lbl_NoOfItems)
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(txt_discount)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(btn_Pay)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(lbl_OverAllGrandTotal)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(773, 155)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(359, 455)
        Panel3.TabIndex = 3
        ' 
        ' lbl_subtotalPrice
        ' 
        lbl_subtotalPrice.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_subtotalPrice.ForeColor = Color.Black
        lbl_subtotalPrice.Location = New Point(226, 116)
        lbl_subtotalPrice.Name = "lbl_subtotalPrice"
        lbl_subtotalPrice.Size = New Size(121, 27)
        lbl_subtotalPrice.TabIndex = 29
        lbl_subtotalPrice.Text = "00.00"
        lbl_subtotalPrice.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(37, 121)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 17)
        Label8.TabIndex = 28
        Label8.Text = "Sub Total"' 
        ' cbo_payMode
        ' 
        cbo_payMode.FormattingEnabled = True
        cbo_payMode.Items.AddRange(New Object() {"CASH", "M-PESA", "CREDIT CARD", "DEBIT CARD"})
        cbo_payMode.Location = New Point(175, 296)
        cbo_payMode.Name = "cbo_payMode"
        cbo_payMode.Size = New Size(172, 25)
        cbo_payMode.TabIndex = 27
        ' 
        ' txt_AmountReceived
        ' 
        txt_AmountReceived.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_AmountReceived.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        txt_AmountReceived.Location = New Point(175, 329)
        txt_AmountReceived.Name = "txt_AmountReceived"
        txt_AmountReceived.Size = New Size(172, 25)
        txt_AmountReceived.TabIndex = 26
        ' 
        ' lbl_Change
        ' 
        lbl_Change.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_Change.ForeColor = Color.Black
        lbl_Change.Location = New Point(226, 367)
        lbl_Change.Name = "lbl_Change"
        lbl_Change.Size = New Size(121, 27)
        lbl_Change.TabIndex = 25
        lbl_Change.Text = "00.00"
        lbl_Change.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_discount
        ' 
        lbl_discount.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_discount.ForeColor = Color.Black
        lbl_discount.Location = New Point(226, 223)
        lbl_discount.Name = "lbl_discount"
        lbl_discount.Size = New Size(121, 27)
        lbl_discount.TabIndex = 23
        lbl_discount.Text = "00.00"
        lbl_discount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_GrandTotal
        ' 
        lbl_GrandTotal.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_GrandTotal.ForeColor = Color.Red
        lbl_GrandTotal.Location = New Point(226, 253)
        lbl_GrandTotal.Name = "lbl_GrandTotal"
        lbl_GrandTotal.Size = New Size(121, 27)
        lbl_GrandTotal.TabIndex = 22
        lbl_GrandTotal.Text = "00.00"
        lbl_GrandTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_TotalTax
        ' 
        lbl_TotalTax.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_TotalTax.ForeColor = Color.Black
        lbl_TotalTax.Location = New Point(226, 182)
        lbl_TotalTax.Name = "lbl_TotalTax"
        lbl_TotalTax.Size = New Size(121, 27)
        lbl_TotalTax.TabIndex = 20
        lbl_TotalTax.Text = "00.00"
        lbl_TotalTax.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_totalPrice
        ' 
        lbl_totalPrice.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_totalPrice.ForeColor = Color.Black
        lbl_totalPrice.Location = New Point(226, 149)
        lbl_totalPrice.Name = "lbl_totalPrice"
        lbl_totalPrice.Size = New Size(121, 27)
        lbl_totalPrice.TabIndex = 19
        lbl_totalPrice.Text = "00.00"
        lbl_totalPrice.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_NoOfItems
        ' 
        lbl_NoOfItems.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_NoOfItems.ForeColor = Color.Black
        lbl_NoOfItems.Location = New Point(226, 78)
        lbl_NoOfItems.Name = "lbl_NoOfItems"
        lbl_NoOfItems.Size = New Size(121, 27)
        lbl_NoOfItems.TabIndex = 18
        lbl_NoOfItems.Text = "00.00"
        lbl_NoOfItems.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(33, 372)
        Label16.Name = "Label16"
        Label16.Size = New Size(54, 17)
        Label16.TabIndex = 17
        Label16.Text = "Change"' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(35, 337)
        Label15.Name = "Label15"
        Label15.Size = New Size(115, 17)
        Label15.TabIndex = 16
        Label15.Text = "Amount Received"' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(35, 299)
        Label14.Name = "Label14"
        Label14.Size = New Size(101, 17)
        Label14.TabIndex = 15
        Label14.Text = "Payment Mode"' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(37, 263)
        Label13.Name = "Label13"
        Label13.Size = New Size(78, 17)
        Label13.TabIndex = 14
        Label13.Text = "Grand Total"' 
        ' txt_discount
        ' 
        txt_discount.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_discount.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        txt_discount.Location = New Point(115, 225)
        txt_discount.Name = "txt_discount"
        txt_discount.Size = New Size(64, 25)
        txt_discount.TabIndex = 10
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(37, 228)
        Label12.Name = "Label12"
        Label12.Size = New Size(72, 17)
        Label12.TabIndex = 13
        Label12.Text = "Discount%"' 
        ' btn_Pay
        ' 
        btn_Pay.BackColor = SystemColors.HotTrack
        btn_Pay.Cursor = Cursors.Hand
        btn_Pay.Dock = DockStyle.Bottom
        btn_Pay.FlatAppearance.BorderSize = 0
        btn_Pay.FlatStyle = FlatStyle.Flat
        btn_Pay.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_Pay.ForeColor = Color.White
        btn_Pay.Location = New Point(0, 405)
        btn_Pay.Name = "btn_Pay"
        btn_Pay.Size = New Size(359, 50)
        btn_Pay.TabIndex = 15
        btn_Pay.Text = "[F9 - PAY]"
        btn_Pay.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(37, 187)
        Label11.Name = "Label11"
        Label11.Size = New Size(61, 17)
        Label11.TabIndex = 12
        Label11.Text = "Total Tax"' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(35, 154)
        Label10.Name = "Label10"
        Label10.Size = New Size(70, 17)
        Label10.TabIndex = 11
        Label10.Text = "Total Price"' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(35, 88)
        Label9.Name = "Label9"
        Label9.Size = New Size(80, 17)
        Label9.TabIndex = 10
        Label9.Text = "No of Items"' 
        ' lbl_OverAllGrandTotal
        ' 
        lbl_OverAllGrandTotal.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_OverAllGrandTotal.ForeColor = SystemColors.HotTrack
        lbl_OverAllGrandTotal.Location = New Point(26, 17)
        lbl_OverAllGrandTotal.Name = "lbl_OverAllGrandTotal"
        lbl_OverAllGrandTotal.Size = New Size(330, 51)
        lbl_OverAllGrandTotal.TabIndex = 0
        lbl_OverAllGrandTotal.Text = "00.00"
        lbl_OverAllGrandTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 155)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(773, 455)
        DataGridView1.TabIndex = 4
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "#"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 41
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Product Code"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 113
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Product Name"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 117
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Product Group"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 119
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "UOM"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 64
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Price"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 61
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "Tax"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 52
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "Sub Total"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 87
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column9.HeaderText = "Qty"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 53
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column10.HeaderText = "Total"
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 61
        ' 
        ' Timer1
        ' 
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        ' 
        ' frm_mainCashier
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1132, 666)
        Controls.Add(DataGridView1)
        Controls.Add(Panel3)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "frm_mainCashier"
        Text = "POS and Inventory Management System"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_loginUser As Label
    Friend WithEvents lbl_logintime As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btp_billdate As DateTimePicker
    Friend WithEvents txt_searchProduct_barcode As TextBox
    Friend WithEvents txt_billno As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_Pay As Button
    Friend WithEvents btn_report As Button
    Friend WithEvents btn_setDiscount As Button
    Friend WithEvents btn_remove As Button
    Friend WithEvents lbl_OverAllGrandTotal As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_discount As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbo_payMode As ComboBox
    Friend WithEvents txt_AmountReceived As TextBox
    Friend WithEvents lbl_Change As Label
    Friend WithEvents lbl_discount As Label
    Friend WithEvents lbl_GrandTotal As Label
    Friend WithEvents lbl_TotalTax As Label
    Friend WithEvents lbl_totalPrice As Label
    Friend WithEvents lbl_NoOfItems As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_subtotalPrice As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label3 As Label
End Class
