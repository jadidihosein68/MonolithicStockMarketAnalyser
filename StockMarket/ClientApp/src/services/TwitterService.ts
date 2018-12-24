import { Injectable } from '@angular/core';
import { ApiService } from './ApiService.service';
import { TwitterDto } from '../model/dto/TwitterDto';

@Injectable()
export class TwitterService {

    constructor(private apiService: ApiService) {}
    public async getTweets(TweetID:string) {
        var result = await this.apiService.get<TwitterDto>({ url: "api/Twitter/GetTweetFromTwtter?ScreenName="+TweetID });
        return result;
    }
}


