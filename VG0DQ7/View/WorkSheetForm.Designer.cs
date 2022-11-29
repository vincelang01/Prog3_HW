namespace VG0DQ7.View
{
    partial class WorkSheetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkSheetForm));
            this.WorkSheetTable = new System.Windows.Forms.TableLayoutPanel();
            this.btn_record = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TotalCostOfMaterial = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TotalTimeCost = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkSheetTable
            // 
            this.WorkSheetTable.AutoScroll = true;
            this.WorkSheetTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WorkSheetTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.WorkSheetTable.ColumnCount = 1;
            this.WorkSheetTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.WorkSheetTable.Location = new System.Drawing.Point(13, 42);
            this.WorkSheetTable.Name = "WorkSheetTable";
            this.WorkSheetTable.RowCount = 1;
            this.WorkSheetTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.WorkSheetTable.Size = new System.Drawing.Size(775, 333);
            this.WorkSheetTable.TabIndex = 0;
            // 
            // btn_record
            // 
            this.btn_record.Location = new System.Drawing.Point(594, 4);
            this.btn_record.Name = "btn_record";
            this.btn_record.Size = new System.Drawing.Size(128, 46);
            this.btn_record.TabIndex = 1;
            this.btn_record.Text = "Rögzítés";
            this.btn_record.UseVisualStyleBackColor = true;
            this.btn_record.Click += new System.EventHandler(this.btn_record_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anyagköltség:";
            // 
            // txt_TotalCostOfMaterial
            // 
            this.txt_TotalCostOfMaterial.AutoSize = true;
            this.txt_TotalCostOfMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalCostOfMaterial.ForeColor = System.Drawing.Color.Lime;
            this.txt_TotalCostOfMaterial.Location = new System.Drawing.Point(163, 16);
            this.txt_TotalCostOfMaterial.Name = "txt_TotalCostOfMaterial";
            this.txt_TotalCostOfMaterial.Size = new System.Drawing.Size(42, 20);
            this.txt_TotalCostOfMaterial.TabIndex = 2;
            this.txt_TotalCostOfMaterial.Text = "0 Ft";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Munkadíj:";
            // 
            // txt_TotalTimeCost
            // 
            this.txt_TotalTimeCost.AutoSize = true;
            this.txt_TotalTimeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalTimeCost.ForeColor = System.Drawing.Color.Red;
            this.txt_TotalTimeCost.Location = new System.Drawing.Point(403, 16);
            this.txt_TotalTimeCost.Name = "txt_TotalTimeCost";
            this.txt_TotalTimeCost.Size = new System.Drawing.Size(42, 20);
            this.txt_TotalTimeCost.TabIndex = 2;
            this.txt_TotalTimeCost.Text = "0 Ft";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_TotalTimeCost);
            this.panel1.Controls.Add(this.btn_record);
            this.panel1.Controls.Add(this.txt_TotalCostOfMaterial);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(32, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 57);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Anyagköltség";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Munkaidő";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Munkadíj";
            // 
            // WorkSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WorkSheetTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkSheetForm";
            this.Text = "WorkSheetForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkSheetForm_FormClosing);
            this.Load += new System.EventHandler(this.WorkSheetForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel WorkSheetTable;
        private System.Windows.Forms.Button btn_record;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_TotalCostOfMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_TotalTimeCost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}