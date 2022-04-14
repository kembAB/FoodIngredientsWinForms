namespace AssignmentFive
{
     partial class FormMain

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
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.grpAddNewRecipe = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddIngredients = new System.Windows.Forms.Button();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNameofRecipe = new System.Windows.Forms.Label();
            this.lstRecipe = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpAddNewRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddRecipe.Location = new System.Drawing.Point(6, 337);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(339, 23);
            this.btnAddRecipe.TabIndex = 0;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // grpAddNewRecipe
            // 
            this.grpAddNewRecipe.Controls.Add(this.txtDescription);
            this.grpAddNewRecipe.Controls.Add(this.btnAddIngredients);
            this.grpAddNewRecipe.Controls.Add(this.cmbCatagory);
            this.grpAddNewRecipe.Controls.Add(this.txtName);
            this.grpAddNewRecipe.Controls.Add(this.label2);
            this.grpAddNewRecipe.Controls.Add(this.lblNameofRecipe);
            this.grpAddNewRecipe.Location = new System.Drawing.Point(0, 0);
            this.grpAddNewRecipe.Name = "grpAddNewRecipe";
            this.grpAddNewRecipe.Size = new System.Drawing.Size(345, 321);
            this.grpAddNewRecipe.TabIndex = 1;
            this.grpAddNewRecipe.TabStop = false;
            this.grpAddNewRecipe.Text = "Add new recipe";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 87);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(302, 214);
            this.txtDescription.TabIndex = 7;
            // 
            // btnAddIngredients
            // 
            this.btnAddIngredients.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddIngredients.Location = new System.Drawing.Point(226, 58);
            this.btnAddIngredients.Name = "btnAddIngredients";
            this.btnAddIngredients.Size = new System.Drawing.Size(100, 23);
            this.btnAddIngredients.TabIndex = 6;
            this.btnAddIngredients.Text = "Add Ingredients";
            this.btnAddIngredients.UseVisualStyleBackColor = true;
            this.btnAddIngredients.Click += new System.EventHandler(this.btnAddIngredients_Click);
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatagory.FormattingEnabled = true;
            this.cmbCatagory.Location = new System.Drawing.Point(86, 60);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(121, 21);
            this.cmbCatagory.TabIndex = 5;
            this.cmbCatagory.SelectedIndexChanged += new System.EventHandler(this.cmbCatagory_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
         //   this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Catagory";
            // 
            // lblNameofRecipe
            // 
            this.lblNameofRecipe.AutoSize = true;
            this.lblNameofRecipe.Location = new System.Drawing.Point(6, 33);
            this.lblNameofRecipe.Name = "lblNameofRecipe";
            this.lblNameofRecipe.Size = new System.Drawing.Size(84, 13);
            this.lblNameofRecipe.TabIndex = 2;
            this.lblNameofRecipe.Text = "Name of Recipe";
            // 
            // lstRecipe
            // 
            this.lstRecipe.FormattingEnabled = true;
            this.lstRecipe.Location = new System.Drawing.Point(369, 30);
            this.lstRecipe.Name = "lstRecipe";
            this.lstRecipe.Size = new System.Drawing.Size(310, 264);
            this.lstRecipe.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "No. of Ingrediets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Catagory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Description";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(744, 30);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 13);
            this.lblDescription.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 372);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstRecipe);
            this.Controls.Add(this.grpAddNewRecipe);
            this.Controls.Add(this.btnAddRecipe);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.grpAddNewRecipe.ResumeLayout(false);
            this.grpAddNewRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.GroupBox grpAddNewRecipe;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddIngredients;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNameofRecipe;
        private System.Windows.Forms.ListBox lstRecipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

