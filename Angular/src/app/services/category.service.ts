import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from '../classes/Category';


@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  allCat:Array<Category>=new Array<Category>
  constructor(public server:HttpClient) { }
selectfilterCar:string=""

//פנקציה שמקבלת את מערך הקטגוריות
//פונקציית get
  getallCat():Observable<Array<Category>>{
     return this.server.get<Array<Category>>('https://localhost:7157/api/category')
  }
}
