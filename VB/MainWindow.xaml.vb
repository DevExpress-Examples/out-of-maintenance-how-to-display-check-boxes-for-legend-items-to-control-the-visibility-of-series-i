Imports DevExpress.Xpf.Charts
Imports System.Collections.Specialized
Imports System.Windows

Namespace CheckBoxesInLegendExample_UnboundMode

    Public Partial Class MainWindow
        Inherits Window

        Private viewModel As ViewModel

        Public Sub New()
            Me.InitializeComponent()
            viewModel = New ViewModel(Me.chart.Diagram.Series, Me.chart.Palette)
            AddHandler Me.chart.Diagram.Series.CollectionChanged, AddressOf Me.Series_CollectionChanged
            DataContext = viewModel
        End Sub

        Private Sub Series_CollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
            viewModel.UpdateSeriesWrapperCollection()
        End Sub

        Private Sub addSeries_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim seriesCount As Integer = Me.chart.Diagram.Series.Count
            Dim newSeries As PointSeries2D = New PointSeries2D()
            newSeries.Points.Add(New SeriesPoint(1.0, 1.0))
            newSeries.DisplayName = "Series" & seriesCount
            Me.chart.Diagram.Series.Add(newSeries)
        End Sub

        Private Sub deleteSeries_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim seriesCount As Integer = Me.chart.Diagram.Series.Count
            If seriesCount > 1 Then Me.chart.Diagram.Series.RemoveAt(seriesCount - 1)
        End Sub
    End Class
End Namespace
