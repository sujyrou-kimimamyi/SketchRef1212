namespace sketchref
{
    partial class Form3
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
            this.bnt_register = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lbl_frase = new System.Windows.Forms.Label();
            this.lbl_tittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnt_register
            // 
            this.bnt_register.Location = new System.Drawing.Point(472, 272);
            this.bnt_register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnt_register.Name = "bnt_register";
            this.bnt_register.Size = new System.Drawing.Size(96, 29);
            this.bnt_register.TabIndex = 0;
            this.bnt_register.Text = "Cadastrar";
            this.bnt_register.UseVisualStyleBackColor = true;
            this.bnt_register.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(454, 335);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(136, 48);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "editar ou excluir o cadastro";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_frase
            // 
            this.lbl_frase.AutoSize = true;
            this.lbl_frase.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_frase.Location = new System.Drawing.Point(296, 133);
            this.lbl_frase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_frase.Name = "lbl_frase";
            this.lbl_frase.Size = new System.Drawing.Size(441, 56);
            this.lbl_frase.TabIndex = 17;
            this.lbl_frase.Text = "As melhores referências!";
            this.lbl_frase.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_tittle
            // 
            this.lbl_tittle.AutoSize = true;
            this.lbl_tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tittle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_tittle.Location = new System.Drawing.Point(386, 69);
            this.lbl_tittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tittle.Name = "lbl_tittle";
            this.lbl_tittle.Size = new System.Drawing.Size(249, 54);
            this.lbl_tittle.TabIndex = 18;
            this.lbl_tittle.Text = "SketchRef";
            this.lbl_tittle.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbl_tittle);
            this.Controls.Add(this.lbl_frase);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.bnt_register);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_register;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label lbl_frase;
        private System.Windows.Forms.Label lbl_tittle;
    }
}