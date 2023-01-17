namespace FigureProgram
{
    partial class InstructionsBG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionsBG));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Инструкции";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(694, 403);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 35);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUK
            // 
            this.btnUK.Image = ((System.Drawing.Image)(resources.GetObject("btnUK.Image")));
            this.btnUK.Location = new System.Drawing.Point(738, 12);
            this.btnUK.Name = "btnUK";
            this.btnUK.Size = new System.Drawing.Size(50, 50);
            this.btnUK.TabIndex = 5;
            this.btnUK.UseVisualStyleBackColor = true;
            this.btnUK.Click += new System.EventHandler(this.btnUK_Click);
            // 
            // InstructionsBG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUK);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "InstructionsBG";
            this.Text = "InstructionsBG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnBack;
        private Button btnUK;
    }
}