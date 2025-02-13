// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//var x = "ahmed";

//if (x!=null)
//{

//}

//x="mazen";



using Data;
using Data.Models.Customers;
using Data.ViewModels;
using LINQ_Course.Extensions;
using System.Linq;


namespace Home
{
    public class Program
    {

        public static bool checkcustomer(Customer customer)
        {
            if (customer != null && customer.age>30 && customer.isActive)
            {
                return true;
            }
            return false;
        }

        public static void Main(string[] args)
        {
            //var ahmedlist = Filter.GetAhmed(Database.GetCustomers());


            // program with extension method
            #region
            //Console.WriteLine("Enter The Name You Search About");

            //var inputname = Console.ReadLine();

            //if (inputname == null || inputname=="")
            //{

            //    Console.WriteLine("invalid Name");

            //}

            //Console.WriteLine("Enter The Age You Search About");

            //var age = int.Parse(Console.ReadLine());

            //if(age<=0)
            //{
            //    Console.WriteLine("invalid age");

            //}



            //else
            //{
            //    var nameslist = Database.GetCustomers().GetName(inputname,age);

            //    if (nameslist!=null && nameslist.Any())
            //    {

            //        foreach (var ahmed in nameslist)
            //        {
            //            Console.WriteLine($"name : {ahmed.name} , age : {ahmed.age} , telephone: {ahmed.telephone}");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("No Person Found With This Name");
            //    }
            //}
            #endregion




            // without extension method
            #region
            //var nameslist = Filter.GetAhmed();

            //if (nameslist!=null && nameslist.Any())
            //{

            //    foreach (var ahmed in nameslist)
            //    {
            //        Console.WriteLine($"name : {ahmed.name} , age : {ahmed.age} , telephone: {ahmed.telephone}");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("No Person Found With This Name");
            //}

            #endregion







            // where linq
            #region
            //var ahmedlist = Database.GetCustomers().Where(w=>w.name=="ahmed");


            //foreach(var ah in ahmedlist)
            //{
            //    Console.WriteLine($"name : {ah.name} , age : {ah.age} , telephone: {ah.telephone}");
            //}
            #endregion


            //with function and extension method
            #region
            //var customers = Database.GetCustomers().GetData(checkcustomer);


            //foreach (var customer in customers) {

            //    Console.WriteLine($"name : {customer.name} , age : {customer.age} , telephone: {customer.telephone}");

            //}
            #endregion


            // with lamda expression
            #region
            //var customers = Database.GetCustomers().GetData(c=>c!=null&&c.age>30&&c.isActive);


            //foreach (var customer in customers)
            //{

            //    Console.WriteLine($"name : {customer.name} , age : {customer.age} , telephone: {customer.telephone}");

            //}

            #endregion



            // IEnumerable Syntax
            #region
            //List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<string> stringList = new List<string>
            // { "ahmed mohamady", "mohamed ahmed", "mo salah", "sayd ahmed" };



            ////var result = myList.Where(l => l>6).ToList();

            ////foreach (var item in result) { 
            ////    Console.WriteLine(item);
            ////}

            //var stringresult = stringList.Where(s=>s.Contains("ahmed"));

            ////using tolist() is to make save the data of list in memory and not to be edited or deleted from it 


            //stringList.Remove("mohamed ahmed");

            //stringList.AddRange(new string[] { "saeed salah", "ahmed morad", "ahmed ahmed" });



            //foreach (var item in stringresult)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            // Query Syntax
            #region
            //    var result = from l in myList
            //             where l >7
            //             select l;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //var stringresult = from l in stringList
            //                   where l.Contains("s")
            //                   select l;

            //foreach (var item in stringresult)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion



            //select method
            #region

            //var customers = Database.GetCustomers().Select(
            //    w => new
            //    {
            //        customer_name=w.name,
            //        customer_age=w.age,
            //        customer_phone=w.telephone
            //    }
            //    ).Where(a=>a.customer_age>=30).ToList();

            //var customers = Database.GetCustomers().Where(a => a.age>=30).Select(
            //    w => new
            //    {
            //        customer_name = w.name,
            //        customer_phone = w.telephone
            //    }
            //    ).ToList();

            //indexed where 
            //var customers = Database.GetCustomers().Where((a,i) => a.age>=30&&i>=3).Select(
            //    w => new CustomerViewModel
            //    {
            //        customer_name = w.name,
            //        customer_phone = w.telephone
            //    }
            //    ).ToList();


            //var customers = from customer in Database.GetCustomers()
            //                where customer.age > 30
            //                select new CustomerViewModel
            //                {
            //                    customer_name = customer.name,
            //                    customer_phone = customer.telephone
            //                };


            //var customers = from customer in Database.GetCustomers()
            //                select new
            //                {
            //                    customer_name = customer.name,
            //                    customer_phone = customer.telephone,
            //                    customer_age = customer.age,
            //                }
            //                into c
            //                where c.customer_age>30
            //                select c;








            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer);
            //}

