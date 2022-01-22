<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpBotForm
    Inherits System.Windows.Forms.Form

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
        Me.TC_Main = New System.Windows.Forms.TabControl()
        Me.TP_Source = New System.Windows.Forms.TabPage()
        Me.BTN_Source_Save = New System.Windows.Forms.Button()
        Me.BTN_Source_Open = New System.Windows.Forms.Button()
        Me.LB_Source = New System.Windows.Forms.ListBox()
        Me.BTN_Source_New = New System.Windows.Forms.Button()
        Me.BTN_Source_Modify = New System.Windows.Forms.Button()
        Me.BTN_Source_Delete = New System.Windows.Forms.Button()
        Me.BTN_Source_Add = New System.Windows.Forms.Button()
        Me.GB_Source_To = New System.Windows.Forms.GroupBox()
        Me.TB_Source_To = New System.Windows.Forms.TextBox()
        Me.GB_Source_From = New System.Windows.Forms.GroupBox()
        Me.TB_Source_From = New System.Windows.Forms.TextBox()
        Me.TP_Dest = New System.Windows.Forms.TabPage()
        Me.BTN_Dest_Save = New System.Windows.Forms.Button()
        Me.BTN_Dest_Open = New System.Windows.Forms.Button()
        Me.LB_Dest = New System.Windows.Forms.ListBox()
        Me.BTN_Dest_New = New System.Windows.Forms.Button()
        Me.BTN_Dest_Modify = New System.Windows.Forms.Button()
        Me.BTN_Dest_Delete = New System.Windows.Forms.Button()
        Me.BTN_Dest_Add = New System.Windows.Forms.Button()
        Me.GB_Dest_To = New System.Windows.Forms.GroupBox()
        Me.TB_Dest_To = New System.Windows.Forms.TextBox()
        Me.GB_Dest_From = New System.Windows.Forms.GroupBox()
        Me.TB_Dest_From = New System.Windows.Forms.TextBox()
        Me.BTN_Source_NewFile = New System.Windows.Forms.Button()
        Me.BTN_Dest_NewFile = New System.Windows.Forms.Button()
        Me.TC_Main.SuspendLayout()
        Me.TP_Source.SuspendLayout()
        Me.GB_Source_To.SuspendLayout()
        Me.GB_Source_From.SuspendLayout()
        Me.TP_Dest.SuspendLayout()
        Me.GB_Dest_To.SuspendLayout()
        Me.GB_Dest_From.SuspendLayout()
        Me.SuspendLayout()
        '
        'TC_Main
        '
        Me.TC_Main.Controls.Add(Me.TP_Source)
        Me.TC_Main.Controls.Add(Me.TP_Dest)
        Me.TC_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TC_Main.Location = New System.Drawing.Point(0, 0)
        Me.TC_Main.Name = "TC_Main"
        Me.TC_Main.SelectedIndex = 0
        Me.TC_Main.Size = New System.Drawing.Size(624, 441)
        Me.TC_Main.TabIndex = 0
        '
        'TP_Source
        '
        Me.TP_Source.Controls.Add(Me.BTN_Source_NewFile)
        Me.TP_Source.Controls.Add(Me.BTN_Source_Save)
        Me.TP_Source.Controls.Add(Me.BTN_Source_Open)
        Me.TP_Source.Controls.Add(Me.LB_Source)
        Me.TP_Source.Controls.Add(Me.BTN_Source_New)
        Me.TP_Source.Controls.Add(Me.BTN_Source_Modify)
        Me.TP_Source.Controls.Add(Me.BTN_Source_Delete)
        Me.TP_Source.Controls.Add(Me.BTN_Source_Add)
        Me.TP_Source.Controls.Add(Me.GB_Source_To)
        Me.TP_Source.Controls.Add(Me.GB_Source_From)
        Me.TP_Source.Location = New System.Drawing.Point(4, 22)
        Me.TP_Source.Name = "TP_Source"
        Me.TP_Source.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Source.Size = New System.Drawing.Size(616, 415)
        Me.TP_Source.TabIndex = 0
        Me.TP_Source.Text = "Source"
        Me.TP_Source.UseVisualStyleBackColor = True
        '
        'BTN_Source_Save
        '
        Me.BTN_Source_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_Source_Save.Location = New System.Drawing.Point(364, 389)
        Me.BTN_Source_Save.Name = "BTN_Source_Save"
        Me.BTN_Source_Save.Size = New System.Drawing.Size(100, 23)
        Me.BTN_Source_Save.TabIndex = 17
        Me.BTN_Source_Save.Text = "Sauvegarder"
        Me.BTN_Source_Save.UseVisualStyleBackColor = True
        '
        'BTN_Source_Open
        '
        Me.BTN_Source_Open.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_Source_Open.Location = New System.Drawing.Point(258, 389)
        Me.BTN_Source_Open.Name = "BTN_Source_Open"
        Me.BTN_Source_Open.Size = New System.Drawing.Size(100, 23)
        Me.BTN_Source_Open.TabIndex = 16
        Me.BTN_Source_Open.Text = "Ouvrir"
        Me.BTN_Source_Open.UseVisualStyleBackColor = True
        '
        'LB_Source
        '
        Me.LB_Source.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_Source.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LB_Source.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LB_Source.FormattingEnabled = True
        Me.LB_Source.HorizontalScrollbar = True
        Me.LB_Source.ItemHeight = 16
        Me.LB_Source.Location = New System.Drawing.Point(8, 160)
        Me.LB_Source.Name = "LB_Source"
        Me.LB_Source.ScrollAlwaysVisible = True
        Me.LB_Source.Size = New System.Drawing.Size(600, 226)
        Me.LB_Source.TabIndex = 15
        '
        'BTN_Source_New
        '
        Me.BTN_Source_New.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BTN_Source_New.Location = New System.Drawing.Point(8, 6)
        Me.BTN_Source_New.Name = "BTN_Source_New"
        Me.BTN_Source_New.Size = New System.Drawing.Size(100, 27)
        Me.BTN_Source_New.TabIndex = 14
        Me.BTN_Source_New.Text = "Nouveau"
        Me.BTN_Source_New.UseVisualStyleBackColor = True
        '
        'BTN_Source_Modify
        '
        Me.BTN_Source_Modify.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Source_Modify.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BTN_Source_Modify.Location = New System.Drawing.Point(402, 127)
        Me.BTN_Source_Modify.Name = "BTN_Source_Modify"
        Me.BTN_Source_Modify.Size = New System.Drawing.Size(100, 27)
        Me.BTN_Source_Modify.TabIndex = 13
        Me.BTN_Source_Modify.Text = "Modifier"
        Me.BTN_Source_Modify.UseVisualStyleBackColor = True
        '
        'BTN_Source_Delete
        '
        Me.BTN_Source_Delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Source_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BTN_Source_Delete.Location = New System.Drawing.Point(296, 127)
        Me.BTN_Source_Delete.Name = "BTN_Source_Delete"
        Me.BTN_Source_Delete.Size = New System.Drawing.Size(100, 27)
        Me.BTN_Source_Delete.TabIndex = 12
        Me.BTN_Source_Delete.Text = "Supprimer"
        Me.BTN_Source_Delete.UseVisualStyleBackColor = True
        '
        'BTN_Source_Add
        '
        Me.BTN_Source_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Source_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BTN_Source_Add.Location = New System.Drawing.Point(508, 127)
        Me.BTN_Source_Add.Name = "BTN_Source_Add"
        Me.BTN_Source_Add.Size = New System.Drawing.Size(100, 27)
        Me.BTN_Source_Add.TabIndex = 11
        Me.BTN_Source_Add.Text = "Ajouter"
        Me.BTN_Source_Add.UseVisualStyleBackColor = True
        '
        'GB_Source_To
        '
        Me.GB_Source_To.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Source_To.Controls.Add(Me.TB_Source_To)
        Me.GB_Source_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GB_Source_To.Location = New System.Drawing.Point(8, 83)
        Me.GB_Source_To.Name = "GB_Source_To"
        Me.GB_Source_To.Size = New System.Drawing.Size(600, 38)
        Me.GB_Source_To.TabIndex = 8
        Me.GB_Source_To.TabStop = False
        Me.GB_Source_To.Text = "À"
        '
        'TB_Source_To
        '
        Me.TB_Source_To.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Source_To.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TB_Source_To.Location = New System.Drawing.Point(3, 19)
        Me.TB_Source_To.Name = "TB_Source_To"
        Me.TB_Source_To.Size = New System.Drawing.Size(594, 16)
        Me.TB_Source_To.TabIndex = 0
        Me.TB_Source_To.WordWrap = False
        '
        'GB_Source_From
        '
        Me.GB_Source_From.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Source_From.Controls.Add(Me.TB_Source_From)
        Me.GB_Source_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GB_Source_From.Location = New System.Drawing.Point(8, 39)
        Me.GB_Source_From.Name = "GB_Source_From"
        Me.GB_Source_From.Size = New System.Drawing.Size(600, 38)
        Me.GB_Source_From.TabIndex = 7
        Me.GB_Source_From.TabStop = False
        Me.GB_Source_From.Text = "De"
        '
        'TB_Source_From
        '
        Me.TB_Source_From.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Source_From.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TB_Source_From.Location = New System.Drawing.Point(3, 19)
        Me.TB_Source_From.Name = "TB_Source_From"
        Me.TB_Source_From.Size = New System.Drawing.Size(594, 16)
        Me.TB_Source_From.TabIndex = 0
        Me.TB_Source_From.WordWrap = False
        '
        'TP_Dest
        '
        Me.TP_Dest.Controls.Add(Me.BTN_Dest_NewFile)
        Me.TP_Dest.Controls.Add(Me.BTN_Dest_Save)
        Me.TP_Dest.Controls.Add(Me.BTN_Dest_Open)
        Me.TP_Dest.Controls.Add(Me.LB_Dest)
        Me.TP_Dest.Controls.Add(Me.BTN_Dest_New)
        Me.TP_Dest.Controls.Add(Me.BTN_Dest_Modify)
        Me.TP_Dest.Controls.Add(Me.BTN_Dest_Delete)
        Me.TP_Dest.Controls.Add(Me.BTN_Dest_Add)
        Me.TP_Dest.Controls.Add(Me.GB_Dest_To)
        Me.TP_Dest.Controls.Add(Me.GB_Dest_From)
        Me.TP_Dest.Location = New System.Drawing.Point(4, 22)
        Me.TP_Dest.Name = "TP_Dest"
        Me.TP_Dest.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Dest.Size = New System.Drawing.Size(616, 415)
        Me.TP_Dest.TabIndex = 1
        Me.TP_Dest.Text = "Destination"
        Me.TP_Dest.UseVisualStyleBackColor = True
        '
        'BTN_Dest_Save
        '
        Me.BTN_Dest_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_Dest_Save.AutoSize = True
        Me.BTN_Dest_Save.Location = New System.Drawing.Point(364, 389)
        Me.BTN_Dest_Save.Name = "BTN_Dest_Save"
        Me.BTN_Dest_Save.Size = New System.Drawing.Size(100, 23)
        Me.BTN_Dest_Save.TabIndex = 26
        Me.BTN_Dest_Save.Text = "Sauvegarder"
        Me.BTN_Dest_Save.UseVisualStyleBackColor = True
        '
        'BTN_Dest_Open
        '
        Me.BTN_Dest_Open.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_Dest_Open.Location = New System.Drawing.Point(258, 389)
        Me.BTN_Dest_Open.Name = "BTN_Dest_Open"
        Me.BTN_Dest_Open.Size = New System.Drawing.Size(100, 23)
        Me.BTN_Dest_Open.TabIndex = 25
        Me.BTN_Dest_Open.Text = "Ouvrir"
        Me.BTN_Dest_Open.UseVisualStyleBackColor = True
        '
        'LB_Dest
        '
        Me.LB_Dest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_Dest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LB_Dest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LB_Dest.FormattingEnabled = True
        Me.LB_Dest.HorizontalScrollbar = True
        Me.LB_Dest.ItemHeight = 16
        Me.LB_Dest.Location = New System.Drawing.Point(8, 160)
        Me.LB_Dest.Name = "LB_Dest"
        Me.LB_Dest.ScrollAlwaysVisible = True
        Me.LB_Dest.Size = New System.Drawing.Size(600, 226)
        Me.LB_Dest.TabIndex = 24
        '
        'BTN_Dest_New
        '
        Me.BTN_Dest_New.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BTN_Dest_New.Location = New System.Drawing.Point(8, 6)
        Me.BTN_Dest_New.Name = "BTN_Dest_New"
        Me.BTN_Dest_New.Size = New System.Drawing.Size(100, 27)
        Me.BTN_Dest_New.TabIndex = 23
        Me.BTN_Dest_New.Text = "Nouveau"
        Me.BTN_Dest_New.UseVisualStyleBackColor = True
        '
        'BTN_Dest_Modify
        '
        Me.BTN_Dest_Modify.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Dest_Modify.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BTN_Dest_Modify.Location = New System.Drawing.Point(402, 127)
        Me.BTN_Dest_Modify.Name = "BTN_Dest_Modify"
        Me.BTN_Dest_Modify.Size = New System.Drawing.Size(100, 27)
        Me.BTN_Dest_Modify.TabIndex = 22
        Me.BTN_Dest_Modify.Text = "Modifier"
        Me.BTN_Dest_Modify.UseVisualStyleBackColor = True
        '
        'BTN_Dest_Delete
        '
        Me.BTN_Dest_Delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Dest_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BTN_Dest_Delete.Location = New System.Drawing.Point(296, 127)
        Me.BTN_Dest_Delete.Name = "BTN_Dest_Delete"
        Me.BTN_Dest_Delete.Size = New System.Drawing.Size(100, 27)
        Me.BTN_Dest_Delete.TabIndex = 21
        Me.BTN_Dest_Delete.Text = "Supprimer"
        Me.BTN_Dest_Delete.UseVisualStyleBackColor = True
        '
        'BTN_Dest_Add
        '
        Me.BTN_Dest_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Dest_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BTN_Dest_Add.Location = New System.Drawing.Point(508, 127)
        Me.BTN_Dest_Add.Name = "BTN_Dest_Add"
        Me.BTN_Dest_Add.Size = New System.Drawing.Size(100, 27)
        Me.BTN_Dest_Add.TabIndex = 20
        Me.BTN_Dest_Add.Text = "Ajouter"
        Me.BTN_Dest_Add.UseVisualStyleBackColor = True
        '
        'GB_Dest_To
        '
        Me.GB_Dest_To.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Dest_To.Controls.Add(Me.TB_Dest_To)
        Me.GB_Dest_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GB_Dest_To.Location = New System.Drawing.Point(8, 83)
        Me.GB_Dest_To.Name = "GB_Dest_To"
        Me.GB_Dest_To.Size = New System.Drawing.Size(600, 38)
        Me.GB_Dest_To.TabIndex = 19
        Me.GB_Dest_To.TabStop = False
        Me.GB_Dest_To.Text = "À"
        '
        'TB_Dest_To
        '
        Me.TB_Dest_To.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Dest_To.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TB_Dest_To.Location = New System.Drawing.Point(3, 19)
        Me.TB_Dest_To.Name = "TB_Dest_To"
        Me.TB_Dest_To.Size = New System.Drawing.Size(594, 16)
        Me.TB_Dest_To.TabIndex = 0
        Me.TB_Dest_To.WordWrap = False
        '
        'GB_Dest_From
        '
        Me.GB_Dest_From.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Dest_From.Controls.Add(Me.TB_Dest_From)
        Me.GB_Dest_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GB_Dest_From.Location = New System.Drawing.Point(8, 39)
        Me.GB_Dest_From.Name = "GB_Dest_From"
        Me.GB_Dest_From.Size = New System.Drawing.Size(600, 38)
        Me.GB_Dest_From.TabIndex = 18
        Me.GB_Dest_From.TabStop = False
        Me.GB_Dest_From.Text = "De"
        '
        'TB_Dest_From
        '
        Me.TB_Dest_From.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Dest_From.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TB_Dest_From.Location = New System.Drawing.Point(3, 19)
        Me.TB_Dest_From.Name = "TB_Dest_From"
        Me.TB_Dest_From.Size = New System.Drawing.Size(594, 16)
        Me.TB_Dest_From.TabIndex = 0
        Me.TB_Dest_From.WordWrap = False
        '
        'BTN_Source_NewFile
        '
        Me.BTN_Source_NewFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_Source_NewFile.Location = New System.Drawing.Point(152, 389)
        Me.BTN_Source_NewFile.Name = "BTN_Source_NewFile"
        Me.BTN_Source_NewFile.Size = New System.Drawing.Size(100, 23)
        Me.BTN_Source_NewFile.TabIndex = 18
        Me.BTN_Source_NewFile.Text = "Nouveau"
        Me.BTN_Source_NewFile.UseVisualStyleBackColor = True
        '
        'BTN_Dest_NewFile
        '
        Me.BTN_Dest_NewFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_Dest_NewFile.Location = New System.Drawing.Point(152, 389)
        Me.BTN_Dest_NewFile.Name = "BTN_Dest_NewFile"
        Me.BTN_Dest_NewFile.Size = New System.Drawing.Size(100, 23)
        Me.BTN_Dest_NewFile.TabIndex = 27
        Me.BTN_Dest_NewFile.Text = "Nouveau"
        Me.BTN_Dest_NewFile.UseVisualStyleBackColor = True
        '
        'HelpBotForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.TC_Main)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HelpBotForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aide-Bot"
        Me.TC_Main.ResumeLayout(False)
        Me.TP_Source.ResumeLayout(False)
        Me.GB_Source_To.ResumeLayout(False)
        Me.GB_Source_To.PerformLayout()
        Me.GB_Source_From.ResumeLayout(False)
        Me.GB_Source_From.PerformLayout()
        Me.TP_Dest.ResumeLayout(False)
        Me.TP_Dest.PerformLayout()
        Me.GB_Dest_To.ResumeLayout(False)
        Me.GB_Dest_To.PerformLayout()
        Me.GB_Dest_From.ResumeLayout(False)
        Me.GB_Dest_From.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TC_Main As TabControl
    Friend WithEvents TP_Source As TabPage
    Friend WithEvents TP_Dest As TabPage
    Friend WithEvents GB_Source_To As GroupBox
    Friend WithEvents TB_Source_To As TextBox
    Friend WithEvents GB_Source_From As GroupBox
    Friend WithEvents TB_Source_From As TextBox
    Friend WithEvents BTN_Source_Delete As Button
    Friend WithEvents BTN_Source_Add As Button
    Friend WithEvents BTN_Source_Modify As Button
    Friend WithEvents LB_Source As ListBox
    Friend WithEvents BTN_Source_New As Button
    Friend WithEvents BTN_Source_Save As Button
    Friend WithEvents BTN_Source_Open As Button
    Friend WithEvents BTN_Dest_Save As Button
    Friend WithEvents BTN_Dest_Open As Button
    Friend WithEvents LB_Dest As ListBox
    Friend WithEvents BTN_Dest_New As Button
    Friend WithEvents BTN_Dest_Modify As Button
    Friend WithEvents BTN_Dest_Delete As Button
    Friend WithEvents BTN_Dest_Add As Button
    Friend WithEvents GB_Dest_To As GroupBox
    Friend WithEvents TB_Dest_To As TextBox
    Friend WithEvents GB_Dest_From As GroupBox
    Friend WithEvents TB_Dest_From As TextBox
    Friend WithEvents BTN_Source_NewFile As Button
    Friend WithEvents BTN_Dest_NewFile As Button
End Class
