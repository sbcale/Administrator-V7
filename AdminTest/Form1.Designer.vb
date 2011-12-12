<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminMain))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.tvwAdmin = New System.Windows.Forms.TreeView
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.lvwAdmin = New System.Windows.Forms.ListView
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.PanelPT = New System.Windows.Forms.Panel
        Me.propGribTabs = New System.Windows.Forms.PropertyGrid
        Me.contextAddControl = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.addTextBox = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripAdmin = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.contextAddControl.SuspendLayout()
        Me.toolStripAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvwAdmin)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(808, 492)
        Me.SplitContainer1.SplitterDistance = 174
        Me.SplitContainer1.TabIndex = 0
        '
        'tvwAdmin
        '
        Me.tvwAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwAdmin.Location = New System.Drawing.Point(0, 0)
        Me.tvwAdmin.Name = "tvwAdmin"
        Me.tvwAdmin.Size = New System.Drawing.Size(174, 492)
        Me.tvwAdmin.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lvwAdmin)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(630, 492)
        Me.SplitContainer2.SplitterDistance = 408
        Me.SplitContainer2.TabIndex = 0
        '
        'lvwAdmin
        '
        Me.lvwAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwAdmin.Location = New System.Drawing.Point(0, 0)
        Me.lvwAdmin.Name = "lvwAdmin"
        Me.lvwAdmin.Size = New System.Drawing.Size(408, 492)
        Me.lvwAdmin.TabIndex = 0
        Me.lvwAdmin.UseCompatibleStateImageBehavior = False
        Me.lvwAdmin.View = System.Windows.Forms.View.Details
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.PanelPT)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.propGribTabs)
        Me.SplitContainer3.Size = New System.Drawing.Size(218, 492)
        Me.SplitContainer3.SplitterDistance = 243
        Me.SplitContainer3.TabIndex = 0
        '
        'PanelPT
        '
        Me.PanelPT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPT.Location = New System.Drawing.Point(0, 0)
        Me.PanelPT.Name = "PanelPT"
        Me.PanelPT.Size = New System.Drawing.Size(218, 243)
        Me.PanelPT.TabIndex = 0
        '
        'propGribTabs
        '
        Me.propGribTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.propGribTabs.Location = New System.Drawing.Point(0, 0)
        Me.propGribTabs.Name = "propGribTabs"
        Me.propGribTabs.PropertySort = System.Windows.Forms.PropertySort.Categorized
        Me.propGribTabs.Size = New System.Drawing.Size(218, 245)
        Me.propGribTabs.TabIndex = 0
        '
        'contextAddControl
        '
        Me.contextAddControl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addTextBox})
        Me.contextAddControl.Name = "contextAddControl"
        Me.contextAddControl.Size = New System.Drawing.Size(144, 26)
        '
        'addTextBox
        '
        Me.addTextBox.Name = "addTextBox"
        Me.addTextBox.Size = New System.Drawing.Size(143, 22)
        Me.addTextBox.Text = "Add Text Box"
        '
        'toolStripAdmin
        '
        Me.toolStripAdmin.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolStripAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.toolStripAdmin.Location = New System.Drawing.Point(0, 0)
        Me.toolStripAdmin.Name = "toolStripAdmin"
        Me.toolStripAdmin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.toolStripAdmin.Size = New System.Drawing.Size(808, 25)
        Me.toolStripAdmin.TabIndex = 2
        Me.toolStripAdmin.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(64, 22)
        Me.ToolStripButton1.Text = "Properties"
        '
        'frmAdminMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 492)
        Me.Controls.Add(Me.toolStripAdmin)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdminMain"
        Me.Text = "Admin Test"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.contextAddControl.ResumeLayout(False)
        Me.toolStripAdmin.ResumeLayout(False)
        Me.toolStripAdmin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents tvwAdmin As System.Windows.Forms.TreeView
    Friend WithEvents lvwAdmin As System.Windows.Forms.ListView
    Friend WithEvents PanelPT As System.Windows.Forms.Panel
    Friend WithEvents contextAddControl As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents addTextBox As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents propGribTabs As System.Windows.Forms.PropertyGrid
    Friend WithEvents toolStripAdmin As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton

End Class
