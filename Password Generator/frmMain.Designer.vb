Namespace Password_Generator
	Partial Public Class frmMain
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
			Me.lblNumOfChars = New System.Windows.Forms.Label()
			Me.numericUpDownChars = New System.Windows.Forms.NumericUpDown()
			Me.chkDigits = New System.Windows.Forms.CheckBox()
			Me.chkUpperCaseLetters = New System.Windows.Forms.CheckBox()
			Me.chkLowerCaseLetters = New System.Windows.Forms.CheckBox()
			Me.chkSymbols = New System.Windows.Forms.CheckBox()
			Me.grpCharsToUse = New System.Windows.Forms.GroupBox()
			Me.menuMain = New System.Windows.Forms.MenuStrip()
			Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.editToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.settingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.txtPassword = New System.Windows.Forms.TextBox()
			Me.btnGenerate = New System.Windows.Forms.Button()
			Me.grpRules = New System.Windows.Forms.GroupBox()
			Me.pnlRules = New System.Windows.Forms.Panel()
			Me.chkNoAdjacents = New System.Windows.Forms.CheckBox()
			Me.chkNoRepeats = New System.Windows.Forms.CheckBox()
			Me.chkCharOnce = New System.Windows.Forms.CheckBox()
			Me.pnlNumberOfChars = New System.Windows.Forms.Panel()
			Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
			Me.grpMinimums = New System.Windows.Forms.GroupBox()
			Me.numericUpDownSymbols = New System.Windows.Forms.NumericUpDown()
			Me.numericUpDownUpper = New System.Windows.Forms.NumericUpDown()
			Me.numericUpDownLower = New System.Windows.Forms.NumericUpDown()
			Me.numericUpDownDigits = New System.Windows.Forms.NumericUpDown()
			Me.workerGeneratePassword = New System.ComponentModel.BackgroundWorker()
			Me.statusMain = New System.Windows.Forms.StatusStrip()
			Me.toolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
			Me.toolStripProgressBar = New System.Windows.Forms.ToolStripProgressBar()
			Me.panel1 = New System.Windows.Forms.Panel()
			DirectCast(Me.numericUpDownChars, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.grpCharsToUse.SuspendLayout()
			Me.menuMain.SuspendLayout()
			Me.grpRules.SuspendLayout()
			Me.pnlRules.SuspendLayout()
			Me.pnlNumberOfChars.SuspendLayout()
			Me.grpMinimums.SuspendLayout()
			DirectCast(Me.numericUpDownSymbols, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.numericUpDownUpper, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.numericUpDownLower, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.numericUpDownDigits, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.statusMain.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' lblNumOfChars
			' 
			Me.lblNumOfChars.AutoSize = True
			Me.lblNumOfChars.Location = New System.Drawing.Point(1, 7)
			Me.lblNumOfChars.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.lblNumOfChars.Name = "lblNumOfChars"
			Me.lblNumOfChars.Size = New System.Drawing.Size(148, 16)
			Me.lblNumOfChars.TabIndex = 0
			Me.lblNumOfChars.Text = "Number of characters:"
			' 
			' numericUpDownChars
			' 
			Me.numericUpDownChars.Location = New System.Drawing.Point(154, 5)
			Me.numericUpDownChars.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.numericUpDownChars.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.numericUpDownChars.Name = "numericUpDownChars"
			Me.numericUpDownChars.Size = New System.Drawing.Size(58, 23)
			Me.numericUpDownChars.TabIndex = 1
			Me.numericUpDownChars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.numericUpDownChars.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			' 
			' chkDigits
			' 
			Me.chkDigits.AutoSize = True
			Me.chkDigits.Dock = System.Windows.Forms.DockStyle.Top
			Me.chkDigits.Location = New System.Drawing.Point(2, 19)
			Me.chkDigits.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.chkDigits.Name = "chkDigits"
			Me.chkDigits.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.chkDigits.Size = New System.Drawing.Size(149, 26)
			Me.chkDigits.TabIndex = 2
			Me.chkDigits.Text = "Digits"
			Me.chkDigits.UseVisualStyleBackColor = True
'			Me.chkDigits.CheckedChanged += New System.EventHandler(Me.chkCharsToUse_CheckedChanged)
			' 
			' chkUpperCaseLetters
			' 
			Me.chkUpperCaseLetters.AutoSize = True
			Me.chkUpperCaseLetters.Dock = System.Windows.Forms.DockStyle.Top
			Me.chkUpperCaseLetters.Location = New System.Drawing.Point(2, 71)
			Me.chkUpperCaseLetters.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.chkUpperCaseLetters.Name = "chkUpperCaseLetters"
			Me.chkUpperCaseLetters.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.chkUpperCaseLetters.Size = New System.Drawing.Size(149, 26)
			Me.chkUpperCaseLetters.TabIndex = 3
			Me.chkUpperCaseLetters.Text = "Upper case letters"
			Me.chkUpperCaseLetters.UseVisualStyleBackColor = True
'			Me.chkUpperCaseLetters.CheckedChanged += New System.EventHandler(Me.chkCharsToUse_CheckedChanged)
			' 
			' chkLowerCaseLetters
			' 
			Me.chkLowerCaseLetters.AutoSize = True
			Me.chkLowerCaseLetters.Dock = System.Windows.Forms.DockStyle.Top
			Me.chkLowerCaseLetters.Location = New System.Drawing.Point(2, 45)
			Me.chkLowerCaseLetters.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.chkLowerCaseLetters.Name = "chkLowerCaseLetters"
			Me.chkLowerCaseLetters.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.chkLowerCaseLetters.Size = New System.Drawing.Size(149, 26)
			Me.chkLowerCaseLetters.TabIndex = 4
			Me.chkLowerCaseLetters.Text = "Lower case letters"
			Me.chkLowerCaseLetters.UseVisualStyleBackColor = True
'			Me.chkLowerCaseLetters.CheckedChanged += New System.EventHandler(Me.chkCharsToUse_CheckedChanged)
			' 
			' chkSymbols
			' 
			Me.chkSymbols.AutoSize = True
			Me.chkSymbols.Dock = System.Windows.Forms.DockStyle.Top
			Me.chkSymbols.Location = New System.Drawing.Point(2, 97)
			Me.chkSymbols.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.chkSymbols.Name = "chkSymbols"
			Me.chkSymbols.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.chkSymbols.Size = New System.Drawing.Size(149, 26)
			Me.chkSymbols.TabIndex = 5
			Me.chkSymbols.Text = "Symbols"
			Me.chkSymbols.UseVisualStyleBackColor = True
'			Me.chkSymbols.CheckedChanged += New System.EventHandler(Me.chkCharsToUse_CheckedChanged)
			' 
			' grpCharsToUse
			' 
			Me.grpCharsToUse.Controls.Add(Me.chkSymbols)
			Me.grpCharsToUse.Controls.Add(Me.chkUpperCaseLetters)
			Me.grpCharsToUse.Controls.Add(Me.chkLowerCaseLetters)
			Me.grpCharsToUse.Controls.Add(Me.chkDigits)
			Me.grpCharsToUse.Location = New System.Drawing.Point(11, 30)
			Me.grpCharsToUse.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.grpCharsToUse.Name = "grpCharsToUse"
			Me.grpCharsToUse.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.grpCharsToUse.Size = New System.Drawing.Size(153, 138)
			Me.grpCharsToUse.TabIndex = 6
			Me.grpCharsToUse.TabStop = False
			Me.grpCharsToUse.Text = "Characters to use"
			' 
			' menuMain
			' 
			Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fileToolStripMenuItem, Me.editToolStripMenuItem, Me.toolsToolStripMenuItem})
			Me.menuMain.Location = New System.Drawing.Point(0, 0)
			Me.menuMain.Name = "menuMain"
			Me.menuMain.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
			Me.menuMain.Size = New System.Drawing.Size(509, 24)
			Me.menuMain.TabIndex = 7
			Me.menuMain.Text = "menuStrip1"
			' 
			' fileToolStripMenuItem
			' 
			Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.exitToolStripMenuItem})
			Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
			Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
			Me.fileToolStripMenuItem.Text = "&File"
			' 
			' exitToolStripMenuItem
			' 
			Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
			Me.exitToolStripMenuItem.ShortcutKeys = (CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys))
			Me.exitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
			Me.exitToolStripMenuItem.Text = "E&xit"
