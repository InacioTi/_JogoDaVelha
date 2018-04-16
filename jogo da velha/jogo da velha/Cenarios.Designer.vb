<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCenarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCenarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pcbcenario1 = New System.Windows.Forms.PictureBox()
        Me.pcbcenario2 = New System.Windows.Forms.PictureBox()
        Me.pcbcenario3 = New System.Windows.Forms.PictureBox()
        Me.pcbcenario4 = New System.Windows.Forms.PictureBox()
        Me.pcbcenario5 = New System.Windows.Forms.PictureBox()
        Me.pcbcenario6 = New System.Windows.Forms.PictureBox()
        Me.pcbcenario7 = New System.Windows.Forms.PictureBox()
        Me.pcbcenario8 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.txtroleta = New System.Windows.Forms.TextBox()
        CType(Me.pcbcenario1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbcenario2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbcenario3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbcenario4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbcenario5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbcenario6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbcenario7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbcenario8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Escolha aqui o cenario de jogo"
        '
        'pcbcenario1
        '
        Me.pcbcenario1.ErrorImage = CType(resources.GetObject("pcbcenario1.ErrorImage"), System.Drawing.Image)
        Me.pcbcenario1.Image = CType(resources.GetObject("pcbcenario1.Image"), System.Drawing.Image)
        Me.pcbcenario1.Location = New System.Drawing.Point(1, 48)
        Me.pcbcenario1.Name = "pcbcenario1"
        Me.pcbcenario1.Size = New System.Drawing.Size(309, 216)
        Me.pcbcenario1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbcenario1.TabIndex = 0
        Me.pcbcenario1.TabStop = False
        '
        'pcbcenario2
        '
        Me.pcbcenario2.ErrorImage = CType(resources.GetObject("pcbcenario2.ErrorImage"), System.Drawing.Image)
        Me.pcbcenario2.Image = CType(resources.GetObject("pcbcenario2.Image"), System.Drawing.Image)
        Me.pcbcenario2.Location = New System.Drawing.Point(316, 48)
        Me.pcbcenario2.Name = "pcbcenario2"
        Me.pcbcenario2.Size = New System.Drawing.Size(309, 216)
        Me.pcbcenario2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbcenario2.TabIndex = 3
        Me.pcbcenario2.TabStop = False
        '
        'pcbcenario3
        '
        Me.pcbcenario3.ErrorImage = CType(resources.GetObject("pcbcenario3.ErrorImage"), System.Drawing.Image)
        Me.pcbcenario3.Image = CType(resources.GetObject("pcbcenario3.Image"), System.Drawing.Image)
        Me.pcbcenario3.Location = New System.Drawing.Point(631, 48)
        Me.pcbcenario3.Name = "pcbcenario3"
        Me.pcbcenario3.Size = New System.Drawing.Size(309, 216)
        Me.pcbcenario3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbcenario3.TabIndex = 4
        Me.pcbcenario3.TabStop = False
        '
        'pcbcenario4
        '
        Me.pcbcenario4.ErrorImage = CType(resources.GetObject("pcbcenario4.ErrorImage"), System.Drawing.Image)
        Me.pcbcenario4.Image = CType(resources.GetObject("pcbcenario4.Image"), System.Drawing.Image)
        Me.pcbcenario4.Location = New System.Drawing.Point(1, 270)
        Me.pcbcenario4.Name = "pcbcenario4"
        Me.pcbcenario4.Size = New System.Drawing.Size(309, 216)
        Me.pcbcenario4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbcenario4.TabIndex = 5
        Me.pcbcenario4.TabStop = False
        '
        'pcbcenario5
        '
        Me.pcbcenario5.ErrorImage = CType(resources.GetObject("pcbcenario5.ErrorImage"), System.Drawing.Image)
        Me.pcbcenario5.Image = CType(resources.GetObject("pcbcenario5.Image"), System.Drawing.Image)
        Me.pcbcenario5.Location = New System.Drawing.Point(316, 270)
        Me.pcbcenario5.Name = "pcbcenario5"
        Me.pcbcenario5.Size = New System.Drawing.Size(309, 216)
        Me.pcbcenario5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbcenario5.TabIndex = 6
        Me.pcbcenario5.TabStop = False
        '
        'pcbcenario6
        '
        Me.pcbcenario6.ErrorImage = CType(resources.GetObject("pcbcenario6.ErrorImage"), System.Drawing.Image)
        Me.pcbcenario6.Image = CType(resources.GetObject("pcbcenario6.Image"), System.Drawing.Image)
        Me.pcbcenario6.Location = New System.Drawing.Point(631, 270)
        Me.pcbcenario6.Name = "pcbcenario6"
        Me.pcbcenario6.Size = New System.Drawing.Size(309, 216)
        Me.pcbcenario6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbcenario6.TabIndex = 7
        Me.pcbcenario6.TabStop = False
        '
        'pcbcenario7
        '
        Me.pcbcenario7.ErrorImage = CType(resources.GetObject("pcbcenario7.ErrorImage"), System.Drawing.Image)
        Me.pcbcenario7.Image = CType(resources.GetObject("pcbcenario7.Image"), System.Drawing.Image)
        Me.pcbcenario7.Location = New System.Drawing.Point(146, 492)
        Me.pcbcenario7.Name = "pcbcenario7"
        Me.pcbcenario7.Size = New System.Drawing.Size(309, 216)
        Me.pcbcenario7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbcenario7.TabIndex = 8
        Me.pcbcenario7.TabStop = False
        '
        'pcbcenario8
        '
        Me.pcbcenario8.ErrorImage = CType(resources.GetObject("pcbcenario8.ErrorImage"), System.Drawing.Image)
        Me.pcbcenario8.Image = CType(resources.GetObject("pcbcenario8.Image"), System.Drawing.Image)
        Me.pcbcenario8.Location = New System.Drawing.Point(461, 492)
        Me.pcbcenario8.Name = "pcbcenario8"
        Me.pcbcenario8.Size = New System.Drawing.Size(309, 216)
        Me.pcbcenario8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbcenario8.TabIndex = 9
        Me.pcbcenario8.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(806, 8)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(99, 27)
        Me.btnRandom.TabIndex = 10
        Me.btnRandom.Text = "Random"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'txtroleta
        '
        Me.txtroleta.Location = New System.Drawing.Point(826, 509)
        Me.txtroleta.Name = "txtroleta"
        Me.txtroleta.Size = New System.Drawing.Size(97, 20)
        Me.txtroleta.TabIndex = 11
        '
        'frmCenarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(941, 712)
        Me.Controls.Add(Me.txtroleta)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.pcbcenario8)
        Me.Controls.Add(Me.pcbcenario7)
        Me.Controls.Add(Me.pcbcenario6)
        Me.Controls.Add(Me.pcbcenario5)
        Me.Controls.Add(Me.pcbcenario4)
        Me.Controls.Add(Me.pcbcenario3)
        Me.Controls.Add(Me.pcbcenario2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pcbcenario1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCenarios"
        Me.Text = "Cenarios"
        CType(Me.pcbcenario1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbcenario2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbcenario3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbcenario4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbcenario5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbcenario6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbcenario7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbcenario8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcbcenario1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pcbcenario2 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbcenario3 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbcenario4 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbcenario5 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbcenario6 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbcenario7 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbcenario8 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnRandom As System.Windows.Forms.Button
    Friend WithEvents txtroleta As System.Windows.Forms.TextBox
End Class
