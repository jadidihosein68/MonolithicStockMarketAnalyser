import { Injectable } from '@angular/core';
import { ApiService } from './ApiService.service';
import { StockSyncResult } from '../model/StockSyncResult';

@Injectable()
export class TimeSeriesService {


    constructor(private apiService: ApiService) { }


    public async SyncTimeSeries(index: string) {
        var result = await this.apiService.get<StockSyncResult>({ url: "api/TimeSeries/SyncTimeSeriesIndex?StockIndex" + index });
        return result;
    }
}


