import { element } from 'protractor';

import { OnInit, Component, ViewChild } from '@angular/core';
import { MACDService } from '../../services/MACD.service';
import { Chart } from 'chart.js';
import { Options } from 'ng5-slider';



@Component({
    selector: 'MACD-Chart',
    templateUrl: './MACD.component.html',
    styleUrls: ['./MACD.component.scss']
})
export class MACDComponent implements OnInit {
    constructor(private MACD: MACDService) { }

    public lineChartOptions: any = {
        responsive: true
        ,
        scales: {
            xAxes: [{
                type: "time",
                time: {
                    unit: 'month',
                    tooltipFormat: 'll'
                },
                scaleLabel: {
                    display: true,
                    labelString: 'Date'
                }
            }],
            yAxes: [{
                scaleLabel: {
                    display: true,
                    labelString: 'value'
                }
            }]
        }
    };
    public lineChartColors: Array<any> = [
        {
            // grey
            backgroundColor: 'rgba(148,159,177,0.2)',
            borderColor: 'rgba(148,159,177,1)',
            pointBackgroundColor: 'rgba(148,159,177,1)',
            pointBorderColor: '#fff',
            pointHoverBackgroundColor: '#fff',
            pointHoverBorderColor: 'rgba(148,159,177,0.8)'
        },
        {
            // dark grey
            backgroundColor: 'rgba(77,83,96,0.2)',
            borderColor: 'rgba(77,83,96,1)',
            pointBackgroundColor: 'rgba(77,83,96,1)',
            pointBorderColor: '#fff',
            pointHoverBackgroundColor: '#fff',
            pointHoverBorderColor: 'rgba(77,83,96,1)'
        },
        {
            // grey
            backgroundColor: 'rgba(148,159,177,0.2)',
            borderColor: 'rgba(148,159,177,1)',
            pointBackgroundColor: 'rgba(148,159,177,1)',
            pointBorderColor: '#fff',
            pointHoverBackgroundColor: '#fff',
            pointHoverBorderColor: 'rgba(148,159,177,0.8)'
        }
    ];

    public lineChartLabels: Array<any> = [
        '01/04/2014',
        '02/04/2014',
        '03/04/2014',
        '04/04/2014',
        '05/04/2014',
        '06/04/2014',
        '07/04/2014'
    ];


    chart = [];

    public lineChartLegend: boolean;
    public lineChartType: string;

    public lineChartData: Array<any> = [
        { data: [65, 59, 80, 81, 56, 55, 40], label: 'MACD', type: 'line' },
        { data: [28, 48, 40, 19, 86, 27, 90], label: 'Histogram' },
        { data: [18, 48, 77, 9, 100, 27, 40], label: 'signal', type: 'line' }
    ];





    ngOnInit() {


        this.lineChartLegend = true;
        this.lineChartType = 'bar';

    }
    public async downloadMACD() {

        let Rowdataset = await this.MACD.getMACD();
        
        /*
        let MACD_Date = Rowdataset.map(function (elements) {
            return {
                x: elements.date,
                y: elements.macd
            }
        }
        );
*/

let MACD_Date = Rowdataset.map(x=>{ return {"x": x.date , "y":x.macd}});
let Signal_Date = Rowdataset.map(x=>{ return {"x": x.date , "y":x.signal}});

console.log({"MACD_Date": MACD_Date});

/*
        let Signal_Date = Rowdataset.map(function (elements) {
            return {
                x: elements.date,
                y: elements.signal
            }
        }
        );
  */
        let Histogram_Date = Rowdataset.map(function (elements) {
            return {
                x: elements.date,
                y: elements.histogram
            }
        }
        );
        let singledate = Rowdataset.map(x => x.date);
        let LinechartDataSet: Array<any> = [
            { data: MACD_Date, label: "MACD", type: "line" }
            , { data: Histogram_Date, label: "Histogram" }
            , { data: Signal_Date, label: "signal", type: "line" }
        ]
        this.lineChartLabels = singledate;
        this.lineChartData = LinechartDataSet;
    }


}
