using System;

// provides us various methods to use in an array
using System.Linq;

namespace C__Syntax3
{
    class Program
    {
        enum en_WeekDays
        {
            SUNDAY,
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY
        }


        static void printName(string Name)
        {
            Console.WriteLine("The Name is: {0}", Name);
        }

        static void printUserInfo(string Name, byte age)
        {
            Console.WriteLine("The User Name is:\t{0}\nThe User Age is:\t{1}", Name, age);
        }

        static void PrintClientInfo(string Name, byte Age, string Address ="No Address is entered (null)")
        {
            Console.WriteLine("Name= {0} , Age= {1}, Address= {2}", Name, Age, Address);
        }


        static string GetMyName(string Name = "Ahmad Hirzallah")
        {
            return Name;
        }


        static void PrintYoungestChild(string child1, string child2, string child3)
        {
            Console.WriteLine("The Youngest child is: " + child3);
        }

        static void PrintOldestChild(string child1, string child2, string child3)
        {
            Console.WriteLine("The Oldest child is: " + child1);
        }

        static int Sum(int Num1, int Num2)
        {
            return (Num1 + Num2);
        }


        static int Sum(int Num1, int Num2, int Num3)
        {
            return (Num1 + Num2 + Num3);
        }

        static double Sum(int Num1, int Num2, double Num3, double Num4)
        {
            return (Num1 + Num2 + Num3 + Num4);
        }



