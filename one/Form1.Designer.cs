namespace one
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            MetroSuite.MetroButton.MainColorScheme mainColorScheme5 = new MetroSuite.MetroButton.MainColorScheme();
            MetroSuite.MetroButton.MainColorScheme mainColorScheme6 = new MetroSuite.MetroButton.MainColorScheme();
            MetroSuite.MetroButton.MainColorScheme mainColorScheme7 = new MetroSuite.MetroButton.MainColorScheme();
            MetroSuite.MetroSeparator.MainColorScheme mainColorScheme8 = new MetroSuite.MetroSeparator.MainColorScheme();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroButton1 = new MetroSuite.MetroButton();
            this.btnLImpiar = new MetroSuite.MetroButton();
            this.btnEliminar = new MetroSuite.MetroButton();
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroSeparator1 = new MetroSuite.MetroSeparator();
            this.lvEstudiantes = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCurso = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNota1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNota2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNota3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCurso = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))));
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // metroButton1
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.metroButton1, true);
            mainColorScheme5.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            mainColorScheme5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            mainColorScheme5.FillColor = System.Drawing.Color.White;
            mainColorScheme5.HoverFillColor = System.Drawing.Color.White;
            mainColorScheme5.PressAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            mainColorScheme5.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.metroButton1.ColorScheme = mainColorScheme5;
            this.metroButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.metroButton1.ForeColor = System.Drawing.Color.Black;
            this.metroButton1.Location = new System.Drawing.Point(314, 155);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(105, 27);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Agregar";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnLImpiar
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.btnLImpiar, true);
            mainColorScheme6.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            mainColorScheme6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            mainColorScheme6.FillColor = System.Drawing.Color.White;
            mainColorScheme6.HoverFillColor = System.Drawing.Color.White;
            mainColorScheme6.PressAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            mainColorScheme6.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLImpiar.ColorScheme = mainColorScheme6;
            this.btnLImpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLImpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLImpiar.Location = new System.Drawing.Point(619, 176);
            this.btnLImpiar.Name = "btnLImpiar";
            this.btnLImpiar.Size = new System.Drawing.Size(55, 27);
            this.btnLImpiar.TabIndex = 13;
            this.btnLImpiar.Text = "Limpiar";
            this.btnLImpiar.Click += new System.EventHandler(this.btnLImpiar_Click);
            // 
            // btnEliminar
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.btnEliminar, true);
            mainColorScheme7.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            mainColorScheme7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            mainColorScheme7.FillColor = System.Drawing.Color.White;
            mainColorScheme7.HoverFillColor = System.Drawing.Color.White;
            mainColorScheme7.PressAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            mainColorScheme7.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.ColorScheme = mainColorScheme7;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(558, 176);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(55, 27);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager2.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))));
            // 
            // metroSeparator1
            // 
            mainColorScheme8.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            mainColorScheme8.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.metroSeparator1.ColorScheme = mainColorScheme8;
            this.metroSeparator1.Location = new System.Drawing.Point(227, 55);
            this.metroSeparator1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.metroSeparator1.Name = "metroSeparator1";
            this.metroSeparator1.Size = new System.Drawing.Size(234, 2);
            this.metroSeparator1.TabIndex = 0;
            // 
            // lvEstudiantes
            // 
            this.lvEstudiantes.BackColor = System.Drawing.Color.White;
            this.lvEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvEstudiantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvEstudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvEstudiantes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvEstudiantes.FullRowSelect = true;
            this.lvEstudiantes.GridLines = true;
            this.lvEstudiantes.Location = new System.Drawing.Point(83, 210);
            this.lvEstudiantes.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lvEstudiantes.MultiSelect = false;
            this.lvEstudiantes.Name = "lvEstudiantes";
            this.lvEstudiantes.OwnerDraw = true;
            this.lvEstudiantes.Size = new System.Drawing.Size(591, 210);
            this.lvEstudiantes.Style = MetroFramework.MetroColorStyle.Red;
            this.lvEstudiantes.TabIndex = 1;
            this.lvEstudiantes.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lvEstudiantes.UseCompatibleStateImageBehavior = false;
            this.lvEstudiantes.UseCustomBackColor = true;
            this.lvEstudiantes.UseCustomForeColor = true;
            this.lvEstudiantes.UseSelectable = true;
            this.lvEstudiantes.UseStyleColors = true;
            this.lvEstudiantes.View = System.Windows.Forms.View.Details;
            this.lvEstudiantes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvEstudiantes_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nota 1";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nota 2";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nota 3";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nota minima";
            this.columnHeader5.Width = 107;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Promedio";
            this.columnHeader6.Width = 83;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Condicion";
            this.columnHeader7.Width = 83;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(83, 187);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(0, 0);
            this.lblCurso.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Depth = 0;
            this.txtNombre.ForeColor = System.Drawing.Color.Red;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(199, 79);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(209, 23);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TabStop = false;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtNota1
            // 
            this.txtNota1.Depth = 0;
            this.txtNota1.Hint = "Nota 1";
            this.txtNota1.Location = new System.Drawing.Point(199, 117);
            this.txtNota1.MaxLength = 32767;
            this.txtNota1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.PasswordChar = '\0';
            this.txtNota1.SelectedText = "";
            this.txtNota1.SelectionLength = 0;
            this.txtNota1.SelectionStart = 0;
            this.txtNota1.Size = new System.Drawing.Size(75, 23);
            this.txtNota1.TabIndex = 4;
            this.txtNota1.TabStop = false;
            this.txtNota1.UseSystemPasswordChar = false;
            // 
            // txtNota2
            // 
            this.txtNota2.Depth = 0;
            this.txtNota2.Hint = "Nota 2";
            this.txtNota2.Location = new System.Drawing.Point(333, 117);
            this.txtNota2.MaxLength = 32767;
            this.txtNota2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.PasswordChar = '\0';
            this.txtNota2.SelectedText = "";
            this.txtNota2.SelectionLength = 0;
            this.txtNota2.SelectionStart = 0;
            this.txtNota2.Size = new System.Drawing.Size(75, 23);
            this.txtNota2.TabIndex = 5;
            this.txtNota2.TabStop = false;
            this.txtNota2.UseSystemPasswordChar = false;
            // 
            // txtNota3
            // 
            this.txtNota3.Depth = 0;
            this.txtNota3.Hint = "Nota 3";
            this.txtNota3.Location = new System.Drawing.Point(467, 117);
            this.txtNota3.MaxLength = 32767;
            this.txtNota3.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.PasswordChar = '\0';
            this.txtNota3.SelectedText = "";
            this.txtNota3.SelectionLength = 0;
            this.txtNota3.SelectionStart = 0;
            this.txtNota3.Size = new System.Drawing.Size(75, 23);
            this.txtNota3.TabIndex = 6;
            this.txtNota3.TabStop = false;
            this.txtNota3.UseSystemPasswordChar = false;
            // 
            // txtCurso
            // 
            this.txtCurso.Depth = 0;
            this.txtCurso.Hint = "Curso";
            this.txtCurso.Location = new System.Drawing.Point(459, 79);
            this.txtCurso.MaxLength = 32767;
            this.txtCurso.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.PasswordChar = '\0';
            this.txtCurso.SelectedText = "";
            this.txtCurso.SelectionLength = 0;
            this.txtCurso.SelectionStart = 0;
            this.txtCurso.Size = new System.Drawing.Size(83, 23);
            this.txtCurso.TabIndex = 7;
            this.txtCurso.TabStop = false;
            this.txtCurso.UseSystemPasswordChar = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::one.Properties.Resources.cabezote2;
            this.pictureBox2.Location = new System.Drawing.Point(0, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 428);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Transparent;
            this.metroButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton2.BackgroundImage")));
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(635, 41);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(39, 39);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.White;
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(one.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackImage = global::one.Properties.Resources._1424683706_16_unidad_educativa_san_luis_fe_y_alegria;
            this.BackImagePadding = new System.Windows.Forms.Padding(160, 12, 0, 0);
            this.BackMaxSize = 60;
            this.ClientSize = new System.Drawing.Size(680, 432);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLImpiar);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lvEstudiantes);
            this.Controls.Add(this.metroSeparator1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Notas de Estudiantes";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private DevComponents.DotNetBar.StyleManager styleManager2;
        private MetroSuite.MetroSeparator metroSeparator1;
        private MetroFramework.Controls.MetroListView lvEstudiantes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MetroFramework.Controls.MetroLabel lblCurso;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNota1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNota2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNota3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCurso;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroSuite.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private MetroSuite.MetroButton btnLImpiar;
        private MetroSuite.MetroButton btnEliminar;
    }
}

