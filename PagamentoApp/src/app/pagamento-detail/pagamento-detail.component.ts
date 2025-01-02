import { Component, OnInit } from '@angular/core';
import { PagamentoDetailFormComponent } from "./pagamento-detail-form/pagamento-detail-form.component";
import { PagamentoDetailService } from '../shared/pagamento-detail.service';
import { CommonModule } from '@angular/common';
import { provideAnimations } from '@angular/platform-browser/animations';
import{provideToastr} from 'ngx-toastr';
import { PagamentoDetail } from '../shared/pagamento-detail.model';


@Component({
  selector: 'app-pagamento-detail',
  imports: [PagamentoDetailFormComponent,CommonModule],
  templateUrl: './pagamento-detail.component.html',
  styles: ``
})
export class PagamentoDetailComponent  implements OnInit{

  constructor(public service: PagamentoDetailService){

  }

  ngOnInit(): void {
    this.service.refreshList()
  }
  populateForm(selectedRecord: PagamentoDetail){
      this.service.formData = Object.assign({},selectedRecord);

  }
}
