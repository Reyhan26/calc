<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.navbar = New System.Windows.Forms.Button()
        Me.expand = New System.Windows.Forms.Button()
        Me.history = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.memory = New System.Windows.Forms.Button()
        Me.mc = New System.Windows.Forms.Button()
        Me.mr = New System.Windows.Forms.Button()
        Me.madd = New System.Windows.Forms.Button()
        Me.mminus = New System.Windows.Forms.Button()
        Me.ms = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'navbar
        '
        Me.navbar.BackgroundImage = Global.Calculator.My.Resources.Resources.icons8_windows_10_32
        Me.navbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.navbar.FlatAppearance.BorderSize = 0
        Me.navbar.Location = New System.Drawing.Point(12, 22)
        Me.navbar.Name = "navbar"
        Me.navbar.Size = New System.Drawing.Size(25, 25)
        Me.navbar.TabIndex = 0
        Me.navbar.UseVisualStyleBackColor = True
        '
        'expand
        '
        Me.expand.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.expand.FlatAppearance.BorderSize = 0
        Me.expand.Location = New System.Drawing.Point(194, 22)
        Me.expand.Name = "expand"
        Me.expand.Size = New System.Drawing.Size(25, 25)
        Me.expand.TabIndex = 1
        Me.expand.Text = "Button1"
        Me.expand.UseVisualStyleBackColor = True
        '
        'history
        '
        Me.history.Location = New System.Drawing.Point(352, 22)
        Me.history.Name = "history"
        Me.history.Size = New System.Drawing.Size(25, 25)
        Me.history.TabIndex = 2
        Me.history.Text = "Button1"
        Me.history.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Standard"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 31.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(388, 71)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "88,888,888,888"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'memory
        '
        Me.memory.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memory.Location = New System.Drawing.Point(327, 169)
        Me.memory.Margin = New System.Windows.Forms.Padding(2)
        Me.memory.Name = "memory"
        Me.memory.Size = New System.Drawing.Size(60, 39)
        Me.memory.TabIndex = 10
        Me.memory.Text = "M^"
        Me.memory.UseVisualStyleBackColor = True
        '
        'mc
        '
        Me.mc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mc.Location = New System.Drawing.Point(7, 169)
        Me.mc.Margin = New System.Windows.Forms.Padding(2)
        Me.mc.Name = "mc"
        Me.mc.Size = New System.Drawing.Size(60, 39)
        Me.mc.TabIndex = 11
        Me.mc.Text = "MC"
        Me.mc.UseVisualStyleBackColor = True
        '
        'mr
        '
        Me.mr.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mr.Location = New System.Drawing.Point(71, 169)
        Me.mr.Margin = New System.Windows.Forms.Padding(2)
        Me.mr.Name = "mr"
        Me.mr.Size = New System.Drawing.Size(60, 39)
        Me.mr.TabIndex = 12
        Me.mr.Text = "MR"
        Me.mr.UseVisualStyleBackColor = True
        '
        'madd
        '
        Me.madd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.madd.Location = New System.Drawing.Point(135, 169)
        Me.madd.Margin = New System.Windows.Forms.Padding(2)
        Me.madd.Name = "madd"
        Me.madd.Size = New System.Drawing.Size(60, 39)
        Me.madd.TabIndex = 13
        Me.madd.Text = "M+"
        Me.madd.UseVisualStyleBackColor = True
        '
        'mminus
        '
        Me.mminus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mminus.Location = New System.Drawing.Point(199, 169)
        Me.mminus.Margin = New System.Windows.Forms.Padding(2)
        Me.mminus.Name = "mminus"
        Me.mminus.Size = New System.Drawing.Size(60, 39)
        Me.mminus.TabIndex = 14
        Me.mminus.Text = "M-"
        Me.mminus.UseVisualStyleBackColor = True
        '
        'ms
        '
        Me.ms.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ms.Location = New System.Drawing.Point(263, 169)
        Me.ms.Margin = New System.Windows.Forms.Padding(2)
        Me.ms.Name = "ms"
        Me.ms.Size = New System.Drawing.Size(60, 39)
        Me.ms.TabIndex = 15
        Me.ms.Text = "MS"
        Me.ms.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(389, 581)
        Me.Controls.Add(Me.ms)
        Me.Controls.Add(Me.mminus)
        Me.Controls.Add(Me.madd)
        Me.Controls.Add(Me.mr)
        Me.Controls.Add(Me.mc)
        Me.Controls.Add(Me.memory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.history)
        Me.Controls.Add(Me.expand)
        Me.Controls.Add(Me.navbar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Calculator"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents navbar As Button
    Friend WithEvents expand As Button
    Friend WithEvents history As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents memory As Button
    Friend WithEvents mc As Button
    Friend WithEvents mr As Button
    Friend WithEvents madd As Button
    Friend WithEvents mminus As Button
    Friend WithEvents ms As Button
End Class
