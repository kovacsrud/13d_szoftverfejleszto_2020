
namespace WinFormsAlap
{
    partial class Szorzas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelEredmeny = new System.Windows.Forms.Label();
            this.buttonSzamol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(103, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(137, 65);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 23);
            this.textBoxA.TabIndex = 2;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(136, 157);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 23);
            this.textBoxB.TabIndex = 3;
            // 
            // labelEredmeny
            // 
            this.labelEredmeny.AutoSize = true;
            this.labelEredmeny.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEredmeny.Location = new System.Drawing.Point(116, 239);
            this.labelEredmeny.Name = "labelEredmeny";
            this.labelEredmeny.Size = new System.Drawing.Size(0, 54);
            this.labelEredmeny.TabIndex = 4;
            this.labelEredmeny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSzamol
            // 
            this.buttonSzamol.Location = new System.Drawing.Point(150, 340);
            this.buttonSzamol.Name = "buttonSzamol";
            this.buttonSzamol.Size = new System.Drawing.Size(75, 23);
            this.buttonSzamol.TabIndex = 5;
            this.buttonSzamol.Text = "Számolás";
            this.buttonSzamol.UseVisualStyleBackColor = true;
            this.buttonSzamol.Click += new System.EventHandler(this.buttonSzamol_Click);
            // 
            // Szorzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 433);
            this.Controls.Add(this.buttonSzamol);
            this.Controls.Add(this.labelEredmeny);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Szorzas";
            this.Text = "Szorzás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelEredmeny;
        private System.Windows.Forms.Button buttonSzamol;
        private System.Windows.Forms.TextBox textBoxB;
    }
}

