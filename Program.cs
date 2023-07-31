using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.BL;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //  >>>>  List of name USERS  and DataType User that is a class 
            List<mUser> users = new List<mUser>();

            //List of Products
            List<Product> products = new List<Product>();

            // file for user Data
            string path = "textfile.txt";
           // File for product data
            string productsPath = "E:\\OOPlab\\missClient\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\products.txt";
            readData(path, users);

               bool check = readProductData(productsPath, products);

            //fuction to read Car DATA B4 fuction exection



            if (check)
               {
                   Console.WriteLine("Data Loaded Successfully");

               }
               else
               Console.WriteLine("Data not Loaded");
               Console.ReadKey();
            


            Console.Clear();

            int option = 0;
            do
            {

                option = Menu();
               // Console.Clear();
                if (option == 1)
                {
                    mUser user = takeInputWithoutRole();

                    if (user != null)
                    {
                        user = signIn(user, users);
                        if (user == null)
                        {
                            Console.WriteLine("Invalid User");

                        }
                        else if (user.isAdmin())
                        {
                            int value = AdminMenu();
                            if (value == 1)
                            {

                                Product p = addProducts();
                                 

                            }
                            if (value == 2)
                            {
                                //  viewProducts(products,p);
                                viewProducts(products);

                            }
                            if (value == 3)
                            {

                            }
                            if (value == 4)
                            {

                            }
                            if (value == 5)
                            {

                            }
                        }
                        else if (user.isCostumer())
                        {
                            int value = costumerMenu();


                            if (value == 1)
                            {
                                buyProducts(products);
                            }
                            if (value == 2)
                            {
                                viewProducts(products);
                            }
                            if (value == 3)
                            {
                                generateBill();
                            }
                        }
                    }
                }
                else if (option == 2)
                {
                    mUser user = takeInputWithRole();

                    bool flag = true;
                    for (int i = 0; i <= users.Count; i++)
                    {

                        if (user != null || user.name != users[i].name)
                        {

                            i++;
                            flag = false;
                        }
                        if (user == null)
                        {
                            Console.WriteLine(">>>>>------ Invalid Input!! TRY AGAIN ------<<<<<");
                        }
                    }
                    if (flag == false)
                    {
                        storeUserDataInFile(path, user);
                        storeUserDataInList(users, user);
                        Console.WriteLine(">>>>----- USER Created Successfully :)");
                        Console.WriteLine();
                        Console.WriteLine("You Can SIgnIn");
                    }

                }

            }
            while (option != 3);
            Console.ReadKey();
           
        }
        static int Menu()
        {
            Console.Clear();
            int option;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Sign In ");
            Console.WriteLine("2. Sign UP");
            Console.WriteLine("3. EXIT");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter your option :");
            option = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;

            return option;

        }
        static mUser takeInputWithoutRole()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" :) Welcome Back !!!  (:");
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            if (name != null && password != null)
            {
                mUser users = new mUser(name, password);
                return users;

            }
            return null;
        }
        static mUser takeInputWithRole()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------>>>>   WellCome New User   <<<<<-----");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter New password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Password Again :");
            string secondPassword = Console.ReadLine();
            Console.WriteLine("Enter Your Role: ");
            string role = Console.ReadLine();

            if (name != null && password != null && role != null && password == secondPassword)
            {
                mUser users = new mUser(name, password, role);
                return users;

            }

            return null;
        }
        static mUser signIn(mUser user, List<mUser> users)
        {
            foreach (mUser storedUser in users)
            {
                if (user.name == storedUser.name && user.password == storedUser.password)
                {
                    return storedUser;
                }

            }
            return null;
        }
        static  int AdminMenu()

        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" 1.Add Product.");
            Console.WriteLine(" 2.View All Products.");
            Console.WriteLine(" 3.Find Product with Highest Unit Price.");
            Console.WriteLine(" 4.View Sales Tax of All Products.");
            Console.WriteLine(" 5.Products to be Ordered. (less than threshold)");
            Console.WriteLine(" 6.Exit");
           int option = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;

            return option;
        }
        static int costumerMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1.View all the products");
            Console.WriteLine("2.Buy the products");
            Console.WriteLine("3.Generate invoice");
            Console.WriteLine("4.Exit");
            int option = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;

            return option;
        }
        static bool readData(string path, List<mUser> users)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string name = parseData(record, 1);
                    string password = parseData(record, 2);
                    string role = parseData(record, 3);
                    mUser user = new mUser(name, password, role);
                    storeUserDataInList(users, user);

                }
                fileVariable.Close();
                return true;

            }
            return false;
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];

                }


            }
            return item;

        }
        static void storeUserDataInList(List<mUser> users, mUser user)
        {
            users.Add(user);
        }
        static void storeProductDataInList(List<Product> products, Product p)
        {
            products.Add(p);
        }
        static void storeUserDataInFile(string path, mUser user)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.name + "," + user.password + "," + user.role);
            file.Flush();
            file.Close();
        }
       
        static Product addProducts()
        {
            Console.WriteLine("Enter the name of Product : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Category of Product :");
            string category = Console.ReadLine();
            Console.WriteLine("Enter the Price : ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the  AvailableStock Quantity : ");
            float availabeStock = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Stock Threshold Quantity : ");
            float thresholdQuantity = float.Parse(Console.ReadLine());

            Product p = new Product(name, category, price, availabeStock, thresholdQuantity);

            return p;
               
        }
        static bool readProductData(string productPath,List<Product> products)
        {
            if (File.Exists(productPath))
            {
                StreamReader fileVariable = new StreamReader(productPath);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string pName = parseData(record, 1);
                    string category = parseData(record, 2);
                    double price = double.Parse(parseData(record, 3));
                    float avStockQuantity = float.Parse(parseData(record, 4));
                    float minStockThreshold = float.Parse(parseData(record, 5));

                    Product p = new Product(pName, category, price, avStockQuantity, minStockThreshold);
                    storeProductDataInList(products,p);

                }
                fileVariable.Close();
                return true;

            }
            return false;
        }
        static void viewProducts(List<Product> products)
        {
            Console.WriteLine("Name\tCategory\tPrice\tAvailableStock\tMinimumStockQuantity");
            foreach (Product s in products)
            {
               
                    Console.WriteLine(s.pname + "\t" + s.pcategory + "\t" + s.pPrice + "\t" + s.availableStockQuantity + "\t" + s.minimunStockThreshold);
                
            }
            Console.WriteLine("Hell0 PRincess ");
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();


        }
        static void generateBill()
        {

        }
        static Costumer buyProduct(List<Product> products, Product p)
        {
            Console.WriteLine("Enter the name of product YOu want to buy : ");
            string pname = Console.ReadLine();

            bool check = checkIfProductIsAvailable(products);
            if(check)
            {
                removeProductFromList(products,p);
            }
            else
            {
                Console.WriteLine("INVALID PRODUCT !!");
            }
            return null;
        }
        static bool checkIfProductIsAvailable(List<Product> products)
        {
            int i = 0;
            bool flag = false;
            foreach(Product p in products)
            {
                if(p.pname == products[i].pname )
                {
                    flag = true;
                    return flag;
                    
                }
                i++;
            }
            return flag;
            
        }
        static void removeProductFromList(List<Product> products,Product p)
        {
            products.Remove(p);
        }

    }
}


