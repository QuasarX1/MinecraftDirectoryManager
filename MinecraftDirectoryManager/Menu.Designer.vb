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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DirectoryNames_ListBox = New System.Windows.Forms.ListBox()
        Me.AddDirectory_Button = New System.Windows.Forms.Button()
        Me.DeleteDirectory_Button = New System.Windows.Forms.Button()
        Me.EditDirectory_Button = New System.Windows.Forms.Button()
        Me.MainMenu_TabControl.SuspendLayout()
        Me.Directories_TabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu_TabControl
        '
        Me.MainMenu_TabControl.Controls.Add(Me.Directories_TabPage)
        Me.MainMenu_TabControl.Controls.Add(Me.TabPage2)
        Me.MainMenu_TabControl.Location = New System.Drawing.Point(12, 12)
        Me.MainMenu_TabControl.Name = "MainMenu_TabControl"
        Me.MainMenu_TabControl.SelectedIndex = 0
        Me.MainMenu_TabControl.Size = New System.Drawing.Size(1274, 780)
        Me.MainMenu_TabControl.TabIndex = 0
        '
        'Directories_TabPage
        '
        Me.Directories_TabPage.Controls.Add(Me.EditDirectory_Button)
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
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(8, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1258, 733)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DirectoryNames_ListBox
        '
        Me.DirectoryNames_ListBox.FormattingEnabled = True
        Me.DirectoryNames_ListBox.ItemHeight = 25
        Me.DirectoryNames_ListBox.Location = New System.Drawing.Point(237, 31)
        Me.DirectoryNames_ListBox.Name = "DirectoryNames_ListBox"
        Me.DirectoryNames_ListBox.Size = New System.Drawing.Size(233, 654)
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
        Me.DeleteDirectory_Button.Location = New System.Drawing.Point(27, 285)
        Me.DeleteDirectory_Button.Name = "DeleteDirectory_Button"
        Me.DeleteDirectory_Button.Size = New System.Drawing.Size(178, 91)
        Me.DeleteDirectory_Button.TabIndex = 2
        Me.DeleteDirectory_Button.Text = "Delete Directory"
        Me.DeleteDirectory_Button.UseVisualStyleBackColor = True
        '
        'EditDirectory_Button
        '
        Me.EditDirectory_Button.Location = New System.Drawing.Point(27, 157)
        Me.EditDirectory_Button.Name = "EditDirectory_Button"
        Me.EditDirectory_Button.Size = New System.Drawing.Size(178, 91)
        Me.EditDirectory_Button.TabIndex = 3
        Me.EditDirectory_Button.Text = "Edit Directory"
        Me.EditDirectory_Button.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1298, 804)
        Me.Controls.Add(Me.MainMenu_TabControl)
        Me.Name = "Menu"
        Me.Text = "Form1"
        Me.MainMenu_TabControl.ResumeLayout(False)
        Me.Directories_TabPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainMenu_TabControl As TabControl
    Friend WithEvents Directories_TabPage As TabPage
    Friend WithEvents EditDirectory_Button As Button
    Friend WithEvents DeleteDirectory_Button As Button
    Friend WithEvents AddDirectory_Button As Button
    Friend WithEvents DirectoryNames_ListBox As ListBox
    Friend WithEvents TabPage2 As TabPage
End Class
