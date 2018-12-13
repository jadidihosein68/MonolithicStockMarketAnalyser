import { Chart } from 'chart.js';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';


import { HomeComponent } from './home/home.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from '../services/fetch-data/fetch-data.component';
import { MACDComponent } from './MACD/MACD.component';
import { WeatherComponent } from './Weather/Weather.component';
import { WeatherService } from '../services/Weather.service';
import { MACDService } from '../services/MACD.service';
import { ApiService } from '../services/ApiService.service';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    MACDComponent,
    WeatherComponent,

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ])
  ],
  providers: [WeatherService
    , MACDService
    , ApiService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
