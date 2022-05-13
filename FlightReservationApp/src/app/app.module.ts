import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { HttpClientModule } from '@angular/common/http';
import { AdminhomeComponent } from './adminhome/adminhome.component';
import { HeaderComponent } from './header/header.component';
import { FlightDetailsComponent } from './flight-details/flight-details.component';
import { AirlineDetailsComponent } from './airline-details/airline-details.component';
import { AuthguardService } from './Services/authguard.service';
import { AddflightComponent } from './addflight/addflight.component';
@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    AdminhomeComponent,
    HeaderComponent,
    FlightDetailsComponent,
    AirlineDetailsComponent,
    AddflightComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
 
    
  ],
  providers: [
    AuthguardService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
