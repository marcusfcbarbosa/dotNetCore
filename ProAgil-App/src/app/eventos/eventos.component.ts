import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {

  eventos: any = [];
  imagemLargura: number = 50;
  imagemMargem: number = 2;
  mostrarImagem: boolean = false;
  filtroLista ="";
  
  constructor(private http: HttpClient) {   }

  ngOnInit() {
    this.getEventos();
  }

    alternarImagem(){
      this.mostrarImagem= !this.mostrarImagem;
    }
  getEventos(){
     this.http.get('http://localhost:5001/api/values').subscribe(
      response => {
        this.eventos = response;
      }, error =>{
        console.log(error);
      }
     );
  }
}
