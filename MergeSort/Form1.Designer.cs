namespace MergeSort
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
            this.mergeSortButton = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btLoadExcel = new System.Windows.Forms.Button();
            this.btAddtoLB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mergeSortButton
            // 
            this.mergeSortButton.Location = new System.Drawing.Point(480, 249);
            this.mergeSortButton.Name = "mergeSortButton";
            this.mergeSortButton.Size = new System.Drawing.Size(221, 92);
            this.mergeSortButton.TabIndex = 0;
            this.mergeSortButton.Text = "Sort";
            this.mergeSortButton.UseVisualStyleBackColor = true;
            this.mergeSortButton.Click += new System.EventHandler(this.mergeSortButton_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(89, 123);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(348, 31);
            this.txtInput.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(89, 181);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 304);
            this.listBox1.TabIndex = 2;
            // 
            // btLoadExcel
            // 
            this.btLoadExcel.Location = new System.Drawing.Point(480, 375);
            this.btLoadExcel.Name = "btLoadExcel";
            this.btLoadExcel.Size = new System.Drawing.Size(221, 92);
            this.btLoadExcel.TabIndex = 3;
            this.btLoadExcel.Text = "Load Excel";
            this.btLoadExcel.UseVisualStyleBackColor = true;
            this.btLoadExcel.Click += new System.EventHandler(this.btLoadExcel_Click);
            // 
            // btAddtoLB
            // 
            this.btAddtoLB.Location = new System.Drawing.Point(480, 123);
            this.btAddtoLB.Name = "btAddtoLB";
            this.btAddtoLB.Size = new System.Drawing.Size(221, 92);
            this.btAddtoLB.TabIndex = 4;
            this.btAddtoLB.Text = "Add to ListBox";
            this.btAddtoLB.UseVisualStyleBackColor = true;
            this.btAddtoLB.Click += new System.EventHandler(this.btAddtoLB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 763);
            this.Controls.Add(this.btAddtoLB);
            this.Controls.Add(this.btLoadExcel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.mergeSortButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mergeSortButton;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btLoadExcel;
        private System.Windows.Forms.Button btAddtoLB;
    }
}

