Public Class registerForm
    Dim DbCon As New OleDb.OleDbConnection
    Dim dbUp As New OleDb.OleDbCommand
    Dim Read As OleDb.OleDbDataReader


    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles registPasswordBox.TextChanged

    End Sub
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles registUserBox.TextChanged

    End Sub

    Private Sub registerForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub registButton_Click(sender As System.Object, e As System.EventArgs) Handles registButton.Click
        dbUp.Connection = DbCon
        DbCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Aluno.PC.006\Documents\GitHub\TrabalhoDeApi\TrabalhoDeApi_VB\Database.mdb"
        DbCon.Open()
        Dim username As String
        Dim password As String
        password = registPasswordBox.Text
        username = registUserBox.Text
        Try
            dbUp.CommandType = CommandType.Text
            dbUp.CommandText = "INSERT INTO LOGIN([Username], [Password])VALUES(@Username, @Password)"
            dbUp.Parameters.AddWithValue("@Username", username)
            dbUp.Parameters.AddWithValue("@Password", password)
            dbUp.ExecuteNonQuery()
            DbCon.Close()
            Me.Hide()
            loginForm.Show()
        Catch exception As System.Data.OleDb.OleDbException
            MessageBox.Show("Já existe uma conta com esse nome")

        End Try


    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class