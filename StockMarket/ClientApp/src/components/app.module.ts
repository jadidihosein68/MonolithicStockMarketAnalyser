import { Chart } from 'chart.js';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import {ChartsModule} from 'ng2-charts/ng2-charts';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
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
import { SideMenuComponent } from './sidebar-menu/sidebar.menu.component';
import { HeaderComponent } from './header-menu/header.component';
import { gruopChartsComponent } from './bar-chart/group.charts.component';
import { PageHeaderComponent } from './page-header/page-header.component';


@NgModule({
  declarations: [
    AppComponent,
    SideMenuComponent,
    HeaderComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    MACDComponent,
    WeatherComponent,
    ChartsComponent,
    RangeSliderComponent,
    gruopChartsComponent,
    PageHeaderComponent

    

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ChartsModule,
    NgbModule,
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
