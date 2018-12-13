import { Injectable } from '@angular/core';
import { Inject } from '@angular/core';
import { ApiService } from './ApiService.service';
import { __await } from 'tslib';
import { MACD } from '../model/interface/MACD';


@Injectable()
export class MACDService {

    public MACD: MACD[];
    constructor(private apiService: ApiService) {}

    public async getMACD() {
        var result = await this.apiService.get<MACD[]>({ url: "api/TimeSeries/generateMacd" });
        return result;
    }
}


