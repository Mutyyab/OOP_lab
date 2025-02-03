using Manual_2;


/*
//Challenge2
Product[] product = new Product[15];
// Adding Products
int count = 0;
for (int i=0; i<product.Length; i++)
{
    if(Console.ReadLine() == "n" ||  Console.ReadLine() == "N")
    {
        break;
    }
    else
    {
        Product temp = new Product();
        product[i] = temp.AddProduct();
        count++;
        Console.WriteLine("If you want to add more write (y|Y)");
        Console.WriteLine("If you do not want to add more write (n|N)");
    }
}
// Showing Products
for (int i = 0; i < count; i++)
{
   product[i].ShowProduct();
}
//Showing Total Worth
int sum = 0;
for (int i = 0; i < product.Length; i++)
{
    sum = sum + product[i].price;
}
Console.WriteLine("Total Store Worth is:" + sum);
*/


/*
// challenge3
string filePath = "E:\\New folder\\userDetails.txt";
Muser muser = new Muser();
muser = muser.LoadUserFromFile(filePath);

muser.PrintUserDetails();
*/

Student[] student = new Student[15];
int count = 0;
for (int i = 0; i < student.Length; i++)
{
    if (Console.ReadLine() == "n" || Console.ReadLine() == "N")
    {
        break;
    }
    else
    {
        Student temper = new Student();
        student[i] = temper.AddStudent();
        count++;
        Console.WriteLine("If you want to add more write (y|Y)");
        Console.WriteLine("If you do not want to add more write (n|N)");
    }
}
for (int i = 0; i < count; i++)
{
    student[i].ShowStudent();
}

double[] Aggregate = new double[count];
for(int i = 0; i < count; i++)
{
    Aggregate[i] = (student[i].matricMarks * 0.1) + (student[i].fscMarks * 0.7) + (student[i].ecatMarks * 0.2);
}

Console.WriteLine("Aggregate of All Students are: ");
for (int i = 0; i < count; i++)
{
    Console.WriteLine(Aggregate[i]);
}

// Top 3 Students
Array.Sort(Aggregate);
Console.WriteLine("Top 3 Students are: ");
    Console.WriteLine(Aggregate[count-1]);
    Console.WriteLine(Aggregate[count - 2]);
    Console.WriteLine(Aggregate[count - 3]);


