Imports System.Text 'allows placing import statements at the top of the program.
Imports System.Math ' allows importing of the math equations without writing out equations fully.
Module Module1
	'Name: Jatinder Judge StudentID:1945979
	Sub main()
		Call Secondary()
		Call third()
		Call fourth()
		Call fifth()
	End Sub
	Sub Secondary()
		Console.WriteLine("--------------------------------------------------------------------------------------------------------------------")
		Console.WriteLine("6.1 INTRODUCTION")
		Console.WriteLine("This laboratory deals with arrays and file handling. As usual make sure that you save any work either on a network drive or a memory stick for future use. This laboratory may take more time than the three hours that has been allocated, so do not worry if you do not complete it in one sitting.")
		Console.WriteLine("--------------------------------------------------------------------------------------------------------------------")
		Console.WriteLine("6.2 ARRAYS")
		'\\\\\\\\\\\\\\\\\\\\\\\\\\SAMPLE CODE FROM THE LAB WORK SHEET\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
		'Dim array(24) As Double, i As Long
		'array(0) = 1
		'For i = 1 To 24
		'	array(i) = 2 * array(i - 1)
		'Next i
		'Call DisplayArray(array)
		'\\\\\\\\\\\\\\\\\\\\\\\\\\\\SAMPLE CODE FROM THE LAB WORK SHEET\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

	End Sub
	Sub third()
		Console.WriteLine("6.2.1 One Dimensional Arrays")
		Console.WriteLine("6.2.1 One Dimensional Arrays question1:")
		Dim array(24) As Double, i As Long
		array(0) = 1
		For i = 1 To 24
			array(i) = 3 * array(i - 1) ' change number 3 to change sequence
		Next i
		Call DisplayArray0(array)
	End Sub
	Sub fourth()
		Console.WriteLine("6.2.1 One Dimensional Arrays question2:")
		Dim array1(24) As Double, j As Long
		array1(0) = 1
		For j = 1 To 24
			array1(j) = -0.5 * array1(j - 1) ' change number -0.5* to change sequence
		Next j
		Call DisplayArray1(array1)


	End Sub
	Sub fifth()
		Console.WriteLine("6.2.1 One Dimensional Arrays question3:")
		Dim x, k As Integer
		Console.WriteLine("Value of x")
		x = Console.ReadLine()
		Console.WriteLine("Value of k")
		k = Console.ReadLine()
		Console.WriteLine("The One Dimensional Array will be:" & x & "," & k)
		Console.WriteLine(x, k)

	End Sub
	Sub DisplayArray(ByVal array() As Double)
		'\\\\\\\\\\\\\\\\\\\\\\\\\\\\SAMPLE CODE FROM THE LAB WORK SHEET\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
		Dim numi As Long, numn As Long
		numn = array.GetLength(0)
		For numi = 0 To numn - 1
			Console.WriteLine(array(numi))
		Next numi
		'\\\\\\\\\\\\\\\\\\\\\\\\\\\\SAMPLE CODE FROM THE LAB WORK SHEET\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
	End Sub
	Sub DisplayArray0(ByVal array() As Double) '6.2.1 One Dimensional Arrays question1
		Dim z As Long, n As Long
		n = array.GetLength(0)
		For z = 0 To n - 1
			Console.WriteLine(array(z))
		Next z
	End Sub
	Sub DisplayArray1(ByVal array() As Double) '6.2.1 One Dimensional Arrays question2
		Dim j As Long, m As Long
		m = array.GetLength(0)
		For j = 0 To m - 1
			Console.WriteLine(array(j))
		Next j
	End Sub
	Function Question3(x As Integer, k As Double) 'Console.WriteLine("6.2.1 One Dimensional Arrays question3:")
		Dim array(x) As Integer
		Dim num1 As Long
		array(0) = 1
		For num1 = 1 To x
			array(num1) = k * array(num1 - 1)
		Next num1
		Call Question3part2(array)
		Return array
	End Function
	Sub Question3part2(ByVal array() As Integer) 'Console.WriteLine("6.2.1 One Dimensional Arrays question3part2:")
		Dim num2, num3 As Long
		num3 = array.GetLength(0)
		For num2 = 0 To num3 - 1
			Console.WriteLine(array(num2))
		Next num2
	End Sub
End Module