'			Me.exitToolStripMenuItem.Click += New System.EventHandler(Me.exitToolStripMenuItem_Click)
			' 
			' editToolStripMenuItem
			' 
			Me.editToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.copyToolStripMenuItem})
			Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
			Me.editToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
			Me.editToolStripMenuItem.Text = "&Edit"
			' 
			' copyToolStripMenuItem
			' 
			Me.copyToolStripMenuItem.Image = (DirectCast(resources.GetObject("copyToolStripMenuItem.Image"), System.Drawing.Image))
			Me.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
			Me.copyToolStripMenuItem.ShortcutKeys = (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys))
			Me.copyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
			Me.copyToolStripMenuItem.Text = "&Copy"
'			Me.copyToolStripMenuItem.Click += New System.EventHandler(Me.copyToolStripMenuItem_Click)
			' 
			' toolsToolStripMenuItem
			' 
			Me.toolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.settingsToolStripMenuItem})
			Me.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
			Me.toolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
			Me.toolsToolStripMenuItem.Text = "&Tools"
			' 
			' settingsToolStripMenuItem
			' 
			Me.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem"
			Me.settingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
			Me.settingsToolStripMenuItem.Text = "&Settings"
'			Me.settingsToolStripMenuItem.Click += New System.EventHandler(Me.settingsToolStripMenuItem_Click)
			' 
			' txtPassword
			' 
			Me.txtPassword.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtPassword.Location = New System.Drawing.Point(162, 11)
			Me.txtPassword.Name = "txtPassword"
			Me.txtPassword.Size = New System.Drawing.Size(325, 26)
			Me.txtPassword.TabIndex = 8
			Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' btnGenerate
			' 
			Me.btnGenerate.Enabled = False
			Me.btnGenerate.Location = New System.Drawing.Point(2, 6)
			Me.btnGenerate.Name = "btnGenerate"
			Me.btnGenerate.Size = New System.Drawing.Size(153, 37)
			Me.btnGenerate.TabIndex = 9
			Me.btnGenerate.Text = "Generate"
			Me.btnGenerate.UseVisualStyleBackColor = True
