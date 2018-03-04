Imports System.IO

Public Class AdiconarFlashcards
    Dim DbCon As New OleDb.OleDbConnection
    Dim dbUp As New OleDb.OleDbCommand
    Dim Read As OleDb.OleDbDataReader
    Dim diretorio As String = Directory.GetCurrentDirectory()
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        dbUp.Connection = DbCon
        DbCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Asus\Documents\GitHub\TrabalhoDeApi\TrabalhoDeApi_VB\Flashcards.mdb"
        DbCon.Open()
        Dim frente As String
        Dim verso As String
        frente = RichTextBox1.Text
        verso = RichTextBox1.Text
        dbUp.CommandType = CommandType.Text
        dbUp.CommandText = "INSERT INTO Flashcards([frente], [verso])VALUES(@frente, @verso)"
        dbUp.Parameters.AddWithValue("@frente", frente)
        dbUp.Parameters.AddWithValue("@verso", verso)
        dbUp.ExecuteNonQuery()
        DbCon.Close()
        Me.Hide()
    End Sub
End Class