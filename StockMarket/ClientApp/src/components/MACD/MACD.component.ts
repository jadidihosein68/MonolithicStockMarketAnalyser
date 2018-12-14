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
export class MACDComponent {
    constructor(private MACD: MACDService) { }

    chart = [];


    public pieChartLabels: string[];// = ["Pending", "InProgress", "OnHold", "Complete", "Cancelled"];
    public pieChartData: any[] =
        [{
            x: "01/04/2014", y: 175
        }, {
            x: "01/10/2014", y: 175
        }, {
            x: "01/04/2015", y: 178
        }, {
            x: "01/10/2015", y: 178
        }];



    public pieChartType: string = 'line';
    public pieChartOptions: any = {
        'backgroundColor': [
            "#FF6384",
            "#4BC0C0",
            "#FFCE56",
            "#E7E9ED",
            "#36A2EB"
        ],

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


    }

    OnInit() {
        /*
                this.chart = new Chart('canvas', {
                    type: 'bar',
                    data: this.data,
                    options: {
                        scales: {
                            xAxes: [{
                                display: true
                              }],
                            yAxes: [{
                                display: true,  
                                ticks: {
                                    beginAtZero: true
                                }
                            }]
                        }
                    }
                });
        */
    }
    public async downloadMACD() {

        let Rowdataset = await this.MACD.getMACD();

        let chartData = Rowdataset.map(function (elements, ll) {
            return {
                x: elements.date,
                y: elements.macd
            }
        }

        );


        this.pieChartData = chartData;
        console.log("call API")
        // console.log(labels)
        console.log(chartData)

    }
}









