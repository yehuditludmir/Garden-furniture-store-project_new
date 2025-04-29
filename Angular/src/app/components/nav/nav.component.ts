import { Component } from '@angular/core';
import { CategoryComponent } from '../category/category.component';
import { Route, Router, RouterLink, RouterOutlet } from '@angular/router';
import { ProductService } from '../../services/product.service';
import { BasketService } from '../../services/basket.service';

@Component({
  selector: 'app-nav',
  standalone: true,
  imports: [CategoryComponent,RouterLink,RouterOutlet],
  templateUrl: './nav.component.html',
  styleUrl: './nav.component.css'
})
export class NavComponent {
constructor(public route:Router ,public ps:ProductService,public bs:BasketService){}
  homef(){

  }
  //הפניות לקומפוננטות ע"פ השמות שניתנו להם
  //בapp.routes
  allCategoryf(){
     this.route.navigate([`./allCategory`])

  }
  allProductf(){
    
    this.route.navigate([`./allProduct`])
  }
  mybasket(){
    this.route.navigate([`./basket`])
  }
  
}
