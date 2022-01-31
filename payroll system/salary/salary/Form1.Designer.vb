<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tsalary = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tdeduction = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ttotal = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.tnet = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bcal = New System.Windows.Forms.Button()
        Me.chkcost = New System.Windows.Forms.CheckBox()
        Me.chkresearch = New System.Windows.Forms.CheckBox()
        Me.rbepf = New System.Windows.Forms.RadioButton()
        Me.rbupf = New System.Windows.Forms.RadioButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bclear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tsalary
        '
        Me.tsalary.Location = New System.Drawing.Point(198, 76)
        Me.tsalary.Name = "tsalary"
        Me.tsalary.Size = New System.Drawing.Size(134, 20)
        Me.tsalary.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Basic Salary"
        '
        'tdeduction
        '
        Me.tdeduction.Location = New System.Drawing.Point(198, 308)
        Me.tdeduction.Name = "tdeduction"
        Me.tdeduction.Size = New System.Drawing.Size(134, 20)
        Me.tdeduction.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Deduction"
        '
        'ttotal
        '
        Me.ttotal.Location = New System.Drawing.Point(198, 282)
        Me.ttotal.Name = "ttotal"
        Me.ttotal.Size = New System.Drawing.Size(134, 20)
        Me.ttotal.TabIndex = 1
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(76, 285)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(83, 13)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Total Allowance"
        '
        'tnet
        '
        Me.tnet.Location = New System.Drawing.Point(198, 334)
        Me.tnet.Name = "tnet"
        Me.tnet.Size = New System.Drawing.Size(134, 20)
        Me.tnet.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Net Pay"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Allowance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Fund Type"
        '
        'bcal
        '
        Me.bcal.Location = New System.Drawing.Point(79, 214)
        Me.bcal.Name = "bcal"
        Me.bcal.Size = New System.Drawing.Size(62, 23)
        Me.bcal.TabIndex = 2
        Me.bcal.Text = "Calculate"
        Me.bcal.UseVisualStyleBackColor = True
        '
        'chkcost
        '
        Me.chkcost.AutoSize = True
        Me.chkcost.Location = New System.Drawing.Point(198, 116)
        Me.chkcost.Name = "chkcost"
        Me.chkcost.Size = New System.Drawing.Size(86, 17)
        Me.chkcost.TabIndex = 3
        Me.chkcost.Text = "Cost of living"
        Me.chkcost.UseVisualStyleBackColor = True
        '
        'chkresearch
        '
        Me.chkresearch.AutoSize = True
        Me.chkresearch.Location = New System.Drawing.Point(198, 139)
        Me.chkresearch.Name = "chkresearch"
        Me.chkresearch.Size = New System.Drawing.Size(124, 17)
        Me.chkresearch.TabIndex = 3
        Me.chkresearch.Text = "Research Allowance"
        Me.chkresearch.UseVisualStyleBackColor = True
        '
        'rbepf
        '
        Me.rbepf.AutoSize = True
        Me.rbepf.Location = New System.Drawing.Point(198, 176)
        Me.rbepf.Name = "rbepf"
        Me.rbepf.Size = New System.Drawing.Size(45, 17)
        Me.rbepf.TabIndex = 4
        Me.rbepf.TabStop = True
        Me.rbepf.Text = "EPF"
        Me.rbepf.UseVisualStyleBackColor = True
        '
        'rbupf
        '
        Me.rbupf.AutoSize = True
        Me.rbupf.Location = New System.Drawing.Point(267, 176)
        Me.rbupf.Name = "rbupf"
        Me.rbupf.Size = New System.Drawing.Size(46, 17)
        Me.rbupf.TabIndex = 4
        Me.rbupf.TabStop = True
        Me.rbupf.Text = "UPF"
        Me.rbupf.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(400, 389)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -7
        Me.LineShape1.X2 = 401
        Me.LineShape1.Y1 = 257
        Me.LineShape1.Y2 = 256
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(140, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 22)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Payroll System"
        '
        'bclear
        '
        Me.bclear.Location = New System.Drawing.Point(294, 214)
        Me.bclear.Name = "bclear"
        Me.bclear.Size = New System.Drawing.Size(62, 23)
        Me.bclear.TabIndex = 2
        Me.bclear.Text = "Clear"
        Me.bclear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 389)
        Me.Controls.Add(Me.bclear)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rbupf)
        Me.Controls.Add(Me.rbepf)
        Me.Controls.Add(Me.chkresearch)
        Me.Controls.Add(Me.chkcost)
        Me.Controls.Add(Me.bcal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ttotal)
        Me.Controls.Add(Me.tnet)
        Me.Controls.Add(Me.tdeduction)
        Me.Controls.Add(Me.tsalary)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsalary As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tdeduction As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ttotal As System.Windows.Forms.TextBox
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents tnet As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bcal As System.Windows.Forms.Button
    Friend WithEvents chkcost As System.Windows.Forms.CheckBox
    Friend WithEvents chkresearch As System.Windows.Forms.CheckBox
    Friend WithEvents rbepf As System.Windows.Forms.RadioButton
    Friend WithEvents rbupf As System.Windows.Forms.RadioButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bclear As System.Windows.Forms.Button

End Class