            #endregion


            // ordering queries
            #region

            //var customers = Database.GetCustomers().OrderByDescending(x => x.joinDate).ThenBy(x => x.id);

            //var customers = from o in Database.GetCustomers()
            //                orderby o.joinDate descending, o.id ascending
            //                select o;


            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer.joinDate+"  "+customer.id+"  "+customer.name+"    "+customer.age);
            //}

            #endregion


            // LINQ Immediate execution methods (First,Last,First or Default,Last or Default)
            #region

            //var customer = Database.GetCustomers().OrderBy(x => x.joinDate).ThenByDescending(x => x.id).First();

            //var customer = (from o in Database.GetCustomers()
            //                orderby o.joinDate , o.id descending
            //                select o).First();

            //var customer =  Database.GetCustomers().OrderBy(x=>x.id).First(x=>x.age>35);

            //var customer = Database.GetCustomers().OrderBy(x => x.joinDate).ThenByDescending(x => x.id).Last();


            //var customer = (from o in Database.GetCustomers()
            //                orderby o.joinDate, o.id descending
            //                select o).Last();






            //Console.WriteLine(customer.name);


            // First 

            //try
            //{
            //    var order = Database.GetOrders().First();

            //    if (order!=null)
            //    {
            //        Console.WriteLine(order.total);
            //    }
            //}
            //catch (Exception ex) { 
            //    Console.WriteLine(ex.Message);
            //}


            // First or Default

            //var order = Database.GetOrders().FirstOrDefault();

            //if (order != null)
            //{
            //    Console.WriteLine(order.total);
            //}


            #endregion


            //some LINQ Opreators
            #region

            //var customer = Database.GetCustomers().ElementAt(700);

            //var customer = Database.GetCustomers().ElementAtOrDefault(700);


            //var customer = Database.GetCustomers().Single(x=>x.age==32);

            //var customer = Database.GetCustomers().SingleOrDefault(x=>x.age==30);

            //if (customer != null)
            //{
            //    Console.WriteLine(customer.name);
            //}



            //if (customer != null) {
            //    Console.WriteLine(customer.name);
            //}
            //else
            //{
            //    Console.WriteLine("No Data Found");
            //}


            //var customerscount=Database.GetCustomers().Count();

            //var customerscount = Database.GetCustomers().Count(x=>x.age>30);


            //var customersmax = Database.GetCustomers().Max(x=>x.age);

            //var customersmax = Database.GetCustomers().Max();

            //var customeraverage = Database.GetCustomers().Average(x => x.spendAverage);

            //Console.WriteLine(Math.Round(customeraverage,2));


            //var customersum = Database.GetCustomers().Sum(x => x.spendAverage);

            //Console.WriteLine(customersum);


            #endregion


            // Using JOIN Operator in inner relationship
            #region

            // one to many relation ( Method Syntax ) 

            // var categories = Database.GetCategories();
            //var customers = Database.GetCustomers();

            //var result = categories.Join
            //    (
            //    customers
            //    , cat=>cat.Id
            //    , cust => cust.categoryId
            //    , (categories,customers) => new
            //    {
            //        fullname = customers.name,
            //        categoryname = categories.Name,
            //    }

            //);


            //foreach (var item in result) {
            //    Console.WriteLine(item);
            //}



            // one to many relation ( Query Syntax ) 

            //var result = from cat in categories
            //             join cust in customers
            //             on cat.Id equals cust.categoryId
            //             select new
            //             {
            //                 fullname = cust.name,
            //                 categoryname = cat.Name,
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            //Left or right outer join query in Linq
            #region

            //var categories = Database.GetCategories();
            //var customers = Database.GetCustomers();

            // Method Syntax 

            // left join

