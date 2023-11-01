
namespace Prototipo_Sistema_Gerenciamento
{
    partial class Select_CRUD
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
            this.lbl_User_Consultation = new System.Windows.Forms.Label();
            this.dgv_Consultation_User = new System.Windows.Forms.DataGridView();
            this.btn_Back_Screen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consultation_User)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_User_Consultation
            // 
            this.lbl_User_Consultation.AutoSize = true;
            this.lbl_User_Consultation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Consultation.Location = new System.Drawing.Point(336, 9);
            this.lbl_User_Consultation.Name = "lbl_User_Consultation";
            this.lbl_User_Consultation.Size = new System.Drawing.Size(151, 19);
            this.lbl_User_Consultation.TabIndex = 1;
            this.lbl_User_Consultation.Text = "Consulta de Usuários";
            this.lbl_User_Consultation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Consultation_User
            // 
            this.dgv_Consultation_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Consultation_User.Location = new System.Drawing.Point(68, 41);
            this.dgv_Consultation_User.Name = "dgv_Consultation_User";
            this.dgv_Consultation_User.Size = new System.Drawing.Size(664, 320);
            this.dgv_Consultation_User.TabIndex = 2;
            // 
            // btn_Back_Screen
            // 
            this.btn_Back_Screen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back_Screen.Location = new System.Drawing.Point(363, 394);
            this.btn_Back_Screen.Name = "btn_Back_Screen";
            this.btn_Back_Screen.Size = new System.Drawing.Size(83, 27);
            this.btn_Back_Screen.TabIndex = 3;
            this.btn_Back_Screen.Text = "VOLTAR";
            this.btn_Back_Screen.UseVisualStyleBackColor = true;
            this.btn_Back_Screen.Click += new System.EventHandler(this.btn_Back_Screen_Click);
            // 
            // Select_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back_Screen);
            this.Controls.Add(this.dgv_Consultation_User);
            this.Controls.Add(this.lbl_User_Consultation);
            this.Name = "Select_CRUD";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Select_CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consultation_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_User_Consultation;
        private System.Windows.Forms.DataGridView dgv_Consultation_User;
        private System.Windows.Forms.Button btn_Back_Screen;
    }
}

