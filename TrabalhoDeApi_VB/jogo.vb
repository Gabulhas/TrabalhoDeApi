Public Class Form1
    Dim road(9) As PictureBox
    Dim s As Integer
    Dim Start As Integer = 5
    Dim vidas As Integer
    Dim Move As Boolean = False
    Dim Carros(2) As PictureBox
    Dim vida(3) As PictureBox
    Dim TimerStartE As Boolean
    Dim GameOver As Boolean = False

    Private Sub TimerMoveRight_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMoveRight.Tick
        If Not PictureBox1.Bounds.IntersectsWith(PictureBox12.Bounds) Then
            PictureBox1.Left += 5
        End If

    End Sub

    Private Sub TimerMoveLeft_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMoveLeft.Tick
        If PictureBox1.Left > 0 Then
            PictureBox1.Left -= 5
        End If

    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right And Move = True Then
            TimerMoveRight.Start()
        End If
        If e.KeyCode = Keys.Left And Move = True Then
            TimerMoveLeft.Start()
        End If
    End Sub

    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
       
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For x = 0 To 9
            road(x).Top += 4

            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        road(0) = PictureBox2
        road(1) = PictureBox3
        road(2) = PictureBox4
        road(3) = PictureBox5
        road(4) = PictureBox6
        road(5) = PictureBox7
        road(6) = PictureBox8
        road(7) = PictureBox9
        road(8) = PictureBox10
        road(9) = PictureBox11

        Carros(0) = PictureBox16
        Carros(1) = PictureBox17
        Carros(2) = PictureBox18

        vida(1) = PictureBox13
        vida(2) = PictureBox14
        vida(3) = PictureBox15

        For y = 0 To 2
            Carros(y).Top = -Int(Rnd() * 500)
        Next
        GameOver = False
    End Sub

    Private Sub Timer_Time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Time.Tick
        s += 1

        Label1.Text = s
    End Sub

    Private Sub Timer_Start_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Start.Tick

        If Start > 0 Then
            Start -= 1
        End If
        Label2.Text = Start
        If Start = 0 Then
            Timer_Time.Start()
            Timer1.Start()
            Timer_Cars.Start()
            Label2.Visible = False
            Move = True
            Timer_Start.Stop()
            TimerStartE = True
        End If
        TimerStartE = True
    End Sub

    Private Sub Timer_Cars_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Cars.Tick
        For y = 0 To 2
            Carros(y).Top += 15

            If Carros(y).Top > Me.Height Then
                Carros(y).Top = -Int(Rnd() * 500)
            End If
            If PictureBox1.Bounds.IntersectsWith(Carros(y).Bounds) Then
                vidas += 1
                Carros(y).Top = -Int(Rnd() * 500)
                vida(vidas - 1).Hide()
                If vidas = 3 Then
                    Timer_Cars.Stop()
                    Timer_Time.Stop()
                    TimerMoveLeft.Stop()
                    TimerMoveRight.Stop()
                    Timer1.Stop()
                    Move = False
                    Label3.Text += Val(s)
                    s = 0
                    vidas = 0
                    MsgBox("Game over")
                    GameOver = True

                End If
            End If
            If vidas = 3 Then
                Timer_Cars.Stop()
                Timer_Time.Stop()
                TimerMoveLeft.Stop()
                TimerMoveRight.Stop()
                Timer1.Stop()
                Move = False
                Label3.Text += Val(s)
                Label1.Text = "0"

                MsgBox(s)
                s = 0
                vidas = 0
                GameOver = True

            End If
        Next

    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        For y = 0 To 3
            Carros(y).Top = -Int(Rnd())
        Next
        vida(1).Show()
        vida(2).Show()
        vida(3).Show()

        TimerStartE = True
        Timer_Start.Start()
        Label2.Text = 5
        PictureBox1.Left = 253
        PictureBox1.Top = 374
        Start = 5
        Timer_Time.Stop()
        Timer1.Stop()
        Timer_Cars.Stop()
        Label2.Visible = True
        Move = False
        TimerStartE = False
        GameOver = False
    End Sub
    

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GameOver = False Then
            If TimerStartE = False Then
                TimerStartE = True
                Label2.Visible = True
                Start = 3
                Label2.Text = 3
                Timer_Start.Start()
                TimerStartE = True

            End If
        End If


    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click

    End Sub

    Private Sub PictureBox12_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox12.Click

    End Sub
End Class

