import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {

  eventos: any = [
    {
      EventoId: 1,
      Tema: 'Angular',
      Local: 'São Paulo'
      },
      {
       EventoId: 2,
       Tema: 'Angular',
      Local: 'Bahia'
      },
      {
         EventoId: 3,
          Tema: 'Angular',
          Local: 'MG'
      }

];
  constructor() { }

  ngOnInit() {
    
  }

}
