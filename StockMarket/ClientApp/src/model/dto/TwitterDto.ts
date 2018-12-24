import { tweets } from '../base/tweets';
export class TwitterDto {
    tweets : Array<tweets>;
    screenName: string;
    totalNoOfTweets: number;
}