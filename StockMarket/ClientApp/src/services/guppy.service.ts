import { Injectable } from '@angular/core';
import { ApiService } from './ApiService.service';
import { __await } from 'tslib';
import { guppy } from '../model/guppy';

@Injectable()
export class guppyService {

    public StochasticOscillator: guppy[];
    constructor(private apiService: ApiService) {}
    public async getGuppy() {
        var result = await this.apiService.get<guppy[]>({ url: "api/TimeSeries/generateGuppy" });
        return result;
    }
}

