using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentLibrary.Models;

namespace TournamentUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();   
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;                 
                                                            
        public CreateTeamForm(ITeamRequester caller)        
        {
            InitializeComponent();

            callingForm = caller;                           
            
            WireUpLists();              
        }

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;                 
            selectTeamMemberDropDown.DataSource = availableTeamMembers;     
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;                       
            teamMembersListBox.DataSource = selectedTeamMembers;            
            teamMembersListBox.DisplayMember = "FullName";                  
        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                PersonModel person = new PersonModel();
                person.FirstName = firstNameValue.Text;
                person.LastName = lastNameValue.Text;
                person.EmailAddress = emailValue.Text;
                person.CellphoneNumber = cellPhoneValue.Text;

                GlobalConfig.Connection.CreatePerson(person);               
                selectedTeamMembers.Add(person);                        
                WireUpLists();                                          

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellPhoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (firstNameValue.Text.Length == 0)    
            {
                output = false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                output = false;
            }

            if (emailValue.Text.Length == 0)
            {
                output = false;
            }

            if (cellPhoneValue.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem; 
            if (p != null)                                                      
            {                                                                   
                availableTeamMembers.Remove(p);                                 
                selectedTeamMembers.Add(p);                                     

                WireUpLists();                                                  
            }
        }

        private void RemoveSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;   
            
            if (p != null)                                                  
            {                                                               
                selectedTeamMembers.Remove(p);                              
                availableTeamMembers.Add(p);                                

                WireUpLists();                                              
            }   
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();              
            t.TeamName = teamNameValue.Text;            
            t.TeamMembers = selectedTeamMembers;        

            GlobalConfig.Connection.CreateTeam(t);          

            callingForm.TeamComplete(t);                

            this.Close();                               
        }
    }
}
