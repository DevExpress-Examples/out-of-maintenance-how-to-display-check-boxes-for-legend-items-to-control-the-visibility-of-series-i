Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Charts

Namespace LegendCustomization
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim total As Double = 0
			For Each point As SeriesPoint In series.Points
				total += point.Value
			Next point
			chart.Legend.DataContext = total
		End Sub
	End Class
End Namespace