namespace Facturacion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pannelLogon = new System.Windows.Forms.Panel();
            this.linkAbout = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdLogueo = new System.Windows.Forms.Button();
            this.TxtPswd = new System.Windows.Forms.TextBox();
            this.TxtKeyNumber = new System.Windows.Forms.TextBox();
            this.TxtCompany = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.panelFacturas = new System.Windows.Forms.Panel();
            this.pannelOpciones = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CmdIngFacturas = new System.Windows.Forms.Button();
            this.CmdMake = new System.Windows.Forms.Button();
            this.CmdSaveData = new System.Windows.Forms.Button();
            this.CmdLoadData = new System.Windows.Forms.Button();
            this.SSTabFacturas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGrFacEnc = new System.Windows.Forms.DataGridView();
            this.panelEncOp = new System.Windows.Forms.Panel();
            this.ChkContado = new System.Windows.Forms.CheckBox();
            this.ChkDefectos = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGrFacRen = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGrFacImp = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DGrFacCuo = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.DGrFonEnc = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.DGrFonRen = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.DGrResult = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pannelLogon.SuspendLayout();
            this.panelFacturas.SuspendLayout();
            this.pannelOpciones.SuspendLayout();
            this.SSTabFacturas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGrFacEnc)).BeginInit();
            this.panelEncOp.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGrFacRen)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGrFacImp)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGrFacCuo)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGrFonEnc)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGrFonRen)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGrResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pannelLogon
            // 
            this.pannelLogon.Controls.Add(this.linkAbout);
            this.pannelLogon.Controls.Add(this.label4);
            this.pannelLogon.Controls.Add(this.label3);
            this.pannelLogon.Controls.Add(this.label2);
            this.pannelLogon.Controls.Add(this.label1);
            this.pannelLogon.Controls.Add(this.CmdLogueo);
            this.pannelLogon.Controls.Add(this.TxtPswd);
            this.pannelLogon.Controls.Add(this.TxtKeyNumber);
            this.pannelLogon.Controls.Add(this.TxtCompany);
            this.pannelLogon.Controls.Add(this.TxtUser);
            this.pannelLogon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannelLogon.Location = new System.Drawing.Point(0, 0);
            this.pannelLogon.Name = "pannelLogon";
            this.pannelLogon.Size = new System.Drawing.Size(944, 44);
            this.pannelLogon.TabIndex = 7;
            // 
            // linkAbout
            // 
            this.linkAbout.AutoSize = true;
            this.linkAbout.Location = new System.Drawing.Point(898, 13);
            this.linkAbout.Name = "linkAbout";
            this.linkAbout.Size = new System.Drawing.Size(34, 13);
            this.linkAbout.TabIndex = 19;
            this.linkAbout.TabStop = true;
            this.linkAbout.Text = "about";
            this.linkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAbout_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Llave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Empresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuario:";
            // 
            // CmdLogueo
            // 
            this.CmdLogueo.Location = new System.Drawing.Point(643, 8);
            this.CmdLogueo.Name = "CmdLogueo";
            this.CmdLogueo.Size = new System.Drawing.Size(75, 23);
            this.CmdLogueo.TabIndex = 13;
            this.CmdLogueo.Text = "&Logueo";
            this.CmdLogueo.UseVisualStyleBackColor = true;
            this.CmdLogueo.Click += new System.EventHandler(this.CmdLogueo_Click);
            // 
            // TxtPswd
            // 
            this.TxtPswd.Location = new System.Drawing.Point(537, 9);
            this.TxtPswd.Name = "TxtPswd";
            this.TxtPswd.PasswordChar = '*';
            this.TxtPswd.Size = new System.Drawing.Size(100, 20);
            this.TxtPswd.TabIndex = 12;
            // 
            // TxtKeyNumber
            // 
            this.TxtKeyNumber.Location = new System.Drawing.Point(369, 9);
            this.TxtKeyNumber.Name = "TxtKeyNumber";
            this.TxtKeyNumber.Size = new System.Drawing.Size(100, 20);
            this.TxtKeyNumber.TabIndex = 11;
            this.TxtKeyNumber.Text = "000000/001";
            // 
            // TxtCompany
            // 
            this.TxtCompany.Location = new System.Drawing.Point(221, 9);
            this.TxtCompany.Name = "TxtCompany";
            this.TxtCompany.Size = new System.Drawing.Size(100, 20);
            this.TxtCompany.TabIndex = 10;
            this.TxtCompany.Text = "Empresa Ejemplo";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(58, 9);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(100, 20);
            this.TxtUser.TabIndex = 9;
            this.TxtUser.Text = "Supervisor";
            // 
            // panelFacturas
            // 
            this.panelFacturas.Controls.Add(this.pannelOpciones);
            this.panelFacturas.Controls.Add(this.SSTabFacturas);
            this.panelFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFacturas.Location = new System.Drawing.Point(0, 44);
            this.panelFacturas.Name = "panelFacturas";
            this.panelFacturas.Size = new System.Drawing.Size(944, 327);
            this.panelFacturas.TabIndex = 8;
            // 
            // pannelOpciones
            // 
            this.pannelOpciones.Controls.Add(this.btCancelar);
            this.pannelOpciones.Controls.Add(this.button1);
            this.pannelOpciones.Controls.Add(this.CmdIngFacturas);
            this.pannelOpciones.Controls.Add(this.CmdMake);
            this.pannelOpciones.Controls.Add(this.CmdSaveData);
            this.pannelOpciones.Controls.Add(this.CmdLoadData);
            this.pannelOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pannelOpciones.Location = new System.Drawing.Point(0, 284);
            this.pannelOpciones.Name = "pannelOpciones";
            this.pannelOpciones.Size = new System.Drawing.Size(944, 43);
            this.pannelOpciones.TabIndex = 0;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(827, 11);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(110, 23);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salvar &Resultado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CmdIngFacturas
            // 
            this.CmdIngFacturas.Location = new System.Drawing.Point(349, 11);
            this.CmdIngFacturas.Name = "CmdIngFacturas";
            this.CmdIngFacturas.Size = new System.Drawing.Size(105, 23);
            this.CmdIngFacturas.TabIndex = 9;
            this.CmdIngFacturas.Text = "&Ingresar Facturas";
            this.CmdIngFacturas.UseVisualStyleBackColor = true;
            this.CmdIngFacturas.Click += new System.EventHandler(this.CmdIngFacturas_Click_1);
            // 
            // CmdMake
            // 
            this.CmdMake.Location = new System.Drawing.Point(7, 11);
            this.CmdMake.Name = "CmdMake";
            this.CmdMake.Size = new System.Drawing.Size(129, 23);
            this.CmdMake.TabIndex = 8;
            this.CmdMake.Text = "&Reconstruir Estructuras";
            this.CmdMake.UseVisualStyleBackColor = true;
            this.CmdMake.Click += new System.EventHandler(this.CmdMake_Click);
            // 
            // CmdSaveData
            // 
            this.CmdSaveData.Location = new System.Drawing.Point(142, 11);
            this.CmdSaveData.Name = "CmdSaveData";
            this.CmdSaveData.Size = new System.Drawing.Size(102, 23);
            this.CmdSaveData.TabIndex = 7;
            this.CmdSaveData.Text = "&Grabar Datos";
            this.CmdSaveData.UseVisualStyleBackColor = true;
            this.CmdSaveData.Click += new System.EventHandler(this.CmdSaveData_Click);
            // 
            // CmdLoadData
            // 
            this.CmdLoadData.Location = new System.Drawing.Point(250, 11);
            this.CmdLoadData.Name = "CmdLoadData";
            this.CmdLoadData.Size = new System.Drawing.Size(90, 23);
            this.CmdLoadData.TabIndex = 6;
            this.CmdLoadData.Text = "Cargar &Datos";
            this.CmdLoadData.UseVisualStyleBackColor = true;
            this.CmdLoadData.Click += new System.EventHandler(this.CmdLoadData_Click);
            // 
            // SSTabFacturas
            // 
            this.SSTabFacturas.Controls.Add(this.tabPage1);
            this.SSTabFacturas.Controls.Add(this.tabPage2);
            this.SSTabFacturas.Controls.Add(this.tabPage3);
            this.SSTabFacturas.Controls.Add(this.tabPage4);
            this.SSTabFacturas.Controls.Add(this.tabPage5);
            this.SSTabFacturas.Controls.Add(this.tabPage6);
            this.SSTabFacturas.Controls.Add(this.tabPage7);
            this.SSTabFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SSTabFacturas.Location = new System.Drawing.Point(0, 0);
            this.SSTabFacturas.Name = "SSTabFacturas";
            this.SSTabFacturas.SelectedIndex = 0;
            this.SSTabFacturas.Size = new System.Drawing.Size(944, 327);
            this.SSTabFacturas.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGrFacEnc);
            this.tabPage1.Controls.Add(this.panelEncOp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(936, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encabezado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGrFacEnc
            // 
            this.DGrFacEnc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrFacEnc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGrFacEnc.Location = new System.Drawing.Point(3, 29);
            this.DGrFacEnc.Name = "DGrFacEnc";
            this.DGrFacEnc.Size = new System.Drawing.Size(930, 269);
            this.DGrFacEnc.TabIndex = 4;
            this.DGrFacEnc.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataChanged);
            // 
            // panelEncOp
            // 
            this.panelEncOp.Controls.Add(this.ChkContado);
            this.panelEncOp.Controls.Add(this.ChkDefectos);
            this.panelEncOp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncOp.Location = new System.Drawing.Point(3, 3);
            this.panelEncOp.Name = "panelEncOp";
            this.panelEncOp.Size = new System.Drawing.Size(930, 26);
            this.panelEncOp.TabIndex = 3;
            // 
            // ChkContado
            // 
            this.ChkContado.AutoSize = true;
            this.ChkContado.Checked = true;
            this.ChkContado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkContado.Location = new System.Drawing.Point(127, 3);
            this.ChkContado.Name = "ChkContado";
            this.ChkContado.Size = new System.Drawing.Size(104, 17);
            this.ChkContado.TabIndex = 3;
            this.ChkContado.Text = "Pago al contado";
            this.ChkContado.UseVisualStyleBackColor = true;
            // 
            // ChkDefectos
            // 
            this.ChkDefectos.AutoSize = true;
            this.ChkDefectos.Location = new System.Drawing.Point(3, 3);
            this.ChkDefectos.Name = "ChkDefectos";
            this.ChkDefectos.Size = new System.Drawing.Size(104, 17);
            this.ChkDefectos.TabIndex = 2;
            this.ChkDefectos.Text = "Defectos Cliente";
            this.ChkDefectos.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGrFacRen);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(936, 301);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Renglones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGrFacRen
            // 
            this.DGrFacRen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrFacRen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGrFacRen.Location = new System.Drawing.Point(0, 0);
            this.DGrFacRen.Name = "DGrFacRen";
            this.DGrFacRen.Size = new System.Drawing.Size(936, 301);
            this.DGrFacRen.TabIndex = 1;
            this.DGrFacRen.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGrFacImp);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(936, 301);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Impuestos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGrFacImp
            // 
            this.DGrFacImp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrFacImp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGrFacImp.Location = new System.Drawing.Point(0, 0);
            this.DGrFacImp.Name = "DGrFacImp";
            this.DGrFacImp.Size = new System.Drawing.Size(936, 301);
            this.DGrFacImp.TabIndex = 1;
            this.DGrFacImp.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DGrFacCuo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(936, 301);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cuotas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DGrFacCuo
            // 
            this.DGrFacCuo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrFacCuo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGrFacCuo.Location = new System.Drawing.Point(0, 0);
            this.DGrFacCuo.Name = "DGrFacCuo";
            this.DGrFacCuo.Size = new System.Drawing.Size(936, 301);
            this.DGrFacCuo.TabIndex = 1;
            this.DGrFacCuo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.DGrFonEnc);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(936, 301);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Fondos Enc.";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // DGrFonEnc
            // 
            this.DGrFonEnc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrFonEnc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGrFonEnc.Location = new System.Drawing.Point(0, 0);
            this.DGrFonEnc.Name = "DGrFonEnc";
            this.DGrFonEnc.Size = new System.Drawing.Size(936, 301);
            this.DGrFonEnc.TabIndex = 1;
            this.DGrFonEnc.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.DGrFonRen);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(936, 301);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Fondos Ren.";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // DGrFonRen
            // 
            this.DGrFonRen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrFonRen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGrFonRen.Location = new System.Drawing.Point(0, 0);
            this.DGrFonRen.Name = "DGrFonRen";
            this.DGrFonRen.Size = new System.Drawing.Size(936, 301);
            this.DGrFonRen.TabIndex = 1;
            this.DGrFonRen.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.DGrResult);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(936, 301);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Resultado";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // DGrResult
            // 
            this.DGrResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGrResult.Location = new System.Drawing.Point(0, 0);
            this.DGrResult.Name = "DGrResult";
            this.DGrResult.Size = new System.Drawing.Size(936, 301);
            this.DGrResult.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 371);
            this.Controls.Add(this.panelFacturas);
            this.Controls.Add(this.pannelLogon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pannelLogon.ResumeLayout(false);
            this.pannelLogon.PerformLayout();
            this.panelFacturas.ResumeLayout(false);
            this.pannelOpciones.ResumeLayout(false);
            this.SSTabFacturas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGrFacEnc)).EndInit();
            this.panelEncOp.ResumeLayout(false);
            this.panelEncOp.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGrFacRen)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGrFacImp)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGrFacCuo)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGrFonEnc)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGrFonRen)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGrResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pannelLogon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdLogueo;
        private System.Windows.Forms.TextBox TxtPswd;
        private System.Windows.Forms.TextBox TxtKeyNumber;
        private System.Windows.Forms.TextBox TxtCompany;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Panel panelFacturas;
        private System.Windows.Forms.TabControl SSTabFacturas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGrFacImp;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView DGrFacCuo;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView DGrFonEnc;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView DGrFonRen;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView DGrResult;
        private System.Windows.Forms.Panel pannelOpciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CmdIngFacturas;
        private System.Windows.Forms.Button CmdMake;
        private System.Windows.Forms.Button CmdSaveData;
        private System.Windows.Forms.Button CmdLoadData;
        private System.Windows.Forms.Panel panelEncOp;
        private System.Windows.Forms.CheckBox ChkContado;
        private System.Windows.Forms.CheckBox ChkDefectos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGrFacRen;
        private System.Windows.Forms.DataGridView DGrFacEnc;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.LinkLabel linkAbout;

    }
}

