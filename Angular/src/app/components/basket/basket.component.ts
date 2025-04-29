import { Component, OnInit } from '@angular/core';
import { basket } from '../../classes/basket';
import { BasketService } from '../../services/basket.service';
import { ifError } from 'assert';
import { Router, RouterLink } from '@angular/router';
import { NgClass } from '@angular/common';
import { BuyService } from '../../services/buy.service';
import { RegisterService } from '../../services/register.service';
import { ButtonComponent } from "../button/button.component";
import { IconComponent } from "../icon/icon.component";
import { ProductService } from '../../services/product.service';

@Component({
  selector: 'app-basket',
  standalone: true,
  imports: [NgClass, ButtonComponent, IconComponent],
  templateUrl: './basket.component.html',
  styleUrl: './basket.component.css'
})
export class BasketComponent implements OnInit{

  ngOnInit(): void {
    
    
  }

  constructor(public bs:BasketService,public route:Router,public buys:BuyService,
    public regs:RegisterService,public prds:ProductService
  ){}
 
  
 //בלחיצה על מינוס -הפחתה בכמות ושליחה לפונקציה שתסנכרן נתונים
  minus(n:basket){
    
    if((n.qty)>1){
       n.qty=n.qty-1  
      this.bs.changeNumProd(-1,n)
    }


  }

  //בלחיצה על פלוס 
  plus(n:basket){
    //בדיקה של הכמות הקיימת בסל ממוצר זה
    this.bs.cany(n.pid)
    //חיפוש המוצר
  var thisprod=this.prds.allP.find(x=>x.Id==n.pid)
  if (thisprod!=null){
    //בדיקה האם הכמות הרציוה קיימת במלאי
    if(thisprod.Amount-n.qty>0){
      n.qty=n.qty+1
//שליחה לסנכרון נתונים
      this.bs.changeNumProd(1,n)
}}
  }
  //מחיקת המוצר מהסל
  removefrombasket(rb:basket)
{
  var a= this.bs.sal.indexOf(rb)
  //סנכרון נתונים
  this.bs.changeNumProd(-rb.qty,rb)
  this.bs.sal.splice(a,1)
  

}
//בלחצה על תשלום
Topay(){
  // עדכון אוביקט הנשלח לשרת עם  הפרמטרים הנצרכים לעדכון הקניה
  //חוץ מהמתמש הנוכחי שיתעדכן בהמשך
  this.buys.newbuytosend.listsal=this.bs.sal
  this.buys.newbuytosend.totalpricetosend=this.bs.totalpriceend
  //ניתוב להתחברות
   this.route.navigate([`./login`]);
}

}
