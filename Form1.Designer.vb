<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtinicio = New System.Windows.Forms.TextBox()
        Me.txtentrega = New System.Windows.Forms.TextBox()
        Me.kinicio = New System.Windows.Forms.TextBox()
        Me.kfim = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNdias = New System.Windows.Forms.Label()
        Me.lblPagamento = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblnkn = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPagamentoKM = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Btncalcular = New System.Windows.Forms.Button()
        Me.Btnlimpar = New System.Windows.Forms.Button()
        Me.Btnsair = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ExAluguerAuto.My.Resources.Resources.BannerCarros
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(796, 245)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(327, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Evans Veículos - Aluguer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Data do ínicio (dd/mm/yyyy):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Data de Entrega (dd/mm/yyyy):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Quilometragem ìnicial:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 450)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Quilometragem final:"
        '
        'txtinicio
        '
        Me.txtinicio.Location = New System.Drawing.Point(213, 289)
        Me.txtinicio.Name = "txtinicio"
        Me.txtinicio.Size = New System.Drawing.Size(281, 20)
        Me.txtinicio.TabIndex = 6
        '
        'txtentrega
        '
        Me.txtentrega.Location = New System.Drawing.Point(213, 333)
        Me.txtentrega.Name = "txtentrega"
        Me.txtentrega.Size = New System.Drawing.Size(281, 20)
        Me.txtentrega.TabIndex = 7
        '
        'kinicio
        '
        Me.kinicio.Location = New System.Drawing.Point(213, 387)
        Me.kinicio.Name = "kinicio"
        Me.kinicio.Size = New System.Drawing.Size(115, 20)
        Me.kinicio.TabIndex = 8
        '
        'kfim
        '
        Me.kfim.Location = New System.Drawing.Point(213, 447)
        Me.kfim.Name = "kfim"
        Me.kfim.Size = New System.Drawing.Size(115, 20)
        Me.kfim.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(327, 493)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Dados de Pagamento"
        '
        'lblNdias
        '
        Me.lblNdias.AutoSize = True
        Me.lblNdias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNdias.Location = New System.Drawing.Point(45, 553)
        Me.lblNdias.Name = "lblNdias"
        Me.lblNdias.Size = New System.Drawing.Size(18, 15)
        Me.lblNdias.TabIndex = 11
        Me.lblNdias.Text = "..."
        '
        'lblPagamento
        '
        Me.lblPagamento.AutoSize = True
        Me.lblPagamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPagamento.Location = New System.Drawing.Point(496, 553)
        Me.lblPagamento.Name = "lblPagamento"
        Me.lblPagamento.Size = New System.Drawing.Size(18, 15)
        Me.lblPagamento.TabIndex = 12
        Me.lblPagamento.Text = "..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(210, 553)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Nº de dias - 35€ por dia"
        '
        'lblnkn
        '
        Me.lblnkn.AutoSize = True
        Me.lblnkn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblnkn.Location = New System.Drawing.Point(45, 628)
        Me.lblnkn.Name = "lblnkn"
        Me.lblnkn.Size = New System.Drawing.Size(18, 15)
        Me.lblnkn.TabIndex = 14
        Me.lblnkn.Text = "..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(210, 628)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "KM's @ 0.10 5€ preço total ="
        '
        'lblPagamentoKM
        '
        Me.lblPagamentoKM.AutoSize = True
        Me.lblPagamentoKM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPagamentoKM.Location = New System.Drawing.Point(496, 626)
        Me.lblPagamentoKM.Name = "lblPagamentoKM"
        Me.lblPagamentoKM.Size = New System.Drawing.Size(18, 15)
        Me.lblPagamentoKM.TabIndex = 16
        Me.lblPagamentoKM.Text = "..."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(210, 701)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Total a Pagar:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(496, 701)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(18, 15)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.Text = "..."
        '
        'Btncalcular
        '
        Me.Btncalcular.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btncalcular.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.Btncalcular.FlatAppearance.BorderSize = 5
        Me.Btncalcular.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btncalcular.Location = New System.Drawing.Point(45, 770)
        Me.Btncalcular.Name = "Btncalcular"
        Me.Btncalcular.Size = New System.Drawing.Size(106, 30)
        Me.Btncalcular.TabIndex = 19
        Me.Btncalcular.Text = "Calcular"
        Me.Btncalcular.UseVisualStyleBackColor = False
        '
        'Btnlimpar
        '
        Me.Btnlimpar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnlimpar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.Btnlimpar.FlatAppearance.BorderSize = 5
        Me.Btnlimpar.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnlimpar.Location = New System.Drawing.Point(331, 770)
        Me.Btnlimpar.Name = "Btnlimpar"
        Me.Btnlimpar.Size = New System.Drawing.Size(106, 30)
        Me.Btnlimpar.TabIndex = 20
        Me.Btnlimpar.Text = "Limpar"
        Me.Btnlimpar.UseVisualStyleBackColor = False
        '
        'Btnsair
        '
        Me.Btnsair.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnsair.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.Btnsair.FlatAppearance.BorderSize = 5
        Me.Btnsair.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsair.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnsair.Location = New System.Drawing.Point(608, 770)
        Me.Btnsair.Name = "Btnsair"
        Me.Btnsair.Size = New System.Drawing.Size(106, 30)
        Me.Btnsair.TabIndex = 21
        Me.Btnsair.Text = "Sair"
        Me.Btnsair.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 856)
        Me.Controls.Add(Me.Btnsair)
        Me.Controls.Add(Me.Btnlimpar)
        Me.Controls.Add(Me.Btncalcular)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblPagamentoKM)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblnkn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblPagamento)
        Me.Controls.Add(Me.lblNdias)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.kfim)
        Me.Controls.Add(Me.kinicio)
        Me.Controls.Add(Me.txtentrega)
        Me.Controls.Add(Me.txtinicio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtinicio As TextBox
    Friend WithEvents txtentrega As TextBox
    Friend WithEvents kinicio As TextBox
    Friend WithEvents kfim As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblNdias As Label
    Friend WithEvents lblPagamento As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblnkn As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPagamentoKM As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Btncalcular As Button
    Friend WithEvents Btnlimpar As Button
    Friend WithEvents Btnsair As Button
End Class
