import { OnInit, Component, ViewChild } from '@angular/core';
import { RSIService } from '../../services/RSI.service';
import { RSI } from '../../model/interface/RSI';
import { csvConvertorService } from '../../services/csv.convertor.service';
import { lineChartOptions } from './../../model/constant/lineChartOptions';

@Component({
    selector: 'RSI-Chart',
    templateUrl: './RSI.component.html',
    styleUrls: ['./RSI.component.scss']
})


export class RSIComponent implements OnInit {
    constructor(private RSI: RSIService,
        private csvConvertorService:csvConvertorService) { }

    show:boolean = false ; 
    public lineChartLabels: Array<any> = [];
    public lineChartLegend: boolean;
    public lineChartType: string;
    sorce : Array<RSI>;
    fromDate: any;
    toDate: any;
    public lineChartOptions=lineChartOptions;
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
    ];

    public lineChartData: Array<any> = [
        { data: [], label: 'RSI', type: 'line' },
    ];

    ngOnInit() {
        this.lineChartLegend = true;
        this.lineChartType = 'line';
    }

    public async getRSIOnline(){
        this.sorce = await this.RSI.getRSI();
        this.sketchRSI();
    }

    public sketchRSI() {

        let Rowdataset = this.getSelectedRangeData();
        let RSI_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.rsi } });
        let singledate = Rowdataset.map(x => x.date);
        let LinechartDataSet: Array<any> = [
            { data: RSI_Date, label: "RSI", type: "line" }
        ]
        this.lineChartLabels = singledate;
        this.lineChartData = LinechartDataSet;
        console.log({RSILinechartDataSet:LinechartDataSet})

    }

    public ExportToCSV(){
        this.csvConvertorService.getRSIcsv(this.getSelectedRangeData());
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
