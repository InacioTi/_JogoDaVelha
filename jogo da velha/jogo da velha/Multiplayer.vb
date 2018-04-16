Public Class frmMultiplayer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pgb1.Value = 100
        pgb2.Value = 100


        turn = 1


    End Sub
    
    Public Sub disablebuttons()
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

        jogada(btnb1)

    End Sub

    Private Sub btnb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb2.Click
        jogada(btnb2)
    End Sub

    Private Sub btnb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb3.Click

        jogada(btnb3)

    End Sub

    Private Sub btnb4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb4.Click
        jogada(btnb4)

    End Sub

    Private Sub btnb5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb5.Click
        jogada(btnb5)

    End Sub

    Private Sub btnb6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb6.Click
        jogada(btnb6)

    End Sub

    Private Sub btnb7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb7.Click
        jogada(btnb7)

    End Sub

    Private Sub btnb8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb8.Click
        jogada(btnb8)

    End Sub

    Private Sub btnb9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb9.Click
        jogada(btnb9)

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

        If Label5.Text = "3" Or Label7.Text = "3" Then
            resp = MsgBox("Deseja continuar e jogar com os mesmos personagens?", vbQuestion + vbYesNo)
            If resp = vbNo Then
                Me.Close()
            Else
                pgb1.Value = 100
                pgb2.Value = 100
                Label5.Text = "0"
                Label7.Text = "0"
            End If

        End If



    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Dim vresp As Integer

        vresp = MsgBox("Deseja sair do jogo", MsgBoxStyle.Question + vbYesNo)

        If vresp = vbYes Then
            Me.Close()

        End If
    End Sub
End Class
