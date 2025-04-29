import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CategoryComponent } from './components/category/category.component';
import { NavComponent } from './components/nav/nav.component';
import { ProductComponent } from './components/product/product.component';
import { FiltersComponent } from "./components/filters/filters.component";
import { CompanyComponent } from "./components/company/company.component";
import { RegisterComponent } from "./components/register/register.component";
import { BasketComponent } from './components/basket/basket.component';
import { LoginComponent } from './components/login/login.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, NavComponent, ProductComponent, CategoryComponent, FiltersComponent, CompanyComponent, RegisterComponent,BasketComponent,LoginComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Project';
}
