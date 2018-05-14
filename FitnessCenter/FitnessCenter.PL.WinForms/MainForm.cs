using FitnessCenter.Shared;
using System;
using System.Windows.Forms;
using FitnessCenter.PL.WinForms.UserForms;
using System.ComponentModel;
using System.Collections.Generic;
using FitnessCenter.PL.WinForms.SubscriptionForms;
using System.Linq;

namespace FitnessCenter.PL.WinForms
{
    public partial class MainForm : Form
    {
        private ILogic logic;
        private List<User> _users = new List<User>();
        private BindingList<UserViewModel> _usersView = new BindingList<UserViewModel>();
        #region Sort Mode
        private enum SortMode { Asceding, Desceding };
        private SortMode _sortModeFirstName = SortMode.Asceding;
        private SortMode _sortModeLastName = SortMode.Asceding;
        private SortMode _sortModeBirthdate = SortMode.Asceding;
        private SortMode _sortModeAge = SortMode.Asceding;
        private SortMode _sortModeSubscription = SortMode.Asceding;
        private SortMode _sortModeSubscriptionTitle = SortMode.Asceding;
        #endregion

        public MainForm(ILogic logic)
        {
            InitializeComponent();
            this.logic = logic;
            ctlUserGrid.AutoGenerateColumns = false;
            ctlSubscriptionGrid.AutoGenerateColumns = false;
        }

        #region User

