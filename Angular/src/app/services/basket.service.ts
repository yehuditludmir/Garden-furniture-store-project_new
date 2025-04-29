import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from '../classes/Product';
import { basket } from '../classes/basket';

@Injectable({
  providedIn: 'root'
})
export class BasketService {

  constructor(public server:HttpClient) { }
orechsal:number=0 
totalpriceend:number=0
sal:Array<basket>=new Array<basket>()
cp:basket=new basket(0,"",0,0,0)
cp1=""
cpqty:number=0

//בדיקה על הכמות הנמצאת בסל עבור קוד המוצר שנשלח
cany(pid:number){
  var qq= this.sal.find(x=>x.pid==pid)
   if(!qq)
     this.cpqty=0
   else
     this.cpqty=qq.qty 
}
//הוספה לסל
//מקבל אוביקט מסוג סל
addp(b:basket){
  //מחפש אם קיים כבר כזה אוביקט בסל
  var isInArray = this.sal.find(x=>x.pid ==b.pid);
  //אם לא - מוסיף למערך המצורים בסל מוצר זה
  if(!isInArray){
    this.sal.push(b)
  }
  //במקרה קיים
  else{
    //משנה את המחיר בכולל למוצר זה
    isInArray.totalprice=isInArray.totalprice+b.pprice*b.qty
    //משנה את הכמות
    isInArray.qty=isInArray.qty+b.qty
    
  }
}

//סנכרון נתונים בעת שמתבצע שינוי בסל
changeNumProd(num:number ,bas?:basket){
  this.orechsal=this.orechsal+num
  if(bas!=null){
  if(num<0){
     bas.totalprice=bas.totalprice-bas.pprice
     this.totalpriceend=this.totalpriceend-(bas.pprice*-num)
  }
  else{
     bas.totalprice=bas.totalprice+bas.pprice
     this.totalpriceend=this.totalpriceend+(bas.pprice*num)
}}



}

total(n1:number , n2:number){

}



}
