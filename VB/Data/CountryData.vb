Namespace CreateHierarchicalReportInCode
	Public Class CountryData
		Public Sub New(ByVal regionId As Integer, ByVal parentRegionId As Integer, ByVal region As String, ByVal area As Double)
			Me.RegionID = regionId
			Me.ParentRegionID = parentRegionId
			Me.Region = region
			Me.Area = area
		End Sub
		Public Property RegionID() As Integer
		Public Property ParentRegionID() As Integer
		Public Property Region() As String
		Public Property Area() As Double
	End Class
End Namespace
