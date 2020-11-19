using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager.Winforms
{
    public partial class AddPlayerForm : Form
    {
        public string PlayerName 
        {
            get => nameTextBox.Text;
            set => nameTextBox.Text = value;
        }

        public AddPlayerForm()
        {
            InitializeComponent();
        }

        private void AddPlayerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
