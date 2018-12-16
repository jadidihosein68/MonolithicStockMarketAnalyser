import { StochasticOscillator } from '../model/StochasticOscillator';

import { Injectable } from '@angular/core';
import { ApiService } from './ApiService.service';
import { __await } from 'tslib';


@Injectable()
export class stochasticOscillatorService {

    public StochasticOscillator: StochasticOscillator[];
    constructor(private apiService: ApiService) {}
    public async getStochasticOscillator() {
        var result = await this.apiService.get<StochasticOscillator[]>({ url: "api/TimeSeries/generateStochasticOscillator" });
        return result;
    }
}


