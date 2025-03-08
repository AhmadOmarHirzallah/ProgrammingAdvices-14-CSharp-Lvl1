using System;

namespace C__Syntax2
{
    class Program
    {
        enum e_WeekDays
        {
            SUNDAY,
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY
        }

        //if you set a value , it will auto number everything after it.
        public enum e_Categories
        {
            Electronics,    // 0
            Food,           // 1
            Automotive = 6, // 6
            Arts,           // 7
            BeautyCare,     // 8
            Fashion         // 9
        }


        struct s_Student
        {
            public string Firstname;
            public string Lastname;
        }
        static void Main(string[] args)
        {

            /*
             * Default Values
             * Every data type has a default value;
             *      - Numeric type is 0, boolean has false, and char has '\0' as default value.
             *      - Use the default(typename) to assign a default value of the data type 
             *      - or C# 7.1 onward, use default literal
             */
            //get default value using default(type)
            int i = default(int); // 0
            float f = default(float);// 0
            decimal d = default(decimal);// 0
            bool b = default(bool);// false
            char c = default(char);// '\0'
            Console.WriteLine("Varaiables:");
            Console.WriteLine("(int)i: {0}\t (float)f: {1}\t (decimal)d: {2}", i, f, d);
            Console.WriteLine("(bool)i: {0}\t (char)f: {1}", b, c);

            // C# 7.1 onwards
            //get default value using default
            int i2 = default; // 0
            float f2 = default;// 0
            decimal d2 = default;// 0
            bool b2 = default;// false
            char c2 = default;// '\0'
            Console.WriteLine("\n\n(int)i2: {0}\t (float)f2: {1}\t (decimal)d2: {2}", i2, f2, d2);
            Console.WriteLine("(bool)i2: {0}\t (char)f2: {1}", b2, c2);

            /*
             * Error in Compiler; because you don't assign default value to variables
             * - Undefined variables will arrise error
             * - Compiler error : Use of unassigned local variable {var name}
            */
            int i3;
            float f3;
            decimal d3;
            bool b3;
            char c3;

            // - Compiler Error in below:

            //Console.WriteLine("\n\n(int)i3: {0}\t (float)f3: {1}\t (decimal)d3: {2}", i3, f3, d3);
            //Console.WriteLine("(bool)i3: {0}\t (char)f3: {1}", b3, c3);






            /*
             * Enums in C# is the Same as C++
             * however you can specify a type for Enum :-)
            */

            Console.WriteLine("\n\nEnums:\n");
            e_WeekDays WeekDayIs = e_WeekDays.FRIDAY;

            // It will be printed as String !!!
            Console.WriteLine("Week Day is: {0}", WeekDayIs);   // Output: Week Day is: FRIDAY

            WeekDayIs = e_WeekDays.SUNDAY;
            Console.WriteLine("Week Day is: {0}", WeekDayIs);   // Output: Week Day is: SUNDAY
            WeekDayIs = e_WeekDays.THURSDAY;
            Console.WriteLine("Week Day is: {0}", WeekDayIs);   // Output: Week Day is: THURSDAY


            e_Categories Category = e_Categories.Automotive;
            Console.WriteLine("\nThe Choosen Category is: {0}", Category);
            Category = e_Categories.Fashion;
            Console.WriteLine("The Choosen Category is: {0}", Category);
            Category = e_Categories.BeautyCare;
            Console.WriteLine("The Choosen Category is: {0}", Category);









            /*
             * Nullable Types
             *  - As you know, a value type cannot be assigned a null value.
             *  - For example, int i = null will give you a compile time error.
             *  - C# 2.0 introduced nullable types that allow you to assign null to value type variables.
             *      - You can declare nullable types using Nullable<t> where T is a type.
             *      - Nullable <int> i = null;
             *  - example:
             *      - Nullable<int>
             *          - This can be assigned any value from -2147483648 to 2147483647, or a null value.
            */

            //  Nullable<int> can be assigned any value
            //  from -2147483648 to 2147483647, or a null value.

            Nullable<int> nullableInteger = null;
            Console.WriteLine("\n\nThe Nullable as <t> = <i> variable result as (null) is : ({0})", nullableInteger);
            nullableInteger = Int32.MaxValue;
            Console.WriteLine("The Nullable varaible value: ({0})", nullableInteger);
            nullableInteger = Int32.MinValue;
            Console.WriteLine("The Nullable varaible value: ({0})", nullableInteger);









            /* 
             * C# - Anonymous Type
             *      - In C#, an anonymous type is a type (class) without any name
             *          that can contain public read-only properties only.
             *      - It cannot contain other members, such as fields, methods, events, etc.
            */

            var student = new { Id = 20, FirstName = "Mohammed", LastName = "Abu-Hadhoud" };
            Console.WriteLine("\n\n\nC# - Anonymous Type:\n");
            Console.WriteLine(student.Id); //output: 20
            Console.WriteLine(student.FirstName); //output: Mohammed
            Console.WriteLine(student.LastName); //output: Abu-Hadhoud

            //You can print like this:
            Console.WriteLine("Print all using variable name without specifying any property:\n{0}", student);


            //  - anonymous types are read-only
            //  - you cannot change the values of properties as they are read-only. 
            //student.Id = 2;   //Error: cannot chage value
            //student.FirstName = "Ali";    //Error: cannot chage value



            //An anonymous type's property can include another anonymous type.
            var studentAnonymousType = new
            {
                Id = 20,
                FirstName = "Ahmad",
                LastName = "Hirzallah",
                Address = new { Id = 1, City = "Amman", County = "Jordan", ZIP_Code = "123ZASDD9" }
            };

            Console.WriteLine("\n\n2nd Anonymous Type:\n");
            Console.WriteLine(studentAnonymousType.Id);
            Console.WriteLine(studentAnonymousType.FirstName);
            Console.WriteLine(studentAnonymousType.LastName);
            Console.WriteLine(studentAnonymousType.Address);
            Console.WriteLine(studentAnonymousType.Address.Id);
            Console.WriteLine(studentAnonymousType.Address.City);
            Console.WriteLine(studentAnonymousType.Address.County);
            Console.WriteLine(studentAnonymousType.Address.ZIP_Code);
            Console.WriteLine(studentAnonymousType);









            /*
             * C# - Struct
             *      - In C#, struct is the value type data type that represents data structures.
             *      - struct can be used to hold small data values that do not require inheritance;;
             *              - e.g. coordinate points, key-value pairs, and complex data structure.
             *      - A struct object can be created with or without the new operator, same as primitive type variables.
             *      - If you declare a variable of struct type without using new keyword,
             *              - it does not call any constructor, so all the members remain unassigned.
             *              - Therefore, you must assign values to each member before accessing them,
             *                  otherwise, it will give a compile-time error.
             *      - using new does not mean it's allocated in heap (not always in heap; as in our case of struct definition).
             *      - structure is allocated in stack as long as it's not part of class.
             */

            //A struct object can be created with or without the new operator,
            //same as primitive type variables.

            s_Student StudentObj;
            s_Student StudentObj2 = new s_Student();

            StudentObj.Firstname = "Ahmad";
            StudentObj.Lastname = "Hirzallah";
            Console.WriteLine("\n\n\nStructure (struct):\n");
            Console.WriteLine("Full Name using struct properties: {0} {1}", StudentObj.Firstname, StudentObj.Lastname);

            Console.WriteLine("The Structure with (new) values are: {0} {1}\n", StudentObj2.Firstname, StudentObj2.Lastname);
            if (StudentObj2.Firstname == null)
                Console.WriteLine("StudentObj2.Firstname == null is true");
            else
                Console.WriteLine("StudentObj2.Firstname == null is false");
            StudentObj2.Firstname = "Mohammad";
            StudentObj2.Lastname = "Abu-Hadhoud";

            Console.WriteLine("\nThe Structure with (new) values After Intialization are: {0} {1}\n", StudentObj2.Firstname, StudentObj2.Lastname);
            if (StudentObj2.Firstname == null)
                Console.WriteLine("StudentObj2.Firstname == null is true");
            else
                Console.WriteLine("StudentObj2.Firstname == null is false");









            /*
             * C# - Dynamic Types
             *      - C# 4.0 (.NET 4.5) introduced a new type called dynamic that avoids compile-time type checking.
             *      - A dynamic type escapes type checking at compile-time; instead, it resolves type at run time.
             *      - A dynamic type variables are defined using the dynamic keyword.
            */

            dynamic myDynamicVar = 100;
            Console.WriteLine("\n\n\nDynamic Types variable as (dynamic myVar;)\n");
            Console.WriteLine("Value: {0}, Type: {1}", myDynamicVar, myDynamicVar.GetType());
            myDynamicVar = "Ahmad Hirzallah Studying Programming Advices";
            Console.WriteLine("Value: {0}, Type: {1}", myDynamicVar, myDynamicVar.GetType());
            if (myDynamicVar.GetType() == typeof(string))
                Console.WriteLine("True!\tType is String.");
            myDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", myDynamicVar, myDynamicVar.GetType());
            if (myDynamicVar is int)
                Console.WriteLine("True!\tType is int.");
            else
                Console.WriteLine("False!\tType ISNOT int; it is {0}.", myDynamicVar.GetType());

            myDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", myDynamicVar, myDynamicVar.GetType());
            if (myDynamicVar.GetType() == typeof(DateTime))
                Console.WriteLine("True!\tType is DateTime.");
            else
                Console.WriteLine("False!\tType ISNOT DateTime; it is {0}.", myDynamicVar.GetType());









            /*
             * Working with Date and Time in C#
             *      - C# includes DateTime struct to work with dates and times.
             *      - To work with date and time in C#, create an object of the DateTime struct using the new keyword.
             *      - The following creates a DateTime object with the default value.
             *          - DateTime dt = new DateTime(); // assigns default value 01/01/0001 00:00:00
             *      - The default and the lowest value of a DateTime object is January 1, 0001 00:00:00 (midnight).
             *      - The maximum value can be December 31, 9999 11:59:59 P.M.
             */

            //  - assigns default value 01/01/0001 00:00:00 
            DateTime dt1 = new DateTime();

            //  - assigns year, month, day
            DateTime dt2 = new DateTime(2023, 12, 31);

            DateTime dtToday = new DateTime(2025, 3, 7);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2025, 3, 7, 12, 43, 00);


