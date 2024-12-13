
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class SortingAlgorithmsForm
    Dim organizar As New Organization()
    Dim array As Integer() = New Integer(9) {}
    Public Sub New()
        InitializeComponent()

        ' ShellSort

        ' Configuración inicial del DataGridView
        dataGridView1.ColumnCount = 10 ' Vamos a mostrar el arreglo completo en una fila de 10 columnas
        dataGridView1.RowCount = 1      ' Solo una fila para los números

        ' Configurar el DataGridView para que no pueda editarse
        dataGridView1.AllowUserToAddRows = False
        dataGridView1.AllowUserToDeleteRows = False
        dataGridView1.ReadOnly = True

        ' Asegurar que se muestre correctamente el contenido
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' CountingSort
        stopwatchCountingSort = New Stopwatch()

        ' Configurar ComboBox con opciones de orden
        cBOrdenCountingSort.Items.Add("Ascendente")
        cBOrdenCountingSort.Items.Add("Descendente")
        cBOrdenCountingSort.SelectedIndex = 0 ' Seleccionar "Ascendente" por defecto

        ' BucketSort
        random = New Random()
        numbers = New Integer(9) {}

        ' Configuración del ListView lstvOrder
        lstvOrder.View = View.Details
        For i As Integer = 0 To 4
            lstvOrder.Columns.Add("" & i, 60)
        Next

        ' Configuración del ListView lstvBucket
        lstvBucket.View = View.Details
        lstvBucket.Columns.Add("Bucket", 80)
        lstvBucket.Columns.Add("Range", 80)
        lstvBucket.Columns.Add("Bucket numbers", 150)

        cbxOrderBucketSort.Items.Add("Ascendente")
        cbxOrderBucketSort.Items.Add("Descendente")
        cbxOrderBucketSort.SelectedIndex = 0 ' Predeterminado en Ascendente

        ' Merge sort
        InitializeListView()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim algorithmsForm As New AlgorithmsForm()
        algorithmsForm.Show()
        Me.Close()
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        If ComBoxSelect.SelectedItem Is Nothing Then
            MessageBox.Show("Selecciona un tipo de algoritmo de organización")
            Return
        End If

        Dim seleccion As String = ComBoxSelect.SelectedItem.ToString()

        LsBoxOrder.Items.Clear()
        Dim Numbers As Integer() = TxtDataNum.Text.Split(" "c).Select(Function(s) Integer.Parse(s)).ToArray()
        Dim arregloDesordenado As Integer() = organizar.DesordenarArreglo(Numbers)

        Select Case seleccion
            Case "Bubblesort"
                AddHandler organizar.OnSwap, AddressOf UpdateListBox
                organizar.BubbleSort(Numbers)
                RemoveHandler organizar.OnSwap, AddressOf UpdateListBox

            Case "Cocktail sort"
                AddHandler organizar.OnSwap, AddressOf UpdateListBox
                organizar.Cocktail_Sort(Numbers)
                RemoveHandler organizar.OnSwap, AddressOf UpdateListBox

            Case "Insertion sort"
                AddHandler organizar.OnSwap, AddressOf UpdateListBox
                organizar.Insertionsort(Numbers)
                RemoveHandler organizar.OnSwap, AddressOf UpdateListBox
        End Select
    End Sub

    Private Sub UpdateListBox(numbers As Integer())
        Dim line As String = String.Join(" ", numbers)
        LsBoxOrder.Items.Add(line)
    End Sub

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        Dim rand As New Random()
        array = New Integer(9) {}
        For i As Integer = 0 To array.Length - 1
            array(i) = rand.Next(0, 100)
        Next

        ' Display the array in the textbox
        tbArray.Text = String.Join(", ", array)
    End Sub
    Public Sub UpdateListBoxHeapSortQuickSortSelectionSort(array As Integer())
        If lboxArray.InvokeRequired Then
            lboxArray.Invoke(New Action(Of Integer())(AddressOf UpdateListBoxHeapSortQuickSortSelectionSort), array)
        Else
            lboxArray.Items.Clear()
            For Each item As Integer In array
                lboxArray.Items.Add(item)
            Next
        End If
    End Sub
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        'lBoxunsorted.Items.Clear()
        'For Each item As Integer In array
        '    lBoxunsorted.Items.Add(item)
        'Next

        'Select Case cbOption.SelectedIndex
        '    Case 0
        '        Dim selectionSorter As New Selectionsort(AddressOf UpdateListBoxHeapSortQuickSortSelectionSort)
        '        Await selectionSorter.SelectionSortAsync(array)

        '    Case 1
        '        Dim heapSorter As New Heapsort(AddressOf UpdateListBoxHeapSortQuickSortSelectionSort)
        '        Await heapSorter.HeapsortAsync(array)

        '    Case 2
        '        Dim quickSorter As New Quicksort(AddressOf UpdateListBoxHeapSortQuickSortSelectionSort)
        '        Await quickSorter.QuicksortAsync(array, 0, array.Length - 1)

        '    Case Else
        '        MessageBox.Show("Selecciona un algoritmo válido.")
        'End Select
    End Sub

    Private Sub btnShellSort_Click(sender As Object, e As EventArgs) Handles btnShellSort.Click
        Try
            ' Obtener los números ingresados por el usuario
            Dim input As String = txtInput.Text
            Dim numbers As Integer() = input.Split(New Char() {","c, " "c}, StringSplitOptions.RemoveEmptyEntries) _
                                            .Select(Function(x) Integer.Parse(x)) _
                                            .ToArray()

            ' Desordenar el arreglo antes de ordenar
            ShuffleArray(numbers)

            ' Mostrar el arreglo desordenado
            ShowArrayState(numbers)

            ' Aplicar Shell Sort y mostrar cada paso
            ShellSort(numbers)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCountingSort_Click(sender As Object, e As EventArgs) Handles btnCountingSort.Click
        ' Leer y procesar los números ingresados en el TextBox
        inputArrayCountingSort = txtInputCountingSort.Text.Split(",") _
                                                .Select(Function(n) Integer.Parse(n.Trim())) _
                                                .ToArray()

        ' Mezclar el arreglo con la clase ArrayShuffler
        ArrayShuffler.Shuffle(inputArrayCountingSort)

        ' Inicializar los arreglos y variables para el proceso de Counting Sort
        outputArrayCountingSort = New Integer(inputArrayCountingSort.Length - 1) {}
        Dim maxValue As Integer = inputArrayCountingSort.Max()
        countArrayCountingSort = New Integer(maxValue) {}
        maxIndexCountingSort = If(cBOrdenCountingSort.SelectedItem.ToString() = "Ascendente", 0, countArrayCountingSort.Length - 1)
        currentIndexCountingSort = 0

        ' Crear el arreglo de conteo
        For Each num As Integer In inputArrayCountingSort
            countArrayCountingSort(num) += 1
        Next

        ' Limpiar el DataGridView y mostrar el arreglo desordenado inicialmente
        dgvOutputCountingSort.Rows.Clear()
        dgvOutputCountingSort.Rows.Add("Desordenado: " & String.Join(", ", inputArrayCountingSort))

        ' Iniciar el temporizador para mostrar el ordenamiento paso a paso
        stopwatchCountingSort.Restart() ' Iniciar el cronómetro
        'Time.Start()
    End Sub
    ' Algoritmo de Shell Sort con visualización
    Private Sub ShellSort(ByVal arr As Integer())
        Dim n As Integer = arr.Length

        ' Inicializar el intervalo
        For gap As Integer = n \ 2 To 1 Step -1
            For i As Integer = gap To n - 1
                Dim temp As Integer = arr(i)
                Dim j As Integer

                ' Realizar la comparación y reordenamiento
                For j = i To gap Step -gap
                    If arr(j - gap) > temp Then
                        arr(j) = arr(j - gap)
                        ' Mostrar el estado actual con los cambios
                        ShowArrayState(arr, j, j - gap) ' Resaltamos los elementos intercambiados
                    Else
                        Exit For
                    End If
                Next

                arr(j) = temp
                ' Mostrar el estado después de la inserción
                ShowArrayState(arr, j, i)
            Next
        Next
    End Sub
    Private Sub ShowArrayState(ByVal arr As Integer(), Optional ByVal index1 As Integer? = Nothing, Optional ByVal index2 As Integer? = Nothing)
        ' Agregar el arreglo como una nueva fila (acumulando los cambios)
        Dim row As New DataGridViewRow()
        For Each number As Integer In arr
            Dim cell As New DataGridViewTextBoxCell With {.Value = number}
            row.Cells.Add(cell)
        Next
        dataGridView1.Rows.Add(row)

        ' Resaltar los intercambios en la fila
        If index1.HasValue AndAlso index2.HasValue Then
            dataGridView1.Rows(dataGridView1.Rows.Count - 1).Cells(index1.Value).Style.BackColor = Color.Yellow
            dataGridView1.Rows(dataGridView1.Rows.Count - 1).Cells(index1.Value).Style.ForeColor = Color.Red
            dataGridView1.Rows(dataGridView1.Rows.Count - 1).Cells(index2.Value).Style.BackColor = Color.Yellow
            dataGridView1.Rows(dataGridView1.Rows.Count - 1).Cells(index2.Value).Style.ForeColor = Color.Red
        End If

        ' Actualizar la interfaz
        dataGridView1.Refresh()
        System.Threading.Thread.Sleep(500) ' Pausa para visualizar el cambio
    End Sub

    ' Función para desordenar el arreglo (Algoritmo Fisher-Yates)
    Private Sub ShuffleArray(ByVal arr As Integer())
        Dim rand As New Random()
        Dim n As Integer = arr.Length

        ' Recorremos el arreglo desde el final hasta el principio
        For i As Integer = n - 1 To 1 Step -1
            ' Elegimos un índice aleatorio entre 0 y i
            Dim j As Integer = rand.Next(0, i + 1)

            ' Intercambiamos arr(i) con arr(j)
            Dim temp As Integer = arr(i)
            arr(i) = arr(j)
            arr(j) = temp
        Next
    End Sub

    'counting sort
    Private inputArrayCountingSort As Integer()
    Private countArrayCountingSort As Integer()
    Private outputArrayCountingSort As Integer()
    Private maxIndexCountingSort As Integer
    Private currentIndexCountingSort As Integer
    Private stopwatchCountingSort As New Stopwatch()
    Private Sub timer1_Tick(sender As Object, e As EventArgs)
        Dim ascending As Boolean = cBOrdenCountingSort.SelectedItem.ToString() = "Ascendente"

        ' Condición para detener el temporizador según el orden elegido
        If (ascending AndAlso maxIndexCountingSort >= countArrayCountingSort.Length) OrElse (Not ascending AndAlso maxIndexCountingSort < 0) Then
            'timer1.Stop()
            stopwatchCountingSort.Stop() ' Detener el cronómetro

            ' Mostrar el tiempo total de ordenamiento en el label con formato hh:mm:ss:fff
            Dim elapsed As TimeSpan = stopwatchCountingSort.Elapsed
            lblTimeElapsed.Text = String.Format("Tiempo de ordenamiento: {0:hh\:mm\:ss\:fff}", elapsed)
            MessageBox.Show(String.Format("El ordenamiento ha finalizado.{0}Tiempo total: {1:hh\:mm\:ss\:fff}", Environment.NewLine, elapsed), "Ordenamiento Completado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Si el valor en countArrayCountingSort(maxIndexCountingSort) es mayor que cero, agregar al outputArrayCountingSort
        If countArrayCountingSort(maxIndexCountingSort) > 0 Then
            outputArrayCountingSort(currentIndexCountingSort) = maxIndexCountingSort
            currentIndexCountingSort += 1
            countArrayCountingSort(maxIndexCountingSort) -= 1

            ' Mostrar el estado actual del arreglo ordenado en una fila del DataGridView
            Dim currentState As String = String.Join(", ", outputArrayCountingSort.Select(Function(n) If(n = 0, "0", n.ToString())))
            dgvOutputCountingSort.Rows.Add("Ordenando: " & currentState)
        Else
            ' Avanzar al siguiente índice en el arreglo de conteo según el orden elegido
            maxIndexCountingSort += If(ascending, 1, -1)
        End If
    End Sub

    'BucketSort
    Private random As New Random()
    Private numbers As Integer()
    Private Sub btnBucketSort_Click(sender As Object, e As EventArgs) Handles btnBucketSort.Click

        For i As Integer = 0 To numbers.Length - 1
            numbers(i) = random.Next(1, 100)
        Next

        ' Mezclar el arreglo de números con la clase ArrayShuffler
        ArrayShuffler.Shuffle(numbers)

        ' Mostrar los números desordenados en el TextBox
        txtOrderBucketSort.Text = String.Join(" , ", numbers)

        If cbxOrderBucketSort.SelectedItem.ToString() = "Ascendente" Then
            BS(ascending:=True)
        Else
            BS(ascending:=False)
        End If
    End Sub
    Public Sub BS(ascending As Boolean)
        Dim bucketCount As Integer = 5
        Dim bucketSize As Integer = 5
        Dim buckets(bucketCount - 1)() As Integer
        Dim bucketSizes(bucketCount - 1) As Integer

        For i As Integer = 0 To bucketCount - 1
            buckets(i) = New Integer(bucketSize - 1) {}
        Next

        ' Configuración del rango de índices dependiendo del orden
        lstvBucket.Items.Clear()
        For i As Integer = 0 To numbers.Length - 1
            Dim bucketIndex As Integer
            If ascending Then
                bucketIndex = (numbers(i) - 1) \ (100 \ bucketCount)
            Else
                bucketIndex = (100 - numbers(i)) \ (100 \ bucketCount)
            End If

            For j As Integer = 0 To bucketSize - 1
                If buckets(bucketIndex)(j) = 0 Then
                    buckets(bucketIndex)(j) = numbers(i)
                    Exit For
                End If
            Next
        Next

        ' Mostrar los buckets en lstvBucket
        For i As Integer = 0 To bucketCount - 1
            Dim rangeStart, rangeEnd As Integer
            If ascending Then
                rangeStart = i * (100 \ bucketCount) + 1
                rangeEnd = (i + 1) * (100 \ bucketCount)
            Else
                rangeStart = 100 - (i * (100 \ bucketCount))
                rangeEnd = 100 - ((i + 1) * (100 \ bucketCount)) + 1
            End If

            Dim range As String = rangeEnd & " - " & rangeStart
            Dim bucketNumbers As String = String.Join(", ", buckets(i).Where(Function(x) x <> 0))
            Dim bucketItem As New ListViewItem((i + 1).ToString())
            bucketItem.SubItems.Add(range)
            bucketItem.SubItems.Add(bucketNumbers)
            lstvBucket.Items.Add(bucketItem)
        Next

        ' Ordenar cada bucket y mostrar los pasos
        lstvOrder.Items.Clear()
        For i As Integer = 0 To bucketCount - 1
            ' Mostrar el estado original del bucket
            AddOriginalBucketState(buckets(i))

            For j As Integer = 1 To bucketSize - 1
                Dim current As Integer = buckets(i)(j)
                If current = 0 Then
                    Exit For
                End If

                Dim k As Integer = j - 1
                While k >= 0 AndAlso (If(ascending, buckets(i)(k) > current, buckets(i)(k) < current))
                    ' Mover el número hacia adelante
                    buckets(i)(k + 1) = buckets(i)(k)

                    ' Mostrar el estado actual del bucket
                    AddStepToOrder(buckets(i))
                    k -= 1
                End While
                buckets(i)(k + 1) = current

                ' Mostrar el estado después de insertar
                AddStepToOrder(buckets(i))
            Next
        Next

        ' Copiar elementos de los buckets al arreglo principal
        Dim index As Integer = 0
        For i As Integer = 0 To bucketCount - 1 ' Recorrer los buckets en orden ascendente
            For j As Integer = 0 To bucketSize - 1
                If buckets(i)(j) <> 0 Then
                    numbers(index) = buckets(i)(j)
                    index += 1
                End If
            Next
        Next

        ' Mostrar el arreglo final ordenado
        txtOrderBucketSort.AppendText(" \nFinal order: " & String.Join(", ", numbers))
    End Sub

    Private Sub AddOriginalBucketState(bucket As Integer())
        ' Crear un ListViewItem para mostrar el estado original del bucket
        Dim originalItem As New ListViewItem("Original")

        For i As Integer = 0 To bucket.Length - 1
            Dim value As String = If(bucket(i) = 0, "", bucket(i).ToString())
            If i = 0 Then
                originalItem.Text = value
            Else
                originalItem.SubItems.Add(value)
            End If
        Next

        lstvOrder.Items.Add(originalItem)
    End Sub

    Private Sub AddStepToOrder(bucket As Integer())
        ' Crear un ListViewItem para mostrar el estado actual
        Dim stepItem As New ListViewItem()

        For i As Integer = 0 To bucket.Length - 1
            Dim value As String = If(bucket(i) = 0, "", bucket(i).ToString())
            If i = 0 Then
                stepItem.Text = value
            Else
                stepItem.SubItems.Add(value)
            End If
        Next

        lstvOrder.Items.Add(stepItem)
    End Sub

    ' MergeSort
    Private numbersMergeSort As Integer()

    Private Sub InitializeListView()
        listViewStepsMergeSort.View = View.Details
        listViewStepsMergeSort.Columns.Add("Descripción", 120)
        listViewStepsMergeSort.Columns.Add("Arreglo", 300)
        listViewStepsMergeSort.FullRowSelect = True
        listViewStepsMergeSort.GridLines = True
    End Sub

    Private Sub btnIngresarMergeSort_Click(sender As Object, e As EventArgs) Handles btnIngresarMergeSort.Click
        Try
            numbersMergeSort = txtInputMergeSort.Text.Split(",").Select(Function(n) Integer.Parse(n)).ToArray()
            If numbersMergeSort.Length <> 8 Then
                MessageBox.Show("Por favor, ingrese exactamente 8 números separados por comas.")
                Return
            End If

            ' Uso de la clase externa para mezclar elementos aleatoriamente
            ArrayShuffler.Shuffle(numbersMergeSort)
            listViewStepsMergeSort.Items.Clear()
            DisplayArray(numbersMergeSort, "Arreglo inicial (mezcla aleatoria)")
        Catch ex As FormatException
            MessageBox.Show("Ingrese solo números separados por comas, sin espacios.")
        End Try
    End Sub
    Private Sub DisplayArray(array As Integer(), description As String)
        ' Crear una copia del arreglo para evitar cambios inesperados
        Dim arrayCopy As Integer() = CType(array.Clone(), Integer())

        Dim item As New ListViewItem(description)
        item.SubItems.Add(String.Join(", ", arrayCopy))
        listViewStepsMergeSort.Items.Add(item)
    End Sub
    Private Sub btnMergeSort_Click(sender As Object, e As EventArgs) Handles btnMergeSort.Click
        listViewStepsMergeSort.Items.Clear()
        If numbersMergeSort Is Nothing OrElse numbersMergeSort.Length <> 8 Then
            MessageBox.Show("Primero ingrese los 8 números en el formato adecuado.")
            Return
        End If
        Algorithms.MergeSort(numbersMergeSort, 0, numbersMergeSort.Length - 1, AddressOf DisplayArray)
    End Sub

    Private Sub btnMezclaDirecta_Click(sender As Object, e As EventArgs) Handles btnMezclaDirecta.Click
        listViewStepsMergeSort.Items.Clear()
        If numbersMergeSort Is Nothing OrElse numbersMergeSort.Length <> 8 Then
            MessageBox.Show("Primero ingrese los 8 números en el formato adecuado.")
            Return
        End If
        Algorithms.DirectMerge(numbersMergeSort, AddressOf DisplayArray)
    End Sub


    Private Sub btnMezclaNatural_Click(sender As Object, e As EventArgs) Handles btnMezclaNatural.Click
        listViewStepsMergeSort.Items.Clear()
        If numbersMergeSort Is Nothing OrElse numbersMergeSort.Length <> 8 Then
            MessageBox.Show("Primero ingrese los 8 números en el formato adecuado.")
            Return
        End If
        Algorithms.NaturalMerge(numbersMergeSort, AddressOf DisplayArray)
    End Sub


    Private Sub btnClearListMergeSort_Click(sender As Object, e As EventArgs) Handles btnClearListMergeSort.Click
        listViewStepsMergeSort.Items.Clear()
    End Sub
    Private numbersGnomeSort As Integer() = {34, 2, 23, 67, 4, 90, 3}

    Private Sub SortingAlgorithmsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayNumbersGnomeSort(numbersGnomeSort)
    End Sub

    Private Sub btnShuffleGnomeSort_Click(sender As Object, e As EventArgs) Handles btnShuffleGnomeSort.Click
        ShuffleArrayGnomeSort(numbersGnomeSort)
        ' Muestra los números mezclados
        DisplayNumbersGnomeSort(numbersGnomeSort)
    End Sub



    Private Sub btnSortGnomeSort_Click(sender As Object, e As EventArgs) Handles btnSortGnomeSort.Click
        'Await GnomeSort(numbersGnomeSort)
    End Sub
    Private Sub DisplayNumbersGnomeSort(arrayGnomeSort As Integer(), Optional highlightIndex1 As Integer = -1, Optional highlightIndex2 As Integer = -1)
        listBoxGnomeSort.Items.Clear()

        Dim displayText As String = ""

        For i As Integer = 0 To arrayGnomeSort.Length - 1
            ' Resaltar los elementos en comparación o intercambio
            If i = highlightIndex1 OrElse i = highlightIndex2 Then
                displayText += $"[{arrayGnomeSort(i)}] "  ' Números comparados o intercambiados
            Else
                displayText += $"{arrayGnomeSort(i)} "  ' Números normales
            End If
        Next

        ' Mostrar todos los números en una fila
        listBoxGnomeSort.Items.Add(displayText.Trim())
    End Sub
    Private Async Function GnomeSort(arrayGnomeSort As Integer()) As Task
        Dim indexGnomeSort As Integer = 0

        While indexGnomeSort < arrayGnomeSort.Length
            ' Si estamos en el primer índice o el número actual es mayor o igual que el anterior
            If indexGnomeSort = 0 OrElse arrayGnomeSort(indexGnomeSort) >= arrayGnomeSort(indexGnomeSort - 1) Then
                ' Mostrar los números actuales y avanzar al siguiente índice
                DisplayNumbersGnomeSort(arrayGnomeSort, indexGnomeSort, indexGnomeSort - 1) ' Resaltamos los números que estamos comparando
                Await Task.Delay(1000) ' Pausa para visualizar la comparación sin intercambio
                indexGnomeSort += 1
            Else
                ' Si el número actual es menor que el anterior, intercambiamos
                DisplayNumbersGnomeSort(arrayGnomeSort, indexGnomeSort, indexGnomeSort - 1) ' Resaltamos los números que estamos intercambiando
                Await Task.Delay(1000) ' Pausa para visualizar el intercambio

                ' Realizamos el intercambio
                Dim tempGnomeSort As Integer = arrayGnomeSort(indexGnomeSort)
                arrayGnomeSort(indexGnomeSort) = arrayGnomeSort(indexGnomeSort - 1)
                arrayGnomeSort(indexGnomeSort - 1) = tempGnomeSort

                ' Retrocedemos al índice anterior para seguir comparando
                indexGnomeSort -= 1

                ' Asegurarse de no retroceder más allá del principio
                If indexGnomeSort < 0 Then
                    indexGnomeSort = 0
                End If

                ' Actualizar la visualización del arreglo con el intercambio
                DisplayNumbersGnomeSort(arrayGnomeSort)
                Await Task.Delay(1000) ' Pausa para visualizar el estado después del intercambio
            End If
        End While

        ' Mostrar el resultado final
        DisplayNumbersGnomeSort(arrayGnomeSort)
        MessageBox.Show("¡Complete ordering!", "Gnome Sort", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Function
    Private Sub ShuffleArrayGnomeSort(array As Integer())
        Dim rng As New Random()
        Dim n As Integer = array.Length
        While n > 1
            n -= 1
            Dim k As Integer = rng.Next(n + 1)
            Dim value As Integer = array(k)
            array(k) = array(n)
            array(n) = value
        End While
    End Sub
    Private Sub btnSortPidgeonHola_Click(sender As Object, e As EventArgs) Handles btnSortPidgeonHola.Click
        Try
            ' Leer los números del TextBox
            Dim arr As Integer() = txtInputPidgeonHola.Text.Split(","c).Select(Function(n) Integer.Parse(n)).ToArray()

            ' Ordenar el array usando Pigeonhole Sort
            PidgeonholeSort(arr)

            ' Mostrar el array ordenado en el TextBox
            txtOutputPidgeonHola.Text = String.Join(", ", arr)
        Catch ex As Exception
            MessageBox.Show("Por favor, ingresa números válidos separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub PidgeonholeSort(arr As Integer())
        Dim min As Integer = arr.Min()
        Dim max As Integer = arr.Max()
        Dim range As Integer = max - min + 1
        Dim holes As Integer() = New Integer(range - 1) {}

        ' Inicializar los agujeros
        For Each num As Integer In arr
            holes(num - min) += 1
        Next

        ' Recoger los elementos de los agujeros y ponerlos de vuelta en el array
        Dim index As Integer = 0
        For i As Integer = 0 To range - 1
            While holes(i) > 0
                arr(index) = i + min
                index += 1
                holes(i) -= 1
            End While
        Next
    End Sub

    Private Sub btnClearPidgeonHola_Click(sender As Object, e As EventArgs) Handles btnClearPidgeonHola.Click
        txtOutputPidgeonHola.Clear()
    End Sub

    Private Sub btnSortCombSort_Click(sender As Object, e As EventArgs) Handles btnSortCombSort.Click
        ' Limpia el DataGridView para el nuevo conjunto de datos
        dataGridViewStepsCombSort.Rows.Clear()
        dataGridViewStepsCombSort.Columns.Clear()

        ' Genera un arreglo de 6 números aleatorios
        Dim numbersCombSort As Integer() = GenerateRandomArrayCombSort(6)

        ' Crea las columnas en el DataGridView
        For i As Integer = 0 To numbersCombSort.Length - 1
            dataGridViewStepsCombSort.Columns.Add("Column" & i.ToString(), "Elemento " & i.ToString())
        Next

        ' Muestra el arreglo inicial en el DataGridView
        AddArrayToDataGridViewCombSort(numbersCombSort, "Array inicial")

        ' Llama al método de Comb Sort y muestra el proceso en DataGridView
        CombSort(numbersCombSort)

        ' Muestra el resultado final en el DataGridView
        AddArrayToDataGridViewCombSort(numbersCombSort, "Array ordenado")
    End Sub
    Private Function GenerateRandomArrayCombSort(size As Integer) As Integer()
        Dim randomCombSort As New Random()
        Dim array As Integer() = New Integer(size - 1) {}
        For i As Integer = 0 To size - 1
            array(i) = randomCombSort.Next(1, 101) ' Números aleatorios entre 1 y 100
        Next
        Return array
    End Function

    Private Sub CombSort(array As Integer())
        Dim gap As Integer = array.Length
        Dim swapped As Boolean = True
        Dim shrinkFactor As Double = 1.3

        ' Comienza el proceso de ordenamiento
        While gap > 1 OrElse swapped
            ' Actualiza el valor de gap
            gap = CInt(gap / shrinkFactor)
            If gap < 1 Then
                gap = 1
            End If

            swapped = False

            ' Recorre el arreglo y compara elementos a la distancia actual
            For i As Integer = 0 To array.Length - gap - 1
                If array(i) > array(i + gap) Then
                    ' Intercambia los elementos
                    Dim temp As Integer = array(i)
                    array(i) = array(i + gap)
                    array(i + gap) = temp
                    swapped = True

                    ' Muestra el estado actual del arreglo en el DataGridView
                    AddArrayToDataGridViewCombSort(array, "Paso intermedio")
                End If
            Next
        End While
    End Sub

    Private Sub AddArrayToDataGridViewCombSort(array As Integer(), label As String)
        ' Crea una fila nueva en el DataGridView
        Dim rowIndex As Integer = dataGridViewStepsCombSort.Rows.Add()
        For i As Integer = 0 To array.Length - 1
            dataGridViewStepsCombSort.Rows(rowIndex).Cells(i).Value = array(i)
        Next
    End Sub

    ' RadixSort
    Private Sub RandomizeNumbers()
        Dim random As New Random()
        ' Genera una lista de 10 números aleatorios entre 1 y 1000
        Dim numbers As List(Of Integer) = (From i In Enumerable.Range(0, 10)
                                           Select random.Next(1, 1000)).ToList()
        txtNumbersRadixSort.Text = String.Join(", ", numbers)
    End Sub


    Private Sub btnRandomizeRadixSort_Click(sender As Object, e As EventArgs) Handles btnRandomizeRadixSort.Click
        RandomizeNumbers()
    End Sub

    Private Sub btnLSDRadixSort_Click(sender As Object, e As EventArgs) Handles btnLSDRadixSort.Click
        PerformRadixSort(lsd:=True) '
    End Sub

    Private Sub btnMSDRadixSort_Click(sender As Object, e As EventArgs) Handles btnMSDRadixSort.Click
        PerformRadixSort(lsd:=False)
    End Sub
    Private Sub PerformRadixSort(ByVal lsd As Boolean)
        If String.IsNullOrWhiteSpace(txtNumbersRadixSort.Text) Then
            MessageBox.Show("Please enter numbers to sort.")
            Return
        End If

        ' Parse numbers
        Dim input As String() = txtNumbersRadixSort.Text.Split(New Char() {","c, " "c}, StringSplitOptions.RemoveEmptyEntries)
        Dim numbers As List(Of Integer) = input.Select(Function(num) Convert.ToInt32(num)).ToList()

        ' Perform sorting
        Dim sorted As List(Of Integer)
        If lsd Then
            sorted = RadixSortLSD(numbers)
        Else
            'sorted = RadixSortMSD(numbers)
        End If

        ' Display sorted numbers
        lstSortedRadixSort.Items.Clear()
        For Each num As Integer In sorted
            lstSortedRadixSort.Items.Add(num)
        Next
    End Sub

    Private Function RadixSortLSD(ByVal numbers As List(Of Integer)) As List(Of Integer)
        Dim maxNumber As Integer = numbers.Max()
        Dim maxDigits As Integer = maxNumber.ToString().Length

        For digit As Integer = 0 To maxDigits - 1
            numbers = numbers.OrderBy(Function(num) (num / CInt(Math.Pow(10, digit))) Mod 10).ToList()
        Next

        Return numbers
    End Function

    'Private Function RadixSortMSD(ByVal numbers As List(Of Integer)) As List(Of Integer)
    '' Método interno de ordenación recursiva
    'Sub Sort(ByRef list As List(Of Integer), ByVal digit As Integer)
    '    ' Caso base para detener la recursión
    '    If list.Count <= 1 OrElse digit < 0 Then
    '        Return
    '    End If

    '    ' Crear los "buckets" para cada dígito (0-9)
    '    Dim buckets(9) As List(Of Integer)
    '    For i As Integer = 0 To 9
    '        buckets(i) = New List(Of Integer)()
    '    Next

    '    ' Distribuir los números en los "buckets" basados en el dígito actual
    '    For Each num As Integer In list
    '        Dim bucketIndex As Integer = (num / CInt(Math.Pow(10, digit))) Mod 10
    '        buckets(bucketIndex).Add(num)
    '    Next

    '    ' Limpiar la lista original y agregar los números de los "buckets"
    '    list.Clear()
    '    For Each bucket As List(Of Integer) In buckets
    '        Sort(bucket, digit - 1)  ' Recursión con el siguiente dígito
    '        list.AddRange(bucket)
    '    Next
    'End Sub

    '' Obtener el número máximo y calcular el número de dígitos
    'Dim maxNumber As Integer = numbers.Max()
    'Dim maxDigits As Integer = maxNumber.ToString().Length

    '' Llamar a la función Sort para ordenar los números
    'Sort(numbers, maxDigits - 1)

    '' Retornar la lista ordenada
    'Return numbers
    'End Function


End Class