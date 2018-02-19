Imports System.Data.OleDb
Imports System.Data


Public Class loginForm
    Dim DbCon As New OleDb.OleDbConnection
    Dim dbUp As New OleDb.OleDbCommand
    Dim Read As OleDb.OleDbDataReader
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles loginPasswordBox.TextChanged

    End Sub

    Private Sub openRegistButton_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)


    End Sub

    Private Sub loginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

        registerForm.Show()

    End Sub

    Private Sub Login_Click(sender As System.Object, e As System.EventArgs)
        
    End Sub

    Private Sub loginUserBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles loginUserBox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Login_Click_1(sender As System.Object, e As System.EventArgs) Handles Login.Click
        Dim diretorio As String = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "
        dbUp.Connection = DbCon
        DbCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Aluno.PC.006\Documents\GitHub\TrabalhoDeApi\TrabalhoDeApi_VB\Database.mdb"
        DbCon.Open()
        Dim username As String
        Dim password As String
        password = loginPasswordBox.Text
        username = loginUserBox.Text
        dbUp.CommandType = CommandType.Text
        dbUp.CommandText = "Select * from LOGIN where Username=" + username + " and Password=" + password
        dbUp.Parameters.Add("Username", Data.OleDb.OleDbType.Variant)
        dbUp.Parameters.Add("Password", Data.OleDb.OleDbType.Variant)
        dbUp.Parameters("Username").Value = loginUserBox.Text
        dbUp.Parameters("Password").Value = loginPasswordBox.Text
        Read = dbUp.ExecuteReader
        With Read
            If .Read Then
                Me.Hide()
                dashboardForm.Show()

            Else
                loginUserBox.Clear()
                loginPasswordBox.Clear()
                MessageBox.Show("Credenciais Erradas.")
            End If
        End With

    End Sub



    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        registerForm.Show()

    End Sub
End Class