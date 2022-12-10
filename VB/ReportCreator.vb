Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraReports.UI
Imports DevExpress.LookAndFeel.DXSkinColors

Namespace CreateHierarchicalReportInCode
	Public Class ReportCreator
		Public Shared Function CreateHierarchicalReport() As XtraReport
			Dim report As New XtraReport() With {.DataSource = New CountryDataSource()}
			report.StyleSheet.AddRange( {
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
			})
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
				.Font = New Font("Tahoma", 9F)
			}
			' Print root level nodes in bold
			detailBand.ExpressionBindings.Add(New ExpressionBinding("Font.Bold", "[DataSource.CurrentRowHierarchyLevel] == 0"))
			' Sort data on each hierarchy level by the Region field
			detailBand.SortFields.Add(New GroupField("Region", XRColumnSortOrder.Ascending))
			' Specify Id-ParentID related fields
			detailBand.HierarchyPrintOptions.KeyFieldName = "RegionID"
			detailBand.HierarchyPrintOptions.ParentFieldName = "ParentRegionID"
			' Specify the child node offset
			detailBand.HierarchyPrintOptions.Indent = 25

			' Add an XRCheckBox control as the DetailBand's drill-down control to allow end users to collapse and expand tree nodes
			Dim expandButton As New XRCheckBox() With {
				.Name = "DrillDownCheckBox",
				.BoundsF = New RectangleF(0, 0, 25, 25)
			}
			expandButton.ExpressionBindings.Add(New ExpressionBinding("Checked", "[ReportItems].[" & detailBand.Name & "].[DrillDownExpanded]"))
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
				.BoundsF = New RectangleF(25, 0, 450, 25),
				.TextAlignment = TextAlignment.MiddleLeft,
				.AnchorHorizontal = HorizontalAnchorStyles.Both
			}
			regionLabel.ExpressionBindings.Add(New ExpressionBinding("Text", "[Region]"))
			Dim AreaLabel As New XRLabel() With {
				.Name = "AreaLabel",
				.TextFormatString = "{0:N0}",
				.BoundsF = New RectangleF(475, 0, 175, 25),
				.TextAlignment = TextAlignment.MiddleRight,
				.AnchorHorizontal = HorizontalAnchorStyles.Right
			}
			AreaLabel.ExpressionBindings.Add(New ExpressionBinding("Text", "[Area]"))
			detailBand.Controls.AddRange(New XRControl() { expandButton, regionLabel, AreaLabel })
			Return detailBand
		End Function
	End Class
End Namespace