            //var result = categories.GroupJoin
            //    (
            //    customers
            //    , cat => cat.Id
            //    , cust => cust.categoryId
            //    , (categories, customers) => new
            //    {
            //        Customers = customers,
            //        categoryname = categories.Name,
            //    }

            //);


            //foreach (var item in result)
            //{
            //    Console.WriteLine("----------------------------------------------------------------------");
            //    Console.WriteLine(item.categoryname);
            //    Console.WriteLine("----------------------------------------------------------------------");

            //    if (item.Customers!=null)
            //    {
            //        foreach(var customer in item.Customers)
            //        {
            //            Console.WriteLine(customer.name);
            //        }
            //    }

            //}


            // right join

            //var result = customers.GroupJoin(categories, cust => cust.categoryId, cat => cat.Id, (customers, categories) => new
            //{
            //    Mycategories= categories,
            //    customername= customers.name,
            //});

            //foreach (var item in result) {
            //    Console.WriteLine("----------------------------------------------------------------------");
            //    Console.WriteLine(item.customername);


            //    if (item.Mycategories != null)
            //    {
            //        foreach (var category in item.Mycategories)
            //        {
            //            Console.WriteLine(category.Name);
            //        }
            //    }


            //}


            // Query Syntax

            // ( Left Join)

            //var result = from cat in categories
            //             join cust in customers
            //             on cat.Id equals cust.categoryId
            //             into mycustomers
            //             select new
            //             {
            //                 MyCustomers = mycustomers,
            //                 categoryname = cat.Name,
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine("----------------------------------------------------------------------");
            //    Console.WriteLine(item.categoryname);
            //    Console.WriteLine("----------------------------------------------------------------------");

            //    if (item.MyCustomers!=null)
            //    {
            //        foreach (var customer in item.MyCustomers)
            //        {
            //            Console.WriteLine(customer.name);
            //        }
            //    }

            //}


            // (Right Join)

            //  var result = from cust in customers
            //               join cat in categories
            //               on cust.categoryId equals cat.Id
            //               into mycategories
            //               select new
            //               {
            //                   Categories = mycategories,
            //                   Customer = cust.name
            //               };

            //foreach (var item in result)
            //  {
            //      Console.WriteLine("----------------------------------------------------------------------");
            //      Console.WriteLine(item.Customer);


            //      if (item.Categories != null)
            //      {
            //          foreach (var category in item.Categories)
            //          {
            //              Console.WriteLine(category.Name);
            //          }
            //      }


            //  }


            #endregion


            //GroupBy & ToLookup Linq Operators
            #region
            //var customers= Database.GetCustomers();
            //var categories = Database.GetCategories();

            //Method Syntax (Groupby and lookup)

            //var result1 = customers.GroupBy(c=>c.categoryId).ToList(); // Deffered 
            //var result2 = customers.ToLookup(c=>c.categoryId).ToList(); // immediate

            //foreach (var category in result) {
            //    Console.WriteLine("Category Key "+category.Key);
            //    foreach (var customer in category) { 
            //        Console.WriteLine("Name : "+" "+customer.name);
            //    }
            //}


            //Query Syntax (Groupby and lookup)

            //var result1 = from c in customers
            //             group c by c.categoryId;

            //var result2 = (
            //    from c in customers
            //    select c
            //    ).ToLookup(c=>c.categoryId);

            //foreach (var category in result)
            //{
            //    Console.WriteLine("Category Key "+category.Key);
            //    foreach (var customer in category)
            //    {
            //        Console.WriteLine("Name : "+" "+customer.name);
            //    }
            //}






            #endregion


            // Generator operators in Linq
            #region

            //var r = Enumerable.Range(1, 1000);

            //var e = Enumerable.Empty<Customer>();

            //var rep = Enumerable.Repeat(100, 4);

            //var cust = Database.GetCustomers().FirstOrDefault();
            //var rep2 = Enumerable.Repeat(cust, 4);

            ////====================================

            //List<string> names = new List<string>()
            //{ "Ahmed Moahamdy", "Mohamed Salah", "alaa khaled"};

            //var sm = names.SelectMany(element => element.Split(' '));

            //foreach (var name in sm)
            //    Console.WriteLine(name);

            //var smq = from n in names
            //          from ns in n.Split(" ")
            //          select ns;

            //foreach (var name in smq)
            //    Console.WriteLine(name);



            #endregion


















































        }







    }
    
}