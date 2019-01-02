import { Component, ViewChild, OnInit } from '@angular/core';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { TwitterService } from '../../../services/TwitterService';
import { sweetAlertService } from '../../../services/sweetAlertService.service';
import { DataTableDirective, DataTablesModule } from 'angular-datatables';
import { DatePipe } from '@angular/common';
import { TweetsSummary } from '../../../model/interface/TweetsSummary';
import { Appsetting } from '../../../model/constant/Appsetting';

@Component({
    selector: 'Datatable-Twitter',
    templateUrl: './twitter.datatable.component.html',
    styleUrls: ['./twitter.datatable.component.scss']
})
export class TwitterDatatableComponent implements OnInit {
    @ViewChild(DataTableDirective)
    datatableElement: DataTableDirective;
    dtOptions: DataTables.Settings = {};
    closeResult: string;
    TweetID: string;
    constructor(private TwitterService: TwitterService, ) { }

    dataset = {
        "data": [
            {
                "lastUpdate": "2018/10/20",
                "screen_Name": "TweetID",
                "nOofRecords": 11,
                "Action": "zz",
            }
        ]
    }
    async ngOnInit() {
        var datePipe = new DatePipe("en-US");
        this.dtOptions = {
            ajax: {
                url: "/api/Twitter/GetTweetsSummary"
                , dataSrc: ""
            },
            columns: [{
                title: 'Last update',
                data: 'lastUpdate'
                , render: function (data) {
                    return datePipe.transform(data, 'MMM-dd-yyyy');;
                }
            }, {
                title: 'Twitter ID',
                data: 'screen_Name',
                render: function (data) {
                    return `<a href="${Appsetting.TwitterURL}/${data}" target="_blank">${data}</a>`;
                }

            }, {
                title: 'No. of records',
                data: 'nOofRecords',
            },
            {
                title: 'Action',
                data: 'screen_Name'
                , render: function (data) {
                    return `<i class="fa fa-refresh" (click)={{abu}}></i>  <i class="fas fa fa-download"></i>`;
                }
            }]
        };
    }

    addRow(object: TweetsSummary) {
        this.datatableElement.dtInstance.then((dtInstance: DataTables.Api) => {
            dtInstance.row.add(
                {
                    "lastUpdate": object.LastUpdate,
                    "screen_Name": object.Screen_Name,
                    "nOofRecords": object.NOofRecords,
                    "Action": object.Screen_Name
                }
            ).draw();
        })
    }
}