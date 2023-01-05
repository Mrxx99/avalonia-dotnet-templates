#If (Not ReactiveUIToolkitChosen) Then
Imports CommunityToolkit.Mvvm.ComponentModel
#End If

Namespace ViewModels
    Public Class MainWindowViewModel
#If (Not ReactiveUIToolkitChosen) Then
        Inherits ObservableObject
#Else
        Inherits ViewModelBase
#End If

        Public ReadOnly Property Greeting As String
            Get
                Return "Welcome to Avalonia!"
            End Get
        End Property

    End Class
End Namespace