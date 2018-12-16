import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'Chart-layout',
  templateUrl: './charts.layout.component.html',
  styleUrls: ['./charts.layout.component.scss']
})
export class ChartsLayoutComponent implements OnInit {

  constructor() { }
  
  coinwallet: string[] = ['MACD','RSI' , 'SO' , 'Guppy'];
  selectedwallet = this.coinwallet[0];

  ngOnInit() {
  }

}
