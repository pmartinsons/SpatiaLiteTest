<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnExecuteSQL = New System.Windows.Forms.Button()
        Me.btnLoadSpatiaLite = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lbInput = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnExecuteSQL
        '
        Me.btnExecuteSQL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExecuteSQL.Location = New System.Drawing.Point(12, 145)
        Me.btnExecuteSQL.Name = "btnExecuteSQL"
        Me.btnExecuteSQL.Size = New System.Drawing.Size(116, 28)
        Me.btnExecuteSQL.TabIndex = 0
        Me.btnExecuteSQL.Text = "Execute SQL"
        Me.btnExecuteSQL.UseVisualStyleBackColor = True
        '
        'btnLoadSpatiaLite
        '
        Me.btnLoadSpatiaLite.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLoadSpatiaLite.Location = New System.Drawing.Point(134, 145)
        Me.btnLoadSpatiaLite.Name = "btnLoadSpatiaLite"
        Me.btnLoadSpatiaLite.Size = New System.Drawing.Size(116, 28)
        Me.btnLoadSpatiaLite.TabIndex = 1
        Me.btnLoadSpatiaLite.Text = "Load Spatialite"
        Me.btnLoadSpatiaLite.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInput.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.txtInput.Location = New System.Drawing.Point(12, 29)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(737, 111)
        Me.txtInput.TabIndex = 2
        '
        'lbInput
        '
        Me.lbInput.AutoSize = True
        Me.lbInput.Location = New System.Drawing.Point(12, 13)
        Me.lbInput.Name = "lbInput"
        Me.lbInput.Size = New System.Drawing.Size(31, 13)
        Me.lbInput.TabIndex = 3
        Me.lbInput.Text = "Input"
        '
        'lblOutput
        '
        Me.lblOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(12, 179)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(39, 13)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.Text = "Output"
        '
        'txtOutput
        '
        Me.txtOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutput.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(12, 194)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(737, 117)
        Me.txtOutput.TabIndex = 4
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 323)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lbInput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnLoadSpatiaLite)
        Me.Controls.Add(Me.btnExecuteSQL)
        Me.Name = "MainForm"
        Me.Text = "SpatiaLite test application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExecuteSQL As Button
    Friend WithEvents btnLoadSpatiaLite As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lbInput As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtOutput As TextBox
End Class
