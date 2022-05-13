import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Flightdetails } from '../model/flightdetails.model';

@Injectable({
  providedIn: 'root'
})
export class FlightService {

  httpHeader = {
    headers: new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*',
   // 'Authorization':'Bearer ' + sessionStorage.getItem('token'),
    }),
    };
  constructor(private httpClient:HttpClient) { }

  getAllflight():Observable<Flightdetails[]>{
    return this.httpClient.get<Flightdetails[]>('http://localhost:9050/api/FlightAPI/GetFlightDetails',this.httpHeader)
    
    };
addflight(flightdetails: Flightdetails): Observable<any> {
  console.log(flightdetails);
 // console.log(this.httpHeader);
  return this.httpClient.post<Flightdetails>('http://localhost:5000/api/FlightAPI/AddFlight',JSON.stringify(flightdetails),this.httpHeader);
}
}
