<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindForm
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
        Me.TB_Find = New System.Windows.Forms.TextBox()
        Me.BTN_Ok = New System.Windows.Forms.Button()
        Me.GB_Result = New System.Windows.Forms.GroupBox()
        Me.BTN_Previous = New System.Windows.Forms.Button()
        Me.BTN_Next = New System.Windows.Forms.Button()
        Me.LBL_SelectedObj = New System.Windows.Forms.Label()
        Me.LBL_ObjsFound = New System.Windows.Forms.Label()
        Me.GB_Result.SuspendLayout()
        Me.SuspendLayout()
        '
        'TB_Find
        '
        Me.TB_Find.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_Find.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_Find.Location = New System.Drawing.Point(13, 15)
        Me.TB_Find.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_Find.Name = "TB_Find"
        Me.TB_Find.Size = New System.Drawing.Size(458, 23)
        Me.TB_Find.TabIndex = 0
        '
        'BTN_Ok
        '
        Me.BTN_Ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Ok.Location = New System.Drawing.Point(371, 45)
        Me.BTN_Ok.Name = "BTN_Ok"
        Me.BTN_Ok.Size = New System.Drawing.Size(100, 27)
        Me.BTN_Ok.TabIndex = 1
        Me.BTN_Ok.Text = "Ok"
        Me.BTN_Ok.UseVisualStyleBackColor = True
        '
        'GB_Result
        '
        Me.GB_Result.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Result.Controls.Add(Me.BTN_Previous)
        Me.GB_Result.Controls.Add(Me.BTN_Next)
        Me.GB_Result.Controls.Add(Me.LBL_SelectedObj)
        Me.GB_Result.Controls.Add(Me.LBL_ObjsFound)
        Me.GB_Result.Location = New System.Drawing.Point(12, 78)
        Me.GB_Result.Name = "GB_Result"
        Me.GB_Result.Size = New System.Drawing.Size(460, 101)
        Me.GB_Result.TabIndex = 2
        Me.GB_Result.TabStop = False
        Me.GB_Result.Text = "Résultat"
        '
        'BTN_Previous
        '
        Me.BTN_Previous.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Previous.Location = New System.Drawing.Point(198, 68)
        Me.BTN_Previous.Name = "BTN_Previous"
        Me.BTN_Previous.Size = New System.Drawing.Size(125, 27)
        Me.BTN_Previous.TabIndex = 3
        Me.BTN_Previous.Text = "Précédent"
        Me.BTN_Previous.UseVisualStyleBackColor = True
        '
        'BTN_Next
        '
        Me.BTN_Next.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Next.Location = New System.Drawing.Point(329, 68)
        Me.BTN_Next.Name = "BTN_Next"
        Me.BTN_Next.Size = New System.Drawing.Size(125, 27)
        Me.BTN_Next.TabIndex = 2
        Me.BTN_Next.Text = "Suivant"
        Me.BTN_Next.UseVisualStyleBackColor = True
        '
        'LBL_SelectedObj
        '
        Me.LBL_SelectedObj.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBL_SelectedObj.Location = New System.Drawing.Point(3, 39)
        Me.LBL_SelectedObj.Name = "LBL_SelectedObj"
        Me.LBL_SelectedObj.Size = New System.Drawing.Size(454, 20)
        Me.LBL_SelectedObj.TabIndex = 1
        Me.LBL_SelectedObj.Text = "Objet sélectionné : 0"
        Me.LBL_SelectedObj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_ObjsFound
        '
        Me.LBL_ObjsFound.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBL_ObjsFound.Location = New System.Drawing.Point(3, 19)
        Me.LBL_ObjsFound.Name = "LBL_ObjsFound"
        Me.LBL_ObjsFound.Size = New System.Drawing.Size(454, 20)
        Me.LBL_ObjsFound.TabIndex = 0
        Me.LBL_ObjsFound.Text = "Objets trouvé : 0"
        Me.LBL_ObjsFound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FindForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 191)
        Me.Controls.Add(Me.GB_Result)
        Me.Controls.Add(Me.BTN_Ok)
        Me.Controls.Add(Me.TB_Find)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Rechercher"
        Me.GB_Result.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_Find As TextBox
    Friend WithEvents BTN_Ok As Button
    Friend WithEvents GB_Result As GroupBox
    Friend WithEvents BTN_Previous As Button
    Friend WithEvents BTN_Next As Button
    Friend WithEvents LBL_SelectedObj As Label
    Friend WithEvents LBL_ObjsFound As Label
End Class
