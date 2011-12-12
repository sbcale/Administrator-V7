<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlDMSTextBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblTextBox = New System.Windows.Forms.Label
        Me.txtTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lblTextBox
        '
        Me.lblTextBox.AutoSize = True
        Me.lblTextBox.Location = New System.Drawing.Point(3, 0)
        Me.lblTextBox.Name = "lblTextBox"
        Me.lblTextBox.Size = New System.Drawing.Size(78, 13)
        Me.lblTextBox.TabIndex = 0
        Me.lblTextBox.Text = "Text Box Label"
        '
        'txtTextBox
        '
        Me.txtTextBox.Enabled = False
        Me.txtTextBox.Location = New System.Drawing.Point(6, 16)
        Me.txtTextBox.Name = "txtTextBox"
        Me.txtTextBox.Size = New System.Drawing.Size(205, 20)
        Me.txtTextBox.TabIndex = 1
        '
        'ctrlDMSTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtTextBox)
        Me.Controls.Add(Me.lblTextBox)
        Me.Name = "ctrlDMSTextBox"
        Me.Size = New System.Drawing.Size(215, 42)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTextBox As System.Windows.Forms.Label
    Public WithEvents txtTextBox As System.Windows.Forms.TextBox

End Class
