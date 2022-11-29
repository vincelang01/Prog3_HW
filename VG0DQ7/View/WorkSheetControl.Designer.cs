namespace VG0DQ7.View
{
    partial class WorkSheetControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_workName = new System.Windows.Forms.Label();
            this.txt_materialCost = new System.Windows.Forms.Label();
            this.txt_workTime = new System.Windows.Forms.Label();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.txt_CostOfTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_workName
            // 
            this.txt_workName.AutoSize = true;
            this.txt_workName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_workName.Location = new System.Drawing.Point(3, 21);
            this.txt_workName.Name = "txt_workName";
            this.txt_workName.Size = new System.Drawing.Size(108, 21);
            this.txt_workName.TabIndex = 0;
            this.txt_workName.Text = "NameOfWork";
            // 
            // txt_materialCost
            // 
            this.txt_materialCost.AutoSize = true;
            this.txt_materialCost.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_materialCost.Location = new System.Drawing.Point(251, 21);
            this.txt_materialCost.Name = "txt_materialCost";
            this.txt_materialCost.Size = new System.Drawing.Size(103, 21);
            this.txt_materialCost.TabIndex = 0;
            this.txt_materialCost.Text = "MaterialCost";
            // 
            // txt_workTime
            // 
            this.txt_workTime.AutoSize = true;
            this.txt_workTime.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_workTime.Location = new System.Drawing.Point(408, 21);
            this.txt_workTime.Name = "txt_workTime";
            this.txt_workTime.Size = new System.Drawing.Size(90, 21);
            this.txt_workTime.TabIndex = 0;
            this.txt_workTime.Text = "Work Time";
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Location = new System.Drawing.Point(551, 26);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(18, 17);
            this.CheckBox.TabIndex = 1;
            this.CheckBox.UseVisualStyleBackColor = true;
            this.CheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // txt_CostOfTime
            // 
            this.txt_CostOfTime.AutoSize = true;
            this.txt_CostOfTime.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CostOfTime.Location = new System.Drawing.Point(638, 21);
            this.txt_CostOfTime.Name = "txt_CostOfTime";
            this.txt_CostOfTime.Size = new System.Drawing.Size(85, 21);
            this.txt_CostOfTime.TabIndex = 0;
            this.txt_CostOfTime.Text = "Time Cost";
            // 
            // WorkSheetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_CostOfTime);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.txt_workTime);
            this.Controls.Add(this.txt_materialCost);
            this.Controls.Add(this.txt_workName);
            this.Name = "WorkSheetControl";
            this.Size = new System.Drawing.Size(737, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_workName;
        private System.Windows.Forms.Label txt_materialCost;
        private System.Windows.Forms.Label txt_workTime;
        private System.Windows.Forms.CheckBox CheckBox;
        private System.Windows.Forms.Label txt_CostOfTime;
    }
}
