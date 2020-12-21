Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim field01 As Integer
        Dim field02 As Integer

        field01 = txtField01.Text
        field02 = txtField02.Text

        field01 = Prueba(field01)

    End Sub

    Private Function Prueba(field01 As Integer) As Integer
        Calcular3(field01)
        Console.WriteLine(field01)
        Calcular2(field01)
        Console.WriteLine(field01)
        Calcular1("5")
        Console.WriteLine(field01)
        txtField02.Text = field01
        Return field01
    End Function

    Private Sub Calcular1(ByVal parametro As Integer)
        parametro = parametro * 2
    End Sub
    Private Sub Calcular2(ByRef parametro As Integer)
        parametro = parametro * 2
    End Sub
    Private Sub Calcular3(parametro As Integer)
        parametro = parametro * 2
    End Sub
End Class
