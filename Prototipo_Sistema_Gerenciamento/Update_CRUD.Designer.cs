
namespace Prototipo_Sistema_Gerenciamento
{
    partial class Update_CRUD
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
            this.btn_Back_Screen = new System.Windows.Forms.Button();
            this.btn_Updade_User = new System.Windows.Forms.Button();
            this.btn_Consultation_User = new System.Windows.Forms.Button();
            this.dgv_Consultation_User = new System.Windows.Forms.DataGridView();
            this.lbl_Title_Update = new System.Windows.Forms.Label();
            this.txt_Update_Id = new System.Windows.Forms.TextBox();
            this.txt_Update_Name = new System.Windows.Forms.TextBox();
            this.txt_Update_Age = new System.Windows.Forms.TextBox();
            this.txt_Update_Adress = new System.Windows.Forms.TextBox();
            this.txt_Update_Phone = new System.Windows.Forms.TextBox();
            this.txt_Update_Email = new System.Windows.Forms.TextBox();
            this.lbl_Update_Id = new System.Windows.Forms.Label();
            this.lbl_Update_Name = new System.Windows.Forms.Label();
            this.lbl_Update_Age = new System.Windows.Forms.Label();
            this.lbl_Update_Adress = new System.Windows.Forms.Label();
            this.lbl_Update_Phone = new System.Windows.Forms.Label();
            this.lbl_Update_Email = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consultation_User)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back_Screen
            // 
            this.btn_Back_Screen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back_Screen.Location = new System.Drawing.Point(90, 404);
            this.btn_Back_Screen.Name = "btn_Back_Screen";
            this.btn_Back_Screen.Size = new System.Drawing.Size(83, 34);
            this.btn_Back_Screen.TabIndex = 0;
            this.btn_Back_Screen.Text = "VOLTAR";
            this.btn_Back_Screen.UseVisualStyleBackColor = true;
            this.btn_Back_Screen.Click += new System.EventHandler(this.btn_Back_Screen_Click);
            // 
            // btn_Updade_User
            // 
            this.btn_Updade_User.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Updade_User.Location = new System.Drawing.Point(592, 406);
            this.btn_Updade_User.Name = "btn_Updade_User";
            this.btn_Updade_User.Size = new System.Drawing.Size(123, 32);
            this.btn_Updade_User.TabIndex = 1;
            this.btn_Updade_User.Text = "ATUALIZAR";
            this.btn_Updade_User.UseVisualStyleBackColor = true;
            this.btn_Updade_User.Click += new System.EventHandler(this.btn_Updade_User_Click);
            // 
            // btn_Consultation_User
            // 
            this.btn_Consultation_User.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultation_User.Location = new System.Drawing.Point(350, 409);
            this.btn_Consultation_User.Name = "btn_Consultation_User";
            this.btn_Consultation_User.Size = new System.Drawing.Size(115, 29);
            this.btn_Consultation_User.TabIndex = 2;
            this.btn_Consultation_User.Text = "CONSULTAR";
            this.btn_Consultation_User.UseVisualStyleBackColor = true;
            this.btn_Consultation_User.Click += new System.EventHandler(this.btn_Consultation_User_Click);
            // 
            // dgv_Consultation_User
            // 
            this.dgv_Consultation_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Consultation_User.Location = new System.Drawing.Point(90, 42);
            this.dgv_Consultation_User.Name = "dgv_Consultation_User";
            this.dgv_Consultation_User.Size = new System.Drawing.Size(625, 150);
            this.dgv_Consultation_User.TabIndex = 3;
            this.dgv_Consultation_User.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Consultation_User_CellContentClick);
            this.dgv_Consultation_User.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Consultation_User_CellMouseDoubleClick);
            // 
            // lbl_Title_Update
            // 
            this.lbl_Title_Update.AutoSize = true;
            this.lbl_Title_Update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title_Update.Location = new System.Drawing.Point(290, 9);
            this.lbl_Title_Update.Name = "lbl_Title_Update";
            this.lbl_Title_Update.Size = new System.Drawing.Size(230, 19);
            this.lbl_Title_Update.TabIndex = 4;
            this.lbl_Title_Update.Text = "Atualizar informações do Usuário";
            this.lbl_Title_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Update_Id
            // 
            this.txt_Update_Id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Update_Id.Location = new System.Drawing.Point(156, 208);
            this.txt_Update_Id.Name = "txt_Update_Id";
            this.txt_Update_Id.Size = new System.Drawing.Size(559, 26);
            this.txt_Update_Id.TabIndex = 5;
            // 
            // txt_Update_Name
            // 
            this.txt_Update_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Update_Name.Location = new System.Drawing.Point(156, 240);
            this.txt_Update_Name.Name = "txt_Update_Name";
            this.txt_Update_Name.Size = new System.Drawing.Size(559, 26);
            this.txt_Update_Name.TabIndex = 6;
            // 
            // txt_Update_Age
            // 
            this.txt_Update_Age.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Update_Age.Location = new System.Drawing.Point(156, 272);
            this.txt_Update_Age.Name = "txt_Update_Age";
            this.txt_Update_Age.Size = new System.Drawing.Size(559, 26);
            this.txt_Update_Age.TabIndex = 7;
            // 
            // txt_Update_Adress
            // 
            this.txt_Update_Adress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Update_Adress.Location = new System.Drawing.Point(156, 304);
            this.txt_Update_Adress.Name = "txt_Update_Adress";
            this.txt_Update_Adress.Size = new System.Drawing.Size(559, 26);
            this.txt_Update_Adress.TabIndex = 8;
            // 
            // txt_Update_Phone
            // 
            this.txt_Update_Phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Update_Phone.Location = new System.Drawing.Point(156, 336);
            this.txt_Update_Phone.Name = "txt_Update_Phone";
            this.txt_Update_Phone.Size = new System.Drawing.Size(559, 26);
            this.txt_Update_Phone.TabIndex = 9;
            // 
            // txt_Update_Email
            // 
            this.txt_Update_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Update_Email.Location = new System.Drawing.Point(156, 368);
            this.txt_Update_Email.Name = "txt_Update_Email";
            this.txt_Update_Email.Size = new System.Drawing.Size(559, 26);
            this.txt_Update_Email.TabIndex = 10;
            // 
            // lbl_Update_Id
            // 
            this.lbl_Update_Id.AutoSize = true;
            this.lbl_Update_Id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_Id.Location = new System.Drawing.Point(93, 211);
            this.lbl_Update_Id.Name = "lbl_Update_Id";
            this.lbl_Update_Id.Size = new System.Drawing.Size(57, 19);
            this.lbl_Update_Id.TabIndex = 11;
            this.lbl_Update_Id.Text = "Código:";
            this.lbl_Update_Id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Update_Name
            // 
            this.lbl_Update_Name.AutoSize = true;
            this.lbl_Update_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_Name.Location = new System.Drawing.Point(100, 243);
            this.lbl_Update_Name.Name = "lbl_Update_Name";
            this.lbl_Update_Name.Size = new System.Drawing.Size(50, 19);
            this.lbl_Update_Name.TabIndex = 12;
            this.lbl_Update_Name.Text = "Nome:";
            // 
            // lbl_Update_Age
            // 
            this.lbl_Update_Age.AutoSize = true;
            this.lbl_Update_Age.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_Age.Location = new System.Drawing.Point(103, 275);
            this.lbl_Update_Age.Name = "lbl_Update_Age";
            this.lbl_Update_Age.Size = new System.Drawing.Size(47, 19);
            this.lbl_Update_Age.TabIndex = 13;
            this.lbl_Update_Age.Text = "Idade:";
            // 
            // lbl_Update_Adress
            // 
            this.lbl_Update_Adress.AutoSize = true;
            this.lbl_Update_Adress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_Adress.Location = new System.Drawing.Point(80, 307);
            this.lbl_Update_Adress.Name = "lbl_Update_Adress";
            this.lbl_Update_Adress.Size = new System.Drawing.Size(70, 19);
            this.lbl_Update_Adress.TabIndex = 14;
            this.lbl_Update_Adress.Text = "Endereço:";
            // 
            // lbl_Update_Phone
            // 
            this.lbl_Update_Phone.AutoSize = true;
            this.lbl_Update_Phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_Phone.Location = new System.Drawing.Point(87, 339);
            this.lbl_Update_Phone.Name = "lbl_Update_Phone";
            this.lbl_Update_Phone.Size = new System.Drawing.Size(63, 19);
            this.lbl_Update_Phone.TabIndex = 15;
            this.lbl_Update_Phone.Text = "Telefone:";
            // 
            // lbl_Update_Email
            // 
            this.lbl_Update_Email.AutoSize = true;
            this.lbl_Update_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_Email.Location = new System.Drawing.Point(99, 371);
            this.lbl_Update_Email.Name = "lbl_Update_Email";
            this.lbl_Update_Email.Size = new System.Drawing.Size(51, 19);
            this.lbl_Update_Email.TabIndex = 16;
            this.lbl_Update_Email.Text = "E-mail:";
            // 
            // Update_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Update_Email);
            this.Controls.Add(this.lbl_Update_Phone);
            this.Controls.Add(this.lbl_Update_Adress);
            this.Controls.Add(this.lbl_Update_Age);
            this.Controls.Add(this.lbl_Update_Name);
            this.Controls.Add(this.lbl_Update_Id);
            this.Controls.Add(this.txt_Update_Email);
            this.Controls.Add(this.txt_Update_Phone);
            this.Controls.Add(this.txt_Update_Adress);
            this.Controls.Add(this.txt_Update_Age);
            this.Controls.Add(this.txt_Update_Name);
            this.Controls.Add(this.txt_Update_Id);
            this.Controls.Add(this.lbl_Title_Update);
            this.Controls.Add(this.dgv_Consultation_User);
            this.Controls.Add(this.btn_Consultation_User);
            this.Controls.Add(this.btn_Updade_User);
            this.Controls.Add(this.btn_Back_Screen);
            this.Name = "Update_CRUD";
            this.Text = "Update_CRUD";
            this.Load += new System.EventHandler(this.Update_CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consultation_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back_Screen;
        private System.Windows.Forms.Button btn_Updade_User;
        private System.Windows.Forms.Button btn_Consultation_User;
        private System.Windows.Forms.DataGridView dgv_Consultation_User;
        private System.Windows.Forms.Label lbl_Title_Update;
        private System.Windows.Forms.TextBox txt_Update_Id;
        private System.Windows.Forms.TextBox txt_Update_Name;
        private System.Windows.Forms.TextBox txt_Update_Age;
        private System.Windows.Forms.TextBox txt_Update_Adress;
        private System.Windows.Forms.TextBox txt_Update_Phone;
        private System.Windows.Forms.TextBox txt_Update_Email;
        private System.Windows.Forms.Label lbl_Update_Id;
        private System.Windows.Forms.Label lbl_Update_Name;
        private System.Windows.Forms.Label lbl_Update_Age;
        private System.Windows.Forms.Label lbl_Update_Adress;
        private System.Windows.Forms.Label lbl_Update_Phone;
        private System.Windows.Forms.Label lbl_Update_Email;
    }
}