namespace ADONetDemo
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.IdLable = new System.Windows.Forms.Label();
            this.DesignLable = new System.Windows.Forms.Label();
            this.NameLable = new System.Windows.Forms.Label();
            this.Salarylabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(312, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(453, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(151, 370);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(101, 23);
            this.btnAddNew.TabIndex = 23;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(577, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(577, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(331, 58);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(164, 22);
            this.txtId.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(331, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 22);
            this.txtName.TabIndex = 19;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(331, 199);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(164, 22);
            this.txtDesignation.TabIndex = 18;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(331, 275);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(164, 22);
            this.txtSalary.TabIndex = 17;
            // 
            // IdLable
            // 
            this.IdLable.AutoSize = true;
            this.IdLable.Location = new System.Drawing.Point(148, 64);
            this.IdLable.Name = "IdLable";
            this.IdLable.Size = new System.Drawing.Size(18, 16);
            this.IdLable.TabIndex = 16;
            this.IdLable.Text = "Id";
            // 
            // DesignLable
            // 
            this.DesignLable.AutoSize = true;
            this.DesignLable.Location = new System.Drawing.Point(148, 202);
            this.DesignLable.Name = "DesignLable";
            this.DesignLable.Size = new System.Drawing.Size(79, 16);
            this.DesignLable.TabIndex = 15;
            this.DesignLable.Text = "Designation";
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Location = new System.Drawing.Point(148, 127);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(44, 16);
            this.NameLable.TabIndex = 14;
            this.NameLable.Text = "Name";
            // 
            // Salarylabel
            // 
            this.Salarylabel.AutoSize = true;
            this.Salarylabel.Location = new System.Drawing.Point(148, 281);
            this.Salarylabel.Name = "Salarylabel";
            this.Salarylabel.Size = new System.Drawing.Size(46, 16);
            this.Salarylabel.TabIndex = 13;
            this.Salarylabel.Text = "Salary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.IdLable);
            this.Controls.Add(this.DesignLable);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.Salarylabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label IdLable;
        private System.Windows.Forms.Label DesignLable;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.Label Salarylabel;
    }
}

