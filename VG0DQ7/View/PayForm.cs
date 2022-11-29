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
    public partial class PayForm : Form
    {
        int TotalTimeCost;
        int TotalMaterialCost;
        int NumberOfOrders;
        int NumberOfWorks;
        int TotalWorkTime;
        int TotalCost;
        
        public PayForm(List<Services> services)
        {
            TotalTimeCost = (from item in services select item.TotalWorkTimeCost).Sum();
            TotalMaterialCost = (from item in services select item.TotalMaterialCost).Sum();
            NumberOfOrders = services.Count;
            NumberOfWorks = (from item in services select item.TotalNumberOfWorks).Sum();
            TotalWorkTime = (from item in services select item.TotalTimeOfWork).Sum();
            TotalCost = TotalTimeCost + TotalMaterialCost;
            InitializeComponent();
            LabelSetter();
            services.Clear();

        }

        private void LabelSetter()
        {
            txt_CostOfMaterail.Text = TotalMaterialCost.ToString() + " Ft";
            txt_CostOfService.Text = TotalTimeCost.ToString() + " Ft";
            txt_NumberOfWorks.Text = NumberOfWorks.ToString() + " db";
            txt_NumberOfWorkSheets.Text = NumberOfOrders.ToString() + " db";
            txt_TimeOfWork.Text = $"{(TotalWorkTime >= 60 ? TotalWorkTime / 60 + "ó " + TotalWorkTime % 60 + "p" : TotalWorkTime % 60 + "p")}";
            txt_TotalCost.Text = TotalCost.ToString() + " Ft";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
