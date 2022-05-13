import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Flightdetails } from '../model/flightdetails.model';
import { FlightService } from '../Services/flight.service';

@Component({
  selector: 'app-flight-details',
  templateUrl: './flight-details.component.html',
  styleUrls: ['./flight-details.component.css']
})
export class FlightDetailsComponent implements OnInit {
  flightobj: any=[];
  constructor(private flightService: FlightService,private router: Router) { }

  ngOnInit(): void {
    this.reloadData();
  }
  reloadData() {
    this.flightService.getAllflight()
    .subscribe((res:any)=>
      { 
        debugger;

        this.flightobj = res;      
        console.log(this.flightobj);
      });   
        }
 airline(){
  this.router.navigate(["airline"]);  
 }
 flight(){
  this.router.navigate(["flight"]);  
 }
 addFlight()
 {
  this.router.navigate(["addflights"]);  
 }
}
