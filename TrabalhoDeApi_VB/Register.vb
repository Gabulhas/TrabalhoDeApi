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
End Class