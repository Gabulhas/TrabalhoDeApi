﻿Imports System
Imports System.IO
Imports System.Data.OleDb
Imports System.Data

Public Class Quiz
    Dim diretorio As String = Application.StartupPath
    Dim RespostaCerta, respostaEscolhida, vResposta1, vResposta2, vResposta3 As String
    Dim DbCon As New OleDb.OleDbConnection
    Dim dbUp As New OleDb.OleDbCommand
    Dim Read As OleDb.OleDbDataReader
    Private Sub RichTextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Quiz_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        dbUp.Connection = DbCon
        DbCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + diretorio + "\Quiz.mdb"
        DbCon.Open()
        dbUp.CommandType = CommandType.Text
        dbUp.CommandText = "SELECT pergunta,resposta1,resposta2,resposta3,respostaCerta FROM Perguntas ORDER BY RND(-Timer()*[ID]);"
        Read = dbUp.ExecuteReader
        While Read.Read()
            RadioButton1.Text = Read("resposta1").ToString
            RadioButton2.Text = Read("resposta2").ToString
            RadioButton3.Text = Read("resposta3").ToString
            RichTextBox1.Text = Read("pergunta").ToString
            vResposta1 = Read("resposta1").ToString
            vResposta2 = Read("resposta2").ToString
            vResposta3 = Read("resposta3").ToString
            RespostaCerta = Read("respostaCerta").ToString
        End While
        DbCon.Close()

        

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Me.Hide()
        dashboardForm.Show()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = diretorio
        If RadioButton1.Checked Then respostaEscolhida = RadioButton1.Text

        If RadioButton2.Checked Then respostaEscolhida = RadioButton2.Text

        If RadioButton3.Checked Then respostaEscolhida = RadioButton3.Text

        If respostaEscolhida = RespostaCerta Then
            MessageBox.Show("batata")
        ElseIf respostaEscolhida <> RespostaCerta Then
            MessageBox.Show("Erro")
        End If

    End Sub
End Class