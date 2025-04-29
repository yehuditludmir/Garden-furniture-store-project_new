import { Component } from '@angular/core';
import { ProductService } from '../../services/product.service';
import { ActivatedRoute } from '@angular/router';
import { Product } from '../../classes/Product';
import { Location, NgClass } from '@angular/common';
import { BasketService } from '../../services/basket.service';
import { basket } from '../../classes/basket';
import { IconComponent } from "../icon/icon.component";
@Component({
  selector: 'app-details',
  standalone: true,
  imports: [IconComponent],
  templateUrl: './details.component.html',
  styleUrl: './details.component.css'
})
export class DetailsComponent {
  //משתנים מקומיים
num:number=1 
id:number =0
public curruntProd:Product=new Product(0,"",0,0,0,0,"",new Date,"","","");

  constructor(public ps:ProductService , public ar:ActivatedRoute , public l:Location
    ,public bs:BasketService
  ){
    //עדכון משתנה מקומי ב 
    //id של המוצר הנוכחי שהתקבל בניתוב
    ar.params.subscribe(
      d=>{
        this.id = d['pId']

        
      },
      err=>{
        console.log(err);
        
      }
    )
    //מציאת המוצר הנוכחי
   let prod=this.ps.allP.find(x=>x.Id==this.id)
   if(prod)
    this.curruntProd=prod

  }
//אופציה לחזרה אחורה
  back(){
    this.l.back()
  }
  //הפחתה מהכמות
  minusd(n:number){
    if(n>0)
       this.num=n-1
  }
  //הוספה במקרה ויש כמות במלאי - בסינכרון עם הכמות ששמורה בסל - 
  //כלומר - שיחד לא יחרגו מהכמות במלאי
  //פה מדובר לגבי תצוגת המספר
  plusd(n:number){
    if(this.curruntProd.Amount-this.bs.cpqty-n>0)
     this.num=n+1
  }
  //הוספה לסל
  addtobasket(p:Product){
    this.bs.cany(p.Id)
    //במקרה והכמות הנדרשת תקינה
    if(p.Amount-this.bs.cpqty-1>=0 && this.num>0){
      // חישוב העלות הכוללת
    var total = this.num*p.Price
    //הוספה לסכום הכללי של הסל
    this.bs.totalpriceend= this.bs.totalpriceend+total
    //יצירת מופע מסוג סל
    var bc:basket = new basket(p.Id,p.Name,total,p.Price,this.num,p.Picture,p.Description);
    //הוספה לסל 
    // if(this.num>0){
       this.bs.addp(bc)
       //סינכרון
       this.bs.changeNumProd(this.num)
    // }
  }
  }
}
