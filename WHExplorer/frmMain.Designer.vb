<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtOpResult = New System.Windows.Forms.TextBox()
        Me.txtItemToFind = New System.Windows.Forms.TextBox()
        Me.dgvCEDBViewer = New System.Windows.Forms.DataGridView()
        Me.CompEleControl = New System.Windows.Forms.TabControl()
        Me.CompElePage = New System.Windows.Forms.TabPage()
        Me.ConsElePage = New System.Windows.Forms.TabPage()
        Me.dgvCSDBViewer = New System.Windows.Forms.DataGridView()
        Me.pnlExtendedData = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDataUltimaModifica = New System.Windows.Forms.TextBox()
        Me.txtModificatoDa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtStatoAttuale = New System.Windows.Forms.TextBox()
        Me.txtCodificaRichiestaDa = New System.Windows.Forms.TextBox()
        Me.lblStatoAttuale = New System.Windows.Forms.Label()
        Me.txtInseritoDa = New System.Windows.Forms.TextBox()
        Me.lblInseritoDa = New System.Windows.Forms.Label()
        Me.lblCodificaRichiestaDa = New System.Windows.Forms.Label()
        Me.txtDataInserimento = New System.Windows.Forms.TextBox()
        Me.lblDataInserimento = New System.Windows.Forms.Label()
        Me.pnlArolCode = New System.Windows.Forms.Panel()
        Me.txtArolCode = New System.Windows.Forms.TextBox()
        Me.lblArolCode = New System.Windows.Forms.Label()
        Me.pnlInstruments = New System.Windows.Forms.Panel()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.lblOpenDocs = New System.Windows.Forms.Label()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.btnReadFromFile = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnToCSV = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStrumenti = New System.Windows.Forms.Label()
        Me.btnInsertNew = New System.Windows.Forms.Button()
        Me.btnChildGenerator = New System.Windows.Forms.Button()
        Me.prgChildGeneration = New System.Windows.Forms.ProgressBar()
        Me.lblFindACode = New System.Windows.Forms.Label()
        Me.txtFindACode = New System.Windows.Forms.TextBox()
        Me.lblFindCCode = New System.Windows.Forms.Label()
        Me.txtFindCCode = New System.Windows.Forms.TextBox()
        Me.lblFindDescr = New System.Windows.Forms.Label()
        Me.txtFindDescr = New System.Windows.Forms.TextBox()
        Me.pnlAdvancedSearch = New System.Windows.Forms.Panel()
        Me.lblFindSupDescr = New System.Windows.Forms.Label()
        Me.txtFindSupDescr = New System.Windows.Forms.TextBox()
        Me.lblFindManufacturer = New System.Windows.Forms.Label()
        Me.txtFindManufacturer = New System.Windows.Forms.TextBox()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.pnlGuidedSearch = New System.Windows.Forms.Panel()
        Me.btnGuideSearch = New System.Windows.Forms.Button()
        Me.cbxSearchManufacturer = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxSearchCategory = New System.Windows.Forms.ComboBox()
        Me.lblSearchCategory = New System.Windows.Forms.Label()
        Me.pnlSimpleSearch = New System.Windows.Forms.Panel()
        Me.rbSimpleSearch = New System.Windows.Forms.RadioButton()
        Me.rbAdvancedSearch = New System.Windows.Forms.RadioButton()
        Me.rbGuidedSearch = New System.Windows.Forms.RadioButton()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.lblUserLogged = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HelpTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlFutureUse = New System.Windows.Forms.Panel()
        Me.lblEditSelected = New System.Windows.Forms.Label()
        Me.btnEditSelected = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewManufacturerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewDocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.csvFileExportBrwDial = New System.Windows.Forms.FolderBrowserDialog()
        Me.tabDocuments = New System.Windows.Forms.TabControl()
        Me.datasheetTabPage = New System.Windows.Forms.TabPage()
        Me.dgvDatasheets = New System.Windows.Forms.DataGridView()
        Me.UserManualTabPage = New System.Windows.Forms.TabPage()
        Me.dgvUserManuals = New System.Windows.Forms.DataGridView()
        Me.electricalDrawingTabPage = New System.Windows.Forms.TabPage()
        Me.dgvElectricalDrawings = New System.Windows.Forms.DataGridView()
        Me.ApplicationNoteTabPage = New System.Windows.Forms.TabPage()
        Me.dgvApplicationNotes = New System.Windows.Forms.DataGridView()
        Me.EconomicTabPage = New System.Windows.Forms.TabPage()
        Me.dgvEconomicBids = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Titolo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Versione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilePath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Url = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Open = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Percorso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Open2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercorsoFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Open3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercorsoFile2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Open4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercorsoFile3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Open5 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvCEDBViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CompEleControl.SuspendLayout()
        Me.CompElePage.SuspendLayout()
        Me.ConsElePage.SuspendLayout()
        CType(Me.dgvCSDBViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlExtendedData.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlNote.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlArolCode.SuspendLayout()
        Me.pnlInstruments.SuspendLayout()
        Me.pnlAdvancedSearch.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.pnlGuidedSearch.SuspendLayout()
        Me.pnlSimpleSearch.SuspendLayout()
        Me.pnlLogin.SuspendLayout()
        Me.pnlFutureUse.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.tabDocuments.SuspendLayout()
        Me.datasheetTabPage.SuspendLayout()
        CType(Me.dgvDatasheets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserManualTabPage.SuspendLayout()
        CType(Me.dgvUserManuals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.electricalDrawingTabPage.SuspendLayout()
        CType(Me.dgvElectricalDrawings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ApplicationNoteTabPage.SuspendLayout()
        CType(Me.dgvApplicationNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EconomicTabPage.SuspendLayout()
        CType(Me.dgvEconomicBids, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOpResult
        '
        Me.txtOpResult.Enabled = False
        Me.txtOpResult.Location = New System.Drawing.Point(1318, 867)
        Me.txtOpResult.Name = "txtOpResult"
        Me.txtOpResult.Size = New System.Drawing.Size(259, 20)
        Me.txtOpResult.TabIndex = 2
        '
        'txtItemToFind
        '
        Me.txtItemToFind.Location = New System.Drawing.Point(5, 21)
        Me.txtItemToFind.Name = "txtItemToFind"
        Me.txtItemToFind.Size = New System.Drawing.Size(140, 20)
        Me.txtItemToFind.TabIndex = 3
        Me.HelpTip.SetToolTip(Me.txtItemToFind, "Testo da ricercare")
        '
        'dgvCEDBViewer
        '
        Me.dgvCEDBViewer.AllowUserToOrderColumns = True
        Me.dgvCEDBViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCEDBViewer.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvCEDBViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCEDBViewer.Location = New System.Drawing.Point(0, 0)
        Me.dgvCEDBViewer.Name = "dgvCEDBViewer"
        Me.dgvCEDBViewer.Size = New System.Drawing.Size(1548, 613)
        Me.dgvCEDBViewer.TabIndex = 5
        Me.dgvCEDBViewer.Visible = False
        '
        'CompEleControl
        '
        Me.CompEleControl.Controls.Add(Me.CompElePage)
        Me.CompEleControl.Controls.Add(Me.ConsElePage)
        Me.CompEleControl.Location = New System.Drawing.Point(12, 213)
        Me.CompEleControl.Name = "CompEleControl"
        Me.CompEleControl.SelectedIndex = 0
        Me.CompEleControl.Size = New System.Drawing.Size(1097, 648)
        Me.CompEleControl.TabIndex = 6
        '
        'CompElePage
        '
        Me.CompElePage.Controls.Add(Me.dgvCEDBViewer)
        Me.CompElePage.Location = New System.Drawing.Point(4, 22)
        Me.CompElePage.Name = "CompElePage"
        Me.CompElePage.Padding = New System.Windows.Forms.Padding(3)
        Me.CompElePage.Size = New System.Drawing.Size(1089, 622)
        Me.CompElePage.TabIndex = 0
        Me.CompElePage.Text = "Componenti Elettrici"
        Me.CompElePage.UseVisualStyleBackColor = True
        '
        'ConsElePage
        '
        Me.ConsElePage.Controls.Add(Me.dgvCSDBViewer)
        Me.ConsElePage.Location = New System.Drawing.Point(4, 22)
        Me.ConsElePage.Name = "ConsElePage"
        Me.ConsElePage.Padding = New System.Windows.Forms.Padding(3)
        Me.ConsElePage.Size = New System.Drawing.Size(1089, 622)
        Me.ConsElePage.TabIndex = 1
        Me.ConsElePage.Text = "Consumabili"
        Me.ConsElePage.UseVisualStyleBackColor = True
        '
        'dgvCSDBViewer
        '
        Me.dgvCSDBViewer.AllowUserToOrderColumns = True
        Me.dgvCSDBViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCSDBViewer.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvCSDBViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCSDBViewer.Location = New System.Drawing.Point(3, 3)
        Me.dgvCSDBViewer.Name = "dgvCSDBViewer"
        Me.dgvCSDBViewer.ReadOnly = True
        Me.dgvCSDBViewer.Size = New System.Drawing.Size(1190, 560)
        Me.dgvCSDBViewer.TabIndex = 0
        Me.dgvCSDBViewer.Visible = False
        '
        'pnlExtendedData
        '
        Me.pnlExtendedData.BackColor = System.Drawing.Color.Transparent
        Me.pnlExtendedData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlExtendedData.Controls.Add(Me.Panel1)
        Me.pnlExtendedData.Controls.Add(Me.pnlNote)
        Me.pnlExtendedData.Controls.Add(Me.Panel5)
        Me.pnlExtendedData.Controls.Add(Me.Panel2)
        Me.pnlExtendedData.Controls.Add(Me.pnlArolCode)
        Me.pnlExtendedData.Location = New System.Drawing.Point(1121, 235)
        Me.pnlExtendedData.Name = "pnlExtendedData"
        Me.pnlExtendedData.Size = New System.Drawing.Size(452, 626)
        Me.pnlExtendedData.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtDataUltimaModifica)
        Me.Panel1.Controls.Add(Me.txtModificatoDa)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(149, 516)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 95)
        Me.Panel1.TabIndex = 20
        '
        'txtDataUltimaModifica
        '
        Me.txtDataUltimaModifica.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataUltimaModifica.Location = New System.Drawing.Point(6, 19)
        Me.txtDataUltimaModifica.Name = "txtDataUltimaModifica"
        Me.txtDataUltimaModifica.ReadOnly = True
        Me.txtDataUltimaModifica.Size = New System.Drawing.Size(147, 20)
        Me.txtDataUltimaModifica.TabIndex = 8
        '
        'txtModificatoDa
        '
        Me.txtModificatoDa.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtModificatoDa.Location = New System.Drawing.Point(6, 62)
        Me.txtModificatoDa.Name = "txtModificatoDa"
        Me.txtModificatoDa.ReadOnly = True
        Me.txtModificatoDa.Size = New System.Drawing.Size(147, 20)
        Me.txtModificatoDa.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Modificato da"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Ultima modifica"
        '
        'pnlNote
        '
        Me.pnlNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNote.Controls.Add(Me.txtNote)
        Me.pnlNote.Controls.Add(Me.lblNote)
        Me.pnlNote.Location = New System.Drawing.Point(149, 295)
        Me.pnlNote.Name = "pnlNote"
        Me.pnlNote.Size = New System.Drawing.Size(292, 215)
        Me.pnlNote.TabIndex = 19
        '
        'txtNote
        '
        Me.txtNote.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNote.Location = New System.Drawing.Point(6, 22)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ReadOnly = True
        Me.txtNote.Size = New System.Drawing.Size(274, 186)
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
        Me.Panel5.Location = New System.Drawing.Point(149, 121)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(292, 168)
        Me.Panel5.TabIndex = 18
        '
        'txtCostoUltimo
        '
        Me.txtCostoUltimo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCostoUltimo.Location = New System.Drawing.Point(106, 115)
        Me.txtCostoUltimo.Name = "txtCostoUltimo"
        Me.txtCostoUltimo.ReadOnly = True
        Me.txtCostoUltimo.Size = New System.Drawing.Size(70, 20)
        Me.txtCostoUltimo.TabIndex = 10
        '
        'txtTipoParte
        '
        Me.txtTipoParte.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTipoParte.Location = New System.Drawing.Point(106, 11)
        Me.txtTipoParte.Name = "txtTipoParte"
        Me.txtTipoParte.ReadOnly = True
        Me.txtTipoParte.Size = New System.Drawing.Size(26, 20)
        Me.txtTipoParte.TabIndex = 22
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
        'txtScortaSicurezza
        '
        Me.txtScortaSicurezza.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtScortaSicurezza.Location = New System.Drawing.Point(106, 63)
        Me.txtScortaSicurezza.Name = "txtScortaSicurezza"
        Me.txtScortaSicurezza.ReadOnly = True
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
        'txtRiordino
        '
        Me.txtRiordino.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRiordino.Location = New System.Drawing.Point(106, 37)
        Me.txtRiordino.Name = "txtRiordino"
        Me.txtRiordino.ReadOnly = True
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
        Me.txtLotto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLotto.Location = New System.Drawing.Point(106, 89)
        Me.txtLotto.Name = "txtLotto"
        Me.txtLotto.ReadOnly = True
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
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtStatoAttuale)
        Me.Panel2.Controls.Add(Me.txtCodificaRichiestaDa)
        Me.Panel2.Controls.Add(Me.lblStatoAttuale)
        Me.Panel2.Controls.Add(Me.txtInseritoDa)
        Me.Panel2.Controls.Add(Me.lblInseritoDa)
        Me.Panel2.Controls.Add(Me.lblCodificaRichiestaDa)
        Me.Panel2.Controls.Add(Me.txtDataInserimento)
        Me.Panel2.Controls.Add(Me.lblDataInserimento)
        Me.Panel2.Location = New System.Drawing.Point(149, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(292, 109)
        Me.Panel2.TabIndex = 6
        '
        'txtStatoAttuale
        '
        Me.txtStatoAttuale.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtStatoAttuale.Location = New System.Drawing.Point(133, 65)
        Me.txtStatoAttuale.Name = "txtStatoAttuale"
        Me.txtStatoAttuale.ReadOnly = True
        Me.txtStatoAttuale.Size = New System.Drawing.Size(100, 20)
        Me.txtStatoAttuale.TabIndex = 4
        '
        'txtCodificaRichiestaDa
        '
        Me.txtCodificaRichiestaDa.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodificaRichiestaDa.Location = New System.Drawing.Point(133, 22)
        Me.txtCodificaRichiestaDa.Name = "txtCodificaRichiestaDa"
        Me.txtCodificaRichiestaDa.ReadOnly = True
        Me.txtCodificaRichiestaDa.Size = New System.Drawing.Size(147, 20)
        Me.txtCodificaRichiestaDa.TabIndex = 8
        '
        'lblStatoAttuale
        '
        Me.lblStatoAttuale.AutoSize = True
        Me.lblStatoAttuale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatoAttuale.Location = New System.Drawing.Point(130, 46)
        Me.lblStatoAttuale.Name = "lblStatoAttuale"
        Me.lblStatoAttuale.Size = New System.Drawing.Size(95, 16)
        Me.lblStatoAttuale.TabIndex = 3
        Me.lblStatoAttuale.Text = "Stato attuale"
        '
        'txtInseritoDa
        '
        Me.txtInseritoDa.BackColor = System.Drawing.Color.WhiteSmoke
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
        Me.txtDataInserimento.BackColor = System.Drawing.Color.WhiteSmoke
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
        'pnlArolCode
        '
        Me.pnlArolCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlArolCode.Controls.Add(Me.txtArolCode)
        Me.pnlArolCode.Controls.Add(Me.lblArolCode)
        Me.pnlArolCode.Location = New System.Drawing.Point(14, 6)
        Me.pnlArolCode.Name = "pnlArolCode"
        Me.pnlArolCode.Size = New System.Drawing.Size(119, 53)
        Me.pnlArolCode.TabIndex = 3
        '
        'txtArolCode
        '
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
        'pnlInstruments
        '
        Me.pnlInstruments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlInstruments.Controls.Add(Me.btnOpenFile)
        Me.pnlInstruments.Controls.Add(Me.lblOpenDocs)
        Me.pnlInstruments.Controls.Add(Me.btnDetails)
        Me.pnlInstruments.Controls.Add(Me.Label4)
        Me.pnlInstruments.Controls.Add(Me.lblDetails)
        Me.pnlInstruments.Controls.Add(Me.btnReadFromFile)
        Me.pnlInstruments.Controls.Add(Me.Label10)
        Me.pnlInstruments.Controls.Add(Me.Label3)
        Me.pnlInstruments.Controls.Add(Me.btnToCSV)
        Me.pnlInstruments.Controls.Add(Me.Label1)
        Me.pnlInstruments.Controls.Add(Me.lblStrumenti)
        Me.pnlInstruments.Controls.Add(Me.btnInsertNew)
        Me.pnlInstruments.Controls.Add(Me.btnChildGenerator)
        Me.pnlInstruments.Controls.Add(Me.prgChildGeneration)
        Me.pnlInstruments.Location = New System.Drawing.Point(187, 31)
        Me.pnlInstruments.Name = "pnlInstruments"
        Me.pnlInstruments.Size = New System.Drawing.Size(161, 177)
        Me.pnlInstruments.TabIndex = 15
        '
        'btnOpenFile
        '
        Me.btnOpenFile.BackgroundImage = CType(resources.GetObject("btnOpenFile.BackgroundImage"), System.Drawing.Image)
        Me.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOpenFile.Location = New System.Drawing.Point(109, 96)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(40, 40)
        Me.btnOpenFile.TabIndex = 11
        Me.HelpTip.SetToolTip(Me.btnOpenFile, "Apri file allegato")
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'lblOpenDocs
        '
        Me.lblOpenDocs.AutoSize = True
        Me.lblOpenDocs.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpenDocs.Location = New System.Drawing.Point(101, 139)
        Me.lblOpenDocs.Name = "lblOpenDocs"
        Me.lblOpenDocs.Size = New System.Drawing.Size(57, 12)
        Me.lblOpenDocs.TabIndex = 26
        Me.lblOpenDocs.Text = "OpenDocs"
        Me.lblOpenDocs.Visible = False
        '
        'btnDetails
        '
        Me.btnDetails.BackgroundImage = CType(resources.GetObject("btnDetails.BackgroundImage"), System.Drawing.Image)
        Me.btnDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDetails.Location = New System.Drawing.Point(57, 96)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(40, 40)
        Me.btnDetails.TabIndex = 28
        Me.HelpTip.SetToolTip(Me.btnDetails, "Vedi dettagli")
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 12)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Rd Child"
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.Location = New System.Drawing.Point(57, 139)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(41, 12)
        Me.lblDetails.TabIndex = 29
        Me.lblDetails.Text = "Details"
        '
        'btnReadFromFile
        '
        Me.btnReadFromFile.BackgroundImage = CType(resources.GetObject("btnReadFromFile.BackgroundImage"), System.Drawing.Image)
        Me.btnReadFromFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReadFromFile.Enabled = False
        Me.btnReadFromFile.Location = New System.Drawing.Point(109, 23)
        Me.btnReadFromFile.Name = "btnReadFromFile"
        Me.btnReadFromFile.Size = New System.Drawing.Size(40, 40)
        Me.btnReadFromFile.TabIndex = 25
        Me.btnReadFromFile.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 12)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "ToCSV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 12)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Wr Child"
        '
        'btnToCSV
        '
        Me.btnToCSV.BackgroundImage = Global.Xplorer.My.Resources.Resources.writeCSV
        Me.btnToCSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnToCSV.Location = New System.Drawing.Point(5, 96)
        Me.btnToCSV.Name = "btnToCSV"
        Me.btnToCSV.Size = New System.Drawing.Size(40, 40)
        Me.btnToCSV.TabIndex = 27
        Me.btnToCSV.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 12)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "New"
        '
        'lblStrumenti
        '
        Me.lblStrumenti.AutoSize = True
        Me.lblStrumenti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrumenti.Location = New System.Drawing.Point(3, 3)
        Me.lblStrumenti.Name = "lblStrumenti"
        Me.lblStrumenti.Size = New System.Drawing.Size(76, 16)
        Me.lblStrumenti.TabIndex = 21
        Me.lblStrumenti.Text = "Strumenti:"
        '
        'btnInsertNew
        '
        Me.btnInsertNew.BackgroundImage = CType(resources.GetObject("btnInsertNew.BackgroundImage"), System.Drawing.Image)
        Me.btnInsertNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInsertNew.Enabled = False
        Me.btnInsertNew.Location = New System.Drawing.Point(5, 23)
        Me.btnInsertNew.Name = "btnInsertNew"
        Me.btnInsertNew.Size = New System.Drawing.Size(40, 40)
        Me.btnInsertNew.TabIndex = 12
        Me.HelpTip.SetToolTip(Me.btnInsertNew, "Inserisci nuovo")
        Me.btnInsertNew.UseVisualStyleBackColor = True
        '
        'btnChildGenerator
        '
        Me.btnChildGenerator.BackgroundImage = CType(resources.GetObject("btnChildGenerator.BackgroundImage"), System.Drawing.Image)
        Me.btnChildGenerator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChildGenerator.Enabled = False
        Me.btnChildGenerator.Location = New System.Drawing.Point(62, 23)
        Me.btnChildGenerator.Name = "btnChildGenerator"
        Me.btnChildGenerator.Size = New System.Drawing.Size(30, 30)
        Me.btnChildGenerator.TabIndex = 16
        Me.HelpTip.SetToolTip(Me.btnChildGenerator, "Genera Figli.txt")
        Me.btnChildGenerator.UseVisualStyleBackColor = True
        '
        'prgChildGeneration
        '
        Me.prgChildGeneration.Location = New System.Drawing.Point(48, 53)
        Me.prgChildGeneration.Name = "prgChildGeneration"
        Me.prgChildGeneration.Size = New System.Drawing.Size(56, 10)
        Me.prgChildGeneration.TabIndex = 17
        '
        'lblFindACode
        '
        Me.lblFindACode.AutoSize = True
        Me.lblFindACode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFindACode.Location = New System.Drawing.Point(3, 6)
        Me.lblFindACode.Name = "lblFindACode"
        Me.lblFindACode.Size = New System.Drawing.Size(66, 13)
        Me.lblFindACode.TabIndex = 19
        Me.lblFindACode.Text = "Arol Code:"
        '
        'txtFindACode
        '
        Me.txtFindACode.Location = New System.Drawing.Point(3, 25)
        Me.txtFindACode.Name = "txtFindACode"
        Me.txtFindACode.Size = New System.Drawing.Size(100, 20)
        Me.txtFindACode.TabIndex = 20
        '
        'lblFindCCode
        '
        Me.lblFindCCode.AutoSize = True
        Me.lblFindCCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFindCCode.Location = New System.Drawing.Point(109, 6)
        Me.lblFindCCode.Name = "lblFindCCode"
        Me.lblFindCCode.Size = New System.Drawing.Size(108, 13)
        Me.lblFindCCode.TabIndex = 22
        Me.lblFindCCode.Text = "Commercial Code:"
        '
        'txtFindCCode
        '
        Me.txtFindCCode.Location = New System.Drawing.Point(109, 25)
        Me.txtFindCCode.Name = "txtFindCCode"
        Me.txtFindCCode.Size = New System.Drawing.Size(108, 20)
        Me.txtFindCCode.TabIndex = 23
        '
        'lblFindDescr
        '
        Me.lblFindDescr.AutoSize = True
        Me.lblFindDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFindDescr.Location = New System.Drawing.Point(223, 6)
        Me.lblFindDescr.Name = "lblFindDescr"
        Me.lblFindDescr.Size = New System.Drawing.Size(75, 13)
        Me.lblFindDescr.TabIndex = 25
        Me.lblFindDescr.Text = "Description:"
        '
        'txtFindDescr
        '
        Me.txtFindDescr.Location = New System.Drawing.Point(223, 25)
        Me.txtFindDescr.Name = "txtFindDescr"
        Me.txtFindDescr.Size = New System.Drawing.Size(251, 20)
        Me.txtFindDescr.TabIndex = 26
        '
        'pnlAdvancedSearch
        '
        Me.pnlAdvancedSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlAdvancedSearch.Controls.Add(Me.lblFindSupDescr)
        Me.pnlAdvancedSearch.Controls.Add(Me.txtFindSupDescr)
        Me.pnlAdvancedSearch.Controls.Add(Me.lblFindManufacturer)
        Me.pnlAdvancedSearch.Controls.Add(Me.txtFindManufacturer)
        Me.pnlAdvancedSearch.Controls.Add(Me.lblFindDescr)
        Me.pnlAdvancedSearch.Controls.Add(Me.txtFindDescr)
        Me.pnlAdvancedSearch.Controls.Add(Me.lblFindCCode)
        Me.pnlAdvancedSearch.Controls.Add(Me.txtFindCCode)
        Me.pnlAdvancedSearch.Controls.Add(Me.lblFindACode)
        Me.pnlAdvancedSearch.Controls.Add(Me.txtFindACode)
        Me.pnlAdvancedSearch.Enabled = False
        Me.pnlAdvancedSearch.Location = New System.Drawing.Point(3, 27)
        Me.pnlAdvancedSearch.Name = "pnlAdvancedSearch"
        Me.pnlAdvancedSearch.Size = New System.Drawing.Size(1208, 60)
        Me.pnlAdvancedSearch.TabIndex = 28
        '
        'lblFindSupDescr
        '
        Me.lblFindSupDescr.AutoSize = True
        Me.lblFindSupDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFindSupDescr.Location = New System.Drawing.Point(594, 6)
        Me.lblFindSupDescr.Name = "lblFindSupDescr"
        Me.lblFindSupDescr.Size = New System.Drawing.Size(162, 13)
        Me.lblFindSupDescr.TabIndex = 28
        Me.lblFindSupDescr.Text = "Supplementary Descritpion:"
        '
        'txtFindSupDescr
        '
        Me.txtFindSupDescr.Location = New System.Drawing.Point(594, 25)
        Me.txtFindSupDescr.Name = "txtFindSupDescr"
        Me.txtFindSupDescr.Size = New System.Drawing.Size(557, 20)
        Me.txtFindSupDescr.TabIndex = 29
        '
        'lblFindManufacturer
        '
        Me.lblFindManufacturer.AutoSize = True
        Me.lblFindManufacturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFindManufacturer.Location = New System.Drawing.Point(480, 6)
        Me.lblFindManufacturer.Name = "lblFindManufacturer"
        Me.lblFindManufacturer.Size = New System.Drawing.Size(86, 13)
        Me.lblFindManufacturer.TabIndex = 22
        Me.lblFindManufacturer.Text = "Manufacturer:"
        '
        'txtFindManufacturer
        '
        Me.txtFindManufacturer.Location = New System.Drawing.Point(480, 25)
        Me.txtFindManufacturer.Name = "txtFindManufacturer"
        Me.txtFindManufacturer.Size = New System.Drawing.Size(108, 20)
        Me.txtFindManufacturer.TabIndex = 23
        '
        'pnlSearch
        '
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSearch.Controls.Add(Me.pnlGuidedSearch)
        Me.pnlSearch.Controls.Add(Me.pnlSimpleSearch)
        Me.pnlSearch.Controls.Add(Me.rbSimpleSearch)
        Me.pnlSearch.Controls.Add(Me.rbAdvancedSearch)
        Me.pnlSearch.Controls.Add(Me.rbGuidedSearch)
        Me.pnlSearch.Controls.Add(Me.pnlAdvancedSearch)
        Me.pnlSearch.Location = New System.Drawing.Point(354, 31)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(1219, 177)
        Me.pnlSearch.TabIndex = 19
        '
        'pnlGuidedSearch
        '
        Me.pnlGuidedSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGuidedSearch.Controls.Add(Me.btnGuideSearch)
        Me.pnlGuidedSearch.Controls.Add(Me.cbxSearchManufacturer)
        Me.pnlGuidedSearch.Controls.Add(Me.Label9)
        Me.pnlGuidedSearch.Controls.Add(Me.cbxSearchCategory)
        Me.pnlGuidedSearch.Controls.Add(Me.lblSearchCategory)
        Me.pnlGuidedSearch.Enabled = False
        Me.pnlGuidedSearch.Location = New System.Drawing.Point(177, 118)
        Me.pnlGuidedSearch.Name = "pnlGuidedSearch"
        Me.pnlGuidedSearch.Size = New System.Drawing.Size(416, 47)
        Me.pnlGuidedSearch.TabIndex = 38
        '
        'btnGuideSearch
        '
        Me.btnGuideSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuideSearch.Location = New System.Drawing.Point(219, 18)
        Me.btnGuideSearch.Name = "btnGuideSearch"
        Me.btnGuideSearch.Size = New System.Drawing.Size(44, 21)
        Me.btnGuideSearch.TabIndex = 39
        Me.btnGuideSearch.Text = "OR"
        Me.btnGuideSearch.UseVisualStyleBackColor = True
        '
        'cbxSearchManufacturer
        '
        Me.cbxSearchManufacturer.FormattingEnabled = True
        Me.cbxSearchManufacturer.Location = New System.Drawing.Point(265, 18)
        Me.cbxSearchManufacturer.Name = "cbxSearchManufacturer"
        Me.cbxSearchManufacturer.Size = New System.Drawing.Size(138, 21)
        Me.cbxSearchManufacturer.TabIndex = 38
        Me.cbxSearchManufacturer.Text = "Seleziona il costruttore..."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(265, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Manufacturer:"
        '
        'cbxSearchCategory
        '
        Me.cbxSearchCategory.FormattingEnabled = True
        Me.cbxSearchCategory.Location = New System.Drawing.Point(3, 18)
        Me.cbxSearchCategory.Name = "cbxSearchCategory"
        Me.cbxSearchCategory.Size = New System.Drawing.Size(214, 21)
        Me.cbxSearchCategory.TabIndex = 37
        Me.cbxSearchCategory.Text = "Seleziona la categoria..."
        '
        'lblSearchCategory
        '
        Me.lblSearchCategory.AutoSize = True
        Me.lblSearchCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchCategory.Location = New System.Drawing.Point(3, 3)
        Me.lblSearchCategory.Name = "lblSearchCategory"
        Me.lblSearchCategory.Size = New System.Drawing.Size(61, 13)
        Me.lblSearchCategory.TabIndex = 21
        Me.lblSearchCategory.Text = "Category:"
        '
        'pnlSimpleSearch
        '
        Me.pnlSimpleSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSimpleSearch.Controls.Add(Me.txtItemToFind)
        Me.pnlSimpleSearch.Enabled = False
        Me.pnlSimpleSearch.Location = New System.Drawing.Point(3, 118)
        Me.pnlSimpleSearch.Name = "pnlSimpleSearch"
        Me.pnlSimpleSearch.Size = New System.Drawing.Size(154, 49)
        Me.pnlSimpleSearch.TabIndex = 37
        '
        'rbSimpleSearch
        '
        Me.rbSimpleSearch.AutoSize = True
        Me.rbSimpleSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSimpleSearch.Location = New System.Drawing.Point(3, 93)
        Me.rbSimpleSearch.Name = "rbSimpleSearch"
        Me.rbSimpleSearch.Size = New System.Drawing.Size(147, 20)
        Me.rbSimpleSearch.TabIndex = 35
        Me.rbSimpleSearch.TabStop = True
        Me.rbSimpleSearch.Text = "Ricerca semplice"
        Me.rbSimpleSearch.UseVisualStyleBackColor = True
        '
        'rbAdvancedSearch
        '
        Me.rbAdvancedSearch.AutoSize = True
        Me.rbAdvancedSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAdvancedSearch.Location = New System.Drawing.Point(3, 3)
        Me.rbAdvancedSearch.Name = "rbAdvancedSearch"
        Me.rbAdvancedSearch.Size = New System.Drawing.Size(147, 20)
        Me.rbAdvancedSearch.TabIndex = 34
        Me.rbAdvancedSearch.TabStop = True
        Me.rbAdvancedSearch.Text = "Ricerca avanzata"
        Me.rbAdvancedSearch.UseVisualStyleBackColor = True
        '
        'rbGuidedSearch
        '
        Me.rbGuidedSearch.AutoSize = True
        Me.rbGuidedSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGuidedSearch.Location = New System.Drawing.Point(177, 93)
        Me.rbGuidedSearch.Name = "rbGuidedSearch"
        Me.rbGuidedSearch.Size = New System.Drawing.Size(136, 20)
        Me.rbGuidedSearch.TabIndex = 36
        Me.rbGuidedSearch.TabStop = True
        Me.rbGuidedSearch.Text = "Ricerca guidata"
        Me.rbGuidedSearch.UseVisualStyleBackColor = True
        '
        'pnlLogin
        '
        Me.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlLogin.Controls.Add(Me.lblUserLogged)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.Label7)
        Me.pnlLogin.Controls.Add(Me.txtUserName)
        Me.pnlLogin.Controls.Add(Me.Label6)
        Me.pnlLogin.Controls.Add(Me.Label5)
        Me.pnlLogin.Location = New System.Drawing.Point(12, 31)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(169, 103)
        Me.pnlLogin.TabIndex = 20
        '
        'lblUserLogged
        '
        Me.lblUserLogged.AutoSize = True
        Me.lblUserLogged.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserLogged.Location = New System.Drawing.Point(53, 6)
        Me.lblUserLogged.Name = "lblUserLogged"
        Me.lblUserLogged.Size = New System.Drawing.Size(85, 13)
        Me.lblUserLogged.TabIndex = 31
        Me.lblUserLogged.Text = "No User Logged"
        '
        'btnLogin
        '
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.Enabled = False
        Me.btnLogin.Location = New System.Drawing.Point(7, 68)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(30, 30)
        Me.btnLogin.TabIndex = 5
        Me.HelpTip.SetToolTip(Me.btnLogin, "Press to Login")
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(47, 47)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(115, 20)
        Me.txtPassword.TabIndex = 30
        Me.HelpTip.SetToolTip(Me.txtPassword, "Inserisci password")
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 12)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "PWD"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(47, 23)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(115, 20)
        Me.txtUserName.TabIndex = 28
        Me.HelpTip.SetToolTip(Me.txtUserName, "Inserisci la tua email")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 12)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Login:"
        '
        'HelpTip
        '
        Me.HelpTip.AutoPopDelay = 2000
        Me.HelpTip.InitialDelay = 500
        Me.HelpTip.ReshowDelay = 100
        Me.HelpTip.ToolTipTitle = "Help"
        '
        'pnlFutureUse
        '
        Me.pnlFutureUse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlFutureUse.Controls.Add(Me.lblEditSelected)
        Me.pnlFutureUse.Controls.Add(Me.btnEditSelected)
        Me.pnlFutureUse.Location = New System.Drawing.Point(12, 137)
        Me.pnlFutureUse.Name = "pnlFutureUse"
        Me.pnlFutureUse.Size = New System.Drawing.Size(169, 71)
        Me.pnlFutureUse.TabIndex = 27
        '
        'lblEditSelected
        '
        Me.lblEditSelected.AutoSize = True
        Me.lblEditSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditSelected.Location = New System.Drawing.Point(62, 49)
        Me.lblEditSelected.Name = "lblEditSelected"
        Me.lblEditSelected.Size = New System.Drawing.Size(69, 12)
        Me.lblEditSelected.TabIndex = 30
        Me.lblEditSelected.Text = "EditSelected"
        '
        'btnEditSelected
        '
        Me.btnEditSelected.BackgroundImage = Global.Xplorer.My.Resources.Resources.edit
        Me.btnEditSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditSelected.Location = New System.Drawing.Point(76, 5)
        Me.btnEditSelected.Name = "btnEditSelected"
        Me.btnEditSelected.Size = New System.Drawing.Size(40, 40)
        Me.btnEditSelected.TabIndex = 31
        Me.btnEditSelected.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem, Me.DatabaseToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1580, 24)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageUserToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.ToolsToolStripMenuItem.Text = "User"
        '
        'ManageUserToolStripMenuItem
        '
        Me.ManageUserToolStripMenuItem.Name = "ManageUserToolStripMenuItem"
        Me.ManageUserToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ManageUserToolStripMenuItem.Text = "Manage User"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewManufacturerToolStripMenuItem, Me.NewDocumentToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'NewManufacturerToolStripMenuItem
        '
        Me.NewManufacturerToolStripMenuItem.Name = "NewManufacturerToolStripMenuItem"
        Me.NewManufacturerToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.NewManufacturerToolStripMenuItem.Text = "New Manufacturer..."
        '
        'NewDocumentToolStripMenuItem
        '
        Me.NewDocumentToolStripMenuItem.Name = "NewDocumentToolStripMenuItem"
        Me.NewDocumentToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.NewDocumentToolStripMenuItem.Text = "New Document..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tabDocuments
        '
        Me.tabDocuments.Controls.Add(Me.datasheetTabPage)
        Me.tabDocuments.Controls.Add(Me.UserManualTabPage)
        Me.tabDocuments.Controls.Add(Me.electricalDrawingTabPage)
        Me.tabDocuments.Controls.Add(Me.ApplicationNoteTabPage)
        Me.tabDocuments.Controls.Add(Me.EconomicTabPage)
        Me.tabDocuments.Location = New System.Drawing.Point(12, 867)
        Me.tabDocuments.Name = "tabDocuments"
        Me.tabDocuments.SelectedIndex = 0
        Me.tabDocuments.Size = New System.Drawing.Size(1097, 146)
        Me.tabDocuments.TabIndex = 29
        '
        'datasheetTabPage
        '
        Me.datasheetTabPage.BackColor = System.Drawing.Color.LightGray
        Me.datasheetTabPage.Controls.Add(Me.dgvDatasheets)
        Me.datasheetTabPage.Location = New System.Drawing.Point(4, 22)
        Me.datasheetTabPage.Name = "datasheetTabPage"
        Me.datasheetTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.datasheetTabPage.Size = New System.Drawing.Size(1089, 120)
        Me.datasheetTabPage.TabIndex = 0
        Me.datasheetTabPage.Text = "Datasheet"
        '
        'dgvDatasheets
        '
        Me.dgvDatasheets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDatasheets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatasheets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Tipo, Me.Titolo, Me.Versione, Me.FilePath, Me.Url, Me.Open})
        Me.dgvDatasheets.Location = New System.Drawing.Point(4, 3)
        Me.dgvDatasheets.Name = "dgvDatasheets"
        Me.dgvDatasheets.Size = New System.Drawing.Size(1082, 114)
        Me.dgvDatasheets.TabIndex = 0
        '
        'UserManualTabPage
        '
        Me.UserManualTabPage.BackColor = System.Drawing.Color.LightGray
        Me.UserManualTabPage.Controls.Add(Me.dgvUserManuals)
        Me.UserManualTabPage.Location = New System.Drawing.Point(4, 22)
        Me.UserManualTabPage.Name = "UserManualTabPage"
        Me.UserManualTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.UserManualTabPage.Size = New System.Drawing.Size(1089, 189)
        Me.UserManualTabPage.TabIndex = 1
        Me.UserManualTabPage.Text = "User Manual"
        '
        'dgvUserManuals
        '
        Me.dgvUserManuals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvUserManuals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserManuals.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Percorso, Me.DataGridViewTextBoxColumn5, Me.Open2})
        Me.dgvUserManuals.Location = New System.Drawing.Point(3, 3)
        Me.dgvUserManuals.Name = "dgvUserManuals"
        Me.dgvUserManuals.Size = New System.Drawing.Size(1082, 114)
        Me.dgvUserManuals.TabIndex = 1
        '
        'electricalDrawingTabPage
        '
        Me.electricalDrawingTabPage.BackColor = System.Drawing.Color.LightGray
        Me.electricalDrawingTabPage.Controls.Add(Me.dgvElectricalDrawings)
        Me.electricalDrawingTabPage.Location = New System.Drawing.Point(4, 22)
        Me.electricalDrawingTabPage.Name = "electricalDrawingTabPage"
        Me.electricalDrawingTabPage.Size = New System.Drawing.Size(1089, 189)
        Me.electricalDrawingTabPage.TabIndex = 2
        Me.electricalDrawingTabPage.Text = "Electrical Drawing"
        '
        'dgvElectricalDrawings
        '
        Me.dgvElectricalDrawings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvElectricalDrawings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvElectricalDrawings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.PercorsoFile, Me.DataGridViewTextBoxColumn10, Me.Open3})
        Me.dgvElectricalDrawings.Location = New System.Drawing.Point(3, 3)
        Me.dgvElectricalDrawings.Name = "dgvElectricalDrawings"
        Me.dgvElectricalDrawings.Size = New System.Drawing.Size(1082, 114)
        Me.dgvElectricalDrawings.TabIndex = 1
        '
        'ApplicationNoteTabPage
        '
        Me.ApplicationNoteTabPage.BackColor = System.Drawing.Color.LightGray
        Me.ApplicationNoteTabPage.Controls.Add(Me.dgvApplicationNotes)
        Me.ApplicationNoteTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ApplicationNoteTabPage.Name = "ApplicationNoteTabPage"
        Me.ApplicationNoteTabPage.Size = New System.Drawing.Size(1089, 189)
        Me.ApplicationNoteTabPage.TabIndex = 3
        Me.ApplicationNoteTabPage.Text = "Application Note"
        '
        'dgvApplicationNotes
        '
        Me.dgvApplicationNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvApplicationNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvApplicationNotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.PercorsoFile2, Me.DataGridViewTextBoxColumn15, Me.Open4})
        Me.dgvApplicationNotes.Location = New System.Drawing.Point(3, 3)
        Me.dgvApplicationNotes.Name = "dgvApplicationNotes"
        Me.dgvApplicationNotes.Size = New System.Drawing.Size(1082, 114)
        Me.dgvApplicationNotes.TabIndex = 1
        '
        'EconomicTabPage
        '
        Me.EconomicTabPage.BackColor = System.Drawing.Color.LightGray
        Me.EconomicTabPage.Controls.Add(Me.dgvEconomicBids)
        Me.EconomicTabPage.Location = New System.Drawing.Point(4, 22)
        Me.EconomicTabPage.Name = "EconomicTabPage"
        Me.EconomicTabPage.Size = New System.Drawing.Size(1089, 189)
        Me.EconomicTabPage.TabIndex = 4
        Me.EconomicTabPage.Text = "Economic Bid"
        '
        'dgvEconomicBids
        '
        Me.dgvEconomicBids.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvEconomicBids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEconomicBids.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.PercorsoFile3, Me.DataGridViewTextBoxColumn20, Me.Open5})
        Me.dgvEconomicBids.Location = New System.Drawing.Point(3, 3)
        Me.dgvEconomicBids.Name = "dgvEconomicBids"
        Me.dgvEconomicBids.Size = New System.Drawing.Size(1082, 114)
        Me.dgvEconomicBids.TabIndex = 1
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'Titolo
        '
        Me.Titolo.HeaderText = "Titolo"
        Me.Titolo.Name = "Titolo"
        '
        'Versione
        '
        Me.Versione.HeaderText = "Versione"
        Me.Versione.Name = "Versione"
        '
        'FilePath
        '
        Me.FilePath.HeaderText = "Percorso"
        Me.FilePath.Name = "FilePath"
        '
        'Url
        '
        Me.Url.HeaderText = "Url"
        Me.Url.Name = "Url"
        '
        'Open
        '
        Me.Open.HeaderText = "Open"
        Me.Open.Name = "Open"
        Me.Open.Text = "Open"
        Me.Open.UseColumnTextForButtonValue = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Titolo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Versione"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Percorso
        '
        Me.Percorso.HeaderText = "Percorso"
        Me.Percorso.Name = "Percorso"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Url"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Open2
        '
        Me.Open2.HeaderText = "Open"
        Me.Open2.Name = "Open2"
        Me.Open2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Open2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Open2.Text = "Open"
        Me.Open2.UseColumnTextForButtonValue = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Titolo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Versione"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'PercorsoFile
        '
        Me.PercorsoFile.HeaderText = "Percorso"
        Me.PercorsoFile.Name = "PercorsoFile"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Url"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Open3
        '
        Me.Open3.HeaderText = "Open"
        Me.Open3.Name = "Open3"
        Me.Open3.Text = "Open"
        Me.Open3.UseColumnTextForButtonValue = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Titolo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Versione"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'PercorsoFile2
        '
        Me.PercorsoFile2.HeaderText = "Percorso"
        Me.PercorsoFile2.Name = "PercorsoFile2"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Url"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'Open4
        '
        Me.Open4.HeaderText = "Open"
        Me.Open4.Name = "Open4"
        Me.Open4.Text = "Open"
        Me.Open4.UseColumnTextForButtonValue = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Titolo"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Versione"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'PercorsoFile3
        '
        Me.PercorsoFile3.HeaderText = "Percorso"
        Me.PercorsoFile3.Name = "PercorsoFile3"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "url"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'Open5
        '
        Me.Open5.HeaderText = "Open"
        Me.Open5.Name = "Open5"
        Me.Open5.Text = "Open"
        Me.Open5.UseColumnTextForButtonValue = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1580, 1019)
        Me.Controls.Add(Me.tabDocuments)
        Me.Controls.Add(Me.pnlExtendedData)
        Me.Controls.Add(Me.pnlFutureUse)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.pnlInstruments)
        Me.Controls.Add(Me.CompEleControl)
        Me.Controls.Add(Me.txtOpResult)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Xplorer"
        CType(Me.dgvCEDBViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CompEleControl.ResumeLayout(False)
        Me.CompElePage.ResumeLayout(False)
        Me.ConsElePage.ResumeLayout(False)
        CType(Me.dgvCSDBViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlExtendedData.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlNote.ResumeLayout(False)
        Me.pnlNote.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlArolCode.ResumeLayout(False)
        Me.pnlArolCode.PerformLayout()
        Me.pnlInstruments.ResumeLayout(False)
        Me.pnlInstruments.PerformLayout()
        Me.pnlAdvancedSearch.ResumeLayout(False)
        Me.pnlAdvancedSearch.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlGuidedSearch.ResumeLayout(False)
        Me.pnlGuidedSearch.PerformLayout()
        Me.pnlSimpleSearch.ResumeLayout(False)
        Me.pnlSimpleSearch.PerformLayout()
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.pnlFutureUse.ResumeLayout(False)
        Me.pnlFutureUse.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tabDocuments.ResumeLayout(False)
        Me.datasheetTabPage.ResumeLayout(False)
        CType(Me.dgvDatasheets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserManualTabPage.ResumeLayout(False)
        CType(Me.dgvUserManuals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.electricalDrawingTabPage.ResumeLayout(False)
        CType(Me.dgvElectricalDrawings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ApplicationNoteTabPage.ResumeLayout(False)
        CType(Me.dgvApplicationNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EconomicTabPage.ResumeLayout(False)
        CType(Me.dgvEconomicBids, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOpResult As TextBox
    Friend WithEvents txtItemToFind As TextBox
    Friend WithEvents dgvCEDBViewer As DataGridView
    Friend WithEvents CompEleControl As TabControl
    Friend WithEvents CompElePage As TabPage
    Friend WithEvents ConsElePage As TabPage
    Friend WithEvents dgvCSDBViewer As DataGridView
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents btnInsertNew As Button
    Friend WithEvents pnlInstruments As Panel
    Friend WithEvents btnChildGenerator As Button
    Friend WithEvents prgChildGeneration As ProgressBar
    Friend WithEvents lblFindACode As Label
    Friend WithEvents txtFindACode As TextBox
    Friend WithEvents lblFindCCode As Label
    Friend WithEvents txtFindCCode As TextBox
    Friend WithEvents lblFindDescr As Label
    Friend WithEvents txtFindDescr As TextBox
    Friend WithEvents pnlAdvancedSearch As Panel
    Friend WithEvents lblFindSupDescr As Label
    Friend WithEvents txtFindSupDescr As TextBox
    Friend WithEvents lblFindManufacturer As Label
    Friend WithEvents txtFindManufacturer As TextBox
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStrumenti As Label
    Friend WithEvents lblOpenDocs As Label
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUserLogged As Label
    Friend WithEvents HelpTip As ToolTip
    Friend WithEvents pnlFutureUse As Panel
    Friend WithEvents rbSimpleSearch As RadioButton
    Friend WithEvents rbAdvancedSearch As RadioButton
    Friend WithEvents rbGuidedSearch As RadioButton
    Friend WithEvents lblSearchCategory As Label
    Friend WithEvents cbxSearchCategory As ComboBox
    Friend WithEvents pnlGuidedSearch As Panel
    Friend WithEvents pnlSimpleSearch As Panel
    Friend WithEvents cbxSearchManufacturer As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnGuideSearch As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnReadFromFile As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewManufacturerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label10 As Label
    Friend WithEvents btnToCSV As Button
    Friend WithEvents csvFileExportBrwDial As FolderBrowserDialog
    Friend WithEvents btnDetails As Button
    Friend WithEvents lblDetails As Label
    Friend WithEvents pnlExtendedData As Panel
    Friend WithEvents pnlArolCode As Panel
    Friend WithEvents txtArolCode As TextBox
    Friend WithEvents lblArolCode As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCodificaRichiestaDa As TextBox
    Friend WithEvents txtInseritoDa As TextBox
    Friend WithEvents lblInseritoDa As Label
    Friend WithEvents lblCodificaRichiestaDa As Label
    Friend WithEvents txtDataInserimento As TextBox
    Friend WithEvents lblDataInserimento As Label
    Friend WithEvents txtStatoAttuale As TextBox
    Friend WithEvents lblStatoAttuale As Label
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
    Friend WithEvents pnlNote As Panel
    Friend WithEvents txtNote As TextBox
    Friend WithEvents lblNote As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtDataUltimaModifica As TextBox
    Friend WithEvents txtModificatoDa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblEditSelected As Label
    Friend WithEvents btnEditSelected As Button
    Friend WithEvents NewDocumentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tabDocuments As TabControl
    Friend WithEvents datasheetTabPage As TabPage
    Friend WithEvents UserManualTabPage As TabPage
    Friend WithEvents electricalDrawingTabPage As TabPage
    Friend WithEvents ApplicationNoteTabPage As TabPage
    Friend WithEvents EconomicTabPage As TabPage
    Friend WithEvents dgvDatasheets As DataGridView
    Friend WithEvents dgvUserManuals As DataGridView
    Friend WithEvents dgvElectricalDrawings As DataGridView
    Friend WithEvents dgvApplicationNotes As DataGridView
    Friend WithEvents dgvEconomicBids As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Titolo As DataGridViewTextBoxColumn
    Friend WithEvents Versione As DataGridViewTextBoxColumn
    Friend WithEvents FilePath As DataGridViewTextBoxColumn
    Friend WithEvents Url As DataGridViewTextBoxColumn
    Friend WithEvents Open As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Percorso As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Open2 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents PercorsoFile As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Open3 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents PercorsoFile2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents Open4 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents PercorsoFile3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents Open5 As DataGridViewButtonColumn
End Class
