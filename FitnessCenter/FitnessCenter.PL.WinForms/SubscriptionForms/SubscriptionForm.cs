using FitnessCenter.Shared;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FitnessCenter.PL.WinForms.SubscriptionForms
{
    public partial class SubscriptionForm : Form
    {
        public string NameService { get; private set; }
        public string Description { get; private set; }
        private readonly bool _createNew = true;

        public SubscriptionForm()
        {
            InitializeComponent();
        }

        public SubscriptionForm(Subscription subscription)
        {
            InitializeComponent();

            NameService = subscription.NameService;
            Description = subscription.Description;
            _createNew = false;
        }

        private void txtNameService_Validated(object sender, EventArgs e)
        {
            NameService = txtNameService.Text.Trim();
        }

        private void txtNameService_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameService.Text.Trim()))
            {
                ctlErrorProviderSubscription.SetError(txtNameService, "Name of service cannot be empty");
                e.Cancel = true;
            }
            else
            {
                ctlErrorProviderSubscription.SetError(txtNameService, string.Empty);
                e.Cancel = false;
            }
        }

        private void txtDescription_Validated(object sender, EventArgs e)
        {
            Description = txtDescription.Text.Trim();
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            var input = txtDescription.Text.Trim();
            if (input.Length > 250)
            {
                ctlErrorProviderSubscription.SetError(txtDescription, "Description cannot be more than 250 symbols");
                e.Cancel = true;
            }
            else
            {
                ctlErrorProviderSubscription.SetError(txtDescription, string.Empty);
                e.Cancel = false;
            }
        }

        private void SubscriptionForm_Load(object sender, EventArgs e)
        {
            txtNameService.Text = Name;
            txtDescription.Text = Description;
            if (_createNew)
            {
                Text = "Add new subscription";
                btnOK.Text = "Create";
            }
            else
            {
                Text = "Edit subscription";
                btnOK.Text = "Update";
            }
        }
    }
}

