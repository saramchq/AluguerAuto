Public Class Form1

    Private Sub Btncalcular_Click(sender As Object, e As EventArgs) Handles Btncalcular.Click
        Dim DataAluguer As Date
        Dim DataFinal As Date

        Dim KmInicial As Integer
        Dim KmFinal As Integer

        Dim Ndias As Integer
        Dim Kms As Integer

        Dim TotalDias As Integer
        Dim TotalKms As Single
        Dim ValorTotal As Integer

        If Not IsDate(txtinicio.Text) Then
            MsgBox("Por favor, digite uma Data Válida", MsgBoxStyle.Exclamation, "Data Aluguer")
            txtinicio.Focus()
        End If

        If Not IsDate(txtentrega.Text) Then
            MsgBox("Por favor, digite uma Data Válida", MsgBoxStyle.Exclamation, "Data Aluguer")
            txtentrega.Focus()
        End If

        'Calculo do nº de dias e valor por dias
        DataAluguer = CDate(txtinicio.Text)
        DataFinal = CDate(txtentrega.Text)

        Ndias = DateDiff(DateInterval.Day, DataAluguer, DataFinal)
        TotalDias = Ndias * 35

        'Calculo dos Kms e total a pagar
        KmInicial = Val(kinicio.Text)
        KmFinal = Val(kfim.Text)

        Kms = KmFinal - KmInicial
        TotalKms = Kms * 0.1

        'Calculo Total a Pagar
        ValorTotal = TotalDias + TotalKms

    End Sub
End Class
