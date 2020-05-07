Imports System.IO
Module Module1

    Sub Main()
        Console.Write("Login:> ")
        Dim strLogin As String = Console.ReadLine
        Console.Write("Senha:> ")
        Dim strSenha As String = Console.ReadLine
        If Len(strLogin) > 0 And Len(strSenha) > 0 Then
            Try
                Dim bw As New StreamWriter(New FileStream("user.txt", FileMode.Create))
                Try
                    bw.Write(strLogin)
                    bw.Write(";")
                    bw.Write(strSenha)
                    bw.Write(";")
                Catch ex As Exception

                    Console.WriteLine("Erro na escrita. " & vbNewLine & ex.Message)

                End Try
                bw.Close()
            Catch ex As Exception

                Console.WriteLine("Erro ao criar o ficheiro!" & vbNewLine & ex.Message)
                Return

            End Try
        End If
        Console.Read()
    End Sub

End Module
