import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TouchSequence } from 'selenium-webdriver';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {

  eventos: any;
  constructor(private http: HttpClient) { 
  }
  
  getEventos(){
    this.http.get('http://localhost:5001/api/values').subscribe(response => {
      this.eventos = response;
    }, error =>{
      console.log(error);
    }
    );
  }

  

  ngOnInit() {
    
  }

}
