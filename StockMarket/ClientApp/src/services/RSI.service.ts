import { Injectable } from '@angular/core';
import { Inject } from '@angular/core';
import { ApiService } from './ApiService.service';
import { __await } from 'tslib';
import { RSI } from '../model/RSI';


@Injectable()
export class RSIService {

    public RSI: RSI[];
    constructor(private apiService: ApiService) {}
    public async getRSI() {
        var result = await this.apiService.get<RSI[]>({ url: "api/TimeSeries/generateRSI" });
        return result;
    }
}


