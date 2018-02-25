Imports System.Data.OleDb
Imports System.Data

Public Class flashcards
    Dim DbCon As New OleDb.OleDbConnection
    Dim dbUp As New OleDb.OleDbCommand
    Dim Read As OleDb.OleDbDataReader
    Dim frente As String = Read("frente").ToString
    Dim verso As String = Read("verso").ToString

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles Ajuda.Popup

        toolTip1.SetToolTip(PictureBox2, "Save changes");
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        
        dbUp.Connection = DbCon
        DbCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kokas\OneDrive\Documentos\GitHub\TrabalhoDeApi\TrabalhoDeApi_VB\Quiz.mdb"
        DbCon.Open()
        dbUp.CommandType = CommandType.Text
        dbUp.CommandText = "SELECT pergunta,resposta1,resposta2,resposta3 FROM Perguntas WHERE rnd(ID)"
        Read = dbUp.ExecuteReader
    End Sub


    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Hide()
        dashboardForm.Show()

    End Sub
End Class