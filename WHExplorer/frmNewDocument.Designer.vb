<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewDocument
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewDocument))
        Me.pnlSelectType = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSelectType = New System.Windows.Forms.Label()
        Me.cbxSelectType = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDocTitle = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtRevision = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblRevision = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.brwPathDialogSelection = New System.Windows.Forms.OpenFileDialog()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblUrl = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lblSaveUndo = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgvConnectTo = New System.Windows.Forms.DataGridView()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.lblLinkTo = New System.Windows.Forms.Label()
        Me.ArolCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommercialCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Constructor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlSelectType.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvConnectTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSelectType
        '
        Me.pnlSelectType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSelectType.Controls.Add(Me.PictureBox1)
        Me.pnlSelectType.Controls.Add(Me.lblSelectType)
        Me.pnlSelectType.Controls.Add(Me.cbxSelectType)
        Me.pnlSelectType.Location = New System.Drawing.Point(12, 12)
        Me.pnlSelectType.Name = "pnlSelectType"
        Me.pnlSelectType.Size = New System.Drawing.Size(283, 59)
        Me.pnlSelectType.TabIndex = 23
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
        'lblSelectType
        '
        Me.lblSelectType.AutoSize = True
        Me.lblSelectType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectType.Location = New System.Drawing.Point(49, 4)
        Me.lblSelectType.Name = "lblSelectType"
        Me.lblSelectType.Size = New System.Drawing.Size(222, 16)
        Me.lblSelectType.TabIndex = 0
        Me.lblSelectType.Text = "Seleziona tipologia documento"
        '
        'cbxSelectType
        '
        Me.cbxSelectType.FormattingEnabled = True
        Me.cbxSelectType.Location = New System.Drawing.Point(49, 23)
        Me.cbxSelectType.Name = "cbxSelectType"
        Me.cbxSelectType.Size = New System.Drawing.Size(222, 21)
        Me.cbxSelectType.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtDocTitle)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(301, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 59)
        Me.Panel1.TabIndex = 24
        '
        'txtDocTitle
        '
        Me.txtDocTitle.Location = New System.Drawing.Point(52, 24)
        Me.txtDocTitle.Name = "txtDocTitle"
        Me.txtDocTitle.Size = New System.Drawing.Size(224, 20)
        Me.txtDocTitle.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Xplorer.My.Resources.Resources._2
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(49, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(128, 16)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Titolo documento"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtRevision)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.lblRevision)
        Me.Panel2.Location = New System.Drawing.Point(590, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(233, 59)
        Me.Panel2.TabIndex = 25
        '
        'txtRevision
        '
        Me.txtRevision.Location = New System.Drawing.Point(52, 24)
        Me.txtRevision.Name = "txtRevision"
        Me.txtRevision.Size = New System.Drawing.Size(171, 20)
        Me.txtRevision.TabIndex = 3
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Xplorer.My.Resources.Resources._3
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'lblRevision
        '
        Me.lblRevision.AutoSize = True
        Me.lblRevision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevision.Location = New System.Drawing.Point(49, 4)
        Me.lblRevision.Name = "lblRevision"
        Me.lblRevision.Size = New System.Drawing.Size(135, 16)
        Me.lblRevision.TabIndex = 0
        Me.lblRevision.Text = "Indice di revisione"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnBrowse)
        Me.Panel3.Controls.Add(Me.txtFilePath)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.lblFilePath)
        Me.Panel3.Location = New System.Drawing.Point(12, 77)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(811, 59)
        Me.Panel3.TabIndex = 26
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(49, 24)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "Cerca file..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(130, 27)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(671, 20)
        Me.txtFilePath.TabIndex = 3
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Xplorer.My.Resources.Resources._4
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'lblFilePath
        '
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilePath.Location = New System.Drawing.Point(49, 4)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(143, 16)
        Me.lblFilePath.TabIndex = 0
        Me.lblFilePath.Text = "Seleziona percorso"
        '
        'brwPathDialogSelection
        '
        Me.brwPathDialogSelection.FileName = "OpenFileDialog1"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.txtUrl)
        Me.Panel4.Controls.Add(Me.PictureBox5)
        Me.Panel4.Controls.Add(Me.lblUrl)
        Me.Panel4.Location = New System.Drawing.Point(12, 142)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(811, 59)
        Me.Panel4.TabIndex = 27
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(49, 23)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(752, 20)
        Me.txtUrl.TabIndex = 3
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.Xplorer.My.Resources.Resources._5
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'lblUrl
        '
        Me.lblUrl.AutoSize = True
        Me.lblUrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUrl.Location = New System.Drawing.Point(49, 4)
        Me.lblUrl.Name = "lblUrl"
        Me.lblUrl.Size = New System.Drawing.Size(60, 16)
        Me.lblUrl.TabIndex = 0
        Me.lblUrl.Text = "Url web"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.btnUndo)
        Me.Panel5.Controls.Add(Me.btnSave)
        Me.Panel5.Controls.Add(Me.PictureBox6)
        Me.Panel5.Controls.Add(Me.lblSaveUndo)
        Me.Panel5.Location = New System.Drawing.Point(12, 411)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(167, 60)
        Me.Panel5.TabIndex = 28
        '
        'btnUndo
        '
        Me.btnUndo.BackgroundImage = Global.Xplorer.My.Resources.Resources.cestino
        Me.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUndo.Location = New System.Drawing.Point(110, 21)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(35, 35)
        Me.btnUndo.TabIndex = 29
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.Xplorer.My.Resources.Resources.Save
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSave.Location = New System.Drawing.Point(52, 21)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(35, 35)
        Me.btnSave.TabIndex = 3
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.Xplorer.My.Resources.Resources._7
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 2
        Me.PictureBox6.TabStop = False
        '
        'lblSaveUndo
        '
        Me.lblSaveUndo.AutoSize = True
        Me.lblSaveUndo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaveUndo.Location = New System.Drawing.Point(49, 4)
        Me.lblSaveUndo.Name = "lblSaveUndo"
        Me.lblSaveUndo.Size = New System.Drawing.Size(112, 16)
        Me.lblSaveUndo.TabIndex = 0
        Me.lblSaveUndo.Text = "Salva / Annulla"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.dgvConnectTo)
        Me.Panel6.Controls.Add(Me.btnSub)
        Me.Panel6.Controls.Add(Me.btnAdd)
        Me.Panel6.Controls.Add(Me.PictureBox7)
        Me.Panel6.Controls.Add(Me.lblLinkTo)
        Me.Panel6.Location = New System.Drawing.Point(12, 207)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(811, 198)
        Me.Panel6.TabIndex = 29
        '
        'dgvConnectTo
        '
        Me.dgvConnectTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConnectTo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ArolCode, Me.CommercialCode, Me.Description, Me.Constructor})
        Me.dgvConnectTo.Location = New System.Drawing.Point(49, 21)
        Me.dgvConnectTo.Name = "dgvConnectTo"
        Me.dgvConnectTo.Size = New System.Drawing.Size(752, 167)
        Me.dgvConnectTo.TabIndex = 30
        '
        'btnSub
        '
        Me.btnSub.BackgroundImage = CType(resources.GetObject("btnSub.BackgroundImage"), System.Drawing.Image)
        Me.btnSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSub.Location = New System.Drawing.Point(8, 154)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(35, 35)
        Me.btnSub.TabIndex = 29
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdd.Location = New System.Drawing.Point(8, 118)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(35, 35)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.Xplorer.My.Resources.Resources._6
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 2
        Me.PictureBox7.TabStop = False
        '
        'lblLinkTo
        '
        Me.lblLinkTo.AutoSize = True
        Me.lblLinkTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLinkTo.Location = New System.Drawing.Point(49, 4)
        Me.lblLinkTo.Name = "lblLinkTo"
        Me.lblLinkTo.Size = New System.Drawing.Size(75, 16)
        Me.lblLinkTo.TabIndex = 0
        Me.lblLinkTo.Text = "Collega a"
        '
        'ArolCode
        '
        Me.ArolCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ArolCode.HeaderText = "Arol Code"
        Me.ArolCode.Name = "ArolCode"
        Me.ArolCode.Width = 78
        '
        'CommercialCode
        '
        Me.CommercialCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CommercialCode.HeaderText = "Commercial Code"
        Me.CommercialCode.Name = "CommercialCode"
        Me.CommercialCode.ReadOnly = True
        '
        'Description
        '
        Me.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Constructor
        '
        Me.Constructor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Constructor.HeaderText = "Constructor"
        Me.Constructor.Name = "Constructor"
        Me.Constructor.ReadOnly = True
        '
        'frmNewDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 480)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlSelectType)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNewDocument"
        Me.Text = "New document..."
        Me.pnlSelectType.ResumeLayout(False)
        Me.pnlSelectType.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dgvConnectTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSelectType As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSelectType As Label
    Friend WithEvents cbxSelectType As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtDocTitle As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtRevision As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblRevision As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblFilePath As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents brwPathDialogSelection As OpenFileDialog
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtUrl As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblUrl As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnUndo As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblSaveUndo As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dgvConnectTo As DataGridView
    Friend WithEvents btnSub As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblLinkTo As Label
    Friend WithEvents ArolCode As DataGridViewTextBoxColumn
    Friend WithEvents CommercialCode As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Constructor As DataGridViewTextBoxColumn
End Class
