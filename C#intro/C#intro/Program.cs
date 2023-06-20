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

Console.WriteLine("Input no:");
int n = Convert.ToInt32(Console.ReadLine());
switch (n)
{
    case 1:
        {
            Console.WriteLine("Ian");
            break;
        }
    case 2:
        {
            Console.WriteLine("Feb");
            break;
        }
    case 3:
        {
            Console.WriteLine("Mar");
            break;
        }
    case 4:
        {
            Console.WriteLine("Apr");
            break;
        }
    case 5:
        {
            Console.WriteLine("Mai");
            break;
        }
    case 6:
        {
            Console.WriteLine("Iun");
            break;
        }
    case 7:
        {
            Console.WriteLine("Iul");
            break;
        }
    case 8:
        {
            Console.WriteLine("Aug");
            break;
        }
    case 9:
        {
            Console.WriteLine("Sept");
            break;
        }
    case 10:
        {
            Console.WriteLine("Oct");
            break;
        }
    case 11:
        {
            Console.WriteLine("Nov");
            break;
        }
    case 12:
        {
            Console.WriteLine("Dec");
            break;
        }
    default:
        {
            Console.WriteLine("Unknown");
            break;
        }
}