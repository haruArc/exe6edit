<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindStringForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.closeButton = New System.Windows.Forms.Button
        Me.findButton = New System.Windows.Forms.Button
        Me.reverse = New System.Windows.Forms.CheckBox
        Me.findString = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'closeButton
        '
        Me.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.closeButton.Location = New System.Drawing.Point(316, 38)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(88, 23)
        Me.closeButton.TabIndex = 18
        Me.closeButton.Text = "閉じる(&X)"
        '
        'findButton
        '
        Me.findButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.findButton.Location = New System.Drawing.Point(316, 6)
        Me.findButton.Name = "findButton"
        Me.findButton.Size = New System.Drawing.Size(88, 23)
        Me.findButton.TabIndex = 17
        Me.findButton.Text = "次を検索(&F)"
        '
        'reverse
        '
        Me.reverse.Location = New System.Drawing.Point(20, 38)
        Me.reverse.Name = "reverse"
        Me.reverse.Size = New System.Drawing.Size(208, 16)
        Me.reverse.TabIndex = 16
        Me.reverse.Text = "上へ検索する(&U)"
        '
        'findString
        '
        Me.findString.Location = New System.Drawing.Point(124, 6)
        Me.findString.Name = "findString"
        Me.findString.Size = New System.Drawing.Size(184, 19)
        Me.findString.TabIndex = 15
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(112, 16)
        Me.label1.TabIndex = 14
        Me.label1.Text = "検索する文字列(&N):"
        '
        'FindStringForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 68)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.findButton)
        Me.Controls.Add(Me.reverse)
        Me.Controls.Add(Me.findString)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindStringForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "検索"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents findButton As System.Windows.Forms.Button
    Friend WithEvents reverse As System.Windows.Forms.CheckBox
    Friend WithEvents findString As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
End Class