            //assigns year, month, day, hour, min, seconds, UTC timezone 
            DateTime dt4 = new DateTime(2025, 3, 7, 1, 00, 00, DateTimeKind.Utc);

            Console.WriteLine("\n\nDate And Time:");
            Console.WriteLine("dt1 (default empty constructor): {0}\ndt2 (filled constructer (y,m,d): {1}", dt1, dt2);
            Console.WriteLine("dtToday (Valide today date): {0}\ndt3 (data & time (y,m,d,H,M,S): {1}", dtToday, dt3);
            Console.WriteLine("dt4 (date & time (y,m,d, H,M,S,DateTimeKind(Local,Utc,Unspecified): {0}", dt4);


            // Current Datetime in C#
            //      - you can get the current date time using :
            DateTime CurrentDateTime = new DateTime();
            CurrentDateTime = DateTime.Now;
            Console.WriteLine("\n\nThe Current 100% Date Time using (DateTime.Now): {0}", CurrentDateTime);




            /*
             * Ticks
             *      - Ticks is a date and time expressed in the number of 100-nanosecond intervals
             *          that have elapsed since January 1, 0001, at 00:00:00.000 in the Gregorian calendar.
             *      - A single tick represents one hundred nanoseconds or one ten-millionth of a second.
             *      - There are 10,000 ticks in a millisecond and 10 million ticks in a second.
            */

