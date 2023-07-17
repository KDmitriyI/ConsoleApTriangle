Module Module1

    Sub Main()
        Dim a, b, c As Single
        a = Val(Console.ReadLine())
        b = Val(Console.ReadLine())
        c = Val(Console.ReadLine())
        If a <= 0 Or b <= 0 Or c <= 0 Then Console.WriteLine("Условие неверно")
        If a >= b + c Or b >= a + c Or c >= b + a Then Console.WriteLine("Треугольник со сторонами {0} {1} {2} несуществует", a, b, c) Else Console.WriteLine("Треугольник со сторонами {0} {1} {2} существует", a, b, c)
        Console.ReadLine()
    End Sub

End Module
