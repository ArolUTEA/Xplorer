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
        Me.pnlInstruments = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReadFromFile = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStrumenti = New System.Windows.Forms.Label()
        Me.btnInsertNew = New System.Windows.Forms.Button()
        Me.btnChildGenerator = New System.Windows.Forms.Button()
        Me.prgChildGeneration = New System.Windows.Forms.ProgressBar()
        Me.lblOpenDocs = New System.Windows.Forms.Label()
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
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.pnlFutureUse = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewManufacturerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnToCSV = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.csvFileExportBrwDial = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.dgvCEDBViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CompEleControl.SuspendLayout()
        Me.CompElePage.SuspendLayout()
        Me.ConsElePage.SuspendLayout()
        CType(Me.dgvCSDBViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInstruments.SuspendLayout()
        Me.pnlAdvancedSearch.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.pnlGuidedSearch.SuspendLayout()
        Me.pnlSimpleSearch.SuspendLayout()
        Me.pnlLogin.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
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
        Me.CompEleControl.Size = New System.Drawing.Size(1565, 648)
        Me.CompEleControl.TabIndex = 6
        '
        'CompElePage
        '
        Me.CompElePage.Controls.Add(Me.dgvCEDBViewer)
        Me.CompElePage.Location = New System.Drawing.Point(4, 22)
        Me.CompElePage.Name = "CompElePage"
        Me.CompElePage.Padding = New System.Windows.Forms.Padding(3)
        Me.CompElePage.Size = New System.Drawing.Size(1557, 622)
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
        Me.ConsElePage.Size = New System.Drawing.Size(1557, 622)
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
        'pnlFutureUse
        '
        Me.pnlFutureUse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlFutureUse.Location = New System.Drawing.Point(12, 137)
        Me.pnlFutureUse.Name = "pnlFutureUse"
        Me.pnlFutureUse.Size = New System.Drawing.Size(169, 71)
        Me.pnlFutureUse.TabIndex = 27
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
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewManufacturerToolStripMenuItem})
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1580, 903)
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
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
End Class
