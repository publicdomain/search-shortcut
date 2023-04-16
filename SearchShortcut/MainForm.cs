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
            this.searchTermCheckedListBox.BeginUpdate();

            // Split by comma adnd trim
            foreach (var term in this.searchTermTextBox.Text.Split(',').Select(x => x.Trim()).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray())
            {
                // Check for a previous one
                if (!this.searchTermCheckedListBox.Items.Contains(term))
                {
                    // Add to checked list
                    this.searchTermCheckedListBox.Items.Add(term);
                }

                // Should it be checked on add?
                if (this.checkOnAddToolStripMenuItem.Checked)
                {
                    // Check item (current or previous)
                    this.searchTermCheckedListBox.SetItemChecked(this.searchTermCheckedListBox.Items.IndexOf(term), true);
                }
            }

            // Resume painting
            this.searchTermCheckedListBox.EndUpdate();
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

            // Update total count
            this.totalToolStripStatusLabel.Text = this.searchEnginesCheckedListBox.Items.Count.ToString();
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
            // TODO Add code
        }

        /// <summary>
        /// Handles the search engines checked list box preview key down.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSearchEnginesCheckedListBoxPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // TODO Add code 
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
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
            // TODO Add code 
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
            // TODO Add code
        }

        /// <summary>
        /// Handles the search engines text box key down.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSearchEnginesTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            // TODO Add code
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
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code 
        }
    }
}