        static void Main(string[] args)
        {
            /*
             *  - C# Strings
             *      - In C#, a string is a series of characters that is used to represent text.
             *      - It can be a character, a word or a long passage surrounded with the double quotes ".
            */

            Console.WriteLine("String Manipulation and Functions and Properties:\n");
            
            string Name = "Ahmad Omar Ibrahim Hirzallah";
            Console.WriteLine("\nName is: " + Name);
            Console.WriteLine("\nName Length is: " + Name.Length);

            //  - This will take 5 characters staring position 2
            Console.WriteLine("\nUsing Substring to take from index 2 a 8 chars len: {0}", Name.Substring(2, 8));

            Console.WriteLine("\n.ToUpper: {0}", Name.ToUpper());
            Console.WriteLine(".ToLower: {0}", Name.ToLower());

            Console.WriteLine("\nRetrieving the index 0 of the string: {0}", Name[0]);
            Console.WriteLine("Retrieving the index 2 of the string: {0}", Name[2]);

            Console.WriteLine("\nInserting (Full Name: )  Insert(index, String):\t{0}", Name.Insert(0, "Full Name: "));
            Console.WriteLine(Name.Insert(3,"KKKK"));   // - Insert at the index & shift the (current & next) indicies chars

            Console.WriteLine("\nReplace every (a) to (*&) using .Replace (Before str/pattern , After ...):\t{0}", Name.Replace("a", "*&"));

            Console.WriteLine("\nIndexOf(Pattern Or String or Char) - IndexOf:Hirz -> :\t{0}", Name.IndexOf("Hirz")); // 19
            Console.WriteLine("IndexOf(Pattern Or String or Char) - IndexOf:A -> :\t{0}", Name.IndexOf("A"));   // 0
            Console.WriteLine("IndexOf(Pattern Or String or Char) - IndexOf:a -> :\t{0}", Name.IndexOf("a"));   // 0

            Console.WriteLine("\nContains:\t{0}", Name.Contains("Omar")); // True
            Console.WriteLine("Contains:\t{0}", Name.Contains('a')); // True
            Console.WriteLine("Contains:\t{0}", Name.Contains('x')); // False

            Console.WriteLine("\n.LastIndexOf('a'):\t{0}", Name.LastIndexOf('a'));    // 26



            string NamesStr = "Ahmad,Mahmoud,Ali,Mohammed,Mosab,Abdulrahman";
            string[] SplittedNames = NamesStr.Split(',');
            Console.WriteLine("\n\nSplitted Names are:\n{0}\t{1}\t{2}\t{3}\t{4}\t{5}",
                                SplittedNames[0], SplittedNames[1], SplittedNames[2],
                                SplittedNames[3], SplittedNames[4], SplittedNames[5]);


            string NamesStr2 = "Ahmad;,Mahmoud;,Ali;,Mohammed;,Mosab;,Abdulrahman";
            string[] separators = new string[] { ";,", "," };
            string[] SplittedNames2 = NamesStr2.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("\n\nNames with multi separators: ");
            foreach (string name in SplittedNames2)
            {
                Console.WriteLine(name);
            }



            string Sentence =  "          Ahmad Is King Of Programming           ";
            Console.WriteLine("\n\nSentence Before:\t({0})", Sentence);
            Console.WriteLine("\nSentence After .Trim():\t({0})", Sentence.Trim());
            Console.WriteLine("\nSentence After .TrimStart():\t({0})", Sentence.TrimStart());
            Console.WriteLine("\nSentence After .TrimEnd():\t({0})", Sentence.TrimEnd());







            /*
             *  - String Interpolation (استيفاء ، اقحام ، توليد):
             *      - String interpolation is a better way of concatenating strings.
             *      - We use + sign to concatenate string variables with static strings.
             *      - C# 6 includes a special character $ to identify an interpolated string.
             *      - An interpolated string is a mixture of static string and string variable
             *          where string variables should be in {} brackets.
             *          
             *  - By placing a $ before the opening quotation mark, you signal that the string is an interpolated string.
             *  - This means any code within curly braces {} is evaluated and converted into a string as part of the final value.
             *  - Why Use String Interpolation?
             *      - Readability: It makes the string construction easier to read than concatenating multiple strings.
             *      - Maintainability: Embedding expressions directly within the string reduces the likelihood of errors
             *          when formatting output.
            */
            
            // Declare variables
            string firstName;
            string lastName;
            string code;

            // Define (assign) variables on separate lines
            firstName = "Mohammed";
            lastName = "Abu-Hadhoud";
            code = "107";

            Console.WriteLine("\n\nInterpolated String:\n");
            // Use string interpolation to build the full name string.
            // Explanation:
            // - The $ before the string literal marks it as an interpolated string.
            // - Inside the string, curly braces {} allow you to embed variable values or expressions directly.
            //   This makes the code more readable and concise compared to traditional concatenation.
            string fullName;
            fullName = $"Mr. {firstName} {lastName}, Code: {code}";

            // Print the interpolated string to the console.
            Console.WriteLine(fullName);


            // Declare variables
            string firstName2;
            string lastName2;
            string code2;
            int age;
            char grade;

            // Define variables on separate lines
            firstName2 = "Ahmad";
            lastName2 = "Hirzallah";
            code2 = "1307";
            age = 25;
            grade = 'A';

            // Use string interpolation to include various types.
            // C# automatically converts non-string types (like int and char)
            // to their string representation via the ToString() method.
            string fullName2;
            fullName2 = $"Mr. {firstName2} {lastName2}, Code: {code2}, Age: {age}, Grade: {grade}";

            // Print the interpolated string to the console.
            Console.WriteLine(fullName2);









            /*
             *  - C# Type Casting
             *      - Type casting is when you assign a value of one data type to another type.
             *      - In C#, there are two types of casting:
             *          - Implicit Casting (automatically) - converting a smaller type to 
             *              a larger type size:  [[char -> int -> long -> float -> double]]
             *          - Explicit Casting (manually) - converting a larger type to
             *              a smaller size type : [[double -> float -> long -> int -> char]]
            */

            //  Implicit casting is done automatically when passing a smaller size type to a larger size type
            int myInt = 32000;
            double myDouble = myInt;    //  - Automatic casting: int to double

            Console.WriteLine("\n\nCasting; Implicit Vs Explicit:\n");
            Console.WriteLine("Integer Value: " + myInt);
            Console.WriteLine("Double Value: " + myDouble);

            //  Explicit casting must be done manually by placing the type in parentheses in front of the value.
            double myDouble2 = 1273.123D;
            //myInt2 = myDouble2;     //  Compile Error ; must do explicit casting
            int myInt2 = (int)myDouble2;    // Manual casting: double to int
            Console.WriteLine("\nDouble Value: " + myDouble2);
            Console.WriteLine("Integer Value: " + myInt2);


            /*
             * Type Conversion Methods:
             *      - It is also possible to convert data types explicitly by using built-in methods, such as
             *          - Convert.ToBoolean, Convert.ToDouble, Convert.ToString,
             *            Convert.ToInt32 (int) AND Convert.ToInt64 (long)
            */
            int myInt3 = 20;
            double myDouble3 = 7.25D;
            bool myBool = true;
            Console.WriteLine("\n\nConverting using (Convert.):\n");
            Console.WriteLine("Converting bool ToString: " + Convert.ToString(myBool));      // True
            Console.WriteLine("Converting int ToString: " + Convert.ToString(myInt3));
            Console.WriteLine("Converting double ToString: " + Convert.ToString(myDouble3));
            Console.WriteLine("Converting int ToDouble: " + Convert.ToDouble(myInt3));
            Console.WriteLine("Converting double ToInt32 (int): " + Convert.ToInt32(myDouble3));



            /*
             * Explicit casting is required to convert from an enum type to its underlying integral type.
            */

            Console.WriteLine("\n\nEnums Explicit Caseing:\n");
            Console.WriteLine(en_WeekDays.FRIDAY);
            //int dayIs2 = en_WeekDays.FRIDAY;  // Error; Need Explicitly Conversion !
            int dayIs = (int)en_WeekDays.FRIDAY;
            Console.WriteLine("Enum after converting to int (explicitly): " + dayIs);








            /*
             * Get User Input
             *      - You have already learned that Console.WriteLine() is used to output (print) values,
             *      - for input we use Console.ReadLine() 
             *          - Equivalent to cin>> in C++
             *      - Important: Console.ReadLine() always reads string.
             *      
             *      - The Console.ReadLine() method returns a string;
             *          Therefore, you cannot get information from another data type, such as int.
             *               - Therefore you should use casting when you read.  
            */

            Console.WriteLine("\n\nGetting user input:\n");
            
            Console.Write("Enter username?  "); 
            string UserName = Console.ReadLine();
            Console.WriteLine("\nYour Username is: " + UserName);

             Console.Write("\n\nEnter your age?  ");
            //if you dont convert you will get error; Becauseif you enter string you will get error
            int ageReading = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe Entered Age is:  " + ageReading);









            /*
             * |= (Bitwise OR Assignment)
             * ^= (Bitwise XOR Assignment)
             * >>= (Right Shift Assignment)
             * <<= (Left Shift Assignment)
             * => (Lambda Operator)
            */
            Console.WriteLine("\n\n=============================================");
            Console.WriteLine(" C# Compound Assignment Operators Visualization");
            Console.WriteLine("=============================================\n");
            int x = 5, y = 3; // Initial values for bitwise operations

            Console.WriteLine($"Initial values: x = {x} (Binary: {Convert.ToString(x, 2).PadLeft(8, '0')}), y = {y} (Binary: {Convert.ToString(y, 2).PadLeft(8, '0')})\n");

            // Bitwise OR Assignment (|=)
             x |= y;
            Console.WriteLine($"x |= y -> x = {x}");
            Console.WriteLine($"Binary: {Convert.ToString(x, 2).PadLeft(8, '0')} (Bitwise OR)\n");
            
            // Reset x
            x = 5;
            // Bitwise XOR Assignment (^=)
            x ^= y;
            Console.WriteLine($"x ^= y -> x = {x}");
            Console.WriteLine($"Binary: {Convert.ToString(x, 2).PadLeft(8, '0')} (Bitwise XOR)\n");

            // Reset x
            x = 5;
            
            // Right Shift Assignment (>>=)
            x >>= 1;
            Console.WriteLine($"x >>= 1 -> x = {x}");
            Console.WriteLine($"Binary: {Convert.ToString(x, 2).PadLeft(8, '0')} (Right Shift by 1)\n");
            
            // Reset x
            x = 5;

            // Left Shift Assignment (<<=)
            x <<= 1;
            Console.WriteLine($"x <<= 1 -> x = {x}");
            Console.WriteLine($"Binary: {Convert.ToString(x, 2).PadLeft(8, '0')} (Left Shift by 1)\n");

            // Lambda Expression (=>)
            Func<int, int> square = num => num * num;
            int result = square(5);
            Console.WriteLine($"Lambda Expression: x => x * x");
            Console.WriteLine($"square(5) = {result} (Returns x * x)");












            // Unary Operators
            //      - Unlike other operators, the unary operators operates on a single operand.
            // Unary Plus (+) → Leaves the sign as it is (but can convert negative to positive in some cases).
            // Unary Minus (-) → Inverts the sign of an operand.


            Console.WriteLine("\n\n=============================================");
            Console.WriteLine(" C# Unary Operators Demonstration");
            Console.WriteLine("=============================================\n");
            // Unary Plus (+)
            int a = -10;
            Console.WriteLine($"\t a = ({a})\n\n");

            int b = +a; // Unary plus retains the value, but converts if needed
            
            
            Console.WriteLine($"Unary Plus: +({a}) = {b}");

            // Unary Minus (-)
            int c = 10;
            int d = -c; // Changes sign
            Console.WriteLine($"Unary Minus: -({c}) = {d}");

            // Increment (++)
            int e = 5;
            Console.WriteLine($"Before Increment: e = {e}");
            e++;
            Console.WriteLine($"After Increment: e++ = {e}");

            // Decrement (--)
            int f = 5;
            Console.WriteLine($"Before Decrement: f = {f}");
            f--;
            Console.WriteLine($"After Decrement: f-- = {f}");

            // Logical Negation (!)
            bool isTrue = true;
            Console.WriteLine($"Before Negation: isTrue = {isTrue}");
            isTrue = !isTrue;
            Console.WriteLine($"After Negation: !isTrue = {isTrue}");









            // Ternary Operator
            //      - The ternary operator ? : operates on three operands.
            //          It is a shorthand for if-then-else statement. Ternary operator can be used as follows:
            //              - variable = Condition? Expression1 : Expression2;
            Console.WriteLine("\n\n\t\t---- Ternary Operator ----\n");

            Console.Write("Please enter a number:  ");
            int nbr = Convert.ToInt32(Console.ReadLine());
            bool isEven = (nbr % 2 == 0) ? true : false;
            Console.WriteLine("The Result: {0}" , isEven);









            /*
             * ~ (Bitwise Complement) → Inverts all bits.
             * & (Bitwise AND) → Performs AND operation on corresponding bits.
             * | (Bitwise OR) → Performs OR operation on corresponding bits.
             * ^ (Bitwise XOR) → Performs XOR operation on corresponding bits.
             * << (Bitwise Left Shift) → Shifts bits to the left, multiplying by powers of 2.
             * >> (Bitwise Right Shift) → Shifts bits to the right, dividing by powers of 2.
            */

            Console.WriteLine("\n\n=============================================");
            Console.WriteLine(" C# Bitwise and Bit Shift Operators Demonstration");
            Console.WriteLine("=============================================\n");

            int firstNumber = 5, secondNumber = 3; // Initial values for bitwise operations
            Console.WriteLine($"Initial values: firstNumber = {firstNumber} ({Convert.ToString(firstNumber, 2).PadLeft(8, '0')}), secondNumber = {secondNumber} ({Convert.ToString(secondNumber, 2).PadLeft(8, '0')})\n");

            // Bitwise Complement (~)
            int complement = ~firstNumber;
            Console.WriteLine($"Bitwise Complement: ~{firstNumber} = {complement}");
            Console.WriteLine($"Binary: {Convert.ToString(complement, 2).PadLeft(8, '0')} (All bits inverted)\n");

            // Bitwise AND (&)
            int andResult = firstNumber & secondNumber;
            Console.WriteLine($"Bitwise AND: {firstNumber} & {secondNumber} = {andResult}");
            Console.WriteLine($"Binary: {Convert.ToString(andResult, 2).PadLeft(8, '0')} (Only common 1s remain)\n");

            // Bitwise OR (|)
            int orResult = firstNumber | secondNumber;
            Console.WriteLine($"Bitwise OR: {firstNumber} | {secondNumber} = {orResult}");
            Console.WriteLine($"Binary: {Convert.ToString(orResult, 2).PadLeft(8, '0')} (1s in either operand remain)\n");

            // Bitwise XOR (^)
            int xorResult = firstNumber ^ secondNumber;
            Console.WriteLine($"Bitwise XOR: {firstNumber} ^ {secondNumber} = {xorResult}");
            Console.WriteLine($"Binary: {Convert.ToString(xorResult, 2).PadLeft(8, '0')} (1s where bits differ)\n");

            // Bitwise Left Shift (<<)
            int leftShift = firstNumber << 1;
            Console.WriteLine($"Left Shift: {firstNumber} << 1 = {leftShift}");
            Console.WriteLine($"Binary: {Convert.ToString(leftShift, 2).PadLeft(8, '0')} (Multiply by 2)\n");

            // Bitwise Right Shift (>>)
            int rightShift = firstNumber >> 1;
            Console.WriteLine($"Right Shift: {firstNumber} >> 1 = {rightShift}");
            Console.WriteLine($"Binary: {Convert.ToString(rightShift, 2).PadLeft(8, '0')} (Divide by 2)\n");








            Console.WriteLine("\n\n\t\t--- If then else if else Statment Control ---- :\n");
            int x2=10; int y2=20;
           
            //if then statement
            if (x2 == 10 && y2<=20)
            {
                Console.WriteLine("yes x = 10 and y<=20");
            }



            //if then else statement
            if (x2 == 11 )
            {
                Console.WriteLine("yes x = 11 ");
            }
            else
            {
                Console.WriteLine("yes x != 11 ");
            }


            //if else if statement
            int number = 12;

            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }
            else if (number > 5)
            {
                Console.WriteLine("{0} is greater than 5", number);
            }
            else if (number > 6)
            {
                Console.WriteLine("{0} is greater than 5 !!", number); 
            }
            else
            {
                Console.WriteLine("{0} is equal to 5");
            }


