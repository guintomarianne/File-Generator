﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.Name = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Age = New System.Windows.Forms.TextBox()
        Me.TXTButton = New System.Windows.Forms.Button()
        Me.XMLButton = New System.Windows.Forms.Button()
        Me.JSONButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(23, 24)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(60, 22)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeLabel.Location = New System.Drawing.Point(23, 78)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(45, 22)
        Me.AgeLabel.TabIndex = 1
        Me.AgeLabel.Text = "Age"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLabel.Location = New System.Drawing.Point(23, 130)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(82, 22)
        Me.AddressLabel.TabIndex = 2
        Me.AddressLabel.Text = "Address"
        '
        'Name
        '
        Me.Name.Location = New System.Drawing.Point(107, 12)
        Me.Name.Multiline = True
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(415, 35)
        Me.Name.TabIndex = 3
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(107, 121)
        Me.Address.Multiline = True
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(415, 103)
        Me.Address.TabIndex = 4
        '
        'Age
        '
        Me.Age.Location = New System.Drawing.Point(107, 65)
        Me.Age.Multiline = True
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(125, 35)
        Me.Age.TabIndex = 5
        '
        'TXTButton
        '
        Me.TXTButton.BackColor = System.Drawing.Color.SteelBlue
        Me.TXTButton.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTButton.Location = New System.Drawing.Point(107, 254)
        Me.TXTButton.Name = "TXTButton"
        Me.TXTButton.Size = New System.Drawing.Size(105, 48)
        Me.TXTButton.TabIndex = 6
        Me.TXTButton.Text = "TXT"
        Me.TXTButton.UseVisualStyleBackColor = False
        '
        'XMLButton
        '
        Me.XMLButton.BackColor = System.Drawing.Color.LimeGreen
        Me.XMLButton.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XMLButton.ForeColor = System.Drawing.Color.Black
        Me.XMLButton.Location = New System.Drawing.Point(266, 254)
        Me.XMLButton.Name = "XMLButton"
        Me.XMLButton.Size = New System.Drawing.Size(105, 48)
        Me.XMLButton.TabIndex = 7
        Me.XMLButton.Text = "XML"
        Me.XMLButton.UseVisualStyleBackColor = False
        '
        'JSONButton
        '
        Me.JSONButton.BackColor = System.Drawing.Color.Goldenrod
        Me.JSONButton.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JSONButton.ForeColor = System.Drawing.Color.Black
        Me.JSONButton.Location = New System.Drawing.Point(417, 254)
        Me.JSONButton.Name = "JSONButton"
        Me.JSONButton.Size = New System.Drawing.Size(105, 48)
        Me.JSONButton.TabIndex = 8
        Me.JSONButton.Text = "JSON"
        Me.JSONButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 327)
        Me.Controls.Add(Me.JSONButton)
        Me.Controls.Add(Me.XMLButton)
        Me.Controls.Add(Me.TXTButton)
        Me.Controls.Add(Me.Age)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.AgeLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Name = "Form1"
        Me.Text = "File Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents Name As TextBox
    Friend WithEvents Address As TextBox
    Friend WithEvents Age As TextBox
    Friend WithEvents TXTButton As Button
    Friend WithEvents XMLButton As Button
    Friend WithEvents JSONButton As Button
End Class