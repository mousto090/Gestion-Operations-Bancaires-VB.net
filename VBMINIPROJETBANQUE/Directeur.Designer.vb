<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Directeur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Directeur))
        Me.PPRINCIPAL = New System.Windows.Forms.Panel()
        Me.PPRIN = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Bie = New System.Windows.Forms.Label()
        Me.PLISCLI = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PCLIETR = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PCLIREC = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PLOGO = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PDA = New System.Windows.Forms.Panel()
        Me.DateActuel = New System.Windows.Forms.DateTimePicker()
        Me.PAGENTS = New System.Windows.Forms.Panel()
        Me.LOGAOUTAGENT = New System.Windows.Forms.PictureBox()
        Me.AGENTS = New System.Windows.Forms.Label()
        Me.M = New System.Windows.Forms.Label()
        Me.Bienvenu = New System.Windows.Forms.Label()
        Me.MENU = New System.Windows.Forms.Panel()
        Me.CLIREC = New System.Windows.Forms.PictureBox()
        Me.LISDESCLI = New System.Windows.Forms.PictureBox()
        Me.CLIETR = New System.Windows.Forms.PictureBox()
        Me.PPRINCIPAL.SuspendLayout()
        Me.PPRIN.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PLISCLI.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PCLIETR.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.PCLIREC.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.PLOGO.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PDA.SuspendLayout()
        Me.PAGENTS.SuspendLayout()
        CType(Me.LOGAOUTAGENT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MENU.SuspendLayout()
        CType(Me.CLIREC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LISDESCLI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIETR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PPRINCIPAL
        '
        Me.PPRINCIPAL.BackColor = System.Drawing.Color.Transparent
        Me.PPRINCIPAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PPRINCIPAL.Controls.Add(Me.PPRIN)
        Me.PPRINCIPAL.Controls.Add(Me.PLISCLI)
        Me.PPRINCIPAL.Controls.Add(Me.PCLIETR)
        Me.PPRINCIPAL.Controls.Add(Me.PCLIREC)
        Me.PPRINCIPAL.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PPRINCIPAL.Location = New System.Drawing.Point(180, 106)
        Me.PPRINCIPAL.Name = "PPRINCIPAL"
        Me.PPRINCIPAL.Size = New System.Drawing.Size(678, 381)
        Me.PPRINCIPAL.TabIndex = 14
        '
        'PPRIN
        '
        Me.PPRIN.Controls.Add(Me.PictureBox2)
        Me.PPRIN.Controls.Add(Me.Bie)
        Me.PPRIN.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PPRIN.Location = New System.Drawing.Point(21, 27)
        Me.PPRIN.Name = "PPRIN"
        Me.PPRIN.Size = New System.Drawing.Size(629, 335)
        Me.PPRIN.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.VBMINIPROJETBANQUE.My.Resources.Resources.lg3
        Me.PictureBox2.Location = New System.Drawing.Point(145, 141)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(310, 115)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Bie
        '
        Me.Bie.AutoSize = True
        Me.Bie.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bie.ForeColor = System.Drawing.Color.White
        Me.Bie.Location = New System.Drawing.Point(64, 84)
        Me.Bie.Name = "Bie"
        Me.Bie.Size = New System.Drawing.Size(491, 31)
        Me.Bie.TabIndex = 2
        Me.Bie.Text = "Bienvenu Dans Votre Banque Populaire"
        '
        'PLISCLI
        '
        Me.PLISCLI.Controls.Add(Me.GroupBox3)
        Me.PLISCLI.Controls.Add(Me.GroupBox2)
        Me.PLISCLI.Controls.Add(Me.GroupBox1)
        Me.PLISCLI.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PLISCLI.Location = New System.Drawing.Point(21, 27)
        Me.PLISCLI.Name = "PLISCLI"
        Me.PLISCLI.Size = New System.Drawing.Size(629, 335)
        Me.PLISCLI.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(601, 181)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Liste Des Clients"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(16, 20)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(568, 150)
        Me.DataGridView2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(601, 50)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saisir De Montant"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(245, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 21)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Montant :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(601, 58)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option de Recherche"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(437, 23)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(112, 19)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Tous Les Cients"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(245, 23)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(77, 19)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Inferieure"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(55, 23)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(86, 19)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Superieure"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'PCLIETR
        '
        Me.PCLIETR.Controls.Add(Me.GroupBox6)
        Me.PCLIETR.Controls.Add(Me.GroupBox7)
        Me.PCLIETR.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PCLIETR.Location = New System.Drawing.Point(21, 27)
        Me.PCLIETR.Name = "PCLIETR"
        Me.PCLIETR.Size = New System.Drawing.Size(629, 335)
        Me.PCLIETR.TabIndex = 7
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DataGridView3)
        Me.GroupBox6.Location = New System.Drawing.Point(15, 83)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(596, 228)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Liste Des Clients"
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(17, 25)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(559, 185)
        Me.DataGridView3.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.ComboBox2)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Location = New System.Drawing.Point(15, 17)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(596, 56)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Choix De Nationalité"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(255, 23)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(144, 23)
        Me.ComboBox2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(177, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nationalité :"
        '
        'PCLIREC
        '
        Me.PCLIREC.Controls.Add(Me.GroupBox5)
        Me.PCLIREC.Controls.Add(Me.GroupBox4)
        Me.PCLIREC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PCLIREC.Location = New System.Drawing.Point(21, 27)
        Me.PCLIREC.Name = "PCLIREC"
        Me.PCLIREC.Size = New System.Drawing.Size(629, 335)
        Me.PCLIREC.TabIndex = 5
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 83)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(596, 228)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Liste Des Clients"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(559, 185)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(596, 56)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Choix De Dates"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(215, 23)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date :"
        '
        'PLOGO
        '
        Me.PLOGO.BackColor = System.Drawing.Color.Transparent
        Me.PLOGO.Controls.Add(Me.PictureBox1)
        Me.PLOGO.Location = New System.Drawing.Point(304, 12)
        Me.PLOGO.Name = "PLOGO"
        Me.PLOGO.Size = New System.Drawing.Size(200, 61)
        Me.PLOGO.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 60)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PDA
        '
        Me.PDA.BackColor = System.Drawing.Color.Transparent
        Me.PDA.Controls.Add(Me.DateActuel)
        Me.PDA.Location = New System.Drawing.Point(26, 12)
        Me.PDA.Name = "PDA"
        Me.PDA.Size = New System.Drawing.Size(245, 61)
        Me.PDA.TabIndex = 12
        '
        'DateActuel
        '
        Me.DateActuel.Location = New System.Drawing.Point(21, 21)
        Me.DateActuel.Name = "DateActuel"
        Me.DateActuel.Size = New System.Drawing.Size(200, 21)
        Me.DateActuel.TabIndex = 0
        '
        'PAGENTS
        '
        Me.PAGENTS.BackColor = System.Drawing.Color.Transparent
        Me.PAGENTS.Controls.Add(Me.LOGAOUTAGENT)
        Me.PAGENTS.Controls.Add(Me.AGENTS)
        Me.PAGENTS.Controls.Add(Me.M)
        Me.PAGENTS.Controls.Add(Me.Bienvenu)
        Me.PAGENTS.Location = New System.Drawing.Point(531, 12)
        Me.PAGENTS.Name = "PAGENTS"
        Me.PAGENTS.Size = New System.Drawing.Size(327, 61)
        Me.PAGENTS.TabIndex = 11
        '
        'LOGAOUTAGENT
        '
        Me.LOGAOUTAGENT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LOGAOUTAGENT.Image = CType(resources.GetObject("LOGAOUTAGENT.Image"), System.Drawing.Image)
        Me.LOGAOUTAGENT.Location = New System.Drawing.Point(262, 6)
        Me.LOGAOUTAGENT.Name = "LOGAOUTAGENT"
        Me.LOGAOUTAGENT.Size = New System.Drawing.Size(55, 50)
        Me.LOGAOUTAGENT.TabIndex = 3
        Me.LOGAOUTAGENT.TabStop = False
        '
        'AGENTS
        '
        Me.AGENTS.AutoSize = True
        Me.AGENTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGENTS.Location = New System.Drawing.Point(133, 21)
        Me.AGENTS.Name = "AGENTS"
        Me.AGENTS.Size = New System.Drawing.Size(77, 13)
        Me.AGENTS.TabIndex = 2
        Me.AGENTS.Text = "Le Directeur"
        '
        'M
        '
        Me.M.AutoSize = True
        Me.M.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M.Location = New System.Drawing.Point(75, 21)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(58, 13)
        Me.M.TabIndex = 1
        Me.M.Text = "Monsieur"
        '
        'Bienvenu
        '
        Me.Bienvenu.AutoSize = True
        Me.Bienvenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bienvenu.Location = New System.Drawing.Point(9, 21)
        Me.Bienvenu.Name = "Bienvenu"
        Me.Bienvenu.Size = New System.Drawing.Size(67, 13)
        Me.Bienvenu.TabIndex = 0
        Me.Bienvenu.Text = "Bienvenue"
        '
        'MENU
        '
        Me.MENU.BackColor = System.Drawing.Color.White
        Me.MENU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MENU.Controls.Add(Me.CLIREC)
        Me.MENU.Controls.Add(Me.LISDESCLI)
        Me.MENU.Controls.Add(Me.CLIETR)
        Me.MENU.Location = New System.Drawing.Point(26, 106)
        Me.MENU.Name = "MENU"
        Me.MENU.Size = New System.Drawing.Size(133, 381)
        Me.MENU.TabIndex = 10
        '
        'CLIREC
        '
        Me.CLIREC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CLIREC.Image = Global.VBMINIPROJETBANQUE.My.Resources.Resources.CliREc
        Me.CLIREC.Location = New System.Drawing.Point(15, 297)
        Me.CLIREC.Name = "CLIREC"
        Me.CLIREC.Size = New System.Drawing.Size(100, 35)
        Me.CLIREC.TabIndex = 6
        Me.CLIREC.TabStop = False
        '
        'LISDESCLI
        '
        Me.LISDESCLI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LISDESCLI.Image = Global.VBMINIPROJETBANQUE.My.Resources.Resources.LisCli
        Me.LISDESCLI.Location = New System.Drawing.Point(15, 44)
        Me.LISDESCLI.Name = "LISDESCLI"
        Me.LISDESCLI.Size = New System.Drawing.Size(100, 35)
        Me.LISDESCLI.TabIndex = 5
        Me.LISDESCLI.TabStop = False
        '
        'CLIETR
        '
        Me.CLIETR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CLIETR.Image = Global.VBMINIPROJETBANQUE.My.Resources.Resources.CliETR
        Me.CLIETR.Location = New System.Drawing.Point(14, 171)
        Me.CLIETR.Name = "CLIETR"
        Me.CLIETR.Size = New System.Drawing.Size(100, 35)
        Me.CLIETR.TabIndex = 4
        Me.CLIETR.TabStop = False
        '
        'Directeur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VBMINIPROJETBANQUE.My.Resources.Resources.bcg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 511)
        Me.Controls.Add(Me.PPRINCIPAL)
        Me.Controls.Add(Me.PLOGO)
        Me.Controls.Add(Me.PDA)
        Me.Controls.Add(Me.PAGENTS)
        Me.Controls.Add(Me.MENU)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 550)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 550)
        Me.Name = "Directeur"
        Me.Text = "Directeur"
        Me.PPRINCIPAL.ResumeLayout(False)
        Me.PPRIN.ResumeLayout(False)
        Me.PPRIN.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PLISCLI.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PCLIETR.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.PCLIREC.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.PLOGO.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PDA.ResumeLayout(False)
        Me.PAGENTS.ResumeLayout(False)
        Me.PAGENTS.PerformLayout()
        CType(Me.LOGAOUTAGENT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MENU.ResumeLayout(False)
        CType(Me.CLIREC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LISDESCLI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIETR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PPRINCIPAL As System.Windows.Forms.Panel
    Friend WithEvents PLOGO As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PDA As System.Windows.Forms.Panel
    Friend WithEvents DateActuel As System.Windows.Forms.DateTimePicker
    Friend WithEvents PAGENTS As System.Windows.Forms.Panel
    Friend WithEvents LOGAOUTAGENT As System.Windows.Forms.PictureBox
    Friend WithEvents AGENTS As System.Windows.Forms.Label
    Friend WithEvents M As System.Windows.Forms.Label
    Friend WithEvents Bienvenu As System.Windows.Forms.Label
    Friend WithEvents MENU As System.Windows.Forms.Panel
    Friend WithEvents PCLIREC As System.Windows.Forms.Panel
    Friend WithEvents CLIREC As System.Windows.Forms.PictureBox
    Friend WithEvents LISDESCLI As System.Windows.Forms.PictureBox
    Friend WithEvents CLIETR As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PPRIN As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Bie As System.Windows.Forms.Label
    Friend WithEvents PLISCLI As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents PCLIETR As System.Windows.Forms.Panel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