'			Me.btnGenerate.EnabledChanged += New System.EventHandler(Me.btnGenerate_EnabledChanged)
'			Me.btnGenerate.Click += New System.EventHandler(Me.btnGenerate_Click)
			' 
			' grpRules
			' 
			Me.grpRules.Controls.Add(Me.pnlRules)
			Me.grpRules.Controls.Add(Me.pnlNumberOfChars)
			Me.grpRules.Location = New System.Drawing.Point(280, 30)
			Me.grpRules.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.grpRules.Name = "grpRules"
			Me.grpRules.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.grpRules.Size = New System.Drawing.Size(222, 138)
			Me.grpRules.TabIndex = 10
			Me.grpRules.TabStop = False
			Me.grpRules.Text = "Rules"
			' 
			' pnlRules
			' 
			Me.pnlRules.Controls.Add(Me.chkNoAdjacents)
			Me.pnlRules.Controls.Add(Me.chkNoRepeats)
			Me.pnlRules.Controls.Add(Me.chkCharOnce)
			Me.pnlRules.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pnlRules.Location = New System.Drawing.Point(2, 53)
			Me.pnlRules.Name = "pnlRules"
			Me.pnlRules.Size = New System.Drawing.Size(218, 82)
			Me.pnlRules.TabIndex = 8
			' 
			' chkNoAdjacents
			' 
			Me.chkNoAdjacents.AutoSize = True
			Me.chkNoAdjacents.Dock = System.Windows.Forms.DockStyle.Top
			Me.chkNoAdjacents.Location = New System.Drawing.Point(0, 52)
			Me.chkNoAdjacents.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.chkNoAdjacents.Name = "chkNoAdjacents"
			Me.chkNoAdjacents.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.chkNoAdjacents.Size = New System.Drawing.Size(218, 26)
			Me.chkNoAdjacents.TabIndex = 6
			Me.chkNoAdjacents.Text = "No adjacent characters"
			Me.toolTip.SetToolTip(Me.chkNoAdjacents, "E.g. no ""1qaz2wsx"" or ""654#@!""")
			Me.chkNoAdjacents.UseVisualStyleBackColor = True
