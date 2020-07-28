namespace Serializzazione
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
            this.btn_serialize = new System.Windows.Forms.Button();
            this.btn_deserialize = new System.Windows.Forms.Button();
            this.tbx_cognome = new System.Windows.Forms.TextBox();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.tbx_età = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_serialize
            // 
            this.btn_serialize.Location = new System.Drawing.Point(49, 221);
            this.btn_serialize.Name = "btn_serialize";
            this.btn_serialize.Size = new System.Drawing.Size(232, 125);
            this.btn_serialize.TabIndex = 4;
            this.btn_serialize.Text = "Serializza persona";
            this.btn_serialize.UseVisualStyleBackColor = true;
            this.btn_serialize.Click += new System.EventHandler(this.btn_serialize_Click);
            // 
            // btn_deserialize
            // 
            this.btn_deserialize.Location = new System.Drawing.Point(520, 221);
            this.btn_deserialize.Name = "btn_deserialize";
            this.btn_deserialize.Size = new System.Drawing.Size(232, 125);
            this.btn_deserialize.TabIndex = 5;
            this.btn_deserialize.Text = "Deserializza persona";
            this.btn_deserialize.UseVisualStyleBackColor = true;
            this.btn_deserialize.Click += new System.EventHandler(this.btn_deserialize_Click);
            // 
            // tbx_cognome
            // 
            this.tbx_cognome.Location = new System.Drawing.Point(288, 80);
            this.tbx_cognome.Name = "tbx_cognome";
            this.tbx_cognome.Size = new System.Drawing.Size(225, 26);
            this.tbx_cognome.TabIndex = 2;
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(288, 34);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(225, 26);
            this.tbx_nome.TabIndex = 1;
            // 
            // tbx_età
            // 
            this.tbx_età.Location = new System.Drawing.Point(288, 128);
            this.tbx_età.Name = "tbx_età";
            this.tbx_età.Size = new System.Drawing.Size(225, 26);
            this.tbx_età.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cognome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Età";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_età);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.tbx_cognome);
            this.Controls.Add(this.btn_deserialize);
            this.Controls.Add(this.btn_serialize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_serialize;
        private System.Windows.Forms.Button btn_deserialize;
        private System.Windows.Forms.TextBox tbx_cognome;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.TextBox tbx_età;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

