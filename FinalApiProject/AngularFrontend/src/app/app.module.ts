import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { NgToastModule } from 'ng-angular-popup';
import { HttpClientModule } from '@angular/common/http';
import { DashboardComponent } from './Components/dashboard/dashboard.component';
import { LoginComponent } from './Components/login/login.component';
import { AddGraduateTraineeComponent } from './Components/add-graduate-trainee/add-graduate-trainee.component';
import { UpdateGraduateTraineComponent } from './Components/update-graduate-traine/update-graduate-traine.component';
import { GetGraduateTraineeIdComponent } from './get-graduate-trainee-id/get-graduate-trainee-id.component';
import { DeleteGraduateTraineeComponent } from './delete-graduate-trainee/delete-graduate-trainee.component';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,LoginComponent, AddGraduateTraineeComponent, UpdateGraduateTraineComponent, GetGraduateTraineeIdComponent, DeleteGraduateTraineeComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    RouterModule,
    HttpClientModule,
    NgToastModule,


  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
