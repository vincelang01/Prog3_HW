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
    public partial class WorkSheetControl : UserControl
    {
        public Work Work { get; private set; }

        public delegate void SelectionChangedHandler(WorkSheetControl sender, bool isChecked);

        public WorkSheetControl(Work work)
        {
            InitializeComponent();
            txt_workName.Text = work.Name;
            txt_materialCost.Text = work.MaterialCost.ToString();
            CheckBox.Checked = false;
            txt_workTime.Text = work.TimeOfWork;
            txt_CostOfTime.Text = work.CostOfTime.ToString() + " Ft";
            txt_CostOfTime.Visible = false;
            Work = work;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //When checkbox checked Work fee will be visible
            if (CheckBox.Checked)
            {
                txt_CostOfTime.Visible = true;
            }
            else
            {
                txt_CostOfTime.Visible = false;
            }

            SelectionChanged?.Invoke(this, CheckBox.Checked);
        }

        public event SelectionChangedHandler SelectionChanged;
    }
}