            //  -  number of 100-nanosecond intervals that have elapsed
            //      since January 1, 0001, at 00:00:00.000 in the Gregorian calendar. 

            DateTime TicksDateTime = new DateTime();
            Console.WriteLine("\n\nTicks Of DateTime:\n");
            Console.WriteLine("Ticks of DateTime.MinValue = {0}", DateTime.MinValue.Ticks);     // min value of ticks
            Console.WriteLine("Ticks of DateTime.MaxValue = {0}", DateTime.MaxValue.Ticks);     // max value of ticks





            /*
             * - DateTime Static Fields
             *      - The DateTime struct includes static fields, properties, and methods.
             *      - The following example demonstrates important static fields and properties.
            */

            DateTime CurrentDtTm = DateTime.Now;            //  returns current date and time
            DateTime TodaysDate = DateTime.Today;           //  returns today's date
            DateTime CurrentDtTmUTC = DateTime.UtcNow;      //  returns current UTC date and time
            DateTime maxDateTimeValue = DateTime.MaxValue;  //  returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue;  //  returns min value of DateTime

            Console.WriteLine("\n\nStatic Fields of DateTime Struct:\n");
            Console.WriteLine("Current Date & Time using DateTime.Now: {0}", CurrentDateTime);
            Console.WriteLine("Today Date using DateTime.Today: {0}", TodaysDate);
            Console.WriteLine("Current Utc Date using DateTime.UtcNow: {0}", CurrentDtTmUTC);
            Console.WriteLine("minDateTimeValue: " + minDateTimeValue);
            Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);








