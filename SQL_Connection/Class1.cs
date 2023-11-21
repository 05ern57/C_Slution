using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SQL_Connection
{
    // stage 3
    public interface IProductDal
    {
        List<Product> GetAllProducts();
        void Create(Product p);
        void Update(Product p);
        //void Delete(int ProductID); // it causes an implementation error.

        // Stage 5 
        Product GetProductById(int id);

        List<Product> Find(string productName);

        // Stage 6
        int Count();
    }
    // stage 3
    public class MsSQLProductDal : IProductDal
    {

        private SqlConnection GetSqlConnection()
        {
            // we declared the server that we are going to take information in it.
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyNorthWind;Integrated Security=SSPI;";
            // after that we give the string connect Database server.
            return new SqlConnection(connectionString);
        }

        public List<Product> GetAllProducts()
        {
            // I will store the Products that i will create later for now it will be null
            List<Product> products = null;
            using (var connection = GetSqlConnection())
            {
                try
                {
                    // we create a connection by using GetSqlConnection() Method than we opened that connection.
                    connection.Open();
                    // we specify the informations that we want from database
                    string query = "SELECT * FROM Products";
                    // we matched the query with the connection(database)
                    SqlCommand command = new SqlCommand(query, connection);
                    // reader is used for reading the data that comesback.-- ExecuteReader sends the command to the server and takes back the information.
                    SqlDataReader reader = command.ExecuteReader();
                    products = new List<Product>();// we created the CollectionList we will store the products by loop
                    // this loop will work until every row has been Readed.That's what the Read() method is used for
                    while (reader.Read())
                    {
                        products.Add(
                            // I am storing the data that i recieve from the server by using Product class
                            new Product(
                                // we have taken the data as json so we should stringfy it first
                                ProductID : int.Parse(reader["ProductID"].ToString()),
                                ProductName : reader["ProductName"].ToString(),
                                Price :double.Parse(reader["UnitPrice"].ToString())
                            )
                        );

                    }
                    // reader's work has finished we don't need it now, so I closed it.
                    reader.Close();
                    
                    return products;

                }catch (Exception ex)
                {
                    Console.WriteLine("Hataaaaaaaaaaaa ============>" + ex.Message);
                }finally { connection.Close(); }
                return products;
            }
        }

        // Stage 5
        public Product GetProductById(int productID)
        {
            Product product = null;
            using (var connection = GetSqlConnection())
            {
                try
                {
                   
                    connection.Open();
                    // SQL Injection : SQL Injection is a flaw that pirates can make a good think of for themselves. to prevent this we are not writing the query like this.
                    // string query = "SELECT * FROM Products WHERE ProductID = " + id;
                    string query = "SELECT * FROM Products WHERE ProductID = @productID;";
                    SqlCommand command = new SqlCommand(query, connection);
                    // after the query we are defining the parameter inside of the query(we can store a value also in sql),
                    // type of the parameter that we passed and , giving the value of the parameter.
                    //command.Parameters.Add("@productID", SqlDbType.Int, productID);// I get error when i try to use the function
                    command.Parameters.Add("@productID", SqlDbType.Int).Value = productID;
                    // The reason why we get an error upside we are defining a variable for sql than ve are not matching the value with variable so we get error.
                    // bu in the second line we are defining a variable than we match with the value.

                    SqlDataReader reader = command.ExecuteReader();
                    // Read() Method is not only for the loops it is for reading data 
                    reader.Read();
                    // after reading the data proccess we check if there is a data as a response.
                    if (!reader.HasRows) throw new NotImplementedException();
                    // and I figured why I've got an error before ı try to instantiate a Product it is because I was matching the values inside of the () and not in the {}.
                    product = new Product()
                    {
                        ProductID = int.Parse(reader["ProductID"].ToString()),
                        ProductName = reader["ProductName"].ToString(),
                        Price = double.Parse(reader["UnitPrice"].ToString())
                    };
                    // instead of this we aslo use this 
                    //product.ProductID = int.Parse(reader["ProductID"].ToString());
                    //product.ProductName = reader["ProductName"].ToString();
                    //product.Price = double.Parse(reader["UnitPrice"].ToString());

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hataaaaaaaaaaaa ============>" + ex.Message);
                }
                finally { connection.Close(); }
                return product;
            }
        }

        public void Create(Product p)
        {
            throw new NotImplementedException();
        }

        //public void Delete(Product p)
        //{
        //    throw new NotImplementedException(); 
        //}

        

        public void Update(Product p)
        {
            throw new NotImplementedException();
        }

        // Stage 5
        public List<Product> Find(string productName)
        {
            List<Product> products = null;
            using (var connection = GetSqlConnection())
            {
                try
                {

                    connection.Open();
                    string query = "SELECT * FROM Products WHERE ProductName LIKE '%' + @ProductName + '%';";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = productName;
                    SqlDataReader reader = command.ExecuteReader();
                    // do not forget the creating new Collection List otherwise it won't work
                    products = new List<Product>();
                    while (reader.Read())
                    {
                        products.Add(new Product()
                        {
                            ProductID = int.Parse(reader["ProductID"].ToString()),
                            ProductName = reader["ProductName"].ToString(),
                            Price = double.Parse(reader["UnitPrice"].ToString())
                        }
                        );
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hataaaaaaaaaaaa ============>" + ex.Message);
                }
                finally { connection.Close(); }
                return products;
            }
        }
    
        // Stage 6
        public int Count()
        {
            int count = 0;
            using (var connection = GetSqlConnection())
            {
                try
                {   
                    
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Products";
                    SqlCommand command = new SqlCommand(query, connection);
                    object isResponseNull = command.ExecuteScalar();
                    if (isResponseNull != null)
                    {
                        count = int.Parse(isResponseNull.ToString());
                    }                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hataaaaaaaaaaaa ============>" + ex.Message);
                }
                finally { connection.Close(); }
                
            }
            return count;
        }
    }

    // Stage 4
    public class MySQLProductDal : IProductDal
    {

        private MySqlConnection GetSqlConnection()
        {
            // we declared the server that we are going to take information in it.
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyNorthWind;Integrated Security=SSPI;";
            // after that we give the string connect Database server.
            return new MySqlConnection(connectionString);
        }

        public List<Product> GetAllProducts()
        {
            // I will store the Products that i will create later for now it will be null
            List<Product> products = null;
            using (var connection = GetSqlConnection())
            {
                try
                {
                    // we create a connection by using GetSqlConnection() Method than we opened that connection.
                    connection.Open();
                    // we specify the informations that we want from database
                    string query = "SELECT * FROM Products";
                    // we matched the query with the connection(database)
                    MySqlCommand command = new MySqlCommand(query, connection);
                    // reader is used for reading the data that comesback.-- ExecuteReader sends the command to the server and takes back the information.
                    MySqlDataReader reader = command.ExecuteReader();
                    products = new List<Product>();// we created the CollectionList we will store the products by loop
                    // this loop will work until every row has been Readed.That's what the Read() method is used for
                    while (reader.Read())
                    {
                        products.Add(
                            // I am storing the data that i recieve from the server by using Product class
                            new Product(
                                // we have taken the data as json so we should stringfy it first
                                ProductID: int.Parse(reader["ProductID"].ToString()),
                                ProductName: reader["ProductName"].ToString(),
                                Price: double.Parse(reader["UnitPrice"].ToString())
                            )
                        );

                    }
                    // reader's work has finished we don't need it now, so I closed it.
                    reader.Close();

                    return products;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hataaaaaaaaaaaa ============>" + ex.Message);
                }
                finally { connection.Close(); }
                return products;
            }
        }

        public Product GetProductById(int id)
        {
            return new Product();
        }

        public void Create(Product p)
        {
            throw new NotImplementedException();
        }

        //public void Delete(Product p)
        //{
        //    throw new NotImplementedException(); 
        //}



        public void Update(Product p)
        {
            throw new NotImplementedException();
        }

        public List<Product> Find(string productName)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }
    }


    // Stage 4

    // Dependency Injection : ProductManager is basic example of an dependency injection. In ProductManager we created an instance of an  IProductDal the reason why is 
    // we MySqlProductDal and MsSqlProductDal implements that interface so we can use one of these as _productDal and as we can see ProductManger also implements the same interface
    // so when we want to call GetAllProducts method we can take Collection List. why did we do this? because if we had to switch servers in previous stiuation we must change the code 
    // line by line but with this we will change much less codes.
    public class ProductManager : IProductDal
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public int Count()
        {
            return _productDal.Count();
        }

        public void Create(Product p)
        {
            throw new NotImplementedException();
        }

        public List<Product> Find(string productName)
        {
            return _productDal.Find(productName);
        }

        public List<Product> GetAllProducts()
        {
            return _productDal.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _productDal.GetProductById(id);
        }

        public void Update(Product p)
        {
            throw new NotImplementedException();
        }
    }

    // stage 2
    public class Product
    {
        public Product() { }
        public Product(int ProductID, string ProductName, double Price)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.Price = Price;
        }
        
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }

}
