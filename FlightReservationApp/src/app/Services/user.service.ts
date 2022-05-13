import { Injectable } from '@angular/core';
import { HttpHeaders,HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private httpHeaders = new HttpHeaders({
	
		'Content-Type' : 'application/json',
    'Access-Control-Allow-Origin':'*',
    'Access-Control-Allow-Methods':'GET,POST,PUT,DELETE'
	});
	
  constructor(private httpClient: HttpClient) { }
  authenticate(LoginId: any, password: any) {

    return this.httpClient.get<any>('http://localhost:9050/api/FlightAPI/Login?LoginId='+LoginId+'&Password='+password,
    ).subscribe(
      userData => {
        console.log(userData);
        sessionStorage.setItem('username', userData[1]);
        let tokenStr = 'Bearer' + userData[0];
        sessionStorage.setItem('token', tokenStr);
        sessionStorage.setItem('usertype',userData[2]);
        return userData;
      }
    );
  }
 
  // Removes user session(logout)
  logOut() {
    sessionStorage.removeItem('username');
  }

  isUserLoggedIn():boolean {
    let user = sessionStorage.getItem('username')
    return !(user === null)
  }
}



