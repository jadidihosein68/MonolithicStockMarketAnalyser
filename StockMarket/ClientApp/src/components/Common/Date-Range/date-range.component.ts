import { Component } from '@angular/core';




@Component({
    selector: 'date-range',
    templateUrl: './date-range.component.html',
    styleUrls: ['./date-range.component.scss']
})
export class DateRangeComponent 
{

    public lineChartLabels: Array<any> = [];
    fromDate: any;
    toDate: any;

}