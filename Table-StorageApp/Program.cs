using Azure;
using Azure.Data.Tables;

string connectionString = "";
string tableName = "Orders";

/* Adding Entity to Table Storage */

//AddEntity("01", "Mobile", 123);
//AddEntity("02", "Laptop", 23);
//AddEntity("03", "Desktop", 123);
//AddEntity("04", "Laptop", 13);
//AddEntity("05", "Mobile", 33);

//void AddEntity(string orderID, string category, int quantity)
//{
//    TableClient tableClient = new TableClient(connectionString, tableName);

//    TableEntity tableEntity = new TableEntity(category, orderID)
//    {
//        {"quantity", quantity }
//    };
//    tableClient.AddEntity(tableEntity);
//    Console.WriteLine("Added Entity order id {0}", orderID);
//}

/* Reading Entities from Table*/

//QueryEntity("Laptop");

//void QueryEntity(string category)
//{
//    TableClient tableClient = new TableClient(connectionString, tableName);

//    Pageable<TableEntity> results= tableClient.Query<TableEntity>(entity => entity.PartitionKey == category);
//    foreach (TableEntity tableEntity in results)
//    {
//        Console.WriteLine("Order id {0}", tableEntity.RowKey);
//        Console.WriteLine("Quantity is {0}", tableEntity.GetInt32("quantity"));
//    }
//}

/* Deleting Entities from Table */

//DeleteEntity("Laptop", "02");

//void DeleteEntity(string category, string orderID)
//{
//    TableClient tableClient = new TableClient(connectionString, tableName);
//    tableClient.DeleteEntity(category, orderID);

//    Console.WriteLine("Deleted Order id is {0}", orderID);

//}
