Imports MaterialSkin

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCnx
    ' Inherits System.Windows.Forms.Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCnx))
        GroupBox1 = New GroupBox()
        TxtMdp = New TextBox()
        TxtUser = New TextBox()
        TxtDatabase = New TextBox()
        TxtServeur = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        LinkLabel1 = New LinkLabel()
        Label5 = New Label()
        BtnConnecter = New Controls.MaterialButton()
        BtnQuitter = New Controls.MaterialButton()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TxtMdp)
        GroupBox1.Controls.Add(TxtUser)
        GroupBox1.Controls.Add(TxtDatabase)
        GroupBox1.Controls.Add(TxtServeur)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 81)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(807, 243)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Paramétrage Serveur"
        ' 
        ' TxtMdp
        ' 
        TxtMdp.BorderStyle = BorderStyle.FixedSingle
        TxtMdp.Location = New Point(301, 181)
        TxtMdp.Name = "TxtMdp"
        TxtMdp.PasswordChar = "*"c
        TxtMdp.Size = New Size(301, 27)
        TxtMdp.TabIndex = 17
        ' 
        ' TxtUser
        ' 
        TxtUser.Location = New Point(301, 132)
        TxtUser.Name = "TxtUser"
        TxtUser.Size = New Size(301, 27)
        TxtUser.TabIndex = 16
        ' 
        ' TxtDatabase
        ' 
        TxtDatabase.Location = New Point(301, 83)
        TxtDatabase.Name = "TxtDatabase"
        TxtDatabase.Size = New Size(301, 27)
        TxtDatabase.TabIndex = 15
        ' 
        ' TxtServeur
        ' 
        TxtServeur.BorderStyle = BorderStyle.FixedSingle
        TxtServeur.Location = New Point(301, 34)
        TxtServeur.Name = "TxtServeur"
        TxtServeur.Size = New Size(301, 27)
        TxtServeur.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label4.Location = New Point(184, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 23)
        Label4.TabIndex = 13
        Label4.Text = "Mot de passe"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(210, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 23)
        Label3.TabIndex = 12
        Label3.Text = "Utilisateur"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(158, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 23)
        Label2.TabIndex = 11
        Label2.Text = "Base de données"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(193, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 23)
        Label1.TabIndex = 10
        Label1.Text = "Serveur SQL"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label5)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(3, 397)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(850, 50)
        Panel1.TabIndex = 11
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(12, 21)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(156, 20)
        LinkLabel1.TabIndex = 1
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "http://www.itmaps.ma"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 5)
        Label5.Name = "Label5"
        Label5.Size = New Size(318, 20)
        Label5.TabIndex = 0
        Label5.Text = "Pour plus d'information veuillez nous contacter"
        ' 
        ' BtnConnecter
        ' 
        BtnConnecter.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnConnecter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnConnecter.Depth = 0
        BtnConnecter.HighEmphasis = True
        BtnConnecter.Icon = Nothing
        BtnConnecter.Location = New Point(354, 333)
        BtnConnecter.Margin = New Padding(4, 6, 4, 6)
        BtnConnecter.MouseState = MouseState.HOVER
        BtnConnecter.Name = "BtnConnecter"
        BtnConnecter.NoAccentTextColor = Color.Empty
        BtnConnecter.Size = New Size(128, 36)
        BtnConnecter.TabIndex = 12
        BtnConnecter.Text = "Se Connecter"
        BtnConnecter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnConnecter.UseAccentColor = False
        BtnConnecter.UseVisualStyleBackColor = True
        ' 
        ' BtnQuitter
        ' 
        BtnQuitter.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnQuitter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnQuitter.Depth = 0
        BtnQuitter.HighEmphasis = True
        BtnQuitter.Icon = Nothing
        BtnQuitter.Location = New Point(533, 333)
        BtnQuitter.Margin = New Padding(4, 6, 4, 6)
        BtnQuitter.MouseState = MouseState.HOVER
        BtnQuitter.Name = "BtnQuitter"
        BtnQuitter.NoAccentTextColor = Color.Empty
        BtnQuitter.Size = New Size(81, 36)
        BtnQuitter.TabIndex = 13
        BtnQuitter.Text = "Quitter"
        BtnQuitter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnQuitter.UseAccentColor = False
        BtnQuitter.UseVisualStyleBackColor = True
        ' 
        ' FrmCnx
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(856, 450)
        Controls.Add(BtnQuitter)
        Controls.Add(BtnConnecter)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FrmCnx"
        Text = "Connexion"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtMdp As TextBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents TxtDatabase As TextBox
    Friend WithEvents TxtServeur As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents BtnConnecter As Controls.MaterialButton
    Friend WithEvents BtnQuitter As Controls.MaterialButton
End Class
