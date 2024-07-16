namespace UI
{
   partial class MainForm
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
         this.buttonCustomers = new System.Windows.Forms.Button();
         this.buttonProducts = new System.Windows.Forms.Button();
         this.buttonOrders = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // buttonCustomers
         // 
         this.buttonCustomers.Location = new System.Drawing.Point(297, 114);
         this.buttonCustomers.Name = "buttonCustomers";
         this.buttonCustomers.Size = new System.Drawing.Size(228, 123);
         this.buttonCustomers.TabIndex = 0;
         this.buttonCustomers.Text = "Customers";
         this.buttonCustomers.UseVisualStyleBackColor = true;
         this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
         // 
         // buttonProducts
         // 
         this.buttonProducts.Location = new System.Drawing.Point(553, 114);
         this.buttonProducts.Name = "buttonProducts";
         this.buttonProducts.Size = new System.Drawing.Size(226, 123);
         this.buttonProducts.TabIndex = 1;
         this.buttonProducts.Text = "Products";
         this.buttonProducts.UseVisualStyleBackColor = true;
         this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
         // 
         // buttonOrders
         // 
         this.buttonOrders.Location = new System.Drawing.Point(41, 114);
         this.buttonOrders.Name = "buttonOrders";
         this.buttonOrders.Size = new System.Drawing.Size(228, 123);
         this.buttonOrders.TabIndex = 2;
         this.buttonOrders.Text = "Orders";
         this.buttonOrders.UseVisualStyleBackColor = true;
         this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.buttonOrders);
         this.Controls.Add(this.buttonProducts);
         this.Controls.Add(this.buttonCustomers);
         this.Name = "MainForm";
         this.Text = "Main Form";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button buttonCustomers;
      private System.Windows.Forms.Button buttonProducts;
      private System.Windows.Forms.Button buttonOrders;
   }
}