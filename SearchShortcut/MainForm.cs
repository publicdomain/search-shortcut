// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace SearchShortcut
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Microsoft.VisualBasic;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SearchShortcut.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the search term add button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSearchTermAddButtonClick(object sender, EventArgs e)
        {
            // Prevent painting
            this.searchTermsCheckedListBox.BeginUpdate();

            // Split by comma adnd trim
            foreach (var term in this.searchTermTextBox.Text.Split(',').Select(x => x.Trim()).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray())
            {
                // Check for a previous one
                if (!this.searchTermsCheckedListBox.Items.Contains(term))
                {
                    // Add to checked list
                    this.searchTermsCheckedListBox.Items.Add(term);
                }

                // Should it be checked on add?
                if (this.checkOnAddToolStripMenuItem.Checked)
                {
                    // Check item (current or previous)
                    this.searchTermsCheckedListBox.SetItemChecked(this.searchTermsCheckedListBox.Items.IndexOf(term), true);
                }
            }

            // Resume painting
            this.searchTermsCheckedListBox.EndUpdate();

            // Clear text box
            this.searchTermTextBox.Clear();

            // Focus text box
            this.searchTermTextBox.Focus();
        }

        /// <summary>
        /// Handles the search engines add button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSearchEnginesAddButtonClick(object sender, EventArgs e)
        {
            // Prevent painting
            this.searchEnginesCheckedListBox.BeginUpdate();

            // Split by comma adnd trim
            foreach (var engine in this.searchEnginesTextBox.Text.Split(',').Select(x => x.Trim()).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray())
            {
                // First check it's well formed
                if (!Uri.IsWellFormedUriString(engine, UriKind.Absolute))
                {
                    // Skip engine
                    continue;
                }

                // Check for a previous one
                if (!this.searchEnginesCheckedListBox.Items.Contains(engine))
                {
                    // Add to checked list
                    this.searchEnginesCheckedListBox.Items.Add(engine);
                }

                // Should it be checked on add
                if (this.checkOnAddToolStripMenuItem.Checked)
                {
                    // Check item (current or previous)
                    this.searchEnginesCheckedListBox.SetItemChecked(this.searchEnginesCheckedListBox.Items.IndexOf(engine), true);
                }
            }

            // Resume painting
            this.searchEnginesCheckedListBox.EndUpdate();

            // Clear text box
            this.searchEnginesTextBox.Clear();

            // Focus text box
            this.searchEnginesTextBox.Focus();
        }

        /// <summary>
        /// Handles the perform search button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnPerformSearchButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the search term checked list box preview key down.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSearchTermCheckedListBoxPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Check for delete
            if (e.KeyCode == Keys.Delete)
            {
                // Remove selected terms
                this.RemoveSelectedItems(this.searchTermsCheckedListBox);
            }
        }

        /// <summary>
        /// Handles the search engines checked list box preview key down.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSearchEnginesCheckedListBoxPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Check for delete
            if (e.KeyCode == Keys.Delete)
            {
                // Remove selected engines
                this.RemoveSelectedItems(this.searchEnginesCheckedListBox);
            }
        }

        /// <summary>
        /// Removes the selected items.
        /// </summary>
        /// <param name="checkedListBox">Checked list box.</param>
        private void RemoveSelectedItems(CheckedListBox checkedListBox)
        {
            // Iterate
            while (checkedListBox.SelectedItems.Count > 0)
            {
                // Remove selected
                checkedListBox.Items.Remove(checkedListBox.SelectedItems[0]);
            }
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Clear search terms list
            this.searchTermsCheckedListBox.Items.Clear();

            // Focus search terms text box
            this.searchTermTextBox.Focus();
        }

        /// <summary>
        /// Handles the open tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the save tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the set new keyword tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSetNewKeywordToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

            // Set topmost by check box
            this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code 
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the search term text box key down.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSearchTermTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            // Check for enter
            if (e.KeyCode == Keys.Enter)
            {
                // Press the add button
                this.searchTermAddButton.PerformClick();
            }
        }

        /// <summary>
        /// Handles the search engines text box key down.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSearchEnginesTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            // Check for enter
            if (e.KeyCode == Keys.Enter)
            {
                // Press the add button
                this.searchEnginesAddButton.PerformClick();
            }
        }

        /// <summary>
        /// Handles the main form load.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormLoad(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the main form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO Add code 
        }

        /// <summary>
        /// Handles the search term checked list box item check.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSearchTermCheckedListBoxItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Update checked terms
            this.termsToolStripStatusLabel.Text = $"{this.searchTermsCheckedListBox.CheckedItems.Count + (e.NewValue == CheckState.Checked ? 1 : -1)}";
        }

        /// <summary>
        /// Handles the search engines checked list box item check.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSearchEnginesCheckedListBoxItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Update checked terms
            this.enginesToolStripStatusLabel.Text = $"{this.searchEnginesCheckedListBox.CheckedItems.Count + (e.NewValue == CheckState.Checked ? 1 : -1)}";
        }

        /// <summary>
        /// Handles the checked list box context menu strip item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCheckedListBoxContextMenuStripItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Determine checked list box
            CheckedListBox checkedListBox = ((CheckedListBox)((ContextMenuStrip)sender).SourceControl);

            switch (e.ClickedItem.Name)
            {
                // Delete
                case "deleteToolStripMenuItem":

                    // Remove selected
                    this.RemoveSelectedItems(checkedListBox);

                    break;

                // Edit
                case "editToolStripMenuItem":

                    // Check there's something to work with
                    if (checkedListBox.SelectedItems.Count > 0)
                    {
                        // Collect item text from user
                        string itemText = Interaction.InputBox("Set new item", "Edit", checkedListBox.SelectedItem.ToString());

                        // Check it's not empty and different 
                        if (itemText.Length > 0 && itemText != checkedListBox.SelectedItem.ToString())
                        {
                            // TODO Check if it's meant to be an URI [Can be improved]
                            if (checkedListBox.Name == "searchEnginesCheckedListBox")
                            {
                                // Test for a well-formed URI-
                                if (!Uri.IsWellFormedUriString(itemText, UriKind.Absolute))
                                {
                                    // Halt flow
                                    break;
                                }
                            }

                            // Edit item
                            checkedListBox.Items[checkedListBox.SelectedIndices[0]] = itemText;
                        }
                    }

                    break;

                // Clear
                case "clearToolStripMenuItem":

                    // Check if must ask
                    if (this.askOnClearToolStripMenuItem.Checked && MessageBox.Show($"Clear {(checkedListBox.Name.Contains("Terms") ? "terms" : "engines")} list?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        // Halt flow
                        break;
                    }

                    // Clear list box items
                    checkedListBox.Items.Clear();

                    break;
            }
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program        
            this.Close();
        }
    }
}
