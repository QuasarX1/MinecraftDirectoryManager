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
        Me.DirectoryNames_ListBox = New System.Windows.Forms.ListBox()
        Me.AddDirectory_Button = New System.Windows.Forms.Button()
        Me.DeleteDirectory_Button = New System.Windows.Forms.Button()
        Me.UpdateDirectoryInfo_Button = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DirectoryName_Label = New System.Windows.Forms.Label()
        Me.DirectoryPath_Label = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.NavToDirectory_Button = New System.Windows.Forms.Button()
        Me.DirectoryInfo_Label = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MainMenu_TabControl.SuspendLayout()
        Me.Directories_TabPage.SuspendLayout()
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
        Me.Directories_TabPage.Controls.Add(Me.DirectoryInfo_Label)
        Me.Directories_TabPage.Controls.Add(Me.NavToDirectory_Button)
        Me.Directories_TabPage.Controls.Add(Me.TextBox2)
        Me.Directories_TabPage.Controls.Add(Me.DirectoryPath_Label)
        Me.Directories_TabPage.Controls.Add(Me.DirectoryName_Label)
        Me.Directories_TabPage.Controls.Add(Me.TextBox1)
        Me.Directories_TabPage.Controls.Add(Me.UpdateDirectoryInfo_Button)
        Me.Directories_TabPage.Controls.Add(Me.DeleteDirectory_Button)
        Me.Directories_TabPage.Controls.Add(Me.AddDirectory_Button)
        Me.Directories_TabPage.Controls.Add(Me.DirectoryNames_ListBox)
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
        Me.Mods_TabPage.Location = New System.Drawing.Point(8, 39)
        Me.Mods_TabPage.Name = "Mods_TabPage"
        Me.Mods_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.Mods_TabPage.Size = New System.Drawing.Size(1258, 733)
        Me.Mods_TabPage.TabIndex = 1
        Me.Mods_TabPage.Text = "Mods"
        Me.Mods_TabPage.UseVisualStyleBackColor = True
        '
        'DirectoryNames_ListBox
        '
        Me.DirectoryNames_ListBox.FormattingEnabled = True
        Me.DirectoryNames_ListBox.ItemHeight = 25
        Me.DirectoryNames_ListBox.Location = New System.Drawing.Point(237, 31)
        Me.DirectoryNames_ListBox.Name = "DirectoryNames_ListBox"
        Me.DirectoryNames_ListBox.Size = New System.Drawing.Size(233, 354)
        Me.DirectoryNames_ListBox.TabIndex = 0
        '
        'AddDirectory_Button
        '
        Me.AddDirectory_Button.Location = New System.Drawing.Point(27, 31)
        Me.AddDirectory_Button.Name = "AddDirectory_Button"
        Me.AddDirectory_Button.Size = New System.Drawing.Size(178, 91)
        Me.AddDirectory_Button.TabIndex = 1
        Me.AddDirectory_Button.Text = "Add Directory"
        Me.AddDirectory_Button.UseVisualStyleBackColor = True
        '
        'DeleteDirectory_Button
        '
        Me.DeleteDirectory_Button.Location = New System.Drawing.Point(27, 294)
        Me.DeleteDirectory_Button.Name = "DeleteDirectory_Button"
        Me.DeleteDirectory_Button.Size = New System.Drawing.Size(178, 91)
        Me.DeleteDirectory_Button.TabIndex = 2
        Me.DeleteDirectory_Button.Text = "Delete Directory"
        Me.DeleteDirectory_Button.UseVisualStyleBackColor = True
        '
        'UpdateDirectoryInfo_Button
        '
        Me.UpdateDirectoryInfo_Button.Location = New System.Drawing.Point(696, 361)
        Me.UpdateDirectoryInfo_Button.Name = "UpdateDirectoryInfo_Button"
        Me.UpdateDirectoryInfo_Button.Size = New System.Drawing.Size(178, 91)
        Me.UpdateDirectoryInfo_Button.TabIndex = 3
        Me.UpdateDirectoryInfo_Button.Text = "Update Directory Info"
        Me.UpdateDirectoryInfo_Button.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(696, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(263, 31)
        Me.TextBox1.TabIndex = 4
        '
        'DirectoryName_Label
        '
        Me.DirectoryName_Label.AutoSize = True
        Me.DirectoryName_Label.Location = New System.Drawing.Point(504, 37)
        Me.DirectoryName_Label.Name = "DirectoryName_Label"
        Me.DirectoryName_Label.Size = New System.Drawing.Size(160, 25)
        Me.DirectoryName_Label.TabIndex = 5
        Me.DirectoryName_Label.Text = "Directory Name"
        '
        'DirectoryPath_Label
        '
        Me.DirectoryPath_Label.AutoSize = True
        Me.DirectoryPath_Label.Location = New System.Drawing.Point(516, 97)
        Me.DirectoryPath_Label.Name = "DirectoryPath_Label"
        Me.DirectoryPath_Label.Size = New System.Drawing.Size(148, 25)
        Me.DirectoryPath_Label.TabIndex = 6
        Me.DirectoryPath_Label.Text = "Directory Path"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(696, 97)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(263, 31)
        Me.TextBox2.TabIndex = 7
        '
        'NavToDirectory_Button
        '
        Me.NavToDirectory_Button.Location = New System.Drawing.Point(1002, 97)
        Me.NavToDirectory_Button.Name = "NavToDirectory_Button"
        Me.NavToDirectory_Button.Size = New System.Drawing.Size(153, 30)
        Me.NavToDirectory_Button.TabIndex = 8
        Me.NavToDirectory_Button.Text = "Navigate To"
        Me.NavToDirectory_Button.UseVisualStyleBackColor = True
        '
        'DirectoryInfo_Label
        '
        Me.DirectoryInfo_Label.AutoSize = True
        Me.DirectoryInfo_Label.Location = New System.Drawing.Point(525, 157)
        Me.DirectoryInfo_Label.Name = "DirectoryInfo_Label"
        Me.DirectoryInfo_Label.Size = New System.Drawing.Size(139, 25)
        Me.DirectoryInfo_Label.TabIndex = 9
        Me.DirectoryInfo_Label.Text = "Directory Info"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(696, 157)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(263, 162)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainMenu_TabControl As TabControl
    Friend WithEvents Directories_TabPage As TabPage
    Friend WithEvents UpdateDirectoryInfo_Button As Button
    Friend WithEvents DeleteDirectory_Button As Button
    Friend WithEvents AddDirectory_Button As Button
    Friend WithEvents DirectoryNames_ListBox As ListBox
    Friend WithEvents Mods_TabPage As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents DirectoryInfo_Label As Label
    Friend WithEvents NavToDirectory_Button As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DirectoryPath_Label As Label
    Friend WithEvents DirectoryName_Label As Label
    Friend WithEvents TextBox1 As TextBox
End Class
