import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RegisterService } from '../../services/register.service';
import { User } from '../../classes/User';
import swal from 'sweetalert2'; 
import { Router } from '@angular/router';
import { BuyService } from '../../services/buy.service';
@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

  constructor(public us:RegisterService,public route:Router,public buys:BuyService){

  }
  user:User=new User("","",new Date,"")
  // הוספת משתמש - הרשמה
  addresiuser(){
//הוספה בשרת
    return this.us.adduser(this.user).subscribe(
      d=>{
        if(d==1){
          this.us.currentUser=this.user.Email
          swal.fire("נרשמת בהצלחה")
          //עדכון הקונה הנוכחי בקניה שנשלחת לשרת
          this.buys.newbuytosend.useremail=this.user.Email
          this.route.navigate([`./pay`]);

        }

      },
      err=>{
        console.log("err");
        swal.fire("יש תקלה בהזנת הפרטים יש לנסות שוב")

      }

    )
  }
  
}
