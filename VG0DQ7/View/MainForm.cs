using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VG0DQ7.Model;

namespace VG0DQ7.View
{
    public partial class MainForm : Form
    {
        WorkStorage workStorage;

        public static List<Services> ServiceOrdered { get; private set; }

        public MainForm()
        {
            workStorage = new WorkStorage();
            ServiceOrdered = new List<Services>();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            munkalapToolStripMenuItem.Enabled = false;
            fizetésToolStripMenuItem.Enabled = false;
            WindowState = FormWindowState.Maximized;

        }

        private void fájlBetöltésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OfD = new OpenFileDialog
            {
                Multiselect = false,
                InitialDirectory = Application.StartupPath
            };

            if(OfD.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    workStorage.AddWorks(new Loader<Work>().LoadFromFile(OfD.FileName, Parser.Parse));

                    munkalapToolStripMenuItem.Enabled = true;
                }
                catch(IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                catch(IndexOutOfRangeException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                catch(NullReferenceException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan be akarod zárni az alkalmazást?", "Figyelmeztetés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void munkalapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WorkSheetForm(workStorage).ShowDialog();
            if(ServiceOrdered.Count > 0) { fizetésToolStripMenuItem.Enabled = true; }
        }

        private void névjegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fizetésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Biztosan szeretne fizetni?", "Fizetés megerősítése", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                new PayForm(ServiceOrdered).ShowDialog();
                fizetésToolStripMenuItem.Enabled = false;
            }
        }
    }
}
