

//string name1 = "Amirastan";
//string surname1 = "Mereyev";
//int age1 = 33;


//string name2 = "Sirac";
//string surname2 = "Memmedov";
//int age2 = 22;

//string name3 = "Elmir";
//string surname3 = "Qafarzade";
//int age3 = 21;


//Console.WriteLine($" { name2} {surname2} {age2}");



//var stu1 = new
//{
//    name = "Amirastan",
//    surname = "Mereyev",
//    age = 33
//};


//var stu2 = new
//{
//    name = "Sirac",
//    surname = "Memmedov",
//    age = 22
//};


//Console.WriteLine(stu1.name + " " + stu1.surname + " " + stu1.age);









using Class_Work_21_02_2024;

//Student stu1 = new Student();

//stu1.name = "Ismayil";
//stu1.surname = "Ceferli";
//stu1.age = 24;
//stu1.adress = "ehmedli";


//Student stu2 = new();

//stu2.name = "Test";
//stu2.surname = "Testov";
//stu2.age = 70;
//stu2.adress = "Xetai";


//string fullName = stu2.name + " " + stu2.surname;

//Console.WriteLine(fullName);

//Student stu3 = new()
//{
//    name = "Sirac",
//    surname = "Memmedov",
//    age = 22,
//    adress = "Masazir",
//    phone = "4648486484"
//};


//Console.WriteLine(stu3.phone);

//stu3.ShowText();



//Console.WriteLine(stu3.GetFullName());
//Console.WriteLine(stu2.GetFullName());

//var result = stu2.GetFullDatas();

//Console.WriteLine(result);


//Student[] students = {stu1, stu2, stu3};

//foreach (Student stu in students)
//{
//    //Console.WriteLine(stu.name + " " + stu.surname);
//    Console.WriteLine(stu.GetFullDatas());
//}

//void ShowAll(Student[] datas)
//{
//    foreach (var item in datas)
//    {
//        Console.WriteLine(item.GetFullDatas());
//    }
//}

//ShowAll(students);

//Student GetByAge(Student[] datas, int age)
//{
//    //Student foundStudent = new();
//    //foreach (var item in datas)
//    //{
//    //    if (item.age == age)
//    //    {
//    //        foundStudent = item; 
//    //        break;
//    //    }
//    //}
//    //return foundStudent;

//    //return Array.Find(datas, m => m.age == age);

//var result = datas.FirstOrDefault(m => m.age == age);

//return result != null ? result : new Student();

//}

//var result = GetByAge(students, 27);

//if (result != null)
//{
//    Console.WriteLine(result.GetFullDatas());
//}
//else
//{
//    Console.WriteLine("Data notfound");
//}

//Console.WriteLine(result.GetFullDatas());

//int a = 5;

////Console.WriteLine(a == 5 ? a : "deyil");

//var result = a == 5 ? a.ToString() : "Deyil";




//Book book = new Book("Leyli ve Mecnun", "Nizami");

//Book book = new Book("Elmir");
//Console.WriteLine(book.name);

//Console.WriteLine(book.name + " " + book.author);