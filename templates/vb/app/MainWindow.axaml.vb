Imports Avalonia
Imports Avalonia.Controls
Imports Avalonia.Markup.Xaml

Public Class MainWindow
    Inherits Window

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub InitializeComponent()
        AvaloniaXamlLoader.Load(Me)

#If DEBUG Then
        Me.AttachDevTools()
#End If
    End Sub
End Class
