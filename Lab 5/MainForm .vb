Option Strict On
Imports System.IO

Public Class mainForm

    ''' <summary>
    ''' This menu button will let the text editor make a new file. It will jsut the empty the current text in the text editor. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NewFile_Click(sender As Object, e As EventArgs) Handles mnuNewFile.Click
        txtTextArea.Text = String.Empty
    End Sub

    ''' <summary>
    ''' This is the open menu button which will open the file explorer for opening a new text file. But point to be kpt in mind is that it will only save text
    ''' file. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuOpenFile_Click(sender As Object, e As EventArgs) Handles mnuOpenFile.Click


        If openDialog.ShowDialog() = DialogResult.OK Then

            Dim openFile As New FileStream(openDialog.FileName, FileMode.Open, FileAccess.Read)
            Dim inputStream As New StreamReader(openFile)
            txtTextArea.Text = inputStream.ReadToEnd()
            inputStream.Close()
        End If


    End Sub

    ''' <summary>
    ''' This menu button option will let you save the file at any location, if the file is already saved then it will not ask for the path.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuSaveFile_Click(sender As Object, e As EventArgs) Handles mnuSaveFile.Click

        If saveDialog.ShowDialog() = DialogResult.OK Then

            Dim saveFile As New FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write)
            Dim outputStream As New StreamWriter(saveFile)

            outputStream.Write(txtTextArea.Text)
            outputStream.Close()
        End If
    End Sub

    ''' <summary>
    ''' This is the save as button menu option which will save the file as we desire it to. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuSaveasFile_Click(sender As Object, e As EventArgs) Handles mnuSaveasFile.Click
        If saveDialog.ShowDialog() = DialogResult.OK Then
            If (saveDialog.FileName = String.Empty) Then
                Dim saveas As New StreamWriter(saveDialog.FileName)
                saveas.Write(txtTextArea.Text)
                saveas.Close()
            Else
                mnuSaveFile_Click(sender, e)
            End If
        End If
    End Sub

    ''' <summary>
    ''' This will let you exit the form, but it will not ask you for saving the file. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuExitForm_Click(sender As Object, e As EventArgs) Handles mnuExitForm.Click
        Application.Exit()

    End Sub

    ''' <summary>
    ''' This is the copy option in the edit menu, which will allow you to copy the text from the text editor. It will be saved in the clipboard. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuCopyText_Click(sender As Object, e As EventArgs) Handles mnuCopyText.Click

        If txtTextArea.SelectionLength > 0 Then
            Clipboard.SetText(txtTextArea.SelectedText)
        End If

    End Sub

    ''' <summary>
    ''' This will let you cut the text from the text in the text editor. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuCutText_Click(sender As Object, e As EventArgs) Handles mnuCutText.Click

        Clipboard.SetText(txtTextArea.SelectedText)
            txtTextArea.SelectedText = ""

    End Sub

    ''' <summary>
    ''' This will let you paste the text from the text editor file. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuPasteFile_Click(sender As Object, e As EventArgs) Handles mnuPasteFile.Click

        If Clipboard.ContainsText Then
            txtTextArea.SelectedText = Clipboard.GetText
        End If
    End Sub

    ''' <summary>
    ''' In this help option a message box will be displayed in the form which will show you some data about the file. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuAboutFile_Click(sender As Object, e As EventArgs) Handles mnuAboutFile.Click
        MessageBox.Show("NETD2202 " & vbCrLf & "Lab 5")


    End Sub
End Class
