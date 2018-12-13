
import { OnInit, Component, ViewChild } from '@angular/core';
import { MACDService } from '../../services/MACD.service';
import { Chart } from 'chart.js';

@Component({
    selector: 'MACD-Chart',
    templateUrl: './MACD.component.html',
    styleUrls: ['./MACD.component.scss']
})
export class MACDComponent {
    constructor(private MACD: MACDService) { }

    chart = [];

    data = {
        labels: ["Red", "Blue", "Yellow", "Green", "Purple", "Orange"],
        datasets: [{
            label: '# of Votes',
            data: [12, 19, 3, 5, 2, 3],
            backgroundColor: [
                'rgba(255, 99, 132, 0.2)',
                'rgba(54, 162, 235, 0.2)',
                'rgba(255, 206, 86, 0.2)',
                'rgba(75, 192, 192, 0.2)',
                'rgba(153, 102, 255, 0.2)',
                'rgba(255, 159, 64, 0.2)'
            ],
            borderColor: [
                'rgba(255,99,132,1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 1
        }]
    };


    OnInit() {

        this.chart = new Chart('canvas', {
            type: 'line',
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

    }
    public downloadMACD() {
        console.log("call API")
        let dataset = this.MACD.getMACD();



    }
}









