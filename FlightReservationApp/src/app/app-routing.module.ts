import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { AdminhomeComponent } from './adminhome/adminhome.component';
import { FlightDetailsComponent } from './flight-details/flight-details.component';
import { AirlineDetailsComponent } from './airline-details/airline-details.component';
import { AuthguardService } from './Services/authguard.service';
import { AddflightComponent } from './addflight/addflight.component';


const routes: Routes = [
  { path: '', redirectTo: 'login', pathMatch: 'full',  },
  {path: 'login', component: LoginComponent},
  {path: 'adminhome', component: AdminhomeComponent,canActivate:[AuthguardService]},
  {path: 'flight', component: FlightDetailsComponent},
  {path: 'airline', component: AirlineDetailsComponent},
  {path: 'editairline/:id', component: AirlineDetailsComponent},
  {path:'addflights',component:AddflightComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes) ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
