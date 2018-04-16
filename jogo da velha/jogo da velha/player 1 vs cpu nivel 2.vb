Public Class frmplayer_1_vs_cpu_nivel_2
    Dim turn As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        turn = 1


    End Sub
    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Dim vresp As Integer

        vresp = MsgBox("Deseja sair do jogo", MsgBoxStyle.Question + vbYesNo)

        If vresp = vbYes Then
            Me.Close()

        End If
    End Sub
    Private Sub win()
        Dim ganhador As Boolean

        ganhador = False

        If btnb1.Tag = "x" And btnb2.Tag = "x" And btnb3.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            Label5.Text += 1
            Call MessageBoxButtons()
            ganhador = True



        ElseIf btnb1.Tag = "x" And btnb4.Tag = "x" And btnb7.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            Label5.Text += 1
            Call disablebuttons()
            ganhador = True

        ElseIf btnb1.Tag = "x" And btnb5.Tag = "x" And btnb9.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            Label5.Text += 1
            Call disablebuttons()
            ganhador = True

        ElseIf btnb3.Tag = "x" And btnb5.Tag = "x" And btnb7.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            Label5.Text += 1
            Call disablebuttons()
            ganhador = True

        ElseIf btnb3.Tag = "x" And btnb6.Tag = "x" And btnb9.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            Label5.Text += 1
            Call disablebuttons()
            ganhador = True

        ElseIf btnb2.Tag = "x" And btnb5.Tag = "x" And btnb8.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            Label5.Text += 1
            Call disablebuttons()
            ganhador = True

        ElseIf btnb4.Tag = "x" And btnb5.Tag = "x" And btnb6.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            Label5.Text += 1
            Call disablebuttons()
            ganhador = True

        ElseIf btnb7.Tag = "x" And btnb8.Tag = "x" And btnb9.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            Label7.Text += 1
            Call disablebuttons()
            ganhador = True

        End If


        If btnb1.Tag = "o" And btnb2.Tag = "o" And btnb3.Tag = "o" Then
            frmganhou.Label1.Text = "Jogador 2 venceu"
            frmganhou.ShowDialog()
            Label5.Text += 1
            Call disablebuttons()
            ganhador = True



        ElseIf btnb1.Tag = "o" And btnb4.Tag = "o" And btnb7.Tag = "o" Then
            frmganhou.Label1.Text = "Jogador 2 venceu"
            frmganhou.ShowDialog()
            Label7.Text += 1
            Call disablebuttons()
            ganhador = True

        ElseIf btnb1.Tag = "o" And btnb5.Tag = "o" And btnb9.Tag = "o" Then
            frmganhou.Label1.Text = "Jogador 2 venceu"
            frmganhou.ShowDialog()
            Label7.Text += 1
            Call disablebuttons()
            ganhador = True

        ElseIf btnb3.Tag = "o" And btnb5.Tag = "o" And btnb7.Tag = "o" Then
            frmganhou.Label1.Text = "Jogador 2 venceu"
            frmganhou.ShowDialog()
            Label7.Text += 1
            Call disablebuttons()
            ganhador = True

        ElseIf btnb3.Tag = "o" And btnb6.Tag = "o" And btnb9.Tag = "o" Then
            frmganhou.Label1.Text = "Jogador 2 venceu"
            frmganhou.ShowDialog()
            Label7.Text += 1
            Call disablebuttons()
            ganhador = True

        ElseIf btnb2.Tag = "o" And btnb5.Tag = "o" And btnb8.Tag = "o" Then
            frmganhou.Label1.Text = "Jogador 2 venceu"
            frmganhou.ShowDialog()
            Label7.Text += 1
            Call disablebuttons()
            ganhador = True

        ElseIf btnb4.Tag = "o" And btnb5.Tag = "o" And btnb6.Tag = "o" Then
            frmganhou.Label1.Text = "Jogador 2 venceu"
            frmganhou.ShowDialog()
            Label7.Text += 1
            Call disablebuttons()
            ganhador = True

        ElseIf btnb7.Tag = "o" And btnb8.Tag = "o" And btnb9.Tag = "o" Then
            frmganhou.Label1.Text = "Jogador 2 venceu"
            frmganhou.ShowDialog()
            Label7.Text += 1
            Call disablebuttons()
            ganhador = True
        End If

        If btnb1.Tag <> "" And btnb2.Tag <> "" And btnb3.Tag <> "" And btnb4.Tag <> "" And btnb5.Tag <> "" And btnb6.Tag <> "" And btnb7.Tag <> "" And btnb8.Tag <> "" And btnb9.Tag <> "" Then
            If ganhador = False Then

                velha.Show()

            End If
        End If

    End Sub
    Private Sub enabled()

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

    Private Sub MessageBoxButtons()
        Throw New NotImplementedException
    End Sub

    Private Sub disablebuttons()
        Throw New NotImplementedException
    End Sub


    Private Sub btnb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb1.Click


        If turn = 1 Then
            btnb1.BackgroundImage = jogo_da_velha.My.Resources.Resources.x1
            btnb1.Tag = "x"


        Else
            btnb1.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
            btnb1.Tag = "o"


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
            btnb2.BackgroundImage = jogo_da_velha.My.Resources.Resources.x1
            btnb2.Tag = "x"


        Else
            btnb2.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
            btnb2.Tag = "o"


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
            btnb3.BackgroundImage = jogo_da_velha.My.Resources.Resources.x1
            btnb3.Tag = "x"


        Else
            btnb3.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
            btnb3.Tag = "o"


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
            btnb4.BackgroundImage = jogo_da_velha.My.Resources.Resources.x1
            btnb4.Tag = "x"


        Else
            btnb4.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
            btnb4.Tag = "o"


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
            btnb5.BackgroundImage = jogo_da_velha.My.Resources.Resources.x1
            btnb5.Tag = "x"


        Else
            btnb5.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
            btnb5.Tag = "o"


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
            btnb6.BackgroundImage = jogo_da_velha.My.Resources.Resources.x1
            btnb6.Tag = "x"


        Else
            btnb6.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
            btnb6.Tag = "o"


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
            btnb7.BackgroundImage = jogo_da_velha.My.Resources.Resources.x1
            btnb7.Tag = "x"


        Else
            btnb7.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
            btnb7.Tag = "o"


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
            btnb8.BackgroundImage = jogo_da_velha.My.Resources.Resources.x1
            btnb8.Tag = "x"


        Else
            btnb8.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
            btnb8.Tag = "o"


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
            btnb9.BackgroundImage = jogo_da_velha.My.Resources.Resources.x1
            btnb9.Tag = "x"


        Else
            btnb9.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
            btnb9.Tag = "o"


        End If
        turn += 1

        If turn > 2 Then
            turn = 1

        End If
        Call win()
        btnb9.Enabled = False

    End Sub


    Private Sub pc()
        Dim value As Integer

        value = Int((6 * Rnd()) + 1)

        If btnb1.Tag = "X" Then
            value = btnb2.Tag = "O"

        End If

    End Sub


    Private Sub btnReiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReiniciar.Click
        Dim resp As Integer
        btnb1.BackgroundImage = Nothing
        btnb1.Tag = ""
        btnb1.Enabled = True
        btnb2.BackgroundImage = Nothing
        btnb2.Tag = ""
        btnb2.Enabled = True
        btnb3.BackgroundImage = Nothing
        btnb3.Tag = ""
        btnb3.Enabled = True
        btnb4.BackgroundImage = Nothing
        btnb4.Tag = ""
        btnb4.Enabled = True
        btnb5.BackgroundImage = Nothing
        btnb5.Tag = ""
        btnb5.Enabled = True
        btnb6.BackgroundImage = Nothing
        btnb6.Tag = ""
        btnb6.Enabled = True
        btnb7.BackgroundImage = Nothing
        btnb7.Tag = ""
        btnb7.Enabled = True
        btnb8.BackgroundImage = Nothing
        btnb8.Tag = ""
        btnb8.Enabled = True
        btnb9.BackgroundImage = Nothing
        btnb9.Tag = ""
        btnb9.Enabled = True

        resp = MsgBox("Deseja continuar e jogar com os mesmos personagens?", vbQuestion + vbYesNo)
        If resp = vbNo Then
            Me.Close()

        End If



    End Sub

End Class