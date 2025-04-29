import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../../services/category.service';
import { Category } from '../../classes/Category';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-category',
  standalone: true,
  imports: [],
  templateUrl: './category.component.html',
  styleUrl: './category.component.css'
})
export class CategoryComponent implements OnInit {
  
  ngOnInit(): void {
    //הפעלת הפונקציה מיד בעת הגישה לקומפוננטה
  this.get()
  }
  count:number=0
  
  constructor(public cs:CategoryService,public ar: ActivatedRoute){}
  
  //פונקציה שמקבלת מהשרת את כל הקטגוריות השמורות במערכת
   get(){
    this.cs.getallCat().subscribe(
      d=>{
        this.cs.allCat=d
        
      },
      err=>{
        console.log(err);
        
      }
    )
   }
   
   selectCategory(id:string){
    this.cs.selectfilterCar=id
   
   }
  
}
