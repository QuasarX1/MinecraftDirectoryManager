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
        Me.DirectoryInfo_Directories_RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DirectoryInfo_Directories_Label = New System.Windows.Forms.Label()
        Me.NavToDirectory_Directories_Button = New System.Windows.Forms.Button()
        Me.DirectoryPath_Directories_TextBox = New System.Windows.Forms.TextBox()
        Me.DirectoryPath_Directories_Label = New System.Windows.Forms.Label()
        Me.DirectoryName_Directories_Label = New System.Windows.Forms.Label()
        Me.DirectoryName_Directories_TextBox = New System.Windows.Forms.TextBox()
        Me.UpdateDirectoryInfo_Directories_Button = New System.Windows.Forms.Button()
        Me.DeleteDirectory_Directories_Button = New System.Windows.Forms.Button()
        Me.AddDirectory_Directories_Button = New System.Windows.Forms.Button()
        Me.DirectoryNames_Directories_ListBox = New System.Windows.Forms.ListBox()
        Me.Mods_TabPage = New System.Windows.Forms.TabPage()
        Me.ResetChages_Mods_Button = New System.Windows.Forms.Button()
        Me.UpdateMods_Mods_Button = New System.Windows.Forms.Button()
        Me.AddModFile_Mods_Button = New System.Windows.Forms.Button()
        Me.RemoveMod_Mods_Button = New System.Windows.Forms.Button()
        Me.AddMod_Mods_Button = New System.Windows.Forms.Button()
        Me.AvalableMods_Mods_ListBox = New System.Windows.Forms.ListBox()
        Me.AvalableMods_Mods_Label = New System.Windows.Forms.Label()
        Me.ModsInDirectory_Mods_Label = New System.Windows.Forms.Label()
        Me.Directories_Mods_Label = New System.Windows.Forms.Label()
        Me.ModsInDirectory_Mods_ListBox = New System.Windows.Forms.ListBox()
        Me.DirectoryNames_Mods_ListBox = New System.Windows.Forms.ListBox()
        Me.Versions_TabPage = New System.Windows.Forms.TabPage()
        Me.RemoveVersion_Versions_Button = New System.Windows.Forms.Button()
        Me.VersionsInDirectory_Versions_Label = New System.Windows.Forms.Label()
        Me.Directories_Versions_Label = New System.Windows.Forms.Label()
        Me.VersionsInDirectory_Versions_ListBox = New System.Windows.Forms.ListBox()
        Me.DirectoryNames_Versions_ListBox = New System.Windows.Forms.ListBox()
        Me.ResetChanges_Versions_Button = New System.Windows.Forms.Button()
        Me.UpdateDirectories_Versions_Button = New System.Windows.Forms.Button()
        Me.ResoursePacks_TabPage = New System.Windows.Forms.TabPage()
        Me.Saves_TabPage = New System.Windows.Forms.TabPage()
        Me.ResetChanges_ResoursePacks_Button = New System.Windows.Forms.Button()
        Me.UpdateResoursePacks_ResoursePacks_Button = New System.Windows.Forms.Button()
        Me.AddResoursePackFile_ResoursePacks_Button = New System.Windows.Forms.Button()
        Me.RemoveResoursePack_ResoursePacks_Button = New System.Windows.Forms.Button()
        Me.AddResoursePack_ResoursePacks_Button = New System.Windows.Forms.Button()
        Me.AvalableResoursePacks_ResoursePacks_ListBox = New System.Windows.Forms.ListBox()
        Me.AvalableResoursePacks_ResoursePacks_Label = New System.Windows.Forms.Label()
        Me.ResoursePacksInDirectory_ResoursePacks_Label = New System.Windows.Forms.Label()
        Me.Directories_ResoursePacks_Label = New System.Windows.Forms.Label()
        Me.ResoursePacksInDirectory_ResoursePacks_ListBox = New System.Windows.Forms.ListBox()
        Me.DirectoryNames_ResoursePacks_ListBox = New System.Windows.Forms.ListBox()
        Me.ResetChanges_Saves_Button = New System.Windows.Forms.Button()
        Me.UpdateSaves_Saves_Button = New System.Windows.Forms.Button()
        Me.AddSaveFile_Saves_Button = New System.Windows.Forms.Button()
        Me.RemoveSave_Saves_Button = New System.Windows.Forms.Button()
        Me.AddSave_Saves_Button = New System.Windows.Forms.Button()
        Me.AvalableSaves_Saves_ListBox = New System.Windows.Forms.ListBox()
        Me.AvalableSaves_Saves_Label = New System.Windows.Forms.Label()
        Me.SavesInDirectory_Saves_Label = New System.Windows.Forms.Label()
        Me.Directories_Saves_Label = New System.Windows.Forms.Label()
        Me.SavesInDirectory_Saves_ListBox = New System.Windows.Forms.ListBox()
        Me.DirectoryNames_Saves_ListBox = New System.Windows.Forms.ListBox()
        Me.DeleteModFile_Mods_Button = New System.Windows.Forms.Button()
        Me.DeleteResoursePackFile_ResourcePacks_Button = New System.Windows.Forms.Button()
        Me.DeleteSaveFile_Saves_Button = New System.Windows.Forms.Button()
        Me.MainMenu_TabControl.SuspendLayout()
        Me.Directories_TabPage.SuspendLayout()
        Me.Mods_TabPage.SuspendLayout()
        Me.Versions_TabPage.SuspendLayout()
        Me.ResoursePacks_TabPage.SuspendLayout()
        Me.Saves_TabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu_TabControl
        '
        Me.MainMenu_TabControl.Controls.Add(Me.Directories_TabPage)
        Me.MainMenu_TabControl.Controls.Add(Me.Mods_TabPage)
        Me.MainMenu_TabControl.Controls.Add(Me.Versions_TabPage)
        Me.MainMenu_TabControl.Controls.Add(Me.ResoursePacks_TabPage)
        Me.MainMenu_TabControl.Controls.Add(Me.Saves_TabPage)
        Me.MainMenu_TabControl.Location = New System.Drawing.Point(12, 12)
        Me.MainMenu_TabControl.Name = "MainMenu_TabControl"
        Me.MainMenu_TabControl.SelectedIndex = 0
        Me.MainMenu_TabControl.Size = New System.Drawing.Size(1274, 780)
        Me.MainMenu_TabControl.TabIndex = 0
        '
        'Directories_TabPage
        '
        Me.Directories_TabPage.Controls.Add(Me.DirectoryInfo_Directories_RichTextBox)
        Me.Directories_TabPage.Controls.Add(Me.DirectoryInfo_Directories_Label)
        Me.Directories_TabPage.Controls.Add(Me.NavToDirectory_Directories_Button)
        Me.Directories_TabPage.Controls.Add(Me.DirectoryPath_Directories_TextBox)
        Me.Directories_TabPage.Controls.Add(Me.DirectoryPath_Directories_Label)
        Me.Directories_TabPage.Controls.Add(Me.DirectoryName_Directories_Label)
        Me.Directories_TabPage.Controls.Add(Me.DirectoryName_Directories_TextBox)
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
        'DirectoryInfo_Directories_RichTextBox
        '
        Me.DirectoryInfo_Directories_RichTextBox.Location = New System.Drawing.Point(696, 157)
        Me.DirectoryInfo_Directories_RichTextBox.Name = "DirectoryInfo_Directories_RichTextBox"
        Me.DirectoryInfo_Directories_RichTextBox.Size = New System.Drawing.Size(263, 162)
        Me.DirectoryInfo_Directories_RichTextBox.TabIndex = 10
        Me.DirectoryInfo_Directories_RichTextBox.Text = ""
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
        'NavToDirectory_Directories_Button
        '
        Me.NavToDirectory_Directories_Button.Location = New System.Drawing.Point(1002, 97)
        Me.NavToDirectory_Directories_Button.Name = "NavToDirectory_Directories_Button"
        Me.NavToDirectory_Directories_Button.Size = New System.Drawing.Size(153, 30)
        Me.NavToDirectory_Directories_Button.TabIndex = 8
        Me.NavToDirectory_Directories_Button.Text = "Navigate To"
        Me.NavToDirectory_Directories_Button.UseVisualStyleBackColor = True
        '
        'DirectoryPath_Directories_TextBox
        '
        Me.DirectoryPath_Directories_TextBox.Location = New System.Drawing.Point(696, 97)
        Me.DirectoryPath_Directories_TextBox.Name = "DirectoryPath_Directories_TextBox"
        Me.DirectoryPath_Directories_TextBox.Size = New System.Drawing.Size(263, 31)
        Me.DirectoryPath_Directories_TextBox.TabIndex = 7
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
        'DirectoryName_Directories_Label
        '
        Me.DirectoryName_Directories_Label.AutoSize = True
        Me.DirectoryName_Directories_Label.Location = New System.Drawing.Point(504, 37)
        Me.DirectoryName_Directories_Label.Name = "DirectoryName_Directories_Label"
        Me.DirectoryName_Directories_Label.Size = New System.Drawing.Size(160, 25)
        Me.DirectoryName_Directories_Label.TabIndex = 5
        Me.DirectoryName_Directories_Label.Text = "Directory Name"
        '
        'DirectoryName_Directories_TextBox
        '
        Me.DirectoryName_Directories_TextBox.Location = New System.Drawing.Point(696, 31)
        Me.DirectoryName_Directories_TextBox.Name = "DirectoryName_Directories_TextBox"
        Me.DirectoryName_Directories_TextBox.Size = New System.Drawing.Size(263, 31)
        Me.DirectoryName_Directories_TextBox.TabIndex = 4
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
        'DeleteDirectory_Directories_Button
        '
        Me.DeleteDirectory_Directories_Button.Location = New System.Drawing.Point(27, 294)
        Me.DeleteDirectory_Directories_Button.Name = "DeleteDirectory_Directories_Button"
        Me.DeleteDirectory_Directories_Button.Size = New System.Drawing.Size(178, 91)
        Me.DeleteDirectory_Directories_Button.TabIndex = 2
        Me.DeleteDirectory_Directories_Button.Text = "Delete Directory"
        Me.DeleteDirectory_Directories_Button.UseVisualStyleBackColor = True
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
        'DirectoryNames_Directories_ListBox
        '
        Me.DirectoryNames_Directories_ListBox.FormattingEnabled = True
        Me.DirectoryNames_Directories_ListBox.ItemHeight = 25
        Me.DirectoryNames_Directories_ListBox.Location = New System.Drawing.Point(237, 31)
        Me.DirectoryNames_Directories_ListBox.Name = "DirectoryNames_Directories_ListBox"
        Me.DirectoryNames_Directories_ListBox.Size = New System.Drawing.Size(233, 354)
        Me.DirectoryNames_Directories_ListBox.TabIndex = 0
        '
        'Mods_TabPage
        '
        Me.Mods_TabPage.Controls.Add(Me.DeleteModFile_Mods_Button)
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
        'ResetChages_Mods_Button
        '
        Me.ResetChages_Mods_Button.Location = New System.Drawing.Point(854, 352)
        Me.ResetChages_Mods_Button.Name = "ResetChages_Mods_Button"
        Me.ResetChages_Mods_Button.Size = New System.Drawing.Size(233, 70)
        Me.ResetChages_Mods_Button.TabIndex = 11
        Me.ResetChages_Mods_Button.Text = "Reset Chages"
        Me.ResetChages_Mods_Button.UseVisualStyleBackColor = True
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
        'AddModFile_Mods_Button
        '
        Me.AddModFile_Mods_Button.Location = New System.Drawing.Point(574, 549)
        Me.AddModFile_Mods_Button.Name = "AddModFile_Mods_Button"
        Me.AddModFile_Mods_Button.Size = New System.Drawing.Size(233, 70)
        Me.AddModFile_Mods_Button.TabIndex = 9
        Me.AddModFile_Mods_Button.Text = "Add Mod File"
        Me.AddModFile_Mods_Button.UseVisualStyleBackColor = True
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
        'AddMod_Mods_Button
        '
        Me.AddMod_Mods_Button.Location = New System.Drawing.Point(574, 450)
        Me.AddMod_Mods_Button.Name = "AddMod_Mods_Button"
        Me.AddMod_Mods_Button.Size = New System.Drawing.Size(233, 70)
        Me.AddMod_Mods_Button.TabIndex = 7
        Me.AddMod_Mods_Button.Text = "Add Mod"
        Me.AddMod_Mods_Button.UseVisualStyleBackColor = True
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
        'AvalableMods_Mods_Label
        '
        Me.AvalableMods_Mods_Label.AutoSize = True
        Me.AvalableMods_Mods_Label.Location = New System.Drawing.Point(569, 23)
        Me.AvalableMods_Mods_Label.Name = "AvalableMods_Mods_Label"
        Me.AvalableMods_Mods_Label.Size = New System.Drawing.Size(160, 25)
        Me.AvalableMods_Mods_Label.TabIndex = 5
        Me.AvalableMods_Mods_Label.Text = "Avalable Mods:"
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
        'Directories_Mods_Label
        '
        Me.Directories_Mods_Label.AutoSize = True
        Me.Directories_Mods_Label.Location = New System.Drawing.Point(19, 23)
        Me.Directories_Mods_Label.Name = "Directories_Mods_Label"
        Me.Directories_Mods_Label.Size = New System.Drawing.Size(121, 25)
        Me.Directories_Mods_Label.TabIndex = 3
        Me.Directories_Mods_Label.Text = "Directories:"
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
        'DirectoryNames_Mods_ListBox
        '
        Me.DirectoryNames_Mods_ListBox.FormattingEnabled = True
        Me.DirectoryNames_Mods_ListBox.ItemHeight = 25
        Me.DirectoryNames_Mods_ListBox.Location = New System.Drawing.Point(24, 68)
        Me.DirectoryNames_Mods_ListBox.Name = "DirectoryNames_Mods_ListBox"
        Me.DirectoryNames_Mods_ListBox.Size = New System.Drawing.Size(233, 354)
        Me.DirectoryNames_Mods_ListBox.TabIndex = 1
        '
        'Versions_TabPage
        '
        Me.Versions_TabPage.Controls.Add(Me.ResetChanges_Versions_Button)
        Me.Versions_TabPage.Controls.Add(Me.UpdateDirectories_Versions_Button)
        Me.Versions_TabPage.Controls.Add(Me.RemoveVersion_Versions_Button)
        Me.Versions_TabPage.Controls.Add(Me.VersionsInDirectory_Versions_Label)
        Me.Versions_TabPage.Controls.Add(Me.Directories_Versions_Label)
        Me.Versions_TabPage.Controls.Add(Me.VersionsInDirectory_Versions_ListBox)
        Me.Versions_TabPage.Controls.Add(Me.DirectoryNames_Versions_ListBox)
        Me.Versions_TabPage.Location = New System.Drawing.Point(8, 39)
        Me.Versions_TabPage.Name = "Versions_TabPage"
        Me.Versions_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.Versions_TabPage.Size = New System.Drawing.Size(1258, 733)
        Me.Versions_TabPage.TabIndex = 2
        Me.Versions_TabPage.Text = "Versions"
        Me.Versions_TabPage.UseVisualStyleBackColor = True
        '
        'RemoveVersion_Versions_Button
        '
        Me.RemoveVersion_Versions_Button.Location = New System.Drawing.Point(305, 451)
        Me.RemoveVersion_Versions_Button.Name = "RemoveVersion_Versions_Button"
        Me.RemoveVersion_Versions_Button.Size = New System.Drawing.Size(233, 70)
        Me.RemoveVersion_Versions_Button.TabIndex = 13
        Me.RemoveVersion_Versions_Button.Text = "Remove Version"
        Me.RemoveVersion_Versions_Button.UseVisualStyleBackColor = True
        '
        'VersionsInDirectory_Versions_Label
        '
        Me.VersionsInDirectory_Versions_Label.AutoSize = True
        Me.VersionsInDirectory_Versions_Label.Location = New System.Drawing.Point(300, 24)
        Me.VersionsInDirectory_Versions_Label.Name = "VersionsInDirectory_Versions_Label"
        Me.VersionsInDirectory_Versions_Label.Size = New System.Drawing.Size(217, 25)
        Me.VersionsInDirectory_Versions_Label.TabIndex = 12
        Me.VersionsInDirectory_Versions_Label.Text = "Versions In Directory:"
        '
        'Directories_Versions_Label
        '
        Me.Directories_Versions_Label.AutoSize = True
        Me.Directories_Versions_Label.Location = New System.Drawing.Point(26, 24)
        Me.Directories_Versions_Label.Name = "Directories_Versions_Label"
        Me.Directories_Versions_Label.Size = New System.Drawing.Size(121, 25)
        Me.Directories_Versions_Label.TabIndex = 11
        Me.Directories_Versions_Label.Text = "Directories:"
        '
        'VersionsInDirectory_Versions_ListBox
        '
        Me.VersionsInDirectory_Versions_ListBox.FormattingEnabled = True
        Me.VersionsInDirectory_Versions_ListBox.ItemHeight = 25
        Me.VersionsInDirectory_Versions_ListBox.Location = New System.Drawing.Point(305, 69)
        Me.VersionsInDirectory_Versions_ListBox.Name = "VersionsInDirectory_Versions_ListBox"
        Me.VersionsInDirectory_Versions_ListBox.Size = New System.Drawing.Size(233, 354)
        Me.VersionsInDirectory_Versions_ListBox.TabIndex = 10
        '
        'DirectoryNames_Versions_ListBox
        '
        Me.DirectoryNames_Versions_ListBox.FormattingEnabled = True
        Me.DirectoryNames_Versions_ListBox.ItemHeight = 25
        Me.DirectoryNames_Versions_ListBox.Location = New System.Drawing.Point(31, 69)
        Me.DirectoryNames_Versions_ListBox.Name = "DirectoryNames_Versions_ListBox"
        Me.DirectoryNames_Versions_ListBox.Size = New System.Drawing.Size(233, 354)
        Me.DirectoryNames_Versions_ListBox.TabIndex = 9
        '
        'ResetChanges_Versions_Button
        '
        Me.ResetChanges_Versions_Button.Location = New System.Drawing.Point(581, 353)
        Me.ResetChanges_Versions_Button.Name = "ResetChanges_Versions_Button"
        Me.ResetChanges_Versions_Button.Size = New System.Drawing.Size(233, 70)
        Me.ResetChanges_Versions_Button.TabIndex = 15
        Me.ResetChanges_Versions_Button.Text = "Reset Chages"
        Me.ResetChanges_Versions_Button.UseVisualStyleBackColor = True
        '
        'UpdateDirectories_Versions_Button
        '
        Me.UpdateDirectories_Versions_Button.Location = New System.Drawing.Point(581, 69)
        Me.UpdateDirectories_Versions_Button.Name = "UpdateDirectories_Versions_Button"
        Me.UpdateDirectories_Versions_Button.Size = New System.Drawing.Size(233, 70)
        Me.UpdateDirectories_Versions_Button.TabIndex = 14
        Me.UpdateDirectories_Versions_Button.Text = "Update Versions"
        Me.UpdateDirectories_Versions_Button.UseVisualStyleBackColor = True
        '
        'ResoursePacks_TabPage
        '
        Me.ResoursePacks_TabPage.Controls.Add(Me.DeleteResoursePackFile_ResourcePacks_Button)
        Me.ResoursePacks_TabPage.Controls.Add(Me.ResetChanges_ResoursePacks_Button)
        Me.ResoursePacks_TabPage.Controls.Add(Me.UpdateResoursePacks_ResoursePacks_Button)
        Me.ResoursePacks_TabPage.Controls.Add(Me.AddResoursePackFile_ResoursePacks_Button)
        Me.ResoursePacks_TabPage.Controls.Add(Me.RemoveResoursePack_ResoursePacks_Button)
        Me.ResoursePacks_TabPage.Controls.Add(Me.AddResoursePack_ResoursePacks_Button)
        Me.ResoursePacks_TabPage.Controls.Add(Me.AvalableResoursePacks_ResoursePacks_ListBox)
        Me.ResoursePacks_TabPage.Controls.Add(Me.AvalableResoursePacks_ResoursePacks_Label)
        Me.ResoursePacks_TabPage.Controls.Add(Me.ResoursePacksInDirectory_ResoursePacks_Label)
        Me.ResoursePacks_TabPage.Controls.Add(Me.Directories_ResoursePacks_Label)
        Me.ResoursePacks_TabPage.Controls.Add(Me.ResoursePacksInDirectory_ResoursePacks_ListBox)
        Me.ResoursePacks_TabPage.Controls.Add(Me.DirectoryNames_ResoursePacks_ListBox)
        Me.ResoursePacks_TabPage.Location = New System.Drawing.Point(8, 39)
        Me.ResoursePacks_TabPage.Name = "ResoursePacks_TabPage"
        Me.ResoursePacks_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ResoursePacks_TabPage.Size = New System.Drawing.Size(1258, 733)
        Me.ResoursePacks_TabPage.TabIndex = 3
        Me.ResoursePacks_TabPage.Text = "Resourse Packs"
        Me.ResoursePacks_TabPage.UseVisualStyleBackColor = True
        '
        'Saves_TabPage
        '
        Me.Saves_TabPage.Controls.Add(Me.DeleteSaveFile_Saves_Button)
        Me.Saves_TabPage.Controls.Add(Me.ResetChanges_Saves_Button)
        Me.Saves_TabPage.Controls.Add(Me.UpdateSaves_Saves_Button)
        Me.Saves_TabPage.Controls.Add(Me.AddSaveFile_Saves_Button)
        Me.Saves_TabPage.Controls.Add(Me.RemoveSave_Saves_Button)
        Me.Saves_TabPage.Controls.Add(Me.AddSave_Saves_Button)
        Me.Saves_TabPage.Controls.Add(Me.AvalableSaves_Saves_ListBox)
        Me.Saves_TabPage.Controls.Add(Me.AvalableSaves_Saves_Label)
        Me.Saves_TabPage.Controls.Add(Me.SavesInDirectory_Saves_Label)
        Me.Saves_TabPage.Controls.Add(Me.Directories_Saves_Label)
        Me.Saves_TabPage.Controls.Add(Me.SavesInDirectory_Saves_ListBox)
        Me.Saves_TabPage.Controls.Add(Me.DirectoryNames_Saves_ListBox)
        Me.Saves_TabPage.Location = New System.Drawing.Point(8, 39)
        Me.Saves_TabPage.Name = "Saves_TabPage"
        Me.Saves_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.Saves_TabPage.Size = New System.Drawing.Size(1258, 733)
        Me.Saves_TabPage.TabIndex = 4
        Me.Saves_TabPage.Text = "Saves"
        Me.Saves_TabPage.UseVisualStyleBackColor = True
        '
        'ResetChanges_ResoursePacks_Button
        '
        Me.ResetChanges_ResoursePacks_Button.Location = New System.Drawing.Point(865, 360)
        Me.ResetChanges_ResoursePacks_Button.Name = "ResetChanges_ResoursePacks_Button"
        Me.ResetChanges_ResoursePacks_Button.Size = New System.Drawing.Size(233, 70)
        Me.ResetChanges_ResoursePacks_Button.TabIndex = 22
        Me.ResetChanges_ResoursePacks_Button.Text = "Reset Chages"
        Me.ResetChanges_ResoursePacks_Button.UseVisualStyleBackColor = True
        '
        'UpdateResoursePacks_ResoursePacks_Button
        '
        Me.UpdateResoursePacks_ResoursePacks_Button.Location = New System.Drawing.Point(865, 76)
        Me.UpdateResoursePacks_ResoursePacks_Button.Name = "UpdateResoursePacks_ResoursePacks_Button"
        Me.UpdateResoursePacks_ResoursePacks_Button.Size = New System.Drawing.Size(233, 70)
        Me.UpdateResoursePacks_ResoursePacks_Button.TabIndex = 21
        Me.UpdateResoursePacks_ResoursePacks_Button.Text = "Update Resourse Packs"
        Me.UpdateResoursePacks_ResoursePacks_Button.UseVisualStyleBackColor = True
        '
        'AddResoursePackFile_ResoursePacks_Button
        '
        Me.AddResoursePackFile_ResoursePacks_Button.Location = New System.Drawing.Point(585, 557)
        Me.AddResoursePackFile_ResoursePacks_Button.Name = "AddResoursePackFile_ResoursePacks_Button"
        Me.AddResoursePackFile_ResoursePacks_Button.Size = New System.Drawing.Size(233, 70)
        Me.AddResoursePackFile_ResoursePacks_Button.TabIndex = 20
        Me.AddResoursePackFile_ResoursePacks_Button.Text = "Add Resourse Pack File"
        Me.AddResoursePackFile_ResoursePacks_Button.UseVisualStyleBackColor = True
        '
        'RemoveResoursePack_ResoursePacks_Button
        '
        Me.RemoveResoursePack_ResoursePacks_Button.Location = New System.Drawing.Point(309, 458)
        Me.RemoveResoursePack_ResoursePacks_Button.Name = "RemoveResoursePack_ResoursePacks_Button"
        Me.RemoveResoursePack_ResoursePacks_Button.Size = New System.Drawing.Size(233, 70)
        Me.RemoveResoursePack_ResoursePacks_Button.TabIndex = 19
        Me.RemoveResoursePack_ResoursePacks_Button.Text = "Remove Resourse Pack"
        Me.RemoveResoursePack_ResoursePacks_Button.UseVisualStyleBackColor = True
        '
        'AddResoursePack_ResoursePacks_Button
        '
        Me.AddResoursePack_ResoursePacks_Button.Location = New System.Drawing.Point(585, 458)
        Me.AddResoursePack_ResoursePacks_Button.Name = "AddResoursePack_ResoursePacks_Button"
        Me.AddResoursePack_ResoursePacks_Button.Size = New System.Drawing.Size(233, 70)
        Me.AddResoursePack_ResoursePacks_Button.TabIndex = 18
        Me.AddResoursePack_ResoursePacks_Button.Text = "Add Resourse Pack"
        Me.AddResoursePack_ResoursePacks_Button.UseVisualStyleBackColor = True
        '
        'AvalableResoursePacks_ResoursePacks_ListBox
        '
        Me.AvalableResoursePacks_ResoursePacks_ListBox.FormattingEnabled = True
        Me.AvalableResoursePacks_ResoursePacks_ListBox.ItemHeight = 25
        Me.AvalableResoursePacks_ResoursePacks_ListBox.Location = New System.Drawing.Point(585, 76)
        Me.AvalableResoursePacks_ResoursePacks_ListBox.Name = "AvalableResoursePacks_ResoursePacks_ListBox"
        Me.AvalableResoursePacks_ResoursePacks_ListBox.Size = New System.Drawing.Size(233, 354)
        Me.AvalableResoursePacks_ResoursePacks_ListBox.TabIndex = 17
        '
        'AvalableResoursePacks_ResoursePacks_Label
        '
        Me.AvalableResoursePacks_ResoursePacks_Label.AutoSize = True
        Me.AvalableResoursePacks_ResoursePacks_Label.Location = New System.Drawing.Point(584, 31)
        Me.AvalableResoursePacks_ResoursePacks_Label.Name = "AvalableResoursePacks_ResoursePacks_Label"
        Me.AvalableResoursePacks_ResoursePacks_Label.Size = New System.Drawing.Size(264, 25)
        Me.AvalableResoursePacks_ResoursePacks_Label.TabIndex = 16
        Me.AvalableResoursePacks_ResoursePacks_Label.Text = "Avalable Resourse Packs:"
        '
        'ResoursePacksInDirectory_ResoursePacks_Label
        '
        Me.ResoursePacksInDirectory_ResoursePacks_Label.AutoSize = True
        Me.ResoursePacksInDirectory_ResoursePacks_Label.Location = New System.Drawing.Point(304, 31)
        Me.ResoursePacksInDirectory_ResoursePacks_Label.Name = "ResoursePacksInDirectory_ResoursePacks_Label"
        Me.ResoursePacksInDirectory_ResoursePacks_Label.Size = New System.Drawing.Size(290, 25)
        Me.ResoursePacksInDirectory_ResoursePacks_Label.TabIndex = 15
        Me.ResoursePacksInDirectory_ResoursePacks_Label.Text = "Resourse Packs in Directory:"
        '
        'Directories_ResoursePacks_Label
        '
        Me.Directories_ResoursePacks_Label.AutoSize = True
        Me.Directories_ResoursePacks_Label.Location = New System.Drawing.Point(30, 31)
        Me.Directories_ResoursePacks_Label.Name = "Directories_ResoursePacks_Label"
        Me.Directories_ResoursePacks_Label.Size = New System.Drawing.Size(121, 25)
        Me.Directories_ResoursePacks_Label.TabIndex = 14
        Me.Directories_ResoursePacks_Label.Text = "Directories:"
        '
        'ResoursePacksInDirectory_ResoursePacks_ListBox
        '
        Me.ResoursePacksInDirectory_ResoursePacks_ListBox.FormattingEnabled = True
        Me.ResoursePacksInDirectory_ResoursePacks_ListBox.ItemHeight = 25
        Me.ResoursePacksInDirectory_ResoursePacks_ListBox.Location = New System.Drawing.Point(309, 76)
        Me.ResoursePacksInDirectory_ResoursePacks_ListBox.Name = "ResoursePacksInDirectory_ResoursePacks_ListBox"
        Me.ResoursePacksInDirectory_ResoursePacks_ListBox.Size = New System.Drawing.Size(233, 354)
        Me.ResoursePacksInDirectory_ResoursePacks_ListBox.TabIndex = 13
        '
        'DirectoryNames_ResoursePacks_ListBox
        '
        Me.DirectoryNames_ResoursePacks_ListBox.FormattingEnabled = True
        Me.DirectoryNames_ResoursePacks_ListBox.ItemHeight = 25
        Me.DirectoryNames_ResoursePacks_ListBox.Location = New System.Drawing.Point(35, 76)
        Me.DirectoryNames_ResoursePacks_ListBox.Name = "DirectoryNames_ResoursePacks_ListBox"
        Me.DirectoryNames_ResoursePacks_ListBox.Size = New System.Drawing.Size(233, 354)
        Me.DirectoryNames_ResoursePacks_ListBox.TabIndex = 12
        '
        'ResetChanges_Saves_Button
        '
        Me.ResetChanges_Saves_Button.Location = New System.Drawing.Point(857, 352)
        Me.ResetChanges_Saves_Button.Name = "ResetChanges_Saves_Button"
        Me.ResetChanges_Saves_Button.Size = New System.Drawing.Size(233, 70)
        Me.ResetChanges_Saves_Button.TabIndex = 22
        Me.ResetChanges_Saves_Button.Text = "Reset Chages"
        Me.ResetChanges_Saves_Button.UseVisualStyleBackColor = True
        '
        'UpdateSaves_Saves_Button
        '
        Me.UpdateSaves_Saves_Button.Location = New System.Drawing.Point(857, 68)
        Me.UpdateSaves_Saves_Button.Name = "UpdateSaves_Saves_Button"
        Me.UpdateSaves_Saves_Button.Size = New System.Drawing.Size(233, 70)
        Me.UpdateSaves_Saves_Button.TabIndex = 21
        Me.UpdateSaves_Saves_Button.Text = "Update Saves"
        Me.UpdateSaves_Saves_Button.UseVisualStyleBackColor = True
        '
        'AddSaveFile_Saves_Button
        '
        Me.AddSaveFile_Saves_Button.Location = New System.Drawing.Point(577, 549)
        Me.AddSaveFile_Saves_Button.Name = "AddSaveFile_Saves_Button"
        Me.AddSaveFile_Saves_Button.Size = New System.Drawing.Size(233, 70)
        Me.AddSaveFile_Saves_Button.TabIndex = 20
        Me.AddSaveFile_Saves_Button.Text = "Add Save File"
        Me.AddSaveFile_Saves_Button.UseVisualStyleBackColor = True
        '
        'RemoveSave_Saves_Button
        '
        Me.RemoveSave_Saves_Button.Location = New System.Drawing.Point(301, 450)
        Me.RemoveSave_Saves_Button.Name = "RemoveSave_Saves_Button"
        Me.RemoveSave_Saves_Button.Size = New System.Drawing.Size(233, 70)
        Me.RemoveSave_Saves_Button.TabIndex = 19
        Me.RemoveSave_Saves_Button.Text = "Remove Save"
        Me.RemoveSave_Saves_Button.UseVisualStyleBackColor = True
        '
        'AddSave_Saves_Button
        '
        Me.AddSave_Saves_Button.Location = New System.Drawing.Point(577, 450)
        Me.AddSave_Saves_Button.Name = "AddSave_Saves_Button"
        Me.AddSave_Saves_Button.Size = New System.Drawing.Size(233, 70)
        Me.AddSave_Saves_Button.TabIndex = 18
        Me.AddSave_Saves_Button.Text = "Add Save"
        Me.AddSave_Saves_Button.UseVisualStyleBackColor = True
        '
        'AvalableSaves_Saves_ListBox
        '
        Me.AvalableSaves_Saves_ListBox.FormattingEnabled = True
        Me.AvalableSaves_Saves_ListBox.ItemHeight = 25
        Me.AvalableSaves_Saves_ListBox.Location = New System.Drawing.Point(577, 68)
        Me.AvalableSaves_Saves_ListBox.Name = "AvalableSaves_Saves_ListBox"
        Me.AvalableSaves_Saves_ListBox.Size = New System.Drawing.Size(233, 354)
        Me.AvalableSaves_Saves_ListBox.TabIndex = 17
        '
        'AvalableSaves_Saves_Label
        '
        Me.AvalableSaves_Saves_Label.AutoSize = True
        Me.AvalableSaves_Saves_Label.Location = New System.Drawing.Point(572, 23)
        Me.AvalableSaves_Saves_Label.Name = "AvalableSaves_Saves_Label"
        Me.AvalableSaves_Saves_Label.Size = New System.Drawing.Size(167, 25)
        Me.AvalableSaves_Saves_Label.TabIndex = 16
        Me.AvalableSaves_Saves_Label.Text = "Avalable Saves:"
        '
        'SavesInDirectory_Saves_Label
        '
        Me.SavesInDirectory_Saves_Label.AutoSize = True
        Me.SavesInDirectory_Saves_Label.Location = New System.Drawing.Point(296, 23)
        Me.SavesInDirectory_Saves_Label.Name = "SavesInDirectory_Saves_Label"
        Me.SavesInDirectory_Saves_Label.Size = New System.Drawing.Size(193, 25)
        Me.SavesInDirectory_Saves_Label.TabIndex = 15
        Me.SavesInDirectory_Saves_Label.Text = "Saves in Directory:"
        '
        'Directories_Saves_Label
        '
        Me.Directories_Saves_Label.AutoSize = True
        Me.Directories_Saves_Label.Location = New System.Drawing.Point(22, 23)
        Me.Directories_Saves_Label.Name = "Directories_Saves_Label"
        Me.Directories_Saves_Label.Size = New System.Drawing.Size(121, 25)
        Me.Directories_Saves_Label.TabIndex = 14
        Me.Directories_Saves_Label.Text = "Directories:"
        '
        'SavesInDirectory_Saves_ListBox
        '
        Me.SavesInDirectory_Saves_ListBox.FormattingEnabled = True
        Me.SavesInDirectory_Saves_ListBox.ItemHeight = 25
        Me.SavesInDirectory_Saves_ListBox.Location = New System.Drawing.Point(301, 68)
        Me.SavesInDirectory_Saves_ListBox.Name = "SavesInDirectory_Saves_ListBox"
        Me.SavesInDirectory_Saves_ListBox.Size = New System.Drawing.Size(233, 354)
        Me.SavesInDirectory_Saves_ListBox.TabIndex = 13
        '
        'DirectoryNames_Saves_ListBox
        '
        Me.DirectoryNames_Saves_ListBox.FormattingEnabled = True
        Me.DirectoryNames_Saves_ListBox.ItemHeight = 25
        Me.DirectoryNames_Saves_ListBox.Location = New System.Drawing.Point(27, 68)
        Me.DirectoryNames_Saves_ListBox.Name = "DirectoryNames_Saves_ListBox"
        Me.DirectoryNames_Saves_ListBox.Size = New System.Drawing.Size(233, 354)
        Me.DirectoryNames_Saves_ListBox.TabIndex = 12
        '
        'DeleteModFile_Mods_Button
        '
        Me.DeleteModFile_Mods_Button.Location = New System.Drawing.Point(574, 648)
        Me.DeleteModFile_Mods_Button.Name = "DeleteModFile_Mods_Button"
        Me.DeleteModFile_Mods_Button.Size = New System.Drawing.Size(233, 70)
        Me.DeleteModFile_Mods_Button.TabIndex = 12
        Me.DeleteModFile_Mods_Button.Text = "Delete Mod File"
        Me.DeleteModFile_Mods_Button.UseVisualStyleBackColor = True
        '
        'DeleteResoursePackFile_ResourcePacks_Button
        '
        Me.DeleteResoursePackFile_ResourcePacks_Button.Location = New System.Drawing.Point(585, 657)
        Me.DeleteResoursePackFile_ResourcePacks_Button.Name = "DeleteResoursePackFile_ResourcePacks_Button"
        Me.DeleteResoursePackFile_ResourcePacks_Button.Size = New System.Drawing.Size(233, 70)
        Me.DeleteResoursePackFile_ResourcePacks_Button.TabIndex = 23
        Me.DeleteResoursePackFile_ResourcePacks_Button.Text = "Delete Resourse Pack File"
        Me.DeleteResoursePackFile_ResourcePacks_Button.UseVisualStyleBackColor = True
        '
        'DeleteSaveFile_Saves_Button
        '
        Me.DeleteSaveFile_Saves_Button.Location = New System.Drawing.Point(577, 648)
        Me.DeleteSaveFile_Saves_Button.Name = "DeleteSaveFile_Saves_Button"
        Me.DeleteSaveFile_Saves_Button.Size = New System.Drawing.Size(233, 70)
        Me.DeleteSaveFile_Saves_Button.TabIndex = 23
        Me.DeleteSaveFile_Saves_Button.Text = "Delete Save File"
        Me.DeleteSaveFile_Saves_Button.UseVisualStyleBackColor = True
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
        Me.Versions_TabPage.ResumeLayout(False)
        Me.Versions_TabPage.PerformLayout()
        Me.ResoursePacks_TabPage.ResumeLayout(False)
        Me.ResoursePacks_TabPage.PerformLayout()
        Me.Saves_TabPage.ResumeLayout(False)
        Me.Saves_TabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainMenu_TabControl As TabControl
    Friend WithEvents Directories_TabPage As TabPage
    Friend WithEvents UpdateDirectoryInfo_Directories_Button As Button
    Friend WithEvents DeleteDirectory_Directories_Button As Button
    Friend WithEvents AddDirectory_Directories_Button As Button
    Friend WithEvents DirectoryNames_Directories_ListBox As ListBox
    Friend WithEvents Mods_TabPage As TabPage
    Friend WithEvents DirectoryInfo_Directories_RichTextBox As RichTextBox
    Friend WithEvents DirectoryInfo_Directories_Label As Label
    Friend WithEvents NavToDirectory_Directories_Button As Button
    Friend WithEvents DirectoryPath_Directories_TextBox As TextBox
    Friend WithEvents DirectoryPath_Directories_Label As Label
    Friend WithEvents DirectoryName_Directories_Label As Label
    Friend WithEvents DirectoryName_Directories_TextBox As TextBox
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
    Friend WithEvents Versions_TabPage As TabPage
    Friend WithEvents RemoveVersion_Versions_Button As Button
    Friend WithEvents VersionsInDirectory_Versions_Label As Label
    Friend WithEvents Directories_Versions_Label As Label
    Friend WithEvents VersionsInDirectory_Versions_ListBox As ListBox
    Friend WithEvents DirectoryNames_Versions_ListBox As ListBox
    Friend WithEvents ResetChanges_Versions_Button As Button
    Friend WithEvents UpdateDirectories_Versions_Button As Button
    Friend WithEvents ResoursePacks_TabPage As TabPage
    Friend WithEvents Saves_TabPage As TabPage
    Friend WithEvents DeleteModFile_Mods_Button As Button
    Friend WithEvents DeleteResoursePackFile_ResourcePacks_Button As Button
    Friend WithEvents ResetChanges_ResoursePacks_Button As Button
    Friend WithEvents UpdateResoursePacks_ResoursePacks_Button As Button
    Friend WithEvents AddResoursePackFile_ResoursePacks_Button As Button
    Friend WithEvents RemoveResoursePack_ResoursePacks_Button As Button
    Friend WithEvents AddResoursePack_ResoursePacks_Button As Button
    Friend WithEvents AvalableResoursePacks_ResoursePacks_ListBox As ListBox
    Friend WithEvents AvalableResoursePacks_ResoursePacks_Label As Label
    Friend WithEvents ResoursePacksInDirectory_ResoursePacks_Label As Label
    Friend WithEvents Directories_ResoursePacks_Label As Label
    Friend WithEvents ResoursePacksInDirectory_ResoursePacks_ListBox As ListBox
    Friend WithEvents DirectoryNames_ResoursePacks_ListBox As ListBox
    Friend WithEvents DeleteSaveFile_Saves_Button As Button
    Friend WithEvents ResetChanges_Saves_Button As Button
    Friend WithEvents UpdateSaves_Saves_Button As Button
    Friend WithEvents AddSaveFile_Saves_Button As Button
    Friend WithEvents RemoveSave_Saves_Button As Button
    Friend WithEvents AddSave_Saves_Button As Button
    Friend WithEvents AvalableSaves_Saves_ListBox As ListBox
    Friend WithEvents AvalableSaves_Saves_Label As Label
    Friend WithEvents SavesInDirectory_Saves_Label As Label
    Friend WithEvents Directories_Saves_Label As Label
    Friend WithEvents SavesInDirectory_Saves_ListBox As ListBox
    Friend WithEvents DirectoryNames_Saves_ListBox As ListBox
End Class
