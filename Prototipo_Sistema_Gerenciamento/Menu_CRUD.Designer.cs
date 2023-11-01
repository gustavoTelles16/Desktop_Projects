
namespace Prototipo_Sistema_Gerenciamento
{
    partial class Menu_CRUD
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mn_Cadastration = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_Cadastration_User = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_Consultation = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_Consultation_User = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_Edition = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_Edition_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_Edition_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_Cadastration,
            this.mn_Consultation,
            this.mn_Edition});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mn_Cadastration
            // 
            this.mn_Cadastration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_Cadastration_User});
            this.mn_Cadastration.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_Cadastration.Name = "mn_Cadastration";
            this.mn_Cadastration.Size = new System.Drawing.Size(81, 23);
            this.mn_Cadastration.Text = "Cadastrar";
            // 
            // mn_Cadastration_User
            // 
            this.mn_Cadastration_User.Name = "mn_Cadastration_User";
            this.mn_Cadastration_User.Size = new System.Drawing.Size(125, 24);
            this.mn_Cadastration_User.Text = "Usuário";
            this.mn_Cadastration_User.Click += new System.EventHandler(this.mn_Cadastration_User_Click);
            // 
            // mn_Consultation
            // 
            this.mn_Consultation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_Consultation_User});
            this.mn_Consultation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_Consultation.Name = "mn_Consultation";
            this.mn_Consultation.Size = new System.Drawing.Size(79, 23);
            this.mn_Consultation.Text = "Consultar";
            // 
            // mn_Consultation_User
            // 
            this.mn_Consultation_User.Name = "mn_Consultation_User";
            this.mn_Consultation_User.Size = new System.Drawing.Size(125, 24);
            this.mn_Consultation_User.Text = "Usuário";
            this.mn_Consultation_User.Click += new System.EventHandler(this.mn_Consultation_User_Click);
            // 
            // mn_Edition
            // 
            this.mn_Edition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_Edition_Update,
            this.mn_Edition_Delete});
            this.mn_Edition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_Edition.Name = "mn_Edition";
            this.mn_Edition.Size = new System.Drawing.Size(57, 23);
            this.mn_Edition.Text = "Editar";
            // 
            // mn_Edition_Update
            // 
            this.mn_Edition_Update.Name = "mn_Edition_Update";
            this.mn_Edition_Update.Size = new System.Drawing.Size(208, 24);
            this.mn_Edition_Update.Text = "Atualizar informações";
            this.mn_Edition_Update.Click += new System.EventHandler(this.mn_Edition_Update_Click);
            // 
            // mn_Edition_Delete
            // 
            this.mn_Edition_Delete.Name = "mn_Edition_Delete";
            this.mn_Edition_Delete.Size = new System.Drawing.Size(208, 24);
            this.mn_Edition_Delete.Text = "Deletar";
            this.mn_Edition_Delete.Click += new System.EventHandler(this.mn_Edition_Delete_Click);
            // 
            // Menu_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_CRUD";
            this.Text = "Menu_CRUD";
            this.Load += new System.EventHandler(this.Menu_CRUD_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mn_Cadastration;
        private System.Windows.Forms.ToolStripMenuItem mn_Cadastration_User;
        private System.Windows.Forms.ToolStripMenuItem mn_Consultation;
        private System.Windows.Forms.ToolStripMenuItem mn_Consultation_User;
        private System.Windows.Forms.ToolStripMenuItem mn_Edition;
        private System.Windows.Forms.ToolStripMenuItem mn_Edition_Update;
        private System.Windows.Forms.ToolStripMenuItem mn_Edition_Delete;
    }
}