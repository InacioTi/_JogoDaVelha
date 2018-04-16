Module Module1

    Public turn As Integer
    Public i As Integer

    Public Sub jogada(ByVal botao As Button)

        If turn = 1 Then
            botao.BackgroundImage = jogo_da_velha.My.Resources.Resources.x1
            botao.Tag = "x"
            frmMultiplayer.pcbvez.Image = My.Resources.bolinha

        Else
            botao.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
            botao.Tag = "o"
            frmMultiplayer.pcbvez.Image = My.Resources.x1

        End If
        turn += 1

        If turn > 2 Then
            turn = 1

        End If
        Call win()
        botao.Enabled = False


    End Sub
    Public Sub jogada2(ByVal botao As Button)

        If turn = 1 Then
            botao.BackgroundImage = jogo_da_velha.My.Resources.Resources.x1
            botao.Tag = "x"
            frmCpu1.pcbvez.Image = My.Resources.bolinha

        Else
            i = New System.Random().Next(1, 9)


        End If
        turn += 1

        If turn > 2 Then
            turn = 1

        End If
        Call win2()
        botao.Enabled = False


    End Sub

    Public Sub win()
        Dim ganhador As Boolean

        ganhador = False

        If frmMultiplayer.btnb1.Tag = "x" And frmMultiplayer.btnb2.Tag = "x" And frmMultiplayer.btnb3.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            frmMultiplayer.Label5.Text += 1
            Call frmMultiplayer.disablebuttons()
            ganhador = True



        ElseIf frmMultiplayer.btnb1.Tag = "x" And frmMultiplayer.btnb4.Tag = "x" And frmMultiplayer.btnb7.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            frmMultiplayer.Label5.Text += 1
            Call frmMultiplayer.disablebuttons()
            ganhador = True

        ElseIf frmMultiplayer.btnb1.Tag = "x" And frmMultiplayer.btnb5.Tag = "x" And frmMultiplayer.btnb9.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            frmMultiplayer.Label5.Text += 1
            Call frmMultiplayer.disablebuttons()
            ganhador = True

        ElseIf frmMultiplayer.btnb3.Tag = "x" And frmMultiplayer.btnb5.Tag = "x" And frmMultiplayer.btnb7.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            frmMultiplayer.Label5.Text += 1
            Call frmMultiplayer.disablebuttons()
            ganhador = True

        ElseIf frmMultiplayer.btnb3.Tag = "x" And frmMultiplayer.btnb6.Tag = "x" And frmMultiplayer.btnb9.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            frmMultiplayer.Label5.Text += 1
            Call frmMultiplayer.disablebuttons()
            ganhador = True

        ElseIf frmMultiplayer.btnb2.Tag = "x" And frmMultiplayer.btnb5.Tag = "x" And frmMultiplayer.btnb8.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            frmMultiplayer.Label5.Text += 1
            Call frmMultiplayer.disablebuttons()
            ganhador = True

        ElseIf frmMultiplayer.btnb4.Tag = "x" And frmMultiplayer.btnb5.Tag = "x" And frmMultiplayer.btnb6.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            frmMultiplayer.Label5.Text += 1
            Call frmMultiplayer.disablebuttons()
            ganhador = True

        ElseIf frmMultiplayer.btnb7.Tag = "x" And frmMultiplayer.btnb8.Tag = "x" And frmMultiplayer.btnb9.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            frmMultiplayer.Label7.Text += 1
            Call frmMultiplayer.disablebuttons()
            ganhador = True

        End If


        If frmMultiplayer.btnb1.Tag = "o" And frmMultiplayer.btnb2.Tag = "o" And frmMultiplayer.btnb3.Tag = "o" Then
            frmganhou.Label1.Text = "Jogador 2 venceu"
            frmganhou.ShowDialog()
            frmMultiplayer.Label5.Text += 1
            Call frmMultiplayer.disablebuttons()
            ganhador = True



        ElseIf frmMultiplayer.btnb1.Tag = "o" And frmMultiplayer.btnb4.Tag = "o" And frmMultiplayer.btnb7.Tag = "o" Then
            frmganhou.Label1.Text = "Jogador 2 venceu"
            frmganhou.ShowDialog()
            frmMultiplayer.Label7.Text += 1
            Call frmMultiplayer.disablebuttons()
            ganhador = True

        ElseIf frmMultiplayer.btnb1.Tag = "o" And frmMultiplayer.btnb5.Tag = "o" And frmMultiplayer.btnb9.Tag = "o" Then
            frmganhou.Label1.Text = "Jogador 2 venceu"
            frmganhou.ShowDialog()
            frmMultiplayer.Label7.Text += 1
            Call frmMultiplayer.disablebuttons()
            ganhador = True

        ElseIf frmMultiplayer.btnb3.Tag = "o" And frmMultiplayer.btnb5.Tag = "o" And frmMultiplayer.btnb7.Tag = "o" Then
            frmganhou.Label1.Text = "Jogador 2 venceu"
            frmganhou.ShowDialog()
            frmMultiplayer.Label7.Text += 1
            Call frmMultiplayer.disablebuttons()
            ganhador = True

        ElseIf frmMultiplayer.btnb3.Tag = "o" And frmMultiplayer.btnb6.Tag = "o" And frmMultiplayer.btnb9.Tag = "o" Then
            frmganhou.Label1.Text = "Jogador 2 venceu"
            frmganhou.ShowDialog()
            frmMultiplayer.Label7.Text += 1
            Call frmMultiplayer.disablebuttons()
            ganhador = True

        ElseIf frmMultiplayer.btnb2.Tag = "o" And frmMultiplayer.btnb5.Tag = "o" And frmMultiplayer.btnb8.Tag = "o" Then
            frmganhou.Label1.Text = "Jogador 2 venceu"
            frmganhou.ShowDialog()
            frmMultiplayer.Label7.Text += 1
            Call frmMultiplayer.disablebuttons()
            ganhador = True

        ElseIf frmMultiplayer.btnb4.Tag = "o" And frmMultiplayer.btnb5.Tag = "o" And frmMultiplayer.btnb6.Tag = "o" Then
            frmganhou.Label1.Text = "Jogador 2 venceu"
            frmganhou.ShowDialog()
            frmMultiplayer.Label7.Text += 1
            Call frmMultiplayer.disablebuttons()
            ganhador = True

        ElseIf frmMultiplayer.btnb7.Tag = "o" And frmMultiplayer.btnb8.Tag = "o" And frmMultiplayer.btnb9.Tag = "o" Then
            frmganhou.Label1.Text = "Jogador 2 venceu"
            frmganhou.ShowDialog()
            frmMultiplayer.Label7.Text += 1
            Call frmMultiplayer.disablebuttons()
            ganhador = True
        End If

        If frmMultiplayer.btnb1.Tag <> "" And frmMultiplayer.btnb2.Tag <> "" And frmMultiplayer.btnb3.Tag <> "" And frmMultiplayer.btnb4.Tag <> "" And frmMultiplayer.btnb5.Tag <> "" And frmMultiplayer.btnb6.Tag <> "" And frmMultiplayer.btnb7.Tag <> "" And frmMultiplayer.btnb8.Tag <> "" And frmMultiplayer.btnb9.Tag <> "" Then
            If ganhador = False Then

                frmvelha.Show()

            End If
        End If

        frmMultiplayer.pgb1.Minimum = 0
        frmMultiplayer.pgb2.Minimum = 0
        frmMultiplayer.pgb1.Maximum = 100
        frmMultiplayer.pgb2.Maximum = 100

        If frmMultiplayer.Label5.Text = "1" Then
            frmMultiplayer.pgb2.Value = 66
        ElseIf frmMultiplayer.Label5.Text = "2" Then
            frmMultiplayer.pgb2.Value = 33
        ElseIf frmMultiplayer.Label5.Text = "3" Then
            frmMultiplayer.pgb2.Value = 0
        End If

        If frmMultiplayer.Label7.Text = "1" Then
            frmMultiplayer.pgb1.Value = 66
        ElseIf frmMultiplayer.Label7.Text = "2" Then
            frmMultiplayer.pgb1.Value = 33
        ElseIf frmMultiplayer.Label7.Text = "3" Then
            frmMultiplayer.pgb1.Value = 0
        End If

    End Sub
    Public Sub win2()
        Dim ganhador As Boolean

        ganhador = False

        If frmCpu1.btnb11.Tag = "x" And frmCpu1.btnb12.Tag = "x" And frmCpu1.btnb13.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            frmCpu1.Label5.Text += 1
            Call frmCpu1.disablebuttons()
            ganhador = True



        ElseIf frmCpu1.btnb11.Tag = "x" And frmCpu1.btnb14.Tag = "x" And frmCpu1.btnb17.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            frmCpu1.Label5.Text += 1
            Call frmCpu1.disablebuttons()
            ganhador = True

        ElseIf frmCpu1.btnb11.Tag = "x" And frmCpu1.btnb15.Tag = "x" And frmCpu1.btnb19.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            frmCpu1.Label5.Text += 1
            Call frmCpu1.disablebuttons()
            ganhador = True

        ElseIf frmCpu1.btnb13.Tag = "x" And frmCpu1.btnb15.Tag = "x" And frmCpu1.btnb17.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            frmCpu1.Label5.Text += 1
            Call frmCpu1.disablebuttons()
            ganhador = True

        ElseIf frmCpu1.btnb13.Tag = "x" And frmCpu1.btnb16.Tag = "x" And frmCpu1.btnb19.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            frmCpu1.Label5.Text += 1
            Call frmCpu1.disablebuttons()
            ganhador = True

        ElseIf frmCpu1.btnb12.Tag = "x" And frmCpu1.btnb15.Tag = "x" And frmCpu1.btnb18.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            frmCpu1.Label5.Text += 1
            Call frmCpu1.disablebuttons()
            ganhador = True

        ElseIf frmCpu1.btnb14.Tag = "x" And frmCpu1.btnb15.Tag = "x" And frmCpu1.btnb16.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            frmCpu1.Label5.Text += 1
            Call frmCpu1.disablebuttons()
            ganhador = True

        ElseIf frmCpu1.btnb17.Tag = "x" And frmCpu1.btnb18.Tag = "x" And frmCpu1.btnb19.Tag = "x" Then
            frmganhou.Label1.Text = "Jogador 1 venceu"
            frmganhou.ShowDialog()
            frmCpu1.Label7.Text += 1
            Call frmCpu1.disablebuttons()
            ganhador = True

        End If


        If frmCpu1.btnb11.Tag = "o" And frmCpu1.btnb12.Tag = "o" And frmCpu1.btnb13.Tag = "o" Then
            frmganhou.Label1.Text = "CPU venceu"
            frmganhou.ShowDialog()
            frmCpu1.Label5.Text += 1
            Call frmCpu1.disablebuttons()
            ganhador = True



        ElseIf frmCpu1.btnb11.Tag = "o" And frmCpu1.btnb14.Tag = "o" And frmCpu1.btnb17.Tag = "o" Then
            frmganhou.Label1.Text = "CPU venceu"
            frmganhou.ShowDialog()
            frmCpu1.Label7.Text += 1
            Call frmCpu1.disablebuttons()
            ganhador = True

        ElseIf frmCpu1.btnb11.Tag = "o" And frmCpu1.btnb15.Tag = "o" And frmCpu1.btnb19.Tag = "o" Then
            frmganhou.Label1.Text = "CPU venceu"
            frmganhou.ShowDialog()
            frmCpu1.Label7.Text += 1
            Call frmCpu1.disablebuttons()
            ganhador = True

        ElseIf frmCpu1.btnb13.Tag = "o" And frmCpu1.btnb15.Tag = "o" And frmCpu1.btnb17.Tag = "o" Then
            frmganhou.Label1.Text = "CPU venceu"
            frmganhou.ShowDialog()
            frmCpu1.Label7.Text += 1
            Call frmCpu1.disablebuttons()
            ganhador = True

        ElseIf frmCpu1.btnb13.Tag = "o" And frmCpu1.btnb16.Tag = "o" And frmCpu1.btnb19.Tag = "o" Then
            frmganhou.Label1.Text = "CPU venceu"
            frmganhou.ShowDialog()
            frmCpu1.Label7.Text += 1
            Call frmCpu1.disablebuttons()
            ganhador = True

        ElseIf frmCpu1.btnb12.Tag = "o" And frmCpu1.btnb15.Tag = "o" And frmCpu1.btnb18.Tag = "o" Then
            frmganhou.Label1.Text = "CPU venceu"
            frmganhou.ShowDialog()
            frmCpu1.Label7.Text += 1
            Call frmCpu1.disablebuttons()
            ganhador = True

        ElseIf frmCpu1.btnb14.Tag = "o" And frmCpu1.btnb15.Tag = "o" And frmCpu1.btnb16.Tag = "o" Then
            frmganhou.Label1.Text = "CPU venceu"
            frmganhou.ShowDialog()
            frmCpu1.Label7.Text += 1
            Call frmCpu1.disablebuttons()
            ganhador = True

        ElseIf frmCpu1.btnb17.Tag = "o" And frmCpu1.btnb18.Tag = "o" And frmCpu1.btnb19.Tag = "o" Then
            frmganhou.Label1.Text = "CPU venceu"
            frmganhou.ShowDialog()
            frmCpu1.Label7.Text += 1
            Call frmCpu1.disablebuttons()
            ganhador = True
        End If

        If frmCpu1.btnb11.Tag <> "" And frmCpu1.btnb12.Tag <> "" And frmCpu1.btnb13.Tag <> "" And frmCpu1.btnb14.Tag <> "" And frmCpu1.btnb15.Tag <> "" And frmCpu1.btnb16.Tag <> "" And frmCpu1.btnb17.Tag <> "" And frmCpu1.btnb18.Tag <> "" And frmCpu1.btnb19.Tag <> "" Then
            If ganhador = False Then

                frmvelha.Show()

            End If
        End If

        frmCpu1.pgb1.Minimum = 0
        frmCpu1.pgb2.Minimum = 0
        frmCpu1.pgb1.Maximum = 100
        frmCpu1.pgb2.Maximum = 100

        If frmCpu1.Label5.Text = "1" Then
            frmCpu1.pgb2.Value = 66
        ElseIf frmCpu1.Label5.Text = "2" Then
            frmCpu1.pgb2.Value = 33
        ElseIf frmCpu1.Label5.Text = "3" Then
            frmCpu1.pgb2.Value = 0
        End If

        If frmCpu1.Label7.Text = "1" Then
            frmCpu1.pgb1.Value = 66
        ElseIf frmCpu1.Label7.Text = "2" Then
            frmCpu1.pgb1.Value = 33
        ElseIf frmCpu1.Label7.Text = "3" Then
            frmCpu1.pgb1.Value = 0
        End If


    End Sub
    Public Sub roleta(ByVal aleatorio As Double)

        i = New System.Random().Next(1, 9)
        frmCenarios.txtroleta.Text = i

    End Sub
    Public Sub numerosaleatorios(ByVal vroleta As Object)


        If turn = 2 Then

            i = New System.Random().Next(1, 9)

            If i = 1 And frmCpu1.btnb11.Tag = "" Then
                frmCpu1.btnb11.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
                frmCpu1.btnb11.Tag = "o"
                frmCpu1.pcbvez.Image = My.Resources.x1
                turn = 1
                frmCpu1.btnb11.Enabled = False



            ElseIf i = 2 And frmCpu1.btnb12.Tag = "" Then
                frmCpu1.btnb12.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
                frmCpu1.btnb12.Tag = "o"
                frmCpu1.pcbvez.Image = My.Resources.x1
                turn = 1
                frmCpu1.btnb12.Enabled = False

            ElseIf i = 3 And frmCpu1.btnb13.Tag = "" Then
                frmCpu1.btnb13.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
                frmCpu1.btnb13.Tag = "o"
                frmCpu1.pcbvez.Image = My.Resources.x1
                turn = 1
                frmCpu1.btnb13.Enabled = False

            ElseIf i = 4 And frmCpu1.btnb14.Tag = "" Then
                frmCpu1.btnb14.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
                frmCpu1.btnb14.Tag = "o"
                frmCpu1.pcbvez.Image = My.Resources.x1
                turn = 1
                frmCpu1.btnb14.Enabled = False

            ElseIf i = 5 And frmCpu1.btnb15.Tag = "" Then
                frmCpu1.btnb15.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
                frmCpu1.btnb15.Tag = "o"
                frmCpu1.pcbvez.Image = My.Resources.x1
                turn = 1
                frmCpu1.btnb15.Enabled = False

            ElseIf i = 6 And frmCpu1.btnb16.Tag = "" Then
                frmCpu1.btnb16.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
                frmCpu1.btnb16.Tag = "o"
                frmCpu1.pcbvez.Image = My.Resources.x1
                turn = 1
                frmCpu1.btnb16.Enabled = False

            ElseIf i = 7 And frmCpu1.btnb17.Tag = "" Then
                frmCpu1.btnb17.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
                frmCpu1.btnb17.Tag = "o"
                frmCpu1.pcbvez.Image = My.Resources.x1
                turn = 1
                frmCpu1.btnb17.Enabled = False

            ElseIf i = 8 And frmCpu1.btnb18.Tag = "" Then
                frmCpu1.btnb18.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
                frmCpu1.btnb18.Tag = "o"
                frmCpu1.pcbvez.Image = My.Resources.x1
                turn = 1
                frmCpu1.btnb18.Enabled = False

            ElseIf i = 9 And frmCpu1.btnb19.Tag = "" Then
                frmCpu1.btnb19.BackgroundImage = jogo_da_velha.My.Resources.Resources.bolinha
                frmCpu1.btnb19.Tag = "o"
                frmCpu1.pcbvez.Image = My.Resources.x1
                turn = 1
                frmCpu1.btnb19.Enabled = False
            Else
                numerosaleatorios(vroleta)
            End If
        End If
    End Sub
End Module
