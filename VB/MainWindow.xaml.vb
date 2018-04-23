Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.Charts
Imports System.Collections.Specialized
Imports System.Windows
Imports System.Windows.Media

Namespace CheckBoxesInLegendExample_UnboundMode

	Partial Public Class MainWindow
		Inherits Window

		Private viewModel As ViewModel

		Public Sub New()
			InitializeComponent()
			viewModel = New ViewModel(chart.Diagram.Series, chart.Palette)
			AddHandler chart.Diagram.Series.CollectionChanged, AddressOf Series_CollectionChanged
			DataContext = viewModel
		End Sub

		Private Sub Series_CollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
			viewModel.UpdateSeriesWrapperCollection()
		End Sub
		Private Sub addSeries_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim seriesCount As Integer = chart.Diagram.Series.Count
			Dim newSeries As New PointSeries2D()
			newSeries.Points.Add(New SeriesPoint(1.0, 1.0))
			newSeries.DisplayName = "Series" & seriesCount
			chart.Diagram.Series.Add(newSeries)
		End Sub
		Private Sub deleteSeries_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim seriesCount As Integer = chart.Diagram.Series.Count
			If seriesCount > 1 Then
				chart.Diagram.Series.RemoveAt(seriesCount-1)
			End If
		End Sub
	End Class

End Namespace