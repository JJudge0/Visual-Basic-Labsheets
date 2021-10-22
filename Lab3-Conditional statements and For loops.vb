
Imports System.Net.Http.Headers

Module Module1

    Sub Main()

        Dim x, y As Long    'declaring x and y as whole number 
        Dim z, c As Double 'declaring z and c as numbers which include decimal number
        Dim a, b As Boolean 'declaring a and b as boolean so true and false
        x = 100
        y = 204
        z = -23.1
        c = -204
        a = True
        b = False

        Console.WriteLine("RELATIONAL OPERATORS---------------------------------------------")
        Console.WriteLine("Question1:  x < y")
        x = 100
        y = 204
        If x < y Then                 'if 100 is smaller than 204 write 'true' otherwise write 'false'
            Console.WriteLine("True")
        Else
            Console.WriteLine("False")

        End If

        Console.WriteLine("Question2: x>z and a=b")
        If (x > z) And (a = b) Then
            Console.WriteLine("True")  'if 100 is bigger than -23.1 AND true is equal to false write true else write false
        Else
            Console.WriteLine("False") 'Both conditions have to be met in order to be true but the second condition true does not equal false so the answer is false.
        End If


        Console.WriteLine("Question3: 2c>y")
        If (2 * c > y) Then
            Console.WriteLine("True") '2 x -204= -408 > 204 but 204 is bigger so the answer is false.
        Else
            Console.WriteLine("False")
        End If


        Console.WriteLine("Question4: x=b")
        If (x = b) Then
            Console.WriteLine("True") '100 is not equal to false so the answer is false
        Else
            Console.WriteLine("False")
        End If


        Console.WriteLine("Question5: c<>y or c=y")
        If (c <> y) Or (c = y) Then  '-204  is not equal 204 Or -204 equal to 204 so it's true
            Console.WriteLine("True")
        Else
            Console.WriteLine("False")
        End If

        Console.WriteLine("Question6: z<>y And c=a")
        If (z <> y) And (c = a) Then
            Console.WriteLine("True")
        Else
            Console.WriteLine("False")
        End If

        Console.WriteLine("Question7: y>= y  And c=a")
        If (y >= y) And (a + 3 <> 2) Then
            Console.WriteLine("True")
        Else
            Console.WriteLine("False")
        End If


        Console.WriteLine("IF STATEMENTS---------------------------------------------")
        Console.WriteLine("Question1) A program that when given three numbers, displays them in the correct order ")

        Dim j, k, l As Integer 'name1= j 'name2= k name3=l
        j = 20
        k = 555
        l = 60
        If (j < k) Then  'Uses the combinations of the 3 numbers set in the 3 variables and has all the combinations from biggest to smallest
            If (k < l) Then
                Console.WriteLine(j & " " & k & " " & l)
            ElseIf (j < l) Then
                Console.WriteLine(j & " " & l & " " & k)
            Else
                Console.WriteLine(l & " " & j & " " & k)
            End If
        ElseIf (k > l) Then
            Console.WriteLine(l & " " & k & " " & j)
        ElseIf (j > l) Then
            Console.WriteLine(k & " " & l & " " & j)
        Else
            Console.WriteLine(k & " " & j & " " & l)
        End If

        Console.WriteLine("Question2) A program that when given three names (e.g. name1, name2 and name3 as string variables), it displays them in the correct alphabetical order")

        Dim name1, name2, name3 As String
        name1 = "Jatinder" 'Uses the combinations of names and puts them in various orders in terms of alphabetical order
        name2 = "sara"
        name3 = "Andreas"
        If (name1 < name2) Then
            If (name2 < name3) Then
                Console.WriteLine(name1 & " " & name2 & " " & name3)
            ElseIf (name1 < name3) Then
                Console.WriteLine(name1 & " " & name3 & " " & name2)
            Else
                Console.WriteLine(name3 & " " & name1 & " " & name2)
            End If
        ElseIf (name2 > name3) Then
            Console.WriteLine(name3 & " " & name2 & " " & name1)
        ElseIf (name1 > name3) Then
            Console.WriteLine(name2 & " " & name3 & " " & name1)
        Else
            Console.WriteLine(name2 & " " & name1 & " " & name3)
        End If


        Console.WriteLine("COMPOUND CONDITIONS---------------------------------------------")
        Console.WriteLine("Question1) Write a program that finds all of the numbers between 1 and 100 that are divisible by 2 and 3. ")


        For x = 1 To 100  'Numbers betwen 1 to 100
            If (x Mod 2 = 0 And x Mod 3 = 0) Then 'sub x in which is numbers between 1 to 100 and if it equals 0 then it's divisible by 2 and 3 so it shows all the numbers that are divisble by 2 and 3 within the range of 1-100
                Console.WriteLine(x)
            End If
        Next x

        Console.WriteLine("Question2) Amend the program so that it displays numbers that are divisible by 7 or 9 ")

        For x = 1 To 100
            If (x Mod 7 = 0 Or x Mod 9 = 0) Then
                Console.WriteLine(x)
            End If
        Next x

        Console.WriteLine("Question3) Amend the program so that it displays numbers that are divisible by 2 and 3 but not 5 ")


        For x = 1 To 100
            If (x Mod 2 = 0 And x Mod 3 = 0 And x Mod 5 <> 0) Then
                Console.WriteLine(x)
            End If
        Next x

        Console.WriteLine("SELECT STATEMENTS---------------------------------------------")
        Console.WriteLine("Question1) Write a program that uses a Select statement to determine if the number between 1 and 100 are Less than 10")
        Dim num As Integer
        num = 2
        Select Case num
            Case 1 To 10
                Console.WriteLine("Less than 10")
            Case Else
                Console.WriteLine("None of the above")
        End Select

        Console.WriteLine("Question2) Write a program that uses a Select statement to determine if the number between 1 and 100 are Greater or equal than 90")
        Dim num2 As Integer
        num2 = 91
        Select Case num2
            Case Is >= 90
                Console.WriteLine(" The number provided is Greater or equal than 90")
            Case Else
                Console.WriteLine(" The number provided is NOT GREATER OR EQUAL THAN 90")
        End Select

        Console.WriteLine("Question3) Write a program that uses a Select statement to determine if the number between 1 and 100 is Between 30 and 40 inclusive")
        Dim o As Long
        o = 29
        Select Case o
            Case 30 To 40
                Console.WriteLine("Equal to numbers in between 30 and 40")
            Case 30, 40
                Console.WriteLine("Between 30 and 40 inclusive")
            Case Else
                Console.WriteLine("NUMBER IS INCLUSIVE AND IS NOT inBetween 30 and 40")
        End Select

        Console.WriteLine("Question4) Write a program that uses a Select statement to determine if the number between 1 and 100 is Equal to 11, 21, 51 or 61")
        Dim num3 As Long
        num3 = 61
        Select Case num3
            Case 11
                Console.WriteLine("Equal to 11")
            Case 21
                Console.WriteLine("Equal to 21")
            Case 51
                Console.WriteLine("Equal to 51")
            Case 61
                Console.WriteLine("Equal to 61")
            Case Else
                Console.WriteLine("NOT EQUAL TO 11,21,51,61")
        End Select

        Console.WriteLine("Question5) Write a program that uses a Select statement to determine if the number between 1 and 100 is Between 70 and 80 exclusive")
        Dim num4 As Long
        num4 = 75
        Select Case num4
            Case 70 To 80
                Console.WriteLine("NUMBER IS IN BETWEEN 70 and 80")
            Case 70, 80
                Console.WriteLine("Between 70 and 80 exclusive")
            Case Else
                Console.WriteLine("NUMBER IS EXCLUSIVE AND IS NOT inBetween 70 and 80")
        End Select

        Console.WriteLine("LOOPS, GENERATING SEQUENCES USING FOR LOOPS---------------------------------------------")
        Console.WriteLine("Question1) 10, 13, 16, 19")
        Dim i As Long
        For i = 10 To 19 Step 3
            Console.WriteLine(i)
        Next i
        Console.WriteLine("Question2) 1, 4, 7, 10, 13, 16")
        Dim num5 As Long
        For num5 = 1 To 16 Step 3
            Console.WriteLine(num5) ' Starts from 1-16 adds +3
        Next num5

        Console.WriteLine("Question3) 2, 4, 6, 8, 10, 12")
        Dim num6 As Long
        For num6 = 2 To 12 Step 2
            Console.WriteLine(num6) ' Starts from 2-12 adds +2
        Next num6


        Console.WriteLine("Question4) 1, 4, 9, 16, 25, 36, 49, 64, 81, 100")
        Dim num7 As Long
        For num7 = 1 To 10
            Console.WriteLine(num7 ^ 2)  'SQUARE numbers so numbers 1-10 square it 
        Next num7


        Console.WriteLine("Question5)-10, -8, -6, -4, -2, 0, 2, 4,  6, 8, 10")
        Dim num8 As Long
        For num8 = -10 To 10 Step +2
            Console.WriteLine(num8)
        Next num8

        Console.WriteLine("Question6) -20, -15, -10, -5, 5, 10, 15, 20")
        Dim num9 As Long
        For num9 = -20 To 20 Step +5
            Console.WriteLine(num9)
        Next num9


        Console.WriteLine("GENERATING PATTERN LOOPS---------------------------------------------")
        Console.WriteLine("Question1)++++++++++")
        Dim num10 As Long
        For num10 = 1 To 1
            Console.WriteLine("++++++++++")
        Next num10

        Console.WriteLine("Question2) ---------")
        Dim num11 As Long
        For num11 = 1 To 1
            Console.WriteLine("---------")
        Next num11

        Console.WriteLine("Question3)+-+-+-+-+-")
        Dim num12 As Long
        For num12 = 1 To 1
            Console.WriteLine("+-+-+-+-+-")
        Next num12

        Console.WriteLine("Question4)*+-*+-*+-")
        Dim num13 As Long
        For num13 = 1 To 1
            Console.WriteLine("*+-*+-*+-")
        Next num13

        Console.WriteLine("GENERATING WHILE LOOPS---------------------------------------------")
        Console.WriteLine("Euclid’s algorithm is one of the first algorithms on record, dating from about 300BC. It computes the highest common factor (HCF) between two positive integers A and B. Here is a flowchart of Euclid’s algorithm.
        Implement Euclid's algorithm (Highest Common Factor - HCF) according to the above flowchart by using a While loop.
        Test your program on the following:")


        Console.WriteLine(" ECULIDS ALGORITHM SHOWN BELOW----------")
        '   Dim num92, num93, num94 As Integer    'a= num92 b =num93 c= num94 VARIABLES CHANGED 
        '   num94 = 0
        '   Do
        '  num94 = num92 Mod num93
        '  If num94 <> 0 Then Exit Do

        ' num92 = num93
        '' num93 = num94
        ' Console.WriteLine(num93)

        '  Loop While num94 <> 0

        Console.WriteLine("Question1)HCF(88,26)=2")

        Dim num15 As Integer ' num15=A, num16=B, Num17= C
        Dim num16 As Integer
        Dim num17 As Integer
        num15 = 26
        num16 = 88
        num17 = 0
        Do 'do loop
            num17 = num15 Mod num16
            If num17 = 0 Then Exit Do
            num15 = num16
            num16 = num17

        Loop While num17 <> 0
        Console.WriteLine(num16)


        Console.WriteLine("Question2)HCF(54,87)=3")
        Dim num18 As Integer ' num18=A, num19=B, Num20= C
        Dim num19 As Integer
        Dim num20 As Integer
        num18 = 54
        num19 = 87
        num20 = 0
        Do
            num20 = num18 Mod num19
            If num20 = 0 Then Exit Do
            num18 = num19
            num19 = num20

        Loop While num20 <> 0
        Console.WriteLine(num19)

        Console.WriteLine("Question3)HCF(16,84)=4")
        Dim num21 As Integer ' num21=A, num22=B, Num23= C
        Dim num22 As Integer
        Dim num23 As Integer
        num21 = 16
        num22 = 84
        num23 = 0
        Do
            num23 = num21 Mod num22
            If num23 = 0 Then Exit Do
            num21 = num22
            num22 = num23

        Loop While num23 <> 0
        Console.WriteLine(num22)

        Console.WriteLine("Question4)HCF(55,25)=5")
        Dim num24 As Integer ' num24=A, num25=B, Num26= C
        Dim num25 As Integer
        Dim num26 As Integer
        num24 = 55
        num25 = 25
        num26 = 0
        Do
            num26 = num24 Mod num25
            If num26 = 0 Then Exit Do
            num24 = num25
            num25 = num26

        Loop While num26 <> 0
        Console.WriteLine(num25)

        Console.WriteLine("Question5)HCF(42,72)=6")
        Dim num27 As Integer ' num27=A, num28=B, Num29= C
        Dim num28 As Integer
        Dim num29 As Integer
        num27 = 42
        num28 = 72
        num29 = 0
        Do
            num29 = num27 Mod num28
            If num29 = 0 Then Exit Do
            num27 = num28
            num28 = num29

        Loop While num29 <> 0
        Console.WriteLine(num28)

        Console.WriteLine("Question6)HCF(77,28)=7")
        Dim num30 As Integer ' num30=A, num31=B, Num32= C
        Dim num31 As Integer
        Dim num32 As Integer
        num30 = 77
        num31 = 28
        num32 = 0
        Do
            num32 = num30 Mod num31
            If num32 = 0 Then Exit Do
            num30 = num31
            num31 = num32

        Loop While num32 <> 0
        Console.WriteLine(num31)

        Console.WriteLine("Question7)HCF(80,88)=8")
        Dim num33 As Integer ' num33=A, num34=B, Num35= C
        Dim num34 As Integer
        Dim num35 As Integer
        num33 = 80
        num34 = 88
        num35 = 0
        Do
            num35 = num33 Mod num34
            If num35 = 0 Then Exit Do
            num33 = num34
            num34 = num35

        Loop While num35 <> 0
        Console.WriteLine(num34)


        Console.WriteLine("NESTED LOOPS---------------------------------------------")
        Console.WriteLine("Question1)  122333444455555")
        Dim v As Long, g As Long

        For v = 1 To 5  'Numbers between 1 to 5.
            For g = 1 To v
                Console.WriteLine(v)
            Next g
        Next v
        Console.WriteLine("Question2)  22333444455555666666")

        For v = 2 To 6
            For g = 1 To v
                Console.WriteLine(v)
            Next g
        Next v
        Console.WriteLine("Question3)  133355555")

        For v = 1 To 5 Step +2 'Numbers 1 to 5 adds +2 to 1
            For g = 1 To v
                Console.WriteLine(v)
            Next g
        Next v

        Console.WriteLine("Question4)  1335557777")

        Dim q As Long = 1
        For p = 1 To 4 ' 1 to 4 numbers which are (1,3,5,7)
            For m = 1 To p
                Console.WriteLine(q)
            Next m
            q += 2 'adds 2 start from 1 then 3 then 5 then 7 , 4 numbers
        Next p
        Console.WriteLine("")

        Console.WriteLine("NESTED LOOPS PART2---------------------------------------------")
        Console.WriteLine("Question1) Display all of the possible pairs of numbers between 1 and 10 (there are 100 pairs)")
        num = 0
        For i = 1 To 10
            For j = i + 1 To 100
                Console.Write(i & j & ",") 'displays numbers between 1 and 10 all the way to 100 pairs.
                num += 1
            Next j
        Next i
        Console.WriteLine(num)

        Console.WriteLine("Question2) Display all possible pairs in the form x, y where x < y and 0 < x, y < 11 (there are 45 pairs)")
        Dim subx1, suby1 As Integer
        For suby1 = 1 To 10     'suby1 is from 1 to 10
            For subx1 = 2 To 10  'subx1 is from 2 to 10
                If subx1 < suby1 Then
                    Console.WriteLine("x & y") 'displays all possible combinations with x and y together.
                End If
            Next subx1
        Next suby1

        Console.WriteLine("Question3) Display all possible pairs of the numbers 1,2,3,4 paired with 4,5,6,7,8 (there are 20 pairs)")
        '  Dim oj As Integer = 0
        For oh As Integer = 1 To 4 'declare oh variable from 1,2,3,4
            For ol As Integer = 4 To 8 'declare ol variables from 4,5,6,7,8
                Console.WriteLine(oh & "," & ol) 'Uses oh and ol variables together to make combinations
            Next ol ' does the next number in the ol sequence
        Next oh ' does the next number in the oh sequence


        Dim numbers As New List(Of Double)()

        'add items in a List collection
        numbers.Add(1)
        numbers.Add(2)
        numbers.Add(3)
        Console.WriteLine(numbers)

    End Sub
End Module




