import { NgStyle } from '@angular/common';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ProductService } from '../../services/product.service';
import { log } from 'node:console';
import { IconComponent } from "../icon/icon.component";

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [NgStyle, IconComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {


  constructor(public route:Router,public prs:ProductService){}
  //פונקציה המעבירה לסינון עפ קטגוריה 
  //קבלת קוד הקטגוריה
sapot(num:number){
  //ניתוב לכל המוצרים עם שליחת הקוד
  this.route.navigate([`./allProduct/${num}`])
  // זימון פונקציית הסינון 
  this.prs.filterproduct(num,1000000,0).subscribe(
    d=>{
     this.prs.allP=d
     
    },
    err=>{

    }
  )
}

}
