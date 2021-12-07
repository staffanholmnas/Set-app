
namespace Set_app
{
    partial class Set_App
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
            this.label1 = new System.Windows.Forms.Label();
            this.set_1_1 = new System.Windows.Forms.NumericUpDown();
            this.set_1_2 = new System.Windows.Forms.NumericUpDown();
            this.set_1_3 = new System.Windows.Forms.NumericUpDown();
            this.set_1_4 = new System.Windows.Forms.NumericUpDown();
            this.set_1_5 = new System.Windows.Forms.NumericUpDown();
            this.set_2_1 = new System.Windows.Forms.NumericUpDown();
            this.set_2_2 = new System.Windows.Forms.NumericUpDown();
            this.set_2_3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Union = new System.Windows.Forms.Button();
            this.Intersection = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.Button();
            this.Difference = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.set_1_6 = new System.Windows.Forms.NumericUpDown();
            this.Add_button_1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.set_1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_1_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_1_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_1_6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set 1";
            // 
            // set_1_1
            // 
            this.set_1_1.Location = new System.Drawing.Point(148, 125);
            this.set_1_1.Name = "set_1_1";
            this.set_1_1.Size = new System.Drawing.Size(62, 20);
            this.set_1_1.TabIndex = 0;
            // 
            // set_1_2
            // 
            this.set_1_2.Location = new System.Drawing.Point(148, 151);
            this.set_1_2.Name = "set_1_2";
            this.set_1_2.Size = new System.Drawing.Size(62, 20);
            this.set_1_2.TabIndex = 0;
            // 
            // set_1_3
            // 
            this.set_1_3.Location = new System.Drawing.Point(148, 177);
            this.set_1_3.Name = "set_1_3";
            this.set_1_3.Size = new System.Drawing.Size(62, 20);
            this.set_1_3.TabIndex = 0;
            this.set_1_3.Visible = false;
            // 
            // set_1_4
            // 
            this.set_1_4.Location = new System.Drawing.Point(148, 203);
            this.set_1_4.Name = "set_1_4";
            this.set_1_4.Size = new System.Drawing.Size(62, 20);
            this.set_1_4.TabIndex = 0;
            this.set_1_4.Visible = false;
            // 
            // set_1_5
            // 
            this.set_1_5.Location = new System.Drawing.Point(148, 229);
            this.set_1_5.Name = "set_1_5";
            this.set_1_5.Size = new System.Drawing.Size(62, 20);
            this.set_1_5.TabIndex = 0;
            this.set_1_5.Visible = false;
            // 
            // set_2_1
            // 
            this.set_2_1.Location = new System.Drawing.Point(247, 125);
            this.set_2_1.Name = "set_2_1";
            this.set_2_1.Size = new System.Drawing.Size(62, 20);
            this.set_2_1.TabIndex = 0;
            // 
            // set_2_2
            // 
            this.set_2_2.Location = new System.Drawing.Point(247, 151);
            this.set_2_2.Name = "set_2_2";
            this.set_2_2.Size = new System.Drawing.Size(62, 20);
            this.set_2_2.TabIndex = 0;
            // 
            // set_2_3
            // 
            this.set_2_3.Location = new System.Drawing.Point(247, 177);
            this.set_2_3.Name = "set_2_3";
            this.set_2_3.Size = new System.Drawing.Size(62, 20);
            this.set_2_3.TabIndex = 0;
            this.set_2_3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set 2";
            // 
            // Union
            // 
            this.Union.Location = new System.Drawing.Point(430, 125);
            this.Union.Name = "Union";
            this.Union.Size = new System.Drawing.Size(75, 23);
            this.Union.TabIndex = 2;
            this.Union.Text = "Union";
            this.Union.UseVisualStyleBackColor = true;
            this.Union.Click += new System.EventHandler(this.Union_Click);
            // 
            // Intersection
            // 
            this.Intersection.Location = new System.Drawing.Point(430, 154);
            this.Intersection.Name = "Intersection";
            this.Intersection.Size = new System.Drawing.Size(75, 23);
            this.Intersection.TabIndex = 2;
            this.Intersection.Text = "Intersection";
            this.Intersection.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(430, 212);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(75, 23);
            this.Product.TabIndex = 2;
            this.Product.Text = "Product";
            this.Product.UseVisualStyleBackColor = true;
            // 
            // Difference
            // 
            this.Difference.Location = new System.Drawing.Point(430, 183);
            this.Difference.Name = "Difference";
            this.Difference.Size = new System.Drawing.Size(75, 23);
            this.Difference.TabIndex = 2;
            this.Difference.Text = "Difference";
            this.Difference.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(549, 125);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(180, 110);
            this.resultLabel.TabIndex = 3;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(430, 255);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 4;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // set_1_6
            // 
            this.set_1_6.Location = new System.Drawing.Point(148, 255);
            this.set_1_6.Name = "set_1_6";
            this.set_1_6.Size = new System.Drawing.Size(62, 20);
            this.set_1_6.TabIndex = 6;
            this.set_1_6.Visible = false;
            // 
            // Add_button_1
            // 
            this.Add_button_1.Location = new System.Drawing.Point(44, 251);
            this.Add_button_1.Name = "Add_button_1";
            this.Add_button_1.Size = new System.Drawing.Size(75, 23);
            this.Add_button_1.TabIndex = 7;
            this.Add_button_1.Text = "Add element";
            this.Add_button_1.UseVisualStyleBackColor = true;
            this.Add_button_1.Click += new System.EventHandler(this.Add_button_1_Click);
            // 
            // Set_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 462);
            this.Controls.Add(this.Add_button_1);
            this.Controls.Add(this.set_1_6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.Difference);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Intersection);
            this.Controls.Add(this.Union);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.set_1_5);
            this.Controls.Add(this.set_1_4);
            this.Controls.Add(this.set_2_3);
            this.Controls.Add(this.set_1_3);
            this.Controls.Add(this.set_2_2);
            this.Controls.Add(this.set_1_2);
            this.Controls.Add(this.set_2_1);
            this.Controls.Add(this.set_1_1);
            this.Name = "Set_App";
            this.Text = "Set App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.set_1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_1_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_1_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_1_6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown set_1_1;
        private System.Windows.Forms.NumericUpDown set_1_2;
        private System.Windows.Forms.NumericUpDown set_1_3;
        private System.Windows.Forms.NumericUpDown set_1_4;
        private System.Windows.Forms.NumericUpDown set_1_5;
        private System.Windows.Forms.NumericUpDown set_2_1;
        private System.Windows.Forms.NumericUpDown set_2_2;
        private System.Windows.Forms.NumericUpDown set_2_3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Union;
        private System.Windows.Forms.Button Intersection;
        private System.Windows.Forms.Button Product;
        private System.Windows.Forms.Button Difference;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown set_1_6;
        private System.Windows.Forms.Button Add_button_1;
    }
}