            /*
             *  - TimeSpan
             *      - TimeSpan is a struct that is used to 
             *          represent time in days, hour, minutes, seconds, and milliseconds.
            */

            DateTime ADt = new DateTime(2025, 1, 1);

            // Hours, Minutes, Seconds
            TimeSpan TmSpan = new TimeSpan(23, 25, 30);

            Console.WriteLine("\n\nTime Spance (TimeSpan) struct:\n");
            Console.WriteLine("Time Span Printing: {0}", TmSpan);
            Console.WriteLine("Time Span Days Printing (TmSpan.Days): {0}", TmSpan.Days);
            Console.WriteLine("Time Span Hours Printing (TmsSpan.Hours): {0}", TmSpan.Hours);
            Console.WriteLine("Time Span Minutes Printing (TmSpan.Minutes): {0}", TmSpan.Minutes);
            Console.WriteLine("Time Span Seconds Printing (TmSpan.Seconds): {0}", TmSpan.Seconds);
            Console.WriteLine("A random DateTime: {0}", ADt);

            // - We can use the TimeSpan to be added into the Date:
            //      - This will add time span to the date.
            DateTime newDate = ADt.Add(TmSpan);
            Console.WriteLine("The new Date after adding a TimeSpan into it as: [DateTime newDate = ADt.Add(TmSpan)] = " + newDate);

            DateTime newDate2 = DateTime.Now;
            Console.WriteLine("A Now DateTime: {0}", newDate2);
            newDate2 = newDate2.Add(TmSpan);
            Console.WriteLine("The new Date after adding a TimeSpan into it as: [newDate2 = newDate2.Add(TmSpan): " + newDate);

            /*
             *  - When you add a TimeSpan to a DateTime using Add(), both the time and the date can be affected
             *      if the time exceeds a 24-hour boundary.
             *  - 
             *  - The TimeSpan object does not modify the original DateTime instance because DateTime is an immutable struct in C#. 
             *  - When you use Add() with a TimeSpan, it returns a new DateTime object with the added value
             *       rather than changing the original object.
             *  - newDate2 = newDate2.Add(TmSpan);
             *  
             *  - How to properly add TimeSpan without losing the old date:
            */
            DateTime originalDate = new DateTime(2025, 1, 1);
            TimeSpan timeSpan = new TimeSpan(23, 25, 30);
            Console.WriteLine("\n\nOriginal Date: " + originalDate);
            DateTime newDate3 = originalDate.Add(timeSpan);
            Console.WriteLine("After Adding TimeSpan: " + newDate3);
            Console.WriteLine("Original Date (Unchanged): " + originalDate);

            DateTime dt = new DateTime(2025, 3, 7, 14, 19, 0); // 3/7/2025 at 2:19 PM
            TimeSpan span = new TimeSpan(3, 0, 0);            // 3 hours
            DateTime newDate4 = dt.Add(span);
            Console.WriteLine("\nOriginal Date (Unchanged): " + dt);
            Console.WriteLine("Updated Date adding 3 hours: " + newDate4);  // {3/7/2025 at 2:19 PM  -> Updated Date: 3/7/2025 5:19:00 PM}


            //  - When does the date change?
            //      - If the time addition crosses midnight, the date automatically increments.

            DateTime dtTmp = new DateTime(2025, 3, 7, 23, 30, 0); // 11:30 PM
            TimeSpan span2 = new TimeSpan(2, 0, 0);             // Add 2 hours
            DateTime newDate5 = dtTmp.Add(span2);
            Console.WriteLine("\nOriginal Date (Unchanged): " + dtTmp);
            Console.WriteLine("The TimeSpan: " + span2);
            Console.WriteLine("Updated Date: " + newDate5);
            //  The day changes because 23:30 + 2 hours = 01:30 AM (which is the next day).






            // Subtraction of two dates results in TimeSpan
            DateTime OrignalDt1 = new DateTime(2025, 1, 20);
            DateTime Dt2 = new DateTime(2025, 1, 25);

