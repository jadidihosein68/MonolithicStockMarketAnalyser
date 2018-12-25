import { TweetsSummary } from '../../model/interface/TweetsSummary';
import { Component, ViewChild } from '@angular/core';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { TwitterService } from '../../services/TwitterService';
import { sweetAlertService } from '../../services/sweetAlertService.service';
import { TwitterDatatableComponent } from '../datatables/TwitterDatatable/twitter.datatable.component';

@Component({
  selector: 'Search-Twitter',
  templateUrl: './search.tweets.component.html',
  styleUrls: ['./search.tweets.component.scss']
})
export class SearchTweetsComponent {
  closeResult: string;
  TweetID:string ;
  @ViewChild(TwitterDatatableComponent)
  twitterDatatableComponent:TwitterDatatableComponent;

  constructor(private modalService: NgbModal
    , private TwitterService: TwitterService
    , private sweetAlertService: sweetAlertService

  ) { }

  async getTweet() {
    let Tweets = await this.TwitterService.getTweets(this.TweetID);

    this.sweetAlertService.getSwal({
      type: 'success',
      title: 'Tweets !',
      text: `A Total No. of ${Tweets.totalNoOfTweets} Tweets were extracted`,
      footer: '<a >Dont tell anyone !</a>'
    });

    this.modalService.dismissAll();

    let tweettssammury :TweetsSummary = {
      Screen_Name : Tweets.screenName,
      NOofRecords : Tweets.totalNoOfTweets,
      LastUpdate : new Date()
    } 
    this.twitterDatatableComponent.addRow(tweettssammury);
  }


}