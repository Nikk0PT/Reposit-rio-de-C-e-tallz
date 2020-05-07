Imports System.IO

Module Module1



    Sub Main()

        Dim f As FileStream

        Try
            f = New FileStream("alfabeto.dat", FileMode.Create)
        Catch ex As Exception

            Console.WriteLine("Erro ao criar o ficheiro!" & vbNewLine & ex.Message)
            Return
        End Try

        For i As Integer = Asc("A") To Asc("Z")
            Try
                f.WriteByte(CByte(i))
            Catch ex As Exception
                Console.WriteLine("Erro ao escrever o ficheiro" & vbNewLine & ex.Message)
                Return
            End Try
        Next

        Console.WriteLine()
        f.Close()
    End Sub
End Module


