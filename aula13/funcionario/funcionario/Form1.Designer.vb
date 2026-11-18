<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        nome = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtnome = New TextBox()
        txtcargp = New TextBox()
        txtsalario = New TextBox()
        txttotal = New TextBox()
        btnsalvar = New Button()
        SuspendLayout()
        ' 
        ' nome
        ' 
        nome.AutoSize = True
        nome.Location = New Point(47, 36)
        nome.Name = "nome"
        nome.Size = New Size(38, 15)
        nome.TabIndex = 0
        nome.Text = "nome"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 15)
        Label2.TabIndex = 0
        Label2.Text = "cargo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 0
        Label3.Text = "salario"
        ' 
        ' txtnome
        ' 
        txtnome.Location = New Point(94, 28)
        txtnome.Name = "txtnome"
        txtnome.Size = New Size(191, 23)
        txtnome.TabIndex = 1
        ' 
        ' txtcargp
        ' 
        txtcargp.Location = New Point(94, 60)
        txtcargp.Name = "txtcargp"
        txtcargp.Size = New Size(191, 23)
        txtcargp.TabIndex = 1
        ' 
        ' txtsalario
        ' 
        txtsalario.Location = New Point(94, 89)
        txtsalario.Name = "txtsalario"
        txtsalario.Size = New Size(115, 23)
        txtsalario.TabIndex = 1
        ' 
        ' txttotal
        ' 
        txttotal.Location = New Point(47, 118)
        txttotal.Multiline = True
        txttotal.Name = "txttotal"
        txttotal.Size = New Size(292, 157)
        txttotal.TabIndex = 1
        ' 
        ' btnsalvar
        ' 
        btnsalvar.Image = My.Resources.Resources.enveolpe_ico
        btnsalvar.ImageAlign = ContentAlignment.TopCenter
        btnsalvar.Location = New Point(288, 28)
        btnsalvar.Name = "btnsalvar"
        btnsalvar.Size = New Size(51, 55)
        btnsalvar.TabIndex = 2
        btnsalvar.Text = "salvar"
        btnsalvar.TextAlign = ContentAlignment.BottomCenter
        btnsalvar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(395, 305)
        Controls.Add(btnsalvar)
        Controls.Add(txttotal)
        Controls.Add(txtsalario)
        Controls.Add(txtcargp)
        Controls.Add(txtnome)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(nome)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents nome As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnome As TextBox
    Friend WithEvents txtcargp As TextBox
    Friend WithEvents txtsalario As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btnsalvar As Button

End Class
