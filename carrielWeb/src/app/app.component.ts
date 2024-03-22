import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CabecalhoComponent } from "./componentes/cabecalho/cabecalho.component";
import { CadLogComponent } from "./componentes/cad-log/cad-log.component";

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [RouterOutlet, CabecalhoComponent, CadLogComponent]
})
export class AppComponent {
  title = 'carrielWeb';
}
