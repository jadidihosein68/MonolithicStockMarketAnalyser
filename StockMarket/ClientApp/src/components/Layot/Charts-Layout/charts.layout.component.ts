import { Component, OnInit, ViewChild } from '@angular/core';
import { dateRangeEventArgs } from '../../../model/interface/dateRangeEventArgs';
import { MACDComponent } from '../../../components/MACD/MACD.component';
import { SOComponent } from '../../../components/stochastic-oscillator/stochastic.oscillator.component';
import { RSIComponent } from '../../../components/RSI/RSI.component';
import { guppyComponent } from '../../../components/guppy/guppy.component';

@Component({
  selector: 'Chart-layout',
  templateUrl: './charts.layout.component.html',
  styleUrls: ['./charts.layout.component.scss']
})
export class ChartsLayoutComponent implements OnInit {

  constructor() { }
  fromDate: any;
  toDate: any;
  coinwallet: string[] = ['MACD', 'RSI', 'SO', 'Guppy'];
  selectedwallet = this.coinwallet[0];

  @ViewChild(MACDComponent) primaryMACDComponent: MACDComponent;
  @ViewChild(SOComponent) primarySOComponent: SOComponent;
  @ViewChild(RSIComponent) primaryRSIComponent: RSIComponent;
  @ViewChild(guppyComponent) primaryguppyComponent: guppyComponent;

  ngOnInit() {
  }
  
  async onDateChange(dateRange: dateRangeEventArgs) {
    console.log({ dateRange: dateRange });
    this.fromDate = dateRange.fromdate;
    this.toDate = dateRange.toDate;
    await this.primaryMACDComponent.getMACDOnline();
    await this.primaryRSIComponent.getRSIOnline();
    await this.primarySOComponent.getSOOnline();
    await this.primaryguppyComponent.getGuppyOnline();
  }

}
