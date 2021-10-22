
Imports System.Math
Module Module1
    Sub Main() 'Name: Jatinder Judge StudentID:1945979
        Console.WriteLine("4.2.1 SYSTEM FUNCTIONS---------------------------------------------------------")
        'Console.WriteLine("Locate the following functions in the VB help files and read up on what they do: ChDir, ChDrive, Dir, MkDir, RmDir, FileCopy")
        'Console.WriteLine("ChDir means VBA ChDir function changes the current folder or directory.")
        'Console.WriteLine("ChDrive means VBA ChDrive function changes the current drive.")
        'Console.WriteLine("Dir means function returns the first name of a file or directory that matches a pattern.")
        'Console.WriteLine("MkDir means function creates a new folder or directory .	")
        'Console.WriteLine("RmDir means function removes an existing directory or folder.")
        'Console.WriteLine("FileCopy means function copies a file from the source directory to the destination directory.")
        Dim r As Date = Now()
        Randomize(Second(r))
        Dim I As Long
        Randomize(10)
        For I = 1 To 10
            Console.WriteLine(Rnd())
        Next I

        Dim d As DateTime
        d = Now()
        Console.WriteLine(d)
        Console.WriteLine(Year(d))
        Console.WriteLine(Month(d))
        Console.WriteLine(Day(d))
        Console.WriteLine(Hour(d))
        Console.WriteLine(Minute(d))
        Console.WriteLine(Second(d))
        '  End Sub
        'Sub textfunctions()
        Console.WriteLine("4.2.2: MATHEMATICAL FUNCTIONS---------------------------------------------------------")
        'Console.WriteLine("Locate the following functions in the VB help files and read up on what they do (remember to import the mathematics libraries as was shown in the lecture")
        'Console.WriteLine("Cos Trigonometric cosine")
        'Console.WriteLine("Sin Trigonometric sine")
        'Console.WriteLine("Tan Trigonometric tangent")
        'Console.WriteLine("Abs Absolute value of a number")
        'Console.WriteLine("Atan Inverse Tan")
        'Console.WriteLine("Exp Exponential (base e)")
        'Console.WriteLine("Log Logarithmic (base e or as parameter)")
        'Console.WriteLine("sqrt Square root")
        'Console.WriteLine("Sgn Sign of a number")

        Dim num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, num15, num16, num17, num18, num19, num20, num21, num22 As Double

        num1 = -100.1
        num2 = Round(num1) 'Uses math round function of when num1 is declared and a value is presented to the variable name.
        num3 = 100.49
        num4 = Round(num3)
        num5 = 100.5
        num6 = Round(num5)
        num7 = -100.51
        num8 = Round(num7)
        num9 = -100.9
        num10 = Round(num9)
        num11 = 0
        num12 = Round(num11)
        num13 = 100.1
        num14 = Round(num13)
        num15 = 100.49
        num16 = Round(num15)
        num17 = 100.5
        num18 = Round(num17)
        num19 = 100.51
        num20 = Round(num19)
        num21 = 100.9
        num22 = Round(num21)

        Console.WriteLine(Str(num2))
        Console.WriteLine(Str(num4))
        Console.WriteLine(Str(num6))
        Console.WriteLine(Str(num8))
        Console.WriteLine(Str(num10))
        Console.WriteLine(Str(num12))
        Console.WriteLine(Str(num14))
        Console.WriteLine(Str(num16))
        Console.WriteLine(Str(num18))
        Console.WriteLine(Str(num20))
        Console.WriteLine(Str(num22))

        Console.WriteLine("4.2.3: TEXT FUNCTIONS---------------------------------------------------------")
        'Console.WriteLine("Locate the following functions in the VB help files and read up on what they do")
        'Console.WriteLine("Len The length of a string")
        'Console.WriteLine("Mid Copy a portion of a string ")
        'Console.WriteLine("Left Copy the beginning of a string")
        'Console.WriteLine("Right Copy the end of a string")
        'Console.WriteLine("Trim Trimall, leading or trailing spaces")
        'Console.WriteLine("LTrim Trimall, leading or trailing spaces")
        'Console.WriteLine("RTrim Trimall, leading or trailing spaces")
        'Console.WriteLine("Instr Search for the position of a string within a string")
        'Console.WriteLine("StrComp Compare two strings")
        'Console.WriteLine("Replace Replace a string within a string ")
        'Console.WriteLine("StrDup Repeat a character a number of times ")
        'Console.WriteLine("Format format a number ")

        Dim a, b, c As String
        Dim x, y, z As Double

        x = 123.456
        y = 17 / 3
        z = Sqrt(2)
        a = "Hello"
        b = "World"
        c = "olleh dlrow"
        Console.WriteLine("Question1) Display y to three decimal places?")
        Console.WriteLine(Format(y, ".000"))  'Replace y for x and Z for 3 decimal places
        Console.WriteLine("Question2) Write a program that displays how many digits come before the decimal point and how many comes after it. Test this program on x, y and z")
        Console.WriteLine(part1(x))
        Console.WriteLine(part2(y))
        Console.WriteLine(part3(z))
        Console.WriteLine("Question3) Create a string c that consists of a in reverse concatenated with b, including a space between them .")
        c = (StrReverse(b + " " + a)) 'Reverse world and hello
        Console.WriteLine(c) 'prints the console of world and hello reversed.
        Console.WriteLine("Question4) Search for the substring ‘ll’ in c and replace it for ‘ppp’")
        Console.WriteLine(question4(c))

        Console.WriteLine("4.3 USER DEFINED FUNCTIONS---------------------------------------------------------")
        'Console.WriteLine("This part of the laboratory is about writing user defined functions AND Locate the following functions in the VB help files and read up on what they do ")
        'Console.WriteLine("What is What is a User Defined Function?? 
        ' A user defined function is one that is written and maintained by the user. We (the users) define what the function does, what parameters it takes, and what value it returns It is then stored for future use")
        'Console.WriteLine("Local variable is one whose scope is local to a specific function or subroutine")
        'Console.WriteLine("Global variables is one whose scope is global to the whole program (module)  ")
        'Console.WriteLine("Socpe of a variable is the sections of a program in which it (its value) can be accessed")
        'Console.WriteLine("Side Effects A function has a side effect, if it can affect variables outside of its own function definition.")

        Dim v1 As Double, v2 As Double
        v1 = 10.2
        v2 = 0
        Console.WriteLine("Before v1 =" + Str$(v1))
        Console.WriteLine("Before v2 =" + Str$(v2))
        v2 = TestLocal(10.2)
        Console.WriteLine("After v1 =" + Str$(v1))
        Console.WriteLine("After v2 =" + Str$(v2))

        'Console.WriteLine("Question1) Variables v1 and v2 are declared")
        'Console.WriteLine("Question2) Variables v1 and v2 are set (10.2 and 0 respectively)")
        'Console.WriteLine("Question3) The values of v1 and v2 are displayed")
        'Console.WriteLine("Question4) Function TestLocal is called with parameter v1. Note that the flow of the program is now transferred from the Main subroutine to the TestLocal function")
        'Console.WriteLine("Question5) The parameter variable p1 is set to be the value of v1 (since v1 was passed as the parameter)")
        'Console.WriteLine("Question6) Within TestLocal, the local variable loc1 is declared")
        'Console.WriteLine("Question7) The local variable loc1 is set as p1+100")
        'Console.WriteLine("Question8) The parameter variable p1 is set to 1234")
        'Console.WriteLine("Question9) The value of loc1 is returned as the value of the function. Note that the flow of the program is now returned to the point from which the function was called")
        'Console.WriteLine("Question10)Back in Main (the call to the function has finished) the variable v2 is set to the return value of the function TestLocal (whatever the return value was)")
        'Console.WriteLine("Question11) The values of v1 and v2 are displayed")


        ' Console.WriteLine("ANSWER TO Question1)  Dim v1 As Double, v2 As Double")
        ' Console.WriteLine("ANSWER TO Question2)  v1 = 10.2  v2 = 0 ")
        ' Console.WriteLine("ANSWER TO Question3)  v1 = 10.2  v2 = 0")
        ' Console.WriteLine("ANSWER TO Question4)  Function TestLocal(ByVal p1 As Double) As Double ")
        ' Console.WriteLine("ANSWER TO Question5) NO it hasn't the outcome is still the same value of 10.2 not 1234")
        ' Console.WriteLine("ANSWER TO Question6) Dim loc1 As Double")
        ' Console.WriteLine("ANSWER TO Question7) loc1 = p1 + 100 ")
        ' Console.WriteLine("ANSWER TO Question8) p1 = 1234 ")
        ' Console.WriteLine("ANSWER TO Question9) Within loc1 = 110.2")
        ' Console.WriteLine("ANSWER TO Question10) After v2 = 110.2")
        ' Console.WriteLine("ANSWER TO Question11) v1 = 10.2, v2 = 0")


        Console.WriteLine("4.3.1 EXCERCISE---------------------------------------------------------")
        'Console.WriteLine("Question1) Change the starting value of v1 and note the changes to what is displayed. ")
        'Console.WriteLine("The parameter variable p1 (within TestLocal) is set to an initial value of whatever v1 contains (in the example above), during the execution (running) of the function. It behaves exactly Like a local variable. Once the Function has finished running, the values of p1 And loc1 are “forgotten”.")
        'Console.WriteLine("Question2) Verify this by trying to display their values in the Main subroutine. Note that when we change the value of p1 (in the line that is p1 = 1234), it does not alter the value of v1 in Main.  ")
        'Console.WriteLine("Question3) Within the declaration of TestLocal, change the keyword ByVal to ByRef, run the program, what happens? ")
        'Console.WriteLine("The value of v1 within Main should now have changed, that is because we have passed the parameter by reference (a pointer to the variable that was passed as a parameter) and not by value (where the parameter values are copied). We say that the function TestLocal has a side effect, in that in now affects variables outside of its own function definition.")
        'Console.WriteLine("Question4) Within Main change the line that is v2 = TestLocal(v1) to v2 = TestLocal(10.2), then run the program, what happens? Can you explain it? ")
        'Console.WriteLine("Question5) Finally change v1 and v2 to being global variables, initialise (set) them within Main and experiment with changing their values in TestLocal.")

        ' Console.WriteLine("ANSWER TO Question1) VALUE OF V1 CHANGED TO 11.4 RESULTS: Before v1 = 11.4, Before v2 = 0, Within p1 = 1234, Within loc1 = 111.4, After v1 = 11.4,  After v2 = 111.4 ")
        ' Console.WriteLine("ANSWER TO Question2) VALUE OF P1 IN THE FUNCTION CHANGED TO 4678 RESULTS: Before v1 = 11.4, Before v2 = 0, Within p1 = 1234, Within loc1 = 111.4, After v1 = 11.4, After v2 = 111.4 ")
        ' Console.WriteLine("ANSWER TO Question3) Within the declaration of TestLocal, change the keyword ByVal to ByRef RESULTS: Before v1 = 11.4,  Before v2 = 0, Within p1 = 1234, Within loc1 = 111.4, After v1 = 1234, After v2 = 111.4")
        ' Console.WriteLine("ANSWER TO Question4)  It has ran it through 10.2 the core value given since v2 orginally equals to 0 anyway so v2 = to 10.2 instead of 0. RESULTS OF RUNNING PROGRAM: Before v1 = 10.2,  Before v2 = 0, Within p1 = 1234, Within loc1 = 110.2, After v1 = 10.2, After v2 = 110.2 ")
        ' Console.WriteLine("ANSWER TO Question5) Adding localandglobal variables so it runs code throughout the whole module.")

        Console.WriteLine("4.3.2 WRITING USER DEFINED FUNCTIONS ---------------------------------------------------------")
        Console.WriteLine("EVEN/ ODD")
        Console.WriteLine("Write a function that returns true if an integer (or long) is even and false if the number is odd.")
        Dim m As Long, eo As Boolean, s As String
        For m = 1 To 25
            eo = evenodd(m)
            If eo = True Then
                s = "Even"
            Else
                s = "Odd"
            End If
            Console.WriteLine(Str(m) + " is " + s) 'Writes string of when the number between 1 to 25 is even or odd
        Next m

        Console.WriteLine("REVERSE STRING VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV")
        Console.WriteLine("Write a Function that When passed a character String, returns the string in reverse order.")

        Dim num24 As String = "hello"
        Dim num25 As String = "world"
        Dim num26 As String = StrReverse(num24 + num25) 'reverse string of hello and world
        Console.WriteLine(num26) 'Prints hello and world

        Console.WriteLine("LEAP YEAR VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV")
        Console.WriteLine("Write a function that returns true if a year is a leap year and false otherwise.")

        Dim num31 As Integer
        Console.Write("Enter Year:")
        num31 = CInt(Console.ReadLine())
        If num31 Mod 100 = 0 Then
            If num31 Mod 400 = 0 Then
                Console.WriteLine("The year is a leap year so it's true ")
            Else
                Console.WriteLine("The year is NOT a leap year so it's false")
            End If
        Else
            If y Mod 4 = 0 Then
                Console.WriteLine("The year is a leap year so it's true")
            Else
                Console.WriteLine("The year is NOT a leap year so it's false")
            End If
        End If

        Console.WriteLine("DAYS IN A MONTH VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV")
        Console.WriteLine(" For a given a month And year write a program that returns the number of days in that month?")

        Dim years As Integer = 2020 ' Pick a year example can be 2020
        Console.WriteLine("Please choose a year ")
        years = Console.ReadLine() 'reads input of the user if they type in a year
        Dim months As Integer = 2  'Pick a month between 1 and 12
        Console.WriteLine("Please choose a month ranging from 1-12 months")
        months = Console.ReadLine() ' reads input of the user if they type in a month
        Dim days As Integer = System.DateTime.DaysInMonth(years, months) ' Displays in the year and month
        Console.WriteLine("The amount of days in the " & months & " month is " & days & " days") 'display the amount of days in that year and month

        Console.WriteLine("DAYS ALIVE VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV")
        Console.WriteLine("Given a person’s date of birth, how many days have they been alive?")

        Dim Birthday As DateTime
        Console.WriteLine("enter a date in the format DD/MM/YYY:")
        Birthday = Console.ReadLine()
        Dim today As DateTime = Date.Now() 'Uses the date of now
        Dim difference As TimeSpan = today - Birthday 'Subtracts the date today- the input of the user
        Dim totaldays As Integer = difference.TotalDays * 24 '24 hours in a day
        Console.WriteLine(totaldays & " days") 'displays message on console in days

        Console.WriteLine("THE FIBONACCI SEQUENCE VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV")
        Dim num35 As Integer
        Console.WriteLine("input a number")
        num35 = Console.ReadLine()
        For v As Integer = 1 To num35
            If num35 <= 0 Then
                Console.WriteLine("wrong value, please restart")
            Else
                Console.WriteLine(fibonacci(I))
            End If
        Next
    End Sub
    ' Function TEXTFUNCTIONSWORKBELOW()
    '    Console.WriteLine("4.2.3: TEXT FUNCTIONS WORK BELOW-VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV")
    ' End Function
    Function part1(ByVal x As String) As String
        Console.WriteLine("Question2 part1")
        Dim mid As Long = InStr(4, x, "")
        Console.WriteLine(mid - 1)
        Dim length As Long = Len(x)
        Console.WriteLine(length - mid)
        part1 = x
    End Function
    ' Function TEXTFUNCTIONSWORKBELOW()
    '    Console.WriteLine("4.2.3: TEXT FUNCTIONS WORK BELOW-VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV")
    ' End Function
    Function part2(ByVal y As String) As String
        Console.WriteLine("Question2 part2")
        Dim mid As Long = InStr(2, y, "")
        Console.WriteLine(mid - 1)
        Dim length As Long = Len(y)
        Console.WriteLine(length - mid)
        part2 = y
    End Function
    ' Function TEXTFUNCTIONSWORKBELOW()
    '    Console.WriteLine("4.2.3: TEXT FUNCTIONS WORK BELOW-VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV")
    ' End Function
    Function part3(ByVal z As String) As String
        Console.WriteLine("Question2 part 3")
        Dim mid As Long = InStr(2, z, "")
        Console.WriteLine(mid - 1)
        Dim length As Long = Len(z)
        Console.WriteLine(length - mid)
        part3 = z
    End Function
    ' Function TEXTFUNCTIONSWORKBELOW()
    '    Console.WriteLine("4.2.3: TEXT FUNCTIONS WORK BELOW-VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV")
    ' End Function
    Function question4(ByVal c As String) As String
        Dim search As String = InStr(1, c, "ll") ' searches position for the 2 L's
        Dim replacewith As String = c.Replace("l", "p") 'replaces 'l' with 'p'
        Console.WriteLine(replacewith)
        question4 = c
    End Function
    ' Function USERDEFINDEDFUNCTIONSWORKBELOW()
    '  Console.WriteLine("4.3 USER DEFINED FUNCTIONS WORK BELOW-VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV")
    '  End Function
    'THIS CODE RELATES TO THE QUESTIONS ABOVE FOR 4.3 USER DEFINED FUNCTIONS
    Function TestLocal(ByVal p1 As Double) As Double
        Dim loc1 As Double
        loc1 = p1 + 100
        p1 = 1234
        Console.WriteLine("Within p1 =" + Str$(p1))
        Console.WriteLine("Within loc1 =" + Str$(loc1))
        TestLocal = loc1
    End Function
    ' Function EVEN/ODDSWORKBELOW()
    '  Console.WriteLine("4.3.2 USER DEFINED FUNCTIONS WORK BELOW-VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV")
    '  End Function
    Function evenodd(ByVal num30 As Integer) As Boolean
        If num30 Mod 2 = 0 Then
            evenodd = True
        Else
            evenodd = False
        End If
    End Function
    ' Function THEFIBONACCISEQUENCEWORKBELOW()
    '  Console.WriteLine("4.3.2 USER DEFINED FUNCTIONS WORK BELOW-VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV")
    '  End Function 
    Function fibonacci(ByVal num36 As Integer) As Integer
        Dim num37 As Integer = 0
        Dim num38 As Integer = 1
        For num39 = 0 To num36 - 1
            Dim num40 As Integer = num37
            num37 = num38
            num38 = num38 + num40
        Next
        Return num36
    End Function
End Module








