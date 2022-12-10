using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace CreateHierarchicalReportInCode {
    public class ReportCreator {
        public static XtraReport CreateHierarchicalReport() {
            XtraReport report = new XtraReport() { DataSource = new CountryDataSource() };
            report.StyleSheet.AddRange(new[] {
                new XRControlStyle() { Name = "CaptionStyle", Font = new Font("Tahoma", 14f), BackColor = Color.Gray, ForeColor = Color.White },
                new XRControlStyle() { Name = "EvenStyle", BackColor = Color.LightGray }
            });
            var pageHeaderBand = CreatePageHeader();
            var detailBand = CreateDetail();
            report.Bands.AddRange(new Band[] { pageHeaderBand, detailBand });
            return report;
        }
        static PageHeaderBand CreatePageHeader() {
            PageHeaderBand pageHeaderBand = new PageHeaderBand() {
                Name = "PageHeader",
                HeightF = 40,
                StyleName = "CaptionStyle",
                Padding = new PaddingInfo(5, 5, 0, 0)
            };
            XRLabel regionCaption = new XRLabel() {
                Name = "RegionCaptionLabel",
                Text = "Region",
                BoundsF = new RectangleF(0, 0, 475, 40),
                TextAlignment = TextAlignment.MiddleLeft,
            };
            XRLabel AreaCaption = new XRLabel() {
                Name = "AreaCaptionLabel",
                Text = "Area",
                BoundsF = new RectangleF(475, 0, 175, 40),
                TextAlignment = TextAlignment.MiddleRight,
            };
            pageHeaderBand.Controls.AddRange(new XRControl[] { regionCaption, AreaCaption });
            return pageHeaderBand;
        }
        static DetailBand CreateDetail() {
            DetailBand detailBand = new DetailBand() {
                Name = "Detail",
                HeightF = 25,
                EvenStyleName = "EvenStyle",
                Padding = new PaddingInfo(5, 5, 0, 0),
                Font = new Font("Tahoma", 9f),
            };
            // Print root level nodes in bold
            detailBand.ExpressionBindings.Add(new ExpressionBinding("Font.Bold", "[DataSource.CurrentRowHierarchyLevel] == 0"));
            // Sort data on each hierarchy level by the Region field
            detailBand.SortFields.Add(new GroupField("Region", XRColumnSortOrder.Ascending));
            // Specify Id-ParentID related fields
            detailBand.HierarchyPrintOptions.KeyFieldName = "RegionID";
            detailBand.HierarchyPrintOptions.ParentFieldName = "ParentRegionID";
            // Specify the child node offset
            detailBand.HierarchyPrintOptions.Indent = 25;

            // Add an XRCheckBox control as the DetailBand's drill-down control to allow end users to collapse and expand tree nodes
            XRCheckBox expandButton = new XRCheckBox() {
                Name = "DrillDownCheckBox",
                BoundsF = new RectangleF(0, 0, 25, 25),
            };
            expandButton.ExpressionBindings.Add(new ExpressionBinding("Checked", "[ReportItems].[" + detailBand.Name + "].[DrillDownExpanded]"));
            SvgImage checkedSvg = SvgImage.FromResources("CreateHierarchicalReportInCode.Expanded.svg", typeof(ReportCreator).Assembly);
            SvgImage uncheckedSvg = SvgImage.FromResources("CreateHierarchicalReportInCode.Collapsed.svg", typeof(ReportCreator).Assembly);
            expandButton.GlyphOptions.Alignment = HorzAlignment.Center;
            expandButton.GlyphOptions.Size = new SizeF(16, 16);
            expandButton.GlyphOptions.CustomGlyphs[CheckBoxState.Checked] = new ImageSource(checkedSvg);
            expandButton.GlyphOptions.CustomGlyphs[CheckBoxState.Unchecked] = new ImageSource(uncheckedSvg);
            detailBand.DrillDownControl = expandButton;
            detailBand.DrillDownExpanded = false;

            XRLabel regionLabel = new XRLabel() {
                Name = "RegionLabel",
                BoundsF = new RectangleF(25, 0, 450, 25),
                TextAlignment = TextAlignment.MiddleLeft,
                // Anchor the label to both the left and right edges of the DetailBand so that it fits the page's width
                AnchorHorizontal = HorizontalAnchorStyles.Both
            };
            regionLabel.ExpressionBindings.Add(new ExpressionBinding("Text", "[Region]"));
            XRLabel AreaLabel = new XRLabel() {
                Name = "AreaLabel",
                TextFormatString = "{0:N0}",
                BoundsF = new RectangleF(475, 0, 175, 25),
                TextAlignment = TextAlignment.MiddleRight,
                // Anchor the label to the right edge of the DetailBand
                AnchorHorizontal = HorizontalAnchorStyles.Right
            };
            AreaLabel.ExpressionBindings.Add(new ExpressionBinding("Text", "[Area]"));
            detailBand.Controls.AddRange(new XRControl[] { expandButton, regionLabel, AreaLabel });
            return detailBand;
        }
    }
}
