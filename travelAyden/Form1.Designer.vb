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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtPeople = New System.Windows.Forms.TextBox()
        Me.btnBelgium = New System.Windows.Forms.Button()
        Me.btnEgypt = New System.Windows.Forms.Button()
        Me.lblPeople = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblBooking = New System.Windows.Forms.Label()
        Me.picFlag = New System.Windows.Forms.PictureBox()
        CType(Me.picFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(62, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Travel"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(12, 63)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(834, 16)
        Me.lblInstructions.TabIndex = 1
        Me.lblInstructions.Text = "Enter the number of family members that will be traveling to either Belgium or Eg" & _
    "ypt and the total cost of the trip will be displayed at the bottom"
        '
        'txtPeople
        '
        Me.txtPeople.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeople.Location = New System.Drawing.Point(230, 139)
        Me.txtPeople.Name = "txtPeople"
        Me.txtPeople.Size = New System.Drawing.Size(193, 22)
        Me.txtPeople.TabIndex = 2
        '
        'btnBelgium
        '
        Me.btnBelgium.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBelgium.Location = New System.Drawing.Point(526, 139)
        Me.btnBelgium.Name = "btnBelgium"
        Me.btnBelgium.Size = New System.Drawing.Size(80, 32)
        Me.btnBelgium.TabIndex = 3
        Me.btnBelgium.Text = "Belgium"
        Me.btnBelgium.UseVisualStyleBackColor = True
        '
        'btnEgypt
        '
        Me.btnEgypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEgypt.Location = New System.Drawing.Point(719, 139)
        Me.btnEgypt.Name = "btnEgypt"
        Me.btnEgypt.Size = New System.Drawing.Size(80, 32)
        Me.btnEgypt.TabIndex = 4
        Me.btnEgypt.Text = "Egypt"
        Me.btnEgypt.UseVisualStyleBackColor = True
        '
        'lblPeople
        '
        Me.lblPeople.AutoSize = True
        Me.lblPeople.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeople.Location = New System.Drawing.Point(23, 139)
        Me.lblPeople.Name = "lblPeople"
        Me.lblPeople.Size = New System.Drawing.Size(176, 16)
        Me.lblPeople.TabIndex = 5
        Me.lblPeople.Text = "Number of Family Members:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(23, 271)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(89, 16)
        Me.lblCost.TabIndex = 6
        Me.lblCost.Text = "Total Cost: $0"
        '
        'lblBooking
        '
        Me.lblBooking.AutoSize = True
        Me.lblBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooking.Location = New System.Drawing.Point(23, 342)
        Me.lblBooking.Name = "lblBooking"
        Me.lblBooking.Size = New System.Drawing.Size(74, 16)
        Me.lblBooking.TabIndex = 7
        Me.lblBooking.Text = "Booking:  0"
        '
        'picFlag
        '
        Me.picFlag.Location = New System.Drawing.Point(491, 209)
        Me.picFlag.Name = "picFlag"
        Me.picFlag.Size = New System.Drawing.Size(355, 185)
        Me.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFlag.TabIndex = 8
        Me.picFlag.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 446)
        Me.Controls.Add(Me.picFlag)
        Me.Controls.Add(Me.lblBooking)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblPeople)
        Me.Controls.Add(Me.btnEgypt)
        Me.Controls.Add(Me.btnBelgium)
        Me.Controls.Add(Me.txtPeople)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents txtPeople As System.Windows.Forms.TextBox
    Friend WithEvents btnBelgium As System.Windows.Forms.Button
    Friend WithEvents btnEgypt As System.Windows.Forms.Button
    Friend WithEvents lblPeople As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblBooking As System.Windows.Forms.Label
    Friend WithEvents picFlag As System.Windows.Forms.PictureBox

End Class
