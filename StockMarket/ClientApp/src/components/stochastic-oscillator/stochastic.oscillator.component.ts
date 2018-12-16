import { OnInit, Component, ViewChild } from '@angular/core';
import { RSIService } from '../../services/RSI.service';
import { RSI } from '../../model/interface/RSI';
import { csvConvertorService } from '../../services/csv.convertor.service';
import { lineChartOptions } from './../../model/constant/lineChartOptions';
import { stochasticOscillatorService } from '../../services/stochasticOscillator.service';
import { StochasticOscillator } from '../../model/StochasticOscillator';

@Component({
    selector: 'SO-Chart',
    templateUrl: './stochastic.oscillator.component.html',
    styleUrls: ['./stochastic.oscillator.component.scss']
})


export class SOComponent implements OnInit {
    constructor(private stochasticOscillatorService: stochasticOscillatorService,
        private csvConvertorService:csvConvertorService) { }

    show:boolean = false ; 
    public lineChartLabels: Array<any> = [];
    public lineChartLegend: boolean;
    public lineChartType: string;
    sorce : Array<StochasticOscillator>;
    fromDate: any;
    toDate: any;
    public lineChartOptions=lineChartOptions;
    public lineChartColors: Array<any> = [
        {
            borderColor: 'rgba(238, 56, 56,1)',
        },

        {
            backgroundColor: 'rgba(46,204,113,2)',
            borderColor: 'rgba(46,204,113,1)',
        },
        {
            borderColor: 'rgba(52,152,219,1)',
        }


    ];

    public lineChartData: Array<any> = [
        { data: [], label: 'Fast K', type: 'line' },
        { data: [], label: 'Fast D', type: 'line' },
        { data: [], label: 'Slow D', type: 'line' }
    ];

    ngOnInit() {
        this.lineChartLegend = true;
        this.lineChartType = 'line';
    }

    public async getSOOnline(){
        this.sorce = await this.stochasticOscillatorService.getStochasticOscillator();

        console.log({"this.sorce":this.sorce});
        this.sketchSO();
    }

    public sketchSO() {

        let Rowdataset = this.getSelectedRangeData();
        let fastK_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.fastK } });
        let fastD_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.fastD } });
        let SlowD_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.slowD } });
        let singledate = Rowdataset.map(x => x.date);
        let LinechartDataSet: Array<any> = [
            { data: fastK_Date, label: "Fast K", type: "line" }
            ,{ data: fastD_Date, label: "Fast D", type: "line" }
            ,{ data: SlowD_Date, label: "Slow D", type: "line" }
        ]

        this.lineChartLabels = singledate;
        this.lineChartData = LinechartDataSet;
        console.log({LinechartDataSet:LinechartDataSet})

    }

    public ExportToCSV(){
        this.csvConvertorService.getSOcsv(this.getSelectedRangeData());
    }

    
    private getSelectedRangeData(){
        let parsedFromDate: Date = (this.fromDate ? new Date(this.fromDate.year, this.fromDate.month - 1, this.fromDate.day) : new Date(1970,1,1));
        let parsedToDate: Date = (this.toDate ? new Date(this.toDate.year, this.toDate.month - 1, this.toDate.day) : new Date());
        let Rowdataset = this.sorce.filter(x => 
            new Date(x.date.toString()) > parsedFromDate
            && new Date(x.date.toString()) < parsedToDate
        );
        return Rowdataset;
    }


}
