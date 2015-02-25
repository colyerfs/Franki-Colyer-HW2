Public Class frmPrimePairs
    Private Sub InitializeLabels(sender As Object, e As EventArgs) Handles txtUpperBound.TextChanged
        lblCousinPrimes.Text = "..."
        lblTwinPrimes.Text = "..."
        lblSexyPrimes.Text = "..."

    End Sub

    Private Sub DiscoverPrimeFamily()
        Dim primes() As Integer = {}
        Dim primePairs()() As Integer = {
            New Integer() {},
            New Integer() {},
            New Integer() {}
            }
        Dim numPrimePairs() As Integer = {primePairs(0).Length, primePairs(1).Length, primePairs(2).Length}
        Dim currNum As Long, lastPrime As Integer, upperBound As Integer, length As Integer
        upperBound = txtUpperBound.Text


        For i As Integer = 0 To lastPrime > txtUpperBound.Text
            IsPrime(currNum)
            If IsPrime(currNum) = True Then
                If currNum > txtUpperBound.Text Then
                    Exit For
                ElseIf currNum < txtUpperBound.Text Then
                    lastPrime = currNum
                    ReDim Preserve primes(currNum)

                End If
            Else
                Exit Sub
            End If
            currNum += 1
        Next

        primes().Length -primes().Length - 1

        primes.GetLength(-primes.GetLength - 1)

        Next
        Select Case 

        End Select
            Case 2




    End Sub

    Private Sub btnFindPrimes_Click(sender As Object, e As EventArgs) Handles btnFindPrimes.Click

        If Not IsNumeric(txtUpperBound.Text) Then
            MessageBox.Show = "Please Enter a Numeric Value"
            Exit Sub
        ElseIf CInt(txtUpperBound.Text) < 3 Or CInt(txtUpperBound.Text) > 500 Then
            MessageBox.Show = "Number is out of bounds"
            Exit Sub
        Else
            DiscoverPrimeFamily()

        End If


        
    End Sub

End Class

