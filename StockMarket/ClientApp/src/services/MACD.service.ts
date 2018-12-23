import { Injectable } from '@angular/core';
import { ApiService } from './ApiService.service';
import { MACD } from '../model/MACD';

@Injectable()
export class MACDService {

    public MACD: MACD[];
    constructor(private apiService: ApiService) {}
    public async getMACD() {
        var result = await this.apiService.get<MACD[]>({ url: "api/TimeSeries/generateMacd" });
        return result;
    }
}