'			Me.chkNoAdjacents.CheckedChanged += New System.EventHandler(Me.chkNoAdjacents_CheckedChanged)
			' 
			' chkNoRepeats
			' 
			Me.chkNoRepeats.AutoSize = True
			Me.chkNoRepeats.Dock = System.Windows.Forms.DockStyle.Top
			Me.chkNoRepeats.Location = New System.Drawing.Point(0, 26)
			Me.chkNoRepeats.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.chkNoRepeats.Name = "chkNoRepeats"
			Me.chkNoRepeats.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.chkNoRepeats.Size = New System.Drawing.Size(218, 26)
			Me.chkNoRepeats.TabIndex = 4
			Me.chkNoRepeats.Text = "No consecutive characters"
			Me.toolTip.SetToolTip(Me.chkNoRepeats, "E.g. no ""kn2222m""")
			Me.chkNoRepeats.UseVisualStyleBackColor = True
			' 
			' chkCharOnce
			' 
			Me.chkCharOnce.AutoSize = True
			Me.chkCharOnce.Dock = System.Windows.Forms.DockStyle.Top
			Me.chkCharOnce.Location = New System.Drawing.Point(0, 0)
			Me.chkCharOnce.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.chkCharOnce.Name = "chkCharOnce"
			Me.chkCharOnce.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.chkCharOnce.Size = New System.Drawing.Size(218, 26)
			Me.chkCharOnce.TabIndex = 7
			Me.chkCharOnce.Text = "Each character once only"
			Me.toolTip.SetToolTip(Me.chkCharOnce, "E.g. no ""AkAqAtA""")
			Me.chkCharOnce.UseVisualStyleBackColor = True
'			Me.chkCharOnce.CheckedChanged += New System.EventHandler(Me.chkCharOnce_CheckedChanged)
			' 
			' pnlNumberOfChars
			' 
			Me.pnlNumberOfChars.Controls.Add(Me.lblNumOfChars)
			Me.pnlNumberOfChars.Controls.Add(Me.numericUpDownChars)
			Me.pnlNumberOfChars.Dock = System.Windows.Forms.DockStyle.Top
			Me.pnlNumberOfChars.Location = New System.Drawing.Point(2, 19)
			Me.pnlNumberOfChars.Name = "pnlNumberOfChars"
			Me.pnlNumberOfChars.Size = New System.Drawing.Size(218, 34)
			Me.pnlNumberOfChars.TabIndex = 5
			' 
			' toolTip
			' 
			Me.toolTip.IsBalloon = True
			' 
			' grpMinimums
			' 
			Me.grpMinimums.Controls.Add(Me.numericUpDownSymbols)
			Me.grpMinimums.Controls.Add(Me.numericUpDownUpper)
			Me.grpMinimums.Controls.Add(Me.numericUpDownLower)
			Me.grpMinimums.Controls.Add(Me.numericUpDownDigits)
			Me.grpMinimums.Location = New System.Drawing.Point(178, 30)
			Me.grpMinimums.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.grpMinimums.Name = "grpMinimums"
			Me.grpMinimums.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.grpMinimums.Size = New System.Drawing.Size(87, 138)
			Me.grpMinimums.TabIndex = 11
			Me.grpMinimums.TabStop = False
			Me.grpMinimums.Text = "Minimums"
			' 
			' numericUpDownSymbols
			' 
			Me.numericUpDownSymbols.Location = New System.Drawing.Point(13, 99)
			Me.numericUpDownSymbols.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.numericUpDownSymbols.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.numericUpDownSymbols.Name = "numericUpDownSymbols"
			Me.numericUpDownSymbols.Size = New System.Drawing.Size(58, 23)
			Me.numericUpDownSymbols.TabIndex = 5
			Me.numericUpDownSymbols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.numericUpDownSymbols.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.numericUpDownSymbols.Visible = False
