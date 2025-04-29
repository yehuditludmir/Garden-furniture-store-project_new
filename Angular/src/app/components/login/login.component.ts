import { Component } from '@angular/core';
import { RegisterService } from '../../services/register.service';
import { login } from '../../classes/login';
import swal from 'sweetalert2'; 

import { RouterLink, RouterOutlet,Router } from '@angular/router';
import { FormsModule } from '@angular/forms';
import Swal from 'sweetalert2';
import { log } from 'node:console';
import { BuyService } from '../../services/buy.service';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [RouterLink,RouterOutlet,FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

constructor(public rs:RegisterService,public route:Router,public buys:BuyService){}
user:login=new login("","")
  
//התחברות
  loginl(){
    //שליחה לפונקציה בשרת המקבלת אימייל
    //(אימיל - מאפיין יחודי)
    this.rs.login(this.user.email).subscribe(
      d=>{
        if(d==true){
          //עדכון קונה נוכחי
          this.rs.currentUser=this.user.email
          //עדכון המשתמש באויקט שנלח לשרת - לבצע קנייה
          this.buys.newbuytosend.useremail=this.user.email
          //הפניה לתשלום
          this.route.navigate([`./pay`])}
       
          else{
            //במקרה ואינו שמור במערכת הפניה לרישום
        swal.fire('עליך להרשם תחילה')
          this.route.navigate([`./register`])
        }
      },
      err=>{
        console.log("שגיאה"); 
       
      }
    )

  }
  //הפנייה להרשמה
  toregister(){
    this.route.navigate([`./register`]);
  }

}
