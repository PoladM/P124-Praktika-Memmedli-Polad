using System;

namespace HomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 6
            //Car car = new Car("BMW", "x5", 10, 100, "2015");
            //car.AddFuel(10);
            //car.Drive(140);
            //car.AddFuel(20);
            //car.ShowInfo();
            #endregion
            #region Task 5 
            //int[] arr = { 1, 3, 4, 6, 67 };
            //int[] arr2 = { 2, 5, 1, 2 };
            //NotInSec(arr, arr2);
            #endregion
            #region Task 7
            //int[] arr = { 1, 4, 5, 2, 10 };
            //Even(ref arr);
            #endregion
            #region Task 8
            //string sntnc = "Salam Polad Mammadli";
            //Words(sntnc);
            #endregion
            #region Task 9
            //Console.WriteLine(AllInString("3In"));
            #endregion
            #region Task 10
            //int[] arr = { 1, 2, 3, 4 };
            //foreach (var item in AddElement(arr, 5))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Task 11
            //Console.WriteLine("Username:");
            //string username = Console.ReadLine();

            //    while (username.Length < 8)
            //    {
            //        Console.WriteLine("Duzgun daxil et");
            //        username = Console.ReadLine();
            //    }

            //User user = new User(username);
            //Console.WriteLine("Password:");
            //string password = Console.ReadLine();
            //user.Password = password;
            //Console.WriteLine($"{user.UserName}, {user.Password}");
            #endregion
            #region Task 12
            //Milk milk = new Milk( 10, 2, "Ariel");
            //milk.Count = 10;
            //milk.Price = 100;
            //milk.Sell();
            //Console.WriteLine($"{milk.Volume}L {milk.FatRate}%");
            #endregion

            #region Task 13
            //Book[] books = new Book[10];
            //for (int i = 0; i < books.Length; i++)
            //{
            //Start:
            //    Console.WriteLine("Book:");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Book Count:");
            //    int count = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Page Count:");
            //    int pagecount = int.Parse(Console.ReadLine());
            //    if (pagecount > 9 && name.Length >= 3)
            //    {
            //        Book book = new Book(name, count);
            //        book.PageCount = pagecount;
            //        books[i] = book;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Page count cannot be less than 10 and Book length cannot be shorter than 3");
            //        goto Start;
            //    }
            //}
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1} {books[i].Name} {books[i].PageCount}");
            //}
            #endregion
            #region Task 14
            //Console.WriteLine("Group limiti teyin edin:");
            //int limit = int.Parse(Console.ReadLine());
            //int button;
            //Group group = new Group(limit);
            //do
            //{

            //    AddStudent(ref group);
            //    GetStudents(ref group);


            //    static void AddStudent(ref Group group)
            //    {
            //        Console.WriteLine("**Telebe Elave Etme**");
            //        if (group.Students.Length < group.Limit)
            //        {
            //            group.AddStudent();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Qrupda yer yoxdur.");
            //        }
            //    }

            //    static void GetStudents(ref Group group)
            //    {
            //        Console.WriteLine("**Telebeler**");
            //        group.GetStudents();
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("(9) - Davam etmek \n(0) - Cixis");
            //    button = int.Parse(Console.ReadLine());

            //} while (button == 9);
            #endregion
            #region Task 15
            //string color = "Yellow";
            //string brand = "BMW";
            //double millage = 10;
            //Car2 car = new Car2(color, brand, millage);
            //Console.WriteLine("***CAR***");
            //string color2 = "Red";
            //string brand2 = "Norco";
            //double millage2 = 5;
            //Bycle bycle = new Bycle(color2, brand2, millage2);
            //car.ShowInfo();
            //Drive(ref car);
            //Console.WriteLine("***BYCLE***");
            //bycle.ShowInfo();
            //Drive2(ref bycle);
            //static void Drive(ref Car2 car)
            //{
            //    Console.WriteLine($"Halhazirki yanacaq {car.CurrentFuel}L");
            //    Console.WriteLine("Gedeceyimiz mesafe (km):");
            //    double km = int.Parse(Console.ReadLine());
            //    car.Drive2(km);
            //}
            //static void Drive2(ref Bycle bycle)
            //{
            //    Console.WriteLine("Gedeceyimiz mesafe (km):");
            //    double km = int.Parse(Console.ReadLine());
            //    bycle.Drive2(km);
            //}

            #endregion
            #region Task 16
            //string name = "Microsoft";
            //int limit = 3;
            //int button;
            //Company company = new Company(name, limit);
            //do
            //{
            //    Console.WriteLine("Ad");
            //    string fullname = Console.ReadLine();
            //    Console.WriteLine("Maas");
            //    double salary = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Vezife");
            //    string position = Console.ReadLine();
            //    Employee employee = new Employee(fullname, salary, position);
            //    AddEmployee(ref company, ref employee);
            //    GetEmployees(ref company);
            //    Console.WriteLine("Ad");
            //    fullname = Console.ReadLine();
            //    Console.WriteLine("Maas");
            //    salary = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Vezife");
            //    position = Console.ReadLine();
            //    Employee employee2 = new Employee(fullname, salary, position);

            //    AddEmployee(ref company, ref employee2);
            //    SearchEmployees(ref company);
            //    RemoveEmployee(ref company);
            //    GetEmployees(ref company);
            //    static void AddEmployee(ref Company company, ref Employee employee)
            //    {
            //        company.AddEmployee(employee);
            //    }
            //    static void GetEmployees(ref Company company)
            //    {
            //        company.GetEmployees();
            //    }
            //    static void SearchEmployees(ref Company company)
            //    {
            //        Console.WriteLine("Isci Axtar:");
            //        string search = Console.ReadLine();
            //        foreach (var item in company.SearchEmployees(search))
            //        {
            //            Console.WriteLine($"{item.FullName} {item.No} {item.Position} {item.Salary}");
            //            return;
            //        }

            //    }

            //    static void RemoveEmployee(ref Company company)
            //    {
            //        Console.WriteLine("isci nomresi daxil edin:");
            //        int no = int.Parse(Console.ReadLine());


            //        company.RemoveEmployee(no);
            //    }

            //    Console.WriteLine("(9) - Davam etmek \n(0) - Cixis");
            //    button = int.Parse(Console.ReadLine());
            //} while (button == 9);
            #endregion
            #region Task 17
            //Console.WriteLine("Fullname:");
            //string fullname = Console.ReadLine();
            //Console.WriteLine("email:");
            //string email = Console.ReadLine();
            //Console.WriteLine("Password:");
            //string password = Console.ReadLine();
            //User2 user = new User2(email, password);
            //user.FullName = fullname;

            //user.ShowInfo();
            #endregion
            #region Task 18
            //while (true)
            //{

            //    string fullname = Console.ReadLine();
            //    string[] items = fullname.Split(" ");
            //    if (items.Length == 2)
            //    {
            //        byte age = byte.Parse(Console.ReadLine());
            //        Student_2 student = new Student_2(fullname, age);
            //        Console.WriteLine("group nomresini daxil edin.");
            //        string groupno = Console.ReadLine();
            //        bool result = Student_2.CheckGroupNo(groupno, student);
            //        Console.WriteLine(result);
            //        Console.WriteLine("** fullname yoxlanir.. **");
            //        fullname = Console.ReadLine();
            //        result = Student_2.CheckFullName(fullname,  student);
            //        Console.WriteLine(result);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("soyad daxil edilmedi.(excample: polad mammadli)");

            //    }
            //}
            #endregion
            #region


            #endregion
        }
        #region Task 1
        //static int Power(int number, int power)
        //{
        //    int result = 1;
        //    for (int i = 1; i <= power; i++)
        //    {
        //        result = result * number;
        //    }
        //    return result;
        //}
        #endregion
        #region Task 2
        //static int Difference(int[] arr)
        //{
        //    int pair = 0;
        //    int single = 0;
        //    if (arr.Length>=5)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i] % 2 == 0)
        //                pair = arr[i] + pair;
        //            else
        //                single = arr[i] + single;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("en az 5 reqem daxil edilmelidir!.");
        //    }
        //    return Math.Abs(pair - single);

        //}
        #endregion
        #region Task 3
        //static int Difference2(int[] arr)
        //{
        //    int x3 = 0;
        //    int others = 0;
        //    int count = 0;
        //    int numb = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        numb = arr[i];
        //        while (numb > 0) 
        //        {
        //            numb = numb - numb % 10;
        //            numb = numb / 10;
        //            count++;
        //        } 

        //            if (count==3)
        //        {
        //            x3 = x3 + arr[i];
        //        }
        //        else
        //        {
        //            others = others + arr[i];
        //        }
        //        count = 0;
        //    }
        //    return Math.Abs(x3 - others);
        //}
        #endregion
        #region Task 4
        //static void Reverse(int [] arr)
        //{
        //    int[] newarr = new int[0];
        //    for (int i = arr.Length-1; i >= 0; i--)
        //    {
        //        Array.Resize(ref newarr, newarr.Length + 1);
        //        newarr[newarr.Length - 1] = arr[i];
        //    }
        //    foreach (var item in newarr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        #endregion
        #region Task 4 (2)
        static void Reverse2(int[] arr)
        {
            //int[] newarr = new int[arr.Length];
            int j = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arr[j] = arr[i];
                j++;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        #endregion
        #region Task 5
        //static void NotInSec(int[] arr,int[]arr2)
        //{

        //    foreach (var item in arr)
        //    {
        //        int i;
        //        for ( i = 0; i < arr2.Length; i++)
        //        {
        //            if (item == arr2[i])
        //            {
        //                break;
        //            }
        //        }
        //        if (i == arr2.Length)
        //        {
        //            Console.WriteLine(item);
        //        }
        //    }
        //}
        #endregion
        #region Task 7
        //static void Even(ref int[] arr)
        //{
        //    int[] myarr = new int[0]; 
        //    foreach (var item in arr)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            Array.Resize(ref myarr, myarr.Length + 1);
        //            myarr[myarr.Length - 1] = item;
        //        }
        //    }
        //    foreach (var item in myarr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        #endregion
        #region Task 8
        //static void Words(string sntnc)
        //{
        //    string[] words = sntnc.Split(" ");
        //    Console.WriteLine(words.Length);
        //}
        #endregion
        #region Task 9
        //static bool AllInString(string word)
        //{
        //    bool check = true;
        //    bool check2 = true;
        //    bool check3 = true;

        //    foreach (var item in word)
        //    {
        //        if (Char.IsDigit(item))
        //        {
        //            check = false;
        //        }
        //        else if (Char.IsLower(item))
        //        {
        //            check2 = false;
        //        }
        //        else if (Char.IsUpper(item))
        //        {
        //            check3 = false;
        //        }
        //    }
        //    if (check == false && check2 == false && check3 == false)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}
        #endregion
        #region Task 10
        //static int[] AddElement(int[] arr, int value)
        //{
        //    Array.Resize(ref arr, arr.Length + 1);
        //    arr[arr.Length - 1] = value;
        //    return arr;
        //}
        #endregion

    }
}

