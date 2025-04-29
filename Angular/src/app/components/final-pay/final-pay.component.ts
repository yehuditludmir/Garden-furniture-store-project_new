import { Component, OnInit } from '@angular/core';
import { BuyService } from '../../services/buy.service';
import swal from 'sweetalert2'; 
import { basket } from '../../classes/basket';
import { BasketService } from '../../services/basket.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-final-pay',
  standalone: true,
  imports: [DatePipe],
  templateUrl: './final-pay.component.html',
  styleUrl: './final-pay.component.css'
})
export class FinalPayComponent implements OnInit{
  ngOnInit(): void {
    this.confirmtobuy()
      
  }
constructor(public buys:BuyService,public bas:BasketService){}

isgood:boolean=false

//אישור בשרת שהקניה שולמה במקרה והעדכון לא צלח הודעת שגיאה למשתשמש
confirmtobuy(){
  this.buys.confirmBuy().subscribe(
    d=>{
      if(d==1){
        this.isgood=true
      }
    },
    err=>{
      swal.fire('ארעה תקלה במהלך התשלום יש לנסות שנית ')
    }
  )
}


}
