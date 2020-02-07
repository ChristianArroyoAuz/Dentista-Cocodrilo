// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 11/08/2016.                                                                              *
// ******************************************************************************************

namespace Dentista_Cocodrilo
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonRegistrase = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox_Condiciones = new System.Windows.Forms.GroupBox();
            this.checkBoxCondiciones = new System.Windows.Forms.CheckBox();
            this.etiquetaTitulo = new System.Windows.Forms.Label();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.etiquetaSexo = new System.Windows.Forms.Label();
            this.comboBoxAño = new System.Windows.Forms.ComboBox();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.comboBoxDia = new System.Windows.Forms.ComboBox();
            this.etiquetaFecha = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.etiquetaPais = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.etiquetaTelefono = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.etiquetaEmail = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.etiquetaConfirmar = new System.Windows.Forms.Label();
            this.etiquetaContraseña = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.etiquetaUsuario = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.etiquetaNombre = new System.Windows.Forms.Label();
            this.dataGridView_Datos = new System.Windows.Forms.DataGridView();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.etiquetaID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.groupBox_Condiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // botonEliminar
            // 
            this.botonEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botonEliminar.Location = new System.Drawing.Point(579, 445);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(186, 34);
            this.botonEliminar.TabIndex = 55;
            this.botonEliminar.Text = "ELIMINAR";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonRegistrase
            // 
            this.botonRegistrase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botonRegistrase.Location = new System.Drawing.Point(402, 445);
            this.botonRegistrase.Name = "botonRegistrase";
            this.botonRegistrase.Size = new System.Drawing.Size(170, 35);
            this.botonRegistrase.TabIndex = 53;
            this.botonRegistrase.Text = "REGISTRASE.";
            this.botonRegistrase.UseVisualStyleBackColor = true;
            this.botonRegistrase.Click += new System.EventHandler(this.botonRegistrase_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(351, 52);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // groupBox_Condiciones
            // 
            this.groupBox_Condiciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox_Condiciones.Controls.Add(this.richTextBox1);
            this.groupBox_Condiciones.Controls.Add(this.checkBoxCondiciones);
            this.groupBox_Condiciones.Location = new System.Drawing.Point(402, 334);
            this.groupBox_Condiciones.Name = "groupBox_Condiciones";
            this.groupBox_Condiciones.Size = new System.Drawing.Size(363, 100);
            this.groupBox_Condiciones.TabIndex = 52;
            this.groupBox_Condiciones.TabStop = false;
            this.groupBox_Condiciones.Text = "Condiciones de Uso.";
            // 
            // checkBoxCondiciones
            // 
            this.checkBoxCondiciones.AutoSize = true;
            this.checkBoxCondiciones.Location = new System.Drawing.Point(6, 77);
            this.checkBoxCondiciones.Name = "checkBoxCondiciones";
            this.checkBoxCondiciones.Size = new System.Drawing.Size(164, 17);
            this.checkBoxCondiciones.TabIndex = 22;
            this.checkBoxCondiciones.Text = "Aceptar Condiciones de Uso.";
            this.checkBoxCondiciones.UseVisualStyleBackColor = true;
            // 
            // etiquetaTitulo
            // 
            this.etiquetaTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.etiquetaTitulo.AutoSize = true;
            this.etiquetaTitulo.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaTitulo.Location = new System.Drawing.Point(369, 21);
            this.etiquetaTitulo.Name = "etiquetaTitulo";
            this.etiquetaTitulo.Size = new System.Drawing.Size(435, 36);
            this.etiquetaTitulo.TabIndex = 51;
            this.etiquetaTitulo.Text = "CREAR NUEVA CUENTA.";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxSexo.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Sin Especificar"});
            this.comboBoxSexo.Location = new System.Drawing.Point(402, 297);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(363, 21);
            this.comboBoxSexo.TabIndex = 50;
            this.comboBoxSexo.Text = "Escoja su Sexo";
            // 
            // etiquetaSexo
            // 
            this.etiquetaSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.etiquetaSexo.AutoSize = true;
            this.etiquetaSexo.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaSexo.Location = new System.Drawing.Point(233, 305);
            this.etiquetaSexo.Name = "etiquetaSexo";
            this.etiquetaSexo.Size = new System.Drawing.Size(43, 13);
            this.etiquetaSexo.TabIndex = 49;
            this.etiquetaSexo.Text = "SEXO:";
            // 
            // comboBoxAño
            // 
            this.comboBoxAño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxAño.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAño.FormattingEnabled = true;
            this.comboBoxAño.Items.AddRange(new object[] {
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970"});
            this.comboBoxAño.Location = new System.Drawing.Point(643, 270);
            this.comboBoxAño.Name = "comboBoxAño";
            this.comboBoxAño.Size = new System.Drawing.Size(122, 21);
            this.comboBoxAño.TabIndex = 48;
            this.comboBoxAño.Text = "Año";
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxMes.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBoxMes.Location = new System.Drawing.Point(515, 270);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(122, 21);
            this.comboBoxMes.TabIndex = 47;
            this.comboBoxMes.Text = "Mes";
            // 
            // comboBoxDia
            // 
            this.comboBoxDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxDia.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDia.FormattingEnabled = true;
            this.comboBoxDia.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxDia.Location = new System.Drawing.Point(402, 270);
            this.comboBoxDia.Name = "comboBoxDia";
            this.comboBoxDia.Size = new System.Drawing.Size(107, 21);
            this.comboBoxDia.TabIndex = 46;
            this.comboBoxDia.Text = "Dia";
            // 
            // etiquetaFecha
            // 
            this.etiquetaFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.etiquetaFecha.AutoSize = true;
            this.etiquetaFecha.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaFecha.Location = new System.Drawing.Point(233, 273);
            this.etiquetaFecha.Name = "etiquetaFecha";
            this.etiquetaFecha.Size = new System.Drawing.Size(145, 13);
            this.etiquetaFecha.TabIndex = 45;
            this.etiquetaFecha.Text = "Fecha DE NACIMIENTO:";
            // 
            // txtPais
            // 
            this.txtPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPais.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(402, 244);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(363, 20);
            this.txtPais.TabIndex = 44;
            this.txtPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPais_KeyPress);
            // 
            // etiquetaPais
            // 
            this.etiquetaPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.etiquetaPais.AutoSize = true;
            this.etiquetaPais.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaPais.Location = new System.Drawing.Point(233, 251);
            this.etiquetaPais.Name = "etiquetaPais";
            this.etiquetaPais.Size = new System.Drawing.Size(39, 13);
            this.etiquetaPais.TabIndex = 43;
            this.etiquetaPais.Text = "PAIS:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTelefono.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(402, 218);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(363, 20);
            this.txtTelefono.TabIndex = 42;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // etiquetaTelefono
            // 
            this.etiquetaTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.etiquetaTelefono.AutoSize = true;
            this.etiquetaTelefono.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaTelefono.Location = new System.Drawing.Point(233, 225);
            this.etiquetaTelefono.Name = "etiquetaTelefono";
            this.etiquetaTelefono.Size = new System.Drawing.Size(75, 13);
            this.etiquetaTelefono.TabIndex = 41;
            this.etiquetaTelefono.Text = "TELEFONO:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCorreo.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(402, 192);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(363, 20);
            this.txtCorreo.TabIndex = 39;
            // 
            // etiquetaEmail
            // 
            this.etiquetaEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.etiquetaEmail.AutoSize = true;
            this.etiquetaEmail.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaEmail.Location = new System.Drawing.Point(233, 199);
            this.etiquetaEmail.Name = "etiquetaEmail";
            this.etiquetaEmail.Size = new System.Drawing.Size(47, 13);
            this.etiquetaEmail.TabIndex = 38;
            this.etiquetaEmail.Text = "eMAIL:";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtConfirmarContraseña.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(402, 166);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PasswordChar = '*';
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(363, 20);
            this.txtConfirmarContraseña.TabIndex = 37;
            this.txtConfirmarContraseña.Leave += new System.EventHandler(this.txtConfirmarContraseña_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtContraseña.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(402, 140);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(363, 20);
            this.txtContraseña.TabIndex = 36;
            // 
            // etiquetaConfirmar
            // 
            this.etiquetaConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.etiquetaConfirmar.AutoSize = true;
            this.etiquetaConfirmar.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaConfirmar.Location = new System.Drawing.Point(233, 173);
            this.etiquetaConfirmar.Name = "etiquetaConfirmar";
            this.etiquetaConfirmar.Size = new System.Drawing.Size(163, 13);
            this.etiquetaConfirmar.TabIndex = 35;
            this.etiquetaConfirmar.Text = "CONFIRAR CONTRASEÑA:";
            // 
            // etiquetaContraseña
            // 
            this.etiquetaContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.etiquetaContraseña.AutoSize = true;
            this.etiquetaContraseña.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaContraseña.Location = new System.Drawing.Point(233, 143);
            this.etiquetaContraseña.Name = "etiquetaContraseña";
            this.etiquetaContraseña.Size = new System.Drawing.Size(95, 13);
            this.etiquetaContraseña.TabIndex = 34;
            this.etiquetaContraseña.Text = "CONTRASEÑA:";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUser.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(402, 114);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(363, 20);
            this.txtUser.TabIndex = 33;
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // etiquetaUsuario
            // 
            this.etiquetaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.etiquetaUsuario.AutoSize = true;
            this.etiquetaUsuario.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaUsuario.Location = new System.Drawing.Point(233, 117);
            this.etiquetaUsuario.Name = "etiquetaUsuario";
            this.etiquetaUsuario.Size = new System.Drawing.Size(43, 13);
            this.etiquetaUsuario.TabIndex = 32;
            this.etiquetaUsuario.Text = "USER:";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtApellido.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(565, 88);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 31;
            this.txtApellido.Text = "Ingrese su Apellido";
            this.txtApellido.Click += new System.EventHandler(this.txtApellido_Click);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNombre.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(402, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 20);
            this.txtNombre.TabIndex = 30;
            this.txtNombre.Text = "Ingrese su Nombre";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // etiquetaNombre
            // 
            this.etiquetaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.etiquetaNombre.AutoSize = true;
            this.etiquetaNombre.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaNombre.Location = new System.Drawing.Point(233, 95);
            this.etiquetaNombre.Name = "etiquetaNombre";
            this.etiquetaNombre.Size = new System.Drawing.Size(63, 13);
            this.etiquetaNombre.TabIndex = 29;
            this.etiquetaNombre.Text = "NOMBRE:";
            // 
            // dataGridView_Datos
            // 
            this.dataGridView_Datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Datos.Location = new System.Drawing.Point(236, 501);
            this.dataGridView_Datos.Name = "dataGridView_Datos";
            this.dataGridView_Datos.Size = new System.Drawing.Size(529, 98);
            this.dataGridView_Datos.TabIndex = 56;
            this.dataGridView_Datos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Datos_RowEnter);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImagen.Image = global::Dentista_Cocodrilo.Properties.Resources.RegistroUsu;
            this.pictureBoxImagen.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(199, 587);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 57;
            this.pictureBoxImagen.TabStop = false;
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonVolver.BackgroundImage = global::Dentista_Cocodrilo.Properties.Resources.Boton_Volver;
            this.botonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.Location = new System.Drawing.Point(449, 605);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(188, 51);
            this.botonVolver.TabIndex = 58;
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // etiquetaID
            // 
            this.etiquetaID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.etiquetaID.AutoSize = true;
            this.etiquetaID.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaID.Location = new System.Drawing.Point(233, 72);
            this.etiquetaID.Name = "etiquetaID";
            this.etiquetaID.Size = new System.Drawing.Size(24, 13);
            this.etiquetaID.TabIndex = 59;
            this.etiquetaID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(399, 72);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(14, 13);
            this.txtID.TabIndex = 60;
            this.txtID.Text = "0";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(811, 661);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.etiquetaID);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.dataGridView_Datos);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonRegistrase);
            this.Controls.Add(this.groupBox_Condiciones);
            this.Controls.Add(this.etiquetaTitulo);
            this.Controls.Add(this.comboBoxSexo);
            this.Controls.Add(this.etiquetaSexo);
            this.Controls.Add(this.comboBoxAño);
            this.Controls.Add(this.comboBoxMes);
            this.Controls.Add(this.comboBoxDia);
            this.Controls.Add(this.etiquetaFecha);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.etiquetaPais);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.etiquetaTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.etiquetaEmail);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.etiquetaConfirmar);
            this.Controls.Add(this.etiquetaContraseña);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.etiquetaUsuario);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.etiquetaNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.groupBox_Condiciones.ResumeLayout(false);
            this.groupBox_Condiciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonRegistrase;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox_Condiciones;
        private System.Windows.Forms.CheckBox checkBoxCondiciones;
        private System.Windows.Forms.Label etiquetaTitulo;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.Label etiquetaSexo;
        private System.Windows.Forms.ComboBox comboBoxAño;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.ComboBox comboBoxDia;
        private System.Windows.Forms.Label etiquetaFecha;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label etiquetaPais;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label etiquetaTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label etiquetaEmail;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label etiquetaConfirmar;
        private System.Windows.Forms.Label etiquetaContraseña;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label etiquetaUsuario;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label etiquetaNombre;
        private System.Windows.Forms.DataGridView dataGridView_Datos;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label etiquetaID;
        private System.Windows.Forms.Label txtID;

    }
}