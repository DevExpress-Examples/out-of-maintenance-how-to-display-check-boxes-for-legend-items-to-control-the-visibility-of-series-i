<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128569746/12.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2842)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [SeriesDisplayNameToLegendItemVisibilityConverter.cs](./CS/SeriesDisplayNameToLegendItemVisibilityConverter.cs) (VB: [SeriesDisplayNameToLegendItemVisibilityConverter.vb](./VB/SeriesDisplayNameToLegendItemVisibilityConverter.vb))
* [SeriesNonVisualWrapper.cs](./CS/SeriesNonVisualWrapper.cs) (VB: [SeriesNonVisualWrapper.vb](./VB/SeriesNonVisualWrapper.vb))
* [ViewModel.cs](./CS/ViewModel.cs) (VB: [ViewModel.vb](./VB/ViewModel.vb))
<!-- default file list end -->
# How to display check boxes for legend items to control the visibility of series in the unbound mode


<p>This example demonstrates how you can provide each legend item with a check box, which controls the visibility of the corresponding series in the <strong>unbound mode</strong>.<br />Note that starting with the DXperience version 13.2.1, the chart control supports a built-in check box in the Legend feature. For more details, see the <a href="https://documentation.devexpress.com/#WPF/CustomDocument16247">Legend Check Box</a> topic.  </p>
<p>Implementation details for the DXperience v2012 vol 2.5</p>
<p>To accomplish this, it is necessary to assign the<strong> Legend.Template</strong> property to custom template and then bind the <strong>ItemsSource</strong> property of the<strong> ItemsControl</strong> object to <strong>SeriesNonVisualWrappersCollection</strong>.</p>
<p>This custom collection is synchronized with the diagram's series collection when the <strong>SeriesCollection.CollectionChanged </strong>event fires.</p>
<p>In addition, the fake series is created to avoid hiding the legend when the <a href="http://help.devexpress.com/#WPF/DevExpressXpfChartsSeries_Visibletopic"><u>Series.Visible</u></a> property is set to <strong>false</strong> for all series.</p>
<p>See also:<br /> - <a href="https://www.devexpress.com/Support/Center/p/E2409">How to display custom information in the legend</a>;<br /> - <a href="https://www.devexpress.com/Support/Center/p/E1914">How to customize chart titles</a>;<br /> - <a href="http://www.devexpress.com/Support/Center/Example/Details/E4484"><u>How to display check boxes for legend items, to control the visibility of series in the bound mode</u></a>.</p>


<h3>Description</h3>

<p>To accomplish this, it is necessary to assign the <strong>Legend.Template</strong> property to custom template and then bind the <strong>ItemsSource </strong>property of the ItemsControl object to <strong>SeriesNonVisualWrappersCollection</strong>. <br> This custom collection is synchronized with the diagram's series collection when the <strong>SeriesCollection.CollectionChanged </strong>event fires.</p>
<p>In addition, the fake series is created to avoid hiding the legend when the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfChartsSeries_Visibletopic"><u>Series.Visible</u></a> property is set to <strong>false</strong> for all series.</p>

<br/>


