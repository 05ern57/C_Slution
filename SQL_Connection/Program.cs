using System.Data.SqlClient;
using SQL_Connection;
using System.Collections.Generic;
using System.Net.Http.Headers;




// To Connect SQL Server
//static SqlConnection GetSqlConnection ()
//{
//    string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyNorthWind;Integrated Security=SSPI;";

//    return new SqlConnection(connectionString);
//    // we need driver-provider to connect to database

//    return new SqlConnection(connectionString);

//}

// Stage 1
//static void GetAllProducts()
//{
//    using (var connection = GetSqlConnection())
//    {
//        try// Stage 2
//        {
//            connection.Open();
//            Console.WriteLine("Bağlantı Sağlandı.");

//            string sql = "SELECT * FROM Products";

//            // whenever we try to make this transaction in MySQL we can simply add My at the beginning.
//            SqlCommand command = new SqlCommand(sql, connection);
//            // I am simply just have connected to SQL Server than i created a query and by using SqlCommand specify the server that I will execute the sql query.

//            // we created a data reader object. with reader we read the data response
//            SqlDataReader reader = command.ExecuteReader();

//            // we read the every row with Read() function.
//            while (reader.Read())
//            {
//                Console.WriteLine($"Name : {reader[1]}                      Price : {reader[5]}"); 
//            }


//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Hataaaaaaaaaaaaa    ====>   " + ex.Message);
//        }
//        finally { connection.Close(); }
//    }
//}


// Stage 2
//static List<Product> GetAllProducts()
//{
//    List<Product> products = null;
//    using (var connection = GetSqlConnection())
//    {
//        try
//        {
//            connection.Open();
//            Console.WriteLine("Bağlantı Sağlandı.");

//            string sql = "SELECT * FROM Products";

//            // whenever we try to make this transaction in MySQL we can simply add My at the beginning.
//            SqlCommand command = new SqlCommand(sql, connection);
//            // I am simply just have connected to SQL Server than i created a query and by using SqlCommand specify the server that I will execute the sql query.

//            // we created a data reader object. with reader we read the data response
//            SqlDataReader reader = command.ExecuteReader();

//            // we created a collection list

//            products = new List<Product> ();

//            while (reader.Read())
//            {
//                products.Add(new Product { 
//                    ProductID = int.Parse(reader[0]?.ToString()), 
//                    ProductName = reader[1]?.ToString(),
//                    Price = double.Parse(reader[5]?.ToString())
//                });
//            }

//            return products;

//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Hataaaaaaaaaaaaa    ====>   " + ex.Message);
//        }
//        finally { connection.Close(); }
//        return products;
//    }
//}

//var products =  GetAllProducts();
//foreach (var i in products)
//{
//    Console.WriteLine($@"
//ProductID: {i.ProductID}
//ProductName: {i.ProductName}
//Price: {i.Price}
//------------------------------------
//");
//}


//stage 3

//var productDal = new MsSQLProductDal();
//var products = productDal.GetAllProducts();

IProductDal productManager = new ProductManager(new MsSQLProductDal());
//var products = productManager.GetAllProducts();

//foreach (var i in products)
//{
//    Console.WriteLine($@"
//ProductID: {i.ProductID}
//ProductName: {i.ProductName}
//Price: {i.Price}
//------------------------------------
//");
//}



// Stage 5 
//var product = productManager.GetProductById(3);


//Console.WriteLine($@"
//ProductID: {product.ProductID}
//ProductName: {product.ProductName}
//Price: {product.Price}
//------------------------------------
//");

//var products = productManager.Find("chai");

//foreach (var i in products)
//{
//    Console.WriteLine($@"
//ProductID: {i.ProductID}
//ProductName: {i.ProductName}
//Price: {i.Price}
//------------------------------------
//");
//}

//Console.WriteLine("-------------------------------");

//var products2 = productManager.Find("c");

//foreach (var i in products2)
//{
//    Console.WriteLine($@"
//ProductID: {i.ProductID}
//ProductName: {i.ProductName}
//Price: {i.Price}
//------------------------------------
//");
//}

// Stage 6 
int count = productManager.Count();

Console.WriteLine($@"Total products: {count}");