            /*
             * - Switch statement can be used to replace the if...else if statement in C#.
             * - The advantage of using switch over if...else if statement is the codes will look much cleaner and readable with switch.        - A problem with the switch statement is, when the matching value is found,
             *      it executes all statements after it until the end of switch block.
             * - To avoid this, we use break statement at the end of each case.
             *      - The break statement stops the program from executing non-matching statements 
             *          by terminating the execution of switch statement.
            */

            Console.WriteLine("\n\n\t\t--- Switch Controlling Statemnet ---- :\n");
            
            char enteredChr;
            Console.Write("Enter a letter?  ");
            enteredChr = Convert.ToChar(Console.ReadLine());
            switch(char.ToLower(enteredChr))
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not A Vowel");
                    break; 
            }

            Console.Write("Enter a letter?  ");
            enteredChr = Convert.ToChar(Console.ReadLine());
            switch(Char.ToLower(enteredChr))
            {
                case 'a':
                case 'e':
                case 'o':
                case 'u':
                case 'i':
                    Console.WriteLine("It is a Vowel");
                    break;
                default:
                    Console.WriteLine("Not A Vowel");
                    break; 
            }









            Console.WriteLine("\n\nSimple Calculator:\n");
            char op;
            double first, second, result2;

            Console.Write("Enter first number: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            op = (char)Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result2 = first + second;
                    Console.WriteLine("{0} + {1} = {2}", first, second, result2);
                    break;

                case '-':
                    result2 = first - second;
                    Console.WriteLine("{0} - {1} = {2}", first, second, result2);
                    break;

                case '*':
                    result2 = first * second;
                    Console.WriteLine("{0} * {1} = {2}", first, second, result2);
                    break;

                case '/':
                    result2 = first / second;
                    Console.WriteLine("{0} / {1} = {2}", first, second, result2);
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break; 
            }









