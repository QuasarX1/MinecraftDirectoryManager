<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgBoxCustom
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.MsgText_RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(130, 231)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(166, 84)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(433, 231)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(166, 84)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'MsgText_RichTextBox
        '
        Me.MsgText_RichTextBox.Enabled = False
        Me.MsgText_RichTextBox.Location = New System.Drawing.Point(12, 12)
        Me.MsgText_RichTextBox.Name = "MsgText_RichTextBox"
        Me.MsgText_RichTextBox.Size = New System.Drawing.Size(733, 179)
        Me.MsgText_RichTextBox.TabIndex = 2
        Me.MsgText_RichTextBox.Text = ""
        '
        'MsgBoxCustom
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(757, 366)
        Me.ControlBox = False
        Me.Controls.Add(Me.MsgText_RichTextBox)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.MaximumSize = New System.Drawing.Size(783, 437)
        Me.MinimumSize = New System.Drawing.Size(783, 437)
        Me.Name = "MsgBoxCustom"
        Me.Text = "MsgBoxCustom"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents MsgText_RichTextBox As RichTextBox
End Class
