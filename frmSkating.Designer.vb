<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSkating
    Inherits System.Windows.Forms.Form

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
        lblHeading = New Label()
        lblLength = New Label()
        lblWidth = New Label()
        lblDepth = New Label()
        txtLength = New TextBox()
        txtWidth = New TextBox()
        txtDepth = New TextBox()
        btnVolume = New Button()
        btnClear = New Button()
        btnExit = New Button()
        lblVolumeDetermined = New Label()
        lblVolumeHeading = New Label()
        picRing = New PictureBox()
        CType(picRing, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(90, 8)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(202, 19)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Indoor Ice Skating Ring"
        ' 
        ' lblLength
        ' 
        lblLength.AutoSize = True
        lblLength.Font = New Font("Tahoma", 11.25F)
        lblLength.Location = New Point(90, 54)
        lblLength.Name = "lblLength"
        lblLength.Size = New Size(117, 18)
        lblLength.TabIndex = 1
        lblLength.Text = "Enter the length:"
        ' 
        ' lblWidth
        ' 
        lblWidth.AutoSize = True
        lblWidth.Font = New Font("Tahoma", 11.25F)
        lblWidth.Location = New Point(90, 92)
        lblWidth.Name = "lblWidth"
        lblWidth.Size = New Size(111, 18)
        lblWidth.TabIndex = 2
        lblWidth.Text = "Enter the width:"
        ' 
        ' lblDepth
        ' 
        lblDepth.AutoSize = True
        lblDepth.Font = New Font("Tahoma", 11.25F)
        lblDepth.Location = New Point(90, 132)
        lblDepth.Name = "lblDepth"
        lblDepth.Size = New Size(115, 18)
        lblDepth.TabIndex = 3
        lblDepth.Text = "Enter the depth:"
        ' 
        ' txtLength
        ' 
        txtLength.Font = New Font("Tahoma", 9.75F)
        txtLength.Location = New Point(215, 51)
        txtLength.Name = "txtLength"
        txtLength.Size = New Size(43, 23)
        txtLength.TabIndex = 4
        txtLength.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtWidth
        ' 
        txtWidth.Font = New Font("Tahoma", 9.75F)
        txtWidth.Location = New Point(215, 90)
        txtWidth.Name = "txtWidth"
        txtWidth.Size = New Size(43, 23)
        txtWidth.TabIndex = 5
        txtWidth.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtDepth
        ' 
        txtDepth.Font = New Font("Tahoma", 9.75F)
        txtDepth.Location = New Point(215, 129)
        txtDepth.Name = "txtDepth"
        txtDepth.Size = New Size(43, 23)
        txtDepth.TabIndex = 6
        txtDepth.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnVolume
        ' 
        btnVolume.Font = New Font("Tahoma", 11.25F)
        btnVolume.Location = New Point(38, 230)
        btnVolume.Name = "btnVolume"
        btnVolume.Size = New Size(91, 45)
        btnVolume.TabIndex = 7
        btnVolume.Text = "Determine Volume"
        btnVolume.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Tahoma", 11.25F)
        btnClear.Location = New Point(170, 230)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(80, 45)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Tahoma", 11.25F)
        btnExit.Location = New Point(297, 230)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(80, 45)
        btnExit.TabIndex = 9
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblVolumeDetermined
        ' 
        lblVolumeDetermined.AutoSize = True
        lblVolumeDetermined.Font = New Font("Tahoma", 12F)
        lblVolumeDetermined.Location = New Point(256, 176)
        lblVolumeDetermined.Name = "lblVolumeDetermined"
        lblVolumeDetermined.Size = New Size(63, 19)
        lblVolumeDetermined.TabIndex = 10
        lblVolumeDetermined.Text = "Volume"
        ' 
        ' lblVolumeHeading
        ' 
        lblVolumeHeading.AutoSize = True
        lblVolumeHeading.Font = New Font("Tahoma", 12F)
        lblVolumeHeading.Location = New Point(90, 176)
        lblVolumeHeading.Name = "lblVolumeHeading"
        lblVolumeHeading.Size = New Size(156, 19)
        lblVolumeHeading.TabIndex = 11
        lblVolumeHeading.Text = "Volume Determined:"
        ' 
        ' picRing
        ' 
        picRing.Image = My.Resources.Resources.Ice
        picRing.Location = New Point(416, 8)
        picRing.Name = "picRing"
        picRing.Size = New Size(387, 245)
        picRing.SizeMode = PictureBoxSizeMode.StretchImage
        picRing.TabIndex = 12
        picRing.TabStop = False
        ' 
        ' frmSkating
        ' 
        AcceptButton = btnVolume
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        CancelButton = btnClear
        ClientSize = New Size(800, 420)
        Controls.Add(picRing)
        Controls.Add(lblVolumeHeading)
        Controls.Add(lblVolumeDetermined)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnVolume)
        Controls.Add(txtDepth)
        Controls.Add(txtWidth)
        Controls.Add(txtLength)
        Controls.Add(lblDepth)
        Controls.Add(lblWidth)
        Controls.Add(lblLength)
        Controls.Add(lblHeading)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmSkating"
        Text = "Ice Skating Ring"
        CType(picRing, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblDepth As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtDepth As TextBox
    Friend WithEvents btnVolume As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblVolumeDetermined As Label
    Friend WithEvents lblVolumeHeading As Label
    Friend WithEvents picRing As PictureBox

End Class
