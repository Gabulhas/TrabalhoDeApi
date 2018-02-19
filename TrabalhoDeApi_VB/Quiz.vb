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
        Dim diretorio As String = "C:\Users\Aluno.PC.006\Documents\GitHub\TrabalhoDeApi\TrabalhoDeApi_VB\Quiz.mdb"
        dbUp.CommandType = CommandType.Text
        dbUp.CommandText = "SELECT top 1 ID from perguntas ORDER BY rnd(ID)"
        CheckBox1.Text = Read("[resposta1]")
        CheckBox2.Text = Read("[resposta2]")
        CheckBox3.Text = Read("[resposta3]")
        RichTextBox1.Text = Read("[pergunta]")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class