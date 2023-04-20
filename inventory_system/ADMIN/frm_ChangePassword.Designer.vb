<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ChangePassword
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
        Me.txt_oldpassword = New System.Windows.Forms.TextBox()
        Me.txt_reenterpassword = New System.Windows.Forms.TextBox()
        Me.txt_newpassword = New System.Windows.Forms.TextBox()
        Me.btn_ChangePassword = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_oldpassword
        '
        Me.txt_oldpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txt_oldpassword.Location = New System.Drawing.Point(78, 64)
        Me.txt_oldpassword.Name = "txt_oldpassword"
        Me.txt_oldpassword.Size = New System.Drawing.Size(281, 25)
        Me.txt_oldpassword.TabIndex = 0
        Me.txt_oldpassword.UseSystemPasswordChar = True
        '
        'txt_reenterpassword
        '
        Me.txt_reenterpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txt_reenterpassword.Location = New System.Drawing.Point(78, 158)
        Me.txt_reenterpassword.Name = "txt_reenterpassword"
        Me.txt_reenterpassword.Size = New System.Drawing.Size(281, 25)
        Me.txt_reenterpassword.TabIndex = 1
        Me.txt_reenterpassword.UseSystemPasswordChar = True
        '
        'txt_newpassword
        '
        Me.txt_newpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txt_newpassword.Location = New System.Drawing.Point(78, 112)
        Me.txt_newpassword.Name = "txt_newpassword"
        Me.txt_newpassword.Size = New System.Drawing.Size(281, 25)
        Me.txt_newpassword.TabIndex = 2
        Me.txt_newpassword.UseSystemPasswordChar = True
        '
        'btn_ChangePassword
        '
        Me.btn_ChangePassword.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_ChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ChangePassword.FlatAppearance.BorderSize = 0
        Me.btn_ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ChangePassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_ChangePassword.ForeColor = System.Drawing.Color.White
        Me.btn_ChangePassword.Location = New System.Drawing.Point(78, 217)
        Me.btn_ChangePassword.Name = "btn_ChangePassword"
        Me.btn_ChangePassword.Size = New System.Drawing.Size(281, 42)
        Me.btn_ChangePassword.TabIndex = 3
        Me.btn_ChangePassword.Text = "Change Pass"
        Me.btn_ChangePassword.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(79, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter your OLD Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(79, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter your NEW Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(79, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Repeat NEW Password"
        '
        'frm_ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(398, 282)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_ChangePassword)
        Me.Controls.Add(Me.txt_newpassword)
        Me.Controls.Add(Me.txt_reenterpassword)
        Me.Controls.Add(Me.txt_oldpassword)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_oldpassword As TextBox
    Friend WithEvents txt_reenterpassword As TextBox
    Friend WithEvents txt_newpassword As TextBox
    Friend WithEvents btn_ChangePassword As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
