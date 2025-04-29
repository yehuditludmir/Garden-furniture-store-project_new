import { Routes } from '@angular/router';
import { CategoryComponent } from './components/category/category.component';
import { DetailsComponent } from './components/details/details.component';
import { ProductComponent } from './components/product/product.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { BasketComponent } from './components/basket/basket.component';
import { PayComponent } from './components/pay/pay.component';
import { RegisterComponent } from './components/register/register.component';
import { FinalPayComponent } from './components/final-pay/final-pay.component';

export const routes: Routes = [
    {path:'home', component:HomeComponent , title:'home'},
    {path:'login', component:LoginComponent , title:'login'},
    {path:'' , component:HomeComponent},
    {path:'allCategory', component:CategoryComponent},
    {path:'allProduct/:id',component:ProductComponent,title:'productsbycategory'},
    {path:'allProduct',component:ProductComponent,title:'products'},
    {path:'details/:pId' , component:DetailsComponent},
    {path:'basket', component:BasketComponent , title:'basket'},
    {path:'pay',component:PayComponent, title:'pay'},
    {path:'register',component:RegisterComponent,title:'register'},
    {path:'login',component:LoginComponent,title:'login'},
    {path:'finalpay',component:FinalPayComponent,title:'finalpay'}


    
];
