using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinAppUIStyleTwo.ViewModels
{
    class ControllerAgentsViewModel : INotifyPropertyChanged
    {
        static int _id = 6;
        public ObservableCollection<Agent> AgentList { get; set; }

        public ControllerAgentsViewModel()
        {

            AgentList = new ObservableCollection<Agent>();
            var ImageUrl = "agent.png";
            AgentList.Add(new Agent() { AgentId = "1", FirstName = "Jack", LastName="Smith", Image = ImageUrl, Email = "A1@gmail.com", LastLocation = "abc1", IsAssigned=true, IsTracking=false});
            AgentList.Add(new Agent() { AgentId = "2", FirstName = "John", LastName="Walker", Image = ImageUrl, Email = "A2@gmail.com", LastLocation = "abc1", IsAssigned = true, IsTracking = false });
            AgentList.Add(new Agent() { AgentId = "3", FirstName = "Raj", LastName="Patel", Image = ImageUrl, Email = "A3@gmail.com", LastLocation = "abc1", IsAssigned = true, IsTracking = true });
            AgentList.Add(new Agent() { AgentId = "4", FirstName = "Rahul", LastName="Shah", Image = ImageUrl, Email = "A4@gmail.com", LastLocation = "abc1", IsAssigned = true, IsTracking = false });
            AgentList.Add(new Agent() { AgentId = "5", FirstName = "Nick", LastName="Jonas", Image = ImageUrl, Email = "A5@gmail.com", LastLocation = "Not Available", IsAssigned = false, IsTracking = false });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // Name and email properties
        public string _fname;
        public string _lname;

        public string _email;
        public string _FName
        {
            get => _fname;
            set {
                _fname = value;
                OnPropertyChanged();
            } 
        }
        public string _LName
        {
            get => _lname;
            set
            {
                _lname = value;
                OnPropertyChanged();
            }
        }
        public string _Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ICommand AddAgentCommand => new Command(AddAgent);
        public void AddAgent()
        {
            if (_FName != null && _LName !=null && _Email != null)
            {
                var ImageUrl = "agent.png";
                AgentList.Add(new Agent()
                {
                    AgentId = _id.ToString(),
                    FirstName = _FName,
                    LastName = _LName,
                    Email = _Email,
                    Image = ImageUrl,
                    LastLocation = "Not Available",
                    IsAssigned = false,
                    IsTracking=false
                });          
                _id++;
                _FName = null;
                _LName = null;
                _Email = null;
            }
        }

        public ICommand DeleteAgentCommand => new Command(DeleteAgent);
        public void DeleteAgent(object o)
        {
            Agent agentToRemove = o as Agent;
            AgentList.Remove(agentToRemove);
        }

        public Agent agentToEdit { get; set; }
        public ICommand EditAgentCommand => new Command(EditAgent);
        public void EditAgent(object o)
        {

            agentToEdit = o as Agent;
            _FName = agentToEdit.FirstName;
            _LName = agentToEdit.LastName;
            _Email = agentToEdit.Email;
        }

        public ICommand SaveChangesCommand => new Command(SaveChanges);
        public void SaveChanges()
        {
            int newIndex = AgentList.IndexOf(agentToEdit);
            if (_FName != null && _LName != null && _Email != null)
            {
                
                AgentList.Remove(agentToEdit);
                Agent temp = new Agent()
                {
                    AgentId = agentToEdit.AgentId,
                    FirstName = _FName,
                    LastName = _LName,
                    Email = _Email,
                    Image = agentToEdit.Image,
                    LastLocation = agentToEdit.LastLocation,
                    IsAssigned = agentToEdit.IsAssigned,
                    IsTracking = agentToEdit.IsTracking
                };
                AgentList.Add(temp);
                _id++;
                _FName = null;
                _LName = null;
                _Email = null;
                int oldIndex = AgentList.IndexOf(temp);
                AgentList.Move(oldIndex, newIndex);
            }


        }


    }

    class Agent
    {
        public string AgentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Image { get; set; }
        public string Email { get; set; }
        public string LastLocation { get; set; }
        public bool IsAssigned { get; set; }
        public bool IsTracking { get; set; }

    }
}
