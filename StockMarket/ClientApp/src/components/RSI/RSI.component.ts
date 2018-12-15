import { RSI } from './../../model/interface/RSI';
import { element } from 'protractor';

import { OnInit, Component, ViewChild } from '@angular/core';
import { RSIService } from '../../services/RSI.service';

@Component({
    selector: 'RSI-Chart',
    templateUrl: './RSI.component.html',
    styleUrls: ['./RSI.component.scss']
})
export class RSIComponent implements OnInit {
    constructor(private RSI: RSIService) { }

    fromDate: any;
    toDate: any;

    public lineChartOptions: any = {
        responsive: true
        ,
        scales: {
            xAxes: [{
                type: "time"
                /*
                 ,time: {
                     unit: 'month',
                     tooltipFormat: 'll'
                 }
                 */
                , scaleLabel: {
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




        ,pan: {
            // Boolean to enable panning
            enabled: true,

            // Panning directions. Remove the appropriate direction to disable 
            // Eg. 'y' would only allow panning in the y direction
            mode: 'xy'
        },

        // Container for zoom options
        zoom: {
            // Boolean to enable zooming
            enabled: true,

            // Zooming directions. Remove the appropriate direction to disable 
            // Eg. 'y' would only allow zooming in the y direction
            mode: 'xy',
        }






    };
    public lineChartColors: Array<any> = [
        {
            // grey
            // backgroundColor: 'rgba(148,159,177,0.2)',
            borderColor: 'rgba(238, 56, 56,1)', // MACD
            // pointBackgroundColor: 'rgba(148,159,177,1)',
            // pointBorderColor: '#fff',
            // pointHoverBackgroundColor: '#fff',
            // pointHoverBorderColor: 'rgba(148,159,177,0.8)'
        },
        {
            // dark grey
            backgroundColor: 'rgba(46,204,113,2)',
            borderColor: 'rgba(46,204,113,1)', // histogram 
            // pointBackgroundColor: 'rgba(77,83,96,1)',
            // pointBorderColor: '#fff',
            // pointHoverBackgroundColor: '#fff',
            //  pointHoverBorderColor: 'rgba(77,83,96,1)'
        },
        {
            // grey
            // backgroundColor: 'rgba(148,159,177,0.2)',
            borderColor: 'rgba(52,152,219,1)',
            // pointBackgroundColor: 'rgba(148,159,177,1)',
            // pointBorderColor: '#fff',
            //  pointHoverBackgroundColor: '#fff',
            // pointHoverBorderColor: 'rgba(148,159,177,0.8)'
        }
    ];

    public lineChartLabels: Array<any> = [];

    chart = [];

    public lineChartLegend: boolean;
    public lineChartType: string;

    public lineChartData: Array<any> = [
        { data: [], label: 'RSI', type: 'line' },
    ];

    ngOnInit() {
        this.lineChartLegend = true;
        this.lineChartType = 'bar';
    }
    public async downloadMACD() {

        let parsedFromDate: Date = (this.fromDate ? new Date(this.fromDate.year, this.fromDate.month - 1, this.fromDate.day) : new Date(1970,1,1));
        let parsedToDate: Date = (this.toDate ? new Date(this.toDate.year, this.toDate.month - 1, this.toDate.day) : new Date());

        let sorce = await this.RSI.getRSI();

        let Rowdataset = sorce.filter(x => 
            new Date(x.date.toString()) > parsedFromDate
            && new Date(x.date.toString()) < parsedToDate
        );

        let RSI_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.RSI } });

        let singledate = Rowdataset.map(x => x.date);
        let LinechartDataSet: Array<any> = [
            { data: RSI_Date, label: "RSI", type: "line" }
        ]
        this.lineChartLabels = singledate;
        this.lineChartData = LinechartDataSet;
    }

}
