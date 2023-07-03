// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine(  );
//Console.WriteLine("Un alt text");
int number = 7;
int anothernumber = 7 + 2;
//Console.WriteLine(number);
//Console.WriteLine(anothernumber);

//byte first = 1;
//byte second = 123;
//char third = 'x';
//string forth = "csharp";
//float fifth = 123.5f;
//bool sixth = true;
//double seventh = 12345678901234567890;




//Console.WriteLine("Introduceti primul nume:");
//string a = Console.ReadLine();
//Console.WriteLine("Introduceti al doilea nume:");
//string b = Console.ReadLine();

//if (a == b)
//{
//    Console.WriteLine("Same");
//}
//else
//{
//    Console.WriteLine("Not the same");
//}

//Console.WriteLine("First name:");
//string a = Console.ReadLine();
//Console.WriteLine("Second name");
//string b = Console.ReadLine();

//if (String.Compare(a, b) <= 0)
//{
//    Console.WriteLine("Alphabetically ordered");
//}
//else
//{
//    Console.WriteLine("Not alphabetically ordered");
//}

//Console.WriteLine("Input no:");
//int n = Convert.ToInt32(Console.ReadLine());
//switch (n)
//{
//    case 1:
//        {
//            Console.WriteLine("Ian");
//            break;
//        }
//    case 2:
//        {
//            Console.WriteLine("Feb");
//            break;
//        }
//    case 3:
//        {
//            Console.WriteLine("Mar");
//            break;
//        }
//    case 4:
//        {
//            Console.WriteLine("Apr");
//            break;
//        }
//    case 5:
//        {
//            Console.WriteLine("Mai");
//            break;
//        }
//    case 6:
//        {
//            Console.WriteLine("Iun");
//            break;
//        }
//    case 7:
//        {
//            Console.WriteLine("Iul");
//            break;
//        }
//    case 8:
//        {
//            Console.WriteLine("Aug");
//            break;
//        }
//    case 9:
//        {
//            Console.WriteLine("Sept");
//            break;
//        }
//    case 10:
//        {
//            Console.WriteLine("Oct");
//            break;
//        }
//    case 11:
//        {
//            Console.WriteLine("Nov");
//            break;
//        }
//    case 12:
//        {
//            Console.WriteLine("Dec");
//            break;
//        }
//    default:
//        {
//            Console.WriteLine("Unknown");
//            break;
//        }
//}

//int[] numbers = new int[5];
//numbers[0] = 12;
//numbers[1] = 14;
//numbers[2] = 34;
//numbers[3] = 567;
//numbers[4] = 34;
//Console.WriteLine(numbers[1]);
//int sum = numbers[0] + numbers[1] + numbers[2];
//int prod = numbers[3] * numbers[4];
//Console.WriteLine("sum =" + sum);
//Console.WriteLine("prod = " + prod);
//Console.WriteLine("sum2 = " + (sum + prod));

//List<int> numere = new List<int>();
//numere.Add(12);
//numere.Add(14);
//numere.Add(34);
//numere.Add(567);
//numere.Add(34);
//Console.WriteLine(numere[1]);

//List<string> nume = new List<string> { "Ana", "Victor", "Luca" };
//Console.WriteLine(nume[0] + "," + nume[1] + "," + nume[2]);

//Queue<int> coada = new Queue<int>();
//coada.Enqueue(12);
//coada.Enqueue(14);
//coada.Enqueue(34);
//coada.Enqueue(567);
//coada.Enqueue(34);
//Console.WriteLine(coada.ElementAt(1));

//Stack<int> stiva = new Stack<int>(5);
//stiva.Push(12);
//stiva.Push(14);
//stiva.Push(34);
//stiva.Push(567);
//stiva.Push(34);
//Console.WriteLine(stiva.ElementAt(1));

//Dictionary<int, string> note = new Dictionary<int, string>();
//note.Add(7, "Ana");
//note.Add(5, "Nicu");
//note.Add(8, "Iulia");
//note.Add(10, "Maria");
//note.Add(9, "Simona");
//Console.WriteLine(note[5]);

//Dictionary<int, List<string>> note2 = new Dictionary<int, List<string>>();
//note2.Add(10, new List<string> { "Ana", "Maria" });
//note2.Add(8, new List<string> { "Ileana", "Viorel", "Gicu" });
//note2.Add(7, new List<string> { "Ioan", "Iulia" });

//Console.WriteLine(note2[10][0]);
//Console.WriteLine(note2[8][1]);

//for (int i = 2; i<=15; )
//{
//    Console.WriteLine(i);
//    i = i + 2;
//}

//for (int i = 14; i>=2; i-=2 )
//{
//    Console.WriteLine(i);
//}

//List<int> list = new List<int>();
//for (int i = -100; i<=100; i++)
//{
//    if (i % 7 == 0)
//    {
//        list.Add(i);
//        Console.WriteLine(i);
//    }
//}

//List<int> numere = new List<int>();
//for (int i = 1; i<=5; i++)
//{
//    Console.WriteLine("Input no:");
//    int j = Convert.ToInt32(Console.ReadLine());
//    numere.Add(j);
//}
//foreach (int element in numere)
//{
//    Console.WriteLine(element*12.75);
//}

//int x = -100;
//while (x<=100)
//{ if (x % 7 == 0)
//    {
//        Console.WriteLine(x);
       
//    }
//    x++;
//}

int z = 56;
do
{
    if (z % 24 == 0)
    {
        Console.WriteLine(z);
    }
    z++;
} while (z <= 987);


