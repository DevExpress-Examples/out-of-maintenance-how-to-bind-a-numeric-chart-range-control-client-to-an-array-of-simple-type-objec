<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128568780/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5110)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/NumericRangeControlClient/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/NumericRangeControlClient/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/NumericRangeControlClient/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/NumericRangeControlClient/MainWindow.xaml.vb))
<!-- default file list end -->
# How to bind a numeric chart range control client to an array of simple type objects


<p>This example demonstrates how to set up a range control with the numeric chart client to display a chart with numeric data in the range control's background. </p><p>Usually, in order to provide data to a chart numeric range control client, you need to specify a datasource using the <a href="https://help.devexpress.com/#WPF/DevExpressXpfChartsRangeControlClientChartRangeControlClient_ItemsSourcetopic"><u>ChartRangeControlClient.ItemsSource</u></a> property and specify the required data fields via <a href="https://help.devexpress.com/#WPF/DevExpressXpfChartsRangeControlClientChartRangeControlClient_ArgumentDataMembertopic"><u>ChartRangeControlClient.ArgumentDataMember</u></a> and <a href="https://help.devexpress.com/#WPF/DevExpressXpfChartsRangeControlClientChartRangeControlClient_ValueDataMembertopic"><u>ChartRangeControlClient.ValueDataMember</u></a> properties (for more information, see the <a href="https://www.devexpress.com/Support/Center/CodeCentral/ViewExample.aspx?exampleId=E5193"><u>How to bind a numeric chart range control client to a list of custom objects</u></a> example).</p><p>In the current example, a numeric chart client is bound to an array of integers using the I<strong>temsSource</strong> property. In addition, you can bind a numeric chart client to other simple type objects (short, integer, long,  double, decimal, float types , etc.). In this scenario the data values are shown in the same order in which elements have been added to the array.</p><p>If you wish to display chart points sorted by arguments in the ascending order, for example, from the collection, specify the <strong>ArgumentDataMember </strong>property as shown in the <a href="https://www.devexpress.com/Support/Center/CodeCentral/ViewExample.aspx?exampleId=E5190"><u>How to bind a numeric chart range control client to a point collection</u></a> example.</p>

<br/>


