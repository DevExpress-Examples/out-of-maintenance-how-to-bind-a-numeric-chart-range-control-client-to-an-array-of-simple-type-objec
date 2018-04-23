Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows

Namespace NumericRangeControlClient

	Partial Public Class MainWindow
		Inherits Window

		Private dataArray() As Integer = { 0, 4, 2, 5, 4, 5, 3, 4, 8, 9, 10 }

		Public Sub New()
			InitializeComponent()
			DataContext = dataArray
		End Sub
	End Class
End Namespace
