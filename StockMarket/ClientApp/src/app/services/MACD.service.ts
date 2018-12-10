import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Inject } from '@angular/core';


@Injectable()
export class MACDService {

    _baseURL;
    public MACD: MACD[];
    constructor(private _http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this._baseURL = baseUrl;
    }

    public getMACD() {
        var result = this._http.get<MACD[]>(this._baseURL + "api/TimeSeries/generateMacd").subscribe(result => {
            this.MACD = result;
            console.log(this.MACD)
        }, error => console.error(error));
        return this.MACD;
    }

}


interface MACD {
    macd: number;
    signal: number;
    histogram: number;
    date: string;
    open: number;
    high: number;
    low: number;
    close: number;
    volume: number;
}

