<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SC_Main = New System.Windows.Forms.SplitContainer()
        Me.GB_Source = New System.Windows.Forms.GroupBox()
        Me.SC_Source = New System.Windows.Forms.SplitContainer()
        Me.GB_Source_Data = New System.Windows.Forms.GroupBox()
        Me.BTN_Source_Data_UseHelpBot = New System.Windows.Forms.Button()
        Me.BTN_Source_Data_Previous = New System.Windows.Forms.Button()
        Me.BTN_Source_Data_Next = New System.Windows.Forms.Button()
        Me.BTN_Source_Data_Add = New System.Windows.Forms.Button()
        Me.GB_Source_Data_Content = New System.Windows.Forms.GroupBox()
        Me.RTB_Source_Data_Content = New System.Windows.Forms.RichTextBox()
        Me.GB_Source_Data_Id = New System.Windows.Forms.GroupBox()
        Me.TB_Source_Data_Id = New System.Windows.Forms.TextBox()
        Me.GB_Source_List = New System.Windows.Forms.GroupBox()
        Me.LB_Source_List = New System.Windows.Forms.ListBox()
        Me.CMS_LB_Source_List = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMS_LB_Source_List_BTN_Copie = New System.Windows.Forms.ToolStripMenuItem()
        Me.LBL_Source_List_Selected = New System.Windows.Forms.Label()
        Me.LBL_Source_List_Total = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBL_Source_Encoding = New System.Windows.Forms.Label()
        Me.CB_Source_Encoding = New System.Windows.Forms.ComboBox()
        Me.SS_Source = New System.Windows.Forms.StatusStrip()
        Me.SS_Source_LBL_Path = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MS_Source = New System.Windows.Forms.MenuStrip()
        Me.MS_Source_BTN_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_Source_BTN_File_New = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_Source_BTN_File_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.GB_Dest = New System.Windows.Forms.GroupBox()
        Me.SC_Dest = New System.Windows.Forms.SplitContainer()
        Me.GB_Dest_Data = New System.Windows.Forms.GroupBox()
        Me.BTN_Dest_Data_UseSource = New System.Windows.Forms.Button()
        Me.BTN_Dest_Data_UseHelpBot = New System.Windows.Forms.Button()
        Me.BTN_Dest_Data_Delete = New System.Windows.Forms.Button()
        Me.BTN_Dest_Data_Modify = New System.Windows.Forms.Button()
        Me.BTN_Dest_Data_Add = New System.Windows.Forms.Button()
        Me.GB_Dest_Data_Content = New System.Windows.Forms.GroupBox()
        Me.RTB_Dest_Data_Content = New System.Windows.Forms.RichTextBox()
        Me.GB_Dest_Data_Id = New System.Windows.Forms.GroupBox()
        Me.TB_Dest_Data_Id = New System.Windows.Forms.TextBox()
        Me.GB_Dest_List = New System.Windows.Forms.GroupBox()
        Me.LB_Dest_List = New System.Windows.Forms.ListBox()
        Me.CMS_LB_Dest_List = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMS_LB_Dest_List_BTN_Copie = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS_LB_Dest_List_BTN_Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.LBL_Dest_List_Selected = New System.Windows.Forms.Label()
        Me.LBL_Dest_List_Total = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBL_Dest_Encoding = New System.Windows.Forms.Label()
        Me.CB_Dest_Encoding = New System.Windows.Forms.ComboBox()
        Me.SS_Dest = New System.Windows.Forms.StatusStrip()
        Me.SS_Dest_LBL_Path = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MS_Dest = New System.Windows.Forms.MenuStrip()
        Me.MS_Dest_BTN_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_Dest_BTN_File_New = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_Dest_BTN_File_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_Dest_BTN_File_Save = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_Dest_BTN_File_SaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_Dest_TB_Author = New System.Windows.Forms.ToolStripTextBox()
        Me.MS_Dest_BTN_Find = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_MainMenu = New System.Windows.Forms.MenuStrip()
        Me.MS_MainMenu_BTN_HelpBot = New System.Windows.Forms.ToolStripMenuItem()
        Me.CB_MainMenu_Language = New System.Windows.Forms.ToolStripComboBox()
        CType(Me.SC_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SC_Main.Panel1.SuspendLayout()
        Me.SC_Main.Panel2.SuspendLayout()
        Me.SC_Main.SuspendLayout()
        Me.GB_Source.SuspendLayout()
        CType(Me.SC_Source, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SC_Source.Panel1.SuspendLayout()
        Me.SC_Source.Panel2.SuspendLayout()
        Me.SC_Source.SuspendLayout()
        Me.GB_Source_Data.SuspendLayout()
        Me.GB_Source_Data_Content.SuspendLayout()
        Me.GB_Source_Data_Id.SuspendLayout()
        Me.GB_Source_List.SuspendLayout()
        Me.CMS_LB_Source_List.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SS_Source.SuspendLayout()
        Me.MS_Source.SuspendLayout()
        Me.GB_Dest.SuspendLayout()
        CType(Me.SC_Dest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SC_Dest.Panel1.SuspendLayout()
        Me.SC_Dest.Panel2.SuspendLayout()
        Me.SC_Dest.SuspendLayout()
        Me.GB_Dest_Data.SuspendLayout()
        Me.GB_Dest_Data_Content.SuspendLayout()
        Me.GB_Dest_Data_Id.SuspendLayout()
        Me.GB_Dest_List.SuspendLayout()
        Me.CMS_LB_Dest_List.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SS_Dest.SuspendLayout()
        Me.MS_Dest.SuspendLayout()
        Me.MS_MainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'SC_Main
        '
        Me.SC_Main.BackColor = System.Drawing.SystemColors.Control
        Me.SC_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SC_Main.Location = New System.Drawing.Point(0, 32)
        Me.SC_Main.Name = "SC_Main"
        '
        'SC_Main.Panel1
        '
        Me.SC_Main.Panel1.Controls.Add(Me.GB_Source)
        Me.SC_Main.Panel1MinSize = 0
        '
        'SC_Main.Panel2
        '
        Me.SC_Main.Panel2.Controls.Add(Me.GB_Dest)
        Me.SC_Main.Panel2MinSize = 0
        Me.SC_Main.Size = New System.Drawing.Size(1264, 649)
        Me.SC_Main.SplitterDistance = 545
        Me.SC_Main.SplitterWidth = 16
        Me.SC_Main.TabIndex = 0
        '
        'GB_Source
        '
        Me.GB_Source.Controls.Add(Me.SC_Source)
        Me.GB_Source.Controls.Add(Me.Panel1)
        Me.GB_Source.Controls.Add(Me.SS_Source)
        Me.GB_Source.Controls.Add(Me.MS_Source)
        Me.GB_Source.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Source.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GB_Source.Location = New System.Drawing.Point(0, 0)
        Me.GB_Source.Name = "GB_Source"
        Me.GB_Source.Size = New System.Drawing.Size(545, 649)
        Me.GB_Source.TabIndex = 0
        Me.GB_Source.TabStop = False
        Me.GB_Source.Text = "Source"
        '
        'SC_Source
        '
        Me.SC_Source.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SC_Source.Location = New System.Drawing.Point(3, 77)
        Me.SC_Source.Name = "SC_Source"
        Me.SC_Source.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SC_Source.Panel1
        '
        Me.SC_Source.Panel1.Controls.Add(Me.GB_Source_Data)
        '
        'SC_Source.Panel2
        '
        Me.SC_Source.Panel2.Controls.Add(Me.GB_Source_List)
        Me.SC_Source.Size = New System.Drawing.Size(539, 564)
        Me.SC_Source.SplitterDistance = 278
        Me.SC_Source.SplitterWidth = 10
        Me.SC_Source.TabIndex = 6
        '
        'GB_Source_Data
        '
        Me.GB_Source_Data.Controls.Add(Me.BTN_Source_Data_UseHelpBot)
        Me.GB_Source_Data.Controls.Add(Me.BTN_Source_Data_Previous)
        Me.GB_Source_Data.Controls.Add(Me.BTN_Source_Data_Next)
        Me.GB_Source_Data.Controls.Add(Me.BTN_Source_Data_Add)
        Me.GB_Source_Data.Controls.Add(Me.GB_Source_Data_Content)
        Me.GB_Source_Data.Controls.Add(Me.GB_Source_Data_Id)
        Me.GB_Source_Data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Source_Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GB_Source_Data.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GB_Source_Data.Location = New System.Drawing.Point(0, 0)
        Me.GB_Source_Data.Name = "GB_Source_Data"
        Me.GB_Source_Data.Size = New System.Drawing.Size(539, 278)
        Me.GB_Source_Data.TabIndex = 5
        Me.GB_Source_Data.TabStop = False
        Me.GB_Source_Data.Text = "Données"
        '
        'BTN_Source_Data_UseHelpBot
        '
        Me.BTN_Source_Data_UseHelpBot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Source_Data_UseHelpBot.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BTN_Source_Data_UseHelpBot.Location = New System.Drawing.Point(280, 244)
        Me.BTN_Source_Data_UseHelpBot.Name = "BTN_Source_Data_UseHelpBot"
        Me.BTN_Source_Data_UseHelpBot.Size = New System.Drawing.Size(150, 27)
        Me.BTN_Source_Data_UseHelpBot.TabIndex = 11
        Me.BTN_Source_Data_UseHelpBot.Text = "Utiliser l'Aide-Bot"
        Me.BTN_Source_Data_UseHelpBot.UseVisualStyleBackColor = True
        '
        'BTN_Source_Data_Previous
        '
        Me.BTN_Source_Data_Previous.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Source_Data_Previous.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BTN_Source_Data_Previous.Location = New System.Drawing.Point(9, 244)
        Me.BTN_Source_Data_Previous.Name = "BTN_Source_Data_Previous"
        Me.BTN_Source_Data_Previous.Size = New System.Drawing.Size(100, 27)
        Me.BTN_Source_Data_Previous.TabIndex = 10
        Me.BTN_Source_Data_Previous.Text = "Précédent"
        Me.BTN_Source_Data_Previous.UseVisualStyleBackColor = True
        '
        'BTN_Source_Data_Next
        '
        Me.BTN_Source_Data_Next.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Source_Data_Next.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BTN_Source_Data_Next.Location = New System.Drawing.Point(115, 244)
        Me.BTN_Source_Data_Next.Name = "BTN_Source_Data_Next"
        Me.BTN_Source_Data_Next.Size = New System.Drawing.Size(100, 27)
        Me.BTN_Source_Data_Next.TabIndex = 9
        Me.BTN_Source_Data_Next.Text = "Suivant"
        Me.BTN_Source_Data_Next.UseVisualStyleBackColor = True
        '
        'BTN_Source_Data_Add
        '
        Me.BTN_Source_Data_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Source_Data_Add.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BTN_Source_Data_Add.Location = New System.Drawing.Point(436, 244)
        Me.BTN_Source_Data_Add.Name = "BTN_Source_Data_Add"
        Me.BTN_Source_Data_Add.Size = New System.Drawing.Size(100, 27)
        Me.BTN_Source_Data_Add.TabIndex = 8
        Me.BTN_Source_Data_Add.Text = "Ajouter"
        Me.BTN_Source_Data_Add.UseVisualStyleBackColor = True
        '
        'GB_Source_Data_Content
        '
        Me.GB_Source_Data_Content.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Source_Data_Content.Controls.Add(Me.RTB_Source_Data_Content)
        Me.GB_Source_Data_Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GB_Source_Data_Content.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GB_Source_Data_Content.Location = New System.Drawing.Point(9, 66)
        Me.GB_Source_Data_Content.Name = "GB_Source_Data_Content"
        Me.GB_Source_Data_Content.Size = New System.Drawing.Size(524, 173)
        Me.GB_Source_Data_Content.TabIndex = 7
        Me.GB_Source_Data_Content.TabStop = False
        Me.GB_Source_Data_Content.Text = "Contenu"
        '
        'RTB_Source_Data_Content
        '
        Me.RTB_Source_Data_Content.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTB_Source_Data_Content.DetectUrls = False
        Me.RTB_Source_Data_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTB_Source_Data_Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.RTB_Source_Data_Content.Location = New System.Drawing.Point(3, 19)
        Me.RTB_Source_Data_Content.Name = "RTB_Source_Data_Content"
        Me.RTB_Source_Data_Content.Size = New System.Drawing.Size(518, 151)
        Me.RTB_Source_Data_Content.TabIndex = 0
        Me.RTB_Source_Data_Content.Text = ""
        Me.RTB_Source_Data_Content.WordWrap = False
        '
        'GB_Source_Data_Id
        '
        Me.GB_Source_Data_Id.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Source_Data_Id.Controls.Add(Me.TB_Source_Data_Id)
        Me.GB_Source_Data_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GB_Source_Data_Id.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GB_Source_Data_Id.Location = New System.Drawing.Point(9, 22)
        Me.GB_Source_Data_Id.Name = "GB_Source_Data_Id"
        Me.GB_Source_Data_Id.Size = New System.Drawing.Size(524, 38)
        Me.GB_Source_Data_Id.TabIndex = 6
        Me.GB_Source_Data_Id.TabStop = False
        Me.GB_Source_Data_Id.Text = "ID"
        '
        'TB_Source_Data_Id
        '
        Me.TB_Source_Data_Id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Source_Data_Id.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TB_Source_Data_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TB_Source_Data_Id.Location = New System.Drawing.Point(3, 19)
        Me.TB_Source_Data_Id.Name = "TB_Source_Data_Id"
        Me.TB_Source_Data_Id.ReadOnly = True
        Me.TB_Source_Data_Id.Size = New System.Drawing.Size(518, 16)
        Me.TB_Source_Data_Id.TabIndex = 0
        Me.TB_Source_Data_Id.WordWrap = False
        '
        'GB_Source_List
        '
        Me.GB_Source_List.Controls.Add(Me.LB_Source_List)
        Me.GB_Source_List.Controls.Add(Me.LBL_Source_List_Selected)
        Me.GB_Source_List.Controls.Add(Me.LBL_Source_List_Total)
        Me.GB_Source_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Source_List.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GB_Source_List.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GB_Source_List.Location = New System.Drawing.Point(0, 0)
        Me.GB_Source_List.Name = "GB_Source_List"
        Me.GB_Source_List.Size = New System.Drawing.Size(539, 276)
        Me.GB_Source_List.TabIndex = 0
        Me.GB_Source_List.TabStop = False
        Me.GB_Source_List.Text = "Liste"
        '
        'LB_Source_List
        '
        Me.LB_Source_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LB_Source_List.ContextMenuStrip = Me.CMS_LB_Source_List
        Me.LB_Source_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LB_Source_List.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LB_Source_List.FormattingEnabled = True
        Me.LB_Source_List.ItemHeight = 16
        Me.LB_Source_List.Location = New System.Drawing.Point(3, 53)
        Me.LB_Source_List.Name = "LB_Source_List"
        Me.LB_Source_List.Size = New System.Drawing.Size(533, 220)
        Me.LB_Source_List.TabIndex = 2
        '
        'CMS_LB_Source_List
        '
        Me.CMS_LB_Source_List.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMS_LB_Source_List_BTN_Copie})
        Me.CMS_LB_Source_List.Name = "CMS_LB_Source_List"
        Me.CMS_LB_Source_List.Size = New System.Drawing.Size(110, 26)
        '
        'CMS_LB_Source_List_BTN_Copie
        '
        Me.CMS_LB_Source_List_BTN_Copie.Name = "CMS_LB_Source_List_BTN_Copie"
        Me.CMS_LB_Source_List_BTN_Copie.Size = New System.Drawing.Size(109, 22)
        Me.CMS_LB_Source_List_BTN_Copie.Text = "Copier"
        '
        'LBL_Source_List_Selected
        '
        Me.LBL_Source_List_Selected.AutoSize = True
        Me.LBL_Source_List_Selected.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBL_Source_List_Selected.Location = New System.Drawing.Point(3, 36)
        Me.LBL_Source_List_Selected.Name = "LBL_Source_List_Selected"
        Me.LBL_Source_List_Selected.Size = New System.Drawing.Size(102, 17)
        Me.LBL_Source_List_Selected.TabIndex = 1
        Me.LBL_Source_List_Selected.Text = "Sélectionné : 0"
        '
        'LBL_Source_List_Total
        '
        Me.LBL_Source_List_Total.AutoSize = True
        Me.LBL_Source_List_Total.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBL_Source_List_Total.Location = New System.Drawing.Point(3, 19)
        Me.LBL_Source_List_Total.Name = "LBL_Source_List_Total"
        Me.LBL_Source_List_Total.Size = New System.Drawing.Size(60, 17)
        Me.LBL_Source_List_Total.TabIndex = 0
        Me.LBL_Source_List_Total.Text = "Total : 0"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LBL_Source_Encoding)
        Me.Panel1.Controls.Add(Me.CB_Source_Encoding)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(539, 30)
        Me.Panel1.TabIndex = 7
        '
        'LBL_Source_Encoding
        '
        Me.LBL_Source_Encoding.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LBL_Source_Encoding.Location = New System.Drawing.Point(3, 5)
        Me.LBL_Source_Encoding.Name = "LBL_Source_Encoding"
        Me.LBL_Source_Encoding.Size = New System.Drawing.Size(125, 20)
        Me.LBL_Source_Encoding.TabIndex = 5
        Me.LBL_Source_Encoding.Text = "Encodage :"
        '
        'CB_Source_Encoding
        '
        Me.CB_Source_Encoding.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_Source_Encoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Source_Encoding.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CB_Source_Encoding.FormattingEnabled = True
        Me.CB_Source_Encoding.Location = New System.Drawing.Point(134, 3)
        Me.CB_Source_Encoding.Name = "CB_Source_Encoding"
        Me.CB_Source_Encoding.Size = New System.Drawing.Size(402, 24)
        Me.CB_Source_Encoding.TabIndex = 4
        '
        'SS_Source
        '
        Me.SS_Source.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SS_Source.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SS_Source_LBL_Path})
        Me.SS_Source.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.SS_Source.Location = New System.Drawing.Point(3, 641)
        Me.SS_Source.Name = "SS_Source"
        Me.SS_Source.Size = New System.Drawing.Size(539, 5)
        Me.SS_Source.SizingGrip = False
        Me.SS_Source.TabIndex = 3
        Me.SS_Source.Text = "Status"
        '
        'SS_Source_LBL_Path
        '
        Me.SS_Source_LBL_Path.Name = "SS_Source_LBL_Path"
        Me.SS_Source_LBL_Path.Size = New System.Drawing.Size(0, 0)
        '
        'MS_Source
        '
        Me.MS_Source.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MS_Source.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MS_Source_BTN_File})
        Me.MS_Source.Location = New System.Drawing.Point(3, 22)
        Me.MS_Source.Name = "MS_Source"
        Me.MS_Source.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MS_Source.Size = New System.Drawing.Size(539, 25)
        Me.MS_Source.TabIndex = 2
        Me.MS_Source.Text = "Menu"
        '
        'MS_Source_BTN_File
        '
        Me.MS_Source_BTN_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MS_Source_BTN_File_New, Me.MS_Source_BTN_File_Open})
        Me.MS_Source_BTN_File.Name = "MS_Source_BTN_File"
        Me.MS_Source_BTN_File.Size = New System.Drawing.Size(62, 21)
        Me.MS_Source_BTN_File.Text = "Fichier"
        '
        'MS_Source_BTN_File_New
        '
        Me.MS_Source_BTN_File_New.Name = "MS_Source_BTN_File_New"
        Me.MS_Source_BTN_File_New.Size = New System.Drawing.Size(133, 22)
        Me.MS_Source_BTN_File_New.Text = "Nouveau"
        '
        'MS_Source_BTN_File_Open
        '
        Me.MS_Source_BTN_File_Open.Name = "MS_Source_BTN_File_Open"
        Me.MS_Source_BTN_File_Open.Size = New System.Drawing.Size(133, 22)
        Me.MS_Source_BTN_File_Open.Text = "Ouvrir"
        '
        'GB_Dest
        '
        Me.GB_Dest.Controls.Add(Me.SC_Dest)
        Me.GB_Dest.Controls.Add(Me.Panel2)
        Me.GB_Dest.Controls.Add(Me.SS_Dest)
        Me.GB_Dest.Controls.Add(Me.MS_Dest)
        Me.GB_Dest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Dest.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GB_Dest.Location = New System.Drawing.Point(0, 0)
        Me.GB_Dest.Name = "GB_Dest"
        Me.GB_Dest.Size = New System.Drawing.Size(703, 649)
        Me.GB_Dest.TabIndex = 1
        Me.GB_Dest.TabStop = False
        Me.GB_Dest.Text = "Destination"
        '
        'SC_Dest
        '
        Me.SC_Dest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SC_Dest.Location = New System.Drawing.Point(3, 79)
        Me.SC_Dest.Name = "SC_Dest"
        Me.SC_Dest.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SC_Dest.Panel1
        '
        Me.SC_Dest.Panel1.Controls.Add(Me.GB_Dest_Data)
        '
        'SC_Dest.Panel2
        '
        Me.SC_Dest.Panel2.Controls.Add(Me.GB_Dest_List)
        Me.SC_Dest.Size = New System.Drawing.Size(697, 562)
        Me.SC_Dest.SplitterDistance = 275
        Me.SC_Dest.SplitterWidth = 10
        Me.SC_Dest.TabIndex = 7
        '
        'GB_Dest_Data
        '
        Me.GB_Dest_Data.Controls.Add(Me.BTN_Dest_Data_UseSource)
        Me.GB_Dest_Data.Controls.Add(Me.BTN_Dest_Data_UseHelpBot)
        Me.GB_Dest_Data.Controls.Add(Me.BTN_Dest_Data_Delete)
        Me.GB_Dest_Data.Controls.Add(Me.BTN_Dest_Data_Modify)
        Me.GB_Dest_Data.Controls.Add(Me.BTN_Dest_Data_Add)
        Me.GB_Dest_Data.Controls.Add(Me.GB_Dest_Data_Content)
        Me.GB_Dest_Data.Controls.Add(Me.GB_Dest_Data_Id)
        Me.GB_Dest_Data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Dest_Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GB_Dest_Data.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GB_Dest_Data.Location = New System.Drawing.Point(0, 0)
        Me.GB_Dest_Data.Name = "GB_Dest_Data"
        Me.GB_Dest_Data.Size = New System.Drawing.Size(697, 275)
        Me.GB_Dest_Data.TabIndex = 5
        Me.GB_Dest_Data.TabStop = False
        Me.GB_Dest_Data.Text = "Données"
        '
        'BTN_Dest_Data_UseSource
        '
        Me.BTN_Dest_Data_UseSource.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Dest_Data_UseSource.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BTN_Dest_Data_UseSource.Location = New System.Drawing.Point(9, 242)
        Me.BTN_Dest_Data_UseSource.Name = "BTN_Dest_Data_UseSource"
        Me.BTN_Dest_Data_UseSource.Size = New System.Drawing.Size(125, 27)
        Me.BTN_Dest_Data_UseSource.TabIndex = 13
        Me.BTN_Dest_Data_UseSource.Text = "Utiliser source"
        Me.BTN_Dest_Data_UseSource.UseVisualStyleBackColor = True
        '
        'BTN_Dest_Data_UseHelpBot
        '
        Me.BTN_Dest_Data_UseHelpBot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Dest_Data_UseHelpBot.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BTN_Dest_Data_UseHelpBot.Location = New System.Drawing.Point(435, 242)
        Me.BTN_Dest_Data_UseHelpBot.Name = "BTN_Dest_Data_UseHelpBot"
        Me.BTN_Dest_Data_UseHelpBot.Size = New System.Drawing.Size(150, 27)
        Me.BTN_Dest_Data_UseHelpBot.TabIndex = 12
        Me.BTN_Dest_Data_UseHelpBot.Text = "Utiliser l'Aide-Bot"
        Me.BTN_Dest_Data_UseHelpBot.UseVisualStyleBackColor = True
        '
        'BTN_Dest_Data_Delete
        '
        Me.BTN_Dest_Data_Delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Dest_Data_Delete.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BTN_Dest_Data_Delete.Location = New System.Drawing.Point(140, 242)
        Me.BTN_Dest_Data_Delete.Name = "BTN_Dest_Data_Delete"
        Me.BTN_Dest_Data_Delete.Size = New System.Drawing.Size(100, 27)
        Me.BTN_Dest_Data_Delete.TabIndex = 10
        Me.BTN_Dest_Data_Delete.Text = "Supprimer"
        Me.BTN_Dest_Data_Delete.UseVisualStyleBackColor = True
        '
        'BTN_Dest_Data_Modify
        '
        Me.BTN_Dest_Data_Modify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Dest_Data_Modify.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BTN_Dest_Data_Modify.Location = New System.Drawing.Point(591, 242)
        Me.BTN_Dest_Data_Modify.Name = "BTN_Dest_Data_Modify"
        Me.BTN_Dest_Data_Modify.Size = New System.Drawing.Size(100, 27)
        Me.BTN_Dest_Data_Modify.TabIndex = 9
        Me.BTN_Dest_Data_Modify.Text = "Modifier"
        Me.BTN_Dest_Data_Modify.UseVisualStyleBackColor = True
        '
        'BTN_Dest_Data_Add
        '
        Me.BTN_Dest_Data_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Dest_Data_Add.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BTN_Dest_Data_Add.Location = New System.Drawing.Point(246, 242)
        Me.BTN_Dest_Data_Add.Name = "BTN_Dest_Data_Add"
        Me.BTN_Dest_Data_Add.Size = New System.Drawing.Size(100, 27)
        Me.BTN_Dest_Data_Add.TabIndex = 8
        Me.BTN_Dest_Data_Add.Text = "Ajouter"
        Me.BTN_Dest_Data_Add.UseVisualStyleBackColor = True
        '
        'GB_Dest_Data_Content
        '
        Me.GB_Dest_Data_Content.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Dest_Data_Content.Controls.Add(Me.RTB_Dest_Data_Content)
        Me.GB_Dest_Data_Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GB_Dest_Data_Content.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GB_Dest_Data_Content.Location = New System.Drawing.Point(9, 66)
        Me.GB_Dest_Data_Content.Name = "GB_Dest_Data_Content"
        Me.GB_Dest_Data_Content.Size = New System.Drawing.Size(682, 170)
        Me.GB_Dest_Data_Content.TabIndex = 7
        Me.GB_Dest_Data_Content.TabStop = False
        Me.GB_Dest_Data_Content.Text = "Contenu"
        '
        'RTB_Dest_Data_Content
        '
        Me.RTB_Dest_Data_Content.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTB_Dest_Data_Content.DetectUrls = False
        Me.RTB_Dest_Data_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTB_Dest_Data_Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.RTB_Dest_Data_Content.Location = New System.Drawing.Point(3, 19)
        Me.RTB_Dest_Data_Content.Name = "RTB_Dest_Data_Content"
        Me.RTB_Dest_Data_Content.Size = New System.Drawing.Size(676, 148)
        Me.RTB_Dest_Data_Content.TabIndex = 0
        Me.RTB_Dest_Data_Content.Text = ""
        Me.RTB_Dest_Data_Content.WordWrap = False
        '
        'GB_Dest_Data_Id
        '
        Me.GB_Dest_Data_Id.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Dest_Data_Id.Controls.Add(Me.TB_Dest_Data_Id)
        Me.GB_Dest_Data_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GB_Dest_Data_Id.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GB_Dest_Data_Id.Location = New System.Drawing.Point(9, 22)
        Me.GB_Dest_Data_Id.Name = "GB_Dest_Data_Id"
        Me.GB_Dest_Data_Id.Size = New System.Drawing.Size(682, 38)
        Me.GB_Dest_Data_Id.TabIndex = 6
        Me.GB_Dest_Data_Id.TabStop = False
        Me.GB_Dest_Data_Id.Text = "ID"
        '
        'TB_Dest_Data_Id
        '
        Me.TB_Dest_Data_Id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Dest_Data_Id.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TB_Dest_Data_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TB_Dest_Data_Id.Location = New System.Drawing.Point(3, 19)
        Me.TB_Dest_Data_Id.Name = "TB_Dest_Data_Id"
        Me.TB_Dest_Data_Id.Size = New System.Drawing.Size(676, 16)
        Me.TB_Dest_Data_Id.TabIndex = 0
        Me.TB_Dest_Data_Id.WordWrap = False
        '
        'GB_Dest_List
        '
        Me.GB_Dest_List.Controls.Add(Me.LB_Dest_List)
        Me.GB_Dest_List.Controls.Add(Me.LBL_Dest_List_Selected)
        Me.GB_Dest_List.Controls.Add(Me.LBL_Dest_List_Total)
        Me.GB_Dest_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Dest_List.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GB_Dest_List.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GB_Dest_List.Location = New System.Drawing.Point(0, 0)
        Me.GB_Dest_List.Name = "GB_Dest_List"
        Me.GB_Dest_List.Size = New System.Drawing.Size(697, 277)
        Me.GB_Dest_List.TabIndex = 0
        Me.GB_Dest_List.TabStop = False
        Me.GB_Dest_List.Text = "Liste"
        '
        'LB_Dest_List
        '
        Me.LB_Dest_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LB_Dest_List.ContextMenuStrip = Me.CMS_LB_Dest_List
        Me.LB_Dest_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LB_Dest_List.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LB_Dest_List.FormattingEnabled = True
        Me.LB_Dest_List.ItemHeight = 16
        Me.LB_Dest_List.Location = New System.Drawing.Point(3, 53)
        Me.LB_Dest_List.Name = "LB_Dest_List"
        Me.LB_Dest_List.Size = New System.Drawing.Size(691, 221)
        Me.LB_Dest_List.TabIndex = 2
        '
        'CMS_LB_Dest_List
        '
        Me.CMS_LB_Dest_List.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMS_LB_Dest_List_BTN_Copie, Me.CMS_LB_Dest_List_BTN_Delete})
        Me.CMS_LB_Dest_List.Name = "CMS_LB_Dest_List"
        Me.CMS_LB_Dest_List.Size = New System.Drawing.Size(130, 48)
        '
        'CMS_LB_Dest_List_BTN_Copie
        '
        Me.CMS_LB_Dest_List_BTN_Copie.Name = "CMS_LB_Dest_List_BTN_Copie"
        Me.CMS_LB_Dest_List_BTN_Copie.Size = New System.Drawing.Size(129, 22)
        Me.CMS_LB_Dest_List_BTN_Copie.Text = "Copier"
        '
        'CMS_LB_Dest_List_BTN_Delete
        '
        Me.CMS_LB_Dest_List_BTN_Delete.Name = "CMS_LB_Dest_List_BTN_Delete"
        Me.CMS_LB_Dest_List_BTN_Delete.Size = New System.Drawing.Size(129, 22)
        Me.CMS_LB_Dest_List_BTN_Delete.Text = "Supprimer"
        '
        'LBL_Dest_List_Selected
        '
        Me.LBL_Dest_List_Selected.AutoSize = True
        Me.LBL_Dest_List_Selected.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBL_Dest_List_Selected.Location = New System.Drawing.Point(3, 36)
        Me.LBL_Dest_List_Selected.Name = "LBL_Dest_List_Selected"
        Me.LBL_Dest_List_Selected.Size = New System.Drawing.Size(102, 17)
        Me.LBL_Dest_List_Selected.TabIndex = 1
        Me.LBL_Dest_List_Selected.Text = "Sélectionné : 0"
        '
        'LBL_Dest_List_Total
        '
        Me.LBL_Dest_List_Total.AutoSize = True
        Me.LBL_Dest_List_Total.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBL_Dest_List_Total.Location = New System.Drawing.Point(3, 19)
        Me.LBL_Dest_List_Total.Name = "LBL_Dest_List_Total"
        Me.LBL_Dest_List_Total.Size = New System.Drawing.Size(60, 17)
        Me.LBL_Dest_List_Total.TabIndex = 0
        Me.LBL_Dest_List_Total.Text = "Total : 0"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LBL_Dest_Encoding)
        Me.Panel2.Controls.Add(Me.CB_Dest_Encoding)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(697, 30)
        Me.Panel2.TabIndex = 8
        '
        'LBL_Dest_Encoding
        '
        Me.LBL_Dest_Encoding.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LBL_Dest_Encoding.Location = New System.Drawing.Point(3, 5)
        Me.LBL_Dest_Encoding.Name = "LBL_Dest_Encoding"
        Me.LBL_Dest_Encoding.Size = New System.Drawing.Size(125, 20)
        Me.LBL_Dest_Encoding.TabIndex = 6
        Me.LBL_Dest_Encoding.Text = "Encodage :"
        '
        'CB_Dest_Encoding
        '
        Me.CB_Dest_Encoding.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_Dest_Encoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Dest_Encoding.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CB_Dest_Encoding.FormattingEnabled = True
        Me.CB_Dest_Encoding.Location = New System.Drawing.Point(134, 3)
        Me.CB_Dest_Encoding.Name = "CB_Dest_Encoding"
        Me.CB_Dest_Encoding.Size = New System.Drawing.Size(560, 24)
        Me.CB_Dest_Encoding.TabIndex = 5
        '
        'SS_Dest
        '
        Me.SS_Dest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SS_Dest.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SS_Dest_LBL_Path})
        Me.SS_Dest.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.SS_Dest.Location = New System.Drawing.Point(3, 641)
        Me.SS_Dest.Name = "SS_Dest"
        Me.SS_Dest.Size = New System.Drawing.Size(697, 5)
        Me.SS_Dest.SizingGrip = False
        Me.SS_Dest.TabIndex = 3
        Me.SS_Dest.Text = "Status"
        '
        'SS_Dest_LBL_Path
        '
        Me.SS_Dest_LBL_Path.Name = "SS_Dest_LBL_Path"
        Me.SS_Dest_LBL_Path.Size = New System.Drawing.Size(0, 0)
        '
        'MS_Dest
        '
        Me.MS_Dest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MS_Dest.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MS_Dest_BTN_File, Me.MS_Dest_TB_Author, Me.MS_Dest_BTN_Find})
        Me.MS_Dest.Location = New System.Drawing.Point(3, 22)
        Me.MS_Dest.Name = "MS_Dest"
        Me.MS_Dest.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MS_Dest.Size = New System.Drawing.Size(697, 27)
        Me.MS_Dest.TabIndex = 2
        Me.MS_Dest.Text = "Menu"
        '
        'MS_Dest_BTN_File
        '
        Me.MS_Dest_BTN_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MS_Dest_BTN_File_New, Me.MS_Dest_BTN_File_Open, Me.MS_Dest_BTN_File_Save, Me.MS_Dest_BTN_File_SaveAs})
        Me.MS_Dest_BTN_File.Name = "MS_Dest_BTN_File"
        Me.MS_Dest_BTN_File.Size = New System.Drawing.Size(62, 23)
        Me.MS_Dest_BTN_File.Text = "Fichier"
        '
        'MS_Dest_BTN_File_New
        '
        Me.MS_Dest_BTN_File_New.Name = "MS_Dest_BTN_File_New"
        Me.MS_Dest_BTN_File_New.Size = New System.Drawing.Size(196, 22)
        Me.MS_Dest_BTN_File_New.Text = "Nouveau"
        '
        'MS_Dest_BTN_File_Open
        '
        Me.MS_Dest_BTN_File_Open.Name = "MS_Dest_BTN_File_Open"
        Me.MS_Dest_BTN_File_Open.Size = New System.Drawing.Size(196, 22)
        Me.MS_Dest_BTN_File_Open.Text = "Ouvrir"
        '
        'MS_Dest_BTN_File_Save
        '
        Me.MS_Dest_BTN_File_Save.Name = "MS_Dest_BTN_File_Save"
        Me.MS_Dest_BTN_File_Save.Size = New System.Drawing.Size(196, 22)
        Me.MS_Dest_BTN_File_Save.Text = "Enregistrer"
        '
        'MS_Dest_BTN_File_SaveAs
        '
        Me.MS_Dest_BTN_File_SaveAs.Name = "MS_Dest_BTN_File_SaveAs"
        Me.MS_Dest_BTN_File_SaveAs.Size = New System.Drawing.Size(196, 22)
        Me.MS_Dest_BTN_File_SaveAs.Text = "Enregistrer sous ..."
        '
        'MS_Dest_TB_Author
        '
        Me.MS_Dest_TB_Author.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.MS_Dest_TB_Author.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MS_Dest_TB_Author.Name = "MS_Dest_TB_Author"
        Me.MS_Dest_TB_Author.Size = New System.Drawing.Size(200, 23)
        Me.MS_Dest_TB_Author.Text = "Oyissan"
        '
        'MS_Dest_BTN_Find
        '
        Me.MS_Dest_BTN_Find.Name = "MS_Dest_BTN_Find"
        Me.MS_Dest_BTN_Find.Size = New System.Drawing.Size(94, 23)
        Me.MS_Dest_BTN_Find.Text = "Rechercher"
        '
        'MS_MainMenu
        '
        Me.MS_MainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.MS_MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MS_MainMenu_BTN_HelpBot, Me.CB_MainMenu_Language})
        Me.MS_MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MS_MainMenu.Name = "MS_MainMenu"
        Me.MS_MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MS_MainMenu.Size = New System.Drawing.Size(1264, 32)
        Me.MS_MainMenu.TabIndex = 1
        Me.MS_MainMenu.Text = "MainMenu"
        '
        'MS_MainMenu_BTN_HelpBot
        '
        Me.MS_MainMenu_BTN_HelpBot.Name = "MS_MainMenu_BTN_HelpBot"
        Me.MS_MainMenu_BTN_HelpBot.Size = New System.Drawing.Size(83, 28)
        Me.MS_MainMenu_BTN_HelpBot.Text = "Aide-Bot"
        '
        'CB_MainMenu_Language
        '
        Me.CB_MainMenu_Language.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CB_MainMenu_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_MainMenu_Language.DropDownWidth = 125
        Me.CB_MainMenu_Language.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CB_MainMenu_Language.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CB_MainMenu_Language.Items.AddRange(New Object() {"ENGLISH", "FRANÇAIS", "РУССКИЙ"})
        Me.CB_MainMenu_Language.Name = "CB_MainMenu_Language"
        Me.CB_MainMenu_Language.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.CB_MainMenu_Language.Size = New System.Drawing.Size(125, 28)
        Me.CB_MainMenu_Language.Sorted = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.SC_Main)
        Me.Controls.Add(Me.MS_MainMenu)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.MainMenuStrip = Me.MS_MainMenu
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.Text = "Outil de traduction 1.4.10"
        Me.SC_Main.Panel1.ResumeLayout(False)
        Me.SC_Main.Panel2.ResumeLayout(False)
        CType(Me.SC_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SC_Main.ResumeLayout(False)
        Me.GB_Source.ResumeLayout(False)
        Me.GB_Source.PerformLayout()
        Me.SC_Source.Panel1.ResumeLayout(False)
        Me.SC_Source.Panel2.ResumeLayout(False)
        CType(Me.SC_Source, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SC_Source.ResumeLayout(False)
        Me.GB_Source_Data.ResumeLayout(False)
        Me.GB_Source_Data_Content.ResumeLayout(False)
        Me.GB_Source_Data_Id.ResumeLayout(False)
        Me.GB_Source_Data_Id.PerformLayout()
        Me.GB_Source_List.ResumeLayout(False)
        Me.GB_Source_List.PerformLayout()
        Me.CMS_LB_Source_List.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.SS_Source.ResumeLayout(False)
        Me.SS_Source.PerformLayout()
        Me.MS_Source.ResumeLayout(False)
        Me.MS_Source.PerformLayout()
        Me.GB_Dest.ResumeLayout(False)
        Me.GB_Dest.PerformLayout()
        Me.SC_Dest.Panel1.ResumeLayout(False)
        Me.SC_Dest.Panel2.ResumeLayout(False)
        CType(Me.SC_Dest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SC_Dest.ResumeLayout(False)
        Me.GB_Dest_Data.ResumeLayout(False)
        Me.GB_Dest_Data_Content.ResumeLayout(False)
        Me.GB_Dest_Data_Id.ResumeLayout(False)
        Me.GB_Dest_Data_Id.PerformLayout()
        Me.GB_Dest_List.ResumeLayout(False)
        Me.GB_Dest_List.PerformLayout()
        Me.CMS_LB_Dest_List.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.SS_Dest.ResumeLayout(False)
        Me.SS_Dest.PerformLayout()
        Me.MS_Dest.ResumeLayout(False)
        Me.MS_Dest.PerformLayout()
        Me.MS_MainMenu.ResumeLayout(False)
        Me.MS_MainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SC_Main As SplitContainer
    Friend WithEvents GB_Source As GroupBox
    Friend WithEvents GB_Dest As GroupBox
    Friend WithEvents MS_Source As MenuStrip
    Friend WithEvents MS_Dest As MenuStrip
    Friend WithEvents MS_Source_BTN_File As ToolStripMenuItem
    Friend WithEvents MS_Dest_BTN_File As ToolStripMenuItem
    Friend WithEvents SS_Source As StatusStrip
    Friend WithEvents SS_Dest As StatusStrip
    Friend WithEvents SS_Source_LBL_Path As ToolStripStatusLabel
    Friend WithEvents SS_Dest_LBL_Path As ToolStripStatusLabel
    Friend WithEvents MS_Source_BTN_File_Open As ToolStripMenuItem
    Friend WithEvents MS_Dest_BTN_File_Open As ToolStripMenuItem
    Friend WithEvents MS_Dest_BTN_File_Save As ToolStripMenuItem
    Friend WithEvents MS_Dest_BTN_File_SaveAs As ToolStripMenuItem
    Friend WithEvents CB_Source_Encoding As ComboBox
    Friend WithEvents CB_Dest_Encoding As ComboBox
    Friend WithEvents GB_Source_Data As GroupBox
    Friend WithEvents BTN_Source_Data_Add As Button
    Friend WithEvents GB_Source_Data_Content As GroupBox
    Friend WithEvents RTB_Source_Data_Content As RichTextBox
    Friend WithEvents GB_Source_Data_Id As GroupBox
    Friend WithEvents TB_Source_Data_Id As TextBox
    Friend WithEvents SC_Source As SplitContainer
    Friend WithEvents GB_Source_List As GroupBox
    Friend WithEvents LB_Source_List As ListBox
    Friend WithEvents LBL_Source_List_Selected As Label
    Friend WithEvents LBL_Source_List_Total As Label
    Friend WithEvents SC_Dest As SplitContainer
    Friend WithEvents GB_Dest_Data As GroupBox
    Friend WithEvents BTN_Dest_Data_Add As Button
    Friend WithEvents GB_Dest_Data_Content As GroupBox
    Friend WithEvents RTB_Dest_Data_Content As RichTextBox
    Friend WithEvents GB_Dest_Data_Id As GroupBox
    Friend WithEvents TB_Dest_Data_Id As TextBox
    Friend WithEvents GB_Dest_List As GroupBox
    Friend WithEvents LB_Dest_List As ListBox
    Friend WithEvents LBL_Dest_List_Selected As Label
    Friend WithEvents LBL_Dest_List_Total As Label
    Friend WithEvents BTN_Dest_Data_Delete As Button
    Friend WithEvents BTN_Dest_Data_Modify As Button
    Friend WithEvents BTN_Source_Data_Previous As Button
    Friend WithEvents BTN_Source_Data_Next As Button
    Friend WithEvents MS_Dest_BTN_File_New As ToolStripMenuItem
    Friend WithEvents BTN_Source_Data_UseHelpBot As Button
    Friend WithEvents MS_MainMenu As MenuStrip
    Friend WithEvents MS_MainMenu_BTN_HelpBot As ToolStripMenuItem
    Friend WithEvents BTN_Dest_Data_UseHelpBot As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBL_Source_Encoding As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LBL_Dest_Encoding As Label
    Friend WithEvents MS_Dest_TB_Author As ToolStripTextBox
    Friend WithEvents CB_MainMenu_Language As ToolStripComboBox
    Friend WithEvents BTN_Dest_Data_UseSource As Button
    Friend WithEvents MS_Dest_BTN_Find As ToolStripMenuItem
    Friend WithEvents CMS_LB_Source_List As ContextMenuStrip
    Friend WithEvents CMS_LB_Source_List_BTN_Copie As ToolStripMenuItem
    Friend WithEvents CMS_LB_Dest_List As ContextMenuStrip
    Friend WithEvents CMS_LB_Dest_List_BTN_Copie As ToolStripMenuItem
    Friend WithEvents CMS_LB_Dest_List_BTN_Delete As ToolStripMenuItem
    Friend WithEvents MS_Source_BTN_File_New As ToolStripMenuItem
End Class
