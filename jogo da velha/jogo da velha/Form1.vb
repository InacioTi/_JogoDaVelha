Public Class frmjogodavelha
    Dim turn, i As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        turn = 1

    End Sub
    Private Sub win()
        If btnb1.Text = "x" And btnb2.Text = "x" And btnb3.Text = "x" Then
            MsgBox("Jogador 1 venceu")
            Label5.Text += 1
            Call disablebuttons()




        ElseIf btnb1.Text = "x" And btnb4.Text = "x" And btnb7.Text = "x" Then
            MsgBox("Jogador 1 venceu")
            Label5.Text += 1
            Call disablebuttons()

        ElseIf btnb1.Text = "x" And btnb5.Text = "x" And btnb9.Text = "x" Then
            MsgBox("Jogador 1 venceu")
            Label5.Text += 1
            Call disablebuttons()

        ElseIf btnb3.Text = "x" And btnb5.Text = "x" And btnb7.Text = "x" Then
            MsgBox("Jogador 1 venceu")
            Label5.Text += 1
            Call disablebuttons()

        ElseIf btnb3.Text = "x" And btnb6.Text = "x" And btnb9.Text = "x" Then
            MsgBox("Jogador 1 venceu")
            Label5.Text += 1
            Call disablebuttons()

        ElseIf btnb2.Text = "x" And btnb5.Text = "x" And btnb8.Text = "x" Then
            MsgBox("Jogador 1 venceu")
            Label5.Text += 1
            Call disablebuttons()

        ElseIf btnb4.Text = "x" And btnb5.Text = "x" And btnb6.Text = "x" Then
            MsgBox("Jogador 1 venceu")
            Label5.Text += 1
            Call disablebuttons()



        ElseIf btnb1.Text = "o" And btnb2.Text = "o" And btnb3.Text = "o" Then
            MsgBox("Jogador 1 venceu")
            Label5.Text += 1
            Call disablebuttons()




        ElseIf btnb1.Text = "o" And btnb4.Text = "o" And btnb7.Text = "o" Then
            MsgBox("Jogador 1 venceu")
            Label7.Text += 1
            Call disablebuttons()

        ElseIf btnb1.Text = "o" And btnb5.Text = "o" And btnb9.Text = "o" Then
            MsgBox("Jogador 1 venceu")
            Label7.Text += 1
            Call disablebuttons()

        ElseIf btnb3.Text = "o" And btnb5.Text = "o" And btnb7.Text = "o" Then
            MsgBox("Jogador 1 venceu")
            Label7.Text += 1
            Call disablebuttons()

        ElseIf btnb3.Text = "o" And btnb6.Text = "o" And btnb9.Text = "o" Then
            MsgBox("Jogador 1 venceu")
            Label7.Text += 1
            Call disablebuttons()

        ElseIf btnb2.Text = "o" And btnb5.Text = "o" And btnb8.Text = "o" Then
            MsgBox("Jogador 1 venceu")
            Label7.Text += 1
            Call disablebuttons()

        ElseIf btnb4.Text = "o" And btnb5.Text = "o" And btnb6.Text = "o" Then
            MsgBox("Jogador 1 venceu")
            Label7.Text += 1
            Call disablebuttons()
        End If







    End Sub
    Private Sub disablebuttons()
        btnb1.Enabled = False
        btnb2.Enabled = False
        btnb3.Enabled = False
        btnb4.Enabled = False
        btnb5.Enabled = False
        btnb6.Enabled = False
        btnb7.Enabled = False
        btnb8.Enabled = False
        btnb9.Enabled = False

    End Sub
    Private Sub btnb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb1.Click
        If turn = 1 Then
            btnb1.Text = "x"
            Label2.Text = "o"

        Else
            btnb1.Text = "o"
            Label2.Text = "X"

        End If
        turn += 1

        If turn > 2 Then
            turn = 1

        End If
        Call win()
        btnb1.Enabled = False


    End Sub

    Private Sub btnb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb2.Click
        If turn = 1 Then
            btnb2.Text = "x"
            Label2.Text = "o"

        Else
            btnb2.Text = "o"
            Label2.Text = "X"

        End If
        turn += 1

        If turn > 2 Then
            turn = 1

        End If
        Call win()
        btnb2.Enabled = False

    End Sub

    Private Sub btnb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb3.Click
        If turn = 1 Then
            btnb3.Text = "x"
            Label2.Text = "o"

        Else
            btnb3.Text = "o"
            Label2.Text = "X"

        End If
        turn += 1

        If turn > 2 Then
            turn = 1

        End If
        Call win()
        btnb3.Enabled = False

    End Sub

    Private Sub btnb4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb4.Click
        If turn = 1 Then
            btnb4.Text = "x"
            Label2.Text = "o"

        Else
            btnb4.Text = "o"
            Label2.Text = "X"

        End If
        turn += 1

        If turn > 2 Then
            turn = 1

        End If
        Call win()
        btnb4.Enabled = False

    End Sub

    Private Sub btnb5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb5.Click
        If turn = 1 Then
            btnb5.Text = "x"
            Label2.Text = "o"

        Else
            btnb5.Text = "o"
            Label2.Text = "X"

        End If
        turn += 1

        If turn > 2 Then
            turn = 1

        End If
        Call win()
        btnb5.Enabled = False

    End Sub

    Private Sub btnb6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb6.Click
        If turn = 1 Then
            btnb6.Text = "x"
            Label2.Text = "o"

        Else
            btnb6.Text = "o"
            Label2.Text = "X"

        End If
        turn += 1

        If turn > 2 Then
            turn = 1

        End If
        Call win()
        btnb6.Enabled = False

    End Sub

    Private Sub btnb7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb7.Click
        If turn = 1 Then
            btnb7.Text = "x"
            Label2.Text = "o"

        Else
            btnb7.Text = "o"
            Label2.Text = "X"

        End If
        turn += 1

        If turn > 2 Then
            turn = 1

        End If
        Call win()
        btnb7.Enabled = False

    End Sub

    Private Sub btnb8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb8.Click
        If turn = 1 Then
            btnb8.Text = "x"
            Label2.Text = "o"

        Else
            btnb8.Text = "o"
            Label2.Text = "X"

        End If
        turn += 1

        If turn > 2 Then
            turn = 1

        End If
        Call win()
        btnb8.Enabled = False

    End Sub

    Private Sub btnb9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb9.Click
        If turn = 1 Then
            btnb9.Text = "x"
            Label2.Text = "o"

        Else
            btnb9.Text = "o"
            Label2.Text = "X"

        End If
        turn += 1

        If turn > 2 Then
            turn = 1

        End If
        Call win()
        btnb9.Enabled = False

    End Sub

    Private Sub btnReiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReiniciar.Click
        btnb1.Text = ""
        btnb1.Enabled = True
        btnb2.Text = ""
        btnb2.Enabled = True
        btnb3.Text = ""
        btnb3.Enabled = True
        btnb4.Text = ""
        btnb4.Enabled = True
        btnb5.Text = ""
        btnb5.Enabled = True
        btnb6.Text = ""
        btnb6.Enabled = True
        btnb7.Text = ""
        btnb7.Enabled = True
        btnb8.Text = ""
        btnb8.Enabled = True
        btnb9.Text = ""
        btnb9.Enabled = True
    End Sub

    Private Sub btnb1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnb1.KeyDown
        If btnb1.Enabled = False And btnb2.Enabled = False And btnb3.Enabled = False And btnb4.Enabled = False And btnb5.Enabled = False And btnb6.Enabled = False And btnb7.Enabled = False And btnb8.Enabled = False And btnb9.Enabled = False Then
            MsgBox("VELHA")
        End If
    End Sub



    Private Sub Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sair.Click


        Dim vresp As Integer
        vresp = MsgBox("Deseja encerrar o jogo ?", MsgBoxStyle.YesNo + vbQuestion)
        If vresp = vbYes Then
            End

        End If
    End Sub
End Class
