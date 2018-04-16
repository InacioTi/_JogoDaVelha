Public Class frmCpu1




    Private Sub frmCpu1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pgb1.Value = 100
        pgb2.Value = 100


        turn = 1

    End Sub
    Public Sub disablebuttons()
        btnb11.Enabled = False
        btnb12.Enabled = False
        btnb13.Enabled = False
        btnb14.Enabled = False
        btnb15.Enabled = False
        btnb16.Enabled = False
        btnb17.Enabled = False
        btnb18.Enabled = False
        btnb19.Enabled = False

    End Sub

    Private Sub btnb11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb11.Click
        jogada2(btnb11)
        numerosaleatorios(btnb11)

    End Sub

    Private Sub btnb12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb12.Click
        jogada2(btnb12)
        numerosaleatorios(btnb12)


    End Sub

    Private Sub btnb13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb13.Click
        jogada2(btnb13)
        numerosaleatorios(btnb13)
    End Sub

    Private Sub btnb14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb14.Click
        jogada2(btnb14)
        numerosaleatorios(btnb14)
    End Sub

    Private Sub btnb15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb15.Click
        jogada2(btnb15)
        numerosaleatorios(btnb15)
    End Sub

    Private Sub btnb16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb16.Click
        jogada2(btnb16)
        numerosaleatorios(btnb16)
    End Sub

    Private Sub btnb17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb17.Click
        jogada2(btnb17)
        numerosaleatorios(btnb17)

    End Sub

    Private Sub btnb18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb18.Click
        jogada2(btnb18)
        numerosaleatorios(btnb18)

    End Sub

    Private Sub btnb19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb19.Click
        jogada2(btnb19)
        numerosaleatorios(btnb19)

    End Sub
    Private Sub btnReiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReiniciar.Click
        Dim resp As Integer
        btnb11.BackgroundImage = Nothing
        btnb11.Tag = ""
        btnb11.Enabled = True
        btnb12.BackgroundImage = Nothing
        btnb12.Tag = ""
        btnb12.Enabled = True
        btnb13.BackgroundImage = Nothing
        btnb13.Tag = ""
        btnb13.Enabled = True
        btnb14.BackgroundImage = Nothing
        btnb14.Tag = ""
        btnb14.Enabled = True
        btnb15.BackgroundImage = Nothing
        btnb15.Tag = ""
        btnb15.Enabled = True
        btnb16.BackgroundImage = Nothing
        btnb16.Tag = ""
        btnb16.Enabled = True
        btnb17.BackgroundImage = Nothing
        btnb17.Tag = ""
        btnb17.Enabled = True
        btnb18.BackgroundImage = Nothing
        btnb18.Tag = ""
        btnb18.Enabled = True
        btnb19.BackgroundImage = Nothing
        btnb19.Tag = ""
        btnb19.Enabled = True

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class