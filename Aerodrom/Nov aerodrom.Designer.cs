namespace Aerodrom
{
    partial class Nov_aerodrom
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kratenka = new System.Windows.Forms.TextBox();
            this.ime = new System.Windows.Forms.TextBox();
            this.grad = new System.Windows.Forms.TextBox();
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.err2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.err3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.kratenka);
            this.groupBox1.Controls.Add(this.ime);
            this.groupBox1.Controls.Add(this.grad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади аеродром";
            this.groupBox1.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Град";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Име";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кратенка";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(175, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Откажи";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Зачувај";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kratenka
            // 
            this.kratenka.Location = new System.Drawing.Point(11, 153);
            this.kratenka.Name = "kratenka";
            this.kratenka.Size = new System.Drawing.Size(100, 20);
            this.kratenka.TabIndex = 2;
            this.kratenka.Validating += new System.ComponentModel.CancelEventHandler(this.Validate2);
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(11, 98);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(269, 20);
            this.ime.TabIndex = 1;
            this.ime.Validating += new System.ComponentModel.CancelEventHandler(this.Validate1);
            // 
            // grad
            // 
            this.grad.Location = new System.Drawing.Point(11, 43);
            this.grad.Name = "grad";
            this.grad.Size = new System.Drawing.Size(269, 20);
            this.grad.TabIndex = 0;
            this.grad.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // err1
            // 
            this.err1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err1.ContainerControl = this;
            // 
            // err2
            // 
            this.err2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err2.ContainerControl = this;
            // 
            // err3
            // 
            this.err3.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err3.ContainerControl = this;
            // 
            // Nov_aerodrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 248);
            this.Controls.Add(this.groupBox1);
            this.Name = "Nov_aerodrom";
            this.Text = "Нов Аеродром";
            this.Load += new System.EventHandler(this.Nov_aerodrom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox kratenka;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.TextBox grad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider err1;
        private System.Windows.Forms.ErrorProvider err2;
        private System.Windows.Forms.ErrorProvider err3;
    }
}