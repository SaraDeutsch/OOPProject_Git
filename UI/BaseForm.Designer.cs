namespace UI
{
   partial class BaseForm
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
         this.buttonDelete = new System.Windows.Forms.Button();
         this.buttonUpdate = new System.Windows.Forms.Button();
         this.buttonReadAll = new System.Windows.Forms.Button();
         this.buttonRead = new System.Windows.Forms.Button();
         this.buttonCreate = new System.Windows.Forms.Button();
         this.textBoxShowProduct = new System.Windows.Forms.TextBox();
         this.groupBoxCRUD = new System.Windows.Forms.GroupBox();
         this.buttonReturn = new System.Windows.Forms.Button();
         this.buttonDEnter = new System.Windows.Forms.Button();
         this.buttonUEnter = new System.Windows.Forms.Button();
         this.buttonREnter = new System.Windows.Forms.Button();
         this.buttonCEnter = new System.Windows.Forms.Button();
         this.buttonMainMenu = new System.Windows.Forms.Button();
         this.groupBoxCRUD.SuspendLayout();
         this.SuspendLayout();
         // 
         // buttonDelete
         // 
         this.buttonDelete.Location = new System.Drawing.Point(60, 168);
         this.buttonDelete.Name = "buttonDelete";
         this.buttonDelete.Size = new System.Drawing.Size(75, 23);
         this.buttonDelete.TabIndex = 9;
         this.buttonDelete.Text = "Remove";
         this.buttonDelete.UseVisualStyleBackColor = true;
         this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
         // 
         // buttonUpdate
         // 
         this.buttonUpdate.Location = new System.Drawing.Point(60, 139);
         this.buttonUpdate.Name = "buttonUpdate";
         this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
         this.buttonUpdate.TabIndex = 8;
         this.buttonUpdate.Text = "Modify";
         this.buttonUpdate.UseVisualStyleBackColor = true;
         this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
         // 
         // buttonReadAll
         // 
         this.buttonReadAll.Location = new System.Drawing.Point(60, 90);
         this.buttonReadAll.Name = "buttonReadAll";
         this.buttonReadAll.Size = new System.Drawing.Size(75, 23);
         this.buttonReadAll.TabIndex = 7;
         this.buttonReadAll.Text = "Show All";
         this.buttonReadAll.UseVisualStyleBackColor = true;
         this.buttonReadAll.Click += new System.EventHandler(this.buttonReadAll_Click);
         // 
         // buttonRead
         // 
         this.buttonRead.Location = new System.Drawing.Point(60, 61);
         this.buttonRead.Name = "buttonRead";
         this.buttonRead.Size = new System.Drawing.Size(75, 23);
         this.buttonRead.TabIndex = 6;
         this.buttonRead.Text = "Show";
         this.buttonRead.UseVisualStyleBackColor = true;
         this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
         // 
         // buttonCreate
         // 
         this.buttonCreate.Location = new System.Drawing.Point(60, 12);
         this.buttonCreate.Name = "buttonCreate";
         this.buttonCreate.Size = new System.Drawing.Size(75, 23);
         this.buttonCreate.TabIndex = 5;
         this.buttonCreate.Text = "New";
         this.buttonCreate.UseVisualStyleBackColor = true;
         this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
         // 
         // textBoxShowProduct
         // 
         this.textBoxShowProduct.Location = new System.Drawing.Point(368, 12);
         this.textBoxShowProduct.Multiline = true;
         this.textBoxShowProduct.Name = "textBoxShowProduct";
         this.textBoxShowProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.textBoxShowProduct.Size = new System.Drawing.Size(512, 568);
         this.textBoxShowProduct.TabIndex = 16;
         // 
         // groupBoxCRUD
         // 
         this.groupBoxCRUD.Controls.Add(this.buttonCreate);
         this.groupBoxCRUD.Controls.Add(this.buttonRead);
         this.groupBoxCRUD.Controls.Add(this.buttonDelete);
         this.groupBoxCRUD.Controls.Add(this.buttonReadAll);
         this.groupBoxCRUD.Controls.Add(this.buttonUpdate);
         this.groupBoxCRUD.Location = new System.Drawing.Point(954, 338);
         this.groupBoxCRUD.Name = "groupBoxCRUD";
         this.groupBoxCRUD.Size = new System.Drawing.Size(141, 306);
         this.groupBoxCRUD.TabIndex = 17;
         this.groupBoxCRUD.TabStop = false;
         // 
         // buttonReturn
         // 
         this.buttonReturn.Location = new System.Drawing.Point(778, 597);
         this.buttonReturn.Name = "buttonReturn";
         this.buttonReturn.Size = new System.Drawing.Size(102, 33);
         this.buttonReturn.TabIndex = 15;
         this.buttonReturn.Text = "Back";
         this.buttonReturn.UseVisualStyleBackColor = true;
         this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
         // 
         // buttonDEnter
         // 
         this.buttonDEnter.Location = new System.Drawing.Point(196, 339);
         this.buttonDEnter.Name = "buttonDEnter";
         this.buttonDEnter.Size = new System.Drawing.Size(100, 23);
         this.buttonDEnter.TabIndex = 26;
         this.buttonDEnter.Text = "Enter";
         this.buttonDEnter.UseVisualStyleBackColor = true;
         this.buttonDEnter.Click += new System.EventHandler(this.buttonDEnter_Click);
         // 
         // buttonUEnter
         // 
         this.buttonUEnter.Location = new System.Drawing.Point(196, 338);
         this.buttonUEnter.Name = "buttonUEnter";
         this.buttonUEnter.Size = new System.Drawing.Size(100, 23);
         this.buttonUEnter.TabIndex = 25;
         this.buttonUEnter.Text = "Enter";
         this.buttonUEnter.UseVisualStyleBackColor = true;
         this.buttonUEnter.Click += new System.EventHandler(this.buttonUEnter_Click);
         // 
         // buttonREnter
         // 
         this.buttonREnter.Location = new System.Drawing.Point(196, 339);
         this.buttonREnter.Name = "buttonREnter";
         this.buttonREnter.Size = new System.Drawing.Size(100, 23);
         this.buttonREnter.TabIndex = 24;
         this.buttonREnter.Text = "Enter";
         this.buttonREnter.UseVisualStyleBackColor = true;
         this.buttonREnter.Click += new System.EventHandler(this.buttonREnter_Click);
         // 
         // buttonCEnter
         // 
         this.buttonCEnter.Location = new System.Drawing.Point(196, 339);
         this.buttonCEnter.Name = "buttonCEnter";
         this.buttonCEnter.Size = new System.Drawing.Size(100, 23);
         this.buttonCEnter.TabIndex = 23;
         this.buttonCEnter.Text = "Enter";
         this.buttonCEnter.UseVisualStyleBackColor = true;
         this.buttonCEnter.Click += new System.EventHandler(this.buttonCEnter_Click_1);
         // 
         // buttonMainMenu
         // 
         this.buttonMainMenu.Location = new System.Drawing.Point(638, 597);
         this.buttonMainMenu.Name = "buttonMainMenu";
         this.buttonMainMenu.Size = new System.Drawing.Size(120, 33);
         this.buttonMainMenu.TabIndex = 10;
         this.buttonMainMenu.Text = "Main Menu";
         this.buttonMainMenu.UseVisualStyleBackColor = true;
         this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
         // 
         // BaseForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1107, 656);
         this.Controls.Add(this.buttonMainMenu);
         this.Controls.Add(this.buttonDEnter);
         this.Controls.Add(this.buttonUEnter);
         this.Controls.Add(this.buttonREnter);
         this.Controls.Add(this.buttonCEnter);
         this.Controls.Add(this.buttonReturn);
         this.Controls.Add(this.groupBoxCRUD);
         this.Controls.Add(this.textBoxShowProduct);
         this.Name = "BaseForm";
         this.Text = "BaseForm";
         this.groupBoxCRUD.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      protected System.Windows.Forms.Button buttonDelete;
      protected System.Windows.Forms.Button buttonUpdate;
      protected System.Windows.Forms.Button buttonReadAll;
      protected System.Windows.Forms.Button buttonRead;
      protected System.Windows.Forms.Button buttonCreate;
      protected System.Windows.Forms.TextBox textBoxShowProduct;
      protected System.Windows.Forms.GroupBox groupBoxCRUD;
      protected System.Windows.Forms.Button buttonReturn;
      protected System.Windows.Forms.Button buttonDEnter;
      protected System.Windows.Forms.Button buttonUEnter;
      protected System.Windows.Forms.Button buttonREnter;
      protected System.Windows.Forms.Button buttonCEnter;
      private System.Windows.Forms.Button buttonMainMenu;
   }
}