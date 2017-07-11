<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.MainMenu_TabControl = New System.Windows.Forms.TabControl()
        Me.Directories_TabPage = New System.Windows.Forms.TabPage()
        Me.Mods_TabPage = New System.Windows.Forms.TabPage()
        Me.DirectoryNames_Directories_ListBox = New System.Windows.Forms.ListBox()
        Me.AddDirectory_Directories_Button = New System.Windows.Forms.Button()
        Me.DeleteDirectory_Directories_Button = New System.Windows.Forms.Button()
        Me.UpdateDirectoryInfo_Directories_Button = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DirectoryName_Directories_Label = New System.Windows.Forms.Label()
        Me.DirectoryPath_Directories_Label = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.NavToDirectory_Directories_Button = New System.Windows.Forms.Button()
        Me.DirectoryInfo_Directories_Label = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.DirectoryNames_Mods_ListBox = New System.Windows.Forms.ListBox()
        Me.ModsInDirectory_Mods_ListBox = New System.Windows.Forms.ListBox()
        Me.Directories_Mods_Label = New System.Windows.Forms.Label()
        Me.ModsInDirectory_Mods_Label = New System.Windows.Forms.Label()
        Me.AvalableMods_Mods_Label = New System.Windows.Forms.Label()
        Me.AvalableMods_Mods_ListBox = New System.Windows.Forms.ListBox()
        Me.AddMod_Mods_Button = New System.Windows.Forms.Button()
        Me.RemoveMod_Mods_Button = New System.Windows.Forms.Button()
        Me.AddModFile_Mods_Button = New System.Windows.Forms.Button()
        Me.UpdateMods_Mods_Button = New System.Windows.Forms.Button()
        Me.ResetChages_Mods_Button = New System.Windows.Forms.Button()
        Me.MainMenu_TabControl.SuspendLayout()
        Me.Directories_TabPage.SuspendLayout()
        Me.Mods_TabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu_TabControl
        '
        Me.MainMenu_TabControl.Controls.Add(Me.Directories_TabPage)
        Me.MainMenu_TabControl.Controls.Add(Me.Mods_TabPage)
        Me.MainMenu_TabControl.Location = New System.Drawing.Point(12, 12)
        Me.MainMenu_TabControl.Name = "MainMenu_TabControl"
        Me.MainMenu_TabControl.SelectedIndex = 0
        Me.MainMenu_TabControl.Size = New System.Drawing.Size(1274, 780)
        Me.MainMenu_TabControl.TabIndex = 0
        '
        'Directories_TabPage
        '
        Me.Directories_TabPage.Controls.Add(Me.RichTextBox1)
        Me.Directories_TabPage.Controls.Add(Me.DirectoryInfo_Directories_Label)
        Me.Directories_TabPage.Controls.Add(Me.NavToDirectory_Directories_Button)
        Me.Directories_TabPage.Controls.Add(Me.TextBox2)
        Me.Directories_TabPage.Controls.Add(Me.DirectoryPath_Directories_Label)
        Me.Directories_TabPage.Controls.Add(Me.DirectoryName_Directories_Label)
        Me.Directories_TabPage.Controls.Add(Me.TextBox1)
        Me.Directories_TabPage.Controls.Add(Me.UpdateDirectoryInfo_Directories_Button)
        Me.Directories_TabPage.Controls.Add(Me.DeleteDirectory_Directories_Button)
        Me.Directories_TabPage.Controls.Add(Me.AddDirectory_Directories_Button)
        Me.Directories_TabPage.Controls.Add(Me.DirectoryNames_Directories_ListBox)
        Me.Directories_TabPage.Location = New System.Drawing.Point(8, 39)
        Me.Directories_TabPage.Name = "Directories_TabPage"
        Me.Directories_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.Directories_TabPage.Size = New System.Drawing.Size(1258, 733)
        Me.Directories_TabPage.TabIndex = 0
        Me.Directories_TabPage.Text = "Directories"
        Me.Directories_TabPage.UseVisualStyleBackColor = True
        '
        'Mods_TabPage
        '
        Me.Mods_TabPage.Controls.Add(Me.ResetChages_Mods_Button)
        Me.Mods_TabPage.Controls.Add(Me.UpdateMods_Mods_Button)
        Me.Mods_TabPage.Controls.Add(Me.AddModFile_Mods_Button)
        Me.Mods_TabPage.Controls.Add(Me.RemoveMod_Mods_Button)
        Me.Mods_TabPage.Controls.Add(Me.AddMod_Mods_Button)
        Me.Mods_TabPage.Controls.Add(Me.AvalableMods_Mods_ListBox)
        Me.Mods_TabPage.Controls.Add(Me.AvalableMods_Mods_Label)
        Me.Mods_TabPage.Controls.Add(Me.ModsInDirectory_Mods_Label)
        Me.Mods_TabPage.Controls.Add(Me.Directories_Mods_Label)
        Me.Mods_TabPage.Controls.Add(Me.ModsInDirectory_Mods_ListBox)
        Me.Mods_TabPage.Controls.Add(Me.DirectoryNames_Mods_ListBox)
        Me.Mods_TabPage.Location = New System.Drawing.Point(8, 39)
        Me.Mods_TabPage.Name = "Mods_TabPage"
        Me.Mods_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.Mods_TabPage.Size = New System.Drawing.Size(1258, 733)
        Me.Mods_TabPage.TabIndex = 1
        Me.Mods_TabPage.Text = "Mods"
        Me.Mods_TabPage.UseVisualStyleBackColor = True
        '
        'DirectoryNames_Directories_ListBox
        '
        Me.DirectoryNames_Directories_ListBox.FormattingEnabled = True
        Me.DirectoryNames_Directories_ListBox.ItemHeight = 25
        Me.DirectoryNames_Directories_ListBox.Location = New System.Drawing.Point(237, 31)
        Me.DirectoryNames_Directories_ListBox.Name = "DirectoryNames_Directories_ListBox"
        Me.DirectoryNames_Directories_ListBox.Size = New System.Drawing.Size(233, 354)
        Me.DirectoryNames_Directories_ListBox.TabIndex = 0
        '
        'AddDirectory_Directories_Button
        '
        Me.AddDirectory_Directories_Button.Location = New System.Drawing.Point(27, 31)
        Me.AddDirectory_Directories_Button.Name = "AddDirectory_Directories_Button"
        Me.AddDirectory_Directories_Button.Size = New System.Drawing.Size(178, 91)
        Me.AddDirectory_Directories_Button.TabIndex = 1
        Me.AddDirectory_Directories_Button.Text = "Add Directory"
        Me.AddDirectory_Directories_Button.UseVisualStyleBackColor = True
        '
        'DeleteDirectory_Directories_Button
        '
        Me.DeleteDirectory_Directories_Button.Location = New System.Drawing.Point(27, 294)
        Me.DeleteDirectory_Directories_Button.Name = "DeleteDirectory_Directories_Button"
        Me.DeleteDirectory_Directories_Button.Size = New System.Drawing.Size(178, 91)
        Me.DeleteDirectory_Directories_Button.TabIndex = 2
        Me.DeleteDirectory_Directories_Button.Text = "Delete Directory"
        Me.DeleteDirectory_Directories_Button.UseVisualStyleBackColor = True
        '
        'UpdateDirectoryInfo_Directories_Button
        '
        Me.UpdateDirectoryInfo_Directories_Button.Location = New System.Drawing.Point(696, 361)
        Me.UpdateDirectoryInfo_Directories_Button.Name = "UpdateDirectoryInfo_Directories_Button"
        Me.UpdateDirectoryInfo_Directories_Button.Size = New System.Drawing.Size(178, 91)
        Me.UpdateDirectoryInfo_Directories_Button.TabIndex = 3
        Me.UpdateDirectoryInfo_Directories_Button.Text = "Update Directory Info"
        Me.UpdateDirectoryInfo_Directories_Button.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(696, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(263, 31)
        Me.TextBox1.TabIndex = 4
        '
        'DirectoryName_Directories_Label
        '
        Me.DirectoryName_Directories_Label.AutoSize = True
        Me.DirectoryName_Directories_Label.Location = New System.Drawing.Point(504, 37)
        Me.DirectoryName_Directories_Label.Name = "DirectoryName_Directories_Label"
        Me.DirectoryName_Directories_Label.Size = New System.Drawing.Size(160, 25)
        Me.DirectoryName_Directories_Label.TabIndex = 5
        Me.DirectoryName_Directories_Label.Text = "Directory Name"
        '
        'DirectoryPath_Directories_Label
        '
        Me.DirectoryPath_Directories_Label.AutoSize = True
        Me.DirectoryPath_Directories_Label.Location = New System.Drawing.Point(516, 97)
        Me.DirectoryPath_Directories_Label.Name = "DirectoryPath_Directories_Label"
        Me.DirectoryPath_Directories_Label.Size = New System.Drawing.Size(148, 25)
        Me.DirectoryPath_Directories_Label.TabIndex = 6
        Me.DirectoryPath_Directories_Label.Text = "Directory Path"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(696, 97)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(263, 31)
        Me.TextBox2.TabIndex = 7
        '
        'NavToDirectory_Directories_Button
        '
        Me.NavToDirectory_Directories_Button.Location = New System.Drawing.Point(1002, 97)
        Me.NavToDirectory_Directories_Button.Name = "NavToDirectory_Directories_Button"
        Me.NavToDirectory_Directories_Button.Size = New System.Drawing.Size(153, 30)
        Me.NavToDirectory_Directories_Button.TabIndex = 8
        Me.NavToDirectory_Directories_Button.Text = "Navigate To"
        Me.NavToDirectory_Directories_Button.UseVisualStyleBackColor = True
        '
        'DirectoryInfo_Directories_Label
        '
        Me.DirectoryInfo_Directories_Label.AutoSize = True
        Me.DirectoryInfo_Directories_Label.Location = New System.Drawing.Point(525, 157)
        Me.DirectoryInfo_Directories_Label.Name = "DirectoryInfo_Directories_Label"
        Me.DirectoryInfo_Directories_Label.Size = New System.Drawing.Size(139, 25)
        Me.DirectoryInfo_Directories_Label.TabIndex = 9
        Me.DirectoryInfo_Directories_Label.Text = "Directory Info"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(696, 157)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(263, 162)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'DirectoryNames_Mods_ListBox
        '
        Me.DirectoryNames_Mods_ListBox.FormattingEnabled = True
        Me.DirectoryNames_Mods_ListBox.ItemHeight = 25
        Me.DirectoryNames_Mods_ListBox.Location = New System.Drawing.Point(24, 68)
        Me.DirectoryNames_Mods_ListBox.Name = "DirectoryNames_Mods_ListBox"
        Me.DirectoryNames_Mods_ListBox.Size = New System.Drawing.Size(233, 354)
        Me.DirectoryNames_Mods_ListBox.TabIndex = 1
        '
        'ModsInDirectory_Mods_ListBox
        '
        Me.ModsInDirectory_Mods_ListBox.FormattingEnabled = True
        Me.ModsInDirectory_Mods_ListBox.ItemHeight = 25
        Me.ModsInDirectory_Mods_ListBox.Location = New System.Drawing.Point(298, 68)
        Me.ModsInDirectory_Mods_ListBox.Name = "ModsInDirectory_Mods_ListBox"
        Me.ModsInDirectory_Mods_ListBox.Size = New System.Drawing.Size(233, 354)
        Me.ModsInDirectory_Mods_ListBox.TabIndex = 2
        '
        'Directories_Mods_Label
        '
        Me.Directories_Mods_Label.AutoSize = True
        Me.Directories_Mods_Label.Location = New System.Drawing.Point(19, 23)
        Me.Directories_Mods_Label.Name = "Directories_Mods_Label"
        Me.Directories_Mods_Label.Size = New System.Drawing.Size(121, 25)
        Me.Directories_Mods_Label.TabIndex = 3
        Me.Directories_Mods_Label.Text = "Directories:"
        '
        'ModsInDirectory_Mods_Label
        '
        Me.ModsInDirectory_Mods_Label.AutoSize = True
        Me.ModsInDirectory_Mods_Label.Location = New System.Drawing.Point(293, 23)
        Me.ModsInDirectory_Mods_Label.Name = "ModsInDirectory_Mods_Label"
        Me.ModsInDirectory_Mods_Label.Size = New System.Drawing.Size(186, 25)
        Me.ModsInDirectory_Mods_Label.TabIndex = 4
        Me.ModsInDirectory_Mods_Label.Text = "Mods in Directory:"
        '
        'AvalableMods_Mods_Label
        '
        Me.AvalableMods_Mods_Label.AutoSize = True
        Me.AvalableMods_Mods_Label.Location = New System.Drawing.Point(569, 23)
        Me.AvalableMods_Mods_Label.Name = "AvalableMods_Mods_Label"
        Me.AvalableMods_Mods_Label.Size = New System.Drawing.Size(160, 25)
        Me.AvalableMods_Mods_Label.TabIndex = 5
        Me.AvalableMods_Mods_Label.Text = "Avalable Mods:"
        '
        'AvalableMods_Mods_ListBox
        '
        Me.AvalableMods_Mods_ListBox.FormattingEnabled = True
        Me.AvalableMods_Mods_ListBox.ItemHeight = 25
        Me.AvalableMods_Mods_ListBox.Location = New System.Drawing.Point(574, 68)
        Me.AvalableMods_Mods_ListBox.Name = "AvalableMods_Mods_ListBox"
        Me.AvalableMods_Mods_ListBox.Size = New System.Drawing.Size(233, 354)
        Me.AvalableMods_Mods_ListBox.TabIndex = 6
        '
        'AddMod_Mods_Button
        '
        Me.AddMod_Mods_Button.Location = New System.Drawing.Point(574, 450)
        Me.AddMod_Mods_Button.Name = "AddMod_Mods_Button"
        Me.AddMod_Mods_Button.Size = New System.Drawing.Size(233, 70)
        Me.AddMod_Mods_Button.TabIndex = 7
        Me.AddMod_Mods_Button.Text = "Add Mod"
        Me.AddMod_Mods_Button.UseVisualStyleBackColor = True
        '
        'RemoveMod_Mods_Button
        '
        Me.RemoveMod_Mods_Button.Location = New System.Drawing.Point(298, 450)
        Me.RemoveMod_Mods_Button.Name = "RemoveMod_Mods_Button"
        Me.RemoveMod_Mods_Button.Size = New System.Drawing.Size(233, 70)
        Me.RemoveMod_Mods_Button.TabIndex = 8
        Me.RemoveMod_Mods_Button.Text = "Remove Mod"
        Me.RemoveMod_Mods_Button.UseVisualStyleBackColor = True
        '
        'AddModFile_Mods_Button
        '
        Me.AddModFile_Mods_Button.Location = New System.Drawing.Point(574, 549)
        Me.AddModFile_Mods_Button.Name = "AddModFile_Mods_Button"
        Me.AddModFile_Mods_Button.Size = New System.Drawing.Size(233, 70)
        Me.AddModFile_Mods_Button.TabIndex = 9
        Me.AddModFile_Mods_Button.Text = "Add Mod File"
        Me.AddModFile_Mods_Button.UseVisualStyleBackColor = True
        '
        'UpdateMods_Mods_Button
        '
        Me.UpdateMods_Mods_Button.Location = New System.Drawing.Point(854, 68)
        Me.UpdateMods_Mods_Button.Name = "UpdateMods_Mods_Button"
        Me.UpdateMods_Mods_Button.Size = New System.Drawing.Size(233, 70)
        Me.UpdateMods_Mods_Button.TabIndex = 10
        Me.UpdateMods_Mods_Button.Text = "Update Mods"
        Me.UpdateMods_Mods_Button.UseVisualStyleBackColor = True
        '
        'ResetChages_Mods_Button
        '
        Me.ResetChages_Mods_Button.Location = New System.Drawing.Point(854, 352)
        Me.ResetChages_Mods_Button.Name = "ResetChages_Mods_Button"
        Me.ResetChages_Mods_Button.Size = New System.Drawing.Size(233, 70)
        Me.ResetChages_Mods_Button.TabIndex = 11
        Me.ResetChages_Mods_Button.Text = "Reset Chages"
        Me.ResetChages_Mods_Button.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1298, 804)
        Me.Controls.Add(Me.MainMenu_TabControl)
        Me.Name = "Menu"
        Me.Text = "Main Menu"
        Me.MainMenu_TabControl.ResumeLayout(False)
        Me.Directories_TabPage.ResumeLayout(False)
        Me.Directories_TabPage.PerformLayout()
        Me.Mods_TabPage.ResumeLayout(False)
        Me.Mods_TabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainMenu_TabControl As TabControl
    Friend WithEvents Directories_TabPage As TabPage
    Friend WithEvents UpdateDirectoryInfo_Directories_Button As Button
    Friend WithEvents DeleteDirectory_Directories_Button As Button
    Friend WithEvents AddDirectory_Directories_Button As Button
    Friend WithEvents DirectoryNames_Directories_ListBox As ListBox
    Friend WithEvents Mods_TabPage As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents DirectoryInfo_Directories_Label As Label
    Friend WithEvents NavToDirectory_Directories_Button As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DirectoryPath_Directories_Label As Label
    Friend WithEvents DirectoryName_Directories_Label As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DirectoryNames_Mods_ListBox As ListBox
    Friend WithEvents Directories_Mods_Label As Label
    Friend WithEvents ModsInDirectory_Mods_ListBox As ListBox
    Friend WithEvents AddModFile_Mods_Button As Button
    Friend WithEvents RemoveMod_Mods_Button As Button
    Friend WithEvents AddMod_Mods_Button As Button
    Friend WithEvents AvalableMods_Mods_ListBox As ListBox
    Friend WithEvents AvalableMods_Mods_Label As Label
    Friend WithEvents ModsInDirectory_Mods_Label As Label
    Friend WithEvents ResetChages_Mods_Button As Button
    Friend WithEvents UpdateMods_Mods_Button As Button
End Class
