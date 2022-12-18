Imports System.Windows

Namespace NumericRangeControlClient

    Public Partial Class MainWindow
        Inherits Window

        Private dataArray As Integer() = New Integer() {0, 4, 2, 5, 4, 5, 3, 4, 8, 9, 10}

        Public Sub New()
            Me.InitializeComponent()
            DataContext = dataArray
        End Sub
    End Class
End Namespace
