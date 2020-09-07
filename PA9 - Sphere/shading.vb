Public Class Shading
    Public coefAmbient As Double = 0
    Public coefDiffuse As Double = 0
    Public coefSpecular As Double = 0
    Public rExponentSpecular As Double = 0

    Public lightSource(2) As Double

    Public defaultLightX As Double = -10
    Public defaultLightY As Double = 10
    Public defaultLightZ As Double = 10

    Public Sub main()
        lightSource(0) = 0
        lightSource(1) = 0
        lightSource(2) = 0
    End Sub
End Class
