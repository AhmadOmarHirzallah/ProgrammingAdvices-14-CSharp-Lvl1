using System;

namespace C__Syntax1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello :0 ");     // Without Newline
            Console.WriteLine("World");     // With Newline



            Console.WriteLine("\n\nHello Guys;");
            Console.WriteLine("My name is Ahmad");
            Console.WriteLine("I am learning C#");
            Console.WriteLine("The sum of 10 + 20 is  =  " + 10 + 20);
            Console.WriteLine("The sum of (10 + 20) is  =  " + (10 + 20));


            Console.Write("Hello");
            Console.Write("Hello;; No new line :)");
            Console.Write("Yes you can see this :(");



            // Formatting the Strings (Formatted String)
            Console.WriteLine("\n\n\nFirst Name: {0} -> Family Name: {1}", "Ahmad", "Hirzallah");
            Console.WriteLine("As a {0}; I will give you some money as you asked;\nMoney Taker: {1}\n\n", "Good Person", "Thank You Very Much");



            //   Escape Characters
            Console.WriteLine("Usefull Escape Characters:\n\n");


            Console.WriteLine("\\n:\tWelcome to\n\"Learning C# Journey\"\n\n");
            Console.WriteLine("\\t:\tWelcome\t\tTo This Nice\t\t\tJoruney");
            Console.WriteLine("\\b:\tWelcome To\bProgrammingAdvices");
            Console.WriteLine("\\b:\tWelcome To \bProgrammingAdvices");
            Console.WriteLine("\\b multiple times(6):\tWelcome To\b\b\b\b\b\bProgrammingAdvices");
            Console.WriteLine("\\':\t\'Ahmad\'");
            Console.WriteLine("\\\":\t\"Ahmad\"");
            Console.WriteLine("\\\\:\t\\");
            Console.WriteLine("\\\\ multiple times; but notice it should be even number of \\ (14) in our case; or it's syntax error! :\t \\\\\\\\\\\\\\");
            Console.WriteLine("\\a:(Alerting)\t:\a");



            //  *********   COMMENTS ************

            // THIS IS SINGLE COMMENT
            /*
                THIS IS MULTIPLE LINES COMMENTS :)
             */


            Console.WriteLine("\n\nVariables in C#:\n\n");

            double x;
            int y = 10;
            string MyName = "Ahmad Omar Ibraheem";
            bool is_true = false;
            char myLetter = 'A';
            long long_nbr = 127372317217372;


            x = 5.84712D;

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = {0}", y);
            Console.WriteLine("My Name is: {0}", MyName);
            Console.WriteLine("My Name is: " + MyName);
            Console.WriteLine("My Letter: " + myLetter);
            Console.WriteLine("My Letter: {0}", myLetter);
            if (is_true)
                Console.WriteLine("Yes is true");
            else
                Console.WriteLine("No it is false");
            Console.WriteLine("My Long Number {0}", long_nbr);
            Console.WriteLine("Formatted string:\tx + y = ({0})", x + y);
            Console.WriteLine("Concatenation:\ty + x = " + y + x);
            Console.WriteLine("Concatenation with priories:\t(x + y) = " + (x + y));


            /*
             * Implicitly Typed Variables (ضمني غير مصرح فيه)
             * Like auto in C++
             * In C# -> (var) keyword is used
             *  - Variables declared using var keyword HAVE TO BE
             *     DEFINED (INITIALIZED and GIVEN A VALUE) WHEN IT'S DECLARED.
            */

            var var1 = 10;
            var var2 = 10.5;
            var var3 = "Ahmad is my 1'st Name";

            Console.WriteLine("\n\n\nImplicitly type variables (With var Keyword):");
            Console.WriteLine("var1 = {0},\tvar2 = {1},\tvar3 = {2}\n\n", var1, var2, var3);


            /*
             * Datatypes in C#:
             *  1. Value Types: Variables stores values inside it; 
             *      - Integrals as: sbyte (means signed byte) - byte - 
             *          short - ushort (means unsigned short) 
             *          - int - uint - long - ulong
             *      
             *      - Characters: char
             *      
             *      - Floating : float - double 
             *      
             *      - Decimal : decimal (like float and double but bigger and more accurate)
             *      
             *      - Boolean : bool
             *      
             *      - Enum Types, Struct Types, Nullable Types
             *  
             *  2. Reference Types: Variables store a reference/address and these have pointers to references in heap !
             *  
             *      - Class Types: 
             *          - Object
             *          - String
             *          - Class
             *          
             *      - Interface Types
             *      
             *      - Array Types
             *      
             *      - Delegate Types
            */

            // All these are Called Predefined Datatypes
            int Nbr1 = 1;
            System.Int32 asNbr1 = 1;
            if (Nbr1 == asNbr1)
                Console.WriteLine("Both Datatypes are the same (int = System.Int32)!");


            long Nbr2 = 1;
            System.Int64 asNbr2 = 1012393129;
            if (Nbr2 == asNbr2)
                Console.WriteLine("Both Datatypes are the same (long = System.Int64)!");


            float Nbr3 = 1012393129.123F;
            System.Single asNbr3 = 1012393129.123F;
            if (Nbr3 == asNbr3)
                Console.WriteLine("Both Datatypes are the same (float = System.Single)!");

            double Nbr4 = 1012393129.123F;
            System.Double asNbr4 = 1012393129.123F;
            if (Nbr4 == asNbr4)
                Console.WriteLine("Both Datatypes are the same (double = System.Double)!");

            decimal Nbr5 = 12345678901234567890;
            System.Decimal asNbr5 = 12345678901234567890;
            if (Nbr5 == asNbr5)
                Console.WriteLine("Both Datatypes are the same (decimal = System.Decimal)!");


            char myChar = 'A';  // This is 2 bytes
            System.Char asMyChar = 'A';
            if (myChar == asMyChar)
                Console.WriteLine("Both Datatypes are the same (char = System.Char)!");

            byte myByte = 50; // Range from 0 to 255 (Yes byte is unsigned)
            sbyte mySignedByte = 120; // Range from -128 to 127 
            short myShort = 2377;
            ushort myUnsignedShort = 8123;
            int myInteger = 128382;
            uint myUnsignedInteger = 1127373217u;
            long myLong = 182383128132l;
            ulong myUnsignedLong = 1238128381328123132ul;
            float myFloat = 182381123124.124f;
            double myDouble = 1283128381328123812.12372174d;
            decimal myDecimal = 12345678901234567890m; // 20 digit only :)
            char myCharacter = 'Z';
            bool myBool = true;
            string myString = "Ahmad is the Strongest";
            DateTime a;



            //Byte

            byte b1 = 255;
            //  byte b2 = -128;// compile-time error: Constant value '-128' cannot be converted to a 'byte'
            sbyte sb1 = -128;
            sbyte sb2 = 127;
            Console.WriteLine("\nByte:");
            Console.WriteLine("Min={0} , Max={1}", Byte.MinValue, Byte.MaxValue);


            Console.WriteLine("\nSByte:");
            Console.WriteLine("Min={0} , Max={1}", SByte.MinValue, SByte.MaxValue);

            //Short
            short s1 = -32768;
            short s2 = 32767;
            // short s3 = 35000;//Compile-time error: Constant value '35000' cannot be converted to a 'short'

            ushort us1 = 65535;
            //  ushort us2 = -32000; //Compile-time error: Constant value '-32000' cannot be converted to a 'ushort'

            Console.WriteLine("\nShort:");
            Console.WriteLine("Min={0} , Max={1}", Int16.MinValue, Int16.MaxValue);

            Console.WriteLine("\nUShort:");
            Console.WriteLine("Min={0} , Max={1}", UInt16.MinValue, UInt16.MaxValue);

            //int
            int i = -2147483648;
            int j = 2147483647;
            //  int k = 4294967295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.

            uint ui1 = 4294967295;
            // uint ui2 = -1; //Compile-time error: Constant value '-1' cannot be converted to a 'uint'

            Console.WriteLine("\nInt:");
            Console.WriteLine("Min={0} , Max={1}", Int32.MinValue, Int32.MaxValue);

            Console.WriteLine("\nUInt:");
            Console.WriteLine("Min={0} , Max={1}", UInt32.MinValue, UInt32.MaxValue);

            //Long
            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;

            ulong ul1 = 18223372036854775808ul;
            ulong ul2 = 18223372036854775808UL;

            Console.WriteLine("\nLong:");
            Console.WriteLine("Min={0} , Max={1}", Int64.MinValue, Int64.MaxValue);

            Console.WriteLine("\nULong:");
            Console.WriteLine("Min={0} , Max={1}", UInt64.MinValue, UInt64.MaxValue);


            //Float
            float f1 = 123456.5F;
            float f2 = 1.123456f;

            Console.WriteLine("\nFloat:");
            Console.WriteLine("Min={0} , Max={1}", Single.MinValue, Single.MaxValue);
            //Console.WriteLine("Min={0} , Max={1}", float.MinValue, float.MaxValue);


            //double
            double d1 = 12345678912345.5d;
            double d2 = 1.123456789123456d;

            Console.WriteLine("\nDouble:");
            Console.WriteLine("Min={0} , Max={1}", Double.MinValue, System.Double.MaxValue);
            //Console.WriteLine("Min={0} , Max={1}", double.MinValue, double.MaxValue);



            //Decimal
            //The decimal type has more precision and a smaller range
            //than both float and double,
            //and so it is appropriate for financial and monetary calculations.
            decimal d3 = 123456789123456789123456789.5m;
            decimal d4 = 1.1234567891345679123456789123m;

            Console.WriteLine("\nDecimal:");
            Console.WriteLine("Min={0} , Max={1}", System.Decimal.MinValue, System.Decimal.MaxValue);
            //Console.WriteLine("Min={0} , Max={1}", decimal.MinValue, decimal.MaxValue);


            //Scientific Notation
            //Use e or E to indicate the power of 10 
            //as exponent part of scientific notation with float, double or decimal.
            double d = 0.12e2d;
            Console.WriteLine("\n\n{0} is written as 0.12e2 ; e2 = 10 ^ 2 ", d);  // 12;

            float f = 123.45e-2f;
            Console.WriteLine("123.45e-2f is equal: {0}", f);  // 1.2345

            decimal m = 1.2e6m;
            Console.WriteLine("1.2e6m is equal: {0}", m);  // 1.2345
            Console.WriteLine(m);// 1200000

            double e_try = 1e5;
            Console.WriteLine("1e5 = {0}", e_try);
            e_try = 1e-5d;
            Console.WriteLine("1e-5 = {0}", e_try);
            e_try = 12345e-2d;
            Console.WriteLine("12345e-2d = {0}", e_try);
            e_try = 12345e-4d;
            Console.WriteLine("12345e-4d = {0}", e_try);
            e_try = 12345e-5d;
            Console.WriteLine("12345e-5d = {0}", e_try);
            e_try = 12345e-6d;
            Console.WriteLine("12345e-6d = {0}", e_try);



            //hex & Binary
            int hex = 0x2F;
            int binary = 0b_0010_1111;

            Console.WriteLine("Hexa: 0x2F is = {0}", hex);
            Console.WriteLine("Binary: 0b_0010_1111 is = {0}", binary);

            // Sometimes console close fast problem ! ;So this will make it wait :)
            Console.ReadKey(); // Just like system("pause"); in c++
        }
    }
}
