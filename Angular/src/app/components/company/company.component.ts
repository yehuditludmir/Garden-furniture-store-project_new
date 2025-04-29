import { Component, OnInit } from '@angular/core';
import { CompanyService } from '../../services/company.service';
import { Company } from '../../classes/Company';

@Component({
  selector: 'app-company',
  standalone: true,
  imports: [],
  templateUrl: './company.component.html',
  styleUrl: './company.component.css'
})
export class CompanyComponent implements OnInit{

  ngOnInit(): void {
      //הפעלת הפונקציה מיד בעת הגישה לקומפוננטה
    this.getallComp()
  }
  constructor(public coms:CompanyService){}

  //פונקציה שמקבלת מהשרת את כל החברות השמורות במערכת
  getallComp(){
    this.coms.getallComps().subscribe(
      d=>{
        this.coms.allCompany=d
      },
      err=>{
        console.log(err);
        }

    )
  }
  
  
  

  

}
