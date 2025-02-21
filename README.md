# How to handle the CellTapped and CellDoubleTapped events in .NET MAUI DataGrid (SfDataGrid) ?
In this article, we will show you how to handle the CellTapped and CellDoubleTapped events in [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

## Xaml
```
<ContentPage.BindingContext>
    <local:EmployeeViewModel x:Name="viewModel" />
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="sfGrid"
                       GridLinesVisibility="Both"
                       HeaderGridLinesVisibility="Both"
                       ColumnWidthMode="Auto"
                       SelectionMode="Single"
                       AllowEditing="True"
                       CellTapped="sfGrid_CellTapped"
                       CellDoubleTapped="sfGrid_CellDoubleTapped"
                       AutoGenerateColumnsMode="None"
                       ItemsSource="{Binding Employees}">

    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridNumericColumn MappingName="EmployeeID"
                                          Format="#"
                                          HeaderText="Employee ID" />
        <syncfusion:DataGridTextColumn MappingName="Name"
                                       HeaderText="Employee Name" />
        <syncfusion:DataGridTextColumn MappingName="Title"
                                       HeaderText="Designation" />
        <syncfusion:DataGridDateColumn MappingName="HireDate"
                                       HeaderText="Hire Date" />

    </syncfusion:SfDataGrid.Columns>

</syncfusion:SfDataGrid>
```

## Xaml.cs
The code below demonstrates how to handle the CellTapped and CellDoubleTapped events in SfDataGrid.
```
private void sfGrid_CellTapped(object sender, DataGridCellTappedEventArgs e)
{
    DisplayAlert("Cell Tapped", $"Cell tap performed on row {e.RowColumnIndex.RowIndex} and column {e.RowColumnIndex.ColumnIndex}.", "OK");
}

private void sfGrid_CellDoubleTapped(object sender, DataGridCellDoubleTappedEventArgs e)
{
    DisplayAlert("Cell Double Tapped", $"Cell Double tap performed on row {e.RowColumnIndex.RowIndex} and column {e.RowColumnIndex.ColumnIndex}.", "OK");
}
```

<img src="https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM1OTA2Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.HYt0DvxvKcfkJAJ4ksCEkamNWiwovY7lvlI04a2-hJY" width=800/>

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-handle-the-CellTapped-and-CellDoubleTapped-event-in-SfDataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to handle the CellTapped and CellDoubleTapped events in SfDataGrid.
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!