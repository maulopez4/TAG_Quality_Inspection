<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPicture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPicture))
        Me.pbcaptureimage = New System.Windows.Forms.PictureBox()
        Me.cmdok = New System.Windows.Forms.Button()
        Me.cmdno = New System.Windows.Forms.Button()
        Me.pbcapture = New System.Windows.Forms.Button()
        Me.ImagePathText = New System.Windows.Forms.TextBox()
        CType(Me.pbcaptureimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbcaptureimage
        '
        Me.pbcaptureimage.Location = New System.Drawing.Point(9, 7)
        Me.pbcaptureimage.Name = "pbcaptureimage"
        Me.pbcaptureimage.Size = New System.Drawing.Size(640, 480)
        Me.pbcaptureimage.TabIndex = 0
        Me.pbcaptureimage.TabStop = False
        '
        'cmdok
        '
        Me.cmdok.Image = CType(resources.GetObject("cmdok.Image"), System.Drawing.Image)
        Me.cmdok.Location = New System.Drawing.Point(268, 507)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.Size = New System.Drawing.Size(28, 23)
        Me.cmdok.TabIndex = 1
        Me.cmdok.UseVisualStyleBackColor = True
        '
        'cmdno
        '
        Me.cmdno.Image = CType(resources.GetObject("cmdno.Image"), System.Drawing.Image)
        Me.cmdno.Location = New System.Drawing.Point(357, 507)
        Me.cmdno.Name = "cmdno"
        Me.cmdno.Size = New System.Drawing.Size(28, 23)
        Me.cmdno.TabIndex = 1
        Me.cmdno.UseVisualStyleBackColor = True
        '
        'pbcapture
        '
        Me.pbcapture.Image = CType(resources.GetObject("pbcapture.Image"), System.Drawing.Image)
        Me.pbcapture.Location = New System.Drawing.Point(302, 493)
        Me.pbcapture.Name = "pbcapture"
        Me.pbcapture.Size = New System.Drawing.Size(49, 50)
        Me.pbcapture.TabIndex = 1
        Me.pbcapture.UseVisualStyleBackColor = True
        '
        'ImagePathText
        '
        Me.ImagePathText.Location = New System.Drawing.Point(420, 503)
        Me.ImagePathText.Name = "ImagePathText"
        Me.ImagePathText.Size = New System.Drawing.Size(204, 23)
        Me.ImagePathText.TabIndex = 2
        '
        'AddPicture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 552)
        Me.Controls.Add(Me.ImagePathText)
        Me.Controls.Add(Me.pbcapture)
        Me.Controls.Add(Me.cmdno)
        Me.Controls.Add(Me.cmdok)
        Me.Controls.Add(Me.pbcaptureimage)
        Me.Name = "AddPicture"
        Me.Text = "Add Picture"
        CType(Me.pbcaptureimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbcaptureimage As PictureBox
    Friend WithEvents cmdok As Button
    Friend WithEvents cmdno As Button
    Friend WithEvents pbcapture As Button
    Friend WithEvents ImagePathText As TextBox
End Class
