import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { environment } from '../../environments/environment';
import { PagamentoDetail } from './pagamento-detail.model';
import { trigger } from '@angular/animations';
import { CommonModule } from '@angular/common';
import { FormsModule,NgForm } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})

export class PagamentoDetailService {

  url: string = environment.apiBaseUrl + '/PagamentoDetail'
  list: PagamentoDetail[] = [];
  formData : PagamentoDetail = new PagamentoDetail()
  formSubmitted: boolean = false
  constructor(private http: HttpClient) { } //agora tem que especificar qual o modulo
  
  refreshList(){
    this.http.get(this.url)
    .subscribe({
      next: res => {
       this.list = res as PagamentoDetail[]
      },
      error : err => {console.log(err)}
    })
  }
  postPagamentoDetail(){
    return this.http.post(this.url,this.formData)
  }

  putPagamentoDetail(){
    return this.http.put(this.url +'/'+ this.formData.pagamentoDetailId,this.formData)
  }  
  
  resetForm(form:NgForm){
    form.form.reset()
    this.formData = new PagamentoDetail()
    this.formSubmitted = false

  }  
}

