Public Class frmAdminMain

    Private tsaDmsText As ctrlDMSTextBox

    Private Sub PanelPT_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelPT.MouseDown
        ' check for right click
        If e.Button = Windows.Forms.MouseButtons.Right Then
            contextAddControl.Show(PanelPT, e.Location)
        End If
    End Sub

    
    Private Sub addTextBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addTextBox.Click
        tsaDmsText = New ctrlDMSTextBox

        ' add control
        PanelPT.Controls.Add(tsaDmsText)

        tsaDmsText.Left = 5
        tsaDmsText.Top = 5

    End Sub

    Private Sub frmAdminMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' clear propgrid
        propGribTabs.SelectedObject = New TextboxProperties
    End Sub
End Class
