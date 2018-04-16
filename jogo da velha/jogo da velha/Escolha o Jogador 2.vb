Public Class frmEscolha_o_Jogador_2
    Private Sub pcbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbClose.Click
        Me.Close()

    End Sub
    Private Sub pcbblanca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbblanca2.Click
        txtjogador2.Text = "Blanka"
        pcbpl2.Image = My.Resources.blanca
        frmMultiplayer.pcbplayer2.Image = My.Resources.blanca
        frmMultiplayer.txtmp2.Text = "Blanka"
        frmVS.pcbPLA2.Image = My.Resources.Blanka

    End Sub

    Private Sub pcbChunLi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbChunLi2.Click
        txtjogador2.Text = "ChunLi"
        pcbpl2.Image = My.Resources.ChunLi
        frmMultiplayer.pcbplayer2.Image = My.Resources.ChunLi
        frmMultiplayer.txtmp2.Text = "ChunLi"
        frmVS.pcbPLA2.Image = My.Resources.Chun_Li
    End Sub

    Private Sub pcbDalsin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbDalsin2.Click
        txtjogador2.Text = "Dhalsim"
        pcbpl2.Image = My.Resources.Dalsin
        frmMultiplayer.pcbplayer2.Image = My.Resources.Dalsin
        frmMultiplayer.txtmp2.Text = "Dhalsim"
        frmVS.pcbPLA2.Image = My.Resources.Dhalsim
    End Sub

    Private Sub pcbguile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbguile2.Click
        txtjogador2.Text = "Guile"
        pcbpl2.Image = My.Resources.Guile
        frmMultiplayer.pcbplayer2.Image = My.Resources.Guile
        frmMultiplayer.txtmp2.Text = "Guile"
        frmVS.pcbPLA2.Image = My.Resources.Guile1
    End Sub

    Private Sub pcbBison_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbcViper2.Click
        txtjogador2.Text = "C.Viper"
        pcbpl2.Image = My.Resources.Cviper
        frmMultiplayer.pcbplayer2.Image = My.Resources.Cviper
        frmMultiplayer.txtmp2.Text = "C.Viper"
        frmVS.pcbPLA2.Image = My.Resources.C_Viper
    End Sub

    Private Sub pcbVegas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbeHonda2.Click
        txtjogador2.Text = "E.Honda"
        pcbpl2.Image = My.Resources.ehonda
        frmMultiplayer.pcbplayer2.Image = My.Resources.ehonda
        frmMultiplayer.txtmp2.Text = "E.Honda"
        frmVS.pcbPLA2.Image = My.Resources.E_Honda
    End Sub

    Private Sub pcbRyo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbRyo2.Click
        txtjogador2.Text = "Ryu"
        pcbpl2.Image = My.Resources.Ryo
        frmMultiplayer.pcbplayer2.Image = My.Resources.Ryo
        frmMultiplayer.txtmp2.Text = "Ryu"
        frmVS.pcbPLA2.Image = My.Resources.Ryu
    End Sub

    Private Sub pcbZanguief_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbZanguief2.Click
        txtjogador2.Text = "Zangief"
        pcbpl2.Image = My.Resources.Zanguief
        frmMultiplayer.pcbplayer2.Image = My.Resources.Zanguief
        frmMultiplayer.txtmp2.Text = "Zangief"
        frmVS.pcbPLA2.Image = My.Resources.Zangief
    End Sub


    Private Sub txtjogador2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjogador2.TextChanged
        If txtjogador2.Text <> "" Then
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Close()
        frmCenarios.ShowDialog()
        Timer1.Stop()
    End Sub

    Private Sub frmEscolha_o_Jogador_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmEscolha_o_Jogador.Close()
        If lblVez.Text = "CPU escolhe" Then
            i = New System.Random().Next(1, 9)
        End If
        If i = 1 Then
            frmCpu1.pcbplayer2.Image = My.Resources.blanca
            frmCpu1.txtmp2.Text = "Blanka"
            pcbpl2.Image = My.Resources.blanca
            txtjogador2.Text = "Blanka"
        End If
        If i = 2 Then
            frmCpu1.pcbplayer2.Image = My.Resources.ChunLi
            frmCpu1.txtmp2.Text = "ChunLi"
            pcbpl2.Image = My.Resources.ChunLi
            txtjogador2.Text = "ChunLi"
        End If
        If i = 3 Then
            frmCpu1.pcbplayer2.Image = My.Resources.Dalsin
            frmCpu1.txtmp2.Text = "Dhalsim"
            pcbpl2.Image = My.Resources.Dalsin
            txtjogador2.Text = "Dhalsim"
        End If
        If i = 4 Then
            frmCpu1.pcbplayer2.Image = My.Resources.Guile
            frmCpu1.txtmp2.Text = "Guile"
            pcbpl2.Image = My.Resources.Guile
            txtjogador2.Text = "Guile"
        End If
        If i = 5 Then
            frmCpu1.pcbplayer2.Image = My.Resources.Cviper
            frmCpu1.txtmp2.Text = "C.Viper"
            pcbpl2.Image = My.Resources.Cviper
            txtjogador2.Text = "C.Viper"
        End If
        If i = 6 Then
            frmCpu1.pcbplayer2.Image = My.Resources.ehonda
            frmCpu1.txtmp2.Text = "E.Honda"
            pcbpl2.Image = My.Resources.ehonda
            txtjogador2.Text = "E.Honda"
        End If
        If i = 7 Then
            frmCpu1.pcbplayer2.Image = My.Resources.Ryo
            frmCpu1.txtmp2.Text = "Ryu"
            pcbpl2.Image = My.Resources.Ryo
            txtjogador2.Text = "Ryu"
        End If
        If i = 8 Then
            frmCpu1.pcbplayer2.Image = My.Resources.Zanguief
            frmCpu1.txtmp2.Text = "Zangief"
            pcbpl2.Image = My.Resources.Zanguief
            txtjogador2.Text = "Zangief"
        End If
        frmjogo.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub pcbKen2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbKen2.Click
        txtjogador2.Text = "Ken"
        pcbpl2.Image = My.Resources.ken_portrait
        frmMultiplayer.pcbplayer2.Image = My.Resources.ken_portrait
        frmMultiplayer.txtmp2.Text = "Ken"
        frmVS.pcbPLA2.Image = My.Resources.Ken


    End Sub
End Class