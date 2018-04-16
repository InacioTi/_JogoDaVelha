<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEscolha_o_Jogador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pcbblanca = New System.Windows.Forms.PictureBox()
        Me.pcbChunLi = New System.Windows.Forms.PictureBox()
        Me.pcbDalsin = New System.Windows.Forms.PictureBox()
        Me.pcbguile = New System.Windows.Forms.PictureBox()
        Me.pcbcViper = New System.Windows.Forms.PictureBox()
        Me.pcbeHonda = New System.Windows.Forms.PictureBox()
        Me.pcbRyo = New System.Windows.Forms.PictureBox()
        Me.pcbZanguief = New System.Windows.Forms.PictureBox()
        Me.pcbClose = New System.Windows.Forms.PictureBox()
        Me.txtjogador1 = New System.Windows.Forms.TextBox()
        Me.lblVez = New System.Windows.Forms.Label()
        Me.pcbpl1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pcbKen = New System.Windows.Forms.PictureBox()
        CType(Me.pcbblanca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbChunLi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbDalsin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbguile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbcViper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbeHonda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbRyo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbZanguief, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbpl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbKen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbblanca
        '
        Me.pcbblanca.Image = Global.jogo_da_velha.My.Resources.Resources.blanca
        Me.pcbblanca.Location = New System.Drawing.Point(1, 267)
        Me.pcbblanca.Name = "pcbblanca"
        Me.pcbblanca.Size = New System.Drawing.Size(125, 178)
        Me.pcbblanca.TabIndex = 0
        Me.pcbblanca.TabStop = False
        Me.pcbblanca.Tag = ""
        '
        'pcbChunLi
        '
        Me.pcbChunLi.Image = Global.jogo_da_velha.My.Resources.Resources.ChunLi
        Me.pcbChunLi.Location = New System.Drawing.Point(132, 267)
        Me.pcbChunLi.Name = "pcbChunLi"
        Me.pcbChunLi.Size = New System.Drawing.Size(125, 178)
        Me.pcbChunLi.TabIndex = 1
        Me.pcbChunLi.TabStop = False
        Me.pcbChunLi.Tag = "Chun Li"
        '
        'pcbDalsin
        '
        Me.pcbDalsin.Image = Global.jogo_da_velha.My.Resources.Resources.Dalsin
        Me.pcbDalsin.Location = New System.Drawing.Point(263, 267)
        Me.pcbDalsin.Name = "pcbDalsin"
        Me.pcbDalsin.Size = New System.Drawing.Size(125, 178)
        Me.pcbDalsin.TabIndex = 2
        Me.pcbDalsin.TabStop = False
        Me.pcbDalsin.Tag = "Dalsin"
        '
        'pcbguile
        '
        Me.pcbguile.Image = Global.jogo_da_velha.My.Resources.Resources.Guile
        Me.pcbguile.Location = New System.Drawing.Point(394, 267)
        Me.pcbguile.Name = "pcbguile"
        Me.pcbguile.Size = New System.Drawing.Size(125, 178)
        Me.pcbguile.TabIndex = 3
        Me.pcbguile.TabStop = False
        Me.pcbguile.Tag = "Guile"
        '
        'pcbcViper
        '
        Me.pcbcViper.Image = Global.jogo_da_velha.My.Resources.Resources.Cviper
        Me.pcbcViper.Location = New System.Drawing.Point(525, 267)
        Me.pcbcViper.Name = "pcbcViper"
        Me.pcbcViper.Size = New System.Drawing.Size(125, 178)
        Me.pcbcViper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pcbcViper.TabIndex = 4
        Me.pcbcViper.TabStop = False
        Me.pcbcViper.Tag = "C Viper"
        '
        'pcbeHonda
        '
        Me.pcbeHonda.Image = Global.jogo_da_velha.My.Resources.Resources.ehonda
        Me.pcbeHonda.Location = New System.Drawing.Point(656, 267)
        Me.pcbeHonda.Name = "pcbeHonda"
        Me.pcbeHonda.Size = New System.Drawing.Size(125, 178)
        Me.pcbeHonda.TabIndex = 5
        Me.pcbeHonda.TabStop = False
        Me.pcbeHonda.Tag = "Vegas"
        '
        'pcbRyo
        '
        Me.pcbRyo.Image = Global.jogo_da_velha.My.Resources.Resources.Ryo
        Me.pcbRyo.Location = New System.Drawing.Point(201, 451)
        Me.pcbRyo.Name = "pcbRyo"
        Me.pcbRyo.Size = New System.Drawing.Size(125, 178)
        Me.pcbRyo.TabIndex = 6
        Me.pcbRyo.TabStop = False
        Me.pcbRyo.Tag = "Ryo"
        '
        'pcbZanguief
        '
        Me.pcbZanguief.Image = Global.jogo_da_velha.My.Resources.Resources.Zanguief
        Me.pcbZanguief.Location = New System.Drawing.Point(463, 451)
        Me.pcbZanguief.Name = "pcbZanguief"
        Me.pcbZanguief.Size = New System.Drawing.Size(125, 178)
        Me.pcbZanguief.TabIndex = 7
        Me.pcbZanguief.TabStop = False
        Me.pcbZanguief.Tag = "Zanguief"
        '
        'pcbClose
        '
        Me.pcbClose.Image = Global.jogo_da_velha.My.Resources.Resources.x1
        Me.pcbClose.Location = New System.Drawing.Point(703, 20)
        Me.pcbClose.Name = "pcbClose"
        Me.pcbClose.Size = New System.Drawing.Size(41, 44)
        Me.pcbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbClose.TabIndex = 8
        Me.pcbClose.TabStop = False
        '
        'txtjogador1
        '
        Me.txtjogador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjogador1.Location = New System.Drawing.Point(337, 232)
        Me.txtjogador1.Name = "txtjogador1"
        Me.txtjogador1.ReadOnly = True
        Me.txtjogador1.Size = New System.Drawing.Size(147, 20)
        Me.txtjogador1.TabIndex = 9
        Me.txtjogador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblVez
        '
        Me.lblVez.AutoSize = True
        Me.lblVez.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVez.Location = New System.Drawing.Point(315, 9)
        Me.lblVez.Name = "lblVez"
        Me.lblVez.Size = New System.Drawing.Size(183, 24)
        Me.lblVez.TabIndex = 11
        Me.lblVez.Text = "Jogador 1 escolhe"
        '
        'pcbpl1
        '
        Me.pcbpl1.Location = New System.Drawing.Point(348, 36)
        Me.pcbpl1.Name = "pcbpl1"
        Me.pcbpl1.Size = New System.Drawing.Size(121, 177)
        Me.pcbpl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbpl1.TabIndex = 12
        Me.pcbpl1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'pcbKen
        '
        Me.pcbKen.Image = Global.jogo_da_velha.My.Resources.Resources.ken_portrait
        Me.pcbKen.Location = New System.Drawing.Point(332, 451)
        Me.pcbKen.Name = "pcbKen"
        Me.pcbKen.Size = New System.Drawing.Size(125, 178)
        Me.pcbKen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbKen.TabIndex = 13
        Me.pcbKen.TabStop = False
        Me.pcbKen.Tag = "Ken"
        '
        'frmEscolha_o_Jogador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.jogo_da_velha.My.Resources.Resources.ap
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 633)
        Me.Controls.Add(Me.pcbKen)
        Me.Controls.Add(Me.pcbpl1)
        Me.Controls.Add(Me.lblVez)
        Me.Controls.Add(Me.txtjogador1)
        Me.Controls.Add(Me.pcbClose)
        Me.Controls.Add(Me.pcbZanguief)
        Me.Controls.Add(Me.pcbRyo)
        Me.Controls.Add(Me.pcbeHonda)
        Me.Controls.Add(Me.pcbcViper)
        Me.Controls.Add(Me.pcbguile)
        Me.Controls.Add(Me.pcbDalsin)
        Me.Controls.Add(Me.pcbChunLi)
        Me.Controls.Add(Me.pcbblanca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEscolha_o_Jogador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Escolha_o_Jogador"
        CType(Me.pcbblanca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbChunLi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbDalsin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbguile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbcViper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbeHonda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbRyo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbZanguief, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbpl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbKen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcbblanca As System.Windows.Forms.PictureBox
    Friend WithEvents pcbChunLi As System.Windows.Forms.PictureBox
    Friend WithEvents pcbDalsin As System.Windows.Forms.PictureBox
    Friend WithEvents pcbguile As System.Windows.Forms.PictureBox
    Friend WithEvents pcbcViper As System.Windows.Forms.PictureBox
    Friend WithEvents pcbeHonda As System.Windows.Forms.PictureBox
    Friend WithEvents pcbRyo As System.Windows.Forms.PictureBox
    Friend WithEvents pcbZanguief As System.Windows.Forms.PictureBox
    Friend WithEvents pcbClose As System.Windows.Forms.PictureBox
    Friend WithEvents txtjogador1 As System.Windows.Forms.TextBox
    Friend WithEvents lblVez As System.Windows.Forms.Label
    Friend WithEvents pcbpl1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pcbKen As System.Windows.Forms.PictureBox
End Class
