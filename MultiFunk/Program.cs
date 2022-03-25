using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections;

namespace MultiFunk
{
    class Program
    {


        /******************************************************************************* */
        /******************************************************************************* */
        //main function 
        static void Main(string[] args)
        {
            Console.Title = "Function Selector";
            Selector selector = new Selector();
            selector.start();

            Console.Write(" press Enter to EXit !");
            Console.ReadKey();
            //clean exit
            Environment.Exit(0);

        }

        /******************************************************************************* */
        /******************************************************************************* */
        // a selector class to call all the functions 
        class Selector
        {
            //int j;
            //int k;
            ////int sizeofarray = 4;
            //int[] arrodd = new int[4];
            //int[] arreven = new int[4];
            int[] arr = new int[6];
            bool flag = false;
            private string FirstName;
            private string LastName;
            private int age;
            public void start()
            {

                Console.Clear();
                Console.WriteLine("Choose an function writing valid number:");
                Console.WriteLine("1) displaying Today();");
                Console.WriteLine("2)     ChangeTextColor();");
                Console.WriteLine("3)  PrintFullNameandAge()");
                Console.WriteLine("4)     ComparetwoValues()");
                Console.WriteLine("5)     Helloworld()");
                Console.WriteLine("6)      saveTextstofile()");
                Console.WriteLine("7)     ReadFromTextfile()  ");
                Console.WriteLine("8)     Multiplicationtable()  ");
                Console.WriteLine("9)     SquareRootSquared()  ");
                Console.WriteLine("10)    SortingRandomnumberArray()  ");
                Console.WriteLine("11)     palindromChecker()  ");
                Console.WriteLine("12)     GuesstheRandomNumber()  ");
                Console.WriteLine("13)   AddNumbers()  ");
                Console.WriteLine("14)   WhatAreMiddleNumbers()  ");
                Console.WriteLine("15)   WhatAreMiddleNumbers()  ");
                Console.WriteLine("16)   WhatAreMiddleNumbers()  ");
                Console.WriteLine("0) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Today();
                        break;
                    case "2":
                        ChangeTextColor();
                        break;
                    case "3":
                        PrintFullNameandAge();
                        break;
                    case "4":
                        Helloworld();
                        break;
                    case "5":
                        Helloworld();
                        break;
                    case "6":
                        saveTextstofile();
                        break;
                    case "7":
                        ReadFromTextfile();
                        break;
                    case "8":
                        Multiplicationtable();
                        break;
                    case "9":
                        SquareRootSquared();
                        break;
                    case "10":
                        SortingRandomnumberArray();
                        break;
                    case "11":
                        palindromChecker();
                        break;
                    case "12":
                        GuesstheRandomNumber();
                        break;
                    case "13":
                        WhatAreMiddleNumbers();
                        break;
                        
                    case "14":
                        //not implemented   
                        AddNumbers();
                        break;
                    case "15":
                        //not implemented 
                        Meandmyopponent();
                        break;
                    case "16":
                        //not implemented
                          OddorEven();
                        break;




                    default:
                        Environment.Exit(0);
                        break;
                }
                
          
                
                
                
            }
            public void Meandmyopponent()
            {
                Console.WriteLine("under construction...press anykey to exit ");
                Console.ReadLine();
                start();

            }

            public void AddNumbers()
            {

               

                Console.WriteLine("under construction...press anykey to exit ");
                Console.ReadLine();
                start();
            }
            public void OddorEven()
            {

                
                Console.WriteLine("under construction...press anykey to exit ");
                Console.ReadLine();
                start();


            }

