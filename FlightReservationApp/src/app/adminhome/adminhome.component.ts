import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import {Airlinedetails} from '../model/airlinedetails.model';
import { AirlineService } from '../Services/airline.service';

@Component({
  selector: 'app-adminhome',
  templateUrl: './adminhome.component.html',
  styleUrls: ['./adminhome.component.css']
})
export class AdminhomeComponent implements OnInit {
  //airline: Airlinedetails = new Airlinedetails();
  airlineobj: any=[];

 
  constructor(private airlineService: AirlineService,private router: Router) { }

  ngOnInit() {
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
 airline(){
  this.router.navigate(["airline"]);  
 }
 flight(){
  this.router.navigate(["flight"]);  
 }
 editairline()
 {
   console.log(this.airlineobj.alId);
   this.router.navigate(['/editairline',this.airlineobj.alId]);
   debugger;
 }
 deleteairline(airlineid:string)
 {
    this.airlineService.deleteAirline(airlineid)
    .subscribe((res:any)=>
      { 
        debugger;

        this.airlineobj = res;      
        console.log(this.airlineobj);
        alert("airline deleted successfully")
        this.reloadData();
      });   
        }
}
