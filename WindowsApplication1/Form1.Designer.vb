<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrimePairs
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
        Me.btnFindPrimes = New System.Windows.Forms.Button()
        Me.txtUpperBound = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTwinCount = New System.Windows.Forms.Label()
        Me.lblPrimeFamily = New System.Windows.Forms.Label()
        Me.lblSexyCount = New System.Windows.Forms.Label()
        Me.lblTwinPrimes = New System.Windows.Forms.Label()
        Me.lblCousinPrimes = New System.Windows.Forms.Label()
        Me.lblSexyPrimes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFindPrimes
        '
        Me.btnFindPrimes.Location = New System.Drawing.Point(274, 27)
        Me.btnFindPrimes.Name = "btnFindPrimes"
        Me.btnFindPrimes.Size = New System.Drawing.Size(80, 27)
        Me.btnFindPrimes.TabIndex = 0
        Me.btnFindPrimes.Text = "Accept"
        Me.btnFindPrimes.UseVisualStyleBackColor = True
        '
        'txtUpperBound
        '
        Me.txtUpperBound.Location = New System.Drawing.Point(109, 31)
        Me.txtUpperBound.Name = "txtUpperBound"
        Me.txtUpperBound.Size = New System.Drawing.Size(150, 20)
        Me.txtUpperBound.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Prime Pairs"
        '
        'lblTwinCount
        '
        Me.lblTwinCount.AutoSize = True
        Me.lblTwinCount.Location = New System.Drawing.Point(38, 102)
        Me.lblTwinCount.Name = "lblTwinCount"
        Me.lblTwinCount.Size = New System.Drawing.Size(61, 13)
        Me.lblTwinCount.TabIndex = 3
        Me.lblTwinCount.Text = "Twin Count"
        '
        'lblPrimeFamily
        '
        Me.lblPrimeFamily.AutoSize = True
        Me.lblPrimeFamily.Location = New System.Drawing.Point(163, 102)
        Me.lblPrimeFamily.Name = "lblPrimeFamily"
        Me.lblPrimeFamily.Size = New System.Drawing.Size(70, 13)
        Me.lblPrimeFamily.TabIndex = 4
        Me.lblPrimeFamily.Text = "Cousin Count"
        '
        'lblSexyCount
        '
        Me.lblSexyCount.AutoSize = True
        Me.lblSexyCount.Location = New System.Drawing.Point(284, 102)
        Me.lblSexyCount.Name = "lblSexyCount"
        Me.lblSexyCount.Size = New System.Drawing.Size(61, 13)
        Me.lblSexyCount.TabIndex = 5
        Me.lblSexyCount.Text = "Sexy Count"
        '
        'lblTwinPrimes
        '
        Me.lblTwinPrimes.AutoSize = True
        Me.lblTwinPrimes.Location = New System.Drawing.Point(38, 141)
        Me.lblTwinPrimes.Name = "lblTwinPrimes"
        Me.lblTwinPrimes.Size = New System.Drawing.Size(16, 13)
        Me.lblTwinPrimes.TabIndex = 6
        Me.lblTwinPrimes.Text = "..."
        '
        'lblCousinPrimes
        '
        Me.lblCousinPrimes.AutoSize = True
        Me.lblCousinPrimes.Location = New System.Drawing.Point(163, 141)
        Me.lblCousinPrimes.Name = "lblCousinPrimes"
        Me.lblCousinPrimes.Size = New System.Drawing.Size(16, 13)
        Me.lblCousinPrimes.TabIndex = 7
        Me.lblCousinPrimes.Text = "..."
        '
        'lblSexyPrimes
        '
        Me.lblSexyPrimes.AutoSize = True
        Me.lblSexyPrimes.Location = New System.Drawing.Point(284, 141)
        Me.lblSexyPrimes.Name = "lblSexyPrimes"
        Me.lblSexyPrimes.Size = New System.Drawing.Size(16, 13)
        Me.lblSexyPrimes.TabIndex = 8
        Me.lblSexyPrimes.Text = "..."
        '
        'frmPrimePairs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 443)
        Me.Controls.Add(Me.lblSexyPrimes)
        Me.Controls.Add(Me.lblCousinPrimes)
        Me.Controls.Add(Me.lblTwinPrimes)
        Me.Controls.Add(Me.lblSexyCount)
        Me.Controls.Add(Me.lblPrimeFamily)
        Me.Controls.Add(Me.lblTwinCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUpperBound)
        Me.Controls.Add(Me.btnFindPrimes)
        Me.Name = "frmPrimePairs"
        Me.Text = "Prime Pairs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFindPrimes As System.Windows.Forms.Button
    Friend WithEvents txtUpperBound As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTwinCount As System.Windows.Forms.Label
    Friend WithEvents lblPrimeFamily As System.Windows.Forms.Label
    Friend WithEvents lblSexyCount As System.Windows.Forms.Label
    Friend WithEvents lblTwinPrimes As System.Windows.Forms.Label
    Friend WithEvents lblCousinPrimes As System.Windows.Forms.Label
    Friend WithEvents lblSexyPrimes As System.Windows.Forms.Label

    Private Sub frmPrimePairs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFindPrimes_Click(sender As Object, e As EventArgs) Handles btnFindPrimes.Click

    End Sub
End Class
