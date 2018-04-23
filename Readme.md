# Is it possible to show group column headers in the same line? 


<p><strong>This feature is a</strong><strong>vailab</strong><strong>l</strong><strong>e</strong><strong> out-of-the-box</strong><strong> starting from version 15.</strong><strong>2.4. Use the GridView.OptionsView.ShowGroupPanelColumnsAsSingleRow property. <br></strong><br><strong>For earlier versions:<br></strong><br><br>This example demonstrates how to display group column headers in the same line, so, the group panel's height is as minimal as possible.<br>   <br> To accomplish this task, it's necessary to create a custom grid as described in the <a href="https://www.devexpress.com/Support/Center/p/A859">How to create a GridView descendant class and register it for design-time use</a> KB article. Furthermore, inherit the GridViewInfo and override its CalcGroupPanelRowDrawInfo and CalcGroupPanelHeight methods.</p>

<br/>


