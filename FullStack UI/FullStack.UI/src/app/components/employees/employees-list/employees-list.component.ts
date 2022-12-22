import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee.model';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent  implements OnInit{
  employees:Employee[]=[
    {
      id:'aaaaaaaa',
      name:'Nimasha1',
      email:'n@gamil.com',
      phone:273658965,
      salary:120000,
      department:'HR'
    },
    {
      id:'bbbbbbbbb',
      name:'Nimasha2',
      email:'n@gamil.com',
      phone:273658965,
      salary:120000,
      department:'HR'
    },
    {
      id:'ccccccccc',
      name:'Nimasha3',
      email:'n@gamil.com',
      phone:273658965,
      salary:120000,
      department:'HR'
    }
  ];
  constructor(){}
  ngOnInit(): void {

    this.employees.push()
    
  }

}
