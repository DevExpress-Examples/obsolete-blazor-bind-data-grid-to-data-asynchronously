# How to bind the Data Grid to a strongly typed collection loaded asynchronously

This example consists of the following pages:
* [Data Property](./CS/DataBindingSamples/Pages/DataProperty.razor) - Assigns a strongly typed collection to the [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.Data) property and uses an asynchronous task to initialize the collection. In this case, the Data Grid page is rendered twice.
* [DataAsync Property](./CS/DataBindingSamples/Pages/DataAsyncProperty.razor) - Uses the [DataAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.DataAsync) property to load a strongly typed collection asynchronously. Specifies a key data field to identify a data source instance.
* [DataAsync: Cancellation Token](./CS/DataBindingSamples/Pages/DataAsyncProperty.CancellationToken.razor) - Uses the [DataAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.DataAsync) property to load a data collection asynchronously and processes a cancellation token to prevent further execution for the already disposed Data Grid.
* [DataAsync: Cache](./CS/DataBindingSamples/Pages/DataAsyncProperty.Cache.razor) - Caches the [DataAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.DataAsync) function. This is helpful if the function is time- or resource-consuming.

For more information, refer to the following help topic: [Bind to Data Asynchronously](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1#bind-to-data-asynchronously).


