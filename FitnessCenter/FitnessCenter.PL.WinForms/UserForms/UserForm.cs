using FitnessCenter.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace FitnessCenter.PL.WinForms.UserForms
{
    public partial class UserForm : Form
    {
        private readonly bool _createNew = true;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime Birthdate { get; private set; }
        public BindingList<Subscription> allSubscriptions = new BindingList<Subscription>();
        public List<Subscription> subscriptions;

        public UserForm(List<Subscription> subscriptions)
        {
            InitializeComponent();
            foreach (var item in subscriptions)
            {
                ctlListSubscriptions.Items.Add(item.NameService);
            }
        }

        public UserForm(User user, List<Subscription> subscriptions)
        {
            InitializeComponent();

            FirstName = user.FirstName;
            LastName = user.LastName;
            Birthdate = user.Birthdate;
            foreach (var item in subscriptions)
            {
                ctlListSubscriptions.Items.Add(item.NameService);
            }
            subscriptions = user.Subscriptions;
            _createNew = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            subscriptions = ctlListSubscriptions.CheckedItems.OfType<Subscription>().ToList();
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            FirstName = txtFirstName.Text.Trim();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            string input = txtFirstName.Text.Trim();
            if (String.IsNullOrEmpty(input) || input.Length > 50)
            {
                ctlErrorProviderUser.SetError(txtFirstName, "First name cannot be empty");
                e.Cancel = true;
            }
            else
            {
                ctlErrorProviderUser.SetError(txtFirstName, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            string input = txtLastName.Text.Trim();
            if (String.IsNullOrEmpty(input) || input.Length > 50)
            {
                ctlErrorProviderUser.SetError(txtLastName, "Last name cannot be empty");
                e.Cancel = true;
            }
            else
            {
                ctlErrorProviderUser.SetError(txtLastName, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            LastName = txtLastName.Text.Trim();
        }

        private void ctlBirthdate_Validated(object sender, EventArgs e)
        {
            Birthdate = ctlBirthdate.Value.Date;
        }

        private void ctlBirthdate_Validating(object sender, CancelEventArgs e)
        {
            DateTime input = ctlBirthdate.Value;
            if (!(input.CompareTo(DateTime.Now) < 0 && (DateTime.Now.Year - input.Year) < 150))
            {
                ctlErrorProviderUser.SetError(ctlBirthdate, "The age cannot be litter than 0 and more than 150");
                e.Cancel = true;
            }
            else
            {
                ctlErrorProviderUser.SetError(ctlBirthdate, String.Empty);
                e.Cancel = false;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;
            if (Birthdate == DateTime.MinValue)
            {
                ctlBirthdate.Value = DateTime.Now;
            }
            else
            {
                ctlBirthdate.Value = Birthdate;
            }

            if (subscriptions != null)
            {
                for (int i = 0; i < ctlListSubscriptions.Items.Count; i++)
                {
                    if (subscriptions.Contains((Subscription)ctlListSubscriptions.Items[i]))
                    {
                        ctlListSubscriptions.SetItemChecked(i, true);
                    }
                }
            }
            if (_createNew)
            {
                Text = "User";
                btnOk.Text = "Create";
            }
            else
            {
                Text = "User";
                btnOk.Text = "Update";
            }
        }
    }
}