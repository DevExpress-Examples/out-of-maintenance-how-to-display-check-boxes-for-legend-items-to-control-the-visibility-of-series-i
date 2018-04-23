Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Charts

Namespace CustomLegend
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			For Each series As Series In Diagram.Series
				If (Not series.Visible) Then
					series.Visible = True
				End If
			Next series
		End Sub
	End Class

	Public Class CustomLegendItemsControl
		Inherits ItemsControl
		Protected Overrides Function IsItemItsOwnContainerOverride(ByVal item As Object) As Boolean
			Return False
		End Function
	End Class
End Namespace
