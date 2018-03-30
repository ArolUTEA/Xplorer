<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModDetails
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
        Me.lblPrevious = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPrevious = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtAfter = New System.Windows.Forms.TextBox()
        Me.lblAfter = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrevious
        '
        Me.lblPrevious.AutoSize = True
        Me.lblPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevious.Location = New System.Drawing.Point(4, 4)
        Me.lblPrevious.Name = "lblPrevious"
        Me.lblPrevious.Size = New System.Drawing.Size(52, 16)
        Me.lblPrevious.TabIndex = 0
        Me.lblPrevious.Text = "Prima:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtPrevious)
        Me.Panel1.Controls.Add(Me.lblPrevious)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 57)
        Me.Panel1.TabIndex = 1
        '
        'txtPrevious
        '
        Me.txtPrevious.BackColor = System.Drawing.Color.White
        Me.txtPrevious.Location = New System.Drawing.Point(4, 24)
        Me.txtPrevious.Name = "txtPrevious"
        Me.txtPrevious.ReadOnly = True
        Me.txtPrevious.Size = New System.Drawing.Size(982, 20)
        Me.txtPrevious.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtAfter)
        Me.Panel2.Controls.Add(Me.lblAfter)
        Me.Panel2.Location = New System.Drawing.Point(13, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(998, 57)
        Me.Panel2.TabIndex = 2
        '
        'txtAfter
        '
        Me.txtAfter.BackColor = System.Drawing.Color.White
        Me.txtAfter.Location = New System.Drawing.Point(4, 25)
        Me.txtAfter.Name = "txtAfter"
        Me.txtAfter.ReadOnly = True
        Me.txtAfter.Size = New System.Drawing.Size(982, 20)
        Me.txtAfter.TabIndex = 3
        '
        'lblAfter
        '
        Me.lblAfter.AutoSize = True
        Me.lblAfter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfter.Location = New System.Drawing.Point(4, 5)
        Me.lblAfter.Name = "lblAfter"
        Me.lblAfter.Size = New System.Drawing.Size(50, 16)
        Me.lblAfter.TabIndex = 2
        Me.lblAfter.Text = "Dopo:"
        '
        'frmModDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 152)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmModDetails"
        Me.Text = "frmModDetails"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPrevious As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPrevious As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtAfter As TextBox
    Friend WithEvents lblAfter As Label
End Class
