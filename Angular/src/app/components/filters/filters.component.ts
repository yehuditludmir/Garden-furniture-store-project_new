import { Component, NgModule } from '@angular/core';
import { CompanyComponent } from "../company/company.component";
import { CompanyService } from '../../services/company.service';
import { CategoryComponent } from "../category/category.component";
import { CategoryService } from '../../services/category.service';
import { ProductService } from '../../services/product.service';
import { Product } from '../../classes/Product';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-filters',
  standalone: true,
  imports: [FormsModule, CategoryComponent, CompanyComponent],
  templateUrl: './filters.component.html',
  styleUrl: './filters.component.css'
})
export class FiltersComponent {
constructor (public coms:CompanyService,public cats:CategoryService,public ps:ProductService,public route:Router){}
price:number=0
p:Product=new Product(0,"",0,0,0,0,"",new Date(),"","","")
filterprodarr:Array<Product>=new Array<Product>
selectprice(){
 

}
//שליחת הפרמטרים הרצויים לסינון לפונקציה הנמצאת בשרת
save(){
this.ps.filterproduct(this.p.CategoryId,this.p.Price,this.p.CompanyId).subscribe(
  d=>{
    this.ps.allP=d
    this.route.navigate(['allProduct/:id'])
  },
  err=>{
    console.log(err);
    
  }
 )

}

//מיון ממחיר נמוך לגבוה
sortsmall(){
  this.ps.allP=this.ps.allP.sort((a,b)=> a.Price - b.Price);
}
//מיון ממחיר גבוה לנמוך
sortbig(){
  this.ps.allP=this.ps.allP.sort((a,b)=> b.Price - a.Price);
}

}
