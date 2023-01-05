Imports Avalonia
Imports Avalonia.Controls.ApplicationLifetimes
Imports Avalonia.Markup.Xaml
#If (Not ReactiveUIToolkitChosen) Then
Imports Avalonia.Data.Core
Imports Avalonia.Data.Core.Plugins
#End If
Imports AvaloniaAppTemplate.ViewModels
Imports AvaloniaAppTemplate.Views

Public Class App
    Inherits Application

    Public Overrides Sub Initialize()
        AvaloniaXamlLoader.Load(Me)
    End Sub

    Public Overrides Sub OnFrameworkInitializationCompleted()
#If (Not ReactiveUIToolkitChosen) Then
        'Line below is needed to remove Avalonia data validation.
        'Without this line you will get duplicate validations from both Avalonia and CT
        ExpressionObserver.DataValidators.RemoveAll(Function(x) TypeOf x Is DataAnnotationsValidationPlugin)
#End If

        If TypeOf ApplicationLifetime Is IClassicDesktopStyleApplicationLifetime Then

            Dim desktop As IClassicDesktopStyleApplicationLifetime = ApplicationLifetime

            desktop.MainWindow = New MainWindow With {
                    .DataContext = New MainWindowViewModel()
                }

        End If

        MyBase.OnFrameworkInitializationCompleted()
    End Sub
End Class