            TimeSpan Result = Dt2.Subtract(OrignalDt1);
            Console.WriteLine("\n\nDate Subtraction:\n");
            Console.WriteLine("Original Date: " + OrignalDt1);
            Console.WriteLine("Date 2 (Subtration is from it):  " + Dt2);
            Console.WriteLine("The Result: " + Result);


            DateTime OrignalDt2 = new DateTime(2025, 1, 20, 10, 30, 00);
            DateTime Dt3 = new DateTime(2025, 1, 25, 20, 50, 30);

            TimeSpan Result2 = Dt3.Subtract(OrignalDt2);
            Console.WriteLine("\n\nDate Subtraction:\n");
            Console.WriteLine("Original Date: " + OrignalDt2);
            Console.WriteLine("Date 2 (Subtration is from it):  " + Dt3);
            Console.WriteLine("The Result: " + Result);


            /*
             *  - In Subtraction ; always the time (Hours Minutes Seconds) will be zero as:
             *      - The Result: 5.00:00:00
            */








            /*
             *  - Operators
             *      - The DateTime struct overloads +, -, ==, !=, >, <, <=, >= operators to ease out
             *          addition, subtraction, and comparison of dates.
             *      - These make it easy to work with dates.
            */

            DateTime Dt4 = new DateTime(2015, 12, 20);
            DateTime Dt5 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan TmSpn = new TimeSpan(10, 5, 25, 50);   // Days, Hours, Minutes, Seconds

            Console.WriteLine("\n\nPerforming operators such as [+ - == etc] on DateTime and TimeSpan\n");
            Console.WriteLine("Date2 + Span: {0}", (Dt5 + TmSpn)); // 1/10/2017 10:36:10 AM
            Console.WriteLine("Date2 - Date1: {0}", (Dt5 - Dt4)); // Date2 - Date1: 377.05:10:20
            Console.WriteLine("Date2 == Date1: {0}", (Dt5 == Dt4)); // False
            Console.WriteLine("Date2 != Date1: {0}", (Dt5 != Dt4)); // False
            Console.WriteLine("Date2 > Date1: {0}", (Dt5 > Dt4)); // True
            Console.WriteLine("Date2 < Date1: {0}", (Dt5 < Dt4)); // False
            Console.WriteLine("Date2 >= Date1: {0}", (Dt5 >= Dt4)); // True
            Console.WriteLine("Date2 <= Date1: {0}", (Dt5 <= Dt4)); // False










            /*
             *  - Convert String to DateTime
             *      - A valid date and time string can be converted to a 
             *          DateTime object using Parse(), ParseExact(), TryParse() and TryParseExact() methods.
             *      - The Parse() and ParseExact() methods will throw an exception if the specified string is not a 
             *          valid representation of a date and time.
             *      - So, it's recommended to use TryParse() or TryParseExact() method because they return false if a string is not valid.
            */

            string DateStr = "6/12/2023";
            DateTime Date1;

            bool isValidDate = DateTime.TryParse(DateStr, out Date1);

            Console.WriteLine("\n\nConverting string to DateTime DateTime Functions :)\n");
            if (isValidDate)
                Console.WriteLine("This is a valid str: DateTime Variable is: {0}", Date1);
            else
                Console.WriteLine($"{DateStr} isn't a valid date string");




            DateStr = "26/2/2023";
            isValidDate = DateTime.TryParse(DateStr, out Date1);

            Console.WriteLine("\n");
            if (isValidDate)
                Console.WriteLine("This is a valid str: DateTime Variable is: {0}", Date1);
            else
                Console.WriteLine($"{DateStr} isn't a valid date string");



            var Datestr3 = "6/12/2023";
            DateTime dt5;

            var isValidDate2 = DateTime.TryParse(Datestr3, out dt5);

            Console.WriteLine("\n");
            if (isValidDate2)
                Console.WriteLine(dt5);
            else
                Console.WriteLine($"{Datestr3} is not a valid date string");



            //invalid string date
            var Datestr4 = "6/65/2023";
            DateTime dt6;

            var isValidDate3 = DateTime.TryParse(Datestr4, out dt6);

            Console.WriteLine("\n");
            if (isValidDate3)
                Console.WriteLine(dt6);
            else
                Console.WriteLine($"{Datestr4} is not a valid date string");

        }
    }

}
