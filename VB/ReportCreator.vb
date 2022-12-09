Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraReports.UI

Namespace CreateHierarchicalReportInCode
	Public Class ReportCreator
		Public Shared Function CreateHierarchicalReport() As XtraReport
			Dim report As New XtraReport() With {
				.DataSource = New CountryDataSource(),
				.StyleSheet = {
					New XRControlStyle() With {
						.Name = "CaptionStyle",
						.Font = New Font("Tahoma", 14F),
						.BackColor = Color.Gray,
						.ForeColor = Color.White
					},
					New XRControlStyle() With {
						.Name = "EvenStyle",
						.BackColor = Color.LightGray
					}
				}
			}
			Dim pageHeaderBand = CreatePageHeader()
			Dim detailBand = CreateDetail()
			report.Bands.AddRange(New Band() { pageHeaderBand, detailBand })
			Return report
		End Function
		Private Shared Function CreatePageHeader() As PageHeaderBand
			Dim pageHeaderBand As New PageHeaderBand() With {
				.Name = "PageHeader",
				.HeightF = 40,
				.StyleName = "CaptionStyle",
				.Padding = New PaddingInfo(5, 5, 0, 0)
			}
			Dim regionCaption As New XRLabel() With {
				.Name = "RegionCaptionLabel",
				.Text = "Region",
				.BoundsF = New RectangleF(0, 0, 475, 40),
				.TextAlignment = TextAlignment.MiddleLeft
			}
			Dim AreaCaption As New XRLabel() With {
				.Name = "AreaCaptionLabel",
				.Text = "Area",
				.BoundsF = New RectangleF(475, 0, 175, 40),
				.TextAlignment = TextAlignment.MiddleRight
			}
			pageHeaderBand.Controls.AddRange(New XRControl() { regionCaption, AreaCaption })
			Return pageHeaderBand
		End Function
		Private Shared Function CreateDetail() As DetailBand
			Dim detailBand As New DetailBand() With {
				.Name = "Detail",
				.HeightF = 25,
				.EvenStyleName = "EvenStyle",
				.Padding = New PaddingInfo(5, 5, 0, 0),
				.Font = New Font("Tahoma", 9F),
				.ExpressionBindings = { New ExpressionBinding("Font.Bold", "[DataSource.CurrentRowHierarchyLevel] == 0") },
				.SortFields = { New GroupField("Region", XRColumnSortOrder.Ascending) }
			}
			' Specify Id-ParentID related fields
			detailBand.HierarchyPrintOptions.KeyFieldName = "RegionID"
			detailBand.HierarchyPrintOptions.ParentFieldName = "ParentRegionID"
			' Specify the child node offset
			detailBand.HierarchyPrintOptions.Indent = 25

			' Add an XRCheckBox control as the DetailBand's drill-down control to allow end users to collapse and expand tree nodes
			Dim expandButton As New XRCheckBox() With {
				.Name = "DrillDownCheckBox",
				.ExpressionBindings = { New ExpressionBinding("Checked", "[ReportItems].[" & detailBand.Name & "].[DrillDownExpanded]") },
				.BoundsF = New RectangleF(0, 0, 25, 25)
			}
			Dim checkedSvg As SvgImage = SvgImage.FromResources("CreateHierarchicalReportInCode.Expanded.svg", GetType(ReportCreator).Assembly)
			Dim uncheckedSvg As SvgImage = SvgImage.FromResources("CreateHierarchicalReportInCode.Collapsed.svg", GetType(ReportCreator).Assembly)
			expandButton.GlyphOptions.Alignment = HorzAlignment.Center
			expandButton.GlyphOptions.Size = New SizeF(16, 16)
			expandButton.GlyphOptions.CustomGlyphs(CheckBoxState.Checked) = New ImageSource(checkedSvg)
			expandButton.GlyphOptions.CustomGlyphs(CheckBoxState.Unchecked) = New ImageSource(uncheckedSvg)
			detailBand.DrillDownControl = expandButton
			detailBand.DrillDownExpanded = False

			Dim regionLabel As New XRLabel() With {
				.Name = "RegionLabel",
				.ExpressionBindings = { New ExpressionBinding("Text", "[Region]") },
				.BoundsF = New RectangleF(25, 0, 450, 25),
				.TextAlignment = TextAlignment.MiddleLeft,
				.AnchorHorizontal = HorizontalAnchorStyles.Both
			}
			Dim AreaLabel As New XRLabel() With {
				.Name = "AreaLabel",
				.ExpressionBindings = { New ExpressionBinding("Text", "[Area]") },
				.TextFormatString = "{0:N0}",
				.BoundsF = New RectangleF(475, 0, 175, 25),
				.TextAlignment = TextAlignment.MiddleRight,
				.AnchorHorizontal = HorizontalAnchorStyles.Right
			}
			detailBand.Controls.AddRange(New XRControl() { expandButton, regionLabel, AreaLabel })
			Return detailBand
		End Function
	End Class
End Namespace
