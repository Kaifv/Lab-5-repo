<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveasFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExitForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopyText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCutText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPasteFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAboutFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtTextArea = New System.Windows.Forms.TextBox()
        Me.ttTextEditor = New System.Windows.Forms.ToolTip(Me.components)
        Me.openDialog = New System.Windows.Forms.OpenFileDialog()
        Me.saveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.menuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEditFile, Me.mnuHelpFile})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(624, 30)
        Me.menuStrip.TabIndex = 0
        Me.menuStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewFile, Me.mnuOpenFile, Me.mnuSaveFile, Me.mnuSaveasFile, Me.mnuExitForm})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(46, 26)
        Me.mnuFile.Text = "&File"
        Me.mnuFile.ToolTipText = "Click for options to perfrom functions on file"
        '
        'mnuNewFile
        '
        Me.mnuNewFile.Name = "mnuNewFile"
        Me.mnuNewFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuNewFile.Size = New System.Drawing.Size(224, 26)
        Me.mnuNewFile.Text = "&New"
        Me.mnuNewFile.ToolTipText = "CLick for new file"
        '
        'mnuOpenFile
        '
        Me.mnuOpenFile.Name = "mnuOpenFile"
        Me.mnuOpenFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpenFile.Size = New System.Drawing.Size(224, 26)
        Me.mnuOpenFile.Text = "&Open"
        Me.mnuOpenFile.ToolTipText = "Click for opening an existing file"
        '
        'mnuSaveFile
        '
        Me.mnuSaveFile.Name = "mnuSaveFile"
        Me.mnuSaveFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSaveFile.Size = New System.Drawing.Size(224, 26)
        Me.mnuSaveFile.Text = "&Save"
        Me.mnuSaveFile.ToolTipText = "Click to save the file"
        '
        'mnuSaveasFile
        '
        Me.mnuSaveasFile.Name = "mnuSaveasFile"
        Me.mnuSaveasFile.Size = New System.Drawing.Size(224, 26)
        Me.mnuSaveasFile.Text = "Save &As"
        Me.mnuSaveasFile.ToolTipText = "Click to save as the file"
        '
        'mnuExitForm
        '
        Me.mnuExitForm.Name = "mnuExitForm"
        Me.mnuExitForm.Size = New System.Drawing.Size(224, 26)
        Me.mnuExitForm.Text = "E&xit"
        Me.mnuExitForm.ToolTipText = "Click to exit the file"
        '
        'mnuEditFile
        '
        Me.mnuEditFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopyText, Me.mnuCutText, Me.mnuPasteFile})
        Me.mnuEditFile.Name = "mnuEditFile"
        Me.mnuEditFile.Size = New System.Drawing.Size(49, 26)
        Me.mnuEditFile.Text = "&Edit"
        Me.mnuEditFile.ToolTipText = "Click for seeing options for editing the text in the editor"
        '
        'mnuCopyText
        '
        Me.mnuCopyText.Name = "mnuCopyText"
        Me.mnuCopyText.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopyText.Size = New System.Drawing.Size(224, 26)
        Me.mnuCopyText.Text = "&Copy"
        Me.mnuCopyText.ToolTipText = "Click to copy the text"
        '
        'mnuCutText
        '
        Me.mnuCutText.Name = "mnuCutText"
        Me.mnuCutText.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCutText.Size = New System.Drawing.Size(224, 26)
        Me.mnuCutText.Text = "Cu&t"
        Me.mnuCutText.ToolTipText = "Click to cut the text"
        '
        'mnuPasteFile
        '
        Me.mnuPasteFile.Name = "mnuPasteFile"
        Me.mnuPasteFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPasteFile.Size = New System.Drawing.Size(224, 26)
        Me.mnuPasteFile.Text = "&Paste"
        Me.mnuPasteFile.ToolTipText = "Click to paste the text"
        '
        'mnuHelpFile
        '
        Me.mnuHelpFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAboutFile})
        Me.mnuHelpFile.Name = "mnuHelpFile"
        Me.mnuHelpFile.Size = New System.Drawing.Size(55, 26)
        Me.mnuHelpFile.Text = "Help"
        Me.mnuHelpFile.ToolTipText = "Click for some help"
        '
        'mnuAboutFile
        '
        Me.mnuAboutFile.Name = "mnuAboutFile"
        Me.mnuAboutFile.Size = New System.Drawing.Size(224, 26)
        Me.mnuAboutFile.Text = "About"
        Me.mnuAboutFile.ToolTipText = "Click for information of the file"
        '
        'txtTextArea
        '
        Me.txtTextArea.Location = New System.Drawing.Point(13, 32)
        Me.txtTextArea.Multiline = True
        Me.txtTextArea.Name = "txtTextArea"
        Me.txtTextArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTextArea.Size = New System.Drawing.Size(599, 368)
        Me.txtTextArea.TabIndex = 1
        '
        'openDialog
        '
        Me.openDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'saveDialog
        '
        Me.saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 412)
        Me.Controls.Add(Me.txtTextArea)
        Me.Controls.Add(Me.menuStrip)
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuNewFile As ToolStripMenuItem
    Friend WithEvents mnuOpenFile As ToolStripMenuItem
    Friend WithEvents mnuSaveFile As ToolStripMenuItem
    Friend WithEvents mnuSaveasFile As ToolStripMenuItem
    Friend WithEvents mnuExitForm As ToolStripMenuItem
    Friend WithEvents mnuEditFile As ToolStripMenuItem
    Friend WithEvents mnuCopyText As ToolStripMenuItem
    Friend WithEvents mnuCutText As ToolStripMenuItem
    Friend WithEvents mnuPasteFile As ToolStripMenuItem
    Friend WithEvents mnuHelpFile As ToolStripMenuItem
    Friend WithEvents mnuAboutFile As ToolStripMenuItem
    Friend WithEvents txtTextArea As TextBox
    Friend WithEvents ttTextEditor As ToolTip
    Friend WithEvents openDialog As OpenFileDialog
    Friend WithEvents saveDialog As SaveFileDialog
End Class
