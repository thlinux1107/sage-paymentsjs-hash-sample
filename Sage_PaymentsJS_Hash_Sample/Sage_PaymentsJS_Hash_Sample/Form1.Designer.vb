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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtJSONresp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHash = New System.Windows.Forms.TextBox()
        Me.txtComputedHash = New System.Windows.Forms.TextBox()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.txtResponse = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtJSONresp
        '
        Me.txtJSONresp.Location = New System.Drawing.Point(40, 41)
        Me.txtJSONresp.Multiline = True
        Me.txtJSONresp.Name = "txtJSONresp"
        Me.txtJSONresp.Size = New System.Drawing.Size(312, 319)
        Me.txtJSONresp.TabIndex = 0
        Me.txtJSONresp.Text = resources.GetString("txtJSONresp.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "JSON Response"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 476)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hash"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 532)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Computed Hash"
        '
        'txtHash
        '
        Me.txtHash.Location = New System.Drawing.Point(40, 492)
        Me.txtHash.Name = "txtHash"
        Me.txtHash.Size = New System.Drawing.Size(630, 20)
        Me.txtHash.TabIndex = 4
        '
        'txtComputedHash
        '
        Me.txtComputedHash.Location = New System.Drawing.Point(40, 548)
        Me.txtComputedHash.Name = "txtComputedHash"
        Me.txtComputedHash.Size = New System.Drawing.Size(630, 20)
        Me.txtComputedHash.TabIndex = 5
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(40, 366)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 23)
        Me.btnProcess.TabIndex = 6
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'txtResponse
        '
        Me.txtResponse.Location = New System.Drawing.Point(40, 437)
        Me.txtResponse.Name = "txtResponse"
        Me.txtResponse.Size = New System.Drawing.Size(630, 20)
        Me.txtResponse.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 421)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Response"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 610)
        Me.Controls.Add(Me.txtResponse)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.txtComputedHash)
        Me.Controls.Add(Me.txtHash)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtJSONresp)
        Me.Name = "Form1"
        Me.Text = "Sage PaymentsJS Sample Hash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtJSONresp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHash As TextBox
    Friend WithEvents txtComputedHash As TextBox
    Friend WithEvents btnProcess As Button
    Friend WithEvents txtResponse As TextBox
    Friend WithEvents Label4 As Label
End Class
