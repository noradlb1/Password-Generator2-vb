Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Password_Generator
	Partial Public Class frmMain
		Inherits Form

		Private Const DIGITS As Integer = 10
		Private Const LETTERS As Integer = 26
		Private Const ALL_SYMBOLS As Integer = 32
		Private Const SEPERATOR As Char = "|"c

		Private Structure Argument
			Public useDigits, useLower, useUpper, useSymbols, noRepeats, noAdjacents, charOnce As Boolean
			Public numOfChars, minDigits, minLower, minUpper, minSymbols As Decimal
		End Structure

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnGenerate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerate.Click
			Dim arg As New Argument()
			arg.charOnce = chkCharOnce.Checked
			arg.minDigits = numericUpDownDigits.Value
			arg.minLower = numericUpDownLower.Value
			arg.minSymbols = numericUpDownSymbols.Value
			arg.minUpper = numericUpDownUpper.Value
			arg.noAdjacents = chkNoAdjacents.Checked
			arg.noRepeats = chkNoRepeats.Checked
			arg.numOfChars = numericUpDownChars.Value
			arg.useDigits = chkDigits.Checked
			arg.useLower = chkLowerCaseLetters.Checked
			arg.useSymbols = chkSymbols.Checked
			arg.useUpper = chkUpperCaseLetters.Checked

			Me.Cursor = Cursors.WaitCursor
			workerGeneratePassword.RunWorkerAsync(arg)
			For Each item As Control In Me.Controls
				If (Not item.Equals(statusMain)) AndAlso (Not item.Equals(menuMain)) Then
					item.Enabled = False
				End If
			Next item
			settingsToolStripMenuItem.Enabled = False
			copyToolStripMenuItem.Enabled = False
		End Sub

		Private Function hasEnoughDigits(ByVal s As String, ByVal min As Integer) As Boolean
			For i As Integer = s.Length - 1 To 0 Step -1
				If Char.IsDigit(s.Chars(i)) Then
					min -= 1
				End If
			Next i
			Return (min <= 0)
		End Function

		Private Function hasEnoughLowerCaseLetters(ByVal s As String, ByVal min As Integer) As Boolean
			For i As Integer = s.Length - 1 To 0 Step -1
				If Char.IsLower(s.Chars(i)) Then
					min -= 1
				End If
			Next i
			Return (min <= 0)
		End Function

		Private Function hasEnoughUpperCaseLetters(ByVal s As String, ByVal min As Integer) As Boolean
			For i As Integer = s.Length - 1 To 0 Step -1
				If Char.IsUpper(s.Chars(i)) Then
					min -= 1
				End If
			Next i
			Return (min <= 0)
		End Function

		Private Function hasEnoughSymbols(ByVal s As String, ByVal min As Integer, ByVal symbols() As Char) As Boolean
			For i As Integer = s.Length - 1 To 0 Step -1
				If symbols.Contains(s.Chars(i)) Then
					min -= 1
				End If
			Next i
			Return (min <= 0)
		End Function

		Private Function generatePassword(ByVal chars() As Char, ByVal numOfChars As UShort, ByVal noRepeats As Boolean, ByVal noAdjacents As Boolean, ByVal charsOnceOnly As Boolean) As String
			Dim n As Integer = chars.Length - 1, randVal As Integer
			Dim rand As New Random()
			Dim password(numOfChars - 1) As Char

			Dim charUsed(n) As Boolean ' default: false

			randVal = rand.Next(n)
			password(0) = chars(randVal)
			charUsed(randVal) = True
			Dim keyboard As New Keyboard(My.Settings.Default.KeyboardLayout)

			For i As UShort = 1 To numOfChars - 1
				Do
					If workerGeneratePassword.CancellationPending Then
						Return "blahrg"
					End If

					randVal = rand.Next(n)
					password(i) = chars(randVal)
				Loop While (charsOnceOnly AndAlso charUsed(randVal)) OrElse (noRepeats AndAlso (password(i) = password(i - 1))) OrElse (noAdjacents AndAlso keyboard.areAdjacent(password(i), password(i - 1)))

				charUsed(randVal) = True
			Next i
			Return toString(password)
		End Function

		Private Function generateCharArray(ByVal useDigits As Boolean, ByVal useLowerCaseLetters As Boolean, ByVal useUpperCaseLetter As Boolean, ByVal useSymbols As Boolean) As Char()
			Dim chars((DIGITS + 2 * LETTERS + ALL_SYMBOLS) - 1) As Char
			Dim i As Integer = 0
			Dim j As Char = ControlChars.NullChar

			If useDigits Then
				j = "0"c
				Do While j <= "9"c
					chars(i) = j
					j = ChrW(AscW(j) + 1)
					i += 1
				Loop
			End If
			If useLowerCaseLetters Then
				j = "a"c
				Do While j <= "z"c
					chars(i) = j
					j = ChrW(AscW(j) + 1)
					i += 1
				Loop
			End If
			If useUpperCaseLetter Then
				j = "A"c
				Do While j <= "Z"c
					chars(i) = j
					j = ChrW(AscW(j) + 1)
					i += 1
				Loop
			End If
			If useSymbols Then
				Dim symbols As String = My.Settings.Default.Symbols

				Dim k As Integer = 0
				Do While k < symbols.Length
					chars(i) = symbols.Chars(k)
					k += 1
					i += 1
				Loop
			End If
			Array.Resize(chars, i + 1)

			Return chars
		End Function


		Private Function toString(ByVal array() As Char) As String
			Dim len As Integer = array.Length
			Dim s As String = String.Empty

			For i As Integer = 0 To len - 1
				s &= array(i)
			Next i
			Return s
		End Function

		Public Sub chkCharsToUse_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkDigits.CheckedChanged, chkUpperCaseLetters.CheckedChanged, chkLowerCaseLetters.CheckedChanged, chkSymbols.CheckedChanged
			If My.Settings.Default.Symbols.Length = 0 Then
				chkSymbols.Checked = False
				chkSymbols.Enabled = False
			Else
				chkSymbols.Enabled = True
			End If

			btnGenerate.Enabled = chkDigits.Checked OrElse chkLowerCaseLetters.Checked OrElse chkUpperCaseLetters.Checked OrElse chkSymbols.Checked
			chkCharOnce_CheckedChanged(Nothing, Nothing)

			numericUpDownDigits.Visible = chkDigits.Checked
			If Not chkDigits.Checked Then
				numericUpDownDigits.Value = 1
			End If

			numericUpDownLower.Visible = chkLowerCaseLetters.Checked
			If Not chkLowerCaseLetters.Checked Then
				numericUpDownLower.Value = 1
			End If

			numericUpDownUpper.Visible = chkUpperCaseLetters.Checked
			If Not chkUpperCaseLetters.Checked Then
				numericUpDownUpper.Value = 1
			End If

			numericUpDownSymbols.Visible = chkSymbols.Checked
			If Not chkSymbols.Checked Then
				numericUpDownSymbols.Value = 1
			End If

			numericUpDown_ValueChanged(Nothing, Nothing)

		End Sub

		Private Sub updateMaxMin(ByVal n As NumericUpDown)
			Dim valueBefore As Decimal = n.Value
			If chkCharOnce.Checked Then
				n.Maximum = 0
				If chkDigits.Checked Then
					n.Maximum += DIGITS
				End If
				If chkLowerCaseLetters.Checked Then
					n.Maximum += LETTERS
				End If
				If chkUpperCaseLetters.Checked Then
					n.Maximum += LETTERS
				End If
				If chkSymbols.Checked Then
					n.Maximum += My.Settings.Default.Symbols.Length
				End If
				If n.Maximum = 0 Then
					n.Maximum += 1
				End If
			Else
				n.Maximum = 400
			End If
			n.Value = valueBefore
		End Sub

		Private Sub chkCharOnce_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkCharOnce.CheckedChanged
			Dim d As Decimal
			If chkCharOnce.Checked Then
				d = numericUpDownDigits.Value
				numericUpDownDigits.Maximum = DIGITS
				numericUpDownDigits.Value = If(d<DIGITS, d, DIGITS)

				d = numericUpDownLower.Value
				numericUpDownLower.Maximum = LETTERS
				numericUpDownLower.Value = If(d < LETTERS, d, LETTERS)

				d = numericUpDownUpper.Value
				numericUpDownUpper.Maximum = LETTERS
				numericUpDownUpper.Value = If(d < LETTERS, d, LETTERS)

				d = numericUpDownSymbols.Value
				numericUpDownSymbols.Maximum = (If(My.Settings.Default.Symbols.Length = 0, 1, My.Settings.Default.Symbols.Length))
				numericUpDownSymbols.Value = If(d < My.Settings.Default.Symbols.Length, d, (If(My.Settings.Default.Symbols.Length = 0, 1, My.Settings.Default.Symbols.Length)))
			Else
				For Each item In grpMinimums.Controls
					d = CType(item, NumericUpDown).Value
					CType(item, NumericUpDown).Maximum = 100
					CType(item, NumericUpDown).Value = d
				Next item
			End If
		End Sub

		Private Sub copyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles copyToolStripMenuItem.Click
			If txtPassword.Text <> "" Then
				Clipboard.SetText(txtPassword.Text)
			End If
		End Sub

		Private Sub chkNoAdjacents_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkNoAdjacents.CheckedChanged
			If chkNoAdjacents.Checked Then
				chkNoRepeats.Checked = True
				chkNoRepeats.Enabled = False
			Else
				chkNoRepeats.Checked = False
				chkNoRepeats.Enabled = True
			End If
		End Sub

		Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitToolStripMenuItem.Click
			Me.Close()
		End Sub

		Private Sub settingsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles settingsToolStripMenuItem.Click
			CType(New frmSettings(), frmSettings).ShowDialog(Me)
		End Sub

		Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			Dim charsToUse As String = String.Empty
			For Each item As Control In grpCharsToUse.Controls
				charsToUse &= CType(item, CheckBox).Checked.ToString() & SEPERATOR
			Next item
			charsToUse = charsToUse.Remove(charsToUse.Length - 1)

			Dim rules As String = String.Empty
			For Each item As Control In pnlRules.Controls
				rules &= CType(item, CheckBox).Checked.ToString() & SEPERATOR
			Next item
			rules = rules.Remove(rules.Length - 1)

			My.Settings.Default.CharsToUse = charsToUse
			My.Settings.Default.Rules = rules
			My.Settings.Default.NumberOfChars = numericUpDownChars.Value
			My.Settings.Default.MinDigits = numericUpDownDigits.Value
			My.Settings.Default.MinLower = numericUpDownLower.Value
			My.Settings.Default.MinUpper = numericUpDownUpper.Value
			My.Settings.Default.MinSymbols = numericUpDownSymbols.Value
			My.Settings.Default.Save()
		End Sub

		Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim stringArray() As String = My.Settings.Default.CharsToUse.Split(SEPERATOR)
			Dim i As Integer = 0
			For Each item As Control In grpCharsToUse.Controls
				CType(item, CheckBox).Checked = Boolean.Parse(stringArray(i))
				i += 1
			Next item

			stringArray = My.Settings.Default.Rules.Split(SEPERATOR)
			i = 0
			For Each item As Control In pnlRules.Controls
				CType(item, CheckBox).Checked = Boolean.Parse(stringArray(i))
				i += 1
			Next item
			'numericUpDown_ValueChanged(null, null);
			numericUpDownDigits.Value = My.Settings.Default.MinDigits
			numericUpDownLower.Value = My.Settings.Default.MinLower
			numericUpDownUpper.Value = My.Settings.Default.MinUpper
			numericUpDownSymbols.Value = My.Settings.Default.MinSymbols
			numericUpDownChars.Value = If(My.Settings.Default.NumberOfChars = 0, 1, My.Settings.Default.NumberOfChars)
		End Sub

		Private Sub numericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDownSymbols.ValueChanged, numericUpDownUpper.ValueChanged, numericUpDownLower.ValueChanged, numericUpDownDigits.ValueChanged
			Dim total As Decimal = 0
			For Each c As Control In grpMinimums.Controls
				If c.Visible Then
					total += CType(c, NumericUpDown).Value
				End If
			Next c
			numericUpDownChars.Minimum = total

			total = 0
			For Each c As Control In grpMinimums.Controls
				If c.Visible Then
					total += CType(c, NumericUpDown).Maximum
				End If
			Next c
			numericUpDownChars.Maximum = total
		End Sub



		Private Sub workerGeneratePassword_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles workerGeneratePassword.DoWork
			Dim arg As Argument = DirectCast(e.Argument, Argument)

			Dim chars() As Char = generateCharArray(arg.useDigits, arg.useLower, arg.useUpper, arg.useSymbols)
			Dim password As String = generatePassword(chars, CUShort(arg.numOfChars), arg.noRepeats, arg.noAdjacents, arg.charOnce)

			Dim symbols() As Char = generateCharArray(False, False, False, True)

			Do While (arg.useLower AndAlso (Not hasEnoughLowerCaseLetters(password, CInt(Math.Truncate(arg.minLower))))) OrElse (arg.useUpper AndAlso (Not hasEnoughUpperCaseLetters(password, CInt(Math.Truncate(arg.minUpper))))) OrElse (arg.useSymbols AndAlso (Not hasEnoughSymbols(password, CInt(Math.Truncate(arg.minSymbols)), symbols))) OrElse (arg.useDigits AndAlso (Not hasEnoughDigits(password, CInt(Math.Truncate(arg.minDigits)))))
				If workerGeneratePassword.CancellationPending Then
					e.Cancel = True
					Return
				End If
				password = generatePassword(chars, CUShort(arg.numOfChars), arg.noRepeats, arg.noAdjacents, arg.charOnce)
			Loop
			e.Result = password
		End Sub

		Private Sub workerGeneratePassword_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles workerGeneratePassword.RunWorkerCompleted
			If Not e.Cancelled Then
				txtPassword.Text = e.Result.ToString()
			End If
			Me.Cursor = Cursors.Default
			For Each item As Control In Me.Controls
				item.Enabled = True
			Next item
			settingsToolStripMenuItem.Enabled = True
			copyToolStripMenuItem.Enabled = True
		End Sub

		Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyUp
			If e.KeyCode=Keys.Escape AndAlso workerGeneratePassword.IsBusy Then
				workerGeneratePassword.CancelAsync()
			End If
		End Sub

		Private Sub btnGenerate_EnabledChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerate.EnabledChanged
			If workerGeneratePassword.IsBusy Then
				toolStripStatusLabel.Text = " Generating...  press Esc to stop"
				toolStripProgressBar.Visible = True
			Else
				toolStripProgressBar.Visible = False
				If DirectCast(sender, Control).Enabled Then
					toolStripStatusLabel.Text = " Ready"
				Else
					toolStripStatusLabel.Text = " Select characters to use"
				End If
			End If
		End Sub
	End Class

	Friend NotInheritable Class Keyboard
		Private mChars(,) As Char
		Private mAltChars(,) As Char
		Private mSize As New Index2d()

		Private Structure Index2d
			Public Row As Short
			Public Column As Short
		End Structure

		Public Sub New(ByVal layout As String)
			Select Case layout
				Case "QWERTY"
					mSize.Row = 4
					mSize.Column = 13

					mChars = New Char(,) { {"`"c,"1"c,"2"c,"3"c,"4"c,"5"c,"6"c,"7"c,"8"c,"9"c,"0"c,"-"c,"="c, ControlChars.NullChar}, {ControlChars.NullChar,"q"c,"w"c,"e"c,"r"c,"t"c,"y"c,"u"c,"i"c,"o"c,"p"c,"["c,"]"c,"\"c}, {ControlChars.NullChar,"a"c,"s"c,"d"c,"f"c,"g"c,"h"c,"j"c,"k"c,"l"c,";"c,"'"c,ControlChars.NullChar,ControlChars.NullChar}, {ControlChars.NullChar,"z"c,"x"c,"c"c,"v"c,"b"c,"n"c,"m"c,","c,"."c,"/"c,ControlChars.NullChar,ControlChars.NullChar,ControlChars.NullChar} }
					mAltChars = New Char(,) { {"~"c,"!"c,"@"c,"#"c,"$"c,"%"c,"^"c,"&"c,"*"c,"("c,")"c,"_"c,"+"c, ControlChars.NullChar}, {ControlChars.NullChar,"Q"c,"W"c,"E"c,"R"c,"T"c,"Y"c,"U"c,"I"c,"O"c,"P"c,"{"c,"}"c,"|"c}, {ControlChars.NullChar,"A"c,"S"c,"D"c,"F"c,"G"c,"H"c,"J"c,"K"c,"L"c,":"c,""""c,ControlChars.NullChar,ControlChars.NullChar}, {ControlChars.NullChar,"Z"c,"X"c,"C"c,"V"c,"B"c,"N"c,"M"c,"<"c,">"c,"?"c,ControlChars.NullChar,ControlChars.NullChar,ControlChars.NullChar} }
			End Select
		End Sub

		Public Function areAdjacent(ByVal c1 As Char, ByVal c2 As Char) As Boolean
			Dim index1 As Index2d = indexOf(c1, mChars), index2 As Index2d = indexOf(c2, mChars)
			If index1.Column = -1 OrElse index1.Row = -1 Then
				index1 = indexOf(c1, mAltChars)
			End If
			If index2.Column = -1 OrElse index2.Row = -1 Then
				index2 = indexOf(c2, mAltChars)
			End If

			' We will assume that both characters were found at this point

			Dim sameKey As Boolean = (index1.Column = index2.Column) AndAlso (index1.Row = index2.Row)
			Dim diffCol As Short = abs(index1.Column, index2.Column)
			Dim diffRow As Short = abs(index1.Row, index2.Row)

			Return (diffCol <= 1 AndAlso diffRow <= 1)
		End Function

		Private Function indexOf(ByVal c As Char, ByVal array(,) As Char) As Index2d
			Dim index As New Index2d()
			index.Row = -1
			index.Column = index.Row

			For i As Short = 0 To mSize.Row - 1
				For j As Short = 0 To mSize.Column - 1
					If array(i, j) = c Then
						index.Row = i
						index.Column = j
						Return index
					End If
				Next j
			Next i

			Return index
		End Function

		Private Function abs(ByVal a As Short, ByVal b As Short) As Short
			Return CShort(Math.Truncate(If(a > b, (a - b), (b - a))))
		End Function
	End Class
End Namespace
