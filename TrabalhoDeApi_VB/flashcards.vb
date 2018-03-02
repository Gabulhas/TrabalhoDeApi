Imports System.Data.OleDb
Imports System.Data
Imports System.IO

Public Class flashcards
    Dim diretorio As String = Directory.GetCurrentDirectory()
    Dim DbCon As New OleDb.OleDbConnection
    Dim dbUp As New OleDb.OleDbCommand
    Dim Read As OleDb.OleDbDataReader
    Dim toolTip1 As New ToolTip()
    Dim frente As String
    Dim verso As String
    Dim control As Control
    Dim caption As String

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = verso
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        dbUp.Connection = DbCon
        DbCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + diretorio + "\Flashcards.mdb"
        DbCon.Open()
        dbUp.CommandType = CommandType.Text
        dbUp.CommandText = "SELECT TOP 1 frente,verso FROM(flashcards) ORDER BY RND(-Timer()*[ID]);"
        Read = dbUp.ExecuteReader
        TextBox1.Text = ""
        While Read.Read()
            frente = Read("frente").ToString()
            verso = Read("verso").ToString
            TextBox1.Text = frente
        End While

        DbCon.Close()
    End Sub
End Class