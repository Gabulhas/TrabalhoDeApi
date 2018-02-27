Imports System.Data.OleDb
Imports System.Data

Public Class Quiz
    Dim DbCon As New OleDb.OleDbConnection
    Dim dbUp As New OleDb.OleDbCommand
    Dim Read As OleDb.OleDbDataReader
    
    Private Sub RichTextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles RichTextBox1.TextChanged
      
    End Sub

    Private Sub Quiz_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        dbUp.Connection = DbCon
        DbCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Asus\Documents\GitHub\TrabalhoDeApi\TrabalhoDeApi_VB\Quiz.mdb"
        DbCon.Open()
        dbUp.CommandType = CommandType.Text
        dbUp.CommandText = "SELECT pergunta,resposta1,resposta2,resposta3 FROM Perguntas ORDER BY RND(-Timer()*[ID]);"
        Read = dbUp.ExecuteReader
        While Read.Read()
            CheckBox1.Text = Read("resposta1").ToString
            CheckBox2.Text = Read("resposta2").ToString
            CheckBox3.Text = Read("resposta3").ToString
            RichTextBox1.Text = Read("pergunta").ToString
        End While
        DbCon.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Me.Hide()
        dashboardForm.Show()

    End Sub
End Class