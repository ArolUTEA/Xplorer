<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticlesDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticlesDetails))
        Me.pnlArolCode = New System.Windows.Forms.Panel()
        Me.txtArolCode = New System.Windows.Forms.TextBox()
        Me.lblArolCode = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCommercialCode = New System.Windows.Forms.TextBox()
        Me.lblCodiceCommerciale = New System.Windows.Forms.Label()
        Me.pnlDescription = New System.Windows.Forms.Panel()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescrizione = New System.Windows.Forms.Label()
        Me.pnlConstructor = New System.Windows.Forms.Panel()
        Me.txtConstructor = New System.Windows.Forms.TextBox()
        Me.lblConstructor = New System.Windows.Forms.Label()
        Me.pnlSupplementaryDescription = New System.Windows.Forms.Panel()
        Me.txtSuppDescription = New System.Windows.Forms.TextBox()
        Me.lblDescrizSupp = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtCodificaRichiestaDa = New System.Windows.Forms.TextBox()
        Me.txtInseritoDa = New System.Windows.Forms.TextBox()
        Me.lblInseritoDa = New System.Windows.Forms.Label()
        Me.lblCodificaRichiestaDa = New System.Windows.Forms.Label()
        Me.txtDataInserimento = New System.Windows.Forms.TextBox()
        Me.lblDataInserimento = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtDataUltimaModifica = New System.Windows.Forms.TextBox()
        Me.txtModificatoDa = New System.Windows.Forms.TextBox()
        Me.lblModificatoDa = New System.Windows.Forms.Label()
        Me.lblDataUltimaModifica = New System.Windows.Forms.Label()
        Me.txtStatoAttuale = New System.Windows.Forms.TextBox()
        Me.lblStatoAttuale = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbxModificaStato = New System.Windows.Forms.ComboBox()
        Me.lblModificaStato = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.pnlNote = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnDeleteExisting = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtRiordino = New System.Windows.Forms.TextBox()
        Me.lblRiordino = New System.Windows.Forms.Label()
        Me.txtLotto = New System.Windows.Forms.TextBox()
        Me.lblLotto = New System.Windows.Forms.Label()
        Me.txtScortaSicurezza = New System.Windows.Forms.TextBox()
        Me.lblScortaSicurezza = New System.Windows.Forms.Label()
        Me.txtTipoParte = New System.Windows.Forms.TextBox()
        Me.lblTipoParte = New System.Windows.Forms.Label()
        Me.txtCostoUltimo = New System.Windows.Forms.TextBox()
        Me.lblCostoUltimo = New System.Windows.Forms.Label()
        Me.pnlArolCode.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlDescription.SuspendLayout()
        Me.pnlConstructor.SuspendLayout()
        Me.pnlSupplementaryDescription.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlNote.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlArolCode
        '
        Me.pnlArolCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlArolCode.Controls.Add(Me.txtArolCode)
        Me.pnlArolCode.Controls.Add(Me.lblArolCode)
        Me.pnlArolCode.Location = New System.Drawing.Point(12, 12)
        Me.pnlArolCode.Name = "pnlArolCode"
        Me.pnlArolCode.Size = New System.Drawing.Size(119, 53)
        Me.pnlArolCode.TabIndex = 0
        '
        'txtArolCode
        '
        Me.txtArolCode.Enabled = False
        Me.txtArolCode.Location = New System.Drawing.Point(6, 22)
        Me.txtArolCode.Name = "txtArolCode"
        Me.txtArolCode.ReadOnly = True
        Me.txtArolCode.Size = New System.Drawing.Size(100, 20)
        Me.txtArolCode.TabIndex = 4
        '
        'lblArolCode
        '
        Me.lblArolCode.AutoSize = True
        Me.lblArolCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArolCode.Location = New System.Drawing.Point(3, 3)
        Me.lblArolCode.Name = "lblArolCode"
        Me.lblArolCode.Size = New System.Drawing.Size(89, 16)
        Me.lblArolCode.TabIndex = 3
        Me.lblArolCode.Text = "Codice Arol"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtCommercialCode)
        Me.Panel1.Controls.Add(Me.lblCodiceCommerciale)
        Me.Panel1.Location = New System.Drawing.Point(137, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(167, 53)
        Me.Panel1.TabIndex = 1
        '
        'txtCommercialCode
        '
        Me.txtCommercialCode.Location = New System.Drawing.Point(6, 22)
        Me.txtCommercialCode.Name = "txtCommercialCode"
        Me.txtCommercialCode.Size = New System.Drawing.Size(149, 20)
        Me.txtCommercialCode.TabIndex = 8
        '
        'lblCodiceCommerciale
        '
        Me.lblCodiceCommerciale.AutoSize = True
        Me.lblCodiceCommerciale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodiceCommerciale.Location = New System.Drawing.Point(3, 3)
        Me.lblCodiceCommerciale.Name = "lblCodiceCommerciale"
        Me.lblCodiceCommerciale.Size = New System.Drawing.Size(152, 16)
        Me.lblCodiceCommerciale.TabIndex = 3
        Me.lblCodiceCommerciale.Text = "Codice Commerciale"
        '
        'pnlDescription
        '
        Me.pnlDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDescription.Controls.Add(Me.txtDescription)
        Me.pnlDescription.Controls.Add(Me.lblDescrizione)
        Me.pnlDescription.Location = New System.Drawing.Point(310, 12)
        Me.pnlDescription.Name = "pnlDescription"
        Me.pnlDescription.Size = New System.Drawing.Size(309, 53)
        Me.pnlDescription.TabIndex = 2
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescription.Location = New System.Drawing.Point(6, 22)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(294, 20)
        Me.txtDescription.TabIndex = 10
        '
        'lblDescrizione
        '
        Me.lblDescrizione.AutoSize = True
        Me.lblDescrizione.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizione.Location = New System.Drawing.Point(3, 3)
        Me.lblDescrizione.Name = "lblDescrizione"
        Me.lblDescrizione.Size = New System.Drawing.Size(90, 16)
        Me.lblDescrizione.TabIndex = 3
        Me.lblDescrizione.Text = "Descrizione"
        '
        'pnlConstructor
        '
        Me.pnlConstructor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlConstructor.Controls.Add(Me.txtConstructor)
        Me.pnlConstructor.Controls.Add(Me.lblConstructor)
        Me.pnlConstructor.Location = New System.Drawing.Point(625, 12)
        Me.pnlConstructor.Name = "pnlConstructor"
        Me.pnlConstructor.Size = New System.Drawing.Size(167, 53)
        Me.pnlConstructor.TabIndex = 3
        '
        'txtConstructor
        '
        Me.txtConstructor.Location = New System.Drawing.Point(6, 22)
        Me.txtConstructor.Name = "txtConstructor"
        Me.txtConstructor.Size = New System.Drawing.Size(149, 20)
        Me.txtConstructor.TabIndex = 8
        '
        'lblConstructor
        '
        Me.lblConstructor.AutoSize = True
        Me.lblConstructor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConstructor.Location = New System.Drawing.Point(3, 3)
        Me.lblConstructor.Name = "lblConstructor"
        Me.lblConstructor.Size = New System.Drawing.Size(83, 16)
        Me.lblConstructor.TabIndex = 3
        Me.lblConstructor.Text = "Costruttore"
        '
        'pnlSupplementaryDescription
        '
        Me.pnlSupplementaryDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSupplementaryDescription.Controls.Add(Me.txtSuppDescription)
        Me.pnlSupplementaryDescription.Controls.Add(Me.lblDescrizSupp)
        Me.pnlSupplementaryDescription.Location = New System.Drawing.Point(12, 186)
        Me.pnlSupplementaryDescription.Name = "pnlSupplementaryDescription"
        Me.pnlSupplementaryDescription.Size = New System.Drawing.Size(780, 53)
        Me.pnlSupplementaryDescription.TabIndex = 4
        '
        'txtSuppDescription
        '
        Me.txtSuppDescription.BackColor = System.Drawing.Color.White
        Me.txtSuppDescription.Location = New System.Drawing.Point(6, 22)
        Me.txtSuppDescription.Name = "txtSuppDescription"
        Me.txtSuppDescription.Size = New System.Drawing.Size(762, 20)
        Me.txtSuppDescription.TabIndex = 16
        '
        'lblDescrizSupp
        '
        Me.lblDescrizSupp.AutoSize = True
        Me.lblDescrizSupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizSupp.Location = New System.Drawing.Point(3, 3)
        Me.lblDescrizSupp.Name = "lblDescrizSupp"
        Me.lblDescrizSupp.Size = New System.Drawing.Size(197, 16)
        Me.lblDescrizSupp.TabIndex = 3
        Me.lblDescrizSupp.Text = "Descrizione supplementare"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtCodificaRichiestaDa)
        Me.Panel2.Controls.Add(Me.txtInseritoDa)
        Me.Panel2.Controls.Add(Me.lblInseritoDa)
        Me.Panel2.Controls.Add(Me.lblCodificaRichiestaDa)
        Me.Panel2.Controls.Add(Me.txtDataInserimento)
        Me.Panel2.Controls.Add(Me.lblDataInserimento)
        Me.Panel2.Location = New System.Drawing.Point(12, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(292, 109)
        Me.Panel2.TabIndex = 5
        '
        'txtCodificaRichiestaDa
        '
        Me.txtCodificaRichiestaDa.BackColor = System.Drawing.Color.LightGray
        Me.txtCodificaRichiestaDa.Enabled = False
        Me.txtCodificaRichiestaDa.Location = New System.Drawing.Point(133, 22)
        Me.txtCodificaRichiestaDa.Name = "txtCodificaRichiestaDa"
        Me.txtCodificaRichiestaDa.ReadOnly = True
        Me.txtCodificaRichiestaDa.Size = New System.Drawing.Size(147, 20)
        Me.txtCodificaRichiestaDa.TabIndex = 8
        '
        'txtInseritoDa
        '
        Me.txtInseritoDa.BackColor = System.Drawing.Color.LightGray
        Me.txtInseritoDa.Enabled = False
        Me.txtInseritoDa.Location = New System.Drawing.Point(6, 65)
        Me.txtInseritoDa.Name = "txtInseritoDa"
        Me.txtInseritoDa.ReadOnly = True
        Me.txtInseritoDa.Size = New System.Drawing.Size(100, 20)
        Me.txtInseritoDa.TabIndex = 6
        '
        'lblInseritoDa
        '
        Me.lblInseritoDa.AutoSize = True
        Me.lblInseritoDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInseritoDa.Location = New System.Drawing.Point(3, 46)
        Me.lblInseritoDa.Name = "lblInseritoDa"
        Me.lblInseritoDa.Size = New System.Drawing.Size(81, 16)
        Me.lblInseritoDa.TabIndex = 6
        Me.lblInseritoDa.Text = "Inserito da"
        '
        'lblCodificaRichiestaDa
        '
        Me.lblCodificaRichiestaDa.AutoSize = True
        Me.lblCodificaRichiestaDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodificaRichiestaDa.Location = New System.Drawing.Point(130, 3)
        Me.lblCodificaRichiestaDa.Name = "lblCodificaRichiestaDa"
        Me.lblCodificaRichiestaDa.Size = New System.Drawing.Size(150, 16)
        Me.lblCodificaRichiestaDa.TabIndex = 7
        Me.lblCodificaRichiestaDa.Text = "Codifica richiesta da"
        '
        'txtDataInserimento
        '
        Me.txtDataInserimento.BackColor = System.Drawing.Color.LightGray
        Me.txtDataInserimento.Enabled = False
        Me.txtDataInserimento.Location = New System.Drawing.Point(6, 22)
        Me.txtDataInserimento.Name = "txtDataInserimento"
        Me.txtDataInserimento.ReadOnly = True
        Me.txtDataInserimento.Size = New System.Drawing.Size(100, 20)
        Me.txtDataInserimento.TabIndex = 4
        '
        'lblDataInserimento
        '
        Me.lblDataInserimento.AutoSize = True
        Me.lblDataInserimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataInserimento.Location = New System.Drawing.Point(3, 3)
        Me.lblDataInserimento.Name = "lblDataInserimento"
        Me.lblDataInserimento.Size = New System.Drawing.Size(125, 16)
        Me.lblDataInserimento.TabIndex = 3
        Me.lblDataInserimento.Text = "Data inserimento"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtDataUltimaModifica)
        Me.Panel3.Controls.Add(Me.txtModificatoDa)
        Me.Panel3.Controls.Add(Me.lblModificatoDa)
        Me.Panel3.Controls.Add(Me.lblDataUltimaModifica)
        Me.Panel3.Controls.Add(Me.txtStatoAttuale)
        Me.Panel3.Controls.Add(Me.lblStatoAttuale)
        Me.Panel3.Location = New System.Drawing.Point(310, 71)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(309, 109)
        Me.Panel3.TabIndex = 6
        '
        'txtDataUltimaModifica
        '
        Me.txtDataUltimaModifica.BackColor = System.Drawing.Color.LightGray
        Me.txtDataUltimaModifica.Enabled = False
        Me.txtDataUltimaModifica.Location = New System.Drawing.Point(133, 22)
        Me.txtDataUltimaModifica.Name = "txtDataUltimaModifica"
        Me.txtDataUltimaModifica.ReadOnly = True
        Me.txtDataUltimaModifica.Size = New System.Drawing.Size(147, 20)
        Me.txtDataUltimaModifica.TabIndex = 8
        '
        'txtModificatoDa
        '
        Me.txtModificatoDa.BackColor = System.Drawing.Color.LightGray
        Me.txtModificatoDa.Enabled = False
        Me.txtModificatoDa.Location = New System.Drawing.Point(133, 65)
        Me.txtModificatoDa.Name = "txtModificatoDa"
        Me.txtModificatoDa.ReadOnly = True
        Me.txtModificatoDa.Size = New System.Drawing.Size(147, 20)
        Me.txtModificatoDa.TabIndex = 6
        '
        'lblModificatoDa
        '
        Me.lblModificatoDa.AutoSize = True
        Me.lblModificatoDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificatoDa.Location = New System.Drawing.Point(130, 46)
        Me.lblModificatoDa.Name = "lblModificatoDa"
        Me.lblModificatoDa.Size = New System.Drawing.Size(102, 16)
        Me.lblModificatoDa.TabIndex = 6
        Me.lblModificatoDa.Text = "Modificato da"
        '
        'lblDataUltimaModifica
        '
        Me.lblDataUltimaModifica.AutoSize = True
        Me.lblDataUltimaModifica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataUltimaModifica.Location = New System.Drawing.Point(130, 3)
        Me.lblDataUltimaModifica.Name = "lblDataUltimaModifica"
        Me.lblDataUltimaModifica.Size = New System.Drawing.Size(115, 16)
        Me.lblDataUltimaModifica.TabIndex = 7
        Me.lblDataUltimaModifica.Text = "Ultima modifica"
        '
        'txtStatoAttuale
        '
        Me.txtStatoAttuale.BackColor = System.Drawing.Color.LightGray
        Me.txtStatoAttuale.Enabled = False
        Me.txtStatoAttuale.Location = New System.Drawing.Point(6, 22)
        Me.txtStatoAttuale.Name = "txtStatoAttuale"
        Me.txtStatoAttuale.ReadOnly = True
        Me.txtStatoAttuale.Size = New System.Drawing.Size(100, 20)
        Me.txtStatoAttuale.TabIndex = 4
        '
        'lblStatoAttuale
        '
        Me.lblStatoAttuale.AutoSize = True
        Me.lblStatoAttuale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatoAttuale.Location = New System.Drawing.Point(3, 3)
        Me.lblStatoAttuale.Name = "lblStatoAttuale"
        Me.lblStatoAttuale.Size = New System.Drawing.Size(95, 16)
        Me.lblStatoAttuale.TabIndex = 3
        Me.lblStatoAttuale.Text = "Stato attuale"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.cbxModificaStato)
        Me.Panel4.Controls.Add(Me.lblModificaStato)
        Me.Panel4.Location = New System.Drawing.Point(625, 71)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(167, 109)
        Me.Panel4.TabIndex = 7
        '
        'cbxModificaStato
        '
        Me.cbxModificaStato.FormattingEnabled = True
        Me.cbxModificaStato.Location = New System.Drawing.Point(6, 22)
        Me.cbxModificaStato.Name = "cbxModificaStato"
        Me.cbxModificaStato.Size = New System.Drawing.Size(115, 21)
        Me.cbxModificaStato.TabIndex = 4
        Me.cbxModificaStato.Text = "Seleziona stato..."
        '
        'lblModificaStato
        '
        Me.lblModificaStato.AutoSize = True
        Me.lblModificaStato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificaStato.Location = New System.Drawing.Point(3, 3)
        Me.lblModificaStato.Name = "lblModificaStato"
        Me.lblModificaStato.Size = New System.Drawing.Size(105, 16)
        Me.lblModificaStato.TabIndex = 3
        Me.lblModificaStato.Text = "Modifica stato"
        '
        'txtNote
        '
        Me.txtNote.BackColor = System.Drawing.Color.White
        Me.txtNote.Location = New System.Drawing.Point(6, 22)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(762, 20)
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
        'pnlNote
        '
        Me.pnlNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNote.Controls.Add(Me.txtNote)
        Me.pnlNote.Controls.Add(Me.lblNote)
        Me.pnlNote.Location = New System.Drawing.Point(12, 245)
        Me.pnlNote.Name = "pnlNote"
        Me.pnlNote.Size = New System.Drawing.Size(780, 53)
        Me.pnlNote.TabIndex = 8
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSave.Location = New System.Drawing.Point(867, 190)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(40, 40)
        Me.btnSave.TabIndex = 9
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.BackgroundImage = CType(resources.GetObject("btnUndo.BackgroundImage"), System.Drawing.Image)
        Me.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUndo.Location = New System.Drawing.Point(912, 190)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(40, 40)
        Me.btnUndo.TabIndex = 10
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'btnDeleteExisting
        '
        Me.btnDeleteExisting.BackgroundImage = Global.Xplorer.My.Resources.Resources.cestino
        Me.btnDeleteExisting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDeleteExisting.Location = New System.Drawing.Point(957, 190)
        Me.btnDeleteExisting.Name = "btnDeleteExisting"
        Me.btnDeleteExisting.Size = New System.Drawing.Size(40, 40)
        Me.btnDeleteExisting.TabIndex = 11
        Me.btnDeleteExisting.UseVisualStyleBackColor = True
        '
        'Panel5
        '
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
        Me.Panel5.Location = New System.Drawing.Point(798, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(199, 168)
        Me.Panel5.TabIndex = 17
        '
        'txtRiordino
        '
        Me.txtRiordino.BackColor = System.Drawing.Color.White
        Me.txtRiordino.Location = New System.Drawing.Point(106, 37)
        Me.txtRiordino.Name = "txtRiordino"
        Me.txtRiordino.Size = New System.Drawing.Size(70, 20)
        Me.txtRiordino.TabIndex = 18
        '
        'lblRiordino
        '
        Me.lblRiordino.AutoSize = True
        Me.lblRiordino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRiordino.Location = New System.Drawing.Point(29, 39)
        Me.lblRiordino.Name = "lblRiordino"
        Me.lblRiordino.Size = New System.Drawing.Size(71, 16)
        Me.lblRiordino.TabIndex = 17
        Me.lblRiordino.Text = "Riordino:"
        Me.lblRiordino.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLotto
        '
        Me.txtLotto.BackColor = System.Drawing.Color.White
        Me.txtLotto.Location = New System.Drawing.Point(106, 89)
        Me.txtLotto.Name = "txtLotto"
        Me.txtLotto.Size = New System.Drawing.Size(70, 20)
        Me.txtLotto.TabIndex = 16
        '
        'lblLotto
        '
        Me.lblLotto.AutoSize = True
        Me.lblLotto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLotto.Location = New System.Drawing.Point(54, 91)
        Me.lblLotto.Name = "lblLotto"
        Me.lblLotto.Size = New System.Drawing.Size(46, 16)
        Me.lblLotto.TabIndex = 3
        Me.lblLotto.Text = "Lotto:"
        Me.lblLotto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtScortaSicurezza
        '
        Me.txtScortaSicurezza.BackColor = System.Drawing.Color.White
        Me.txtScortaSicurezza.Location = New System.Drawing.Point(106, 63)
        Me.txtScortaSicurezza.Name = "txtScortaSicurezza"
        Me.txtScortaSicurezza.Size = New System.Drawing.Size(70, 20)
        Me.txtScortaSicurezza.TabIndex = 20
        '
        'lblScortaSicurezza
        '
        Me.lblScortaSicurezza.AutoSize = True
        Me.lblScortaSicurezza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScortaSicurezza.Location = New System.Drawing.Point(43, 65)
        Me.lblScortaSicurezza.Name = "lblScortaSicurezza"
        Me.lblScortaSicurezza.Size = New System.Drawing.Size(57, 16)
        Me.lblScortaSicurezza.TabIndex = 19
        Me.lblScortaSicurezza.Text = "Scorta:"
        Me.lblScortaSicurezza.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTipoParte
        '
        Me.txtTipoParte.BackColor = System.Drawing.Color.White
        Me.txtTipoParte.Location = New System.Drawing.Point(106, 11)
        Me.txtTipoParte.Name = "txtTipoParte"
        Me.txtTipoParte.Size = New System.Drawing.Size(26, 20)
        Me.txtTipoParte.TabIndex = 22
        '
        'lblTipoParte
        '
        Me.lblTipoParte.AutoSize = True
        Me.lblTipoParte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoParte.Location = New System.Drawing.Point(16, 13)
        Me.lblTipoParte.Name = "lblTipoParte"
        Me.lblTipoParte.Size = New System.Drawing.Size(84, 16)
        Me.lblTipoParte.TabIndex = 21
        Me.lblTipoParte.Text = "Tipo parte:"
        Me.lblTipoParte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCostoUltimo
        '
        Me.txtCostoUltimo.BackColor = System.Drawing.Color.LightGray
        Me.txtCostoUltimo.Enabled = False
        Me.txtCostoUltimo.Location = New System.Drawing.Point(106, 115)
        Me.txtCostoUltimo.Name = "txtCostoUltimo"
        Me.txtCostoUltimo.ReadOnly = True
        Me.txtCostoUltimo.Size = New System.Drawing.Size(70, 20)
        Me.txtCostoUltimo.TabIndex = 10
        '
        'lblCostoUltimo
        '
        Me.lblCostoUltimo.AutoSize = True
        Me.lblCostoUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoUltimo.Location = New System.Drawing.Point(3, 117)
        Me.lblCostoUltimo.Name = "lblCostoUltimo"
        Me.lblCostoUltimo.Size = New System.Drawing.Size(97, 16)
        Me.lblCostoUltimo.TabIndex = 9
        Me.lblCostoUltimo.Text = "Costo ultimo:"
        '
        'frmArticlesDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 307)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btnDeleteExisting)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.pnlNote)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlSupplementaryDescription)
        Me.Controls.Add(Me.pnlConstructor)
        Me.Controls.Add(Me.pnlDescription)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlArolCode)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmArticlesDetails"
        Me.Text = "Article details"
        Me.pnlArolCode.ResumeLayout(False)
        Me.pnlArolCode.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlDescription.ResumeLayout(False)
        Me.pnlDescription.PerformLayout()
        Me.pnlConstructor.ResumeLayout(False)
        Me.pnlConstructor.PerformLayout()
        Me.pnlSupplementaryDescription.ResumeLayout(False)
        Me.pnlSupplementaryDescription.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnlNote.ResumeLayout(False)
        Me.pnlNote.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlArolCode As Panel
    Friend WithEvents lblArolCode As Label
    Friend WithEvents txtArolCode As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCodiceCommerciale As Label
    Friend WithEvents txtCommercialCode As TextBox
    Friend WithEvents pnlDescription As Panel
    Friend WithEvents lblDescrizione As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents pnlConstructor As Panel
    Friend WithEvents txtConstructor As TextBox
    Friend WithEvents lblConstructor As Label
    Friend WithEvents pnlSupplementaryDescription As Panel
    Friend WithEvents lblDescrizSupp As Label
    Friend WithEvents txtSuppDescription As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtInseritoDa As TextBox
    Friend WithEvents lblInseritoDa As Label
    Friend WithEvents txtDataInserimento As TextBox
    Friend WithEvents lblDataInserimento As Label
    Friend WithEvents txtCodificaRichiestaDa As TextBox
    Friend WithEvents lblCodificaRichiestaDa As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtDataUltimaModifica As TextBox
    Friend WithEvents txtModificatoDa As TextBox
    Friend WithEvents lblModificatoDa As Label
    Friend WithEvents lblDataUltimaModifica As Label
    Friend WithEvents txtStatoAttuale As TextBox
    Friend WithEvents lblStatoAttuale As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbxModificaStato As ComboBox
    Friend WithEvents lblModificaStato As Label
    Friend WithEvents txtNote As TextBox
    Friend WithEvents lblNote As Label
    Friend WithEvents pnlNote As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents btnDeleteExisting As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtLotto As TextBox
    Friend WithEvents lblLotto As Label
    Friend WithEvents txtRiordino As TextBox
    Friend WithEvents lblRiordino As Label
    Friend WithEvents txtTipoParte As TextBox
    Friend WithEvents lblTipoParte As Label
    Friend WithEvents txtScortaSicurezza As TextBox
    Friend WithEvents lblScortaSicurezza As Label
    Friend WithEvents txtCostoUltimo As TextBox
    Friend WithEvents lblCostoUltimo As Label
End Class
