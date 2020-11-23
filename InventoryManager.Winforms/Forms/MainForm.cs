using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using InventoryManager.Data;
using InventoryManager.WinForms.ViewModels;

namespace InventoryManager.WinForms.Forms
{
    public partial class MainForm : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

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

        private bool IsWorldLoaded
        {
            get => mIsWorldLoaded;
            set
            {
                mIsWorldLoaded = value;
                mainTabControl.Enabled = mIsWorldLoaded;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
            IsWorldLoaded = false;
        }

        private void AddPlayerButton_Click(object sender, System.EventArgs e)
        {
            using (AddPlayerForm addPlayerForm = new AddPlayerForm())
            {
                if (addPlayerForm.ShowDialog() == DialogResult.OK)
                {
                    Player player = new Player { Name = addPlayerForm.PlayerName };
                    ViewModel.Players.Add(player);
                }
            }
        }

        private void PlayersListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            deletePlayerButton.Enabled = playersListBox.SelectedItem != null;
        }

        private void DeletePlayerButton_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Delete this player?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Players.Remove((Player)playersListBox.SelectedItem);
                playersListBox.SelectedItem = ViewModel.Players.FirstOrDefault();
            }
        }

        #region Main Menu
        private void OpenWorldToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
                IsWorldLoaded = true;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, System.EventArgs e) => ViewModel.SaveWorld();

        private void SaveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveFileDialog.FileName;
                ViewModel.SaveWorld();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e) => Close();

        private void NewWorldToolStripMenuItem_Click(object sender, EventArgs e) => ShowNotYetImplementedMessageBox();

        private void CloseWorldToolStripMenuItem_Click(object sender, EventArgs e) => ShowNotYetImplementedMessageBox();

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) => ShowNotYetImplementedMessageBox();
        #endregion Main Menu

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            using (AddItemForm addItemForm = new AddItemForm())
            {
                if (addItemForm.ShowDialog() == DialogResult.OK)
                {
                    Item item = new Item { Name = addItemForm.ItemName };
                    ViewModel.Items.Add(item);
                }
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e) => deleteItemButton.Enabled = itemsListBox.SelectedItem != null;

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this item?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.RemoveItem((Item)itemsListBox.SelectedItem);
                itemsListBox.SelectedItem = ViewModel.Items.FirstOrDefault();

                //TODO: refresh selected player (which may have a stale reference to the deleted item)
            }
        }

        private void AddItemToInventoryButton_Click(object sender, EventArgs e) => ShowNotYetImplementedMessageBox();

        private void RemoveItemFromInventoryButton_Click(object sender, EventArgs e) => ShowNotYetImplementedMessageBox();

        private void ShowNotYetImplementedMessageBox() => MessageBox.Show("Not yet implemented.", AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        private WorldViewModel mViewModel;
        private bool mIsWorldLoaded;

        private void playersTabPage_Click(object sender, EventArgs e)
        {

        }
    }
}