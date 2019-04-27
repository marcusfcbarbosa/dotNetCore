import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
//Para trabalhar com requisições HTTP
import { HttpClientModule} from '@angular/common/http';
//Para trabalhar com two-way Data Binding usando o FormsModule
import {FormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventosComponent } from './eventos/eventos.component';
import { NavComponent } from './nav/nav.component';



@NgModule({
   declarations: [
      AppComponent,
      EventosComponent,
      NavComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      HttpClientModule,
      FormsModule
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
