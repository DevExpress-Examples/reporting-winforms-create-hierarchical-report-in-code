Imports System.Collections.Generic

Namespace CreateHierarchicalReportInCode
	Public Class CountryDataSource
		Inherits List(Of CountryData)

		Public Sub New()
			Dim sales As New List(Of CountryData)() From {
				New CountryData(0, -1, "Northern Europe", 1811151),
				New CountryData(1, 0, "Norway", 385207),
				New CountryData(2, 0, "Sweden", 528447),
				New CountryData(3, 0, "Denmark", 42951),
				New CountryData(4, 0, "Finland", 338455),
				New CountryData(5, 0, "Iceland", 103000),
				New CountryData(6, 0, "Ireland", 84421),
				New CountryData(7, 0, "United Kingdom", 243610),
				New CountryData(17, -1, "Southern Europe", 1316300),
				New CountryData(18, 17, "Spain", 505990),
				New CountryData(19, 17, "Portugal", 92212),
				New CountryData(20, 17, "Greece", 131957),
				New CountryData(21, 17, "Italy", 301230),
				New CountryData(22, 17, "Malta", 316),
				New CountryData(23, 17, "San Marino", 61.2),
				New CountryData(25, 17, "Serbia", 88499),
				New CountryData(26, -1, "North America", 24490000),
				New CountryData(27, 26, "USA", 9522055),
				New CountryData(28, 26, "Canada", 9984670),
				New CountryData(29, -1, "South America", 17840000),
				New CountryData(30, 29, "Argentina", 2780400),
				New CountryData(31, 29, "Brazil", 8514215),
				New CountryData(32, -1, "East Asia", 11796365),
				New CountryData(34, 32, "India", 3287263),
				New CountryData(35, 32, "Japan", 377975),
				New CountryData(36, 32, "China", 9597000)
			}
			Me.AddRange(sales)
		End Sub
	End Class
End Namespace
