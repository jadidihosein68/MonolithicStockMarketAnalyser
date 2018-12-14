import { Chart } from 'chart.js';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import {ChartsModule} from 'ng2-charts/ng2-charts';

import { HomeComponent } from './home/home.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from '../services/fetch-data/fetch-data.component';
import { MACDComponent } from './MACD/MACD.component';
import { WeatherComponent } from './Weather/Weather.component';
import { WeatherService } from '../services/Weather.service';
import { MACDService } from '../services/MACD.service';
import { ApiService } from '../services/ApiService.service';
import { ChartsComponent } from './Chart/charts.component';
import { RangeSliderComponent } from './DynamicOptionsSlider/dynamic-options-slider.component';
import { Ng5SliderModule } from 'ng5-slider';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    MACDComponent,
    WeatherComponent,
    ChartsComponent,
    RangeSliderComponent,
    

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ChartsModule,
    Ng5SliderModule,
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
