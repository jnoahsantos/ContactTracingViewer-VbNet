<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewerApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewerApp))
        Me.listBox = New System.Windows.Forms.ListBox()
        Me.btnViewData = New System.Windows.Forms.Button()
        Me.labelTitle1 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtBxSearch = New System.Windows.Forms.TextBox()
        Me.labelSearchWarning = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.panel2.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listBox
        '
        Me.listBox.BackColor = System.Drawing.Color.PaleVioletRed
        Me.listBox.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.listBox.FormattingEnabled = True
        Me.listBox.ItemHeight = 19
        Me.listBox.Location = New System.Drawing.Point(25, 196)
        Me.listBox.Name = "listBox"
        Me.listBox.Size = New System.Drawing.Size(529, 270)
        Me.listBox.TabIndex = 11
        '
        'btnViewData
        '
        Me.btnViewData.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnViewData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnViewData.FlatAppearance.BorderSize = 0
        Me.btnViewData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewData.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewData.Location = New System.Drawing.Point(218, 3)
        Me.btnViewData.Name = "btnViewData"
        Me.btnViewData.Size = New System.Drawing.Size(146, 39)
        Me.btnViewData.TabIndex = 4
        Me.btnViewData.Text = "View Data"
        Me.btnViewData.UseVisualStyleBackColor = False
        '
        'labelTitle1
        '
        Me.labelTitle1.AutoSize = True
        Me.labelTitle1.Cursor = System.Windows.Forms.Cursors.No
        Me.labelTitle1.Font = New System.Drawing.Font("Cooper Black", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelTitle1.Location = New System.Drawing.Point(36, 21)
        Me.labelTitle1.Name = "labelTitle1"
        Me.labelTitle1.Size = New System.Drawing.Size(508, 46)
        Me.labelTitle1.TabIndex = 5
        Me.labelTitle1.Text = "Contact Tracing Viewer"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.LightPink
        Me.panel2.Controls.Add(Me.btnViewData)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 472)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(579, 48)
        Me.panel2.TabIndex = 18
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.listBox1)
        Me.panel1.Controls.Add(Me.labelTitle1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(579, 92)
        Me.panel1.TabIndex = 17
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(460, 135)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 29)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtBxSearch
        '
        Me.txtBxSearch.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtBxSearch.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtBxSearch.ForeColor = System.Drawing.Color.Black
        Me.txtBxSearch.Location = New System.Drawing.Point(25, 135)
        Me.txtBxSearch.Name = "txtBxSearch"
        Me.txtBxSearch.Size = New System.Drawing.Size(429, 27)
        Me.txtBxSearch.TabIndex = 15
        '
        'labelSearchWarning
        '
        Me.labelSearchWarning.AutoSize = True
        Me.labelSearchWarning.BackColor = System.Drawing.Color.Transparent
        Me.labelSearchWarning.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSearchWarning.ForeColor = System.Drawing.Color.Maroon
        Me.labelSearchWarning.Location = New System.Drawing.Point(22, 22)
        Me.labelSearchWarning.Name = "labelSearchWarning"
        Me.labelSearchWarning.Size = New System.Drawing.Size(0, 16)
        Me.labelSearchWarning.TabIndex = 12
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(22, 114)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(237, 18)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Search (M/D/YYYY or NAME):"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(22, 175)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(147, 18)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Choose one below:"
        '
        'listBox1
        '
        Me.listBox1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listBox1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.listBox1.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 19
        Me.listBox1.Location = New System.Drawing.Point(556, -1)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(22, 19)
        Me.listBox1.TabIndex = 19
        '
        'ViewerApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(579, 520)
        Me.Controls.Add(Me.listBox)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtBxSearch)
        Me.Controls.Add(Me.labelSearchWarning)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewerApp"
        Me.RightToLeftLayout = True
        Me.Text = "Contact Tracing Viewer"
        Me.panel2.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents listBox As ListBox
    Private WithEvents btnViewData As Button
    Private WithEvents labelTitle1 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents panel1 As Panel
    Private WithEvents btnSearch As Button
    Private WithEvents txtBxSearch As TextBox
    Private WithEvents labelSearchWarning As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents listBox1 As ListBox
End Class
