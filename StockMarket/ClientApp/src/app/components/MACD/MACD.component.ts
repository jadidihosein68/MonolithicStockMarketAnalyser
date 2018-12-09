import { Chart } from 'chart.js';
import { OnInit, Component, ViewChild } from '@angular/core';



@Component({
    selector: 'MACD-Chart',
    templateUrl: './MACD.component.html',
    })
export class MACDComponent {
    @ViewChild('lineChart') private chartRef;
    chart: any;

}
