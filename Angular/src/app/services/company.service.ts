import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Company } from '../classes/Company';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  constructor(public server:HttpClient) { }
  allCompany:Array<Company>=new Array<Company>
  selectfilter:number=0

 //פונקציה שמקבל את מערך החברות
 //פונקציית get 
getallComps():Observable<Array<Company>>{
 
    return this.server.get<Array<Company>>('https://localhost:7157/api/company')

  }
}
