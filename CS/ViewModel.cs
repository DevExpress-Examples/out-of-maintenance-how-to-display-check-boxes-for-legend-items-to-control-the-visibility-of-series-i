using DevExpress.Xpf.Charts;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace CheckBoxesInLegendExample_UnboundMode {

    // To simplify this example, this class is not a descendant of the DependencyObject class   
    class ViewModel {
        ObservableCollection<SeriesNonVisualWrapper> seriesNonVisualWrappersCollection = new ObservableCollection<SeriesNonVisualWrapper>();
        SeriesCollection seriesCollection;
        Palette palette;

        public ObservableCollection<SeriesNonVisualWrapper> SeriesNonVisualWrappersCollection {
            get { return seriesNonVisualWrappersCollection; }
        }

        public ViewModel(SeriesCollection seriesCollection, Palette palette) {
            this.seriesCollection = seriesCollection;
            this.palette = palette;
            UpdateSeriesWrapperCollection();
        }

        public void UpdateSeriesWrapperCollection() {
            this.seriesNonVisualWrappersCollection.Clear();
            for(int i = 0; i < seriesCollection.Count; i++)
                SeriesNonVisualWrappersCollection.Add(new SeriesNonVisualWrapper(this.seriesCollection[i], new SolidColorBrush(this.palette[i])));
        }
    }

}
