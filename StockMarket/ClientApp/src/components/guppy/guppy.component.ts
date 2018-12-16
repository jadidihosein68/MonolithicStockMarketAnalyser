import { OnInit, Component, ViewChild } from '@angular/core';
import { csvConvertorService } from '../../services/csv.convertor.service';
import { lineChartOptions } from './../../model/constant/lineChartOptions';
import { guppyService } from '../../services/guppy.service';
import { guppy } from './../../model/guppy';

@Component({
    selector: 'guppy-Chart',
    templateUrl: './guppy.component.html',
    styleUrls: ['./guppy.component.scss']
})


export class guppyComponent implements OnInit {
    constructor(private guppyService: guppyService,
        private csvConvertorService:csvConvertorService) { }

    show:boolean = false ; 
    public lineChartLabels: Array<any> = [];
    public lineChartLegend: boolean;
    public lineChartType: string;
    sorce : Array<guppy>;
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
        { data: [], label: 'shortlag3', type: 'line' },
        { data: [], label: 'shortlag5', type: 'line' },
        { data: [], label: 'shortlag8', type: 'line' },
        { data: [], label: 'shortlag10', type: 'line' },
        { data: [], label: 'shortlag12', type: 'line' },
        { data: [], label: 'shortlag15', type: 'line' },
        { data: [], label: 'longlag30', type: 'line' },
        { data: [], label: 'longlag35', type: 'line' },
        { data: [], label: 'longlag40', type: 'line' },
        { data: [], label: 'longlag45', type: 'line' },
        { data: [], label: 'longlag50', type: 'line' },
        { data: [], label: 'longlag60', type: 'line' }      
    ];

    ngOnInit() {
        this.lineChartLegend = true;
        this.lineChartType = 'line';
    }

    public async getGuppyOnline(){
        this.sorce = await this.guppyService.getGuppy();

        console.log({"this.sorce":this.sorce});
        this.sketchGuppy();
    }

    public sketchGuppy() {

        let Rowdataset = this.getSelectedRangeData();
        let shortlag3_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.shortlag3 } });
        let shortlag5_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.shortlag5 } });
        let shortlag8_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.shortlag8 } });
        let shortlag10_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.shortlag10 } });
        let shortlag12_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.shortlag12 } });
        let shortlag15_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.shortlag15 } });
        let longlag30_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.longlag30 } });
        let longlag35_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.longlag35 } });
        let longlag40_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.longlag40 } });
        let longlag45_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.longlag45 } });
        let longlag50_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.longlag50 } });
        let longlag60_Date = Rowdataset.map(x => { return { "x": x.date, "y": x.longlag60 } });

        let singledate = Rowdataset.map(x => x.date);
        let LinechartDataSet: Array<any> = [
            { data: shortlag3_Date, label: "short lag 3", type: "line" }
            ,{ data: shortlag5_Date, label: "short lag 5", type: "line" }
            ,{ data: shortlag8_Date, label: "short lag 8", type: "line" }
            ,{ data: shortlag10_Date, label: "short lag 10", type: "line" }
            ,{ data: shortlag12_Date, label: "short lag 12", type: "line" }
            ,{ data: shortlag15_Date, label: "short lag 15", type: "line" }
            ,{ data: longlag30_Date, label: "long lag 30", type: "line" }
            ,{ data: longlag35_Date, label: "long lag 35", type: "line" }
            ,{ data: longlag40_Date, label: "long lag 40", type: "line" }
            ,{ data: longlag45_Date, label: "long lag 45", type: "line" }
            ,{ data: longlag50_Date, label: "long lag 50", type: "line" }
            ,{ data: longlag60_Date, label: "long lag 60", type: "line" }
        ]

        this.lineChartLabels = singledate;
        this.lineChartData = LinechartDataSet;
        console.log({LinechartDataSet:LinechartDataSet})

    }

    public ExportToCSV(){
        this.csvConvertorService.getGuppycsv(this.getSelectedRangeData());
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
