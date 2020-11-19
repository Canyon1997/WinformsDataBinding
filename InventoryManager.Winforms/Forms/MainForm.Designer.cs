namespace InventoryManager.Winforms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fileLabel;
            this.selectFileButton = new System.Windows.Forms.Button();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.playersTabPage = new System.Windows.Forms.TabPage();
            this.playerScoreTextBox = new System.Windows.Forms.TextBox();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.playerHealthTextBox = new System.Windows.Forms.TextBox();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.deletePlayerButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.playersBidningSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            fileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.playersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBidningSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldBindingSource)).BeginInit();
            this.itemsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.Location = new System.Drawing.Point(12, 9);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new System.Drawing.Size(23, 13);
            fileLabel.TabIndex = 0;
            fileLabel.Text = "File";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(453, 4);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(33, 23);
            this.selectFileButton.TabIndex = 1;
            this.selectFileButton.Text = "...";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldViewModelBindingSource, "Filename", true));
            this.filenameTextBox.Location = new System.Drawing.Point(41, 5);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.ReadOnly = true;
            this.filenameTextBox.Size = new System.Drawing.Size(406, 20);
            this.filenameTextBox.TabIndex = 2;
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(InventoryManager.Winforms.ViewModels.WorldViewModel);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.playersTabPage);
            this.mainTabControl.Controls.Add(this.itemsTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(15, 31);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(471, 314);
            this.mainTabControl.TabIndex = 3;
            // 
            // playersTabPage
            // 
            this.playersTabPage.Controls.Add(this.playerScoreTextBox);
            this.playersTabPage.Controls.Add(this.playerScoreLabel);
            this.playersTabPage.Controls.Add(this.playerHealthTextBox);
            this.playersTabPage.Controls.Add(this.playerHealthLabel);
            this.playersTabPage.Controls.Add(this.playerNameTextBox);
            this.playersTabPage.Controls.Add(this.playerNameLabel);
            this.playersTabPage.Controls.Add(this.deletePlayerButton);
            this.playersTabPage.Controls.Add(this.addPlayerButton);
            this.playersTabPage.Controls.Add(this.playersListBox);
            this.playersTabPage.Location = new System.Drawing.Point(4, 22);
            this.playersTabPage.Name = "playersTabPage";
            this.playersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.playersTabPage.Size = new System.Drawing.Size(463, 288);
            this.playersTabPage.TabIndex = 0;
            this.playersTabPage.Text = "Players";
            this.playersTabPage.UseVisualStyleBackColor = true;
            this.playersTabPage.Click += new System.EventHandler(this.playersTabPage_Click);
            // 
            // playerScoreTextBox
            // 
            this.playerScoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBidningSource, "Score", true));
            this.playerScoreTextBox.Location = new System.Drawing.Point(168, 128);
            this.playerScoreTextBox.Name = "playerScoreTextBox";
            this.playerScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerScoreTextBox.TabIndex = 16;
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Location = new System.Drawing.Point(168, 112);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(35, 13);
            this.playerScoreLabel.TabIndex = 15;
            this.playerScoreLabel.Text = "Score";
            // 
            // playerHealthTextBox
            // 
            this.playerHealthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBidningSource, "Health", true));
            this.playerHealthTextBox.Location = new System.Drawing.Point(168, 78);
            this.playerHealthTextBox.Name = "playerHealthTextBox";
            this.playerHealthTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerHealthTextBox.TabIndex = 14;
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.Location = new System.Drawing.Point(168, 62);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(38, 13);
            this.playerHealthLabel.TabIndex = 13;
            this.playerHealthLabel.Text = "Health";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBidningSource, "Name", true));
            this.playerNameTextBox.Location = new System.Drawing.Point(168, 28);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.playerNameTextBox.TabIndex = 12;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(168, 12);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(35, 13);
            this.playerNameLabel.TabIndex = 11;
            this.playerNameLabel.Text = "Name";
            // 
            // deletePlayerButton
            // 
            this.deletePlayerButton.Location = new System.Drawing.Point(87, 257);
            this.deletePlayerButton.Name = "deletePlayerButton";
            this.deletePlayerButton.Size = new System.Drawing.Size(75, 23);
            this.deletePlayerButton.TabIndex = 2;
            this.deletePlayerButton.Text = "&Delete";
            this.deletePlayerButton.UseVisualStyleBackColor = true;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(6, 257);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.addPlayerButton.TabIndex = 1;
            this.addPlayerButton.Text = "&Add";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // playersListBox
            // 
            this.playersListBox.DataSource = this.playersBidningSource;
            this.playersListBox.DisplayMember = "Name";
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.Location = new System.Drawing.Point(0, 0);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(162, 251);
            this.playersListBox.TabIndex = 0;
            // 
            // playersBidningSource
            // 
            this.playersBidningSource.DataMember = "Players";
            this.playersBidningSource.DataSource = this.worldBindingSource;
            // 
            // worldBindingSource
            // 
            this.worldBindingSource.DataMember = "World";
            this.worldBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.button1);
            this.itemsTabPage.Controls.Add(this.button2);
            this.itemsTabPage.Controls.Add(this.itemsListBox);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTabPage.Size = new System.Drawing.Size(463, 288);
            this.itemsTabPage.TabIndex = 1;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            this.itemsTabPage.Click += new System.EventHandler(this.itemsTabPage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // itemsListBox
            // 
            this.itemsListBox.DataSource = this.itemsBindingSource;
            this.itemsListBox.DisplayMember = "Name";
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(0, 0);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(164, 251);
            this.itemsListBox.TabIndex = 0;
            this.itemsListBox.ValueMember = "Name";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.worldBindingSource;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 357);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(fileLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Inventory Manager";
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.playersTabPage.ResumeLayout(false);
            this.playersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBidningSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldBindingSource)).EndInit();
            this.itemsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage playersTabPage;
        private System.Windows.Forms.Button deletePlayerButton;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.TextBox playerScoreTextBox;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.TextBox playerHealthTextBox;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.BindingSource worldBindingSource;
        private System.Windows.Forms.BindingSource playersBidningSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
    }
}

