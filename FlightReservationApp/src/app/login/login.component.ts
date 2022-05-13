import { Component, OnInit } from '@angular/core';
import { UserService } from '../Services/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginid = '';
  password = '';
  invalidLogin = false;

  constructor(private router: Router,
    private loginservice: UserService) { }

  ngOnInit(): void {
  }

  // Check user for authenticatoin
  checkLogin() {
    if(this.loginservice.authenticate(this.loginid, this.password)) {     
        //this.redirect();
        this.router.navigate(["adminhome"]);
      
    }
    else {
      console.log("Invalid Login Credentials..");
      this.invalidLogin = true;
    }
  }

  // Redirect based on the user role
  redirect() {
   
  }

}