            /*
             *  - Arrays Declaration:
             *      - datatype[] arrayName;
             *          - dataType - data type like int, string, char, etc
             *          - arrayName - it is an identifier
             *      - int[] age;
             *  - Array Defining:
             *      - To define the number of elements that an array can hold,
             *          - we have to allocate memory for the array in C#. For example,
             *              - int[] age = new int[5];
             *                  - new int[5] represents that the array can store 5 elements.
             *                      We can also say the size/length of the array is 5.
            */
            Console.WriteLine("\n\nDefining Arrays in C#:\n");

            int[] studentsAges = new int[5];
            string[] studentsNames;

            studentsNames = new string[5];

            studentsAges[0] = 18;
            studentsAges[1] = 22;
            studentsAges[2] = 33;
            studentsAges[3] = 34;
            studentsAges[4] = 55;
            studentsNames[0] = "Ahmad Omar";
            studentsNames[1] = "Mohammad Abu-Hadhoud";
            studentsNames[2] = "Abdulrhman Hirzallah";
            studentsNames[3] = "Ali Alesh";
            studentsNames[4] = "Sereen Abu Akleh";
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Index {0}\t Age = {1}\tName = {2}", i, studentsAges[i], studentsNames[i]);


            Console.WriteLine("\n\nArray Intialization:\n");
            // Note that we have not provided the size of the array.
            // the C# automatically specifies the size by counting the number of elements in the array (i.e. 5).
            int[] myArray = { 5132, 12323, 123, 54, 87645 };
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Index {0}\t ArrayNumber = {1}", i, myArray[i]);


