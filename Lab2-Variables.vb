Module Variables2

	Sub Main()
		'Name: Jatinder Judge StudentID:1945979
		Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------")
		Console.WriteLine("TESTING PHASE")
		Dim j As Double
		j = 21.1
		Console.WriteLine(j)
		j = j + 10.1
		Console.WriteLine(j)
		j += 10
		Console.WriteLine(j)

		Dim p As Long
		p = 21.1
		Console.WriteLine(p)
		p = p + 10.1
		Console.WriteLine(p)
		p += 10
		Console.WriteLine(p)

		Dim l, q, o As Long
		l = 5
		q = 2
		o = l + q
		Console.WriteLine(o)

		Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------")
		Console.WriteLine("Lab sheet questions")
		Dim x As Long
		Dim y As Double
		Dim Z As String  'declares  variables
		Dim a, g As Long
		Dim b, c, I As Double
		Dim d As Boolean
		Dim e, f As String
		' "I put Dim e,f statement" which works however breaks the rule on line 37 instead shoulf of put "Dim e,f As String"
		Dim name, h As String

		Const pi = 3.142

		a = 100
		b = 2.3
		c = -52.2
		d = ("True")
		e = ("I am")
		f = ("A student")
		g = ("0")
		h = "!"
		name = "Jatinder"
		Console.WriteLine("Question1 x= a + b")
		a = 100
		b = 2.3
		x = a + b
		Console.WriteLine(x) ' Incorrect answer because x is considered as a long not a double 

		Console.WriteLine("Question2 y= a + b")
		a = 100
		b = 2.3
		y = a + b
		Console.WriteLine(y)

		Console.WriteLine("Question3 z = e + f")
		e = "I am"
		f = " a student"
		Z = e + f
		Console.WriteLine(Z)

		Console.WriteLine("Question4 x=bc")
		b = 2.3
		c = -52.2
		x = b * c
		Console.WriteLine(x) ' Incorrect answer because x is considered as a long not a double 

		Console.WriteLine("Question5 pi = 22/7")
		I = 22 / 7
		Console.WriteLine(I)

		Console.WriteLine("Question6 Z = name / g")
		name = "Jatinder"
		g = 0
		'Z = name / g     ' Not putting variable As "z" since it keeps On saying "I am a student" from a previous question If the current String Is incorrect
		'Console.WriteLine(Z) 'A from string of which is a name cannot calculate with an integer as it would come up as an error.

		Console.WriteLine("Question7 l=c/g")
		c = -52.2
		g = 0
		'l = c / g  Unhandled Exception: System.OverflowException: Arithmetic operation resulted in an overflow meaning this equation is undefined if it was the other way it would equal to 0
		'Console.WriteLine(l) Instead of the variable "z" changed the variable to an unused one called "l"

		Console.WriteLine("Question8 x=x^3")
		'x= 10
		'x = x ^ 3
		'Console.WriteLine(x)  X is considered a set variable to be long as it has not been declared to any sort of value so x^3 still works out to give a valid answer.


		Console.WriteLine("Question9 z = name + " Is " + f + h ")
		Z = name + " Is " + f + h
		Console.WriteLine(Z)

		Console.WriteLine("Question10 y = (name + 10)/(name + h)")
		'y = (name + 10) / y = (name + h)
		'Console.WriteLine(y) Unhandled Exception: System.InvalidCastException: Conversion from string "Jatinder" to type 'Double' is not valid.

		Console.WriteLine("Question11 x = (a +b)/(d+c)")
		x = (a + b) / (d + c)
		a = 100
		b = 2.3
		c = -52.5
		d = True
		Console.WriteLine(x)

		Console.WriteLine("Question12 y = 100.3  y = (y / (a + b)) - c")
		y = (y / (a + b)) - c
		a = 100
		b = 2.3
		c = -52.5
		y = 100.3
		Console.WriteLine(y)

		Console.WriteLine("Question13 x^2 = y^2 + z^2")
		' x*x = (y * y  + Z*Z )
		' Console.WriteLine(x) Unhandled Exception: System.InvalidCastException: Conversion from string "Jatinder Is  a student!" to type 'Double' is not valid. ---> System.FormatException: Input string was not in a correct format.

		Console.WriteLine("Question14 name = " Is " + f - h")
		f = "a student"
		h = "!"
		'  name = " Is " + f - h
		'Console.WriteLine(name) 'Unhandled Exception: System.InvalidCastException: Conversion from string " Is  a student" to type 'Double' is not valid.

		Console.WriteLine("Question15 ((pi + 1)/(pi + 2))/(pi + 3)")
		y = ((pi + 1) / (pi + 2)) / (pi + 3)
		Console.WriteLine(y)

		Console.WriteLine("Question16 ")
		y = -2
		y = (y ^ 2 / a) ^ (1 / 3)
		Console.WriteLine(y)

		Console.WriteLine("Question17 z = d/g  z = z + name  ")
		d = True
		g = 0
		Z = d / g
		Z = Z + name
		Console.WriteLine(Z)

		Console.WriteLine("Question18 z= name   z = d/g + z")
		'Z = name
		'Z = d / g + Z
		'Console.WriteLine(Z) Conflicts, d is boolean = true and g is= 0 so it would come up as error

		Console.WriteLine("Question19 x= -2.3 y=ax^2 +bx + c")
		x = -2.3
		'y = a * (x ^ 2) + b * (x) + c
		'Console.WriteLine(y)          'Conflicts with other declared variable

		Console.WriteLine("Question20 ")
		y = y - (a - b) ^ (b - c) ^ (c - d)
		Console.WriteLine(y)



	End Sub
End Module



