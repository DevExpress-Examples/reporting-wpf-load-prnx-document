<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128601783/23.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4713)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for WPF - How to load a DevExpress Reporting Document (PRNX) to the Document Preview

This example illustrates how to preview a DevExpress Report document (*.PRNX) using the [WPF Document Viewer](https://docs.devexpress.com/XtraReports/15016/wpf-reporting/document-preview).

The [Document Preview Control](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.DocumentPreviewControl) supports the following document sources:

* [DevExpress Reports](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport).
* DevExpress Report Documents: [Store Report Documents](https://docs.devexpress.com/XtraReports/5157/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/store-report-layouts-and-documents/store-report-documents?p=netframework). It can be:
  * A stream containing report document data: [Saving Documents to a Stream](https://docs.devexpress.com/XtraReports/4811/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/store-report-layouts-and-documents/save-and-open-report-documents?p=netframework#stream);
  * A string containing a path to a PRNX file which stores report document data: [Saving Documents to a File](https://docs.devexpress.com/XtraReports/4811/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/store-report-layouts-and-documents/save-and-open-report-documents?p=netframework#file).
* An object implementing the [ILink](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.ILink) interface: [WPF Controls | Printing Links](https://docs.devexpress.com/WPF/9696/controls-and-libraries/printing-exporting/concepts/printing-links).

## Example Overview

To preview a document:
* Generate a document from a report by calling the [`PrintingSystemBase.SaveDocument`](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.SaveDocument.overloads) method:
```
private void button1_Click(object sender, System.EventArgs e) {
    // Create a report instance. 
    XtraReport1 report = new XtraReport1();

    // Generate a complete report document.
    report.CreateDocument();

    // Save the document to a file. 
    report.PrintingSystem.SaveDocument(@"...\Invoice.prnx");
}
```
* Assign a path to the resulting document or a stream with document data to the [`DocumentViewerControl.DocumentSource`](https://docs.devexpress.com/WPF/DevExpress.Xpf.DocumentViewer.DocumentViewerControl.DocumentSource) property at runtime:
```
documentPreview.DocumentSource = @"...\Invoice.prnx";
```

## Files to Review

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-load-prnx-document&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-load-prnx-document&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
