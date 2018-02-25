Imports System.Data.OleDb
Imports System.Data

Public Class flashcards
    Dim DbCon As New OleDb.OleDbConnection
    Dim dbUp As New OleDb.OleDbCommand
    Dim Read As OleDb.OleDbDataReader
    

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)

        ''toolTip1.SetToolTip(PictureBox2, "Save changes");
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        dbUp.Connection = DbCon
        DbCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kokas\OneDrive\Documentos\GitHub\TrabalhoDeApi\TrabalhoDeApi_VB\Quiz.mdb"
        DbCon.Open()
        dbUp.CommandType = CommandType.Text
        dbUp.CommandText = "SELECT pergunta,resposta1,resposta2,resposta3 FROM Perguntas WHERE rnd(ID)"
        Read = dbUp.ExecuteReader
        Dim frente As String = Read("frente").ToString
        Dim verso As String = Read("verso").ToString
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        dashboardForm.Show()

    End Sub
End Class