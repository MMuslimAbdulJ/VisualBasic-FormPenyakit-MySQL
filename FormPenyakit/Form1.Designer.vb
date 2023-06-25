<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPenyakit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbKode = New System.Windows.Forms.TextBox()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.tbPenyakit = New System.Windows.Forms.TextBox()
        Me.cbICD = New System.Windows.Forms.ComboBox()
        Me.DGVPenyakit = New System.Windows.Forms.DataGridView()
        Me.btBaru = New System.Windows.Forms.Button()
        Me.btSimpan = New System.Windows.Forms.Button()
        Me.btHapus = New System.Windows.Forms.Button()
        Me.btTutup = New System.Windows.Forms.Button()
        CType(Me.DGVPenyakit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ICD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Penyakit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total"
        '
        'tbKode
        '
        Me.tbKode.Location = New System.Drawing.Point(193, 36)
        Me.tbKode.Name = "tbKode"
        Me.tbKode.Size = New System.Drawing.Size(179, 27)
        Me.tbKode.TabIndex = 4
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(193, 199)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(179, 27)
        Me.tbTotal.TabIndex = 5
        '
        'tbPenyakit
        '
        Me.tbPenyakit.Location = New System.Drawing.Point(193, 143)
        Me.tbPenyakit.Name = "tbPenyakit"
        Me.tbPenyakit.ReadOnly = True
        Me.tbPenyakit.Size = New System.Drawing.Size(365, 27)
        Me.tbPenyakit.TabIndex = 6
        '
        'cbICD
        '
        Me.cbICD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbICD.FormattingEnabled = True
        Me.cbICD.Location = New System.Drawing.Point(193, 89)
        Me.cbICD.Name = "cbICD"
        Me.cbICD.Size = New System.Drawing.Size(224, 28)
        Me.cbICD.TabIndex = 7
        '
        'DGVPenyakit
        '
        Me.DGVPenyakit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPenyakit.Location = New System.Drawing.Point(48, 292)
        Me.DGVPenyakit.Name = "DGVPenyakit"
        Me.DGVPenyakit.RowHeadersWidth = 51
        Me.DGVPenyakit.RowTemplate.Height = 29
        Me.DGVPenyakit.Size = New System.Drawing.Size(554, 193)
        Me.DGVPenyakit.TabIndex = 8
        '
        'btBaru
        '
        Me.btBaru.Location = New System.Drawing.Point(48, 247)
        Me.btBaru.Name = "btBaru"
        Me.btBaru.Size = New System.Drawing.Size(94, 29)
        Me.btBaru.TabIndex = 9
        Me.btBaru.Text = "Baru"
        Me.btBaru.UseVisualStyleBackColor = True
        '
        'btSimpan
        '
        Me.btSimpan.Location = New System.Drawing.Point(163, 247)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(94, 29)
        Me.btSimpan.TabIndex = 10
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'btHapus
        '
        Me.btHapus.Location = New System.Drawing.Point(279, 247)
        Me.btHapus.Name = "btHapus"
        Me.btHapus.Size = New System.Drawing.Size(94, 29)
        Me.btHapus.TabIndex = 11
        Me.btHapus.Text = "Hapus"
        Me.btHapus.UseVisualStyleBackColor = True
        '
        'btTutup
        '
        Me.btTutup.Location = New System.Drawing.Point(508, 247)
        Me.btTutup.Name = "btTutup"
        Me.btTutup.Size = New System.Drawing.Size(94, 29)
        Me.btTutup.TabIndex = 12
        Me.btTutup.Text = "Tutup"
        Me.btTutup.UseVisualStyleBackColor = True
        '
        'FormPenyakit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 533)
        Me.Controls.Add(Me.btTutup)
        Me.Controls.Add(Me.btHapus)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.btBaru)
        Me.Controls.Add(Me.DGVPenyakit)
        Me.Controls.Add(Me.cbICD)
        Me.Controls.Add(Me.tbPenyakit)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.tbKode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPenyakit"
        Me.Text = "Form Penyakit"
        CType(Me.DGVPenyakit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbKode As TextBox
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents tbPenyakit As TextBox
    Friend WithEvents cbICD As ComboBox
    Friend WithEvents DGVPenyakit As DataGridView
    Friend WithEvents btBaru As Button
    Friend WithEvents btSimpan As Button
    Friend WithEvents btHapus As Button
    Friend WithEvents btTutup As Button
End Class
