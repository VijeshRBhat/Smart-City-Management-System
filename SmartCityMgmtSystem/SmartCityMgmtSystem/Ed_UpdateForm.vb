﻿Public Class Ed_UpdateForm
    Private newFont As Font = New Font("Arial", 12)
    Private newFontColor As Color = Color.Black

    'Initialise to null string'
    Public Property original As String = ""
    Public Property updated As String = ""

    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click
        ' Open font dialog to select font
        Dim fontDialog As New FontDialog()
        If fontDialog.ShowDialog() = DialogResult.OK Then
            newFont = fontDialog.Font
        End If
    End Sub

    Private Sub btnFontColor_Click(sender As Object, e As EventArgs) Handles btnFontColor.Click
        ' Open color dialog to select font color
        Dim colorDialog As New ColorDialog()
        If colorDialog.ShowDialog() = DialogResult.OK Then
            newFontColor = colorDialog.Color
        End If
    End Sub

    Private Sub RichTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles RichTextBox1.KeyDown
        ' Apply font and color to newly typed text
        Dim startIndex As Integer = RichTextBox1.SelectionStart
        Dim length As Integer = RichTextBox1.SelectionLength
        RichTextBox1.SelectionFont = newFont
        RichTextBox1.SelectionColor = newFontColor
        RichTextBox1.Select(startIndex, length)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Store the summary variable'
        updated = RichTextBox1.Rtf
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Ed_UpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Rtf = original
    End Sub
End Class