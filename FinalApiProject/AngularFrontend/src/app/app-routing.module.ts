import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './Components/dashboard/dashboard.component';
import { LoginComponent } from './Components/login/login.component';
import { AddGraduateTraineeComponent } from './Components/add-graduate-trainee/add-graduate-trainee.component';
import { UpdateGraduateTraineComponent } from './Components/update-graduate-traine/update-graduate-traine.component';
import { GetGraduateTraineeIdComponent } from './get-graduate-trainee-id/get-graduate-trainee-id.component';
import { DeleteGraduateTraineeComponent } from './delete-graduate-trainee/delete-graduate-trainee.component';
import { authGuard } from './auth.guard';

const routes: Routes = [
  {
    path: 'dashboard',
    component: DashboardComponent,
    //canActivate: [authGuard],
  },
  {
    path: 'login',
    component: LoginComponent,
    //canActivate: [authGuard],
  },
  {
    path: 'add-graduate-trainee',
    component: AddGraduateTraineeComponent,
    //canActivate: [authGuard],
  },

    { path: 'get-graduate-trainee-id/:id', component: GetGraduateTraineeIdComponent,
    //canActivate: [authGuard],
  },


    { path: 'update-graduate-trainee/:id', component: UpdateGraduateTraineComponent,
    //canActivate: [authGuard],
  },
    { path: 'delete-graduate-trainee/:id', component: DeleteGraduateTraineeComponent,
    //canActivate: [authGuard],
  },


  { path: '**', redirectTo: '/login' },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
