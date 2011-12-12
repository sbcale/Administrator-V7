Option Explicit On

Public Class ctrlDMSTextBox
    ' Public Variables

    ' Private Variables
    Private mMouseDown As Boolean = False
    Private mEdge As EdgeEnum = EdgeEnum.None
    Private mWidth As Integer = 4

    Private m_DataID As Long
    Private m_FieldType As Integer
    Private m_Visible As Boolean
    Private m_Enabled As Boolean
    Private m_MultiValue As String
    Private m_Required As Boolean
    Private m_MinValue As Double
    Private m_MaxValue As Double
    Private m_bChanged As Boolean
    Private m_TabNo As Integer
    Private m_Wildcard As String
    Private m_MultiSqlSelectDataIDs As String
    Private m_Range As String

    Private Enum EdgeEnum
        None
        Right
        Left
        Top
        Bottom
        TopLeft
    End Enum

    Public Property FieldType() As Integer
        Get
            Return m_FieldType
        End Get
        Set(ByVal value As Integer)
            m_FieldType = value
        End Set
    End Property
    Public Overrides Property Text() As String
        Get
            Return txtTextBox.Text
        End Get
        Set(ByVal value As String)
            txtTextBox.Text = value
        End Set
    End Property


    Private _isDescriptionBox As Boolean
    Public Property IsDescriptionBox() As Boolean
        Get
            Return _isDescriptionBox
        End Get
        Set(ByVal value As Boolean)
            _isDescriptionBox = value
        End Set
    End Property

    Private _isValueDescription As Boolean
    Public Property IsValueDescription() As Boolean
        Get
            Return _isValueDescription
        End Get
        Set(ByVal value As Boolean)
            _isValueDescription = value
        End Set
    End Property
    Private _description As String
    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Private _value As String
    Public Property Value() As String
        Get
            Return _value
        End Get
        Set(ByVal value As String)
            _value = value
        End Set
    End Property
    Public Property Wildcard() As Integer
        Get
            Return m_Wildcard
        End Get
        Set(ByVal value As Integer)
            If value = 0 Then
                m_wildCard = "00"
            ElseIf value = 11 Then
                m_wildCard = "11"
            ElseIf value = 12 Then
                m_wildCard = "10"
            ElseIf value = 13 Then
                m_wildCard = "01"
            End If
        End Set
    End Property

    Public Property Range() As String
        Get
            Return m_Range
        End Get
        Set(ByVal value As String)
            m_Range = value
        End Set
    End Property
    Public Property MulitSelectDataIDs() As String
        Get
            Return m_MultiSqlSelectDataIDs
        End Get
        Set(ByVal value As String)
            m_MultiSqlSelectDataIDs = value
        End Set
    End Property
    Public Property TabNo() As Integer
        Get
            TabNo = m_TabNo
        End Get
        Set(ByVal value As Integer)
            m_TabNo = value
        End Set
    End Property

    Public Property MaxValue() As Double
        Get
            MaxValue = m_MaxValue
        End Get
        Set(ByVal value As Double)
            m_MaxValue = value
        End Set
    End Property

    Public Property MinValue() As Double
        Get
            MinValue = m_MinValue
        End Get
        Set(ByVal value As Double)
            m_MinValue = value
        End Set
    End Property

    Public Property Required() As Boolean
        Get
            Required = m_Required
        End Get
        Set(ByVal value As Boolean)
            m_Required = value
        End Set
    End Property

    Public Property bChanged() As Boolean
        Get
            bChanged = m_bChanged
        End Get
        Set(ByVal value As Boolean)
            m_bChanged = value
        End Set
    End Property

    Public Property MultiValue() As String
        Get
            MultiValue = m_MultiValue
        End Get
        Set(ByVal value As String)
            If value = "1" Then
                m_MultiValue = "yes"
            Else
                m_MultiValue = "no"
            End If
        End Set
    End Property

    Public Property DataID() As Long
        Get
            DataID = m_DataID
        End Get
        Set(ByVal value As Long)
            m_DataID = value
        End Set
    End Property

    Public WriteOnly Property ControlHeight() As Integer
        Set(ByVal value As Integer)
            If value > 30 Then
                txtTextBox.Multiline = True
            End If
            txtTextBox.Height = value
            Me.Height = lblTextBox.Height + txtTextBox.Height + 5
        End Set
    End Property

    Public WriteOnly Property ControlWidth() As Integer
        Set(ByVal value As Integer)
            txtTextBox.Width = value
            Me.Width = value + 15
        End Set
    End Property

    Public Property Caption() As String
        Get
            Caption = lblTextBox.Text
        End Get
        Set(ByVal value As String)
            lblTextBox.Text = value
        End Set
    End Property

    Public Overloads Property Visible() As Boolean
        Get
            Visible = m_Visible
        End Get
        Set(ByVal value As Boolean)
            m_Visible = value
            lblTextBox.Visible = value
            txtTextBox.Visible = value
        End Set
    End Property

    Public Overloads Property Enabled() As Boolean
        Get
            Enabled = m_Enabled
        End Get
        Set(ByVal value As Boolean)
            m_Enabled = value
            If m_Enabled = False Then
                If Required Then
                    lblTextBox.ForeColor = Color.Red
                Else
                    lblTextBox.ForeColor = Color.DimGray
                End If
                txtTextBox.ForeColor = Color.DimGray
            Else
                If Required Then
                    lblTextBox.ForeColor = Color.Red
                Else
                    lblTextBox.ForeColor = Color.Black
                End If
            End If
        End Set
    End Property

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Slight adjust for startup
        txtTextBox.Top = txtTextBox.Top - 3
        m_bChanged = False
    End Sub

    'Private Sub txtTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTextBox.KeyPress
    '    ' check if on quick search
    '    If StrComp(Me.Parent.Name, "FalconQSearch", CompareMethod.Text) = 0 Then
    '        If e.KeyChar = Chr(Keys.Enter) Then
    '            ' set to true
    '            e.Handled = True
    '            ' display wait cursor
    '            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
    '            '' call find button click
    '            'Call frmAdminMain.PanelPT.tsbFind_Click(Me, New System.EventArgs)
    '            ' display default cursor
    '            Cursor.Current = System.Windows.Forms.Cursors.Default
    '        End If
    '    Else
    '        If m_Enabled = False Then
    '            e.KeyChar = ""
    '        Else
    '            m_bChanged = True
    '            ' change save to enabled
    '            'frmDocMan.tsbSave.Enabled = True
    '        End If
    '    End If
    'End Sub

    Dim valid As Boolean
    Private Sub txtTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTextBox.Leave

        'If verifyControlValueForNumbersAndDates(m_DataID, txtTextBox.Text, lblTextBox.Text) Then

        '    txtTextBox.BackColor = Color.White
        'Else

        '    If Len(Trim(txtTextBox.Text)) > 0 Then
        '        txtTextBox.BackColor = Color.Red
        '    Else
        '        txtTextBox.BackColor = Color.White
        '    End If
        '    txtTextBox.Focus()
        '    Exit Sub
        'End If


    End Sub

    'Private Sub txtTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTextBox.LostFocus
    '    Dim bRangeOk As Boolean

    '    If Not valid Then
    '        Exit Sub
    '    End If

    '    'If verifyControlValueForNumbersAndDates(m_DataID, txtTextBox.Text, lblTextBox.Text) = False Then
    '    '    sender.Focus()
    '    '    Exit Sub
    '    'End If

    '    bRangeOk = True

    '    'm_MinValue = 2.0
    '    'm_MaxValue = 15.0

    '    'Select Case m_DataID
    '    '    Case enumFalcon50DataIDs.DATA_ID_I1, enumFalcon50DataIDs.DATA_ID_I2, _
    '    '            enumFalcon50DataIDs.DATA_ID_I3, enumFalcon50DataIDs.DATA_ID_I4
    '    '        If Len(txtTextBox.Text) > 0 Then
    '    '            If m_MinValue > CDbl(txtTextBox.Text) Then
    '    '                bRangeOk = False
    '    '                txtTextBox.Text = m_MinValue
    '    '            End If
    '    '            If m_MaxValue < CDbl(txtTextBox.Text) Then
    '    '                bRangeOk = False
    '    '                txtTextBox.Text = m_MaxValue
    '    '            End If
    '    '        Else
    '    '            bRangeOk = False
    '    '        End If
    '    '    Case enumFalcon50DataIDs.DATA_ID_R1, enumFalcon50DataIDs.DATA_ID_R2, _
    '    '            enumFalcon50DataIDs.DATA_ID_R3, enumFalcon50DataIDs.DATA_ID_R4
    '    '        If Len(txtTextBox.Text) > 0 Then
    '    '            If m_MinValue > CDbl(txtTextBox.Text) Then
    '    '                bRangeOk = False
    '    '                txtTextBox.Text = m_MinValue
    '    '            End If
    '    '            If m_MaxValue < CDbl(txtTextBox.Text) Then
    '    '                bRangeOk = False
    '    '                txtTextBox.Text = m_MaxValue
    '    '            End If
    '    '        Else
    '    '            bRangeOk = False
    '    '        End If
    '    'End Select

    '    'If bRangeOk = False Then
    '    '    Dim strMsg As String = ""
    '    '    Select Case m_DataID
    '    '        Case enumFalcon50DataIDs.DATA_ID_I1, enumFalcon50DataIDs.DATA_ID_I2, _
    '    '                enumFalcon50DataIDs.DATA_ID_I3, enumFalcon50DataIDs.DATA_ID_I4
    '    '            strMsg = "The value " & Trim(txtTextBox.Text) & " is not within the range of " & _
    '    '                CInt(m_MinValue) & " to " & CInt(m_MaxValue) & " for " & lblTextBox.Text & "."
    '    '        Case enumFalcon50DataIDs.DATA_ID_R1, enumFalcon50DataIDs.DATA_ID_R2, _
    '    '                enumFalcon50DataIDs.DATA_ID_R3, enumFalcon50DataIDs.DATA_ID_R4
    '    '            strMsg = "The value " & Trim(txtTextBox.Text) & " is not within the range of " & _
    '    '                m_MinValue & " to " & m_MaxValue & " for " & lblTextBox.Text & "."
    '    '    End Select
    '    '    MsgBox(strMsg, MsgBoxStyle.Information)

    '    '    Exit Sub
    '    'End If
    'End Sub

    Public Sub Clear()
        If Enabled Then
            txtTextBox.Text = ""
        End If
    End Sub

    Private Sub ctrlDMSTextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mMouseDown = True
            ' select
            Me.Select()
        End If
    End Sub

    Private Sub ctrlDMSTextBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Dim c As Control = CType(sender, Control)

        c.Cursor = Cursors.SizeAll
    End Sub

    Private Sub ctrlDMSTextBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ctrlDMSTextBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Dim c As Control = CType(sender, Control)

        'If mMouseDown And mEdge <> EdgeEnum.None Then
        If mMouseDown Then ' And mEdge <> EdgeEnum.None Then
            c.SuspendLayout()

            Select Case mEdge
                Case EdgeEnum.None
                    c.SetBounds(c.Left + e.X, c.Top + e.Y, c.Width, c.Height)
                    'c.SetBounds(e.X, e.Y, c.Width, c.Height)
                Case EdgeEnum.Left
                    c.SetBounds(c.Left + e.X, c.Top, c.Width - e.X, c.Height)
                Case EdgeEnum.Right
                    c.SetBounds(c.Left, c.Top, c.Width - (c.Width - e.X), c.Height)
                Case EdgeEnum.Top
                    c.SetBounds(c.Left, c.Top + e.Y, c.Width, c.Height - e.Y)
                Case EdgeEnum.Bottom
                    c.SetBounds(c.Left, c.Top, c.Width, c.Height - (c.Height - e.Y))
            End Select

            c.ResumeLayout()
        Else
            Select Case True
                'Case e.X <= (mWidth * 4) And e.Y <= (mWidth * 4) 'top left corner
                '    c.Cursor = Cursors.SizeAll
                '    mEdge = EdgeEnum.TopLeft
                Case e.X <= mWidth 'left edge
                    c.Cursor = Cursors.VSplit
                    mEdge = EdgeEnum.Left
                Case e.X > c.Width - (mWidth + 1) 'right edge
                    c.Cursor = Cursors.VSplit
                    mEdge = EdgeEnum.Right
                Case e.Y <= mWidth 'top edge
                    c.Cursor = Cursors.HSplit
                    mEdge = EdgeEnum.Top
                Case e.Y > c.Height - (mWidth + 1) 'bottom edge
                    c.Cursor = Cursors.HSplit
                    mEdge = EdgeEnum.Bottom
                Case Else 'no edge
                    c.Cursor = Cursors.SizeAll
                    mEdge = EdgeEnum.None
            End Select
        End If
    End Sub

    Private Sub ctrlDMSTextBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        mMouseDown = False
    End Sub

    Private Sub ctrlDMSTextBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Dim c As Control = CType(sender, Control)
        mEdge = EdgeEnum.None
        c.Refresh()
    End Sub
End Class
