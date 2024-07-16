namespace UI
{
   partial class ProductForm
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
         this.groupBoxProductC = new System.Windows.Forms.GroupBox();
         this.textBoxamt = new System.Windows.Forms.TextBox();
         this.textBoxCPU = new System.Windows.Forms.TextBox();
         this.textBoxPName = new System.Windows.Forms.TextBox();
         this.textBoxPNumber = new System.Windows.Forms.TextBox();
         this.labelamt = new System.Windows.Forms.Label();
         this.labelCPU = new System.Windows.Forms.Label();
         this.labelPNumber = new System.Windows.Forms.Label();
         this.labelPName = new System.Windows.Forms.Label();
         this.groupBoxCRUD.SuspendLayout();
         this.groupBoxProductC.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBoxProductC
         // 
         this.groupBoxProductC.Controls.Add(this.textBoxamt);
         this.groupBoxProductC.Controls.Add(this.textBoxCPU);
         this.groupBoxProductC.Controls.Add(this.textBoxPName);
         this.groupBoxProductC.Controls.Add(this.textBoxPNumber);
         this.groupBoxProductC.Controls.Add(this.labelamt);
         this.groupBoxProductC.Controls.Add(this.labelCPU);
         this.groupBoxProductC.Controls.Add(this.labelPNumber);
         this.groupBoxProductC.Controls.Add(this.labelPName);
         this.groupBoxProductC.Location = new System.Drawing.Point(12, 4);
         this.groupBoxProductC.Name = "groupBoxProductC";
         this.groupBoxProductC.Size = new System.Drawing.Size(281, 189);
         this.groupBoxProductC.TabIndex = 19;
         this.groupBoxProductC.TabStop = false;
         // 
         // textBoxamt
         // 
         this.textBoxamt.Location = new System.Drawing.Point(134, 156);
         this.textBoxamt.Name = "textBoxamt";
         this.textBoxamt.Size = new System.Drawing.Size(100, 22);
         this.textBoxamt.TabIndex = 7;
         // 
         // textBoxCPU
         // 
         this.textBoxCPU.Location = new System.Drawing.Point(134, 124);
         this.textBoxCPU.Name = "textBoxCPU";
         this.textBoxCPU.Size = new System.Drawing.Size(100, 22);
         this.textBoxCPU.TabIndex = 6;
         this.textBoxCPU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCPU_KeyDown);
         // 
         // textBoxPName
         // 
         this.textBoxPName.Location = new System.Drawing.Point(134, 86);
         this.textBoxPName.Name = "textBoxPName";
         this.textBoxPName.Size = new System.Drawing.Size(100, 22);
         this.textBoxPName.TabIndex = 5;
         this.textBoxPName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPName_KeyDown);
         // 
         // textBoxPNumber
         // 
         this.textBoxPNumber.Location = new System.Drawing.Point(134, 54);
         this.textBoxPNumber.Name = "textBoxPNumber";
         this.textBoxPNumber.Size = new System.Drawing.Size(100, 22);
         this.textBoxPNumber.TabIndex = 4;
         this.textBoxPNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPNumber_KeyDown);
         // 
         // labelamt
         // 
         this.labelamt.AutoSize = true;
         this.labelamt.Location = new System.Drawing.Point(8, 159);
         this.labelamt.Name = "labelamt";
         this.labelamt.Size = new System.Drawing.Size(102, 16);
         this.labelamt.TabIndex = 3;
         this.labelamt.Text = "Amount In Stock";
         // 
         // labelCPU
         // 
         this.labelCPU.AutoSize = true;
         this.labelCPU.Location = new System.Drawing.Point(8, 130);
         this.labelCPU.Name = "labelCPU";
         this.labelCPU.Size = new System.Drawing.Size(84, 16);
         this.labelCPU.TabIndex = 2;
         this.labelCPU.Text = "Cost Per Unit";
         // 
         // labelPNumber
         // 
         this.labelPNumber.AutoSize = true;
         this.labelPNumber.Location = new System.Drawing.Point(6, 57);
         this.labelPNumber.Name = "labelPNumber";
         this.labelPNumber.Size = new System.Drawing.Size(104, 16);
         this.labelPNumber.TabIndex = 1;
         this.labelPNumber.Text = "Product Number";
         // 
         // labelPName
         // 
         this.labelPName.AutoSize = true;
         this.labelPName.Location = new System.Drawing.Point(6, 89);
         this.labelPName.Name = "labelPName";
         this.labelPName.Size = new System.Drawing.Size(93, 16);
         this.labelPName.TabIndex = 0;
         this.labelPName.Text = "Product Name";
         // 
         // ProductForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1157, 695);
         this.Controls.Add(this.groupBoxProductC);
         this.Name = "ProductForm";
         this.Text = "ProductForm";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductForm_FormClosing);
         this.Load += new System.EventHandler(this.ProductForm_Load);
         this.Controls.SetChildIndex(this.textBoxShowProduct, 0);
         this.Controls.SetChildIndex(this.groupBoxCRUD, 0);
         this.Controls.SetChildIndex(this.buttonReturn, 0);
         this.Controls.SetChildIndex(this.buttonCEnter, 0);
         this.Controls.SetChildIndex(this.buttonREnter, 0);
         this.Controls.SetChildIndex(this.buttonUEnter, 0);
         this.Controls.SetChildIndex(this.buttonDEnter, 0);
         this.Controls.SetChildIndex(this.groupBoxProductC, 0);
         this.groupBoxCRUD.ResumeLayout(false);
         this.groupBoxProductC.ResumeLayout(false);
         this.groupBoxProductC.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBoxProductC;
      private System.Windows.Forms.Label labelamt;
      private System.Windows.Forms.Label labelCPU;
      private System.Windows.Forms.Label labelPNumber;
      private System.Windows.Forms.Label labelPName;
      private System.Windows.Forms.TextBox textBoxamt;
      private System.Windows.Forms.TextBox textBoxCPU;
      private System.Windows.Forms.TextBox textBoxPName;
      private System.Windows.Forms.TextBox textBoxPNumber;
   }
}