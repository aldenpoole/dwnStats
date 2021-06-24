import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { UsersComponent } from './users/users.component';
import { UserProfileComponent} from './users/user-profile/user-profile.component'

const routes: Routes = [
  {path: '', component:DashboardComponent},
  {path: 'users', component:UsersComponent},
  {path: 'user-profile/:id', component:UserProfileComponent}
  // {path: "**", component: PageNotFoundComponent}
  // will need to add page not found component later
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

