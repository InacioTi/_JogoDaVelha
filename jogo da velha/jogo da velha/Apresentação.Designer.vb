<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmjogo
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
        Me.btnvs = New System.Windows.Forms.Button()
        Me.btnn1 = New System.Windows.Forms.Button()
        Me.btnv2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnvs
        '
        Me.btnvs.Location = New System.Drawing.Point(91, 12)
        Me.btnvs.Name = "btnvs"
        Me.btnvs.Size = New System.Drawing.Size(222, 58)
        Me.btnvs.TabIndex = 0
        Me.btnvs.Text = "player1  vs  player2"
        Me.btnvs.UseVisualStyleBackColor = True
        '
        'btnn1
        '
        Me.btnn1.Location = New System.Drawing.Point(91, 95)
        Me.btnn1.Name = "btnn1"
        Me.btnn1.Size = New System.Drawing.Size(222, 58)
        Me.btnn1.TabIndex = 1
        Me.btnn1.Text = "player1 vs cpu nivel1"
        Me.btnn1.UseVisualStyleBackColor = True
        '
        'btnv2
        '
        Me.btnv2.Location = New System.Drawing.Point(91, 169)
        Me.btnv2.Name = "btnv2"
        Me.btnv2.Size = New System.Drawing.Size(222, 58)
        Me.btnv2.TabIndex = 2
        Me.btnv2.Text = "player1   vs cpu nivel2"
        Me.btnv2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.jogo_da_velha.My.Resources.Resources.apresentação
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(442, 245)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmjogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 243)
        Me.Controls.Add(Me.btnv2)
        Me.Controls.Add(Me.btnn1)
        Me.Controls.Add(Me.btnvs)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmjogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jogo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnvs As System.Windows.Forms.Button
    Friend WithEvents btnn1 As System.Windows.Forms.Button
    Friend WithEvents btnv2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
