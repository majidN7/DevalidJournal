<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipale
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipale))
        Label1 = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        MenuStrip1 = New MenuStrip()
        FichierToolStripMenuItem = New ToolStripMenuItem()
        OuvrirToolStripMenuItem = New ToolStripMenuItem()
        FermerToolStripMenuItem = New ToolStripMenuItem()
        AProposToolStripMenuItem = New ToolStripMenuItem()
        AProposToolStripMenuItem1 = New ToolStripMenuItem()
        GuideToolStripMenuItem = New ToolStripMenuItem()
        Label3 = New Label()
        Label4 = New Label()
        LblDatabase = New Label()
        lblServeur = New Label()
        LinkLabel1 = New LinkLabel()
        Label5 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        BtnCloturer = New MaterialSkin.Controls.MaterialButton()
        BtnDecolture = New MaterialSkin.Controls.MaterialButton()
        List_Mois = New MaterialSkin.Controls.MaterialComboBox()
        List_JNL = New MaterialSkin.Controls.MaterialComboBox()
        BtnRechrecher = New MaterialSkin.Controls.MaterialButton()
        BtnReintialiser = New MaterialSkin.Controls.MaterialButton()
        MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(76, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 23)
        Label1.TabIndex = 2
        Label1.Text = "Mois"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(76, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 23)
        Label2.TabIndex = 3
        Label2.Text = "Journal"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.InfoText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 225)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(893, 237)
        DataGridView1.TabIndex = 6
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FichierToolStripMenuItem, AProposToolStripMenuItem})
        MenuStrip1.Location = New Point(3, 64)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(980, 28)
        MenuStrip1.TabIndex = 8
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FichierToolStripMenuItem
        ' 
        FichierToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OuvrirToolStripMenuItem, FermerToolStripMenuItem})
        FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        FichierToolStripMenuItem.Size = New Size(66, 24)
        FichierToolStripMenuItem.Text = "Fichier"
        ' 
        ' OuvrirToolStripMenuItem
        ' 
        OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        OuvrirToolStripMenuItem.Size = New Size(138, 26)
        OuvrirToolStripMenuItem.Text = "Ouvrir"
        ' 
        ' FermerToolStripMenuItem
        ' 
        FermerToolStripMenuItem.Name = "FermerToolStripMenuItem"
        FermerToolStripMenuItem.Size = New Size(138, 26)
        FermerToolStripMenuItem.Text = "Fermer"
        ' 
        ' AProposToolStripMenuItem
        ' 
        AProposToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AProposToolStripMenuItem1, GuideToolStripMenuItem})
        AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        AProposToolStripMenuItem.Size = New Size(54, 24)
        AProposToolStripMenuItem.Text = "Aide"
        ' 
        ' AProposToolStripMenuItem1
        ' 
        AProposToolStripMenuItem1.Name = "AProposToolStripMenuItem1"
        AProposToolStripMenuItem1.Size = New Size(153, 26)
        AProposToolStripMenuItem1.Text = "A propos"
        ' 
        ' GuideToolStripMenuItem
        ' 
        GuideToolStripMenuItem.Name = "GuideToolStripMenuItem"
        GuideToolStripMenuItem.Size = New Size(153, 26)
        GuideToolStripMenuItem.Text = "Guide"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(7, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 23)
        Label3.TabIndex = 9
        Label3.Text = "Serveur : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(230, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 23)
        Label4.TabIndex = 10
        Label4.Text = "Base de donées :"
        ' 
        ' LblDatabase
        ' 
        LblDatabase.AutoSize = True
        LblDatabase.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        LblDatabase.Location = New Point(362, 19)
        LblDatabase.Name = "LblDatabase"
        LblDatabase.Size = New Size(24, 23)
        LblDatabase.TabIndex = 11
        LblDatabase.Text = """"""
        ' 
        ' lblServeur
        ' 
        lblServeur.AutoSize = True
        lblServeur.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblServeur.Location = New Point(86, 18)
        lblServeur.Name = "lblServeur"
        lblServeur.Size = New Size(24, 23)
        lblServeur.TabIndex = 12
        lblServeur.Text = """"""
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(12, 23)
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
        ' Panel1
        ' 
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label5)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(3, 570)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(980, 50)
        Panel1.TabIndex = 13
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(BtnCloturer)
        Panel2.Controls.Add(BtnDecolture)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(lblServeur)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(LblDatabase)
        Panel2.Location = New Point(12, 483)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(893, 59)
        Panel2.TabIndex = 14
        ' 
        ' BtnCloturer
        ' 
        BtnCloturer.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnCloturer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnCloturer.Depth = 0
        BtnCloturer.HighEmphasis = True
        BtnCloturer.Icon = Nothing
        BtnCloturer.Location = New Point(595, 12)
        BtnCloturer.Margin = New Padding(4, 6, 4, 6)
        BtnCloturer.MouseState = MaterialSkin.MouseState.HOVER
        BtnCloturer.Name = "BtnCloturer"
        BtnCloturer.NoAccentTextColor = Color.Empty
        BtnCloturer.Size = New Size(117, 36)
        BtnCloturer.TabIndex = 14
        BtnCloturer.Text = "Déclôturer"
        BtnCloturer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnCloturer.UseAccentColor = False
        BtnCloturer.UseVisualStyleBackColor = True
        ' 
        ' BtnDecolture
        ' 
        BtnDecolture.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnDecolture.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnDecolture.Depth = 0
        BtnDecolture.HighEmphasis = True
        BtnDecolture.Icon = Nothing
        BtnDecolture.Location = New Point(736, 12)
        BtnDecolture.Margin = New Padding(4, 6, 4, 6)
        BtnDecolture.MouseState = MaterialSkin.MouseState.HOVER
        BtnDecolture.Name = "BtnDecolture"
        BtnDecolture.NoAccentTextColor = Color.Empty
        BtnDecolture.Size = New Size(94, 36)
        BtnDecolture.TabIndex = 13
        BtnDecolture.Text = "CLOTURER"
        BtnDecolture.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnDecolture.UseAccentColor = False
        BtnDecolture.UseVisualStyleBackColor = True
        ' 
        ' List_Mois
        ' 
        List_Mois.AutoResize = False
        List_Mois.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        List_Mois.Depth = 0
        List_Mois.DrawMode = DrawMode.OwnerDrawVariable
        List_Mois.DropDownHeight = 174
        List_Mois.DropDownStyle = ComboBoxStyle.DropDownList
        List_Mois.DropDownWidth = 121
        List_Mois.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        List_Mois.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        List_Mois.FormattingEnabled = True
        List_Mois.IntegralHeight = False
        List_Mois.ItemHeight = 43
        List_Mois.Location = New Point(206, 96)
        List_Mois.MaxDropDownItems = 4
        List_Mois.MouseState = MaterialSkin.MouseState.OUT
        List_Mois.Name = "List_Mois"
        List_Mois.Size = New Size(389, 49)
        List_Mois.StartIndex = 0
        List_Mois.TabIndex = 15
        ' 
        ' List_JNL
        ' 
        List_JNL.AutoResize = False
        List_JNL.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        List_JNL.Depth = 0
        List_JNL.DrawMode = DrawMode.OwnerDrawVariable
        List_JNL.DropDownHeight = 174
        List_JNL.DropDownStyle = ComboBoxStyle.DropDownList
        List_JNL.DropDownWidth = 121
        List_JNL.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        List_JNL.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        List_JNL.FormattingEnabled = True
        List_JNL.IntegralHeight = False
        List_JNL.ItemHeight = 43
        List_JNL.Location = New Point(206, 165)
        List_JNL.MaxDropDownItems = 4
        List_JNL.MouseState = MaterialSkin.MouseState.OUT
        List_JNL.Name = "List_JNL"
        List_JNL.Size = New Size(389, 49)
        List_JNL.StartIndex = 0
        List_JNL.TabIndex = 17
        ' 
        ' BtnRechrecher
        ' 
        BtnRechrecher.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnRechrecher.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnRechrecher.Depth = 0
        BtnRechrecher.HighEmphasis = True
        BtnRechrecher.Icon = Nothing
        BtnRechrecher.Location = New Point(729, 109)
        BtnRechrecher.Margin = New Padding(4, 6, 4, 6)
        BtnRechrecher.MouseState = MaterialSkin.MouseState.HOVER
        BtnRechrecher.Name = "BtnRechrecher"
        BtnRechrecher.NoAccentTextColor = Color.Empty
        BtnRechrecher.Size = New Size(115, 36)
        BtnRechrecher.TabIndex = 18
        BtnRechrecher.Text = "Rechercher"
        BtnRechrecher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnRechrecher.UseAccentColor = False
        BtnRechrecher.UseVisualStyleBackColor = True
        ' 
        ' BtnReintialiser
        ' 
        BtnReintialiser.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnReintialiser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnReintialiser.Depth = 0
        BtnReintialiser.HighEmphasis = True
        BtnReintialiser.Icon = Nothing
        BtnReintialiser.Location = New Point(729, 178)
        BtnReintialiser.Margin = New Padding(4, 6, 4, 6)
        BtnReintialiser.MouseState = MaterialSkin.MouseState.HOVER
        BtnReintialiser.Name = "BtnReintialiser"
        BtnReintialiser.NoAccentTextColor = Color.Empty
        BtnReintialiser.Size = New Size(115, 36)
        BtnReintialiser.TabIndex = 19
        BtnReintialiser.Text = "Réintialiser"
        BtnReintialiser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnReintialiser.UseAccentColor = False
        BtnReintialiser.UseVisualStyleBackColor = True
        ' 
        ' MaterialDivider1
        ' 
        MaterialDivider1.BackColor = Color.FromArgb(CByte(30), CByte(0), CByte(0), CByte(0))
        MaterialDivider1.Depth = 0
        MaterialDivider1.Location = New Point(-2, 561)
        MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialDivider1.Name = "MaterialDivider1"
        MaterialDivider1.Size = New Size(994, 10)
        MaterialDivider1.TabIndex = 20
        MaterialDivider1.Text = "MaterialDivider1"
        ' 
        ' FrmPrincipale
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(986, 623)
        Controls.Add(MaterialDivider1)
        Controls.Add(BtnReintialiser)
        Controls.Add(BtnRechrecher)
        Controls.Add(List_JNL)
        Controls.Add(List_Mois)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        HelpButton = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "FrmPrincipale"
        Text = "Decolturer Journaux Sage 100"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnDecloturer As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FermerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GuideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblDatabase As Label
    Friend WithEvents lblServeur As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents List_Mois As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents List_JNL As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents BtnRechrecher As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BtnReintialiser As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BtnDecolture As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents BtnCloturer As MaterialSkin.Controls.MaterialButton


End Class
