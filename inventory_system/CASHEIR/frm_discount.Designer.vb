<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_discount
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
        txt_discount = New TextBox()
        btn_updatediscount = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txt_discount
        ' 
        txt_discount.Location = New Point(45, 37)
        txt_discount.Name = "txt_discount"
        txt_discount.Size = New Size(276, 25)
        txt_discount.TabIndex = 0
        ' 
        ' btn_updatediscount
        ' 
        btn_updatediscount.BackColor = SystemColors.HotTrack
        btn_updatediscount.FlatAppearance.BorderSize = 0
        btn_updatediscount.FlatStyle = FlatStyle.Flat
        btn_updatediscount.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_updatediscount.ForeColor = Color.White
        btn_updatediscount.Location = New Point(45, 90)
        btn_updatediscount.Name = "btn_updatediscount"
        btn_updatediscount.Size = New Size(276, 46)
        btn_updatediscount.TabIndex = 1
        btn_updatediscount.Text = "UPDATE DISCOUNT"
        btn_updatediscount.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 17)
        Label1.TabIndex = 2
        Label1.Text = "Enter Discount %"' 
        ' frm_discount
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(378, 180)
        Controls.Add(Label1)
        Controls.Add(btn_updatediscount)
        Controls.Add(txt_discount)
        Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "frm_discount"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Discount"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_discount As TextBox
    Friend WithEvents btn_updatediscount As Button
    Friend WithEvents Label1 As Label
End Class
