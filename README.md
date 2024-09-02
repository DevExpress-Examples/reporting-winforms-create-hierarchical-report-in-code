<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/192323273/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828674)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for WinForms - How to create a Hierarchical Report in Code

![Hierarchical Report](Images/HierarchicalReport.png)


## Implementation Details

Do the following to create a hierarchical report in code:

### Bind Report to Data

You can print a report in tree mode if it is bound to recursive data or data with ID-ParentID related fields. In this example, data records are defined by the **CountryData** class.

### Specify Hierarchy Print Options

Specify either the [HierarchyPrintOptions.ChildListFieldName](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.HierarchyPrintOptions.ChildListFieldName) property (for recursive data) or the [HierarchyPrintOptions.KeyFieldName](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.HierarchyPrintOptions.KeyFieldName)-[HierarchyPrintOptions.ParentFieldName](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.HierarchyPrintOptions.ParentFieldName) property pair (for ID-ParentID related data fields, like in this example) to print the report's [DetailBand](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.DetailBand).

Specify the [HierarchyPrintOptions.Indent](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.HierarchyPrintOptions.Indent) property to set the child node offset, in [report units](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.ReportUnit).

### Align Tree Nodes

In this example, the [AnchorHorizontal](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRControl.AnchorHorizontal) property of the DetailBand's labels is set to *Both*. This allows the labels to fit the page. See the [HierarchyPrintOptions](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.HierarchyPrintOptions) class description for details.

### Add a Control to Expand/Collapse Tree Nodes

Do the following to allow end users to expand and collapse tree nodes:

1. Add the [XRCheckBox](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRCheckBox) control to the DetailBand at the left-most position.
	In this example, the checkbox' [GlyphOptions](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRCheckBox.GlyphOptions) property is used to specify custom glyphs for the *checked* and *unchecked* states.
	
2. Set the DetailBand's [DrillDownControl](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.DetailBand.DrillDownControl) property to the added XRCheckBox control.

3. Set the XRCheckBox's [CheckState](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRCheckBox.CheckState) property to the following expression: [ReportItems].[Detail].[DrillDownExpanded] 

### Sort Report Data

In this example, the DetailBand's [SortFields](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.DetailBand.SortFields) property is specified to sort data on each hierarchy level.

### Highlight Root Nodes

When the **CurrentRowHierarchyLevel** variable in [expressions](https://docs.devexpress.com/XtraReports/120104/detailed-guide-to-devexpress-reporting/use-expressions/expression-constants-operators-and-functions#variables-for-event-related-expressions) to get a row's zero-based level in the tree. In this example, this variable is used in the DetailBand's expression to set the background color for the top-level nodes.

## Files to Review

- [CountryData.cs](./CS/Data/CountryData.cs)
- [CountryDataSource.cs](./CS/Data/CountryDataSource.cs)
- [ReportCreator.cs](./CS/ReportCreator.cs)


## Documentation

- Create a Hierarchical Report](https://docs.devexpress.com/XtraReports/400925/create-popular-reports/create-a-hierarchical-report)







<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-create-hierarchical-report-in-code&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-create-hierarchical-report-in-code&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
