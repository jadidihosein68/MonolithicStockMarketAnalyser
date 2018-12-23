import { Component, Output, EventEmitter } from '@angular/core';

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
    @Output() SearchOnDate = new EventEmitter ();
    
    getChartOnline(){
        this.SearchOnDate.emit({fromdate: this.fromDate , toDate : this.toDate});
    }



}
