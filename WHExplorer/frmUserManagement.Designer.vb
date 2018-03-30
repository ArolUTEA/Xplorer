<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserManagement))
        Me.pnlSelectUser = New System.Windows.Forms.Panel()
        Me.btnFindUser = New System.Windows.Forms.Button()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblSelectUser = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbAdvanced = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbScrittura = New System.Windows.Forms.RadioButton()
        Me.rbLettura = New System.Windows.Forms.RadioButton()
        Me.pnlSelectUser.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSelectUser
        '
        Me.pnlSelectUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSelectUser.Controls.Add(Me.btnFindUser)
        Me.pnlSelectUser.Controls.Add(Me.txtUserName)
        Me.pnlSelectUser.Controls.Add(Me.lblSelectUser)
        Me.pnlSelectUser.Location = New System.Drawing.Point(13, 13)
        Me.pnlSelectUser.Name = "pnlSelectUser"
        Me.pnlSelectUser.Size = New System.Drawing.Size(152, 52)
        Me.pnlSelectUser.TabIndex = 0
        '
        'btnFindUser
        '
        Me.btnFindUser.BackgroundImage = CType(resources.GetObject("btnFindUser.BackgroundImage"), System.Drawing.Image)
        Me.btnFindUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFindUser.Location = New System.Drawing.Point(113, 14)
        Me.btnFindUser.Name = "btnFindUser"
        Me.btnFindUser.Size = New System.Drawing.Size(30, 30)
        Me.btnFindUser.TabIndex = 5
        Me.btnFindUser.UseVisualStyleBackColor = True
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(7, 24)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtUserName.TabIndex = 1
        '
        'lblSelectUser
        '
        Me.lblSelectUser.AutoSize = True
        Me.lblSelectUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectUser.Location = New System.Drawing.Point(4, 4)
        Me.lblSelectUser.Name = "lblSelectUser"
        Me.lblSelectUser.Size = New System.Drawing.Size(57, 16)
        Me.lblSelectUser.TabIndex = 0
        Me.lblSelectUser.Text = "Utente:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.rbAdvanced)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.rbScrittura)
        Me.Panel1.Controls.Add(Me.rbLettura)
        Me.Panel1.Location = New System.Drawing.Point(13, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(152, 99)
        Me.Panel1.TabIndex = 6
        '
        'rbAdvanced
        '
        Me.rbAdvanced.AutoSize = True
        Me.rbAdvanced.Location = New System.Drawing.Point(7, 69)
        Me.rbAdvanced.Name = "rbAdvanced"
        Me.rbAdvanced.Size = New System.Drawing.Size(70, 17)
        Me.rbAdvanced.TabIndex = 9
        Me.rbAdvanced.TabStop = True
        Me.rbAdvanced.Text = "Avanzato"
        Me.rbAdvanced.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modifica Permessi:"
        '
        'rbScrittura
        '
        Me.rbScrittura.AutoSize = True
        Me.rbScrittura.Location = New System.Drawing.Point(7, 46)
        Me.rbScrittura.Name = "rbScrittura"
        Me.rbScrittura.Size = New System.Drawing.Size(64, 17)
        Me.rbScrittura.TabIndex = 8
        Me.rbScrittura.TabStop = True
        Me.rbScrittura.Text = "Scrittura"
        Me.rbScrittura.UseVisualStyleBackColor = True
        '
        'rbLettura
        '
        Me.rbLettura.AutoSize = True
        Me.rbLettura.Location = New System.Drawing.Point(7, 23)
        Me.rbLettura.Name = "rbLettura"
        Me.rbLettura.Size = New System.Drawing.Size(58, 17)
        Me.rbLettura.TabIndex = 7
        Me.rbLettura.TabStop = True
        Me.rbLettura.Text = "Lettura"
        Me.rbLettura.UseVisualStyleBackColor = True
        '
        'frmUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 180)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlSelectUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmUserManagement"
        Me.Text = "User Management"
        Me.pnlSelectUser.ResumeLayout(False)
        Me.pnlSelectUser.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSelectUser As Panel
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents lblSelectUser As Label
    Friend WithEvents btnFindUser As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents rbLettura As RadioButton
    Friend WithEvents rbScrittura As RadioButton
    Friend WithEvents rbAdvanced As RadioButton
End Class
