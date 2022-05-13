import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Flightdetails } from '../model/flightdetails.model';
import { AirlineService } from '../Services/airline.service';
import { FlightService } from '../Services/flight.service';

@Component({
  selector: 'app-addflight',
  templateUrl: './addflight.component.html',
  styleUrls: ['./addflight.component.css']
})
export class AddflightComponent implements OnInit {
  airlineobj: any=[];
  flightobj: Flightdetails = new Flightdetails();
  constructor(private airlineService: AirlineService,private router: Router,private flightservice: FlightService) { }

  ngOnInit(): void {
    this.reloadData();
  }
  reloadData() {
    this.airlineService.getAllAirline()
    .subscribe((res:any)=>
      { 
        debugger;

        this.airlineobj = res;      
        console.log(this.airlineobj);
      });   
        }
        onSubmit() {
          console.log(this.flightobj);
    this.flightservice.addflight(this.flightobj)
    .subscribe(data =>{
      console.log(data)
      alert("flight added sucessfully")
     // this.newairline.resetForm(this.airline);
    } , 
    error =>{ 
      console.log(error)
     alert('Unable to Add flight')
    });
        }
}
