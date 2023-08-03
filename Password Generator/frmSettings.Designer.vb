Namespace Password_Generator
	Partial Public Class frmSettings
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
			Me.chkListSymbols = New System.Windows.Forms.CheckedListBox()
			Me.grpKeyboard = New System.Windows.Forms.GroupBox()
			Me.lstLayouts = New System.Windows.Forms.ListBox()
			Me.grpSymbols = New System.Windows.Forms.GroupBox()
			Me.btnSelectNone = New System.Windows.Forms.Button()
			Me.btnSelectAll = New System.Windows.Forms.Button()
			Me.btnOK = New System.Windows.Forms.Button()
			Me.btnCancel = New System.Windows.Forms.Button()
			Me.grpKeyboard.SuspendLayout()
			Me.grpSymbols.SuspendLayout()
			Me.SuspendLayout()
			' 
			' chkListSymbols
			' 
			Me.chkListSymbols.CheckOnClick = True
			Me.chkListSymbols.ColumnWidth = 90
			Me.chkListSymbols.Dock = System.Windows.Forms.DockStyle.Top
			Me.chkListSymbols.Items.AddRange(New Object() { "'", "-", "!", """", "#", "$", "%", "&", "(", ")", "*", ",", ".", "/", ":", ";", "?", "@", "[", "\", "]", "^", "_", "`", "{", "|", "}", "~", "+", "<", "=", ">"})
			Me.chkListSymbols.Location = New System.Drawing.Point(7, 23)
			Me.chkListSymbols.MultiColumn = True
			Me.chkListSymbols.Name = "chkListSymbols"
			Me.chkListSymbols.Size = New System.Drawing.Size(364, 148)
			Me.chkListSymbols.TabIndex = 2
			' 
			' grpKeyboard
			' 
			Me.grpKeyboard.Controls.Add(Me.lstLayouts)
			Me.grpKeyboard.Location = New System.Drawing.Point(12, 12)
			Me.grpKeyboard.Name = "grpKeyboard"
			Me.grpKeyboard.Padding = New System.Windows.Forms.Padding(7)
			Me.grpKeyboard.Size = New System.Drawing.Size(139, 219)
			Me.grpKeyboard.TabIndex = 0
			Me.grpKeyboard.TabStop = False
			Me.grpKeyboard.Text = "Keyboard Layout"
			' 
			' lstLayouts
			' 
			Me.lstLayouts.Dock = System.Windows.Forms.DockStyle.Top
			Me.lstLayouts.FormattingEnabled = True
			Me.lstLayouts.ItemHeight = 16
			Me.lstLayouts.Items.AddRange(New Object() { "QWERTY"})
			Me.lstLayouts.Location = New System.Drawing.Point(7, 23)
			Me.lstLayouts.Name = "lstLayouts"
			Me.lstLayouts.Size = New System.Drawing.Size(125, 180)
			Me.lstLayouts.TabIndex = 2
			' 
			' grpSymbols
			' 
			Me.grpSymbols.Controls.Add(Me.btnSelectNone)
			Me.grpSymbols.Controls.Add(Me.btnSelectAll)
			Me.grpSymbols.Controls.Add(Me.chkListSymbols)
			Me.grpSymbols.Location = New System.Drawing.Point(157, 12)
			Me.grpSymbols.Name = "grpSymbols"
			Me.grpSymbols.Padding = New System.Windows.Forms.Padding(7)
			Me.grpSymbols.Size = New System.Drawing.Size(378, 219)
			Me.grpSymbols.TabIndex = 3
			Me.grpSymbols.TabStop = False
			Me.grpSymbols.Text = "Symbols to use"
			' 
			' btnSelectNone
			' 
			Me.btnSelectNone.Location = New System.Drawing.Point(116, 177)
			Me.btnSelectNone.Name = "btnSelectNone"
			Me.btnSelectNone.Size = New System.Drawing.Size(100, 25)
			Me.btnSelectNone.TabIndex = 4
			Me.btnSelectNone.Text = "Select none"
			Me.btnSelectNone.UseVisualStyleBackColor = True
'			Me.btnSelectNone.Click += New System.EventHandler(Me.btnSelect_Click)
			' 
			' btnSelectAll
			' 
			Me.btnSelectAll.Location = New System.Drawing.Point(10, 177)
			Me.btnSelectAll.Name = "btnSelectAll"
			Me.btnSelectAll.Size = New System.Drawing.Size(100, 25)
			Me.btnSelectAll.TabIndex = 3
			Me.btnSelectAll.Text = "Select all"
			Me.btnSelectAll.UseVisualStyleBackColor = True
'			Me.btnSelectAll.Click += New System.EventHandler(Me.btnSelect_Click)
			' 
			' btnOK
			' 
			Me.btnOK.Location = New System.Drawing.Point(444, 237)
			Me.btnOK.Name = "btnOK"
			Me.btnOK.Size = New System.Drawing.Size(91, 31)
			Me.btnOK.TabIndex = 4
			Me.btnOK.Text = "OK"
			Me.btnOK.UseVisualStyleBackColor = True
'			Me.btnOK.Click += New System.EventHandler(Me.btnOK_Click)
			' 
			' btnCancel
			' 
			Me.btnCancel.Location = New System.Drawing.Point(320, 237)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New System.Drawing.Size(118, 31)
			Me.btnCancel.TabIndex = 5
			Me.btnCancel.Text = "Cancel"
			Me.btnCancel.UseVisualStyleBackColor = True
'			Me.btnCancel.Click += New System.EventHandler(Me.btnCancel_Click)
			' 
			' frmSettings
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(547, 280)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnOK)
			Me.Controls.Add(Me.grpSymbols)
			Me.Controls.Add(Me.grpKeyboard)
			Me.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.Name = "frmSettings"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Settings"
'			Me.Load += New System.EventHandler(Me.frmSettings_Load)
			Me.grpKeyboard.ResumeLayout(False)
			Me.grpSymbols.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chkListSymbols As System.Windows.Forms.CheckedListBox
		Private grpKeyboard As System.Windows.Forms.GroupBox
		Private lstLayouts As System.Windows.Forms.ListBox
		Private grpSymbols As System.Windows.Forms.GroupBox
		Private WithEvents btnOK As System.Windows.Forms.Button
		Private WithEvents btnCancel As System.Windows.Forms.Button
		Private WithEvents btnSelectAll As System.Windows.Forms.Button
		Private WithEvents btnSelectNone As System.Windows.Forms.Button

	End Class
End Namespace