<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpecialUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpecialUser))
        Me.pbxSpecialUser = New System.Windows.Forms.PictureBox()
        CType(Me.pbxSpecialUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxSpecialUser
        '
        Me.pbxSpecialUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxSpecialUser.Image = CType(resources.GetObject("pbxSpecialUser.Image"), System.Drawing.Image)
        Me.pbxSpecialUser.Location = New System.Drawing.Point(3, 2)
        Me.pbxSpecialUser.Name = "pbxSpecialUser"
        Me.pbxSpecialUser.Size = New System.Drawing.Size(1087, 695)
        Me.pbxSpecialUser.TabIndex = 0
        Me.pbxSpecialUser.TabStop = False
        '
        'frmSpecialUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 695)
        Me.Controls.Add(Me.pbxSpecialUser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSpecialUser"
        Me.Text = "FraMonti ConeNco Special User!! :-) :-) Guest Star!! :-D :-D "
        CType(Me.pbxSpecialUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbxSpecialUser As PictureBox
End Class
