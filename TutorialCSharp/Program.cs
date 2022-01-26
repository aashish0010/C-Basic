namespace TutorialCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////print the instruction in console
            //Console.WriteLine("Hello World.!!");

            //Console.WriteLine("*");
            //Console.WriteLine("**");
            //Console.WriteLine("***");
            //Console.WriteLine("****");
            //Console.WriteLine("*****");


            ////variable
            ////use to store the value
            ////container
            //string name = "aashish";
            //int age = 23;
            //int classno;
            //classno = 11;
            ////add two variable
            //Console.WriteLine("Hello i am " + name +" age " + age + " currently studing in "+classno);

            ////datatype
            //string pharas = "Hello User";
            //char grade = 'A';
            //int agenum = 22;
            ////extact number like currecy
            //decimal currey = 22000;
            ////not extact datatype
            //float notexact = 22;
            ////between decimal and float
            //double gpa = 3.3;
            ////true or false
            //bool isMale = true;


            ////play with string
            ////new line code(\n)
            //Console.WriteLine("Hello\nworld..!!");

            ////print comma("") and play with it(\)

            //Console.WriteLine("Hello \"Aashish\"");

            ////count the word c#
            //string world = "Hello World";
            //Console.WriteLine(world.Length);

            ////upper lower case c#
            //string worldnext = "hello world";
            //Console.WriteLine(worldnext.ToUpper());

            ////contains
            //string worldprev = "Hello World";
            //Console.WriteLine(worldprev.Contains("Hello"));

            ////indexing
            //Console.WriteLine(world[2]);

            ////cut the value or splite
            //Console.WriteLine(world.Substring(2,4));


            ////power
            //Console.WriteLine(Math.Pow(2,3));


            ////input information
            //Console.WriteLine();//write the line of code and go to next line

            //Console.Write("Enter Your Name:");
            //string nameofuser = Console.ReadLine(); //store the value of console.write();
            //Console.Write("Enter Your Age:");
            //string ageofuser = Console.ReadLine();
            //Console.WriteLine("Hello " + nameofuser + " of age "+ ageofuser);


            ////building an calculator
            //Console.Write("Enter the First Number:");

            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter the First Number:");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter sign:");
            //string sign = Console.ReadLine();
            //if(sign== "+")
            //{
            //    double sum = num1 + num2;
            //    Console.WriteLine("Sum "+sum);
            //}
            //else if(sign=="-")
            //    {
            //    double minus = num1 - num2;
            //    Console.WriteLine("Diff "+minus);
            //}
            //else if(sign=="/")
            //    {
            //    double div = num1 / num2;
            //    Console.WriteLine("Divide "+div);
            //}
            //else if(sign=="*")
            //    {
            //    double mul = num1 * num2;
            //    Console.WriteLine("Mul "+mul);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}

            ////creating the mad lips game
            //string color, pluralNoun, celebrity;
            //Console.Write("Enter the color : ");
            //color = Console.ReadLine();
            //Console.Write("Enter Plural Noun : ");
            //pluralNoun = Console.ReadLine();
            //Console.Write("Enter Celebrity : ");
            //celebrity = Console.ReadLine();

            //Console.WriteLine("Roses are "+color);
            //Console.WriteLine(pluralNoun + " are blue");
            //Console.WriteLine("I Love "+celebrity);

            //Console.ReadLine();

            ////array
            //int[] luckyNumbers = { 1, 3, 4, 6, 7 };

            //for(int i=0; i< luckyNumbers.Length;i++)
            //{
            //    Console.WriteLine(luckyNumbers[i]);
            //}

            //2d array
            //int[,] Numbergrid =
            //{
            //    {1, 2 },
            //    { 3, 4 },
            //    {5,6 }
            //};
            //for (int i = 0; i > Numbergrid.Length; i++)
            //{
            //    for (int j = 0; j > Numbergrid.Length; j++)
            //    {
            //        Console.WriteLine(Numbergrid[i,j]);
            //    }
            //}
            ////Console.WriteLine(numbergrid);

            //SayHi("Aashish");
            
            //Console.WriteLine(SayHello("aashish", 22));
            
            //Console.Write("enter the value: ");
            //int data=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(SwitchFun(data));
            //Console.ReadLine();

            //exception handling
            try
            {
                Console.Write("Number");
                int a= Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





        }
        //void method doesnot return anythings
        static void SayHi(string name)
        {
            Console.WriteLine("Hello User "+name);
        }
        //return keyword
        static dynamic SayHello(string name , int age)
        {
            return name+ age;
        }
        static dynamic SwitchFun(int Days)
        {
            string days;
            switch (Days)
            {
                case 1:
                    days = "sunday";
                    break;
                case 2:
                    days = "monday";
                    break;
                case 3:
                    days = "Tuesday";
                    break;
                case 4:
                    days = "Wednesday";
                    break;
                case 5:
                    days = "Thrusday";
                    break;
                case 6:
                    days = "Friday";
                    break;
                default:
                    days = "Saturday";
                    break;

            }
            return days;
        }



        
    }
}