# How to bind the Data Grid to a data source asynchronously

This example consists of the following pages:
* [Data Property](./CS/DataBindingSamples/Pages/DataProperty.razor) - Assigns a data source to the [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.Data) property and uses an asynchronous task to load data. In this case, the Data Grid page is rendered twice.
* [DataAsync: Cache Data](./CS/DataBindingSamples/Pages/DataAsyncProperty.Cache.razor) - Uses the [DataAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.DataAsync) property to load a data source asynchronously. Caches a data source instance to prevent excessive data extraction and keep the same item references during the page's entire life cycle.
*	[DataAsync: KeyFieldName](./CS/DataBindingSamples/Pages/DataAsyncProperty.KeyFieldName.razor) - Uses the [DataAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.DataAsync) property to load a data source asynchronously. Specifies a key data source field to identify a data source instance.
*	[DataAsync: Cancellation Token](./CS/DataBindingSamples/Pages/DataAsyncProperty.CancellationToken.razor) - Uses the [DataAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.DataAsync) property to load a data source asynchronously and processes a cancellation token to prevent further execution for the already disposed Data Grid.

For more information, refer to the following help topic: [Bind to Data Asynchronously](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1#bind-to-data-asynchronously).


