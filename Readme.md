<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication1/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication1/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication1/MainWindow.xaml.vb))
<!-- default file list end -->
# How to load a DevExpress Reporting Document (PRNX) to the Document Preview in WPF
## Overview
This example illustrates how to preview a DevExpress Report document (*.PRNX) using the [WPF Document Viewer](https://docs.devexpress.com/XtraReports/15016/wpf-reporting/document-preview).

The [Document Preview Control](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.DocumentPreviewControl) supports the following document sources:

* [DevExpress Reports](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport).
* DevExpress Report Documents: [Store Report Documents](https://docs.devexpress.com/XtraReports/5157/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/store-report-layouts-and-documents/store-report-documents?p=netframework). It can be:
  * A stream containing report document data: [Saving Documents to a Stream](https://docs.devexpress.com/XtraReports/4811/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/store-report-layouts-and-documents/save-and-open-report-documents?p=netframework#stream);
  * A string containing a path to a PRNX file which stores report document data: [Saving Documents to a File](https://docs.devexpress.com/XtraReports/4811/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/store-report-layouts-and-documents/save-and-open-report-documents?p=netframework#file).
* An object implementing the [ILink](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.ILink) interface: [WPF Controls | Printing Links](https://docs.devexpress.com/WPF/9696/controls-and-libraries/printing-exporting/concepts/printing-links).

## Main steps
To preview a document:
* Generate a document from a report by calling the the [PrintingSystemBase.SaveDocument](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.SaveDocument.overloads) method:
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
* Assign a path to the resulting document or a stream with document data to the [DocumentViewerControl.DocumentSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.DocumentViewer.DocumentViewerControl.DocumentSource) property at runtime:
```
documentPreview.DocumentSource = @"...\Invoice.prnx";
```






