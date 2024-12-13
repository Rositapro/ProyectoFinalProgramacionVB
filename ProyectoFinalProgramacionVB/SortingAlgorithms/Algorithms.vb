Public Class Algorithms
    ' Merge Sort principal
    Public Shared Sub MergeSort(array As Integer(), left As Integer, right As Integer, displayCallback As Action(Of Integer(), String))
        If left < right Then
            Dim middle As Integer = (left + right) \ 2
            displayCallback(array.Skip(left).Take(right - left + 1).ToArray(), $"División: {left} - {right}")

            MergeSort(array, left, middle, displayCallback)
            MergeSort(array, middle + 1, right, displayCallback)
            Merge(array, left, middle, right, displayCallback)
        End If
    End Sub

    ' Método Merge
    Private Shared Sub Merge(array As Integer(), left As Integer, middle As Integer, right As Integer, displayCallback As Action(Of Integer(), String))
        Dim leftArray = array.Skip(left).Take(middle - left + 1).ToArray()
        Dim rightArray = array.Skip(middle + 1).Take(right - middle).ToArray()

        Dim i = 0, j = 0, k = left

        While i < leftArray.Length AndAlso j < rightArray.Length
            If leftArray(i) <= rightArray(j) Then
                array(k) = leftArray(i)
                i += 1
            Else
                array(k) = rightArray(j)
                j += 1
            End If
            k += 1
        End While

        While i < leftArray.Length
            array(k) = leftArray(i)
            i += 1
            k += 1
        End While

        While j < rightArray.Length
            array(k) = rightArray(j)
            j += 1
            k += 1
        End While

        displayCallback(array, "Merge paso completado")
    End Sub

    ' Direct Merge
    Public Shared Sub DirectMerge(array As Integer(), displayCallback As Action(Of Integer(), String))
        Dim n = array.Length
        Dim temp(n - 1) As Integer

        For width As Integer = 1 To n - 1 Step width * 2
            displayCallback(CType(array.Clone(), Integer()), $"División con width = {width}")

            For i As Integer = 0 To n - 1 Step 2 * width
                Dim left = i
                Dim middle = Math.Min(i + width, n)
                Dim right = Math.Min(i + 2 * width, n)

                Dim l = left, r = middle, k = left
                While l < middle AndAlso r < right
                    If array(l) <= array(r) Then
                        temp(k) = array(l)
                        l += 1
                    Else
                        temp(k) = array(r)
                        r += 1
                    End If
                    k += 1
                End While
                While l < middle
                    temp(k) = array(l)
                    l += 1 : k += 1
                End While
                While r < right
                    temp(k) = array(r)
                    r += 1 : k += 1
                End While
            Next

            array.Copy(temp, array, n)
            displayCallback(CType(array.Clone(), Integer()), $"Mezcla después de width = {width}")
        Next
    End Sub
    Public Shared Sub NaturalMerge(ByVal array As Integer(), ByVal displayCallback As Action(Of Integer(), String))
        Dim ordenado As Boolean = False
        Dim temp(array.Length - 1) As Integer

        ' El ciclo while se ejecuta mientras ordenado sea False
        While Not ordenado
            ordenado = True
            Dim i As Integer = 0

            ' Mostrar el arreglo antes de iniciar el ciclo de mezcla
            displayCallback(array, "División en sub-secuencias")

            While i < array.Length
                Dim start As Integer = i

                ' Encuentra el final de la primera secuencia ordenada
                While i < array.Length - 1 AndAlso array(i) <= array(i + 1)
                    i += 1
                End While
                i += 1

                Dim j As Integer = i

                ' Encuentra el final de la segunda secuencia ordenada
                While i < array.Length - 1 AndAlso array(i) <= array(i + 1)
                    i += 1
                End While
                i += 1

                ' Mezcla las sub-secuencias en el arreglo temporal
                If j < array.Length Then
                    MergeNatural(array, start, j, Math.Min(i, array.Length), temp)
                    ordenado = False
                End If
            End While

            ' Copia el arreglo temporal de vuelta al arreglo original
            array.Copy(temp, 0, array, 0, array.Length)

            ' Muestra el estado del arreglo después de cada ciclo de mezcla
            displayCallback(array, "Mezcla completa")
        End While
    End Sub

    ' Método MergeNatural sin el callback interno
    Private Shared Sub MergeNatural(ByVal array As Integer(), ByVal left As Integer, ByVal middle As Integer, ByVal right As Integer, ByVal temp As Integer())
        Dim i As Integer = left
        Dim j As Integer = middle
        Dim k As Integer = left

        ' Mezcla las dos secuencias ordenadas
        While i < middle AndAlso j < right
            If array(i) <= array(j) Then
                temp(k) = array(i)
                i += 1
            Else
                temp(k) = array(j)
                j += 1
            End If
            k += 1
        End While

        ' Copiar los elementos restantes de la primera secuencia
        While i < middle
            temp(k) = array(i)
            i += 1
            k += 1
        End While

        ' Copiar los elementos restantes de la segunda secuencia
        While j < right
            temp(k) = array(j)
            j += 1
            k += 1
        End While
    End Sub
End Class
