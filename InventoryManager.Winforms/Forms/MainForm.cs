using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using InventoryManager.Data;
using InventoryManager.Winforms.ViewModels;

namespace InventoryManager.Winforms
{
    public partial class MainForm : Form

    {
        private WorldViewModel ViewModel 
        {   
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    worldViewModelBindingSource.DataSource = mViewModel;
                }
            }
                
        }
        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
            }
        }

        private WorldViewModel mViewModel;

        private void itemsTabPage_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            using (AddPlayerForm addPlayerForm = new AddPlayerForm())
            {
                if(addPlayerForm.ShowDialog() == DialogResult.OK)
                {
                    Player player = new Player { Name = addPlayerForm.PlayerName };
                    //playersListBox.Items.Add();
                }
            }
        }

        private void playersTabPage_Click(object sender, EventArgs e)
        {

        }
    }
}
