namespace JogoDaForcaSupinpa
{
    partial class telaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaPrincipal));
            pictureBox1 = new PictureBox();
            lb_braco1 = new Label();
            lb_pernas = new Label();
            lb_braco2 = new Label();
            lb_coluna = new Label();
            lb_cabeca = new Label();
            lb_Boneco = new Label();
            bt_Start = new Button();
            imageList1 = new ImageList(components);
            bt_sair = new Button();
            pictureBox2 = new PictureBox();
            letra_Q = new Button();
            letra_W = new Button();
            letra_E = new Button();
            letra_R = new Button();
            letra_T = new Button();
            letra_Y = new Button();
            letra_U = new Button();
            letra_I = new Button();
            letra_O = new Button();
            letra_P = new Button();
            letra_A = new Button();
            letra_S = new Button();
            letra_D = new Button();
            letra_F = new Button();
            letra_G = new Button();
            letra_H = new Button();
            letra_J = new Button();
            letra_K = new Button();
            letra_L = new Button();
            letra_Z = new Button();
            letra_X = new Button();
            letra_C = new Button();
            letra_V = new Button();
            letra_B = new Button();
            letra_N = new Button();
            letra_M = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            lb_palavra = new Label();
            label4 = new Label();
            lb_tentativas = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lb_faltam = new Label();
            label10 = new Label();
            lb_erros = new Label();
            bt_tentar = new Button();
            txt_PalavraSecreta = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(757, 442);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lb_braco1
            // 
            lb_braco1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_braco1.AutoSize = true;
            lb_braco1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_braco1.ForeColor = SystemColors.Highlight;
            lb_braco1.Location = new Point(77, 223);
            lb_braco1.Name = "lb_braco1";
            lb_braco1.Size = new Size(33, 46);
            lb_braco1.TabIndex = 12;
            lb_braco1.Text = "/\r\n";
            lb_braco1.Visible = false;
            // 
            // lb_pernas
            // 
            lb_pernas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_pernas.AutoSize = true;
            lb_pernas.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_pernas.ForeColor = SystemColors.Highlight;
            lb_pernas.Location = new Point(90, 260);
            lb_pernas.Name = "lb_pernas";
            lb_pernas.Size = new Size(55, 46);
            lb_pernas.TabIndex = 14;
            lb_pernas.Text = "/ \\\r\n";
            lb_pernas.Visible = false;
            // 
            // lb_braco2
            // 
            lb_braco2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_braco2.AutoSize = true;
            lb_braco2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_braco2.ForeColor = SystemColors.MenuHighlight;
            lb_braco2.Location = new Point(126, 223);
            lb_braco2.Name = "lb_braco2";
            lb_braco2.Size = new Size(33, 46);
            lb_braco2.TabIndex = 13;
            lb_braco2.Text = "\\";
            lb_braco2.Visible = false;
            // 
            // lb_coluna
            // 
            lb_coluna.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_coluna.AutoSize = true;
            lb_coluna.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_coluna.ForeColor = SystemColors.HotTrack;
            lb_coluna.Location = new Point(99, 223);
            lb_coluna.Name = "lb_coluna";
            lb_coluna.Size = new Size(36, 46);
            lb_coluna.TabIndex = 15;
            lb_coluna.Text = "||";
            lb_coluna.Visible = false;
            // 
            // lb_cabeca
            // 
            lb_cabeca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_cabeca.AutoSize = true;
            lb_cabeca.BackColor = SystemColors.InactiveCaptionText;
            lb_cabeca.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_cabeca.ForeColor = SystemColors.HotTrack;
            lb_cabeca.Location = new Point(99, 187);
            lb_cabeca.Name = "lb_cabeca";
            lb_cabeca.Size = new Size(46, 46);
            lb_cabeca.TabIndex = 11;
            lb_cabeca.Text = "O";
            lb_cabeca.Visible = false;
            // 
            // lb_Boneco
            // 
            lb_Boneco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_Boneco.AutoSize = true;
            lb_Boneco.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Boneco.ForeColor = Color.FromArgb(128, 64, 0);
            lb_Boneco.Location = new Point(21, 78);
            lb_Boneco.Name = "lb_Boneco";
            lb_Boneco.Size = new Size(192, 328);
            lb_Boneco.TabIndex = 10;
            lb_Boneco.Text = "\r\n/===\\           \r\n||         |\r\n||\r\n||\r\n||\r\n||\r\n\r\n";
            // 
            // bt_Start
            // 
            bt_Start.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt_Start.BackColor = Color.Black;
            bt_Start.ForeColor = Color.Black;
            bt_Start.ImageIndex = 1;
            bt_Start.ImageList = imageList1;
            bt_Start.Location = new Point(482, 316);
            bt_Start.MaximumSize = new Size(100, 42);
            bt_Start.MinimumSize = new Size(100, 42);
            bt_Start.Name = "bt_Start";
            bt_Start.Size = new Size(100, 42);
            bt_Start.TabIndex = 21;
            bt_Start.UseVisualStyleBackColor = false;
            bt_Start.Click += bt_iniciar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "exit.png");
            imageList1.Images.SetKeyName(1, "start.png");
            // 
            // bt_sair
            // 
            bt_sair.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt_sair.BackColor = Color.Black;
            bt_sair.ForeColor = Color.Black;
            bt_sair.ImageKey = "exit.png";
            bt_sair.ImageList = imageList1;
            bt_sair.Location = new Point(588, 316);
            bt_sair.MaximumSize = new Size(98, 42);
            bt_sair.MinimumSize = new Size(98, 42);
            bt_sair.Name = "bt_sair";
            bt_sair.Size = new Size(98, 42);
            bt_sair.TabIndex = 22;
            bt_sair.UseVisualStyleBackColor = false;
            bt_sair.Click += bt_sair_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(287, 12);
            pictureBox2.MaximumSize = new Size(250, 93);
            pictureBox2.MinimumSize = new Size(250, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // letra_Q
            // 
            letra_Q.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_Q.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_Q.Location = new Point(209, 153);
            letra_Q.Name = "letra_Q";
            letra_Q.Size = new Size(39, 34);
            letra_Q.TabIndex = 24;
            letra_Q.Text = "Q";
            letra_Q.UseVisualStyleBackColor = true;
            letra_Q.Click += letra_Q_Click;
            // 
            // letra_W
            // 
            letra_W.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_W.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_W.Location = new Point(254, 153);
            letra_W.Name = "letra_W";
            letra_W.Size = new Size(39, 34);
            letra_W.TabIndex = 25;
            letra_W.Text = "W";
            letra_W.UseVisualStyleBackColor = true;
            letra_W.Click += letra_W_Click;
            // 
            // letra_E
            // 
            letra_E.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_E.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_E.Location = new Point(299, 153);
            letra_E.Name = "letra_E";
            letra_E.Size = new Size(39, 34);
            letra_E.TabIndex = 26;
            letra_E.Text = "E";
            letra_E.UseVisualStyleBackColor = true;
            letra_E.Click += letra_E_Click;
            // 
            // letra_R
            // 
            letra_R.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_R.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_R.Location = new Point(344, 153);
            letra_R.Name = "letra_R";
            letra_R.Size = new Size(39, 34);
            letra_R.TabIndex = 27;
            letra_R.Text = "R";
            letra_R.UseVisualStyleBackColor = true;
            letra_R.Click += letra_R_Click;
            // 
            // letra_T
            // 
            letra_T.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_T.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_T.Location = new Point(389, 153);
            letra_T.Name = "letra_T";
            letra_T.Size = new Size(39, 34);
            letra_T.TabIndex = 28;
            letra_T.Text = "T";
            letra_T.UseVisualStyleBackColor = true;
            letra_T.Click += letra_T_Click;
            // 
            // letra_Y
            // 
            letra_Y.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_Y.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_Y.Location = new Point(434, 153);
            letra_Y.Name = "letra_Y";
            letra_Y.Size = new Size(39, 34);
            letra_Y.TabIndex = 29;
            letra_Y.Text = "Y";
            letra_Y.UseVisualStyleBackColor = true;
            letra_Y.Click += letra_Y_Click;
            // 
            // letra_U
            // 
            letra_U.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_U.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_U.Location = new Point(479, 153);
            letra_U.Name = "letra_U";
            letra_U.Size = new Size(39, 34);
            letra_U.TabIndex = 30;
            letra_U.Text = "U";
            letra_U.UseVisualStyleBackColor = true;
            letra_U.Click += letra_U_Click;
            // 
            // letra_I
            // 
            letra_I.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_I.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_I.Location = new Point(524, 153);
            letra_I.Name = "letra_I";
            letra_I.Size = new Size(39, 34);
            letra_I.TabIndex = 31;
            letra_I.Text = "I";
            letra_I.UseVisualStyleBackColor = true;
            letra_I.Click += letra_I_Click;
            // 
            // letra_O
            // 
            letra_O.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_O.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_O.Location = new Point(569, 153);
            letra_O.Name = "letra_O";
            letra_O.Size = new Size(39, 34);
            letra_O.TabIndex = 32;
            letra_O.Text = "O";
            letra_O.UseVisualStyleBackColor = true;
            letra_O.Click += letra_O_Click;
            // 
            // letra_P
            // 
            letra_P.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_P.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_P.Location = new Point(614, 153);
            letra_P.Name = "letra_P";
            letra_P.Size = new Size(39, 34);
            letra_P.TabIndex = 33;
            letra_P.Text = "P";
            letra_P.UseVisualStyleBackColor = true;
            letra_P.Click += letra_P_Click;
            // 
            // letra_A
            // 
            letra_A.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_A.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_A.Location = new Point(228, 193);
            letra_A.Name = "letra_A";
            letra_A.Size = new Size(39, 34);
            letra_A.TabIndex = 34;
            letra_A.Text = "A";
            letra_A.UseVisualStyleBackColor = true;
            letra_A.Click += letra_A_Click;
            // 
            // letra_S
            // 
            letra_S.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_S.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_S.Location = new Point(273, 193);
            letra_S.Name = "letra_S";
            letra_S.Size = new Size(39, 34);
            letra_S.TabIndex = 35;
            letra_S.Text = "S";
            letra_S.UseVisualStyleBackColor = true;
            letra_S.Click += letra_S_Click;
            // 
            // letra_D
            // 
            letra_D.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_D.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_D.Location = new Point(318, 193);
            letra_D.Name = "letra_D";
            letra_D.Size = new Size(39, 34);
            letra_D.TabIndex = 36;
            letra_D.Text = "D";
            letra_D.UseVisualStyleBackColor = true;
            letra_D.Click += letra_D_Click;
            // 
            // letra_F
            // 
            letra_F.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_F.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_F.Location = new Point(363, 193);
            letra_F.Name = "letra_F";
            letra_F.Size = new Size(39, 34);
            letra_F.TabIndex = 37;
            letra_F.Text = "F";
            letra_F.UseVisualStyleBackColor = true;
            letra_F.Click += letra_F_Click;
            // 
            // letra_G
            // 
            letra_G.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_G.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_G.Location = new Point(408, 193);
            letra_G.Name = "letra_G";
            letra_G.Size = new Size(39, 34);
            letra_G.TabIndex = 38;
            letra_G.Text = "G";
            letra_G.UseVisualStyleBackColor = true;
            letra_G.Click += letra_G_Click;
            // 
            // letra_H
            // 
            letra_H.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_H.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_H.Location = new Point(453, 193);
            letra_H.Name = "letra_H";
            letra_H.Size = new Size(39, 34);
            letra_H.TabIndex = 39;
            letra_H.Text = "H";
            letra_H.UseVisualStyleBackColor = true;
            letra_H.Click += letra_H_Click;
            // 
            // letra_J
            // 
            letra_J.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_J.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_J.Location = new Point(498, 193);
            letra_J.Name = "letra_J";
            letra_J.Size = new Size(39, 34);
            letra_J.TabIndex = 40;
            letra_J.Text = "J";
            letra_J.UseVisualStyleBackColor = true;
            letra_J.Click += letra_J_Click;
            // 
            // letra_K
            // 
            letra_K.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_K.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_K.Location = new Point(543, 193);
            letra_K.Name = "letra_K";
            letra_K.Size = new Size(39, 34);
            letra_K.TabIndex = 41;
            letra_K.Text = "K";
            letra_K.UseVisualStyleBackColor = true;
            letra_K.Click += letra_K_Click;
            // 
            // letra_L
            // 
            letra_L.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_L.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_L.Location = new Point(588, 193);
            letra_L.Name = "letra_L";
            letra_L.Size = new Size(39, 34);
            letra_L.TabIndex = 42;
            letra_L.Text = "L";
            letra_L.UseVisualStyleBackColor = true;
            letra_L.Click += letra_L_Click;
            // 
            // letra_Z
            // 
            letra_Z.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_Z.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_Z.Location = new Point(273, 233);
            letra_Z.Name = "letra_Z";
            letra_Z.Size = new Size(39, 34);
            letra_Z.TabIndex = 43;
            letra_Z.Text = "Z";
            letra_Z.UseVisualStyleBackColor = true;
            letra_Z.Click += letra_Z_Click;
            // 
            // letra_X
            // 
            letra_X.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_X.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_X.Location = new Point(318, 233);
            letra_X.Name = "letra_X";
            letra_X.Size = new Size(39, 34);
            letra_X.TabIndex = 44;
            letra_X.Text = "X";
            letra_X.UseVisualStyleBackColor = true;
            letra_X.Click += letra_X_Click;
            // 
            // letra_C
            // 
            letra_C.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_C.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_C.Location = new Point(363, 233);
            letra_C.Name = "letra_C";
            letra_C.Size = new Size(39, 34);
            letra_C.TabIndex = 45;
            letra_C.Text = "C";
            letra_C.UseVisualStyleBackColor = true;
            letra_C.Click += letra_C_Click;
            // 
            // letra_V
            // 
            letra_V.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_V.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_V.Location = new Point(408, 233);
            letra_V.Name = "letra_V";
            letra_V.Size = new Size(39, 34);
            letra_V.TabIndex = 46;
            letra_V.Text = "V";
            letra_V.UseVisualStyleBackColor = true;
            letra_V.Click += letra_V_Click;
            // 
            // letra_B
            // 
            letra_B.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_B.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_B.Location = new Point(453, 233);
            letra_B.Name = "letra_B";
            letra_B.Size = new Size(39, 34);
            letra_B.TabIndex = 47;
            letra_B.Text = "B";
            letra_B.UseVisualStyleBackColor = true;
            letra_B.Click += letra_B_Click;
            // 
            // letra_N
            // 
            letra_N.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_N.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_N.Location = new Point(498, 233);
            letra_N.Name = "letra_N";
            letra_N.Size = new Size(39, 34);
            letra_N.TabIndex = 48;
            letra_N.Text = "N";
            letra_N.UseVisualStyleBackColor = true;
            letra_N.Click += letra_N_Click;
            // 
            // letra_M
            // 
            letra_M.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            letra_M.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            letra_M.Location = new Point(543, 233);
            letra_M.Name = "letra_M";
            letra_M.Size = new Size(39, 34);
            letra_M.TabIndex = 49;
            letra_M.Text = "M";
            letra_M.UseVisualStyleBackColor = true;
            letra_M.Click += letra_M_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Location = new Point(0, -1);
            pictureBox3.MaximumSize = new Size(757, 442);
            pictureBox3.MinimumSize = new Size(757, 442);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(757, 442);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(21, 78);
            label1.Name = "label1";
            label1.Size = new Size(192, 328);
            label1.TabIndex = 10;
            label1.Text = "\r\n/===\\           \r\n||         |\r\n||\r\n||\r\n||\r\n||\r\n\r\n";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox1.BackColor = Color.FromArgb(224, 224, 224);
            maskedTextBox1.Enabled = false;
            maskedTextBox1.Font = new Font("Segoe UI Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(209, 281);
            maskedTextBox1.Mask = "A";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(70, 36);
            maskedTextBox1.TabIndex = 50;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 337);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 52;
            label2.Text = "Palavra";
            // 
            // lb_palavra
            // 
            lb_palavra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_palavra.AutoSize = true;
            lb_palavra.BackColor = Color.Yellow;
            lb_palavra.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_palavra.Location = new Point(116, 337);
            lb_palavra.Name = "lb_palavra";
            lb_palavra.Size = new Size(25, 21);
            lb_palavra.TabIndex = 53;
            lb_palavra.Text = "...";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveBorder;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(65, 406);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 54;
            label4.Text = "Tentativas";
            // 
            // lb_tentativas
            // 
            lb_tentativas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_tentativas.AutoSize = true;
            lb_tentativas.BackColor = Color.Red;
            lb_tentativas.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_tentativas.Location = new Point(166, 406);
            lb_tentativas.Name = "lb_tentativas";
            lb_tentativas.Size = new Size(25, 21);
            lb_tentativas.TabIndex = 55;
            lb_tentativas.Text = "...";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(309, 129);
            label6.Name = "label6";
            label6.Size = new Size(238, 21);
            label6.TabIndex = 56;
            label6.Text = "digite ou clique em uma letra";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 255, 128);
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(14, 102);
            label7.Name = "label7";
            label7.Size = new Size(145, 21);
            label7.TabIndex = 57;
            label7.Text = "Palavra Aleatoria";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveBorder;
            label8.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(273, 372);
            label8.Name = "label8";
            label8.Size = new Size(64, 21);
            label8.TabIndex = 58;
            label8.Text = "Faltam";
            // 
            // lb_faltam
            // 
            lb_faltam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_faltam.AutoSize = true;
            lb_faltam.BackColor = Color.Yellow;
            lb_faltam.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_faltam.Location = new Point(344, 372);
            lb_faltam.Name = "lb_faltam";
            lb_faltam.Size = new Size(20, 21);
            lb_faltam.TabIndex = 59;
            lb_faltam.Text = "0";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveBorder;
            label10.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(273, 406);
            label10.Name = "label10";
            label10.Size = new Size(51, 21);
            label10.TabIndex = 60;
            label10.Text = "Erros";
            // 
            // lb_erros
            // 
            lb_erros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_erros.AutoSize = true;
            lb_erros.BackColor = Color.Red;
            lb_erros.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_erros.Location = new Point(344, 406);
            lb_erros.Name = "lb_erros";
            lb_erros.Size = new Size(20, 21);
            lb_erros.TabIndex = 61;
            lb_erros.Text = "0";
            // 
            // bt_tentar
            // 
            bt_tentar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt_tentar.Enabled = false;
            bt_tentar.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            bt_tentar.Location = new Point(375, 273);
            bt_tentar.MaximumSize = new Size(98, 54);
            bt_tentar.MinimumSize = new Size(98, 54);
            bt_tentar.Name = "bt_tentar";
            bt_tentar.Size = new Size(98, 54);
            bt_tentar.TabIndex = 62;
            bt_tentar.Text = "tentar";
            bt_tentar.UseVisualStyleBackColor = true;
            bt_tentar.Click += bt_tentar_Click;
            // 
            // txt_PalavraSecreta
            // 
            txt_PalavraSecreta.BackColor = SystemColors.InfoText;
            txt_PalavraSecreta.Location = new Point(0, -1);
            txt_PalavraSecreta.Name = "txt_PalavraSecreta";
            txt_PalavraSecreta.Size = new Size(14, 23);
            txt_PalavraSecreta.TabIndex = 64;
            txt_PalavraSecreta.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(543, 28);
            pictureBox4.MaximumSize = new Size(155, 77);
            pictureBox4.MinimumSize = new Size(155, 77);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(155, 77);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 63;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(515, 364);
            pictureBox5.MaximumSize = new Size(138, 66);
            pictureBox5.MinimumSize = new Size(138, 66);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(138, 66);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 65;
            pictureBox5.TabStop = false;
            // 
            // telaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(758, 442);
            Controls.Add(pictureBox5);
            Controls.Add(txt_PalavraSecreta);
            Controls.Add(pictureBox4);
            Controls.Add(bt_tentar);
            Controls.Add(lb_erros);
            Controls.Add(label10);
            Controls.Add(lb_faltam);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lb_tentativas);
            Controls.Add(label4);
            Controls.Add(lb_palavra);
            Controls.Add(label2);
            Controls.Add(maskedTextBox1);
            Controls.Add(letra_M);
            Controls.Add(letra_N);
            Controls.Add(letra_B);
            Controls.Add(letra_V);
            Controls.Add(letra_C);
            Controls.Add(letra_X);
            Controls.Add(letra_Z);
            Controls.Add(letra_L);
            Controls.Add(letra_K);
            Controls.Add(letra_J);
            Controls.Add(letra_H);
            Controls.Add(letra_G);
            Controls.Add(letra_F);
            Controls.Add(letra_D);
            Controls.Add(letra_S);
            Controls.Add(letra_A);
            Controls.Add(letra_P);
            Controls.Add(letra_O);
            Controls.Add(letra_I);
            Controls.Add(letra_U);
            Controls.Add(letra_Y);
            Controls.Add(letra_T);
            Controls.Add(letra_R);
            Controls.Add(letra_E);
            Controls.Add(letra_W);
            Controls.Add(letra_Q);
            Controls.Add(pictureBox2);
            Controls.Add(bt_sair);
            Controls.Add(bt_Start);
            Controls.Add(lb_coluna);
            Controls.Add(lb_pernas);
            Controls.Add(lb_braco2);
            Controls.Add(lb_braco1);
            Controls.Add(lb_cabeca);
            Controls.Add(label1);
            Controls.Add(lb_Boneco);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(774, 481);
            MinimumSize = new Size(774, 481);
            Name = "telaPrincipal";
            Text = "JOGO DA FORCA GURIZADA";
            Load += telaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lb_braco1;
        private Label lb_pernas;
        private Label lb_braco2;
        private Label lb_coluna;
        private Label lb_cabeca;
        private Label lb_Boneco;
        private Button bt_Start;
        private Button bt_sair;
        private PictureBox pictureBox2;
        private Button letra_Q;
        private Button letra_W;
        private Button letra_E;
        private Button letra_R;
        private Button letra_T;
        private Button letra_Y;
        private Button letra_U;
        private Button letra_I;
        private Button letra_O;
        private Button letra_P;
        private Button letra_A;
        private Button letra_S;
        private Button letra_D;
        private Button letra_F;
        private Button letra_G;
        private Button letra_H;
        private Button letra_J;
        private Button letra_K;
        private Button letra_L;
        private Button letra_Z;
        private Button letra_X;
        private Button letra_C;
        private Button letra_V;
        private Button letra_B;
        private Button letra_N;
        private Button letra_M;
        private PictureBox pictureBox3;
        private Label label1;
        private ImageList imageList1;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Label lb_palavra;
        private Label label4;
        private Label lb_tentativas;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lb_faltam;
        private Label label10;
        private Label lb_erros;
        private Button bt_tentar;
        private TextBox txt_PalavraSecreta;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}