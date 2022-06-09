
namespace ControllerGenerator
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_api = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameController = new System.Windows.Forms.TextBox();
            this.cbxGet = new System.Windows.Forms.CheckBox();
            this.cbxUpdate = new System.Windows.Forms.CheckBox();
            this.cbxDelete = new System.Windows.Forms.CheckBox();
            this.cbxInsert = new System.Windows.Forms.CheckBox();
            this.btController = new System.Windows.Forms.Button();
            this.btService = new System.Windows.Forms.Button();
            this.btRepository = new System.Windows.Forms.Button();
            this.txtGenerated = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_api
            // 
            this.cb_api.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_api.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_api.FormattingEnabled = true;
            this.cb_api.Items.AddRange(new object[] {
            "solos-apirest-atividade-request",
            "solos-apirest-cadastros-auxiliares-request",
            "solos-apirest-controle-documentos-request",
            "solos-apirest-seguranca-request",
            "Outra api"});
            this.cb_api.Location = new System.Drawing.Point(233, 25);
            this.cb_api.Name = "cb_api";
            this.cb_api.Size = new System.Drawing.Size(319, 28);
            this.cb_api.TabIndex = 0;
            this.cb_api.SelectedIndexChanged += new System.EventHandler(this.cb_api_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe o nome do Controller:";
            // 
            // txtNameController
            // 
            this.txtNameController.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameController.Location = new System.Drawing.Point(233, 59);
            this.txtNameController.Name = "txtNameController";
            this.txtNameController.Size = new System.Drawing.Size(319, 26);
            this.txtNameController.TabIndex = 3;
            // 
            // cbxGet
            // 
            this.cbxGet.AutoSize = true;
            this.cbxGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGet.Location = new System.Drawing.Point(12, 100);
            this.cbxGet.Name = "cbxGet";
            this.cbxGet.Size = new System.Drawing.Size(83, 24);
            this.cbxGet.TabIndex = 4;
            this.cbxGet.Text = "getById";
            this.cbxGet.UseVisualStyleBackColor = true;
            // 
            // cbxUpdate
            // 
            this.cbxUpdate.AutoSize = true;
            this.cbxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUpdate.Location = new System.Drawing.Point(101, 100);
            this.cbxUpdate.Name = "cbxUpdate";
            this.cbxUpdate.Size = new System.Drawing.Size(110, 24);
            this.cbxUpdate.TabIndex = 5;
            this.cbxUpdate.Text = "updateById";
            this.cbxUpdate.UseVisualStyleBackColor = true;
            // 
            // cbxDelete
            // 
            this.cbxDelete.AutoSize = true;
            this.cbxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDelete.Location = new System.Drawing.Point(217, 100);
            this.cbxDelete.Name = "cbxDelete";
            this.cbxDelete.Size = new System.Drawing.Size(104, 24);
            this.cbxDelete.TabIndex = 6;
            this.cbxDelete.Text = "deleteById";
            this.cbxDelete.UseVisualStyleBackColor = true;
            // 
            // cbxInsert
            // 
            this.cbxInsert.AutoSize = true;
            this.cbxInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxInsert.Location = new System.Drawing.Point(327, 100);
            this.cbxInsert.Name = "cbxInsert";
            this.cbxInsert.Size = new System.Drawing.Size(67, 24);
            this.cbxInsert.TabIndex = 7;
            this.cbxInsert.Text = "insert";
            this.cbxInsert.UseVisualStyleBackColor = true;
            // 
            // btController
            // 
            this.btController.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btController.Location = new System.Drawing.Point(12, 143);
            this.btController.Name = "btController";
            this.btController.Size = new System.Drawing.Size(138, 35);
            this.btController.TabIndex = 8;
            this.btController.Text = "Gerar Controller";
            this.btController.UseVisualStyleBackColor = true;
            this.btController.Click += new System.EventHandler(this.btController_Click);
            // 
            // btService
            // 
            this.btService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btService.Location = new System.Drawing.Point(156, 143);
            this.btService.Name = "btService";
            this.btService.Size = new System.Drawing.Size(138, 35);
            this.btService.TabIndex = 9;
            this.btService.Text = "Gerar Service";
            this.btService.UseVisualStyleBackColor = true;
            this.btService.Click += new System.EventHandler(this.btService_Click);
            // 
            // btRepository
            // 
            this.btRepository.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRepository.Location = new System.Drawing.Point(300, 143);
            this.btRepository.Name = "btRepository";
            this.btRepository.Size = new System.Drawing.Size(138, 35);
            this.btRepository.TabIndex = 10;
            this.btRepository.Text = "Gerar Repository";
            this.btRepository.UseVisualStyleBackColor = true;
            this.btRepository.Click += new System.EventHandler(this.btRepository_Click);
            // 
            // txtGenerated
            // 
            this.txtGenerated.Location = new System.Drawing.Point(12, 184);
            this.txtGenerated.Name = "txtGenerated";
            this.txtGenerated.Size = new System.Drawing.Size(776, 254);
            this.txtGenerated.TabIndex = 11;
            this.txtGenerated.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Informe a API:";
            // 
            // txtApi
            // 
            this.txtApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApi.Location = new System.Drawing.Point(558, 25);
            this.txtApi.Name = "txtApi";
            this.txtApi.Size = new System.Drawing.Size(230, 27);
            this.txtApi.TabIndex = 13;
            this.txtApi.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtApi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGenerated);
            this.Controls.Add(this.btRepository);
            this.Controls.Add(this.btService);
            this.Controls.Add(this.btController);
            this.Controls.Add(this.cbxInsert);
            this.Controls.Add(this.cbxDelete);
            this.Controls.Add(this.cbxUpdate);
            this.Controls.Add(this.cbxGet);
            this.Controls.Add(this.txtNameController);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_api);
            this.Name = "Home";
            this.Text = "ControllerGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_api;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameController;
        private System.Windows.Forms.CheckBox cbxGet;
        private System.Windows.Forms.CheckBox cbxUpdate;
        private System.Windows.Forms.CheckBox cbxDelete;
        private System.Windows.Forms.CheckBox cbxInsert;
        private System.Windows.Forms.Button btController;
        private System.Windows.Forms.Button btService;
        private System.Windows.Forms.Button btRepository;
        private System.Windows.Forms.RichTextBox txtGenerated;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApi;
    }
}

