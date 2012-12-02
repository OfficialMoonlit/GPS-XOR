<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtXOR = New System.Windows.Forms.TextBox()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.lblChecksum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtXOR
        '
        Me.txtXOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXOR.Location = New System.Drawing.Point(10, 53)
        Me.txtXOR.Name = "txtXOR"
        Me.txtXOR.Size = New System.Drawing.Size(521, 20)
        Me.txtXOR.TabIndex = 0
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.Location = New System.Drawing.Point(7, 9)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(151, 14)
        Me.lblAppName.TabIndex = 1
        Me.lblAppName.Text = "GPS Checksum Generator"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.Location = New System.Drawing.Point(7, 37)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(71, 14)
        Me.lblInput.TabIndex = 2
        Me.lblInput.Text = "Input String"
        '
        'txtSum
        '
        Me.txtSum.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSum.Location = New System.Drawing.Point(537, 53)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.Size = New System.Drawing.Size(31, 20)
        Me.txtSum.TabIndex = 3
        '
        'lblChecksum
        '
        Me.lblChecksum.AutoSize = True
        Me.lblChecksum.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChecksum.Location = New System.Drawing.Point(534, 37)
        Me.lblChecksum.Name = "lblChecksum"
        Me.lblChecksum.Size = New System.Drawing.Size(32, 14)
        Me.lblChecksum.TabIndex = 4
        Me.lblChecksum.Text = "Sum"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 83)
        Me.Controls.Add(Me.lblChecksum)
        Me.Controls.Add(Me.txtSum)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.lblAppName)
        Me.Controls.Add(Me.txtXOR)
        Me.Name = "frmMain"
        Me.Text = "gpSIM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtXOR As System.Windows.Forms.TextBox
    Friend WithEvents lblAppName As System.Windows.Forms.Label
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents txtSum As System.Windows.Forms.TextBox
    Friend WithEvents lblChecksum As System.Windows.Forms.Label

End Class
