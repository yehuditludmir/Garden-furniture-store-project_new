import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { buy } from '../classes/buy';
import { tosend } from '../classes/tosend';
import { basket } from '../classes/basket';

@Injectable({
  providedIn: 'root'
})
export class BuyService {

  constructor(public server:HttpClient) { }
  newwors:string=""

  newbuytosend:tosend=new tosend(new Array<basket>,"",0)
  displaybuy:buy=new buy(0,new Date,0,false,0,"","")

  //הוספת קניה
  //מקבל מהשרת אוביקט קניה
  //פונקצית post
  addbuy():Observable<buy>{
    
    return this.server.post<buy>('https://localhost:7157/api/buy',this.newbuytosend)
  }
//אישר תשלום
//מקבל מספר - הצלחה - 1 כישלון - 0
//פונקציית get 
//ששולחת בניתוב את קוד הקניה
  confirmBuy():Observable<number>{

    return this.server.get<number>(`https://localhost:7157/id?id=${this.displaybuy.Id}`)
  }
}
