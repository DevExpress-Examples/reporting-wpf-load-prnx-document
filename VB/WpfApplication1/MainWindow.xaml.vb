Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Printing

Namespace WpfApplication1

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim sl As SimpleLink = New SimpleLink()
            sl.PrintingSystem.LoadDocument("CustomerOrder.prnx")
            Me.documentPreview1.Model = New LinkPreviewModel(sl)
        End Sub
    End Class
End Namespace
