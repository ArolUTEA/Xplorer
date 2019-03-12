<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocMigrationRun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocMigrationRun))
        Me.prbDocMigration = New System.Windows.Forms.ProgressBar()
        Me.lblMigration = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'prbDocMigration
        '
        Me.prbDocMigration.Location = New System.Drawing.Point(13, 13)
        Me.prbDocMigration.Maximum = 20
        Me.prbDocMigration.Name = "prbDocMigration"
        Me.prbDocMigration.Size = New System.Drawing.Size(176, 23)
        Me.prbDocMigration.TabIndex = 0
        '
        'lblMigration
        '
        Me.lblMigration.AutoSize = True
        Me.lblMigration.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMigration.Location = New System.Drawing.Point(12, 41)
        Me.lblMigration.Name = "lblMigration"
        Me.lblMigration.Size = New System.Drawing.Size(173, 26)
        Me.lblMigration.TabIndex = 1
        Me.lblMigration.Text = "Attendere prego..."
        '
        'frmDocMigrationRun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 76)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMigration)
        Me.Controls.Add(Me.prbDocMigration)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDocMigrationRun"
        Me.Text = "Document Migration is Running..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents prbDocMigration As ProgressBar
    Friend WithEvents lblMigration As Label
End Class
