using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Charts;

namespace CustomLegend {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        void button1_Click(object sender, RoutedEventArgs e) {
            foreach(Series series in Diagram.Series) {
                if(!series.Visible)
                    series.Visible = true;
            }
        }
    }

    public class CustomLegendItemsControl : ItemsControl {
        protected override bool IsItemItsOwnContainerOverride(object item) {
            return false;
        }
    }
}
