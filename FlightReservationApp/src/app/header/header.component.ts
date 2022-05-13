import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  username:any;
  constructor(private router: Router) { 
   // this.username:"";
  }

  ngOnInit(): void {
    this.username=sessionStorage.getItem('username');
        if(this.username!=null)
            this.username=this.username.toUpperCase();
  }
  onClick()
  {
 
  sessionStorage.setItem('token', "");
  sessionStorage.setItem('username', "");
  sessionStorage.setItem('usertype', "");
  this.router.navigate(['login']);
  }
}
