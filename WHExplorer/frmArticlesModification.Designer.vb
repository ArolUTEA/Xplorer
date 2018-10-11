<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticlesModification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticlesModification))
        Me.pnlAdvancedSearch = New System.Windows.Forms.Panel()
        Me.lblFindSupDescr = New System.Windows.Forms.Label()
        Me.txtSuppDescription = New System.Windows.Forms.TextBox()
        Me.lblFindManufacturer = New System.Windows.Forms.Label()
        Me.txtConstructor = New System.Windows.Forms.TextBox()
        Me.lblFindDescr = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblFindCCode = New System.Windows.Forms.Label()
        Me.txtCommercialCode = New System.Windows.Forms.TextBox()
        Me.lblFindACode = New System.Windows.Forms.Label()
        Me.txtArolCode = New System.Windows.Forms.TextBox()
        Me.pnlNote = New System.Windows.Forms.Panel()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtCostoUltimo = New System.Windows.Forms.TextBox()
        Me.txtTipoParte = New System.Windows.Forms.TextBox()
        Me.lblCostoUltimo = New System.Windows.Forms.Label()
        Me.lblTipoParte = New System.Windows.Forms.Label()
        Me.txtScortaSicurezza = New System.Windows.Forms.TextBox()
        Me.lblScortaSicurezza = New System.Windows.Forms.Label()
        Me.txtRiordino = New System.Windows.Forms.TextBox()
        Me.lblRiordino = New System.Windows.Forms.Label()
        Me.txtLotto = New System.Windows.Forms.TextBox()
        Me.lblLotto = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbxModificaStato = New System.Windows.Forms.ComboBox()
        Me.lblModificaStato = New System.Windows.Forms.Label()
        Me.txtStatoAttuale = New System.Windows.Forms.TextBox()
        Me.lblStatoAttuale = New System.Windows.Forms.Label()
        Me.pnlFutureUse = New System.Windows.Forms.Panel()
        Me.btnDeleteExisting = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.pnlAdvancedSearch.SuspendLayout()
        Me.pnlNote.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlFutureUse.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAdvancedSearch
        '
        Me.pnlAdvancedSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlAdvancedSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlAdvancedSearch.Controls.Add(Me.lblFindSupDescr)
        Me.pnlAdvancedSearch.Controls.Add(Me.txtSuppDescription)
        Me.pnlAdvancedSearch.Controls.Add(Me.lblFindManufacturer)
        Me.pnlAdvancedSearch.Controls.Add(Me.txtConstructor)
        Me.pnlAdvancedSearch.Controls.Add(Me.lblFindDescr)
        Me.pnlAdvancedSearch.Controls.Add(Me.txtDescription)
        Me.pnlAdvancedSearch.Controls.Add(Me.lblFindCCode)
        Me.pnlAdvancedSearch.Controls.Add(Me.txtCommercialCode)
        Me.pnlAdvancedSearch.Controls.Add(Me.lblFindACode)
        Me.pnlAdvancedSearch.Controls.Add(Me.txtArolCode)
        Me.pnlAdvancedSearch.Location = New System.Drawing.Point(12, 12)
        Me.pnlAdvancedSearch.Name = "pnlAdvancedSearch"
        Me.pnlAdvancedSearch.Size = New System.Drawing.Size(789, 146)
        Me.pnlAdvancedSearch.TabIndex = 29
        '
        'lblFindSupDescr
        '
        Me.lblFindSupDescr.AutoSize = True
        Me.lblFindSupDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFindSupDescr.Location = New System.Drawing.Point(3, 113)
        Me.lblFindSupDescr.Name = "lblFindSupDescr"
        Me.lblFindSupDescr.Size = New System.Drawing.Size(199, 16)
        Me.lblFindSupDescr.TabIndex = 28
        Me.lblFindSupDescr.Text = "Supplementary Descritpion:"
        Me.lblFindSupDescr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSuppDescription
        '
        Me.txtSuppDescription.Location = New System.Drawing.Point(208, 111)
        Me.txtSuppDescription.Name = "txtSuppDescription"
        Me.txtSuppDescription.Size = New System.Drawing.Size(557, 20)
        Me.txtSuppDescription.TabIndex = 29
        '
        'lblFindManufacturer
        '
        Me.lblFindManufacturer.AutoSize = True
        Me.lblFindManufacturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFindManufacturer.Location = New System.Drawing.Point(101, 87)
        Me.lblFindManufacturer.Name = "lblFindManufacturer"
        Me.lblFindManufacturer.Size = New System.Drawing.Size(101, 16)
        Me.lblFindManufacturer.TabIndex = 22
        Me.lblFindManufacturer.Text = "Manufacturer:"
        Me.lblFindManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConstructor
        '
        Me.txtConstructor.Location = New System.Drawing.Point(208, 85)
        Me.txtConstructor.Name = "txtConstructor"
        Me.txtConstructor.Size = New System.Drawing.Size(108, 20)
        Me.txtConstructor.TabIndex = 23
        '
        'lblFindDescr
        '
        Me.lblFindDescr.AutoSize = True
        Me.lblFindDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFindDescr.Location = New System.Drawing.Point(111, 61)
        Me.lblFindDescr.Name = "lblFindDescr"
        Me.lblFindDescr.Size = New System.Drawing.Size(91, 16)
        Me.lblFindDescr.TabIndex = 25
        Me.lblFindDescr.Text = "Description:"
        Me.lblFindDescr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(208, 59)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(251, 20)
        Me.txtDescription.TabIndex = 26
        '
        'lblFindCCode
        '
        Me.lblFindCCode.AutoSize = True
        Me.lblFindCCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFindCCode.Location = New System.Drawing.Point(67, 35)
        Me.lblFindCCode.Name = "lblFindCCode"
        Me.lblFindCCode.Size = New System.Drawing.Size(135, 16)
        Me.lblFindCCode.TabIndex = 22
        Me.lblFindCCode.Text = "Commercial Code:"
        Me.lblFindCCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCommercialCode
        '
        Me.txtCommercialCode.Location = New System.Drawing.Point(208, 33)
        Me.txtCommercialCode.Name = "txtCommercialCode"
        Me.txtCommercialCode.Size = New System.Drawing.Size(108, 20)
        Me.txtCommercialCode.TabIndex = 23
        '
        'lblFindACode
        '
        Me.lblFindACode.AutoSize = True
        Me.lblFindACode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFindACode.Location = New System.Drawing.Point(121, 9)
        Me.lblFindACode.Name = "lblFindACode"
        Me.lblFindACode.Size = New System.Drawing.Size(81, 16)
        Me.lblFindACode.TabIndex = 19
        Me.lblFindACode.Text = "Arol Code:"
        Me.lblFindACode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtArolCode
        '
        Me.txtArolCode.Location = New System.Drawing.Point(208, 7)
        Me.txtArolCode.Name = "txtArolCode"
        Me.txtArolCode.Size = New System.Drawing.Size(100, 20)
        Me.txtArolCode.TabIndex = 20
        '
        'pnlNote
        '
        Me.pnlNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNote.Controls.Add(Me.txtNote)
        Me.pnlNote.Controls.Add(Me.lblNote)
        Me.pnlNote.Location = New System.Drawing.Point(12, 165)
        Me.pnlNote.Name = "pnlNote"
        Me.pnlNote.Size = New System.Drawing.Size(789, 154)
        Me.pnlNote.TabIndex = 32
        '
        'txtNote
        '
        Me.txtNote.BackColor = System.Drawing.Color.White
        Me.txtNote.Location = New System.Drawing.Point(6, 22)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(759, 124)
        Me.txtNote.TabIndex = 16
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(3, 3)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(41, 16)
        Me.lblNote.TabIndex = 3
        Me.lblNote.Text = "Note"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.txtCostoUltimo)
        Me.Panel5.Controls.Add(Me.txtTipoParte)
        Me.Panel5.Controls.Add(Me.lblCostoUltimo)
        Me.Panel5.Controls.Add(Me.lblTipoParte)
        Me.Panel5.Controls.Add(Me.txtScortaSicurezza)
        Me.Panel5.Controls.Add(Me.lblScortaSicurezza)
        Me.Panel5.Controls.Add(Me.txtRiordino)
        Me.Panel5.Controls.Add(Me.lblRiordino)
        Me.Panel5.Controls.Add(Me.txtLotto)
        Me.Panel5.Controls.Add(Me.lblLotto)
        Me.Panel5.Location = New System.Drawing.Point(807, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(193, 146)
        Me.Panel5.TabIndex = 31
        '
        'txtCostoUltimo
        '
        Me.txtCostoUltimo.BackColor = System.Drawing.Color.LightGray
        Me.txtCostoUltimo.Enabled = False
        Me.txtCostoUltimo.Location = New System.Drawing.Point(106, 109)
        Me.txtCostoUltimo.Name = "txtCostoUltimo"
        Me.txtCostoUltimo.ReadOnly = True
        Me.txtCostoUltimo.Size = New System.Drawing.Size(70, 20)
        Me.txtCostoUltimo.TabIndex = 10
        '
        'txtTipoParte
        '
        Me.txtTipoParte.BackColor = System.Drawing.Color.White
        Me.txtTipoParte.Location = New System.Drawing.Point(106, 5)
        Me.txtTipoParte.Name = "txtTipoParte"
        Me.txtTipoParte.Size = New System.Drawing.Size(26, 20)
        Me.txtTipoParte.TabIndex = 22
        '
        'lblCostoUltimo
        '
        Me.lblCostoUltimo.AutoSize = True
        Me.lblCostoUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoUltimo.Location = New System.Drawing.Point(3, 111)
        Me.lblCostoUltimo.Name = "lblCostoUltimo"
        Me.lblCostoUltimo.Size = New System.Drawing.Size(97, 16)
        Me.lblCostoUltimo.TabIndex = 9
        Me.lblCostoUltimo.Text = "Costo ultimo:"
        '
        'lblTipoParte
        '
        Me.lblTipoParte.AutoSize = True
        Me.lblTipoParte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoParte.Location = New System.Drawing.Point(16, 7)
        Me.lblTipoParte.Name = "lblTipoParte"
        Me.lblTipoParte.Size = New System.Drawing.Size(84, 16)
        Me.lblTipoParte.TabIndex = 21
        Me.lblTipoParte.Text = "Tipo parte:"
        Me.lblTipoParte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtScortaSicurezza
        '
        Me.txtScortaSicurezza.BackColor = System.Drawing.Color.White
        Me.txtScortaSicurezza.Location = New System.Drawing.Point(106, 57)
        Me.txtScortaSicurezza.Name = "txtScortaSicurezza"
        Me.txtScortaSicurezza.Size = New System.Drawing.Size(70, 20)
        Me.txtScortaSicurezza.TabIndex = 20
        '
        'lblScortaSicurezza
        '
        Me.lblScortaSicurezza.AutoSize = True
        Me.lblScortaSicurezza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScortaSicurezza.Location = New System.Drawing.Point(43, 59)
        Me.lblScortaSicurezza.Name = "lblScortaSicurezza"
        Me.lblScortaSicurezza.Size = New System.Drawing.Size(57, 16)
        Me.lblScortaSicurezza.TabIndex = 19
        Me.lblScortaSicurezza.Text = "Scorta:"
        Me.lblScortaSicurezza.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRiordino
        '
        Me.txtRiordino.BackColor = System.Drawing.Color.White
        Me.txtRiordino.Location = New System.Drawing.Point(106, 31)
        Me.txtRiordino.Name = "txtRiordino"
        Me.txtRiordino.Size = New System.Drawing.Size(70, 20)
        Me.txtRiordino.TabIndex = 18
        '
        'lblRiordino
        '
        Me.lblRiordino.AutoSize = True
        Me.lblRiordino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRiordino.Location = New System.Drawing.Point(29, 33)
        Me.lblRiordino.Name = "lblRiordino"
        Me.lblRiordino.Size = New System.Drawing.Size(71, 16)
        Me.lblRiordino.TabIndex = 17
        Me.lblRiordino.Text = "Riordino:"
        Me.lblRiordino.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLotto
        '
        Me.txtLotto.BackColor = System.Drawing.Color.White
        Me.txtLotto.Location = New System.Drawing.Point(106, 83)
        Me.txtLotto.Name = "txtLotto"
        Me.txtLotto.Size = New System.Drawing.Size(70, 20)
        Me.txtLotto.TabIndex = 16
        '
        'lblLotto
        '
        Me.lblLotto.AutoSize = True
        Me.lblLotto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLotto.Location = New System.Drawing.Point(54, 85)
        Me.lblLotto.Name = "lblLotto"
        Me.lblLotto.Size = New System.Drawing.Size(46, 16)
        Me.lblLotto.TabIndex = 3
        Me.lblLotto.Text = "Lotto:"
        Me.lblLotto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.cbxModificaStato)
        Me.Panel3.Controls.Add(Me.lblModificaStato)
        Me.Panel3.Controls.Add(Me.txtStatoAttuale)
        Me.Panel3.Controls.Add(Me.lblStatoAttuale)
        Me.Panel3.Location = New System.Drawing.Point(807, 165)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(193, 97)
        Me.Panel3.TabIndex = 30
        '
        'cbxModificaStato
        '
        Me.cbxModificaStato.FormattingEnabled = True
        Me.cbxModificaStato.Location = New System.Drawing.Point(4, 64)
        Me.cbxModificaStato.Name = "cbxModificaStato"
        Me.cbxModificaStato.Size = New System.Drawing.Size(115, 21)
        Me.cbxModificaStato.TabIndex = 6
        Me.cbxModificaStato.Text = "Seleziona stato..."
        '
        'lblModificaStato
        '
        Me.lblModificaStato.AutoSize = True
        Me.lblModificaStato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificaStato.Location = New System.Drawing.Point(3, 45)
        Me.lblModificaStato.Name = "lblModificaStato"
        Me.lblModificaStato.Size = New System.Drawing.Size(109, 16)
        Me.lblModificaStato.TabIndex = 5
        Me.lblModificaStato.Text = "Modifica stato:"
        '
        'txtStatoAttuale
        '
        Me.txtStatoAttuale.BackColor = System.Drawing.Color.LightGray
        Me.txtStatoAttuale.Enabled = False
        Me.txtStatoAttuale.Location = New System.Drawing.Point(6, 22)
        Me.txtStatoAttuale.Name = "txtStatoAttuale"
        Me.txtStatoAttuale.ReadOnly = True
        Me.txtStatoAttuale.Size = New System.Drawing.Size(96, 20)
        Me.txtStatoAttuale.TabIndex = 4
        '
        'lblStatoAttuale
        '
        Me.lblStatoAttuale.AutoSize = True
        Me.lblStatoAttuale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatoAttuale.Location = New System.Drawing.Point(3, 3)
        Me.lblStatoAttuale.Name = "lblStatoAttuale"
        Me.lblStatoAttuale.Size = New System.Drawing.Size(99, 16)
        Me.lblStatoAttuale.TabIndex = 3
        Me.lblStatoAttuale.Text = "Stato attuale:"
        Me.lblStatoAttuale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlFutureUse
        '
        Me.pnlFutureUse.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlFutureUse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlFutureUse.Controls.Add(Me.btnDeleteExisting)
        Me.pnlFutureUse.Controls.Add(Me.btnSave)
        Me.pnlFutureUse.Controls.Add(Me.btnUndo)
        Me.pnlFutureUse.Location = New System.Drawing.Point(807, 268)
        Me.pnlFutureUse.Name = "pnlFutureUse"
        Me.pnlFutureUse.Size = New System.Drawing.Size(193, 51)
        Me.pnlFutureUse.TabIndex = 33
        '
        'btnDeleteExisting
        '
        Me.btnDeleteExisting.BackgroundImage = Global.Xplorer.My.Resources.Resources.cestino
        Me.btnDeleteExisting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDeleteExisting.Location = New System.Drawing.Point(117, 3)
        Me.btnDeleteExisting.Name = "btnDeleteExisting"
        Me.btnDeleteExisting.Size = New System.Drawing.Size(40, 40)
        Me.btnDeleteExisting.TabIndex = 31
        Me.btnDeleteExisting.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(27, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(40, 40)
        Me.btnSave.TabIndex = 29
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.BackgroundImage = CType(resources.GetObject("btnUndo.BackgroundImage"), System.Drawing.Image)
        Me.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUndo.Enabled = False
        Me.btnUndo.Location = New System.Drawing.Point(72, 3)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(40, 40)
        Me.btnUndo.TabIndex = 30
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'frmArticlesModification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 327)
        Me.Controls.Add(Me.pnlFutureUse)
        Me.Controls.Add(Me.pnlNote)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlAdvancedSearch)
        Me.Name = "frmArticlesModification"
        Me.Text = "Modifica Esistente"
        Me.pnlAdvancedSearch.ResumeLayout(False)
        Me.pnlAdvancedSearch.PerformLayout()
        Me.pnlNote.ResumeLayout(False)
        Me.pnlNote.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlFutureUse.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlAdvancedSearch As Panel
    Friend WithEvents lblFindSupDescr As Label
    Friend WithEvents txtSuppDescription As TextBox
    Friend WithEvents lblFindManufacturer As Label
    Friend WithEvents txtConstructor As TextBox
    Friend WithEvents lblFindDescr As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblFindCCode As Label
    Friend WithEvents txtCommercialCode As TextBox
    Friend WithEvents lblFindACode As Label
    Friend WithEvents txtArolCode As TextBox
    Friend WithEvents pnlNote As Panel
    Friend WithEvents txtNote As TextBox
    Friend WithEvents lblNote As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtCostoUltimo As TextBox
    Friend WithEvents txtTipoParte As TextBox
    Friend WithEvents lblCostoUltimo As Label
    Friend WithEvents lblTipoParte As Label
    Friend WithEvents txtScortaSicurezza As TextBox
    Friend WithEvents lblScortaSicurezza As Label
    Friend WithEvents txtRiordino As TextBox
    Friend WithEvents lblRiordino As Label
    Friend WithEvents txtLotto As TextBox
    Friend WithEvents lblLotto As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cbxModificaStato As ComboBox
    Friend WithEvents lblModificaStato As Label
    Friend WithEvents txtStatoAttuale As TextBox
    Friend WithEvents lblStatoAttuale As Label
    Friend WithEvents pnlFutureUse As Panel
    Friend WithEvents btnDeleteExisting As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUndo As Button
End Class
