Public Class frmCenarios
    Private Sub Cenarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pcbcenario1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\blanka.jpg"
        pcbcenario2.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Chunli.png"
        pcbcenario3.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Guile.jpg"
        pcbcenario4.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Ryo.jpg"
        pcbcenario5.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Cenario_Dhalsim.png"
        pcbcenario6.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\ehonda01.jpg"
        pcbcenario7.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\ken.jpg"
        pcbcenario8.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\zangief.png"
    End Sub

    Private Sub pcbcenario1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbcenario1.Click
        frmMultiplayer.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\blanka.jpg"
        frmCpu1.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\blanka.jpg"
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Close()
        frmVS.Show()
        Timer1.Stop()
    End Sub

    Private Sub pcbcenario2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbcenario2.Click
        frmMultiplayer.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Chunli.png"
        frmCpu1.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Chunli.png"
        Timer1.Start()
    End Sub

    Private Sub pcbcenario3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbcenario3.Click
        frmMultiplayer.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Guile.jpg"
        frmCpu1.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Guile.jpg"
        Timer1.Start()
    End Sub

    Private Sub pcbcenario4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbcenario4.Click
        frmMultiplayer.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Ryo.jpg"
        frmCpu1.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Ryo.jpg"
        Timer1.Start()
    End Sub

    Private Sub pcbcenario5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbcenario5.Click
        frmMultiplayer.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Cenario_Dhalsim.png"
        frmCpu1.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Cenario_Dhalsim.png"
        Timer1.Start()
    End Sub

    Private Sub pcbcenario6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbcenario6.Click
        frmMultiplayer.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\ehonda01.jpg"
        frmCpu1.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\ehonda01.jpg"
        Timer1.Start()
    End Sub

    Private Sub pcbcenario7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbcenario7.Click
        frmMultiplayer.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\ken.jpg"
        frmCpu1.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\ken.jpg"
        Timer1.Start()
    End Sub

    Private Sub pcbcenario8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbcenario8.Click
        frmMultiplayer.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\zangief.png"
        frmCpu1.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\zangief.png"
        Timer1.Start()
    End Sub

    Private Sub btnRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandom.Click
        i = New System.Random().Next(1, 9)
        txtroleta.Text = i
        If txtroleta.Text = "1" Then
            frmMultiplayer.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\blanka.jpg"
            frmCpu1.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\blanka.jpg"
            Timer1.Start()
        ElseIf txtroleta.Text = "2" Then
            frmMultiplayer.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Chunli.png"
            frmCpu1.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Chunli.png"
            Timer1.Start()
        ElseIf txtroleta.Text = "3" Then
            frmMultiplayer.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Guile.jpg"
            frmCpu1.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Guile.jpg"
            Timer1.Start()
        ElseIf txtroleta.Text = "4" Then
            frmMultiplayer.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Ryo.jpg"
            frmCpu1.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Ryo.jpg"
            Timer1.Start()
        ElseIf txtroleta.Text = "5" Then
            frmMultiplayer.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Cenario_Dhalsim.png"
            frmCpu1.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\Cenario_Dhalsim.png"
            Timer1.Start()
        ElseIf txtroleta.Text = "6" Then
            frmMultiplayer.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\ehonda01.jpg"
            frmCpu1.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\ehonda01.jpg"
            Timer1.Start()
        ElseIf txtroleta.Text = "7" Then
            frmMultiplayer.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\ken.jpg"
            frmCpu1.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\ken.jpg"
            Timer1.Start()
        ElseIf txtroleta.Text = "8" Then
            frmMultiplayer.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\zangief.png"
            frmCpu1.PictureBox1.ImageLocation = "C:\Users\USUARIO\Documents\VB\jogo da velha\Cenarios\zangief.png"
            Timer1.Start()
        End If

    End Sub
End Class