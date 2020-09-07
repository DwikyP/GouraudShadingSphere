Public Class matrix

    'matrix 3x1 min
    Public Function matrixMin33(ByVal a() As Double, ByVal b() As Double) As Double()
        Dim c(2) As Double

        For i = 0 To 2
            c(i) = b(i) - a(i)
        Next

        Return c
    End Function

    'cross product
    Public Function cross(ByVal a() As Double, ByVal b() As Double) As Double()
        Dim c(2) As Double

        c(0) = a(1) * b(2) - b(1) * a(2)
        c(1) = a(2) * b(0) - b(2) * a(0)
        c(2) = a(0) * b(1) - b(0) * a(1)

        Return c
    End Function

    'dot product
    Public Function dot(ByVal a() As Double, ByVal b() As Double) As Double

        Return a(0) * b(0) + a(1) * b(1) + a(2) * b(2)

    End Function

    'matrix 4x4
    Public Function inputMatrix44(ByVal a00 As Double, ByVal a01 As Double, ByVal a02 As Double, ByVal a03 As Double,
                             ByVal a10 As Double, ByVal a11 As Double, ByVal a12 As Double, ByVal a13 As Double,
                             ByVal a20 As Double, ByVal a21 As Double, ByVal a22 As Double, ByVal a23 As Double,
                             ByVal a30 As Double, ByVal a31 As Double, ByVal a32 As Double, ByVal a33 As Double) As Double()()

        Dim c(3)() As Double

        c(0) = New Double() {a00, a01, a02, a03}
        c(1) = New Double() {a10, a11, a12, a13}
        c(2) = New Double() {a20, a21, a22, a23}
        c(3) = New Double() {a30, a31, a32, a33}

        Return c
    End Function

    'matrix multiplucation 4x4 * 4x4
    Public Function matrixMul44(ByVal a()() As Double, b()() As Double) As Double()()
        Dim temp As Double
        Dim c(3)() As Double

        'create empty multidimension array 4x4
        For i = 0 To 3
            c(i) = New Double(4) {}
        Next

        'multiplying
        For i = 0 To 3
            For j = 0 To 3

                For k = 0 To 3
                    temp += a(i)(k) * b(k)(j)
                Next
                c(i)(j) = temp
                temp = 0
            Next
        Next

        Return c
    End Function

    'matrix multiplucation 4x1 * 4x4
    Public Function matrixMul14(ByVal a() As Double, b()() As Double) As Double()
        Dim temp As Double
        Dim c(3) As Double

        'multiplying
        For j = 0 To 3
            For k = 0 To 3
                temp += a(k) * b(k)(j)
            Next
            c(j) = temp
            temp = 0
        Next

        Return c
    End Function

End Class
