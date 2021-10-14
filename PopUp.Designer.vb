<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopUp_Window
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
        Me.PopUp_PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.PopUp_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PopUp_PictureBox
        '
        Me.PopUp_PictureBox.Location = New System.Drawing.Point(13, 13)
        Me.PopUp_PictureBox.Name = "PopUp_PictureBox"
        Me.PopUp_PictureBox.Size = New System.Drawing.Size(640, 480)
        Me.PopUp_PictureBox.TabIndex = 0
        Me.PopUp_PictureBox.TabStop = False
        '
        'PopUp_Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 500)
        Me.Controls.Add(Me.PopUp_PictureBox)
        Me.Name = "PopUp_Window"
        Me.Text = "Image PopUp"
        CType(Me.PopUp_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PopUp_PictureBox As PictureBox
End Class
