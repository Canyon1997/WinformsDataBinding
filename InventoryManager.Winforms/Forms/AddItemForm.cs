using System.Windows.Forms;

namespace InventoryManager.WinForms.Forms
{
    public partial class AddItemForm : Form
    {
        public string ItemName
        {
            get => nameTextBox.Text;
            set => nameTextBox.Text = value;
        }

        public AddItemForm()
        {
            InitializeComponent();
        }

        private void NameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(ItemName);
        }

        private void AddItemForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}