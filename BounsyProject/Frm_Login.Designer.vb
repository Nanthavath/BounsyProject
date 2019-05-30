<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtUser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 11)
        Me.Panel1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SeaGreen
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.BounsyProject.My.Resources.Resources.icons8_delete_sign_30px_1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(371, 256)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 44)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "ຍົກເລີກ"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SeaGreen
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.BounsyProject.My.Resources.Resources.icons8_enter_2_30px
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(128, 256)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 44)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "ເຂົ້າສູ່ລະບົບ"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Font = New System.Drawing.Font("Saysettha OT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(228, 210)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(121, 26)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "ສະແດງລະຫັດຜ່ານ"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'txtUser
        '
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.Black
        Me.txtUser.HintForeColor = System.Drawing.Color.Gray
        Me.txtUser.HintText = "Usename"
        Me.txtUser.isPassword = False
        Me.txtUser.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtUser.LineIdleColor = System.Drawing.Color.Gray
        Me.txtUser.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtUser.LineThickness = 9
        Me.txtUser.Location = New System.Drawing.Point(113, 122)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.txtUser.Size = New System.Drawing.Size(370, 37)
        Me.txtUser.TabIndex = 5
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPass
        '
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.HintForeColor = System.Drawing.Color.Gray
        Me.txtPass.HintText = "Password"
        Me.txtPass.isPassword = False
        Me.txtPass.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtPass.LineIdleColor = System.Drawing.Color.Gray
        Me.txtPass.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtPass.LineThickness = 6
        Me.txtPass.Location = New System.Drawing.Point(113, 166)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.txtPass.Size = New System.Drawing.Size(370, 37)
        Me.txtPass.TabIndex = 6
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BounsyProject.My.Resources.Resources.icons8_lock_50px_3
        Me.PictureBox1.Location = New System.Drawing.Point(264, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(575, 329)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PictureBox1 As PictureBox
End Class