             int[] numbers = { 1, 2, 3 };

            //access first element
            Console.WriteLine("Element in first index : " + numbers[0]);
            //access second element
            Console.WriteLine("Element in second index : " + numbers[1]);
            //access third element
            Console.WriteLine("Element in third index : " + numbers[2]);

            //through loop
            Console.WriteLine("\nAccess array using loop:\n");
            for (int i = 0;i < numbers.Length; i++)
                Console.WriteLine("Element in index {0} : {1} " ,i, numbers[i]);








            //  ***** Two-Dimensional Arrays
            
            //  - x is a two-dimensional array with 2 elements. And, each element is also an array with 3 elements.
            //      - All together the array can store 6 elements (2 * 3).
            
            int[ , ] my2DArray = new int[2, 3];     // Declaration

            int[ , ] my2DArray2x3 = { { 1, 2 ,3}, { 3, 4, 5 } };

            int [ , ] another2DArray2x3 = new int[2, 3] { {1, 2, 3}, {3, 4, 5} };
            
            // access first element from the first row 
            Console.WriteLine("Element at index [0, 0] : " + another2DArray2x3[0, 0]);

            // access first element from second row
            Console.WriteLine("Element at index [1, 0] : " + another2DArray2x3[1, 0]);








            //  ********    foreach  loop

