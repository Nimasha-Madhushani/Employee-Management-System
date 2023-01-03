import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddEmployeeComponent } from './components/add-employee/add-employee.component';
import { EmployeesListComponent } from './components/employees/employees-list/employees-list.component';

const routes: Routes = [
  {
    path:'',
    component:EmployeesListComponent
  },
  {
    path:'employees',
    component:EmployeesListComponent
  },
  {
    path:'employees/add',
    component:AddEmployeeComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
