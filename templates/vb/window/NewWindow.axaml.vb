Imports Avalonia
Imports Avalonia.Controls
Imports Avalonia.Markup.Xaml

Public Class NewWindow
    Inherits Window

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub InitializeComponent()
        AvaloniaXamlLoader.Load(Me)

'-:cnd:noEmit
#If DEBUG Then
        Me.AttachDevTools()
#End If
'+:cnd:noEmit
    End Sub
End Class