            public void WhatAreMiddleNumbers()
            {
                Console.WriteLine("Enter the first  number:");
                
                int value1 = (Convert.ToInt32(Console.ReadLine()));
               
                Console.WriteLine("Enter the second  number:");
                int value2 = (Convert.ToInt32(Console.ReadLine()));
                

                //print the middle numbers 
                Console.WriteLine($"printing the mid numbers between {value1  } and  {value2 }...");
                if ((value1 )< (value2))
                {
                   
                for(int i=(value1+1);i< (value2);i++)
                    {
                        
                        Console.WriteLine($"{i }");
                        
                     
                    }
                }
               else if ((value1) > (value2))
                {

                    for (int i = (value2 + 1); i < (value1); i++)
                    {
                       
                        Console.WriteLine($"{i }");
                        

                    }
                }
            
                else 
                    Console.WriteLine($"the numbers are equal so there are no middle numbers");
            }
            public void palindromChecker()
            {
                string potentialpalindrome;

                Console.WriteLine("Enter your text to check palindrom");
                potentialpalindrome = Console.ReadLine().ToString();
               
                int length = potentialpalindrome.Length;
                for (int i = 0; i < length / 2; i++)
                {
                    if (potentialpalindrome[i] != potentialpalindrome[length - i - 1])
                    {
                        Console.WriteLine("sorry it is not palindrome");
                        break;
                    }
   
                }
                for (int i = 0; i < length / 2; i++)
                {
                   
                  if (potentialpalindrome[i] != potentialpalindrome[length - i - 1]) flag = true;
                    
                }
                if (flag==false)
                Console.WriteLine("sucess it is palindrom");
                Console.ReadLine();
                start();
            }
            public void SortingRandomnumberArray()
            {
                int sizeofarray = 10;
                int[] arr = new int[sizeofarray];
                //For simplicity let us generate 10 random numbers from 1-100
                Random random = new Random();
                Console.WriteLine("The generated 10 numbers to be  in the unsorted arrary are:");
                for (int i = 0; i < sizeofarray; i++)
                {
                    //array of randomnly ordered numbers between 1 and 1000
                    arr[i] = random.Next(random.Next(1, 100));

                }
                for (int i = 0; i < sizeofarray; i++)
                    Console.WriteLine(arr[i]);

                //sorting 
                Console.WriteLine("After sorting in increasing order the array looks like this :");
               
                int swap = 0;

                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            swap = arr[i];
                            arr[i] = arr[j];
                            arr[j] = swap;
                        }
                    }
                }
                for (int i = 0; i < sizeofarray; i++)
                    Console.WriteLine(arr[i]);
                Console.ReadLine();
                start();
            }
            public void Multiplicationtable() {



                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write(i * j + "\t");
                    }
                    Console.Write("\n");
                }

                Console.ReadLine();
                start();
            }
            
            /******************************************************************************* */
            /******************************************************************************* */
            public void SquareRootSquared()
            {
                Console.WriteLine("Enter the   number:");
                string value = Console.ReadLine();
                bool validnumber = false;
                decimal decimalnumber;
                while (validnumber == false)
                {

                   // if  it  a valid integer number i.e.validnuber == true break out of the loop
                    if (decimal.TryParse(value, out decimalnumber))
                    {

                        break;
                    }
                    //else if decimal.TryParse(value, out decimalnumber)< 0{ }
                    else 
                    {

                        //promp re enter age in the right format if the age is still invalid integer i.e validnumber == false 
                        Console.WriteLine("not a valid  decimal number  please try again. use comma instead of point ");
                        value = Console.ReadLine();
                    }

                }
                decimal value1 = decimal.Parse(value);
                //calling a static method
                
                decimal value2 = Selector.Sqrt(value1);
                //power of 2 of value2
                decimal value3 =( value2 * 2 )* 10;
                Console.WriteLine($"the result is  { value3}");
            }
            //Read from the file
            public void ReadFromTextfile()
            {
                string path = @"C:\\csharpfile\csharpfiles.txt";
                using (StreamReader readtext = new StreamReader(path))
                {
                    string s = "";
                    while ((s = readtext.ReadLine()) != null)
                    {
                        Console.WriteLine("reading from file ......");
                        Console.WriteLine(s);
                    }

                }
                Console.ReadLine();
                start();
            }

            //save a text to hard disk 
            public void saveTextstofile()
            {
                //  C:\csharpfile\csharpfiles.txt is the path
                string txtInput;
                string path = @"C:\\csharpfile\csharpfiles.txt";


                Console.WriteLine("Enter your text to write to disk please");
                txtInput = Console.ReadLine().ToString();
                
                    using (StreamWriter streamwriter = File.AppendText(path))
                    {
                        streamwriter.WriteLine(txtInput);
                    }
                Console.WriteLine("sucess the text is written to the path adress");
                Console.ReadLine();
                start();
            }
            //guessing the random number generated from 1-100
            public void GuesstheRandomNumber()
            {

                //three allowed attempts allowed to guess 
                int trynumber = 3;
                String _number;
                Random rand = new Random();
                int number = rand.Next(1, 100);
                Console.WriteLine("guess the generated random number:");
                _number = Console.ReadLine();

                //check the _number is valid integer using while loop and tryparse
                bool validnumber = false;
                int integerNumber;
                while (validnumber == false)
                {

                    //if  it  a valid integer number i.e . validnuber==true break out of the loop 
                    if (int.TryParse(_number, out integerNumber)&& (number == int.Parse(_number)))
                    {
                        Console.WriteLine("sucessful guess;!!");
                        break;
                    }
                    
                    
                    else
                    {
                        //promp re enter age in the right format if the age is still invalid integer i.e validnumber == false 
                        Console.WriteLine("not a valid integer  please try again ");
                        if (int.TryParse(_number, out integerNumber) && (number < int.Parse(_number))) 
                            { Console.WriteLine("your guess is greater than random generated number;!!"); }
                        if (int.TryParse(_number, out integerNumber) && (number > int.Parse(_number))) 
                            { Console.WriteLine("your guess is less than random generated number;!!"); }
                        --trynumber;
                        Console.WriteLine($" you have left with  { trynumber} attempts" );
                        if (trynumber == 0)
                        {
                            Console.WriteLine("sorry not sucessful guess!!");
                            Console.WriteLine($"the generated number is !! {number}");
                            break;
                        }
                            _number = Console.ReadLine();
                    }
                }
                Console.ReadLine();
                start();



                //}
                /******************************************************************************* */
                /******************************************************************************* */

            }
            //Hello world function 
            public void Helloworld()
            {
                //print Hello world to the conslole
                Console.WriteLine("Hello World!");
                Console.ReadLine();
                start();

            }

            /******************************************************************************* */
            /******************************************************************************* */

            // A function for full name and age 
            public void PrintFullNameandAge()
            {
                string _age;
                //first name 
                Console.WriteLine("Enter your Frist name please");
                FirstName = Console.ReadLine().ToString();

                //validating if the first name is valid text or string 
                bool isvalidFirstName;
                while (string.IsNullOrEmpty(FirstName))
                {

                    Console.WriteLine("First name can't be empty and must be a string or text! Input your last name once more");
                    FirstName = Console.ReadLine();
                }
                while (!string.IsNullOrEmpty(FirstName))
                {
                    isvalidFirstName = Regex.IsMatch(FirstName, @"^[a-zA-ZäöåÄÖÅ]+$");
                    foreach (char c in FirstName)
                    {
                        if (!char.IsLetter(c))
                            isvalidFirstName = false;
                        if (isvalidFirstName == false)
                        {
                            Console.WriteLine("Fist name can't be empty and must be a string or text! Input your last name once more");
                            FirstName = Console.ReadLine();
                        }
                        else break;
                    }
                    break;
                }
                //validate if the first name is not empty 



                //Last name input validation 
                Console.WriteLine("Enter your Last name please");
                LastName = Console.ReadLine().ToString();
                //validate if the last name is not empty 
                while (string.IsNullOrEmpty(LastName))
                {
                    Console.WriteLine("Last Name can't be empty! Input your last name once more");
                    LastName = Console.ReadLine();
                }
                //validating if the last name is valid name only using alphabets
                while (!string.IsNullOrEmpty(LastName))
                {
                    bool isvalidLastName = Regex.IsMatch(LastName, @"^[a-zA-ZäöåÄÖÅ]+$");
                    foreach (char c in LastName)
                    {
                        if (!char.IsLetter(c))
                            isvalidLastName = false;
                        if (isvalidLastName == false)
                        {
                            Console.WriteLine("Last  name can't be empty and must be a string or text! Input your last name once more");
                            LastName = Console.ReadLine();
                        }
                        else break;
                    }
                    break;
                }


                Console.WriteLine("Enter your age  please");
                _age = Console.ReadLine();

                /*check the age is valid integer using while loop and tryparse*/
                bool validnumber = false;
                int integerNumber;
                while (validnumber == false)
                {

                    //if  it  a valid integer number i.e . validnuber==true break out of the loop 
                    if (int.TryParse(_age, out integerNumber))
                    {

                        break;
                    }
                    else
                    {
                        //promp re enter age in the right format if the age is still invalid integer i.e validnumber == false 
                        Console.WriteLine("not a valid integer age please try again ");
                        _age = Console.ReadLine();
                    }

                }
                //print the age 
                age = int.Parse(_age, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                Console.WriteLine($"name is :  { FirstName}  { LastName } and age is { age}");
                Console.ReadLine();
                start();
            }
            //end of fullname printing function 


            /******************************************************************************* */
            /******************************************************************************* */
            //here the change color fn starts
            public void ChangeTextColor()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nForeground color  = " + Console.ForegroundColor);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nForeground color  = " + Console.ForegroundColor);
                Console.ReadLine();
                start();
                // Console.Clear();
            }


            /******************************************************************************* */
            /******************************************************************************* */
            //print the date 
            public void Today()
            {
                DateTime now = DateTime.Now;
                string strDate = DateTime.Now.ToString("MM/dd/yyyy");
                
                Console.WriteLine($"Today's date is  :  { strDate} ");
                Console.ReadLine();
                     start();
            }


            /******************************************************************************* */
            /******************************************************************************* */
            //compare two values function 
            public void ComparetwoValues()
            {
                string result;
                Console.WriteLine("Enter the first  number:");
                
                  string value1 = Console.ReadLine();
                bool validnumber = false;
                double doublenumber ;
                while (validnumber == false)
                {

                    //if  it  a valid integer number i.e . validnuber==true break out of the loop 
                    if (double.TryParse(value1, out doublenumber))
                    {

                        break;
                    }
                    else
                    {
                        //promp re enter age in the right format if the age is still invalid integer i.e validnumber == false 
                        Console.WriteLine("not a valid number please try again ");
                        value1 = Console.ReadLine();
                    }

                }
                Console.WriteLine("Enter the second  number:");
                string value2 = Console.ReadLine();
                bool validnumber2 = false;
                double doublenumber2;
                while (validnumber2 == false)
                {

                    //if  it  a valid integer number i.e . validnuber==true break out of the loop 
                    if (double.TryParse(value1, out doublenumber2))
                    {

                        break;
                    }
                    else
                    {
                        //promp re enter age in the right format if the age is still invalid integer i.e validnumber == false 
                        Console.WriteLine("not a valid number  please try again ");
                        value2 = Console.ReadLine();
                    }

                }
           
                if (Convert.ToDouble(value1) < Convert.ToDouble(value2))
                    result = "less than";
                else if (Convert.ToDouble(value1) == Convert.ToDouble(value2))
                        result = "equal to";
                 else
                        result = "greater than";
                
                Console.WriteLine("The first number is {0} the second number.",
                                  result);
                Console.ReadLine();
                start();
            }
            public static decimal Sqrt(decimal x, decimal epsilon = 0.0M)
            {
                bool validnumber= false;
                while (validnumber == false)
                {
                    Selector sel = new Selector();
                    if (x < 0)
                    {
                        Console.WriteLine("negative  number  is not valid please try again ");
                        sel.SquareRootSquared();
                    }

                }
                decimal current = (decimal)Math.Sqrt((double)x), previous;
                do
                {
                    previous = current;
                    if (previous == 0.0M) return 0;
                    current = (previous + x / previous) / 2;
                }
                while (Math.Abs(previous - current) > epsilon);
                return current;
            }
        }
        }
    }

 