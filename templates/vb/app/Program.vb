Imports Avalonia

Module Program
    <STAThread()>
    Sub Main(args As String())
        BuildAvaloniaApp().StartWithClassicDesktopLifetime(args)
    End Sub

    Function BuildAvaloniaApp() As AppBuilder
        Return AppBuilder.Configure(Of App)() _
                .UsePlatformDetect() _
                .LogToTrace()
    End Function
End Module
