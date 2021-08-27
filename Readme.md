<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632455/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2326)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:


* [Form1.cs](./CS/WindowsApplication3/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication3/Form1.vb))
* [Program.cs](./CS/WindowsApplication3/Program.cs) (VB: [Program.vb](./VB/WindowsApplication3/Program.vb))
<!-- default file list end -->
# Is it possible to show group column headers in the same line? 


<p><strong>This feature is a</strong><strong>vailab</strong><strong>l</strong><strong>e</strong><strong> out-of-the-box</strong><strong> starting from version 15.</strong><strong>2.4. Use the GridView.OptionsView.ShowGroupPanelColumnsAsSingleRow property. <br></strong><br><strong>For earlier versions:<br></strong><br><br>This example demonstrates how to display group column headers in the same line, so, the group panel's height is as minimal as possible.<br>   <br> To accomplish this task, it's necessary to create a custom grid as described in the <a href="https://www.devexpress.com/Support/Center/p/A859">How to create a GridView descendant class and register it for design-time use</a> KB article. Furthermore, inherit the GridViewInfo and override its CalcGroupPanelRowDrawInfo and CalcGroupPanelHeight methods.</p>

<br/>


