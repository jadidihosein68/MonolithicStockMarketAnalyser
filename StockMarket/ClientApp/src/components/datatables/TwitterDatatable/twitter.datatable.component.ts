import { csvConvertorService } from './../../../services/csv.convertor.service';
import { Component, ViewChild, OnInit, Renderer } from '@angular/core';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { TwitterService } from '../../../services/TwitterService';
import { sweetAlertService } from '../../../services/sweetAlertService.service';
import { DataTableDirective, DataTablesModule } from 'angular-datatables';
import { DatePipe } from '@angular/common';
import { TweetsSummary } from '../../../model/interface/TweetsSummary';
import { Appsetting } from '../../../model/constant/Appsetting';
import { Router } from '@angular/router';

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
    constructor(private TwitterService: TwitterService,
        private renderer: Renderer,
        private csvConvertorService: csvConvertorService,
        private sweetAlertService: sweetAlertService
    ) { }

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
                , render: function (data: any, type: any, full: any) {
                    return `<i class="fa fa-refresh" refresh-id=${data} ></i>  <i class="fas fa fa-download" download-id=${data}></i>`;
                }
            }]
        };
    }

    async ngAfterViewInit() {
        this.renderer.listenGlobal('document', 'click', async (event) => {

            if (event.target.hasAttribute("refresh-id")) {

                var screenName = event.target.getAttribute("refresh-id");
                var theobj = {
                    title: 'Updating Tweets!',
                    html: `Update <strong>${screenName}</strong> Tweets.`,
                    showConfirmButton: false,
                    showCloseButton: false,
                };
                this.sweetAlertService.AJAXCallSwal(theobj);
                var results = await this.TwitterService.getTweets(screenName);
                this.refreshTable()
                this.sweetAlertService.getSwal({
                    type: 'success',
                    title: `${screenName}  Tweets !`,
                    text: `A Total No. of ${results.totalNoOfTweets} Tweets were extracted`,
                    footer: '<a >Dont tell anyone !</a>'
                });
            }
            if (event.target.hasAttribute("download-id")) {
                var screenName = event.target.getAttribute("download-id");
                var reslt = await this.TwitterService.GetTweetsFromDBByScreenName(screenName);
                this.csvConvertorService.getTweetsCsv(reslt, screenName);
            }
        });
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

    refreshTable() {
        this.datatableElement.dtInstance.then((dtInstance: DataTables.Api) => {
            dtInstance.ajax.reload();
        })
    }

}