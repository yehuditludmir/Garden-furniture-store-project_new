import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BuyService } from '../../services/buy.service';
import { buy } from '../../classes/buy';
import { Router } from '@angular/router';

@Component({
  selector: 'app-pay',
  standalone: true,
  imports: [],
  templateUrl: './pay.component.html',
  styleUrl: './pay.component.css'
})
export class PayComponent implements OnInit{
ngOnInit(): void {
    //הפעלת הפונקציה מיד בעת הגישה לקומפוננטה
  this.getbuy()
}
constructor(public buys:BuyService,public route:Router){}

//קבלת אוביקט הקניה שנשמר בשרת
getbuy(){
  this.buys.addbuy().subscribe(
    d=>{
      if(d!=null){
        this.buys.displaybuy=d
      }
      
      
  },
err=>{
  console.log("שגיאה");
  
})
}
//הפנייה לקבלה
movetofinalpay(){
  this.route.navigate(['./finalpay']);

}

}
