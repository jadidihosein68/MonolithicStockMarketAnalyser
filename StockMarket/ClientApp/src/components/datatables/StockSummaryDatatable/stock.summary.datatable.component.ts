import { Renderer, ViewChild, OnInit, Component } from '@angular/core';
import { csvConvertorService } from '../../../services/csv.convertor.service';
import { sweetAlertService } from '../../../services/sweetAlertService.service';
import { DataTableDirective } from 'angular-datatables';
import { DatePipe } from '@angular/common';

@Component({
    selector: 'Datatable-StockSummary',
    templateUrl: './stock.summary.datatable.component.html',
    styleUrls: ['./stock.summary.datatable.component.scss']
})

export class StockSummaryDatatableComponent implements OnInit {
    @ViewChild(DataTableDirective)
    datatableElement: DataTableDirective;
    dtOptions: DataTables.Settings = {};
    closeResult: string;
    TweetID: string;
    constructor(
        private renderer: Renderer,
        private csvConvertorService: csvConvertorService,
        private sweetAlertService: sweetAlertService
    ) { }

    dataset = {
        "data": [
            {
                "stockIndex": "FB",
                "startDate": "2018/10/20",
                "endDate": "2018/10/20",
                "Action": "zz",
            }
        ]
    }

    async ngOnInit() {
        var datePipe = new DatePipe("en-US");

        this.dtOptions = {
            ajax: {
                url: "/api/TimeSeries/getStockSmmeries"
                , dataSrc: ""
            },
            columns: [
                {
                    title: 'Stock Index',
                    data: 'stockIndex',
                    render: function (data) {
                        return data;
                    }

                },
                {
                    title: 'Start Date',
                    data: 'startDate'
                    , render: function (data) {
                        return datePipe.transform(data, 'MMM-dd-yyyy');
                    }
                }, {
                    title: 'End Date',
                    data: 'endDate',
                    render: function (data) {
                        return datePipe.transform(data, 'MMM-dd-yyyy');
                    }
                },
                {
                    title: 'Action',
                    data: 'stockIndex'
                    , render: function (data: any, type: any, full: any) {
                        return `<i class="fa fa-refresh" refresh-id=${data} ></i>  <i class="fas fa fa-download" download-id=${data}></i>`;
                    }
                }]
        };

    }

    refreshTable() {
        this.datatableElement.dtInstance.then((dtInstance: DataTables.Api) => {
            dtInstance.ajax.reload();
        })
    }
}