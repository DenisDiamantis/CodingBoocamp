import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  constructor() { }

  Username: String = "";
  Designation: String = "";
  NoOfTeamMembers: number = 0;
  TotalCostOfAllProjects: number = 0;;
  PendingTasks: number = 0;
  UpComingProjects: number = 0;
  ProjectCost: number = 0;
  CurrentExpenditure: number = 0;
  AvailableFunds: number = 0;

  Clients: string[] = [];
  Projects: string[] = [];
  Years: number[] = [];
  TeamMembersSummary: any[] = [];
  TeamMembers: any[] = [];



  ngOnInit(): void {
    this.Designation = "Team Leader";
    this.Username = "Scott Smith";
    this.NoOfTeamMembers = 67;
    this.PendingTasks = 15;
    this.TotalCostOfAllProjects = 240;
    this.UpComingProjects = 2;
    this.ProjectCost = 2113507;
    this.CurrentExpenditure = 96788;
    this.AvailableFunds = 52536;
    this.Clients = [
      'ABC Infotech Ltd.',
      'DEF Software Solutions',
      'GHI Industries'
    ];
    this.Projects = [
      'Project A',
      'Project B',
      'Project C',
      'Project D'
    ];
    for (let index = 2019; index >= 2010; index--) {
      this.Years.push(index);
    }
    this.TeamMembersSummary = [
      {
        Region: 'East',
        TeamMembersCount: 20,
        TemporarilyUnavailableMembers: 4
      },
      {
        Region: 'West',
        TeamMembersCount: 25,
        TemporarilyUnavailableMembers: 8
      },
      {
        Region: 'South',
        TeamMembersCount: 17,
        TemporarilyUnavailableMembers: 1
      },
      {
        Region: 'North',
        TeamMembersCount: 15,
        TemporarilyUnavailableMembers: 6
      }
    ];
    this.TeamMembers = [
      {
        Region: 'East',
        Members: [
          { ID: 1, Name: 'Ford', Status: 'Available' },
          { ID: 2, Name: 'Miller', Status: 'Available' },
          { ID: 3, Name: 'Jones', Status: 'Busy' },
          { ID: 4, Name: 'James', Status: 'Busy' },
        ]
      },
      {
        Region: 'West',
        Members: [
          { ID: 5, Name: 'Ford', Status: 'Available' },
          { ID: 6, Name: 'Miller', Status: 'Available' },
          { ID: 7, Name: 'Jones', Status: 'Busy' },
          { ID: 8, Name: 'James', Status: 'Busy' },
        ]
      },
      {
        Region: 'South',
        Members: [
          { ID: 9, Name: 'Ford', Status: 'Available' },
          { ID: 10, Name: 'Miller', Status: 'Available' },
          { ID: 11, Name: 'Jones', Status: 'Busy' },
          { ID: 12, Name: 'James', Status: 'Busy' },
        ]
      },
      {
        Region: 'North',
        Members: [
          { ID: 13, Name: 'Ford', Status: 'Available' },
          { ID: 14, Name: 'Miller', Status: 'Available' },
          { ID: 15, Name: 'Jones', Status: 'Busy' },
          { ID: 16, Name: 'James', Status: 'Busy' },
        ]
      },
    ];

  }
  onProjectChange($event: any){
    if($event.target.innerHTML.trim()=='Project A'){
      this.ProjectCost=2113507;
      this.CurrentExpenditure=96788;
      this.AvailableFunds=52436;
    }else if($event.target.innerHTML.trim()=='Project B'){
      this.ProjectCost=8888933;
      this.CurrentExpenditure=42342;
      this.AvailableFunds=786545;
    }else if($event.target.innerHTML.trim()=='Project C'){
      this.ProjectCost=662183;
      this.CurrentExpenditure=77213;
      this.AvailableFunds=9763;
    }else if($event.target.innerHTML.trim()=='Project D'){
      this.ProjectCost=9322321;
      this.CurrentExpenditure=34238;
      this.AvailableFunds=23446;
    }
  }
}
