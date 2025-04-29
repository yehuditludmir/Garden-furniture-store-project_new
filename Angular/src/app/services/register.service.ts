import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../classes/User';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {

  constructor(public server:HttpClient) { }
  
currentUser:string=""

//הוספת לקוח
//מקבל מספר - הצלחה - 1 כישלון - 0
//פונקציית post 
  adduser(user:User):Observable<number>{
    
    return this.server.post<number>('https://localhost:7157/api/user',user)
  }
//פונקצייה מחזירה ערך בוליאני
//פונקצית get
//שולחת את האימיל בניתוב
  login(email:string){
    return this.server.get<boolean>(`https://localhost:7157/byemail?email=${email}`)
  }
}
