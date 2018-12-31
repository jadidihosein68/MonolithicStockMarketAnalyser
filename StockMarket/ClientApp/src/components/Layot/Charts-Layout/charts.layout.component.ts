import { Component, OnInit, ViewChild } from '@angular/core';
import { dateRangeEventArgs } from '../../../model/interface/dateRangeEventArgs';
import { MACDComponent } from '../../../components/charts/MACD/MACD.component';
import { SOComponent } from '../../../components/charts/stochastic-oscillator/stochastic.oscillator.component';
import { RSIComponent } from '../../../components/charts/RSI/RSI.component';
import { guppyComponent } from '../../../components/charts/guppy/guppy.component';
import swal from '../../../../node_modules/sweetalert2/dist/sweetalert2.js'
import { sweetAlertService } from '../../../services/sweetAlertService.service';

@Component({
  selector: 'Chart-layout',
  templateUrl: './charts.layout.component.html',
  styleUrls: ['./charts.layout.component.scss']
})
export class ChartsLayoutComponent implements OnInit {

  constructor(private sweetAlertService:sweetAlertService) { }
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
    swal({
      title: 'Generate Charts'
      ,text: 'Calculate MACD'
      ,footer: `3 more calculation left`
 });
 swal.enableLoading();
 await this.primaryMACDComponent.getMACDOnline();
 swal({
  title: 'Generate Charts'
  ,text: 'Calculate RSI'
  ,footer: `2 more calculation left`
});
swal.enableLoading();
await this.primaryRSIComponent.getRSIOnline();

swal({
  title: 'Generate Charts'
  ,text: 'Calculate SO'
  ,footer: `1 more calculation left`
});

swal.enableLoading();
await this.primarySOComponent.getSOOnline();


swal({
  title: 'Generate Charts'
  ,text: 'Calculate Guppy'
  ,footer: `We are almost there !`
});
swal.enableLoading();
await this.primaryguppyComponent.getGuppyOnline();

 swal.close();
/*
    await this.primaryMACDComponent.getMACDOnline();
    await this.primaryRSIComponent.getRSIOnline();
    await this.primarySOComponent.getSOOnline();
    await this.primaryguppyComponent.getGuppyOnline();
*/


  }

}
