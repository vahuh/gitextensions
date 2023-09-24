using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResourceManager;

namespace GitUI.CommandsDialogs.BrowseDialog.DashboardControl
{
    public partial class FormDashboardCustomizeRepoName : GitExtensionsForm
    {
        private readonly TranslationString _repoNameRequiredText = new("Repository name is required");
        private readonly TranslationString _repoNameTakenText = new("Repository name already exists");
        private readonly List<string> _existingRepoNames = new();
        public FormDashboardCustomizeRepoName()
        {
            InitializeComponent();
            InitializeComplete();
        }

        public FormDashboardCustomizeRepoName(IEnumerable<string> existingRepoNames)
            : this()
        {
            if (existingRepoNames is not null)
            {
                _existingRepoNames.AddRange(existingRepoNames);
            }
        }

        public string? RepoName { get; private set; }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRepoName.Text))
            {
                MessageBox.Show(this, _repoNameRequiredText.Text, lblRepoName.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_existingRepoNames.Contains(txtRepoName.Text.Trim(), StringComparer.Ordinal))
            {
                MessageBox.Show(this, _repoNameTakenText.Text, lblRepoName.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RepoName = txtRepoName.Text;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtRepoName_TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = txtRepoName.Text != RepoName;
        }
    }
}
