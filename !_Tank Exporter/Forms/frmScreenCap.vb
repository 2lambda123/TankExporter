﻿#Region "imports"
Imports System.Windows
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Xml
Imports System.Web
Imports Tao.OpenGl
Imports Tao.Platform.Windows
Imports Tao.FreeGlut
Imports Tao.FreeGlut.Glut
Imports Microsoft.VisualBasic.Strings
Imports System.Math
Imports System.Object
Imports System.Threading
Imports System.Data
Imports Tao.DevIl
Imports System.Runtime.InteropServices
Imports System.Runtime.CompilerServices
Imports System.Collections.Generic
Imports Ionic.Zip
Imports System.Drawing.Imaging
Imports System.Globalization
#End Region


Public Class frmScreenCap
    Public r_size As New Size
    Public r_trans As Boolean
    Public r_terrain As Boolean
    Public r_color_flag As Boolean
    Public r_color_val(3) As Single
    Public RENDER_OUT As Boolean
    Public r_filename As String
    Private r_color = Color.DarkGray
    Public Sub set_background_mode()
        r_trans = trans_rb.Checked
        r_terrain = terrain_rb.Checked
        r_color_flag = color_rb.Checked
        ColorDialog1.Color = r_color
        r_color_val(0) = CSng(r_color.R / 255)
        r_color_val(1) = CSng(r_color.G / 255)
        r_color_val(2) = CSng(r_color.B / 255)
        r_color_val(3) = 1.0

    End Sub

    Public Sub set_size()
        If x1980x1200_rb.Checked Then
            r_size.Width = 1920
            r_size.Height = 1200
        End If
        If x1920_rb.Checked Then
            r_size.Width = 1920
            r_size.Height = 1080
        End If
        If x1440_rb.Checked Then
            r_size.Width = 1440
            r_size.Height = 900
        End If
        If x1280_rb.Checked Then
            r_size.Width = 1280
            r_size.Height = 800
        End If
        If x1366_rb.Checked Then
            r_size.Width = 1366
            r_size.Height = 768
        End If
        If x64_rb.Checked Then
            r_size.Width = 114
            r_size.Height = 64
        End If

    End Sub
    Private Sub x1980x1200_rb_CheckedChanged(sender As Object, e As EventArgs) Handles x1980x1200_rb.CheckedChanged
        set_size()
    End Sub
    Private Sub x1920_rb_CheckedChanged(sender As Object, e As EventArgs) Handles x1920_rb.CheckedChanged
        set_size()
    End Sub

    Private Sub x1440_rb_CheckedChanged(sender As Object, e As EventArgs) Handles x1440_rb.CheckedChanged
        set_size()
    End Sub

    Private Sub x1280_rb_CheckedChanged(sender As Object, e As EventArgs) Handles x1280_rb.CheckedChanged
        set_size()
    End Sub

    Private Sub x1366_rb_CheckedChanged(sender As Object, e As EventArgs) Handles x1366_rb.CheckedChanged
        set_size()
    End Sub

    Private Sub x64_rb_CheckedChanged(sender As Object, e As EventArgs) Handles x64_rb.CheckedChanged
        set_size()
    End Sub

    Private Sub trans_rb_CheckedChanged(sender As Object, e As EventArgs) Handles trans_rb.CheckedChanged
        r_trans = trans_rb.Checked
    End Sub

    Private Sub terrain_rb_CheckedChanged(sender As Object, e As EventArgs) Handles terrain_rb.CheckedChanged
        r_terrain = terrain_rb.Checked
    End Sub

    Private Sub color_rb_CheckedChanged(sender As Object, e As EventArgs) Handles color_rb.CheckedChanged
        r_color_flag = color_rb.Checked
        If color_rb.Checked Then
            pick_color_btn.Enabled = True
        Else
            pick_color_btn.Enabled = False
        End If
    End Sub

    Private Sub pick_color_btn_Click(sender As Object, e As EventArgs) Handles pick_color_btn.Click
        ColorDialog1.Color = r_color
        If ColorDialog1.ShowDialog <> Forms.DialogResult.Cancel Then
            r_color = ColorDialog1.Color
            r_color_val(0) = CSng(r_color.R / 255)
            r_color_val(1) = CSng(r_color.G / 255)
            r_color_val(2) = CSng(r_color.B / 255)
            r_color_val(3) = 1.0
        End If
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        SaveFileDialog1.Title = "Save Screen Capture PNG file..."
        SaveFileDialog1.Filter = "Save PNG Image (*.png*)|*.png"
        If SaveFileDialog1.ShowDialog = Forms.DialogResult.OK _
         Then
            r_filename = SaveFileDialog1.FileName
            RENDER_OUT = True
            frmMain.pb1.Dock = DockStyle.None
            frmMain.pb1.Size = r_size
            Application.DoEvents()
            G_Buffer.init()
            Gl.glBindFramebufferEXT(Gl.GL_FRAMEBUFFER_EXT, gBufferFBO)
            G_Buffer.attachColorTexture()
            frmMain.draw_scene()
            RENDER_OUT = False
            save_image()
            frmMain.pb1.Dock = DockStyle.Fill
            Application.DoEvents()
            G_Buffer.init()
            Me.Hide()
            'frmMain.draw_scene()
            'G_Buffer.init()
        End If
    End Sub

    Private Sub frmScreenCap_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub frmScreenCap_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        frmMain.draw_scene()
    End Sub
    Private Sub save_image()
        Application.DoEvents()
        If Not (Wgl.wglMakeCurrent(pb1_hDC, pb1_hRC)) Then
            MessageBox.Show("Unable to make rendering context current")
            End
        End If
        'frmMain.gl_stop = True
        'While gl_busy
        'End While
        set_background_mode()
        set_size()
        Dim w, h As Integer
        Gl.glEnable(Gl.GL_TEXTURE_2D)
        Gl.glActiveTexture(Gl.GL_TEXTURE0)
        w = frmMain.pb1.Width
        h = frmMain.pb1.Height
        Gl.glFinish()
        Dim tId As Integer = Il.ilGenImage
        Il.ilBindImage(tId)
        Il.ilTexImage(w, h, 0, 4, Il.IL_RGBA, Il.IL_UNSIGNED_BYTE, Nothing)

        Gl.glReadPixels(0, 0, w, h, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, Il.ilGetData())
        Gl.glFinish()

        Gl.glFinish()
        Il.ilSave(Il.IL_PNG, r_filename) ' save to temp
        Gl.glDisable(Gl.GL_TEXTURE_2D)
        Il.ilBindImage(0)
        Il.ilDeleteImage(tId)
        Application.DoEvents()


    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Hide()
    End Sub

End Class