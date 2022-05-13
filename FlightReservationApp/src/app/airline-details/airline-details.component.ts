import { Component, Input, OnInit } from '@angular/core';
import {Airlinedetails} from '../model/airlinedetails.model';
import { AirlineService } from '../Services/airline.service';
import { ActivatedRoute, Router } from '@angular/router';
//import {NgForm} from '@angular/forms'

@Component({
  selector: 'app-airline-details',
  templateUrl: './airline-details.component.html',
  styleUrls: ['./airline-details.component.css']
})
export class AirlineDetailsComponent implements OnInit {
 // newairline!: NgForm;
 airline: Airlinedetails = new Airlinedetails();
  id:any;
 // submitted=false;
  constructor(private airlineService: AirlineService,private router: Router,
    private route:ActivatedRoute) { }

  ngOnInit(): void {
    console.log(this.router.url);
    if(this.router.url != '/airline')
    {
    this.route.paramMap.subscribe(parametermap=>
      {
         this.id = parametermap.get('id');
        console.log(this.id);
        this.getairline(this.id !== null ? this.id : "");
      });
    }
  }
   getairline(id:string)
  {
    if(id ==null)
    {
      alId: null;
      alName: null;
      alLogo: null;
      alCustCareNo: 0;		
      alAddr1: null;
        alCity: null; 
        alState: null;
        alEmail: null;
        alIsBlocked: false;
    }
    else{

    this.airlineService.getAirlinebyId(id)
    .subscribe((data:any) =>{
      console.log(data);
        this.airline = data;
    });
    }
     
  }
  onSubmit() {
   // debugger;
  //  this.submitted = true;
  if(this.id != null) 
  {
      this.airlineService.UpdateAirline(this.airline)
      .subscribe(data=>{
        console.log(data);
        alert("Airline Updated Sucessfully");
       // this.newairline.resetForm(this.airline);
       this.router.navigate(["adminhome"]);
      }, error =>{ 
        console.log(error)
       alert('Unable to update airline')
      });
  } 
  else
  {
    console.log(this.airline);
    this.airlineService.addAirline(this.airline)
    .subscribe(data =>{
      console.log(data)
      alert("Airline added sucessfully")
     // this.newairline.resetForm(this.airline);
     this.router.navigate(["adminhome"]);
    } , 
    error =>{ 
      console.log(error)
     alert('Unable to Add airline')
    });
  }
    
    
  }
  onBack(){
    this.router.navigate(["airline"]);  
  }
 
}
