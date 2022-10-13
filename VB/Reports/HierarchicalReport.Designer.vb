Namespace CreateHierarchicalReportInCode.Reports
	Partial Public Class HierarchicalReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim objectConstructorInfo1 As New DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(HierarchicalReport))
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.table1 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.table2 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.objectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
			Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
			CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.objectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.pageInfo1, Me.pageInfo2})
			Me.BottomMargin.Name = "BottomMargin"
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.label1})
			Me.ReportHeader.HeightF = 60F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table1})
			Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeader1.HeightF = 28F
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrCheckBox1, Me.table2})
			Me.Detail.DrillDownControl = Me.xrCheckBox1
			Me.Detail.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "Iif([DataSource.CurrentRowHierarchyLevel] == 0, Rgb(231,235,244), ?)")})
			Me.Detail.HeightF = 25.00004F
			Me.Detail.HierarchyPrintOptions.Indent = 30F
			Me.Detail.HierarchyPrintOptions.KeyFieldName = "RegionID"
			Me.Detail.HierarchyPrintOptions.ParentFieldName = "ParentRegionID"
			Me.Detail.Name = "Detail"
			Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("Region", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			' 
			' pageInfo1
			' 
			Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.pageInfo1.Name = "pageInfo1"
			Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			Me.pageInfo1.SizeF = New System.Drawing.SizeF(325F, 23F)
			Me.pageInfo1.StyleName = "PageInfo"
			' 
			' pageInfo2
			' 
			Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(325F, 0F)
			Me.pageInfo2.Name = "pageInfo2"
			Me.pageInfo2.SizeF = New System.Drawing.SizeF(325F, 23F)
			Me.pageInfo2.StyleName = "PageInfo"
			Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.pageInfo2.TextFormatString = "Page {0} of {1}"
			' 
			' label1
			' 
			Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.label1.Name = "label1"
			Me.label1.SizeF = New System.Drawing.SizeF(650F, 24.19433F)
			Me.label1.StyleName = "Title"
			Me.label1.Text = "Report Title"
			' 
			' table1
			' 
			Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.table1.Name = "table1"
			Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow1})
			Me.table1.SizeF = New System.Drawing.SizeF(650F, 28F)
			' 
			' tableRow1
			' 
			Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell1, Me.tableCell2})
			Me.tableRow1.Name = "tableRow1"
			Me.tableRow1.Weight = 1R
			' 
			' tableCell1
			' 
			Me.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.tableCell1.Name = "tableCell1"
			Me.tableCell1.StyleName = "DetailCaption1"
			Me.tableCell1.StylePriority.UseBorders = False
			Me.tableCell1.Text = "Region"
			Me.tableCell1.Weight = 0.57217848557692308R
			' 
			' tableCell2
			' 
			Me.tableCell2.Name = "tableCell2"
			Me.tableCell2.StyleName = "DetailCaption1"
			Me.tableCell2.StylePriority.UseTextAlignment = False
			Me.tableCell2.Text = "Area"
			Me.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.tableCell2.Weight = 0.4278215613731971R
			' 
			' table2
			' 
			Me.table2.AnchorHorizontal = (CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles))
			Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(27.08337F, 0F)
			Me.table2.Name = "table2"
			Me.table2.OddStyleName = "DetailData3_Odd"
			Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow2})
			Me.table2.SizeF = New System.Drawing.SizeF(622.9166F, 25F)
			' 
			' tableRow2
			' 
			Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell3, Me.tableCell4})
			Me.tableRow2.Name = "tableRow2"
			Me.tableRow2.Weight = 11.5R
			' 
			' tableCell3
			' 
			Me.tableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.tableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Region]")})
			Me.tableCell3.Name = "tableCell3"
			Me.tableCell3.StyleName = "DetailData1"
			Me.tableCell3.StylePriority.UseBorders = False
			Me.tableCell3.Weight = 0.53051170935997594R
			' 
			' tableCell4
			' 
			Me.tableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Area]")})
			Me.tableCell4.Name = "tableCell4"
			Me.tableCell4.StyleName = "DetailData1"
			Me.tableCell4.StylePriority.UseTextAlignment = False
			Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.tableCell4.TextFormatString = "{0:N0}"
			Me.tableCell4.Weight = 0.4278215613731971R
			' 
			' objectDataSource1
			' 
			Me.objectDataSource1.Constructor = objectConstructorInfo1
			Me.objectDataSource1.DataSource = GetType(CreateHierarchicalReportInCode.CountryDataSource)
			Me.objectDataSource1.Name = "objectDataSource1"
			' 
			' Title
			' 
			Me.Title.BackColor = System.Drawing.Color.Transparent
			Me.Title.BorderColor = System.Drawing.Color.Black
			Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.Title.BorderWidth = 1F
			Me.Title.Font = New System.Drawing.Font("Arial", 14.25F)
			Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.Title.Name = "Title"
			Me.Title.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			' 
			' DetailCaption1
			' 
			Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.DetailCaption1.BorderColor = System.Drawing.Color.White
			Me.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
			Me.DetailCaption1.BorderWidth = 2F
			Me.DetailCaption1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.DetailCaption1.ForeColor = System.Drawing.Color.White
			Me.DetailCaption1.Name = "DetailCaption1"
			Me.DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailData1
			' 
			Me.DetailData1.BorderColor = System.Drawing.Color.Transparent
			Me.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
			Me.DetailData1.BorderWidth = 2F
			Me.DetailData1.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.DetailData1.ForeColor = System.Drawing.Color.Black
			Me.DetailData1.Name = "DetailData1"
			Me.DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailData3_Odd
			' 
			Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(231)))), (CInt((CByte(231)))), (CInt((CByte(231)))))
			Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
			Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.DetailData3_Odd.BorderWidth = 1F
			Me.DetailData3_Odd.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
			Me.DetailData3_Odd.Name = "DetailData3_Odd"
			Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' PageInfo
			' 
			Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.PageInfo.Name = "PageInfo"
			Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			' 
			' xrCheckBox1
			' 
			Me.xrCheckBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[ReportItems.Detail].[DrillDownExpanded]")})
			Me.xrCheckBox1.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrCheckBox1.GlyphOptions.CustomGlyphs.Checked"))
			Me.xrCheckBox1.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrCheckBox1.GlyphOptions.CustomGlyphs.Unchecked"))
			Me.xrCheckBox1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrCheckBox1.Name = "xrCheckBox1"
			Me.xrCheckBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrCheckBox1.SizeF = New System.Drawing.SizeF(27.08333F, 25.00004F)
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.Detail})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.objectDataSource1})
			Me.DataSource = Me.objectDataSource1
			Me.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.DetailCaption1, Me.DetailData1, Me.DetailData3_Odd, Me.PageInfo})
			Me.Version = "22.1"
			CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.objectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private label1 As DevExpress.XtraReports.UI.XRLabel
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private table1 As DevExpress.XtraReports.UI.XRTable
		Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private xrCheckBox1 As DevExpress.XtraReports.UI.XRCheckBox
		Private table2 As DevExpress.XtraReports.UI.XRTable
		Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private objectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
		Private Title As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailCaption1 As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailData1 As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
		Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
	End Class
End Namespace
