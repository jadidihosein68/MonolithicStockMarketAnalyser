import { guppyService } from './../services/guppy.service';
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
import { FetchDataComponent } from '../services/fetch-data/fetch-data.component';
import { MACDComponent } from './MACD/MACD.component';
import { WeatherService } from '../services/Weather.service';
import { MACDService } from '../services/MACD.service';
import { ApiService } from '../services/ApiService.service';
import { Ng5SliderModule } from 'ng5-slider';
import { SideMenuComponent } from './sidebar-menu/sidebar.menu.component';
import { HeaderComponent } from './header-menu/header.component';
import { gruopChartsComponent } from './bar-chart/group.charts.component';
import { PageHeaderComponent } from './page-header/page-header.component';
import { DatePickerComponent } from './Common/Date-picker/date-picker.component';
import 'chartjs-plugin-zoom';
import { RSIService } from '../services/RSI.service';
import { RSIComponent } from './RSI/RSI.component';
import { ChartsLayoutComponent } from './Layot/Charts-Layout/charts.layout.component';
import { csvConvertorService } from '../services/csv.convertor.service';
import { SOComponent } from './stochastic-oscillator/stochastic.oscillator.component';
import { stochasticOscillatorService } from '../services/stochasticOscillator.service';
import { guppyComponent } from './guppy/guppy.component';
import { DateRangeComponent } from './Common/Date-Range/date-range.component';
import { SweetAlert2Module } from '@toverux/ngx-sweetalert2';


@NgModule({
  declarations: [
    AppComponent,
    SideMenuComponent,
    HeaderComponent,
    NavMenuComponent,
    HomeComponent,
    FetchDataComponent,
    MACDComponent,
    RSIComponent,
    gruopChartsComponent,
    PageHeaderComponent,
    DatePickerComponent,
    ChartsLayoutComponent,
    SOComponent,
    guppyComponent,
    DateRangeComponent,
    

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
      { path: 'fetch-data', component: FetchDataComponent },
    ]),
    
    SweetAlert2Module.forRoot({
      buttonsStyling: false,
      customClass: 'modal-content',
      confirmButtonClass: 'btn btn-primary',
      cancelButtonClass: 'btn'
  })
  ],
  providers: [WeatherService
    , MACDService
    , RSIService
    , ApiService
    , csvConvertorService
    , stochasticOscillatorService
    , guppyService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
