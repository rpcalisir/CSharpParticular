using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsingSqlLiteLibrary;

namespace UsingSqlLiteWinFormUI
{
    public partial class Form1 : Form
    {
        List<PersonModel> people = new List<PersonModel>();
        public Form1()
        {
            InitializeComponent();
            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            people.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            people.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });
            people.Add(new PersonModel { FirstName = "Jimmy", LastName = "Knut" });

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            lstListPeople.DataSource = null;
            lstListPeople.DataSource = people;
            lstListPeople.DisplayMember = "FirstName";
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        private void AddPerson()
        {
            PersonModel person = new PersonModel();

            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;

            people.Add(person);

            txtFirstName.Text = "";
            txtLastName.Text = "";

            WireUpPeopleList();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            people.Clear();
            LoadPeopleList();
        }
    }
}
