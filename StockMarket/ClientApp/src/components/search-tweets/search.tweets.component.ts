import { Component } from '@angular/core';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { TwitterService } from '../../services/TwitterService';
import { sweetAlertService } from '../../services/sweetAlertService.service';

@Component({
  selector: 'Search-Twitter',
  templateUrl: './search.tweets.component.html',
  styleUrls: ['./search.tweets.component.scss']
})
export class SearchTweetsComponent {
  closeResult: string;
  TweetID:string ;
  MardImage = `assets/images/Mard2.png`;
  constructor(private modalService: NgbModal
    , private TwitterService: TwitterService
    , private sweetAlertService: sweetAlertService

  ) { }

  open(content) {
    this.modalService.open(content).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }

  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }

  async getTweet() {
    let Tweets = await this.TwitterService.getTweets(this.TweetID);
    this.sweetAlertService.getSwal({
      type: 'success',
      title: 'Tweets !',
      text: `A Total No. of ${Tweets.totalNoOfTweets} Tweets were extracted`,
      footer: '<a >Dont tell anyone !</a>'
    });

    if (!Tweets) {
      console.log("Apaaa ?!");

    }

    console.log(Tweets);
  }


}