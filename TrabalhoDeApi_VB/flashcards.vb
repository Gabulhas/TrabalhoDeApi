Imports System.Data.OleDb
Imports System.Data

Public Class flashcards
    Dim DbCon As New OleDb.OleDbConnection
    Dim dbUp As New OleDb.OleDbCommand
    Dim Read As OleDb.OleDbDataReader
    Dim toolTip1 As New ToolTip()

    Dim control As Control
    Dim caption As String

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        dbUp.Connection = DbCon
        DbCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kokas\OneDrive\Documentos\GitHub\TrabalhoDeApi\TrabalhoDeApi_VB\flashcards.mdb"
        DbCon.Open()
        dbUp.CommandType = CommandType.Text
        dbUp.CommandText = "SELECT pergunta,resposta1,resposta2,resposta3 FROM Perguntas WHERE rnd(ID)"
        Read = dbUp.ExecuteReader
        Dim frente As String = Read("frente").ToString
        Dim verso As String = Read("verso").ToString



    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        dashboardForm.Show()

    End Sub

    Private Sub Ajuda_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles Ajuda.Popup

        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 1000
        toolTip1.ReshowDelay = 500
        toolTip1.ShowAlways = True




    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        toolTip1.SetToolTip(Me.PictureBox2, "My button1")

    End Sub

    Private Sub flashcards_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class