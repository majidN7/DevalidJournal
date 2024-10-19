<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmApropos
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmApropos))
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        MaterialMultiLineTextBox1 = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        SuspendLayout()
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(261, 429)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(161, 36)
        MaterialButton1.TabIndex = 0
        MaterialButton1.Text = "Fenetre Principal"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' MaterialButton2
        ' 
        MaterialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton2.Depth = 0
        MaterialButton2.HighEmphasis = True
        MaterialButton2.Icon = Nothing
        MaterialButton2.Location = New Point(525, 429)
        MaterialButton2.Margin = New Padding(4, 6, 4, 6)
        MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton2.Name = "MaterialButton2"
        MaterialButton2.NoAccentTextColor = Color.Empty
        MaterialButton2.Size = New Size(81, 36)
        MaterialButton2.TabIndex = 1
        MaterialButton2.Text = "Quitter"
        MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton2.UseAccentColor = False
        MaterialButton2.UseVisualStyleBackColor = True
        ' 
        ' MaterialMultiLineTextBox1
        ' 
        MaterialMultiLineTextBox1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialMultiLineTextBox1.BorderStyle = BorderStyle.None
        MaterialMultiLineTextBox1.Depth = 0
        MaterialMultiLineTextBox1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialMultiLineTextBox1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialMultiLineTextBox1.Location = New Point(15, 86)
        MaterialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialMultiLineTextBox1.Name = "MaterialMultiLineTextBox1"
        MaterialMultiLineTextBox1.Size = New Size(1109, 334)
        MaterialMultiLineTextBox1.TabIndex = 2
        MaterialMultiLineTextBox1.Text = resources.GetString("MaterialMultiLineTextBox1.Text")
        ' 
        ' FrmApropos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1130, 492)
        Controls.Add(MaterialMultiLineTextBox1)
        Controls.Add(MaterialButton2)
        Controls.Add(MaterialButton1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FrmApropos"
        Text = "A propos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialMultiLineTextBox1 As MaterialSkin.Controls.MaterialMultiLineTextBox
End Class
