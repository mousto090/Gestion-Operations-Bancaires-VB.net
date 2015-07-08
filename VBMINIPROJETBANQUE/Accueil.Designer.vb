<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.Guichet = New System.Windows.Forms.PictureBox()
        Me.Banque = New System.Windows.Forms.PictureBox()
        Me.Authentification = New System.Windows.Forms.Panel()
        Me.LOGIN = New System.Windows.Forms.PictureBox()
        Me.T_MDP = New System.Windows.Forms.TextBox()
        Me.T_Utilisateur = New System.Windows.Forms.TextBox()
        Me.MDP = New System.Windows.Forms.Label()
        Me.Utilisateur = New System.Windows.Forms.Label()
        CType(Me.Guichet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Authentification.SuspendLayout()
        CType(Me.LOGIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guichet
        '
        Me.Guichet.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Guichet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guichet.Image = Global.VBMINIPROJETBANQUE.My.Resources.Resources.carteguichet
        Me.Guichet.Location = New System.Drawing.Point(0, 0)
        Me.Guichet.MaximumSize = New System.Drawing.Size(300, 510)
        Me.Guichet.MinimumSize = New System.Drawing.Size(300, 510)
        Me.Guichet.Name = "Guichet"
        Me.Guichet.Size = New System.Drawing.Size(300, 510)
        Me.Guichet.TabIndex = 0
        Me.Guichet.TabStop = False
        '
        'Banque
        '
        Me.Banque.BackColor = System.Drawing.Color.Transparent
        Me.Banque.BackgroundImage = CType(resources.GetObject("Banque.BackgroundImage"), System.Drawing.Image)
        Me.Banque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Banque.Location = New System.Drawing.Point(304, 0)
        Me.Banque.MaximumSize = New System.Drawing.Size(580, 510)
        Me.Banque.MinimumSize = New System.Drawing.Size(580, 510)
        Me.Banque.Name = "Banque"
        Me.Banque.Size = New System.Drawing.Size(580, 510)
        Me.Banque.TabIndex = 1
        Me.Banque.TabStop = False
        '
        'Authentification
        '
        Me.Authentification.BackColor = System.Drawing.Color.Transparent
        Me.Authentification.Controls.Add(Me.LOGIN)
        Me.Authentification.Controls.Add(Me.T_MDP)
        Me.Authentification.Controls.Add(Me.T_Utilisateur)
        Me.Authentification.Controls.Add(Me.MDP)
        Me.Authentification.Controls.Add(Me.Utilisateur)
        Me.Authentification.Location = New System.Drawing.Point(387, 402)
        Me.Authentification.Name = "Authentification"
        Me.Authentification.Size = New System.Drawing.Size(405, 92)
        Me.Authentification.TabIndex = 2
        '
        'LOGIN
        '
        Me.LOGIN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LOGIN.Image = Global.VBMINIPROJETBANQUE.My.Resources.Resources.login
        Me.LOGIN.Location = New System.Drawing.Point(313, 22)
        Me.LOGIN.Name = "LOGIN"
        Me.LOGIN.Size = New System.Drawing.Size(55, 50)
        Me.LOGIN.TabIndex = 4
        Me.LOGIN.TabStop = False
        '
        'T_MDP
        '
        Me.T_MDP.Location = New System.Drawing.Point(139, 55)
        Me.T_MDP.Name = "T_MDP"
        Me.T_MDP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.T_MDP.Size = New System.Drawing.Size(155, 21)
        Me.T_MDP.TabIndex = 3
        '
        'T_Utilisateur
        '
        Me.T_Utilisateur.Location = New System.Drawing.Point(139, 16)
        Me.T_Utilisateur.Name = "T_Utilisateur"
        Me.T_Utilisateur.Size = New System.Drawing.Size(155, 21)
        Me.T_Utilisateur.TabIndex = 2
        '
        'MDP
        '
        Me.MDP.AutoSize = True
        Me.MDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MDP.Location = New System.Drawing.Point(29, 58)
        Me.MDP.Name = "MDP"
        Me.MDP.Size = New System.Drawing.Size(96, 16)
        Me.MDP.TabIndex = 1
        Me.MDP.Text = "Mot de passe :"
        '
        'Utilisateur
        '
        Me.Utilisateur.AutoSize = True
        Me.Utilisateur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Utilisateur.Location = New System.Drawing.Point(29, 19)
        Me.Utilisateur.Name = "Utilisateur"
        Me.Utilisateur.Size = New System.Drawing.Size(73, 16)
        Me.Utilisateur.TabIndex = 0
        Me.Utilisateur.Text = "Utilisateur :"
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VBMINIPROJETBANQUE.My.Resources.Resources.bcg
        Me.ClientSize = New System.Drawing.Size(884, 511)
        Me.Controls.Add(Me.Authentification)
        Me.Controls.Add(Me.Banque)
        Me.Controls.Add(Me.Guichet)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 550)
        Me.MinimumSize = New System.Drawing.Size(900, 550)
        Me.Name = "Accueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Banque Marocain de Squelette Kwala"
        CType(Me.Guichet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Authentification.ResumeLayout(False)
        Me.Authentification.PerformLayout()
        CType(Me.LOGIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guichet As System.Windows.Forms.PictureBox
    Friend WithEvents Banque As System.Windows.Forms.PictureBox
    Friend WithEvents Authentification As System.Windows.Forms.Panel
    Friend WithEvents MDP As System.Windows.Forms.Label
    Friend WithEvents Utilisateur As System.Windows.Forms.Label
    Friend WithEvents T_Utilisateur As System.Windows.Forms.TextBox
    Friend WithEvents T_MDP As System.Windows.Forms.TextBox
    Friend WithEvents LOGIN As System.Windows.Forms.PictureBox

End Class
