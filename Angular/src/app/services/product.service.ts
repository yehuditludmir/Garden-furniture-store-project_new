import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../classes/Product';
import { log } from 'util';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(public server:HttpClient) { }
  //משתנים ב
  //service
  // - אפשר לגשת אליהם מכל הקומוננטות
  allP:Array<Product>=new Array<Product>
  allPf:Array<Product>=new Array<Product>
  
  //שליפת כל המוצרים
  getAllProduct():Observable<Array<Product>>{
    return this.server.get<Array<Product>>('https://localhost:7157/api/product')

  }
//שליפה עפ סינון שנשלח בstring query
filterproduct(cat:number,price:number,com:number):Observable<Array<Product>>{
  const params = new HttpParams()
                    .set('ID', cat)
                    .set('price', price)
                    .set('cid', com);


  return this.server.get<Array<Product>>('https://localhost:7157/api/product/filters',{params} );
}
}
