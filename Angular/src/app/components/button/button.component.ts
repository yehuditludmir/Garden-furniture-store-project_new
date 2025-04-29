import { Component, EventEmitter, Input, input, Output } from '@angular/core';


@Component({
  selector: 'app-button',
  standalone: true,
  imports: [],
  templateUrl: './button.component.html',
  styleUrl: './button.component.css'
})
export class ButtonComponent {
  //  יצירת מאפיינים לכפתור
  @Input() name:string="";
  @Input() icon:string|undefined
  @Input() id:string|undefined
  @Input() disable:string|undefined
//יצירת ארוע click
  @Output() newclick=new EventEmitter()

  //הפעלת הארוע שנשלח לפונקציה זו
  mimosh(){
    this.newclick.emit()
  }



}
