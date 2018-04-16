Public Class frmEscolha_o_Jogador

    Private Sub pcbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbClose.Click
        Me.Close()

    End Sub

    Private Sub pcbblanca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbblanca.Click
        txtjogador1.Text = "Blanka"
        pcbpl1.Image = My.Resources.blanca
        frmMultiplayer.pcbplayer1.Image = My.Resources.blanca
        frmMultiplayer.txtmp1.Text = "Blanka"
        frmCpu1.pcbplayer1.Image = My.Resources.blanca
        frmCpu1.txtmp1.Text = "Blanka"
        frmVS.pcbPLA1.Image = My.Resources.Blanka


    End Sub

    Private Sub pcbChunLi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbChunLi.Click
        txtjogador1.Text = "ChunLi"
        pcbpl1.Image = My.Resources.ChunLi
        frmMultiplayer.pcbplayer1.Image = My.Resources.ChunLi
        frmMultiplayer.txtmp1.Text = "ChunLi"
        frmCpu1.pcbplayer1.Image = My.Resources.ChunLi
        frmCpu1.txtmp1.Text = "ChunLi"
        frmVS.pcbPLA1.Image = My.Resources.Chun_Li



    End Sub

    Private Sub pcbDalsin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbDalsin.Click
        txtjogador1.Text = "Dhalsim"
        pcbpl1.Image = My.Resources.Dalsin
        frmMultiplayer.pcbplayer1.Image = My.Resources.Dalsin
        frmMultiplayer.txtmp1.Text = "Dhalsim"
        frmCpu1.pcbplayer1.Image = My.Resources.Dalsin
        frmCpu1.txtmp1.Text = "Dhalsim"
        frmVS.pcbPLA1.Image = My.Resources.Dhalsim

    End Sub

    Private Sub pcbguile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbguile.Click
        txtjogador1.Text = "Guile"
        pcbpl1.Image = My.Resources.Guile
        frmMultiplayer.pcbplayer1.Image = My.Resources.Guile
        frmMultiplayer.txtmp1.Text = "Guile"
        frmCpu1.pcbplayer1.Image = My.Resources.Guile
        frmCpu1.txtmp1.Text = "Guile"
        frmVS.pcbPLA1.Image = My.Resources.Guile1

    End Sub

    Private Sub pcbBison_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbcViper.Click
        txtjogador1.Text = "C.Viper"
        pcbpl1.Image = My.Resources.Cviper
        frmMultiplayer.pcbplayer1.Image = My.Resources.Cviper
        frmMultiplayer.txtmp1.Text = "C.Viper"
        frmCpu1.pcbplayer1.Image = My.Resources.Cviper
        frmCpu1.txtmp1.Text = "C.Viper"
        frmVS.pcbPLA1.Image = My.Resources.C_Viper


    End Sub

    Private Sub pcbVegas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbeHonda.Click
        txtjogador1.Text = "E.Honda"
        pcbpl1.Image = My.Resources.ehonda
        frmMultiplayer.pcbplayer1.Image = My.Resources.ehonda
        frmMultiplayer.txtmp1.Text = "E.Honda"
        frmCpu1.pcbplayer1.Image = My.Resources.ehonda
        frmCpu1.txtmp1.Text = "E.Honda"
        frmVS.pcbPLA1.Image = My.Resources.E_Honda

    End Sub

    Private Sub pcbRyo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbRyo.Click
        txtjogador1.Text = "Ryu"
        pcbpl1.Image = My.Resources.Ryo
        frmMultiplayer.pcbplayer1.Image = My.Resources.Ryo
        frmMultiplayer.txtmp1.Text = "Ryu"
        frmCpu1.pcbplayer1.Image = My.Resources.Ryo
        frmCpu1.txtmp1.Text = "Ryu"
        frmVS.pcbPLA1.Image = My.Resources.Ryu


    End Sub

    Private Sub pcbZanguief_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbZanguief.Click
        txtjogador1.Text = "Zangief"
        pcbpl1.Image = My.Resources.Zanguief
        frmMultiplayer.pcbplayer1.Image = My.Resources.Zanguief
        frmMultiplayer.txtmp1.Text = "Zangief"
        frmCpu1.pcbplayer1.Image = My.Resources.Zanguief
        frmCpu1.txtmp1.Text = "Zangief"
        frmVS.pcbPLA1.Image = My.Resources.Zangief



    End Sub


    Private Sub txtjogador1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjogador1.TextChanged
        If txtjogador1.Text <> "" Then
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Close()
        frmEscolha_o_Jogador_2.Show()

        If frmEscolha_o_Jogador_2.lblVez.Text = "CPU escolhe" Then
            i = New System.Random().Next(1, 9)
            If i = 1 Then
                frmCpu1.pcbplayer1.Image = My.Resources.blanca
                frmCpu1.txtmp1.Text = "Blanka"
                frmVS.pcbPLA1.Image = My.Resources.Blanka
            ElseIf i = 2 Then
                frmCpu1.pcbplayer2.Image = My.Resources.ChunLi
                frmCpu1.txtmp2.Text = "ChunLi"
                frmVS.pcbPLA2.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\apresentação jogo da velha\Chun-Li.gif"
            ElseIf i = 3 Then
                frmCpu1.pcbplayer2.Image = My.Resources.Dalsin
                frmCpu1.txtmp2.Text = "Dhalsim"
                frmVS.pcbPLA2.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\apresentação jogo da velha\Dhalsim.gif"
            ElseIf i = 4 Then
                frmCpu1.pcbplayer2.Image = My.Resources.Guile
                frmCpu1.txtmp2.Text = "Guile"
                frmVS.pcbPLA2.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\apresentação jogo da velha\Guile.gif"
            ElseIf i = 5 Then
                frmCpu1.pcbplayer2.Image = My.Resources.Cviper
                frmCpu1.txtmp2.Text = "C.Viper"
                frmVS.pcbPLA2.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\apresentação jogo da velha\C Viper.gif"
            ElseIf i = 6 Then
                frmCpu1.pcbplayer2.Image = My.Resources.ehonda
                frmCpu1.txtmp2.Text = "E.Honda"
                frmVS.pcbPLA2.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\apresentação jogo da velha\E.Honda.gif"
            ElseIf i = 7 Then
                frmCpu1.pcbplayer2.Image = My.Resources.Ryo
                frmCpu1.txtmp2.Text = "Ryu"
                frmVS.pcbPLA2.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\apresentação jogo da velha\Ryu.gif"
            ElseIf i = 8 Then
                frmCpu1.pcbplayer2.Image = My.Resources.Zanguief
                frmCpu1.txtmp2.Text = "Zangief"
                frmVS.pcbPLA2.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\apresentação jogo da velha\Zangief.gif"
            ElseIf i = 9 Then
                frmCpu1.pcbplayer2.Image = My.Resources.ken_portrait
                frmCpu1.txtmp2.Text = "Ken"
                frmVS.pcbPLA2.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\apresentação jogo da velha\Ken.gif"
            End If
        End If
        Timer1.Stop()
    End Sub

    Private Sub pcbKen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbKen.Click
        txtjogador1.Text = "Ken"
        pcbpl1.Image = My.Resources.ken_portrait
        frmMultiplayer.pcbplayer1.Image = My.Resources.ken_portrait
        frmMultiplayer.txtmp1.Text = "Ken"
        frmCpu1.pcbplayer1.Image = My.Resources.ken_portrait
        frmCpu1.txtmp1.Text = "Ken"
        frmVS.pcbPLA1.Image = My.Resources.Ken
    End Sub
End Class