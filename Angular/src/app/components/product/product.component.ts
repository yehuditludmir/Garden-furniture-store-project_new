import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../services/product.service';
import { Product } from '../../classes/Product';
import { ActivatedRoute, Router, RouterOutlet } from '@angular/router';
import { NgClass, NgForOf, NgStyle } from '@angular/common';
import { FiltersComponent } from "../filters/filters.component";
import { AfterBuyDirective } from '../../directive/after-buy.directive';
import { basket } from '../../classes/basket';
import { BasketService } from '../../services/basket.service';
import { ButtonComponent } from "../button/button.component";

@Component({
  selector: 'app-product',
  standalone: true,
  imports: [RouterOutlet, NgClass, NgStyle, FiltersComponent, AfterBuyDirective, ButtonComponent],
  templateUrl: './product.component.html',
  styleUrl: './product.component.css',
})
export class ProductComponent implements OnInit {

  ngOnInit(): void {
    //שמירת הערך שנשלח בניתוב - במשתנה מקומי
    this.activerv.params.subscribe((params)=>{
      this.fid=params['id']
    })
      this.getallP()
   
  }
  constructor(public ps:ProductService,public route:Router,public bs:BasketService,public activerv:ActivatedRoute){}
  b:basket=new basket(0,"",0,0,0,"")
fid?:number
sort(a:Array<Product>){
  const z=a.sort((a,b)=> a.Price - b.Price);

}
//שליפת המוצרים
  getallP(){
    //במקרה ולא נשלח קוד בניתוב 
    //שליפת כל המוצרים מהשרת
    if(!this.fid){
      this.ps.getAllProduct().subscribe(
       da=>{
         this.ps.allP=da
      },
      error=>{
        console.log(error);
      }
    )}

  }
  //ניתוב לפרטים נוספים
  moreDetails(p:Product){
    this.route.navigate([`./details/${p.Id}`])

  }
  
//הופסה לסל - 
  addCart(p:Product){
    //בדיקה על הכמות הקיימת בסל
    this.bs.cany(p.Id)
    //במקרה והכמות בסל עדיין לא חורגת מהכמות במלאי
    if(p.Amount-this.bs.cpqty-1>=0){
      //הוספת המחיר לחישוב בכללי של השתלום על הסל
    this.bs.totalpriceend= this.bs.totalpriceend+p.Price
    //יצירת אוביקט סל
    var bc:basket = new basket(p.Id,p.Name,p.Price,p.Price,1,p.Picture,p.Description);
    //הוספה לסל
    this.bs.addp(bc)
    //סנכרון נתונים
    this.bs.changeNumProd(1)
    }
  }

}
