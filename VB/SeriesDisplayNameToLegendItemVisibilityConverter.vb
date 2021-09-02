﻿Imports System
Imports System.Windows
Imports System.Windows.Data

Namespace CheckBoxesInLegendExample_UnboundMode

	'This converter is used to hide the fake series from the legend
	Friend Class SeriesDisplayNameToLegendItemVisibilityConverter
		Implements IValueConverter

		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Dim displayName As String = DirectCast(value, String)
			If displayName = "fakeSeries" Then
				Return Visibility.Collapsed
			Else
				Return Visibility.Visible
			End If
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class

End Namespace
