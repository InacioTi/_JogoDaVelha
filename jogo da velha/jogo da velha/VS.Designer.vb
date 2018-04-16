<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVS
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pcbvs = New System.Windows.Forms.PictureBox()
        Me.pcbPLA2 = New System.Windows.Forms.PictureBox()
        Me.pcbPLA1 = New System.Windows.Forms.PictureBox()
        CType(Me.pcbvs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPLA2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPLA1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'pcbvs
        '
        Me.pcbvs.Image = Global.jogo_da_velha.My.Resources.Resources.vs
        Me.pcbvs.Location = New System.Drawing.Point(371, 362)
        Me.pcbvs.Name = "pcbvs"
        Me.pcbvs.Size = New System.Drawing.Size(110, 110)
        Me.pcbvs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbvs.TabIndex = 2
        Me.pcbvs.TabStop = False
        '
        'pcbPLA2
        '
        Me.pcbPLA2.Location = New System.Drawing.Point(424, 0)
        Me.pcbPLA2.Name = "pcbPLA2"
        Me.pcbPLA2.Size = New System.Drawing.Size(447, 483)
        Me.pcbPLA2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbPLA2.TabIndex = 1
        Me.pcbPLA2.TabStop = False
        '
        'pcbPLA1
        '
        Me.pcbPLA1.Location = New System.Drawing.Point(1, 0)
        Me.pcbPLA1.Name = "pcbPLA1"
        Me.pcbPLA1.Size = New System.Drawing.Size(426, 483)
        Me.pcbPLA1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbPLA1.TabIndex = 0
        Me.pcbPLA1.TabStop = False
        '
        'frmVS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 484)
        Me.Controls.Add(Me.pcbvs)
        Me.Controls.Add(Me.pcbPLA2)
        Me.Controls.Add(Me.pcbPLA1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VS"
        CType(Me.pcbvs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPLA2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPLA1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pcbPLA1 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbPLA2 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbvs As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
