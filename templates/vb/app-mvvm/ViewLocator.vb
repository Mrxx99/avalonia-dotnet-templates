Imports System
#If (Not ReactiveUIToolkitChosen) Then
Imports System.ComponentModel
#End If
Imports Avalonia.Controls
Imports Avalonia.Controls.Templates
#If (ReactiveUIToolkitChosen) Then
Imports AvaloniaAppTemplate.ViewModels
#End If

Public Class ViewLocator
    Implements IDataTemplate

    Public Function Build(data As Object) As IControl Implements ITemplate(Of Object, IControl).Build
        Dim name = data.GetType().FullName.Replace("ViewModel", "View")
        Dim type = System.Type.GetType(name)

        If type IsNot Nothing Then
            Return DirectCast(Activator.CreateInstance(type), IControl)
        End If

        Return New TextBlock With {.Text = "Not Found: " + name}
    End Function

    Public Function Match(data As Object) As Boolean Implements IDataTemplate.Match
#If (ReactiveUIToolkitChosen) Then
        Return TypeOf data Is ViewModelBase
#Else
        Return TypeOf data Is INotifyPropertyChanged
#End If
    End Function
End Class