        private void AddUser()
        {
            var userForm = new UserForm(logic.GetSubscription());
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                var firstName = userForm.FirstName;
                var lastName = userForm.LastName;
                var birthdate = userForm.Birthdate;
                var listSubscriptions = userForm.subscriptions;
                var user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Birthdate = birthdate,
                    Subscriptions = listSubscriptions
                };
                logic.AddUser(user);
                UpdateUsersGrid();
            }
        }

        private void UpdateUsersGrid()
        {
            var users = logic.GetUsersViewModel();
            ctlUserGrid.DataSource = null;
            ctlUserGrid.DataSource = users;
        }

        private void RemoveSelectedUser()
        {
            if (ctlUserGrid.SelectedCells.Count > 0)
            {
                UserViewModel userView = (UserViewModel)ctlUserGrid.SelectedCells[0].OwningRow.DataBoundItem;
                logic.DeleteUser(userView.UserId);
                UpdateUsersGrid();
            }
        }

        private void EditSelectedUser()
        {
            if (ctlUserGrid.SelectedCells.Count > 0)
            {
                UserViewModel userView = (UserViewModel)ctlUserGrid.SelectedCells[0].OwningRow.DataBoundItem;
                User user = userView.GetUser();
                UserForm form = new UserForm(user, logic.GetSubscription());
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    user.AddSubscription(form.subscriptions);
                    user.FirstName = form.FirstName;
                    user.LastName = form.LastName;
                    user.Birthdate = form.Birthdate;
                    logic.UpdateUser(user);
                    UpdateUsersGrid();
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            UserViewModel userView = (UserViewModel)ctlUserGrid.SelectedCells[0].OwningRow.DataBoundItem;
            DialogResult dialogres = MessageBox.Show($"Do you want to delete {userView.FirstName} {userView.LastName}?", "Warning", MessageBoxButtons.YesNo);
            if (dialogres == DialogResult.Yes)
            {
                RemoveSelectedUser();
            }
        }

        private void btnEditUserContextMenu_Click(object sender, EventArgs e)
        {
            EditSelectedUser();
        }

        #endregion

        #region Subscription

        private void AddSubscription()
        {
            SubscriptionForm form = new SubscriptionForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                Subscription subscription = new Subscription
                {
                    NameService = form.NameService,
                    Description = form.Description
                };
                logic.AddSubscription(subscription);
                UpdateSubscriptionsGrid();
            }
        }

        private void EditSelectedSubscription()
        {
            if (ctlSubscriptionGrid.SelectedCells.Count > 0)
            {
                Subscription subscription = (Subscription)ctlSubscriptionGrid.SelectedCells[0].OwningRow.DataBoundItem;
                SubscriptionForm form = new SubscriptionForm(subscription);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    subscription.NameService = form.NameService;
                    subscription.Description = form.Description;
                    logic.UpdateSubscription(subscription);
                }
            }
            UpdateUsersGrid();
            UpdateSubscriptionsGrid();
        }

        private void RemoveSelectedSubscription()
        {
            if (ctlSubscriptionGrid.SelectedCells.Count > 0)
            {
                Subscription subscription = (Subscription)ctlSubscriptionGrid.SelectedCells[0].OwningRow.DataBoundItem;
                logic.DeleteSubscription(subscription.SubscriptionId);
                UpdateUsersGrid();
                UpdateSubscriptionsGrid();
            }
        }

        private void UpdateSubscriptionsGrid()
        {
            var subscriptions = logic.GetSubscription();
            ctlSubscriptionGrid.DataSource = null;
            ctlSubscriptionGrid.DataSource = subscriptions;
        }

        private void btnAddSubscriptionMenu_Click(object sender, EventArgs e)
        {
            AddSubscription();
        }

        private void btnDeleteSubscription_Click(object sender, EventArgs e)
        {
            Subscription subscription = (Subscription)ctlSubscriptionGrid.SelectedCells[0].OwningRow.DataBoundItem;
            DialogResult dialogres = MessageBox.Show($"Do you want to delete {subscription.NameService}?", "Warning", MessageBoxButtons.YesNo);
            if (dialogres == DialogResult.Yes)
            {
                RemoveSelectedSubscription();
            }
        }

        private void btnSubscriptionContextMenu_Click(object sender, EventArgs e)
        {
            EditSelectedSubscription();
        }

        #endregion


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var users = logic.GetUsersViewModel();
            if (users.Count > 0)
            {
                ctlUserGrid.DataSource = users;
            }
            var subscriptions = logic.GetSubscription();
            if (subscriptions.Count > 0)
            {
                ctlSubscriptionGrid.DataSource = subscriptions;
            }
        }

        #region Sort
        private void SortByFirstNameAsc()
        {
            _usersView = new BindingList<UserViewModel>(_usersView.OrderBy(s => s.FirstName).ToList());
        }

        private void SortByFirstNameDesc()
        {
            _usersView = new BindingList<UserViewModel>(_usersView.OrderByDescending(s => s.FirstName).ToList());
        }

        private void SortByLastNameAsc()
        {
            _usersView = new BindingList<UserViewModel>(_usersView.OrderBy(s => s.LastName).ToList());
        }

        private void SortByLastNameDesc()
        {
            _usersView = new BindingList<UserViewModel>(_usersView.OrderByDescending(s => s.LastName).ToList());
        }

        private void SortByBirthdateAsc()
        {
            //sort
            //_usersView = new BindingList<UserViewModel>(_usersView.OrderBy(s => s.Birthdate).ToList());
        }

        private void SortByBirthdateDesc()
        {
            //sort
            //_users = new List<UserViewModel>(_users.OrderByDescending(s => s.Birthdate).ToList());
        }

        private void SortByAgeAsc()
        {
            _usersView = new BindingList<UserViewModel>(_usersView.OrderBy(s => s.Age).ToList());
        }

        private void SortByAgeDesc()
        {
            _usersView = new BindingList<UserViewModel>(_usersView.OrderByDescending(s => s.Age).ToList());
        }

        private void SortBySubscriptionAsc()
        {
            //sort
            //_usersView = new BindingList<UserViewModel>(_usersView.OrderBy(s => s.Subscription.Count).ToList());
        }

        private void SortBySubscriptionDesc()
        {
            //sort
            //_usersView = new BindingList<UserViewModel>(_usersView.OrderByDescending(s => s.Subscriptions.Count).ToList());
        }

        private void SortBySubscriptionTitleAsc()
        {
            //sort
            //_rewards = new BindingList<Reward>(_rewards.OrderBy(s => s.Title).ToList());
        }

        private void SortBySubscriptionTitleDesc()
        {
            //sort
            //_rewards = new BindingList<Reward>(_rewards.OrderByDescending(s => s.Title).ToList());
        }

        private void ctlUserGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ctlSubscriptionGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (_sortModeSubscriptionTitle == SortMode.Asceding)
                {
                    SortBySubscriptionTitleDesc();
                    _sortModeSubscriptionTitle = SortMode.Desceding;
                }
                else
                {
                    SortBySubscriptionTitleAsc();
                    _sortModeSubscriptionTitle = SortMode.Asceding;
                }
            }
            UpdateSubscriptionsGrid();
        }

        #endregion
    }
}