'			Me.numericUpDownSymbols.ValueChanged += New System.EventHandler(Me.numericUpDown_ValueChanged)
			' 
			' numericUpDownUpper
			' 
			Me.numericUpDownUpper.Location = New System.Drawing.Point(13, 73)
			Me.numericUpDownUpper.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.numericUpDownUpper.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.numericUpDownUpper.Name = "numericUpDownUpper"
			Me.numericUpDownUpper.Size = New System.Drawing.Size(58, 23)
			Me.numericUpDownUpper.TabIndex = 4
			Me.numericUpDownUpper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.numericUpDownUpper.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.numericUpDownUpper.Visible = False
'			Me.numericUpDownUpper.ValueChanged += New System.EventHandler(Me.numericUpDown_ValueChanged)
			' 
			' numericUpDownLower
			' 
			Me.numericUpDownLower.Location = New System.Drawing.Point(13, 47)
			Me.numericUpDownLower.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.numericUpDownLower.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.numericUpDownLower.Name = "numericUpDownLower"
			Me.numericUpDownLower.Size = New System.Drawing.Size(58, 23)
			Me.numericUpDownLower.TabIndex = 3
			Me.numericUpDownLower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.numericUpDownLower.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.numericUpDownLower.Visible = False
'			Me.numericUpDownLower.ValueChanged += New System.EventHandler(Me.numericUpDown_ValueChanged)
			' 
			' numericUpDownDigits
			' 
			Me.numericUpDownDigits.Location = New System.Drawing.Point(13, 21)
			Me.numericUpDownDigits.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.numericUpDownDigits.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.numericUpDownDigits.Name = "numericUpDownDigits"
			Me.numericUpDownDigits.Size = New System.Drawing.Size(58, 23)
			Me.numericUpDownDigits.TabIndex = 2
			Me.numericUpDownDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.numericUpDownDigits.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.numericUpDownDigits.Visible = False
'			Me.numericUpDownDigits.ValueChanged += New System.EventHandler(Me.numericUpDown_ValueChanged)
			' 
			' workerGeneratePassword
			' 
			Me.workerGeneratePassword.WorkerSupportsCancellation = True
