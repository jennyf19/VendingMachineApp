namespace VendingMachineApp
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
            this.InsertMoney = new System.Windows.Forms.Label();
            this.ExactChange = new System.Windows.Forms.Label();
            this.TotalAmountInserted = new System.Windows.Forms.Label();
            this.regular = new System.Windows.Forms.PictureBox();
            this.diet = new System.Windows.Forms.PictureBox();
            this.fanta = new System.Windows.Forms.PictureBox();
            this.MoneyReturned = new System.Windows.Forms.Button();
            this.RegularDispense = new System.Windows.Forms.Button();
            this.DietDispense = new System.Windows.Forms.Button();
            this.FantaDispense = new System.Windows.Forms.Button();
            this.Quarter = new System.Windows.Forms.Button();
            this.Dime = new System.Windows.Forms.Button();
            this.Nickel = new System.Windows.Forms.Button();
            this.HalfDollar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.regular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fanta)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertMoney
            // 
            this.InsertMoney.AutoSize = true;
            this.InsertMoney.Location = new System.Drawing.Point(897, 24);
            this.InsertMoney.Name = "InsertMoney";
            this.InsertMoney.Size = new System.Drawing.Size(150, 29);
            this.InsertMoney.TabIndex = 0;
            this.InsertMoney.Text = "Insert Money";
            // 
            // ExactChange
            // 
            this.ExactChange.AutoSize = true;
            this.ExactChange.Location = new System.Drawing.Point(755, 88);
            this.ExactChange.Name = "ExactChange";
            this.ExactChange.Size = new System.Drawing.Size(277, 29);
            this.ExactChange.TabIndex = 1;
            this.ExactChange.Text = "Exact change is required";
            // 
            // TotalAmountInserted
            // 
            this.TotalAmountInserted.AutoSize = true;
            this.TotalAmountInserted.Location = new System.Drawing.Point(683, 385);
            this.TotalAmountInserted.Name = "TotalAmountInserted";
            this.TotalAmountInserted.Size = new System.Drawing.Size(364, 29);
            this.TotalAmountInserted.TabIndex = 2;
            this.TotalAmountInserted.Text = "Total Amount of Money Inserted: ";
            // 
            // regular
            // 
            this.regular.Image = ((System.Drawing.Image)(resources.GetObject("regular.Image")));
            this.regular.InitialImage = ((System.Drawing.Image)(resources.GetObject("regular.InitialImage")));
            this.regular.Location = new System.Drawing.Point(75, 453);
            this.regular.Name = "regular";
            this.regular.Size = new System.Drawing.Size(300, 300);
            this.regular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.regular.TabIndex = 3;
            this.regular.TabStop = false;
            this.regular.Click += new System.EventHandler(this.regular_Click);
            // 
            // diet
            // 
            this.diet.Image = ((System.Drawing.Image)(resources.GetObject("diet.Image")));
            this.diet.InitialImage = ((System.Drawing.Image)(resources.GetObject("diet.InitialImage")));
            this.diet.Location = new System.Drawing.Point(436, 465);
            this.diet.Name = "diet";
            this.diet.Size = new System.Drawing.Size(384, 288);
            this.diet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.diet.TabIndex = 4;
            this.diet.TabStop = false;
            // 
            // fanta
            // 
            this.fanta.Image = ((System.Drawing.Image)(resources.GetObject("fanta.Image")));
            this.fanta.InitialImage = ((System.Drawing.Image)(resources.GetObject("fanta.InitialImage")));
            this.fanta.Location = new System.Drawing.Point(892, 453);
            this.fanta.Name = "fanta";
            this.fanta.Size = new System.Drawing.Size(300, 300);
            this.fanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fanta.TabIndex = 5;
            this.fanta.TabStop = false;
            // 
            // MoneyReturned
            // 
            this.MoneyReturned.Location = new System.Drawing.Point(61, 1013);
            this.MoneyReturned.Name = "MoneyReturned";
            this.MoneyReturned.Size = new System.Drawing.Size(222, 54);
            this.MoneyReturned.TabIndex = 6;
            this.MoneyReturned.Text = "Money returned";
            this.MoneyReturned.UseVisualStyleBackColor = true;
            // 
            // RegularDispense
            // 
            this.RegularDispense.Location = new System.Drawing.Point(135, 774);
            this.RegularDispense.Name = "RegularDispense";
            this.RegularDispense.Size = new System.Drawing.Size(148, 57);
            this.RegularDispense.TabIndex = 7;
            this.RegularDispense.Text = "Regular";
            this.RegularDispense.UseVisualStyleBackColor = true;
            // 
            // DietDispense
            // 
            this.DietDispense.Location = new System.Drawing.Point(525, 779);
            this.DietDispense.Name = "DietDispense";
            this.DietDispense.Size = new System.Drawing.Size(164, 52);
            this.DietDispense.TabIndex = 8;
            this.DietDispense.Text = "Diet";
            this.DietDispense.UseVisualStyleBackColor = true;
            // 
            // FantaDispense
            // 
            this.FantaDispense.Location = new System.Drawing.Point(947, 774);
            this.FantaDispense.Name = "FantaDispense";
            this.FantaDispense.Size = new System.Drawing.Size(155, 57);
            this.FantaDispense.TabIndex = 9;
            this.FantaDispense.Text = "Fanta";
            this.FantaDispense.UseVisualStyleBackColor = true;
            // 
            // Quarter
            // 
            this.Quarter.Location = new System.Drawing.Point(1106, 107);
            this.Quarter.Name = "Quarter";
            this.Quarter.Size = new System.Drawing.Size(86, 71);
            this.Quarter.TabIndex = 10;
            this.Quarter.Text = "$0.25";
            this.Quarter.UseVisualStyleBackColor = true;
            // 
            // Dime
            // 
            this.Dime.Location = new System.Drawing.Point(1106, 200);
            this.Dime.Name = "Dime";
            this.Dime.Size = new System.Drawing.Size(88, 70);
            this.Dime.TabIndex = 11;
            this.Dime.Text = "$0.10";
            this.Dime.UseVisualStyleBackColor = true;
            // 
            // Nickel
            // 
            this.Nickel.Location = new System.Drawing.Point(1106, 301);
            this.Nickel.Name = "Nickel";
            this.Nickel.Size = new System.Drawing.Size(86, 74);
            this.Nickel.TabIndex = 12;
            this.Nickel.Text = "$0.05";
            this.Nickel.UseVisualStyleBackColor = true;
            // 
            // HalfDollar
            // 
            this.HalfDollar.Location = new System.Drawing.Point(1113, 3);
            this.HalfDollar.Name = "HalfDollar";
            this.HalfDollar.Size = new System.Drawing.Size(83, 71);
            this.HalfDollar.TabIndex = 13;
            this.HalfDollar.Text = "$0.50";
            this.HalfDollar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 1094);
            this.Controls.Add(this.HalfDollar);
            this.Controls.Add(this.Nickel);
            this.Controls.Add(this.Dime);
            this.Controls.Add(this.Quarter);
            this.Controls.Add(this.FantaDispense);
            this.Controls.Add(this.DietDispense);
            this.Controls.Add(this.RegularDispense);
            this.Controls.Add(this.MoneyReturned);
            this.Controls.Add(this.fanta);
            this.Controls.Add(this.diet);
            this.Controls.Add(this.regular);
            this.Controls.Add(this.TotalAmountInserted);
            this.Controls.Add(this.ExactChange);
            this.Controls.Add(this.InsertMoney);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.regular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fanta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InsertMoney;
        private System.Windows.Forms.Label ExactChange;
        private System.Windows.Forms.Label TotalAmountInserted;
        private System.Windows.Forms.PictureBox regular;
        private System.Windows.Forms.PictureBox diet;
        private System.Windows.Forms.PictureBox fanta;
        private System.Windows.Forms.Button MoneyReturned;
        private System.Windows.Forms.Button RegularDispense;
        private System.Windows.Forms.Button DietDispense;
        private System.Windows.Forms.Button FantaDispense;
        private System.Windows.Forms.Button Quarter;
        private System.Windows.Forms.Button Dime;
        private System.Windows.Forms.Button Nickel;
        private System.Windows.Forms.Button HalfDollar;
    }
}

