<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePassword))
        Me.lblOldPwd = New System.Windows.Forms.Label()
        Me.txtOldPwd = New System.Windows.Forms.TextBox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.txtNewPwd = New System.Windows.Forms.TextBox()
        Me.lblConfirmPwd = New System.Windows.Forms.Label()
        Me.txtConfirmPwd = New System.Windows.Forms.TextBox()
        Me.btnOkChangePwd = New System.Windows.Forms.Button()
        Me.btnCancelChangePwd = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblOldPwd
        '
        Me.lblOldPwd.AutoSize = True
        Me.lblOldPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldPwd.Location = New System.Drawing.Point(40, 49)
        Me.lblOldPwd.Name = "lblOldPwd"
        Me.lblOldPwd.Size = New System.Drawing.Size(119, 18)
        Me.lblOldPwd.TabIndex = 0
        Me.lblOldPwd.Text = "Old Password:"
        '
        'txtOldPwd
        '
        Me.txtOldPwd.Location = New System.Drawing.Point(165, 48)
        Me.txtOldPwd.Name = "txtOldPwd"
        Me.txtOldPwd.Size = New System.Drawing.Size(151, 20)
        Me.txtOldPwd.TabIndex = 2
        Me.txtOldPwd.UseSystemPasswordChar = True
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassword.Location = New System.Drawing.Point(33, 87)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(126, 18)
        Me.lblNewPassword.TabIndex = 2
        Me.lblNewPassword.Text = "New Password:"
        '
        'txtNewPwd
        '
        Me.txtNewPwd.Location = New System.Drawing.Point(165, 86)
        Me.txtNewPwd.Name = "txtNewPwd"
        Me.txtNewPwd.Size = New System.Drawing.Size(151, 20)
        Me.txtNewPwd.TabIndex = 3
        Me.txtNewPwd.UseSystemPasswordChar = True
        '
        'lblConfirmPwd
        '
        Me.lblConfirmPwd.AutoSize = True
        Me.lblConfirmPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPwd.Location = New System.Drawing.Point(6, 125)
        Me.lblConfirmPwd.Name = "lblConfirmPwd"
        Me.lblConfirmPwd.Size = New System.Drawing.Size(153, 18)
        Me.lblConfirmPwd.TabIndex = 4
        Me.lblConfirmPwd.Text = "Confirm Password:"
        '
        'txtConfirmPwd
        '
        Me.txtConfirmPwd.Location = New System.Drawing.Point(165, 124)
        Me.txtConfirmPwd.Name = "txtConfirmPwd"
        Me.txtConfirmPwd.Size = New System.Drawing.Size(151, 20)
        Me.txtConfirmPwd.TabIndex = 4
        Me.txtConfirmPwd.UseSystemPasswordChar = True
        '
        'btnOkChangePwd
        '
        Me.btnOkChangePwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkChangePwd.Location = New System.Drawing.Point(160, 160)
        Me.btnOkChangePwd.Name = "btnOkChangePwd"
        Me.btnOkChangePwd.Size = New System.Drawing.Size(75, 23)
        Me.btnOkChangePwd.TabIndex = 5
        Me.btnOkChangePwd.Text = "Ok"
        Me.btnOkChangePwd.UseVisualStyleBackColor = True
        '
        'btnCancelChangePwd
        '
        Me.btnCancelChangePwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelChangePwd.Location = New System.Drawing.Point(241, 160)
        Me.btnCancelChangePwd.Name = "btnCancelChangePwd"
        Me.btnCancelChangePwd.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelChangePwd.TabIndex = 6
        Me.btnCancelChangePwd.Text = "Cancel"
        Me.btnCancelChangePwd.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(69, 11)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(90, 18)
        Me.lblUsername.TabIndex = 8
        Me.lblUsername.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(165, 10)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(151, 20)
        Me.txtUsername.TabIndex = 1
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 193)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnCancelChangePwd)
        Me.Controls.Add(Me.btnOkChangePwd)
        Me.Controls.Add(Me.txtConfirmPwd)
        Me.Controls.Add(Me.lblConfirmPwd)
        Me.Controls.Add(Me.txtNewPwd)
        Me.Controls.Add(Me.lblNewPassword)
        Me.Controls.Add(Me.txtOldPwd)
        Me.Controls.Add(Me.lblOldPwd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChangePassword"
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOldPwd As Label
    Friend WithEvents txtOldPwd As TextBox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents txtNewPwd As TextBox
    Friend WithEvents lblConfirmPwd As Label
    Friend WithEvents txtConfirmPwd As TextBox
    Friend WithEvents btnOkChangePwd As Button
    Friend WithEvents btnCancelChangePwd As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
End Class
