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
	Partial Public Class frmSettings
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
			Me.Close()
		End Sub

		Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
			Dim total As Integer = chkListSymbols.Items.Count
			Dim symbolsToUse As String = String.Empty

			For i As Integer = 0 To total - 1
				If chkListSymbols.GetItemChecked(i) Then
					symbolsToUse &= chkListSymbols.Items(i).ToString()
				End If
			Next i
			My.Settings.Default.Symbols = symbolsToUse
			My.Settings.Default.KeyboardLayout = lstLayouts.SelectedItem.ToString()
			My.Settings.Default.Save()

			DirectCast(Me.Owner, frmMain).chkCharsToUse_CheckedChanged(Nothing, Nothing)


			Me.Close()
		End Sub

		Private Sub btnSelect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelectNone.Click, btnSelectAll.Click
			Dim n As Integer = chkListSymbols.Items.Count
			Dim value As Boolean = sender.Equals(btnSelectAll)

			For i As Integer = 0 To n - 1
				chkListSymbols.SetItemChecked(i, value)
			Next i
		End Sub

		Private Sub frmSettings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			lstLayouts.SelectedItem = My.Settings.Default.KeyboardLayout

			Dim symbolsToUse As String = My.Settings.Default.Symbols
			Dim n As Integer = chkListSymbols.Items.Count

			For i As Integer = 0 To n - 1
				chkListSymbols.SetItemChecked(i, symbolsToUse.Contains(chkListSymbols.Items(i).ToString()))
			Next i
		End Sub
	End Class
End Namespace
