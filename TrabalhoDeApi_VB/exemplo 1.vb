Public Class exemplo_1

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        animações.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox1.Text = "Se ambos os carros tiverem a intenção de virar para cima, o carro B tem prioridade sob o carro A"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox1.Text = "Se ambos os carros tiverem a intenção de virar para baixo, o carro A tem prioridade sob o carro B"
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As System.Object, e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub
End Class