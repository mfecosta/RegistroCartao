import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { PagamentoDetailService } from '../../shared/pagamento-detail.service';
import { FormsModule, NgForm } from '@angular/forms';
import { PagamentoDetail } from '../../shared/pagamento-detail.model';
import { provideAnimations } from '@angular/platform-browser/animations';
import {provideToastr, ToastrService} from 'ngx-toastr'


@Component({
  selector: 'app-pagamento-detail-form',
  imports: [FormsModule],
  templateUrl: './pagamento-detail-form.component.html',
  styles: ``
})
export class PagamentoDetailFormComponent {

constructor(public service: PagamentoDetailService, private toastr : ToastrService)
{ 

}

onSumbit(form:NgForm){
  // this.service.formSubmitted = true
  // if(form.invalid){

     this.service.postPagamentoDetail()
     .subscribe({
       next: res =>{ 
     this.service.list = res as PagamentoDetail[]
     this.service.resetForm(form)
     this.toastr.success('Inserido com sucesso','Verifique')
   },
   error: err =>  {console.log(err)}    
   })   
  // if (this.service.formData.pagamentoDetailId != 0) 
  //   this.insertRecord(form)
  //    else
  //    this.updateRecord(form)
  }

  
// insertRecord(form:NgForm){

// this.service.postPagamentoDetail()
// .subscribe({
//     next: res =>{ 
//    this.service.list = res as PagamentoDetail[]
//    this.service.resetForm(form)
//    this.toastr.success('Inserido com sucesso','Verifique')
//  },
//  error: err =>  {console.log(err)}    
//  })
//  }
//  updateRecord(form:NgForm){  

//    this.service.putPagamentoDetail()
//    .subscribe({
//      next: res =>{ 
//    this.service.list = res as PagamentoDetail[]
//    this.service.resetForm(form)
//    this.toastr.info('Inserido com sucesso','Verifique')
//  },
//  error: err =>  {console.log(err)}    
//  })
// }

}

  


