using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VG0DQ7.Model;

namespace VG0DQ7.View
{
    public partial class WorkSheetForm : Form
    {
        bool recordClose = false;
        WorkStorage works;
        Services ServiceOrders;
        Dictionary<CheckBox, Work> ServiceOptions;
        
        public WorkSheetForm(WorkStorage workFromFile)
        {
            works = workFromFile;
            ServiceOrders = new Services();
            ServiceOptions = new Dictionary<CheckBox, Work>();
            InitializeComponent();
            Filltable();
        }

        private void Filltable()
        {
            WorkSheetTable.RowStyles.Clear();
            WorkSheetTable.RowCount = ServiceOptions.Count;
            //ha nem row count akkor WorkSheetTable.RowStyles.Count
            for(int i = 0; i < WorkSheetTable.RowCount; i++)
            {
                WorkSheetTable.RowStyles[i].SizeType = SizeType.Absolute;
                WorkSheetTable.RowStyles[i].Height = 50;
                
            }

            WorkSheetTable.Refresh();

            int row = 0;

            for(int i = 0; i < works.Count(); i++)
            {
                var work = new WorkSheetControl(works[i]);
                work.SelectionChanged += CheckBox_Changed;
                WorkSheetTable.Controls.Add(work, 0, row++);
            }

        }

        private void CheckBox_Changed(WorkSheetControl work, bool isChecked)
        {
            if (isChecked)
            {
                ServiceOrders.AddItem(work.Work);
                txt_TotalTimeCost.Text = ServiceOrders.TotalWorkTimeCost.ToString() + "Ft";
                txt_TotalCostOfMaterial.Text = ServiceOrders.TotalMaterialCost.ToString() + "Ft";
            }
            else
            {
                ServiceOrders.RemoveItem(work.Work);
                txt_TotalTimeCost.Text = ServiceOrders.TotalWorkTimeCost.ToString() + "Ft";
                txt_TotalCostOfMaterial.Text = ServiceOrders.TotalMaterialCost.ToString() + "Ft";
            }
        }

        private void WorkSheetForm_Load(object sender, EventArgs e)
        {

        }

        private void WorkSheetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!recordClose)
            {
                if (MessageBox.Show("Biztosan be szeretné zárni az ablakot?\nMinden nem elmentett változtatás elveszik!", "Figyelmeztetés", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                }
                else
                {
                    e.Cancel = true;
                }
            }
            recordClose = false;
        }

        private void btn_record_Click(object sender, EventArgs e)
        {
            if (!recordClose)
            {
                if (ServiceOrders.TotalNumberOfWorks > 0 && MessageBox.Show("Rögzíti a munkalapot?", "Figyelem!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MainForm.ServiceOrdered.Add(ServiceOrders);
                    recordClose = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Nincs feljegyzett munka!\nRögzítéshez jelöljön be munkát!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
