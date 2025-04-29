import { Directive, ElementRef, HostListener } from '@angular/core';
import bodyParser from 'body-parser';

@Directive({
  selector: '[appAfterBuy]',
  standalone: true
})
export class AfterBuyDirective {

  constructor(private el: ElementRef) { }
//בלחצה על הכפתור נשלח לפונקציה צבע
  @HostListener('click') onMouseEnter() {
    this.buttonbuy('yellow');
  }
 //מקבלת צבע והופכת את רקע הכפתור לצבע זה
  private buttonbuy(color: string) {
    this.el.nativeElement.style.backgroundColor = color;

  }
}
