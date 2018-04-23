using System.Windows;
using DevExpress.Xpf.Charts;

namespace LegendCustomization {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        void chart_BoundDataChanged(object sender, RoutedEventArgs e) {
            double total = 0;
            foreach (SeriesPoint point in series.Points)
                total += point.Value;
            chart.Legend.DataContext = total;
        }
    }
}