
import { Component, EventEmitter, Input, input, Output } from '@angular/core';
@Component({
  selector: 'app-icon',
  standalone: true,
  imports: [],
  templateUrl: './icon.component.html',
  styleUrl: './icon.component.css'
})
export class IconComponent {
  //מאפיינים לקומפוננת איקון
  //(ללא כפתור)
  @Input() name:string="";
  @Input() icon:string|undefined
  @Input() id:string|undefined

  //ארוע
  @Output() newclick1=new EventEmitter()

  mimosh(){
    this.newclick1.emit()
  }

}
