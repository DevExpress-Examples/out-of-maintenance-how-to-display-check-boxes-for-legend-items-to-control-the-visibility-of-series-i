using DevExpress.Xpf.Charts;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Media;

namespace CheckBoxesInLegendExample_UnboundMode {
    
    public partial class MainWindow : Window {

        ViewModel viewModel; 

        public MainWindow() {
            InitializeComponent();
            viewModel = new ViewModel(chart.Diagram.Series, chart.Palette);
            chart.Diagram.Series.CollectionChanged += Series_CollectionChanged;
            DataContext = viewModel;
        }

        void Series_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
            viewModel.UpdateSeriesWrapperCollection();
        }
        void addSeries_Click_1(object sender, RoutedEventArgs e) {
            int seriesCount = chart.Diagram.Series.Count;
            PointSeries2D newSeries = new PointSeries2D();
            newSeries.Points.Add(new SeriesPoint(1.0, 1.0));
            newSeries.DisplayName = "Series" + seriesCount;
            chart.Diagram.Series.Add(newSeries);
        }
        void deleteSeries_Click_1(object sender, RoutedEventArgs e) {
            int seriesCount = chart.Diagram.Series.Count;
            if (seriesCount > 1)
                chart.Diagram.Series.RemoveAt(seriesCount-1);
        }
    }

}