﻿// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace SearchShortcut
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Web;
    using System.Windows.Forms;
    using System.Xml.Serialization;
    using Microsoft.VisualBasic;
    using PublicDomain;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// The settings data.
        /// </summary>
        private SettingsData settingsData = null;

        /// <summary>
        /// The settings data path.
        /// </summary>
        private string settingsDataPath = $"{Application.ProductName}-SettingsData.txt";

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SearchShortcut.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Title bar */

            // Set title by exe file name
            this.Text = Path.GetFileNameWithoutExtension(Application.ExecutablePath);

            /* Set icons */

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set PublicDomain.is tool strip menu item image
            this.freeReleasesPublicDomainisToolStripMenuItem.Image = this.associatedIcon.ToBitmap();

            /* Settings data */

            // HACK Flag for options
            bool setDefaultOptions = false;

            // Check for settings file
            if (!File.Exists(this.settingsDataPath))
            {
                // Create new settings file
                this.SaveSettingsFile(this.settingsDataPath, new SettingsData());

                // Toggle flag
                setDefaultOptions = true;
            }

            // Load settings from disk
            this.settingsData = this.LoadSettingsFile(this.settingsDataPath);

            // Check if must set default options
            if (setDefaultOptions)
            {
                // Set default options
                this.settingsData.CheckedOptionsList = new List<string>() { "askOnClearToolStripMenuItem", "checkOnAddToolStripMenuItem", "checkOnClickToolStripMenuItem", "restoreTermsToolStripMenuItem" };
            }
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

            // Declare terms list
            List<string> termsList = new List<string>();

            // Update add button text
            switch (this.SearchTermsModeToolStripComboBox.SelectedItem.ToString())
            {
                // Add
                case "Add terms":

                    // Add the terms
                    this.AddTerms();

                    break;

                case "Add and search":
                    // Set terms list
                    termsList = this.AddTerms();

                    // Perform search
                    this.PerformSearch(termsList, false);

                    break;

                case "Direct search":

                    // Split by comma adnd trim
                    foreach (string term in this.searchTermTextBox.Text.Split(',').Select(x => x.Trim()).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray())
                    {
                        // Add term to list
                        termsList.Add(term);
                    }

                    // Perform search
                    this.PerformSearch(termsList, false);

                    break;
            }

            // Resume painting
            this.searchTermsCheckedListBox.EndUpdate();

            // Clear text box
            this.searchTermTextBox.Clear();

            // Focus text box
            this.searchTermTextBox.Focus();
        }

        /// <summary>
        /// Adds the terms.
        /// </summary>
        private List<string> AddTerms()
        {
            // Terms list
            List<string> termsList = new List<string>();

            // Split by comma adnd trim
            foreach (string term in this.searchTermTextBox.Text.Split(',').Select(x => x.Trim()).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray())
            {
                // Add term to list
                termsList.Add(term);

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

            // Return terms list
            return termsList;
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
            // Perform search
            this.PerformSearch(new List<string>(), true);
        }

        /// <summary>
        /// Performs the search.
        /// </summary>
        /// <param name="termsList">Terms list.</param>
        /// <param name="addChecked">If set to <c>true</c> add checked.</param>
        private void PerformSearch(List<string> termsList, bool addChecked)
        {
            // Check flag
            if (addChecked)
            {
                // Iterate checked terms
                foreach (var searchTerm in this.searchTermsCheckedListBox.CheckedItems)
                {
                    // Add to terms list
                    termsList.Add(searchTerm.ToString());
                }
            }

            /* Check there are both terms & engines to perform a search */

            // Check for terms
            if (termsList.Count == 0)
            {
                // Advise user
                MessageBox.Show("No search term(s) to search.", "Missing term(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Halt flow
                return;
            }

            // Check for engines
            if (this.searchEnginesCheckedListBox.CheckedItems.Count == 0)
            {
                // Advise user
                MessageBox.Show("No engine(s) to search with.", "Missing engine(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Halt flow
                return;
            }

            // Iterate search terms
            foreach (string searchTerm in termsList)
            {
                // Iterate checked engines
                foreach (var searchEngine in this.searchEnginesCheckedListBox.CheckedItems)
                {
                    // Replace keyword
                    string searchEngineUrl = searchEngine.ToString().Replace(this.settingsData.Keyword, HttpUtility.UrlEncode(searchTerm));

                    // Check if must launch in chrome
                    if (this.chromeToolStripMenuItem.Checked)
                    {
                        try
                        {
                            // Launch in chrome
                            Process.Start("chrome", searchEngineUrl);

                            // Halt flow
                            continue;
                        }
                        catch
                        {
                            // Let it flow through
                            ;
                        }
                    }

                    // Launch in default browser
                    Process.Start(searchEngineUrl);
                }
            }
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
            // Reset file name
            this.textFileOpenFileDialog.FileName = string.Empty;

            // Show open file dialog
            if (this.textFileOpenFileDialog.ShowDialog() == DialogResult.OK && this.textFileOpenFileDialog.FileNames.Length > 0)
            {
                // Prevent painting
                this.searchEnginesCheckedListBox.BeginUpdate();

                // Iterate text files
                foreach (var textFilePath in this.textFileOpenFileDialog.FileNames)
                {
                    // Iterate lines
                    foreach (var possibleSearchEngine in File.ReadAllLines(textFilePath))
                    {
                        // First check it's well formed
                        if (!Uri.IsWellFormedUriString(possibleSearchEngine, UriKind.Absolute))
                        {
                            // Skip engine
                            continue;
                        }

                        // Check for a previous one
                        if (!this.searchEnginesCheckedListBox.Items.Contains(possibleSearchEngine))
                        {
                            // Add to checked list
                            this.searchEnginesCheckedListBox.Items.Add(possibleSearchEngine);
                        }

                        // Should it be checked on add
                        if (this.checkOnAddToolStripMenuItem.Checked)
                        {
                            // Check item (current or previous)
                            this.searchEnginesCheckedListBox.SetItemChecked(this.searchEnginesCheckedListBox.Items.IndexOf(possibleSearchEngine), true);
                        }
                    }
                }

                // Resume painting
                this.searchEnginesCheckedListBox.EndUpdate();

                // Focus text box
                this.searchEnginesTextBox.Focus();
            }
        }

        /// <summary>
        /// Handles the save tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Check there's something to save
            if (this.searchEnginesCheckedListBox.Items.Count == 0)
            {
                // Inform user
                MessageBox.Show($"Nothing to save.", "Empty list", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Halt flow
                return;
            }

            // Empty file name
            this.textFileSaveFileDialog.FileName = string.Empty;

            // Open save file dialog
            if (this.textFileSaveFileDialog.ShowDialog() == DialogResult.OK && this.textFileSaveFileDialog.FileName.Length > 0)
            {
                try
                {
                    // Save lines to disk
                    File.WriteAllLines(this.textFileSaveFileDialog.FileName, this.searchEnginesCheckedListBox.Items.Cast<string>().ToArray());
                }
                catch (Exception exception)
                {
                    // Inform user
                    MessageBox.Show($"Error when saving to \"{Path.GetFileName(this.textFileSaveFileDialog.FileName)}\":{Environment.NewLine}{exception.Message}", "Save file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Handles the set new keyword tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSetNewKeywordToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Collect item text from user
            string newKeyword = Interaction.InputBox("Set new keyword", "Edit", this.settingsData.Keyword);

            // Check it's not empty and different 
            if (newKeyword.Length > 0 && newKeyword != this.settingsData.Keyword)
            {
                // Set into settings data
                this.settingsData.Keyword = newKeyword;

                // Update display
                this.keywordToolStripStatusLabel.Text = newKeyword;
            }
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
        /// Handles the target browser tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnTargetBrowserToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Uncheck all
            foreach (ToolStripMenuItem dropDownItem in this.targetBrowserToolStripMenuItem.DropDownItems)
            {
                dropDownItem.Checked = false;
            }

            // Check clicked menu item
            toolStripMenuItem.Checked = true;
        }

        /// <summary>
        /// Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our site
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=53334.0");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/publicdomain/search-shortcut");
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"Search icon by mcmurryjulie - Pixabay's Content license{Environment.NewLine}" +
                $"https://pixabay.com/vectors/database-search-database-search-icon-2797375/{Environment.NewLine}{Environment.NewLine}" +
                $"Patreon icon used according to published brand guidelines{Environment.NewLine}" +
                $"https://www.patreon.com/brand{Environment.NewLine}{Environment.NewLine}" +
                $"GitHub mark icon used according to published logos and usage guidelines{Environment.NewLine}" +
                $"https://github.com/logos{Environment.NewLine}{Environment.NewLine}" +
                $"DonationCoder icon used with permission{Environment.NewLine}" +
                $"https://www.donationcoder.com/forum/index.php?topic=48718{Environment.NewLine}{Environment.NewLine}" +
                $"PublicDomain icon is based on the following source images:{Environment.NewLine}{Environment.NewLine}" +
                $"Bitcoin by GDJ - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/bitcoin-digital-currency-4130319/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter P by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/p-glamour-gold-lights-2790632/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter D by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/d-glamour-gold-lights-2790573/{Environment.NewLine}{Environment.NewLine}";

            // Prepend sponsors
            licenseText = $"RELEASE SUPPORTERS:{Environment.NewLine}{Environment.NewLine}* Jesse Reichler (mouser){Environment.NewLine}* Max P.{Environment.NewLine}* Kathryn S.{Environment.NewLine}* Cranioscopical{Environment.NewLine}* tomos{Environment.NewLine}* luvnbeast{Environment.NewLine}* nkormanik{Environment.NewLine}{Environment.NewLine}=========={Environment.NewLine}{Environment.NewLine}" + licenseText;

            // Set title
            string programTitle = typeof(MainForm).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

            // Set version for generating semantic version
            Version version = typeof(MainForm).GetTypeInfo().Assembly.GetName().Version;

            // Set about form
            var aboutForm = new AboutForm(
                $"About {programTitle}",
                $"{programTitle} {version.Major}.{version.Minor}.{version.Build}",
                $"Made for: luvnbeast{Environment.NewLine}DonationCoder.com{Environment.NewLine}Day #129, Week #19 @ May 09, 2023",
                licenseText,
                this.Icon.ToBitmap())
            {
                // Set about form icon
                Icon = this.associatedIcon,

                // Set always on top
                TopMost = this.TopMost
            };

            // Show about form
            aboutForm.ShowDialog();
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
            /* GUI */

            // Add items to checked listboxes
            this.searchTermsCheckedListBox.Items.AddRange(this.settingsData.SearchTermsList.ToArray());
            this.searchEnginesCheckedListBox.Items.AddRange(this.settingsData.SearchEnginesList.ToArray());

            // Check terms
            for (int i = 0; i < this.searchTermsCheckedListBox.Items.Count; i++)
            {
                // Check if exists in checked search terms list
                if (this.settingsData.CheckedSearchTermsList.Contains(this.searchTermsCheckedListBox.Items[i].ToString()))
                {
                    // Check
                    this.searchTermsCheckedListBox.SetItemChecked(i, true);
                }
            }

            // Check engines
            for (int i = 0; i < this.searchEnginesCheckedListBox.Items.Count; i++)
            {
                // Check if exists in checked search engines list
                if (this.settingsData.CheckedSearchEnginesList.Contains(this.searchEnginesCheckedListBox.Items[i].ToString()))
                {
                    // Check
                    this.searchEnginesCheckedListBox.SetItemChecked(i, true);
                }
            }

            // Update checked count
            this.termsToolStripStatusLabel.Text = this.searchTermsCheckedListBox.CheckedItems.Count.ToString();
            this.enginesToolStripStatusLabel.Text = this.searchEnginesCheckedListBox.CheckedItems.Count.ToString();

            // Check options
            foreach (ToolStripMenuItem toolStripMenuItem in this.optionsToolStripMenuItem.DropDownItems)
            {
                // Set checked state
                toolStripMenuItem.Checked = this.settingsData.CheckedOptionsList.Contains(toolStripMenuItem.Name);
            }

            // Check target browser
            foreach (ToolStripMenuItem toolStripMenuItem in this.targetBrowserToolStripMenuItem.DropDownItems)
            {
                // Check if it's contained  in checked options list
                if (this.settingsData.CheckedTargetBrowser == toolStripMenuItem.Name)
                {
                    // Check it
                    toolStripMenuItem.Checked = true;

                    // Halt flow
                    break;
                }
            }

            // Keyword
            this.keywordToolStripStatusLabel.Text = this.settingsData.Keyword;

            // Set topmost by settings data
            this.TopMost = this.settingsData.CheckedOptionsList.Contains("alwaysOnTopToolStripMenuItem");

            // Set search terms mode
            this.SearchTermsModeToolStripComboBox.SelectedIndex = this.SearchTermsModeToolStripComboBox.Items.IndexOf(this.settingsData.SearchTermsMode);
        }

        /// <summary>
        /// Handles the main form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            /* Checked options */

            // New checked options list
            List<string> checkedOptionsList = new List<string>();

            // Set checked options list
            foreach (ToolStripMenuItem toolStripMenuItem in this.optionsToolStripMenuItem.DropDownItems)
            {
                // Check if checked
                if (toolStripMenuItem.Checked)
                {
                    // Add to checked options list
                    checkedOptionsList.Add(toolStripMenuItem.Name);
                }
            }

            // Set into settings data
            this.settingsData.CheckedOptionsList.Clear();
            this.settingsData.CheckedOptionsList = checkedOptionsList;

            /* Checked target browser */

            // Set checked target browser
            foreach (ToolStripMenuItem toolStripMenuItem in this.targetBrowserToolStripMenuItem.DropDownItems)
            {
                // Check if checked
                if (toolStripMenuItem.Checked)
                {
                    // Set into settings data
                    this.settingsData.CheckedTargetBrowser = toolStripMenuItem.Name;

                    // Halt flow
                    break;
                }
            }

            /* Search terms list */

            // Clear afresh
            this.settingsData.SearchTermsList.Clear();
            this.settingsData.CheckedSearchTermsList.Clear();

            // Check if must restore terms
            if (this.restoreTermsToolStripMenuItem.Checked)
            {
                // Add items into settings data list 
                this.settingsData.SearchTermsList.AddRange(this.searchTermsCheckedListBox.Items.Cast<string>());

                // Add checked items into settings data list 
                this.settingsData.CheckedSearchTermsList.AddRange(this.searchTermsCheckedListBox.CheckedItems.Cast<string>());
            }

            /* Search engines list */

            // Clear afresh
            this.settingsData.SearchEnginesList.Clear();
            this.settingsData.CheckedSearchEnginesList.Clear();

            // Add items into settings data list 
            this.settingsData.SearchEnginesList.AddRange(this.searchEnginesCheckedListBox.Items.Cast<string>());

            // Add checked items into settings data list 
            this.settingsData.CheckedSearchEnginesList.AddRange(this.searchEnginesCheckedListBox.CheckedItems.Cast<string>());

            /* Save to disk */

            // Save settings data to disk
            this.SaveSettingsFile(this.settingsDataPath, this.settingsData);
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
            // Update checked engines
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
        /// Loads the settings file.
        /// </summary>
        /// <returns>The settings file.</returns>
        /// <param name="settingsFilePath">Settings file path.</param>
        private SettingsData LoadSettingsFile(string settingsFilePath)
        {
            // Use file stream
            using (FileStream fileStream = File.OpenRead(settingsFilePath))
            {
                // Set xml serialzer
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                // Return populated settings data
                return xmlSerializer.Deserialize(fileStream) as SettingsData;
            }
        }

        /// <summary>
        /// Saves the settings file.
        /// </summary>
        /// <param name="settingsFilePath">Settings file path.</param>
        /// <param name="settingsDataParam">Settings data parameter.</param>
        private void SaveSettingsFile(string settingsFilePath, SettingsData settingsDataParam)
        {
            try
            {
                // Use stream writer
                using (StreamWriter streamWriter = new StreamWriter(settingsFilePath, false))
                {
                    // Set xml serialzer
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                    // Serialize settings data
                    xmlSerializer.Serialize(streamWriter, settingsDataParam);
                }
            }
            catch (Exception exception)
            {
                // Advise user
                MessageBox.Show($"Error saving settings file.{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{exception.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the search terms mode tool strip combo box selected index changed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSearchTermsModeToolStripComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            // Update add button text
            switch (this.SearchTermsModeToolStripComboBox.SelectedItem.ToString())
            {
                // Add
                case "Add terms":

                    // Update button text
                    this.searchTermAddButton.Text = "&Add";

                    break;

                case "Add and search":

                    // Update button text
                    this.searchTermAddButton.Text = "&A+S";

                    break;

                case "Direct search":

                    // Update button text
                    this.searchTermAddButton.Text = "&Srch";

                    break;
            }

            // Update settings data
            this.settingsData.SearchTermsMode = this.SearchTermsModeToolStripComboBox.SelectedItem.ToString();
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
