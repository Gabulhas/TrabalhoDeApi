Public Class Exemplo_2

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        animações.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = "Nas rotundas, o condutor deve adotar o seguinte comportamento:" & vbCrLf & "a) Entrar na rotunda após ceder a passagem aos veículos que nela circulam, qualquer que seja a via por onde o façam;" & vbCrLf & "b) Se pretender sair da rotunda na primeira via de saída, deve ocupar a via da direita;" & vbCrLf & "c) Se pretender sair da rotunda por qualquer das outras vias de saída, só deve ocupar a via de trânsito mais à direita após passar a via de saída imediatamente anterior àquela por onde pretende sair, aproximando-se progressivamente desta e mudando de via depois de tomadas as devidas precauções;" & vbCrLf & "d) Sem prejuízo do disposto nas alíneas anteriores, os condutores devem utilizar a via de trânsito mais conveniente ao seu destino."
    End Sub
End Class