'			Me.workerGeneratePassword.DoWork += New System.ComponentModel.DoWorkEventHandler(Me.workerGeneratePassword_DoWork)
'			Me.workerGeneratePassword.RunWorkerCompleted += New System.ComponentModel.RunWorkerCompletedEventHandler(Me.workerGeneratePassword_RunWorkerCompleted)
			' 
			' statusMain
			' 
			Me.statusMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripStatusLabel, Me.toolStripProgressBar})
			Me.statusMain.Location = New System.Drawing.Point(0, 224)
			Me.statusMain.Name = "statusMain"
			Me.statusMain.Size = New System.Drawing.Size(509, 22)
			Me.statusMain.TabIndex = 12
			' 
			' toolStripStatusLabel
			' 
			Me.toolStripStatusLabel.Name = "toolStripStatusLabel"
			Me.toolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
			Me.toolStripStatusLabel.Text = " Ready"
			' 
			' toolStripProgressBar
			' 
			Me.toolStripProgressBar.Name = "toolStripProgressBar"
			Me.toolStripProgressBar.Size = New System.Drawing.Size(100, 16)
			Me.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
			Me.toolStripProgressBar.Visible = False
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.txtPassword)
			Me.panel1.Controls.Add(Me.btnGenerate)
			Me.panel1.Location = New System.Drawing.Point(11, 174)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(491, 49)
			Me.panel1.TabIndex = 13
			' 
			' frmMain
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(509, 246)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.statusMain)
			Me.Controls.Add(Me.grpMinimums)
			Me.Controls.Add(Me.grpRules)
			Me.Controls.Add(Me.grpCharsToUse)
			Me.Controls.Add(Me.menuMain)
			Me.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.KeyPreview = True
			Me.MainMenuStrip = Me.menuMain
			Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.MaximizeBox = False
			Me.Name = "frmMain"
			Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Password Generator"
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.frmMain_FormClosing)
'			Me.Load += New System.EventHandler(Me.frmMain_Load)
'			Me.KeyUp += New System.Windows.Forms.KeyEventHandler(Me.frmMain_KeyUp)
			DirectCast(Me.numericUpDownChars, System.ComponentModel.ISupportInitialize).EndInit()
			Me.grpCharsToUse.ResumeLayout(False)
			Me.grpCharsToUse.PerformLayout()
			Me.menuMain.ResumeLayout(False)
			Me.menuMain.PerformLayout()
			Me.grpRules.ResumeLayout(False)
			Me.pnlRules.ResumeLayout(False)
			Me.pnlRules.PerformLayout()
			Me.pnlNumberOfChars.ResumeLayout(False)
			Me.pnlNumberOfChars.PerformLayout()
			Me.grpMinimums.ResumeLayout(False)
			DirectCast(Me.numericUpDownSymbols, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.numericUpDownUpper, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.numericUpDownLower, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.numericUpDownDigits, System.ComponentModel.ISupportInitialize).EndInit()
			Me.statusMain.ResumeLayout(False)
			Me.statusMain.PerformLayout()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private lblNumOfChars As System.Windows.Forms.Label
		Private numericUpDownChars As System.Windows.Forms.NumericUpDown
		Private WithEvents chkDigits As System.Windows.Forms.CheckBox
		Private WithEvents chkUpperCaseLetters As System.Windows.Forms.CheckBox
		Private WithEvents chkLowerCaseLetters As System.Windows.Forms.CheckBox
		Private WithEvents chkSymbols As System.Windows.Forms.CheckBox
		Private grpCharsToUse As System.Windows.Forms.GroupBox
		Private menuMain As System.Windows.Forms.MenuStrip
		Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private editToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents copyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private txtPassword As System.Windows.Forms.TextBox
		Private WithEvents btnGenerate As System.Windows.Forms.Button
		Private grpRules As System.Windows.Forms.GroupBox
		Private chkNoRepeats As System.Windows.Forms.CheckBox
		Private pnlNumberOfChars As System.Windows.Forms.Panel
		Private WithEvents chkNoAdjacents As System.Windows.Forms.CheckBox
		Private WithEvents chkCharOnce As System.Windows.Forms.CheckBox
		Private toolTip As System.Windows.Forms.ToolTip
		Private toolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents settingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private pnlRules As System.Windows.Forms.Panel
		Private grpMinimums As System.Windows.Forms.GroupBox
		Private WithEvents numericUpDownSymbols As System.Windows.Forms.NumericUpDown
		Private WithEvents numericUpDownUpper As System.Windows.Forms.NumericUpDown
		Private WithEvents numericUpDownLower As System.Windows.Forms.NumericUpDown
		Private WithEvents numericUpDownDigits As System.Windows.Forms.NumericUpDown
		Private WithEvents workerGeneratePassword As System.ComponentModel.BackgroundWorker
		Private statusMain As System.Windows.Forms.StatusStrip
		Private toolStripProgressBar As System.Windows.Forms.ToolStripProgressBar
		Private toolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
		Private panel1 As System.Windows.Forms.Panel
	End Class
End Namespace

