Imports System.IO

Public Class Form3
    Dim DbCon As New OleDb.OleDbConnection
    Dim dbUp As New OleDb.OleDbCommand
    Dim Read As OleDb.OleDbDataReader
    Dim diretorio As String = Directory.GetCurrentDirectory()
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        dbUp.Connection = DbCon
        DbCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Asus\Documents\GitHub\TrabalhoDeApi\TrabalhoDeApi_VB\Quiz.mdb"
        DbCon.Open()
        Dim pergunta As String
        Dim resposta1 As String
        Dim resposta2 As String
        Dim resposta3 As String
        Dim respostaCerta As String
        pergunta = RichTextBox1.Text
        resposta1 = RichTextBox2.Text
        resposta2 = RichTextBox3.Text
        resposta3 = RichTextBox4.Text
        respostaCerta = RichTextBox5.Text
        dbUp.CommandType = CommandType.Text
        dbUp.CommandText = "INSERT INTO Flashcards([pergunta],[resposta1],[resposta2],[resposta3],[respostaCerta])VALUES(@pergunta,@resposta1,@resposta2,@resposta3,@respostaCerta)"
        dbUp.Parameters.AddWithValue("@pergunta", pergunta)
        dbUp.Parameters.AddWithValue("@resposta1", resposta1)
        dbUp.Parameters.AddWithValue("@resposta2", resposta2)
        dbUp.Parameters.AddWithValue("@resposta3", resposta3)
        dbUp.Parameters.AddWithValue("@respostaCerta", respostaCerta)
        dbUp.ExecuteNonQuery()
        DbCon.Close()

    End Sub
End Class