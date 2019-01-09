import { Injectable } from '@angular/core';
import { ApiService } from './ApiService.service';
import { TwitterDto } from '../model/dto/TwitterDto';
import { TweetsSummary } from '../model/interface/TweetsSummary';
import { TaskData } from '@angular/core/src/testability/testability';
import { tweets } from '../model/base/tweets';

@Injectable()
export class TwitterService {

    constructor(private apiService: ApiService) { }
    public async getTweets(TweetID: string) {
        var result = await this.apiService.get<TwitterDto>({ url: "api/Twitter/GetTweetFromTwtter?ScreenName=" + TweetID });
        return result;
    }


    public async  getTweetSummary() {
        var result = await this.apiService.get<TweetsSummary[]>({ url: "api/Twitter/GetTweetsSummary" });
        return result;
    }


    public async GetTweetsFromDBByScreenName(TweetID: string) {
        var result = await this.apiService.get<tweets[]>({ url: "api/Twitter/GetTweetsByScreenName?ScreenName=" + TweetID });
        return result;
    }



}

