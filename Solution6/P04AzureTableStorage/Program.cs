// See https://aka.ms/new-console-template for more information
using Azure;
using Azure.Data.Tables;


var connectionString = "DefaultEndpointsProtocol=https;AccountName=volleyball1storage1ra;AccountKey=Jo2wBaraoaHJXuu3R+ak3qYYJdZvDdrvbtsIocWwDXOqcULv6unmPm2rPWO+/++FBPrEhUcjMML2+AStPPFrFw==;EndpointSuffix=core.windows.net";


string tableName = "Persons";


var tableClient = new TableClient(connectionString, tableName);


// Create a table in your storage account
await tableClient.CreateIfNotExistsAsync();
// Insert an entity into the table
var entity = new TableEntity("volleyball", "player4")
{
{ "name", "juzef" },
{ "secondName", "traczyk" },
{ "secondName", "traczyk" },
{ "country", "bulanda" },
{ "heigth", "166" },
{ "weigth", "66.6" },
{ "birthDay", "2013-12-13" },
};
await tableClient.AddEntityAsync(entity);
Console.WriteLine("Entity added to the table.");
//// Query entities from the table
//string partitionKeyFilter = $"PartitionKey eq '{entity.PartitionKey}'";
//await foreach (var e in tableClient.QueryAsync<TableEntity>(partitionKeyFilter))
//{
//// another method is needed for another data type than string, i.e GetDateTime()
//    Console.WriteLine($"PartitionKey: {e.PartitionKey}, RowKey: {e.RowKey}," +
//        $"Property1: { e.GetString("Property1")}, Property2: { e.GetString("Property2")}");
//}
//// Update an entity in the table
//var entity = new TableEntity("volleyball", "player4")
//entity["country"] = "jamaica";
//await tableClient.UpdateEntityAsync(entity, ETag.All);
//Console.WriteLine("Entity updated in the table.");
//// Delete an entity from the table
//await tableClient.DeleteEntityAsync(entity.PartitionKey, entity.RowKey);
//Console.WriteLine("Entity deleted from the table.");