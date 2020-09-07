
Public Class operation

    Public Bit As New Bitmap(400, 400)
    Public G As Graphics = Graphics.FromImage(Bit)

    Dim v As New List(Of vertices)
    Dim vScreen As New List(Of Points)
    Dim listPoly As New List(Of Polygon)
    Dim listFrontPoly As New List(Of Polygon)

    Public radius, dTeta, dPhi As Double
    Public nLong As Integer
    Public nLat As Integer

    Public dop(2) As Double
    Public defaultTranslateX As Double = 0.0
    Public defaultTranslateY As Double = 0.0
    Public translateX As Double = defaultTranslateX
    Public translateY As Double = defaultTranslateY

    Public xCenter, yCenter As Double

    Public centerSphere As New vertices

    Public m As New matrix

    Public viewer(2) As Double
    Public lightSource(2) As Double
    Public defaultlight(2) As Double

    Public ILight As Double
    Public IAmbient As Double
    Public coefAmbient As Double
    Public coefDiffuse As Double
    Public coefSpecular As Double
    Public rExponentSpecular As Double


    Public Sub load()
        nLat = 15 'default 15
        nLong = 25 'default 25

        dTeta = 360 / nLong
        dPhi = 90 / nLat

        dop(0) = 0
        dop(1) = 0
        dop(2) = -1

        viewer(0) = 0
        viewer(1) = 0
        viewer(2) = 4

        defaultlight(0) = -10
        defaultlight(1) = 10
        defaultlight(2) = 10

        lightSource(0) = defaultlight(0)
        lightSource(1) = defaultlight(1)
        lightSource(2) = defaultlight(2)

        ILight = 1
        IAmbient = 0.5
        coefAmbient = 0.1
        coefDiffuse = 0.9
        coefSpecular = 0.6
        rExponentSpecular = 1

        xCenter = FormGouraud.PictureBox.Width / 2
        yCenter = FormGouraud.PictureBox.Height / 2

        centerSphere.x = 0
        centerSphere.y = 0
        centerSphere.z = 0
        radius = 1

        listVertex()
        listPolygon()
        process()

    End Sub

    Public Sub process()
        calWT()
        backFaceCulling()
        calVT()
        FormGouraud.lblCenter.Text = "(" + centerSphere.x.ToString + ", " + centerSphere.y.ToString + ", " + centerSphere.z.ToString + ")"
        calST()
        G.Clear(Color.Black)
        processFrontPoly()
        'drawSphere()
        FormGouraud.PictureBox.Image = Bit
        listFrontPoly.Clear()
        vScreen.Clear()
    End Sub

    Private Function calVertex(ByVal teta As Double, ByVal phi As Double) As List(Of Double)
        Dim x, y, z, d As Double
        Dim vertices As New List(Of Double)
        Dim aPhi, aTeta As Double

        aPhi = Math.PI * phi / 180.0
        aTeta = Math.PI * teta / 180.0
        y = radius * Math.Sin(aPhi)
        d = radius * Math.Cos(aPhi)
        x = d * Math.Sin(aTeta)
        z = d * Math.Cos(aTeta)

        vertices.Add(x)
        vertices.Add(y)
        vertices.Add(z)

        Return vertices
    End Function

    Private Sub calWT()
        Dim WT(3)() As Double
        WT(0) = New Double() {1, 0, 0, 0}
        WT(1) = New Double() {0, 1, 0, 0}
        WT(2) = New Double() {0, 0, 1, 0}
        WT(3) = New Double() {0, 0, 0, 1}

        Dim vertices(3) As Double

        vertices(0) = centerSphere.x
        vertices(1) = centerSphere.y
        vertices(2) = centerSphere.z
        vertices(3) = 1

        vertices = m.matrixMul14(vertices, WT)

        centerSphere.x = vertices(0)
        centerSphere.y = vertices(1)
        centerSphere.z = vertices(2)

        For Each vertex In v
            vertices(0) = vertex.x
            vertices(1) = vertex.y
            vertices(2) = vertex.z
            vertices(3) = 1

            vertices = m.matrixMul14(vertices, WT)

            vertex.x = vertices(0)
            vertex.y = vertices(1)
            vertex.z = vertices(2)
        Next

    End Sub

    Private Sub calVT()
        Dim VT(3)() As Double
        VT(0) = New Double() {1, 0, 0, 0}
        VT(1) = New Double() {0, 1, 0, 0}
        VT(2) = New Double() {0, 0, 1, 0}
        VT(3) = New Double() {translateX, translateY, 0, 1}

        Dim vertices(3) As Double

        vertices(0) = centerSphere.x
        vertices(1) = centerSphere.y
        vertices(2) = centerSphere.z
        vertices(3) = 1

        vertices = m.matrixMul14(vertices, VT)

        centerSphere.x = vertices(0)
        centerSphere.y = vertices(1)
        centerSphere.z = vertices(2)

        For Each vertex In v
            Dim magN As Double

            vertices(0) = vertex.x
            vertices(1) = vertex.y
            vertices(2) = vertex.z
            vertices(3) = 1

            vertices = m.matrixMul14(vertices, VT)

            vertex.x = vertices(0)
            vertex.y = vertices(1)
            vertex.z = vertices(2)

            vertex.N(0) = vertex.x - centerSphere.x
            vertex.N(1) = vertex.y - centerSphere.y
            vertex.N(2) = vertex.z - centerSphere.z
            magN = Math.Sqrt((vertex.N(0) * vertex.N(0)) + (vertex.N(1) * vertex.N(1)) + (vertex.N(2) * vertex.N(2)))
            vertex.N(0) = vertex.N(0) / magN
            vertex.N(1) = vertex.N(1) / magN
            vertex.N(2) = vertex.N(2) / magN

            vertex.I = calIntensity(vertex, vertex.N)
        Next

    End Sub

    Public Sub calST()
        Dim n As Integer = 0
        For Each vertex In v
            vScreen.Add(New Points)
            vScreen(n).newPoints(CInt((vertex.x * 150) + xCenter), CInt(-(vertex.y * 150) + yCenter), vertex.N, vertex.I)
            n += 1
        Next
    End Sub

    Public Function calculateNormal(v1 As vertices, v2 As vertices, v3 As vertices) As Double()
        Dim vector1(2), vector2(2), normal(2) As Double

        Dim vertices1(2) As Double
        Dim vertices2(2) As Double
        Dim vertices3(2) As Double

        vertices1(0) = v1.x
        vertices1(1) = v1.y
        vertices1(2) = v1.z

        vertices2(0) = v2.x
        vertices2(1) = v2.y
        vertices2(2) = v2.z

        vertices3(0) = v3.x
        vertices3(1) = v3.y
        vertices3(2) = v3.z

        vector1 = m.matrixMin33(vertices1, vertices2)
        vector2 = m.matrixMin33(vertices2, vertices3)

        normal = m.cross(vector1, vector2)

        Return normal
    End Function

    Private Sub backFaceCulling()
        Dim normal(2) As Double
        Dim dotProduct As Double
        Dim n As Integer

        For Each polygon In listPoly
            normal = calculateNormal(v(polygon.v1), v(polygon.v2), v(polygon.v3))
            dotProduct = m.dot(dop, normal)
            If (dotProduct < 0) Then
                listFrontPoly.Add(New Polygon)
                listFrontPoly(n) = polygon
                n = n + 1
            End If
        Next
    End Sub

    Private Function calIntensity(ByVal P As vertices, ByVal N As Double()) As Double
        Dim V(2) As Double
        Dim magV As Double
        Dim L(2) As Double
        Dim R(2) As Double
        Dim magL As Double

        Dim IA As Double
        Dim ID As Double
        Dim Ispecular As Double

        V(0) = viewer(0) - P.x
        V(1) = viewer(1) - P.y
        V(2) = viewer(2) - P.z
        magV = Math.Sqrt(Math.Pow(V(0), 2) + Math.Pow(V(1), 2) + Math.Pow(V(2), 2))
        V(0) = V(0) / magV
        V(1) = V(1) / magV
        V(2) = V(2) / magV

        L(0) = lightSource(0) - P.x
        L(1) = lightSource(1) - P.y
        L(2) = lightSource(2) - P.z
        magL = Math.Sqrt(Math.Pow(L(0), 2) + Math.Pow(L(1), 2) + Math.Pow(L(2), 2))
        L(0) = L(0) / magL
        L(1) = L(1) / magL
        L(2) = L(2) / magL

        R(0) = 2 * N(0) * m.dot(N, L) - L(0)
        R(1) = 2 * N(1) * m.dot(N, L) - L(1)
        R(2) = 2 * N(2) * m.dot(N, L) - L(2)

        IA = coefAmbient * IAmbient
        ID = coefDiffuse * ILight * m.dot(N, L)
        Ispecular = coefSpecular * ILight * Math.Pow(m.dot(V, R), rExponentSpecular)

        If m.dot(N, L) > 0 Then
            If m.dot(V, R) > 0 Then
                Return IA + ID + Ispecular
            Else
                Return IA + ID
            End If
        Else
            Return IA
        End If

    End Function

    Private Function caldeltaI(ByVal poly As Polygon) As Double()
        Dim P1P2(2) As Double
        Dim P2P3(2) As Double
        Dim NI(2) As Double
        Dim deltaI(1) As Double

        P1P2(0) = vScreen(poly.v2).x - vScreen(poly.v1).x
        P1P2(1) = vScreen(poly.v2).y - vScreen(poly.v1).y
        P1P2(2) = vScreen(poly.v2).I - vScreen(poly.v1).I

        P2P3(0) = vScreen(poly.v3).x - vScreen(poly.v2).x
        P2P3(1) = vScreen(poly.v3).y - vScreen(poly.v2).y
        P2P3(2) = vScreen(poly.v3).I - vScreen(poly.v2).I

        NI = m.cross(P1P2, P2P3)

        deltaI(0) = (NI(0) / NI(2)) * -1 ''''''deltaIx+1
        deltaI(1) = (NI(1) / NI(2)) * -1 ''''''deltaIy+1

        Return deltaI

    End Function

    Private Sub processFrontPoly()
        For Each polygon In listFrontPoly
            scanLine(polygon)
        Next
        'For i = 0 To 1
        '    scanLine(listFrontPoly(i))
        'Next

    End Sub

    Private Sub scanLine(ByVal polygon As Polygon)
        Dim activeEdgeList As EdgeBucket
        Dim edgeTable(400) As EdgeBucket
        Dim edges As New List(Of Edges)

        Dim ymin As Integer
        Dim ymax As Integer
        Dim xofYmin As Integer
        Dim dy As Integer
        Dim dx As Integer

        Dim dIx As Double
        Dim dIy As Double
        Dim intensity As Double

        Dim startPoint As Integer
        Dim endPoint As Integer
        Dim col

        startPoint = vScreen(polygon.v1).y
        endPoint = vScreen(polygon.v1).y

        dIx = caldeltaI(polygon)(0)

        dIy = caldeltaI(polygon)(1)
        intensity = vScreen(polygon.v3).I

        '''''''''''start Point'''''''''''''''''
        'Compare startPoint to v2
        If startPoint > vScreen(polygon.v2).y Then
            startPoint = vScreen(polygon.v2).y
        End If
        'Compare startPoint to v3
        If startPoint > vScreen(polygon.v3).y Then
            startPoint = vScreen(polygon.v3).y
        End If
        ''''''''''''''''''''''''''''''''''''''''

        ''''''''''end Point'''''''''''''''''
        'Compare endPoint to v2
        If endPoint < vScreen(polygon.v2).y Then
            endPoint = vScreen(polygon.v2).y
        End If
        'Compare endPoint to v3
        If endPoint < vScreen(polygon.v3).y Then
            endPoint = vScreen(polygon.v3).y
        End If
        ''''''''''''''''''''''''''''''''''''

        edges.Add(New Edges)
        edges(0).newEdge(vScreen(polygon.v1), vScreen(polygon.v2))

        edges.Add(New Edges)
        edges(1).newEdge(vScreen(polygon.v2), vScreen(polygon.v3))

        edges.Add(New Edges)
        edges(2).newEdge(vScreen(polygon.v3), vScreen(polygon.v1))

        ''''''''''''''''''''''''''Create Edge Bucket and insert to Edge Table'''''''''''''''''''''''''''''''
        For Each edge In edges
            If edge.v1.y <> edge.v2.y Then
                Dim edgeBucket As New EdgeBucket
                If edge.v1.y < edge.v2.y Then 'v2.Y > v1.Y
                    dy = edge.v2.y - edge.v1.y
                    dx = edge.v2.x - edge.v1.x
                    ymax = edge.v2.y
                    ymin = edge.v1.y
                    xofYmin = edge.v1.x
                ElseIf edge.v1.y > edge.v2.y Then 'v1.Y > v2.Y
                    dy = edge.v1.y - edge.v2.y
                    dx = edge.v1.x - edge.v2.x
                    ymax = edge.v1.y
                    ymin = edge.v2.y
                    xofYmin = edge.v2.x
                End If

                edgeBucket.yMax = ymax
                edgeBucket.xofYmin = xofYmin
                edgeBucket.dx = dx
                edgeBucket.dy = dy
                edgeBucket.carry = 0
                edgeBucket.nextEdge = Nothing

                If ymin >= 0 And ymin <= FormGouraud.PictureBox.Height Then
                    If edgeTable(ymin) Is Nothing Then
                        edgeTable(ymin) = edgeBucket
                    Else
                        edgeBucket.nextEdge = edgeTable(ymin)
                        edgeTable(ymin) = edgeBucket
                    End If
                End If
            End If
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''Sort buckets based on x'''''''''''''''''''''''''''
        For j = startPoint To endPoint
            Dim temp1 As New EdgeBucket
            Dim temp2 As New EdgeBucket
            If j >= 0 And j <= FormGouraud.PictureBox.Height Then
                If edgeTable(j) IsNot Nothing Then
                    If edgeTable(j).nextEdge IsNot Nothing Then
                        If edgeTable(j).nextEdge.xofYmin < edgeTable(j).xofYmin Then
                            temp1 = edgeTable(j).nextEdge
                            edgeTable(j).nextEdge = Nothing
                            temp2 = edgeTable(j)
                            edgeTable(j) = temp1
                            edgeTable(j).nextEdge = temp2
                        End If
                    End If
                End If
            End If
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''Scanline''''''''''''''''''''''''''''
        If startPoint >= 0 And startPoint <= FormGouraud.PictureBox.Height Then
            activeEdgeList = edgeTable(startPoint)
            Dim tempInten
            For j = startPoint To endPoint
                tempInten = intensity
                If activeEdgeList IsNot Nothing Then
                    For i = activeEdgeList.xofYmin To activeEdgeList.nextEdge.xofYmin
                        If tempInten > 1 Then
                            col = Color.FromArgb(255 * 1, 255 * 1, 255 * 1)
                        Else
                            If Not Double.IsNaN(tempInten) And Not Double.IsNegativeInfinity(tempInten) Then
                                col = Color.FromArgb(255 * tempInten, 255 * tempInten, 255 * tempInten)
                            End If
                        End If
                        If i < FormGouraud.PictureBox.Width And j < FormGouraud.PictureBox.Height And i >= 0 And j >= 0 Then
                            Bit.SetPixel(i, j, col)
                        End If
                        tempInten = tempInten + dIx
                    Next
                End If
                intensity = intensity + dIy
                ''''''''''''''''''''''''''''''''Update AEL''''''''''''''''''''''''''''''
                If activeEdgeList IsNot Nothing Then
                    activeEdgeList.carry += activeEdgeList.dx
                    If activeEdgeList.dx < 0 Then
                        While (-2 * activeEdgeList.carry >= activeEdgeList.dy)
                            activeEdgeList.xofYmin -= 1
                            activeEdgeList.carry += activeEdgeList.dy
                            intensity = intensity - dIx
                        End While
                    ElseIf activeEdgeList.dx >= 0 Then
                        While (2 * activeEdgeList.carry >= activeEdgeList.dy)
                            activeEdgeList.xofYmin += 1
                            activeEdgeList.carry -= activeEdgeList.dy
                            intensity = intensity + dIx
                        End While
                    End If

                    activeEdgeList.nextEdge.carry += activeEdgeList.nextEdge.dx
                    If activeEdgeList.nextEdge.dx < 0 Then
                        While (-2 * activeEdgeList.nextEdge.carry >= activeEdgeList.nextEdge.dy)
                            activeEdgeList.nextEdge.xofYmin -= 1
                            activeEdgeList.nextEdge.carry += activeEdgeList.nextEdge.dy
                        End While
                    ElseIf activeEdgeList.nextEdge.dx >= 0 Then
                        While (2 * activeEdgeList.nextEdge.carry >= activeEdgeList.nextEdge.dy)
                            activeEdgeList.nextEdge.xofYmin += 1
                            activeEdgeList.nextEdge.carry -= activeEdgeList.nextEdge.dy
                        End While
                    End If
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Next
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Public Sub drawSphere()
        For Each polygon In listFrontPoly
            Dim point1 As New Point(vScreen(polygon.v1).x, vScreen(polygon.v1).y)
            Dim point2 As New Point(vScreen(polygon.v2).x, vScreen(polygon.v2).y)
            Dim point3 As New Point(vScreen(polygon.v3).x, vScreen(polygon.v3).y)

            G.DrawLine(Pens.White, point1, point2)
            G.DrawLine(Pens.White, point2, point3)
            G.DrawLine(Pens.White, point3, point1)
        Next
    End Sub

    Private Sub listVertex()
        Dim n As Integer = 0
        Dim teta As Double
        Dim phi As Double

        'up
        For j = 0 To nLat - 1
            For i = 0 To nLong - 1
                phi = j * dPhi
                teta = i * dTeta

                v.Add(New vertices)
                v(n).newVertices(calVertex(teta, phi).Item(0), calVertex(teta, phi).Item(1), calVertex(teta, phi).Item(2))
                n = n + 1
            Next
        Next
        v.Add(New vertices)
        v(n).newVertices(0, radius, 0)
        n = n + 1

        'down
        For j = 1 To nLat - 1
            For i = 0 To nLong - 1
                phi = j * dPhi
                teta = i * dTeta

                v.Add(New vertices)
                v(n).newVertices(calVertex(teta, phi).Item(0), -calVertex(teta, phi).Item(1), calVertex(teta, phi).Item(2))
                n = n + 1
            Next
        Next
        v.Add(New vertices)
        v(n).newVertices(0, -radius, 0)
    End Sub

    Private Sub listPolygon()
        Dim k As Integer
        Dim n As Integer = 0

        'up
        For j = 0 To nLat - 2
            k = j * nLong
            For i = 0 To nLong - 2

                listPoly.Add(New Polygon)
                listPoly(n).newPolygon(i + k, i + k + 1, i + k + nLong + 1)
                n = n + 1

                listPoly.Add(New Polygon)
                listPoly(n).newPolygon(i + k, i + k + nLong + 1, i + k + nLong)
                n = n + 1
            Next

            listPoly.Add(New Polygon)
            listPoly(n).newPolygon(k + nLong - 1, k, k + nLong)
            n = n + 1

            listPoly.Add(New Polygon)
            listPoly(n).newPolygon(k + nLong - 1, k + nLong, k + 2 * nLong - 1)
            n = n + 1
        Next

        For i = (nLat - 1) * nLong To nLat * nLong - 2

            listPoly.Add(New Polygon)
            listPoly(n).newPolygon(i, i + 1, nLat * nLong)
            n = n + 1
        Next

        listPoly.Add(New Polygon)
        listPoly(n).newPolygon(nLat * nLong - 1, (nLat - 1) * nLong, nLat * nLong)
        n = n + 1

        'down
        Dim l As Integer = nLat * nLong + 1
        For j = 0 To nLat - 2
            k = j * nLong
            For i = 0 To nLong - 2

                If j = 0 Then
                    listPoly.Add(New Polygon)
                    listPoly(n).newPolygon(i + l + k, i + l + 1 + k, i + 1 + k)
                    n = n + 1

                    listPoly.Add(New Polygon)
                    listPoly(n).newPolygon(i + l + k, i + 1 + k, i + k)
                    n = n + 1

                Else
                    listPoly.Add(New Polygon)
                    listPoly(n).newPolygon(i + k + l, i + k + 1 + l, i + k + 1 + l - nLong)
                    n = n + 1

                    listPoly.Add(New Polygon)
                    listPoly(n).newPolygon(i + k + l, i + k + 1 + l - nLong, i + k + l - nLong)
                    n = n + 1
                End If

            Next

            If j = 0 Then
                listPoly.Add(New Polygon)
                listPoly(n).newPolygon(l + nLong - 1, l, 0)
                n = n + 1

                listPoly.Add(New Polygon)
                listPoly(n).newPolygon(l + nLong - 1, 0, nLong - 1)
                n = n + 1
            Else
                listPoly.Add(New Polygon)
                listPoly(n).newPolygon(l + nLong - 1 + k, k + l, k + l - nLong)
                n = n + 1

                listPoly.Add(New Polygon)
                listPoly(n).newPolygon(l + nLong - 1 + k, k + l - nLong, l - 1 + k)
                n = n + 1
            End If

        Next

        Dim idxDown = nLong * (2 * nLat - 1) + 1

        For i = 2 * nLong * (nLat - 1) To nLong * (2 * nLat - 1) - 1
            listPoly.Add(New Polygon)
            listPoly(n).newPolygon(i, idxDown, i + 1)
            n = n + 1
        Next
        listPoly.Add(New Polygon)
        listPoly(n).newPolygon(idxDown - 1, idxDown, idxDown - nLong)

    End Sub

End Class

Public Class vertices
    Public x As Double
    Public y As Double
    Public z As Double
    Public N(2) As Double
    Public I As Double

    Public Sub newVertices(ByVal x As Double, ByVal y As Double, ByVal z As Double)
        Me.x = x
        Me.y = y
        Me.z = z
    End Sub

End Class

Public Class Points
    Public x As Integer
    Public y As Integer
    Public N(2) As Double
    Public I As Double

    Public Sub newPoints(ByVal x As Integer, ByVal y As Integer, ByVal N As Double(), ByVal I As Double)
        Me.x = x
        Me.y = y
        Me.N = N
        Me.I = I
    End Sub
End Class

Public Class Polygon
    Public v1, v2, v3 As Integer

    Public Sub newPolygon(ByVal v1 As Integer, ByVal v2 As Integer, ByVal v3 As Integer)
        Me.v1 = v1
        Me.v2 = v2
        Me.v3 = v3

    End Sub
End Class

Public Class Edges
    Public v1 As Points
    Public v2 As Points

    Public Sub newEdge(ByVal v1 As Points, ByVal v2 As Points)
        Me.v1 = v1
        Me.v2 = v2
    End Sub
End Class

Public Class EdgeBucket
    Public yMax As Integer 'y max of the edge
    Public xofYmin As Integer 'smallest x of the ymin
    Public dx As Integer 'x endpoint - x startpoint of the edge
    Public dy As Integer 'ymax of the edge - ymix of the edge
    Public carry As Integer
    Public nextEdge As EdgeBucket = Nothing

End Class
