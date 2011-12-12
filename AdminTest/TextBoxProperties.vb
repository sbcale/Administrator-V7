Imports System.ComponentModel

<DefaultPropertyAttribute("Title"), _
DescriptionAttribute("TextBox Properties")> _
Public Class TextboxProperties
    Private _Label As String
    Private _Show As Boolean
    Private _Number As Short
    Private _Height As Integer
    Private _Width As Integer

    <CategoryAttribute("TextBox"), _
       Browsable(True), _
       [ReadOnly](False), _
       BindableAttribute(False), _
       DefaultValueAttribute(""), _
       DesignOnly(False), _
       DescriptionAttribute("Enter a label for the TextBox")> _
    Public Property Label() As String
        Get
            Return _Label
        End Get
        Set(ByVal Value As String)
            _Label = Value
        End Set
    End Property
    '''
    <CategoryAttribute("TextBox"), _
       Browsable(True), _
       [ReadOnly](False), _
       BindableAttribute(False), _
       DefaultValueAttribute("True"), _
       DesignOnly(False), _
       DescriptionAttribute("Height")> _
    Public Property Height() As Integer
        Get
            Return _Height
        End Get
        Set(ByVal Value As Integer)
            _Height = Value
        End Set
    End Property

    <CategoryAttribute("TextBox"), _
       Browsable(True), _
       [ReadOnly](False), _
       BindableAttribute(False), _
       DefaultValueAttribute("True"), _
       DesignOnly(False), _
       DescriptionAttribute("Width")> _
    Public Property Width() As Integer
        Get
            Return _Width
        End Get
        Set(ByVal Value As Integer)
            _Width = Value
        End Set
    End Property

    <CategoryAttribute("TextBox"), _
       Browsable(True), _
       [ReadOnly](False), _
       BindableAttribute(False), _
       DefaultValueAttribute("True"), _
       DesignOnly(False), _
       DescriptionAttribute("Show option")> _
    Public Property Show() As Boolean
        Get
            Return _Show
        End Get
        Set(ByVal Value As Boolean)
            _Show = Value
        End Set
    End Property

End Class