            Console.WriteLine("\n\nUsing the foreach loop;; printing array of chars of my name:\n");
            char[] CharsArray = new char[5] { 'A', 'h', 'm', 'a', 'd' } ;
            foreach (char anChar in CharsArray)
                Console.Write(anChar);


            Console.WriteLine("\n\nforeach loop;; printing array of chars processing an array of gender :\n");
            char[] Genders = new char[10] { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
            int malesCount = 0, femalesCount = 0;

            foreach(char anChar in Genders)
            {
                if (anChar == 'm')
                    malesCount++;
                if (anChar == 'f')
                    femalesCount++; 
            }
            Console.WriteLine("Number of Males = {0}", malesCount);
            Console.WriteLine("Number of Femals = {0}", femalesCount);







            /*
             *  - Array Operations using System.Linq
             *      - In C#, we have the System.Linq namespace that provides 
             *          different methods to perform various operations in an array.
            */

            Console.WriteLine("\n\nUsing the System.Linq namespace methods and operations:\n");
            int[] ArrayOfNbrs = { 51, -1, 2,14,18, 40, 178 };

            // get the minimum element
            Console.WriteLine("Smallest element is:\t{0}", ArrayOfNbrs.Min());

            // Max() returns the largest number in array
            Console.WriteLine("Largest number/element in the array is:\t{0}", ArrayOfNbrs.Max());

            // Return the Count
            Console.WriteLine("The Count of elements in the array:\t{0}", ArrayOfNbrs.Count());

            // Compute elements summation
            Console.WriteLine("The summation of the numbers:\t{0}", ArrayOfNbrs.Sum());
            
            // compute the average
            Console.WriteLine("The Average of the numbers:\t{0}", ArrayOfNbrs.Average());








            /*
             *  - C# Math
             *      - The C# Math class has many methods that allows you to perform mathematical tasks on numbers.
             *      - The Math.Max(x,y) method can be used to find the highest value of x and y.
             *      - The Math.Min(x,y) method can be used to find the lowest value of of x and y.
             *      - The Math.Sqrt(x) method returns the square root of x
             *      - The Math.Abs(x) method returns the absolute (positive) value of x.
             *      - Math.Round() rounds a number to the nearest whole number.
            */

            Console.WriteLine("\n\nUsing the Math Class methods and operations:\n");

            Console.WriteLine("Max of 5, 10 is: {0}", Math.Max(5, 10));
            Console.WriteLine("Min of 5, 10 is: {0}", Math.Min(5,10));
            Console.WriteLine("Square Root of 64 is: {0}", Math.Sqrt(64));
            Console.WriteLine("Absolute (positive) value of  -4.7 is: {0}", Math.Abs(-4.7));
            Console.WriteLine("Round of 9.99: {0}", Math.Round(9.99));
            Console.WriteLine("Ceiling of 9.99: {0}", Math.Ceiling(9.99));
            Console.WriteLine("Floor of 9.99: {0}", Math.Floor(9.99));








            /*
             *  - A method is a block of code which only runs when it is (called).
             *  - You can pass data, known as (parameters), into a method.
             *  - Methods are used to perform certain actions, and they are also known as functions.
             *  - C# is a fully OOP language , you cannot create a method outside class.
             *  - You should use static if you want to call the method without having object.
             *  - Parameters and Arguments:
             *      - Information can be passed to methods as parameter.
             *      - Parameters act as variables inside the method.
             *      - They are specified after the method name, inside the parentheses.
             *      - You can add as many parameters as you want, just separate them with a comma.
             *      - Default Parameter Value
             *          - You can also use a default parameter value, by using the equals sign (=).
             *      - If you want the method to return a value, you can use a primitive data type;
             *          (such as int or double) instead of void, and use the return keyword inside the method.
             *      - C# Named Arguments:
             *          - It is also possible to send arguments with the key: value syntax.
             *          - That way, the order of the arguments does not matter.
             *          - Reordering: If you want to pass arguments in a different order than the method’s parameter list,
             *              you must specify each parameter name exactly as it appears in the method definition
             *          - Clarity: Named arguments can make the purpose of each argument clearer,
             *              especially when there are many parameters or when some are optional.
             *          - Optional Parameters: If a method has optional parameters (with default values),
             *              you can skip certain parameters by specifying only those you need by name.
             *      - OverLoading:
             *          With method overloading, multiple methods can have the same name with different parameters.  
            */

            Console.WriteLine("\n\nCalling methods and Functions in C#:\n");

            printName("Ahmad Omar Ibarhim Hirzallah");

            string anName = "Ahmad Omar Ibarhim Hirzallah";
            Console.WriteLine("\nAnother Method with parameters:\n");
            printUserInfo(anName, 24);

            Console.WriteLine("\nAnother Method with default parameter value:\n");
            anName = "Ahmad Hirzallah";
            PrintClientInfo(anName, 25, "Amman/Jordan");
            PrintClientInfo(anName, 25);        // Will take the default value of the function's parameter.
            PrintClientInfo(anName, 25, null);  // will print empty string "" as address; In address nothing will be displayed.


            Console.WriteLine("\nAnother Method with return type (Not void):\n");
            Console.WriteLine("My Name is:\t{0}", GetMyName());
            Console.WriteLine("My Name is:\t{0}", GetMyName("Mohammed Abu-Hadhoud"));

            





            Console.WriteLine("\n\nC# Named Arguments (key:value):\n");

            //  - see the order of sending parameters is not important in this case;
            //      Passing parameters in a different order by using named arguments:
            PrintYoungestChild(child3: "Aya", child1: "Ahmad", child2: "Abood");
            PrintOldestChild(child3: "Aya", child1: "Ahmad", child2: "Abood");







            Console.WriteLine("\n\nC# Overloading of Methods/Functions:\n");
            Console.WriteLine(Sum(10, 20));
            Console.WriteLine(Sum(10, 20,30));
            Console.WriteLine(Sum(10, 20, 30.383D , 40.94181243D));







            /*
             *  - C# Exceptions - Try..Catch
             *      - When executing C# code, different errors can occur:
             *          - coding errors made by the programmer, errors due to wrong input,
             *              or other unforeseeable (غير متوقع) things.
             *      - When an error occurs, C# will normally stop and generate an error message.
             *          - The technical term for this is: C# will throw an exception (throw an error).
             *  - C# try and catch
             *      - The try statement allows you to define a block of code to be tested for errors while it is being executed.
             *      
             *      - The catch statement allows you to define a block of code to be executed; 
             *          only if an error occurs in the try block.
             *          
             *      - The try and catch keywords come in pairs:
            */

            Console.WriteLine("\n\nC# Exceptions; (try) and (catch):\n");
            try
            {
                int[] myIntegers = { 1, 2, 3 };
                Console.WriteLine("Array Element 10 is:\t{0}", myIntegers[10]); 
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);   // This will print:     Index was outside the bounds of the array.  
            }








            Console.WriteLine("\n\nGenerating Random Number in Min to Max Range:\n");

            //  - Use the Next(int min, int max) overload method to get
            //      a random integer that is within a specified range.
            Random rand = new Random();
            Console.WriteLine("Generating a nbr which (nbr >= 10 & nbr < 20):");
            for (int i = 0; i < 30; i++)
                Console.Write("{0}\t", rand.Next(10,20));   // returns random integers >= 10 and < 20








        }

    }
  
}

