import { Component, importProvidersFrom } from '@angular/core';
import { PagamentoDetailComponent } from "./pagamento-detail/pagamento-detail.component";
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [PagamentoDetailComponent,CommonModule,RouterModule],
  templateUrl: './app.component.html',
  styles: [],

  
})
export class AppComponent {
  title = 'PagamentoApp';
}
