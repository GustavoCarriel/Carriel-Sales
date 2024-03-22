import { Component } from '@angular/core';
import { InputMaskModule } from 'primeng/inputmask';


@Component({
  selector: 'app-cad-log',
  standalone: true,
  imports: [
    InputMaskModule,
  ],
  templateUrl: './cad-log.component.html',
  styleUrl: './cad-log.component.scss'
})
export class CadLogComponent {
  isLoginFormVisible = true;

  toggleForm() {
    this.isLoginFormVisible = !this.isLoginFormVisible;
  }
}
