﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScreenCap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScreenCap))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.y_size_tb = New System.Windows.Forms.TextBox()
        Me.x_size_tb = New System.Windows.Forms.TextBox()
        Me.x1980x1200_rb = New System.Windows.Forms.RadioButton()
        Me.x1440_rb = New System.Windows.Forms.RadioButton()
        Me.x1280_rb = New System.Windows.Forms.RadioButton()
        Me.x1366_rb = New System.Windows.Forms.RadioButton()
        Me.x1920_rb = New System.Windows.Forms.RadioButton()
        Me.x64_rb = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pick_color_btn = New System.Windows.Forms.Button()
        Me.color_rb = New System.Windows.Forms.RadioButton()
        Me.terrain_rb = New System.Windows.Forms.RadioButton()
        Me.trans_rb = New System.Windows.Forms.RadioButton()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.image_rb = New System.Windows.Forms.RadioButton()
        Me.wot_carousel_rb = New System.Windows.Forms.RadioButton()
        Me.wot_panel_rb = New System.Windows.Forms.RadioButton()
        Me.wot_wotmod_rb = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.wot_wotmod_rb)
        Me.GroupBox1.Controls.Add(Me.wot_panel_rb)
        Me.GroupBox1.Controls.Add(Me.wot_carousel_rb)
        Me.GroupBox1.Controls.Add(Me.y_size_tb)
        Me.GroupBox1.Controls.Add(Me.x_size_tb)
        Me.GroupBox1.Controls.Add(Me.x1980x1200_rb)
        Me.GroupBox1.Controls.Add(Me.x1440_rb)
        Me.GroupBox1.Controls.Add(Me.x1280_rb)
        Me.GroupBox1.Controls.Add(Me.x1366_rb)
        Me.GroupBox1.Controls.Add(Me.x1920_rb)
        Me.GroupBox1.Controls.Add(Me.x64_rb)
        Me.GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 280)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Output Size"
        '
        'y_size_tb
        '
        Me.y_size_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.y_size_tb.ForeColor = System.Drawing.Color.White
        Me.y_size_tb.Location = New System.Drawing.Point(6, 252)
        Me.y_size_tb.Name = "y_size_tb"
        Me.y_size_tb.Size = New System.Drawing.Size(76, 20)
        Me.y_size_tb.TabIndex = 6
        Me.y_size_tb.Text = "480"
        '
        'x_size_tb
        '
        Me.x_size_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.x_size_tb.ForeColor = System.Drawing.Color.White
        Me.x_size_tb.Location = New System.Drawing.Point(6, 230)
        Me.x_size_tb.Name = "x_size_tb"
        Me.x_size_tb.Size = New System.Drawing.Size(76, 20)
        Me.x_size_tb.TabIndex = 4
        Me.x_size_tb.Text = "800"
        '
        'x1980x1200_rb
        '
        Me.x1980x1200_rb.AutoSize = True
        Me.x1980x1200_rb.Location = New System.Drawing.Point(6, 24)
        Me.x1980x1200_rb.Name = "x1980x1200_rb"
        Me.x1980x1200_rb.Size = New System.Drawing.Size(84, 17)
        Me.x1980x1200_rb.TabIndex = 5
        Me.x1980x1200_rb.Text = "1920 x 1200"
        Me.x1980x1200_rb.UseVisualStyleBackColor = True
        '
        'x1440_rb
        '
        Me.x1440_rb.AutoSize = True
        Me.x1440_rb.Location = New System.Drawing.Point(6, 70)
        Me.x1440_rb.Name = "x1440_rb"
        Me.x1440_rb.Size = New System.Drawing.Size(78, 17)
        Me.x1440_rb.TabIndex = 4
        Me.x1440_rb.Text = "1440 x 900"
        Me.x1440_rb.UseVisualStyleBackColor = True
        '
        'x1280_rb
        '
        Me.x1280_rb.AutoSize = True
        Me.x1280_rb.Location = New System.Drawing.Point(6, 93)
        Me.x1280_rb.Name = "x1280_rb"
        Me.x1280_rb.Size = New System.Drawing.Size(78, 17)
        Me.x1280_rb.TabIndex = 3
        Me.x1280_rb.Text = "1280 x 800"
        Me.x1280_rb.UseVisualStyleBackColor = True
        '
        'x1366_rb
        '
        Me.x1366_rb.AutoSize = True
        Me.x1366_rb.Location = New System.Drawing.Point(6, 116)
        Me.x1366_rb.Name = "x1366_rb"
        Me.x1366_rb.Size = New System.Drawing.Size(78, 17)
        Me.x1366_rb.TabIndex = 2
        Me.x1366_rb.Text = "1366 x 768"
        Me.x1366_rb.UseVisualStyleBackColor = True
        '
        'x1920_rb
        '
        Me.x1920_rb.AutoSize = True
        Me.x1920_rb.Location = New System.Drawing.Point(6, 47)
        Me.x1920_rb.Name = "x1920_rb"
        Me.x1920_rb.Size = New System.Drawing.Size(84, 17)
        Me.x1920_rb.TabIndex = 1
        Me.x1920_rb.Text = "1920 x 1080"
        Me.x1920_rb.UseVisualStyleBackColor = True
        '
        'x64_rb
        '
        Me.x64_rb.AutoSize = True
        Me.x64_rb.Checked = True
        Me.x64_rb.Location = New System.Drawing.Point(6, 210)
        Me.x64_rb.Name = "x64_rb"
        Me.x64_rb.Size = New System.Drawing.Size(60, 17)
        Me.x64_rb.TabIndex = 0
        Me.x64_rb.TabStop = True
        Me.x64_rb.Text = "Custom"
        Me.x64_rb.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.image_rb)
        Me.GroupBox2.Controls.Add(Me.pick_color_btn)
        Me.GroupBox2.Controls.Add(Me.color_rb)
        Me.GroupBox2.Controls.Add(Me.terrain_rb)
        Me.GroupBox2.Controls.Add(Me.trans_rb)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(213, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(101, 169)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Background"
        '
        'pick_color_btn
        '
        Me.pick_color_btn.Enabled = False
        Me.pick_color_btn.ForeColor = System.Drawing.Color.Black
        Me.pick_color_btn.Location = New System.Drawing.Point(10, 93)
        Me.pick_color_btn.Name = "pick_color_btn"
        Me.pick_color_btn.Size = New System.Drawing.Size(75, 23)
        Me.pick_color_btn.TabIndex = 3
        Me.pick_color_btn.Text = "Pick Color"
        Me.pick_color_btn.UseVisualStyleBackColor = True
        '
        'color_rb
        '
        Me.color_rb.AutoSize = True
        Me.color_rb.Location = New System.Drawing.Point(7, 70)
        Me.color_rb.Name = "color_rb"
        Me.color_rb.Size = New System.Drawing.Size(49, 17)
        Me.color_rb.TabIndex = 2
        Me.color_rb.Text = "Color"
        Me.color_rb.UseVisualStyleBackColor = True
        '
        'terrain_rb
        '
        Me.terrain_rb.AutoSize = True
        Me.terrain_rb.Location = New System.Drawing.Point(6, 47)
        Me.terrain_rb.Name = "terrain_rb"
        Me.terrain_rb.Size = New System.Drawing.Size(58, 17)
        Me.terrain_rb.TabIndex = 1
        Me.terrain_rb.Text = "Terrain"
        Me.terrain_rb.UseVisualStyleBackColor = True
        '
        'trans_rb
        '
        Me.trans_rb.AutoSize = True
        Me.trans_rb.Checked = True
        Me.trans_rb.Location = New System.Drawing.Point(6, 24)
        Me.trans_rb.Name = "trans_rb"
        Me.trans_rb.Size = New System.Drawing.Size(82, 17)
        Me.trans_rb.TabIndex = 0
        Me.trans_rb.TabStop = True
        Me.trans_rb.Text = "Transparent"
        Me.trans_rb.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.ForeColor = System.Drawing.Color.Black
        Me.save_btn.Location = New System.Drawing.Point(237, 298)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(77, 23)
        Me.save_btn.TabIndex = 2
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'cancel_btn
        '
        Me.cancel_btn.ForeColor = System.Drawing.Color.Black
        Me.cancel_btn.Location = New System.Drawing.Point(12, 298)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(98, 23)
        Me.cancel_btn.TabIndex = 3
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = True
        '
        'image_rb
        '
        Me.image_rb.AutoSize = True
        Me.image_rb.Location = New System.Drawing.Point(7, 140)
        Me.image_rb.Name = "image_rb"
        Me.image_rb.Size = New System.Drawing.Size(54, 17)
        Me.image_rb.TabIndex = 4
        Me.image_rb.Text = "Image"
        Me.image_rb.UseVisualStyleBackColor = True
        '
        'wot_carousel_rb
        '
        Me.wot_carousel_rb.AutoSize = True
        Me.wot_carousel_rb.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wot_carousel_rb.Location = New System.Drawing.Point(6, 140)
        Me.wot_carousel_rb.Name = "wot_carousel_rb"
        Me.wot_carousel_rb.Size = New System.Drawing.Size(163, 16)
        Me.wot_carousel_rb.TabIndex = 7
        Me.wot_carousel_rb.Text = "WoT Carousel 160x100"
        Me.wot_carousel_rb.UseVisualStyleBackColor = True
        '
        'wot_panel_rb
        '
        Me.wot_panel_rb.AutoSize = True
        Me.wot_panel_rb.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wot_panel_rb.Location = New System.Drawing.Point(6, 163)
        Me.wot_panel_rb.Name = "wot_panel_rb"
        Me.wot_panel_rb.Size = New System.Drawing.Size(163, 16)
        Me.wot_panel_rb.TabIndex = 8
        Me.wot_panel_rb.Text = "WoT Panel    420x307"
        Me.wot_panel_rb.UseVisualStyleBackColor = True
        '
        'wot_wotmod_rb
        '
        Me.wot_wotmod_rb.AutoSize = True
        Me.wot_wotmod_rb.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wot_wotmod_rb.Location = New System.Drawing.Point(6, 188)
        Me.wot_wotmod_rb.Name = "wot_wotmod_rb"
        Me.wot_wotmod_rb.Size = New System.Drawing.Size(163, 16)
        Me.wot_wotmod_rb.TabIndex = 9
        Me.wot_wotmod_rb.Text = "WoT Mods     302x170"
        Me.wot_wotmod_rb.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmScreenCap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(326, 333)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmScreenCap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Screen Capture"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents x1440_rb As System.Windows.Forms.RadioButton
    Friend WithEvents x1280_rb As System.Windows.Forms.RadioButton
    Friend WithEvents x1366_rb As System.Windows.Forms.RadioButton
    Friend WithEvents x1920_rb As System.Windows.Forms.RadioButton
    Friend WithEvents x64_rb As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pick_color_btn As System.Windows.Forms.Button
    Friend WithEvents color_rb As System.Windows.Forms.RadioButton
    Friend WithEvents terrain_rb As System.Windows.Forms.RadioButton
    Friend WithEvents trans_rb As System.Windows.Forms.RadioButton
    Friend WithEvents save_btn As System.Windows.Forms.Button
    Friend WithEvents cancel_btn As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents x1980x1200_rb As System.Windows.Forms.RadioButton
    Friend WithEvents y_size_tb As System.Windows.Forms.TextBox
    Friend WithEvents x_size_tb As System.Windows.Forms.TextBox
    Friend WithEvents image_rb As System.Windows.Forms.RadioButton
    Friend WithEvents wot_wotmod_rb As System.Windows.Forms.RadioButton
    Friend WithEvents wot_panel_rb As System.Windows.Forms.RadioButton
    Friend WithEvents wot_carousel_rb As System.Windows.Forms.RadioButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
