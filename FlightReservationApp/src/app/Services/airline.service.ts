import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Airlinedetails } from '../model/airlinedetails.model';


@Injectable({
  providedIn: 'root'
})
export class AirlineService {

 httpHeader = {
  headers: new HttpHeaders({
  'Content-Type': 'application/json',
  'Access-Control-Allow-Origin': '*',
 // 'Authorization':'Bearer ' + sessionStorage.getItem('token'),
  }),
  };
  constructor(private httpClient:HttpClient) { }


  getAllAirline():Observable<Airlinedetails[]>{
    return this.httpClient.get<Airlinedetails[]>('http://localhost:9050/AirlineAPI/GetAirline',this.httpHeader)
    
    };
addAirline(airlinedetails: Airlinedetails): Observable<any> {
  console.log(airlinedetails);
 // console.log(this.httpHeader);
  return this.httpClient.post<Airlinedetails>('http://localhost:9050/api/AirlineAPI/AddAirline',JSON.stringify(airlinedetails),this.httpHeader);
}
UpdateAirline(airlinedetails: Airlinedetails): Observable<Object> {
  return this.httpClient.put('http://localhost:9050/api/AirlineAPI/EditAirline',JSON.stringify(airlinedetails),this.httpHeader);
}
getAirlinebyId(airportCode: string): Observable<Object> {
  return this.httpClient.get('http://localhost:9050/AirlineAPI/GetAirlineById?id='+airportCode+'');
}

deleteAirline(airportCode: string): Observable<Object> {
  return this.httpClient.delete('http://localhost:9050/api/AirlineAPI/DeleteAirline?id='+airportCode+'');
}
}
function tap(arg0: (product: any) => void): import("rxjs").OperatorFunction<Airlinedetails[], Airlinedetails[]> {
  throw new Error('Function not implemented.');
}

