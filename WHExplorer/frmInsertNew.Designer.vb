<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInsertNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInsertNew))
        Me.lblFamily = New System.Windows.Forms.Label()
        Me.cbxCompFamily = New System.Windows.Forms.ComboBox()
        Me.lblArolCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtLowCode = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblCommercialCode = New System.Windows.Forms.Label()
        Me.txtCommercialCode = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLockUnlockDescr = New System.Windows.Forms.Button()
        Me.lblCostructor = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.cbxConstructor = New System.Windows.Forms.ComboBox()
        Me.txtSuppDescription = New System.Windows.Forms.TextBox()
        Me.lblSuppDescription = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblEsempioDescrizione = New System.Windows.Forms.Label()
        Me.txtDescrExample = New System.Windows.Forms.TextBox()
        Me.lblDescriptionConstructor = New System.Windows.Forms.Label()
        Me.brwFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.txtFileExtension = New System.Windows.Forms.TextBox()
        Me.lblFileExtension = New System.Windows.Forms.Label()
        Me.lblDSFilePath = New System.Windows.Forms.Label()
        Me.txtFileDSPath = New System.Windows.Forms.TextBox()
        Me.lblDatasheet = New System.Windows.Forms.Label()
        Me.cbxAddDatasheet = New System.Windows.Forms.CheckBox()
        Me.brwFolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.rdbMatCons = New System.Windows.Forms.RadioButton()
        Me.rdbMatComm = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.rdbGenerico = New System.Windows.Forms.RadioButton()
        Me.rdbFamComponente = New System.Windows.Forms.RadioButton()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.btnInsertNew = New System.Windows.Forms.Button()
        Me.btnCreaFileTxt = New System.Windows.Forms.Button()
        Me.frmInsertNewHelpTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFamily
        '
        Me.lblFamily.AutoSize = True
        Me.lblFamily.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFamily.Location = New System.Drawing.Point(49, 99)
        Me.lblFamily.Name = "lblFamily"
        Me.lblFamily.Size = New System.Drawing.Size(242, 16)
        Me.lblFamily.TabIndex = 0
        Me.lblFamily.Text = "Seleziona famiglia di componente"
        '
        'cbxCompFamily
        '
        Me.cbxCompFamily.FormattingEnabled = True
        Me.cbxCompFamily.Location = New System.Drawing.Point(49, 118)
        Me.cbxCompFamily.Name = "cbxCompFamily"
        Me.cbxCompFamily.Size = New System.Drawing.Size(239, 21)
        Me.cbxCompFamily.TabIndex = 1
        '
        'lblArolCode
        '
        Me.lblArolCode.AutoSize = True
        Me.lblArolCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArolCode.Location = New System.Drawing.Point(50, 5)
        Me.lblArolCode.Name = "lblArolCode"
        Me.lblArolCode.Size = New System.Drawing.Size(89, 16)
        Me.lblArolCode.TabIndex = 2
        Me.lblArolCode.Text = "Codice Arol"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCode.Location = New System.Drawing.Point(50, 25)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 3
        '
        'txtLowCode
        '
        Me.txtLowCode.Location = New System.Drawing.Point(154, 25)
        Me.txtLowCode.Name = "txtLowCode"
        Me.txtLowCode.Size = New System.Drawing.Size(56, 20)
        Me.txtLowCode.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lblArolCode)
        Me.Panel1.Controls.Add(Me.txtCode)
        Me.Panel1.Controls.Add(Me.txtLowCode)
        Me.Panel1.Location = New System.Drawing.Point(321, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 57)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'lblCommercialCode
        '
        Me.lblCommercialCode.AutoSize = True
        Me.lblCommercialCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommercialCode.Location = New System.Drawing.Point(50, 4)
        Me.lblCommercialCode.Name = "lblCommercialCode"
        Me.lblCommercialCode.Size = New System.Drawing.Size(152, 16)
        Me.lblCommercialCode.TabIndex = 6
        Me.lblCommercialCode.Text = "Codice Commerciale"
        '
        'txtCommercialCode
        '
        Me.txtCommercialCode.Location = New System.Drawing.Point(50, 24)
        Me.txtCommercialCode.Name = "txtCommercialCode"
        Me.txtCommercialCode.Size = New System.Drawing.Size(149, 20)
        Me.txtCommercialCode.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.lblCommercialCode)
        Me.Panel2.Controls.Add(Me.txtCommercialCode)
        Me.Panel2.Location = New System.Drawing.Point(547, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 57)
        Me.Panel2.TabIndex = 6
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(6, 5)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(90, 16)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Descrizione"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDescription.Location = New System.Drawing.Point(6, 24)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(294, 20)
        Me.txtDescription.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnLockUnlockDescr)
        Me.Panel3.Controls.Add(Me.txtDescription)
        Me.Panel3.Controls.Add(Me.lblDescription)
        Me.Panel3.Location = New System.Drawing.Point(763, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(343, 57)
        Me.Panel3.TabIndex = 10
        '
        'btnLockUnlockDescr
        '
        Me.btnLockUnlockDescr.BackgroundImage = CType(resources.GetObject("btnLockUnlockDescr.BackgroundImage"), System.Drawing.Image)
        Me.btnLockUnlockDescr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLockUnlockDescr.Location = New System.Drawing.Point(306, 14)
        Me.btnLockUnlockDescr.Name = "btnLockUnlockDescr"
        Me.btnLockUnlockDescr.Size = New System.Drawing.Size(30, 30)
        Me.btnLockUnlockDescr.TabIndex = 10
        Me.frmInsertNewHelpTip.SetToolTip(Me.btnLockUnlockDescr, "Abilita/Disabilita" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "modifica manuale descrizione")
        Me.btnLockUnlockDescr.UseVisualStyleBackColor = True
        '
        'lblCostructor
        '
        Me.lblCostructor.AutoSize = True
        Me.lblCostructor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostructor.Location = New System.Drawing.Point(48, 3)
        Me.lblCostructor.Name = "lblCostructor"
        Me.lblCostructor.Size = New System.Drawing.Size(83, 16)
        Me.lblCostructor.TabIndex = 11
        Me.lblCostructor.Text = "Costruttore"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.PictureBox5)
        Me.Panel4.Controls.Add(Me.cbxConstructor)
        Me.Panel4.Controls.Add(Me.lblCostructor)
        Me.Panel4.Location = New System.Drawing.Point(1112, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(219, 57)
        Me.Panel4.TabIndex = 12
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 26
        Me.PictureBox5.TabStop = False
        '
        'cbxConstructor
        '
        Me.cbxConstructor.FormattingEnabled = True
        Me.cbxConstructor.Location = New System.Drawing.Point(48, 23)
        Me.cbxConstructor.Name = "cbxConstructor"
        Me.cbxConstructor.Size = New System.Drawing.Size(149, 21)
        Me.cbxConstructor.TabIndex = 23
        '
        'txtSuppDescription
        '
        Me.txtSuppDescription.BackColor = System.Drawing.Color.White
        Me.txtSuppDescription.Location = New System.Drawing.Point(52, 23)
        Me.txtSuppDescription.Name = "txtSuppDescription"
        Me.txtSuppDescription.Size = New System.Drawing.Size(438, 20)
        Me.txtSuppDescription.TabIndex = 15
        '
        'lblSuppDescription
        '
        Me.lblSuppDescription.AutoSize = True
        Me.lblSuppDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppDescription.Location = New System.Drawing.Point(52, 4)
        Me.lblSuppDescription.Name = "lblSuppDescription"
        Me.lblSuppDescription.Size = New System.Drawing.Size(199, 16)
        Me.lblSuppDescription.TabIndex = 14
        Me.lblSuppDescription.Text = "Descrizione Supplementare"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.PictureBox6)
        Me.Panel5.Controls.Add(Me.lblSuppDescription)
        Me.Panel5.Controls.Add(Me.txtSuppDescription)
        Me.Panel5.Location = New System.Drawing.Point(13, 378)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(508, 55)
        Me.Panel5.TabIndex = 16
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 26
        Me.PictureBox6.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.PictureBox4)
        Me.Panel6.Controls.Add(Me.lblEsempioDescrizione)
        Me.Panel6.Controls.Add(Me.txtDescrExample)
        Me.Panel6.Controls.Add(Me.lblDescriptionConstructor)
        Me.Panel6.Location = New System.Drawing.Point(13, 161)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1317, 212)
        Me.Panel6.TabIndex = 17
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'lblEsempioDescrizione
        '
        Me.lblEsempioDescrizione.AutoSize = True
        Me.lblEsempioDescrizione.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsempioDescrizione.Location = New System.Drawing.Point(3, 186)
        Me.lblEsempioDescrizione.Name = "lblEsempioDescrizione"
        Me.lblEsempioDescrizione.Size = New System.Drawing.Size(157, 16)
        Me.lblEsempioDescrizione.TabIndex = 22
        Me.lblEsempioDescrizione.Text = "Esempio descrizione:"
        '
        'txtDescrExample
        '
        Me.txtDescrExample.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDescrExample.Location = New System.Drawing.Point(159, 184)
        Me.txtDescrExample.Name = "txtDescrExample"
        Me.txtDescrExample.ReadOnly = True
        Me.txtDescrExample.Size = New System.Drawing.Size(325, 20)
        Me.txtDescrExample.TabIndex = 21
        '
        'lblDescriptionConstructor
        '
        Me.lblDescriptionConstructor.AutoSize = True
        Me.lblDescriptionConstructor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionConstructor.Location = New System.Drawing.Point(49, 3)
        Me.lblDescriptionConstructor.Name = "lblDescriptionConstructor"
        Me.lblDescriptionConstructor.Size = New System.Drawing.Size(90, 16)
        Me.lblDescriptionConstructor.TabIndex = 18
        Me.lblDescriptionConstructor.Text = "Descrizione"
        '
        'brwFileDialog
        '
        Me.brwFileDialog.FileName = "OpenFileDialog1"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.PictureBox7)
        Me.Panel7.Controls.Add(Me.txtFileExtension)
        Me.Panel7.Controls.Add(Me.lblFileExtension)
        Me.Panel7.Controls.Add(Me.lblDSFilePath)
        Me.Panel7.Controls.Add(Me.txtFileDSPath)
        Me.Panel7.Controls.Add(Me.lblDatasheet)
        Me.Panel7.Controls.Add(Me.cbxAddDatasheet)
        Me.Panel7.Location = New System.Drawing.Point(527, 378)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(625, 55)
        Me.Panel7.TabIndex = 21
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 27
        Me.PictureBox7.TabStop = False
        '
        'txtFileExtension
        '
        Me.txtFileExtension.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFileExtension.Location = New System.Drawing.Point(290, 25)
        Me.txtFileExtension.Name = "txtFileExtension"
        Me.txtFileExtension.ReadOnly = True
        Me.txtFileExtension.Size = New System.Drawing.Size(47, 20)
        Me.txtFileExtension.TabIndex = 25
        '
        'lblFileExtension
        '
        Me.lblFileExtension.AutoSize = True
        Me.lblFileExtension.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileExtension.Location = New System.Drawing.Point(210, 27)
        Me.lblFileExtension.Name = "lblFileExtension"
        Me.lblFileExtension.Size = New System.Drawing.Size(74, 13)
        Me.lblFileExtension.TabIndex = 24
        Me.lblFileExtension.Text = "File extension:"
        '
        'lblDSFilePath
        '
        Me.lblDSFilePath.AutoSize = True
        Me.lblDSFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDSFilePath.Location = New System.Drawing.Point(234, 5)
        Me.lblDSFilePath.Name = "lblDSFilePath"
        Me.lblDSFilePath.Size = New System.Drawing.Size(50, 13)
        Me.lblDSFilePath.TabIndex = 23
        Me.lblDSFilePath.Text = "File path:"
        '
        'txtFileDSPath
        '
        Me.txtFileDSPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFileDSPath.Location = New System.Drawing.Point(290, 3)
        Me.txtFileDSPath.Name = "txtFileDSPath"
        Me.txtFileDSPath.ReadOnly = True
        Me.txtFileDSPath.Size = New System.Drawing.Size(325, 20)
        Me.txtFileDSPath.TabIndex = 10
        '
        'lblDatasheet
        '
        Me.lblDatasheet.AutoSize = True
        Me.lblDatasheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatasheet.Location = New System.Drawing.Point(53, 4)
        Me.lblDatasheet.Name = "lblDatasheet"
        Me.lblDatasheet.Size = New System.Drawing.Size(81, 16)
        Me.lblDatasheet.TabIndex = 22
        Me.lblDatasheet.Text = "DataSheet"
        '
        'cbxAddDatasheet
        '
        Me.cbxAddDatasheet.AutoSize = True
        Me.cbxAddDatasheet.Location = New System.Drawing.Point(58, 26)
        Me.cbxAddDatasheet.Name = "cbxAddDatasheet"
        Me.cbxAddDatasheet.Size = New System.Drawing.Size(118, 17)
        Me.cbxAddDatasheet.TabIndex = 0
        Me.cbxAddDatasheet.Text = "Inserisci DataSheet"
        Me.cbxAddDatasheet.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.rdbMatCons)
        Me.Panel8.Controls.Add(Me.rdbMatComm)
        Me.Panel8.Controls.Add(Me.PictureBox1)
        Me.Panel8.Controls.Add(Me.lblFamily)
        Me.Panel8.Controls.Add(Me.cbxCompFamily)
        Me.Panel8.Controls.Add(Me.Panel10)
        Me.Panel8.Controls.Add(Me.Panel11)
        Me.Panel8.Location = New System.Drawing.Point(13, 9)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(302, 146)
        Me.Panel8.TabIndex = 22
        '
        'rdbMatCons
        '
        Me.rdbMatCons.AutoSize = True
        Me.rdbMatCons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMatCons.Location = New System.Drawing.Point(183, 6)
        Me.rdbMatCons.Name = "rdbMatCons"
        Me.rdbMatCons.Size = New System.Drawing.Size(102, 34)
        Me.rdbMatCons.TabIndex = 4
        Me.rdbMatCons.TabStop = True
        Me.rdbMatCons.Text = "Materiale a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consumo"
        Me.rdbMatCons.UseVisualStyleBackColor = True
        '
        'rdbMatComm
        '
        Me.rdbMatComm.AutoSize = True
        Me.rdbMatComm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMatComm.Location = New System.Drawing.Point(59, 6)
        Me.rdbMatComm.Name = "rdbMatComm"
        Me.rdbMatComm.Size = New System.Drawing.Size(109, 34)
        Me.rdbMatComm.TabIndex = 3
        Me.rdbMatComm.TabStop = True
        Me.rdbMatComm.Text = "Materiale su " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Commessa"
        Me.rdbMatComm.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Location = New System.Drawing.Point(49, 1)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(242, 47)
        Me.Panel10.TabIndex = 24
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Controls.Add(Me.rdbGenerico)
        Me.Panel11.Controls.Add(Me.rdbFamComponente)
        Me.Panel11.Location = New System.Drawing.Point(49, 49)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(242, 47)
        Me.Panel11.TabIndex = 25
        '
        'rdbGenerico
        '
        Me.rdbGenerico.AutoSize = True
        Me.rdbGenerico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbGenerico.Location = New System.Drawing.Point(8, 14)
        Me.rdbGenerico.Name = "rdbGenerico"
        Me.rdbGenerico.Size = New System.Drawing.Size(83, 19)
        Me.rdbGenerico.TabIndex = 5
        Me.rdbGenerico.TabStop = True
        Me.rdbGenerico.Text = "Generico"
        Me.rdbGenerico.UseVisualStyleBackColor = True
        '
        'rdbFamComponente
        '
        Me.rdbFamComponente.AutoSize = True
        Me.rdbFamComponente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFamComponente.Location = New System.Drawing.Point(132, 6)
        Me.rdbFamComponente.Name = "rdbFamComponente"
        Me.rdbFamComponente.Size = New System.Drawing.Size(106, 34)
        Me.rdbFamComponente.TabIndex = 6
        Me.rdbFamComponente.TabStop = True
        Me.rdbFamComponente.Text = "Famiglia di" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Componente"
        Me.rdbFamComponente.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Controls.Add(Me.PictureBox8)
        Me.Panel9.Controls.Add(Me.btnInsertNew)
        Me.Panel9.Controls.Add(Me.btnCreaFileTxt)
        Me.Panel9.Location = New System.Drawing.Point(1159, 378)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(171, 55)
        Me.Panel9.TabIndex = 23
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox8.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 28
        Me.PictureBox8.TabStop = False
        '
        'btnInsertNew
        '
        Me.btnInsertNew.BackgroundImage = CType(resources.GetObject("btnInsertNew.BackgroundImage"), System.Drawing.Image)
        Me.btnInsertNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInsertNew.Location = New System.Drawing.Point(59, 3)
        Me.btnInsertNew.Name = "btnInsertNew"
        Me.btnInsertNew.Size = New System.Drawing.Size(42, 42)
        Me.btnInsertNew.TabIndex = 19
        Me.frmInsertNewHelpTip.SetToolTip(Me.btnInsertNew, "Salva su DataBase")
        Me.btnInsertNew.UseVisualStyleBackColor = True
        '
        'btnCreaFileTxt
        '
        Me.btnCreaFileTxt.BackgroundImage = CType(resources.GetObject("btnCreaFileTxt.BackgroundImage"), System.Drawing.Image)
        Me.btnCreaFileTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreaFileTxt.Location = New System.Drawing.Point(107, 3)
        Me.btnCreaFileTxt.Name = "btnCreaFileTxt"
        Me.btnCreaFileTxt.Size = New System.Drawing.Size(42, 42)
        Me.btnCreaFileTxt.TabIndex = 20
        Me.frmInsertNewHelpTip.SetToolTip(Me.btnCreaFileTxt, "Aggiungi a file Codici.txt")
        Me.btnCreaFileTxt.UseVisualStyleBackColor = True
        '
        'frmInsertNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 441)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInsertNew"
        Me.Text = "Nuova Codifica"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblFamily As Label
    Friend WithEvents cbxCompFamily As ComboBox
    Friend WithEvents lblArolCode As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtLowCode As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCommercialCode As Label
    Friend WithEvents txtCommercialCode As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblCostructor As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtSuppDescription As TextBox
    Friend WithEvents lblSuppDescription As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblDescriptionConstructor As Label
    Friend WithEvents btnInsertNew As Button
    Friend WithEvents btnCreaFileTxt As Button
    Friend WithEvents txtDescrExample As TextBox
    Friend WithEvents brwFileDialog As OpenFileDialog
    Friend WithEvents lblEsempioDescrizione As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblDSFilePath As Label
    Friend WithEvents txtFileDSPath As TextBox
    Friend WithEvents lblDatasheet As Label
    Friend WithEvents cbxAddDatasheet As CheckBox
    Friend WithEvents txtFileExtension As TextBox
    Friend WithEvents lblFileExtension As Label
    Friend WithEvents brwFolderDialog As FolderBrowserDialog
    Friend WithEvents cbxConstructor As ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents btnLockUnlockDescr As Button
    Friend WithEvents frmInsertNewHelpTip As ToolTip
    Friend WithEvents rdbMatComm As RadioButton
    Friend WithEvents rdbMatCons As RadioButton
    Friend WithEvents rdbFamComponente As RadioButton
    Friend WithEvents rdbGenerico As RadioButton
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
End Class
