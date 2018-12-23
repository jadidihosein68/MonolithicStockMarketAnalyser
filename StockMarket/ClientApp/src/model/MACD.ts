import { TimeSeries } from './base/TimeSeries';

export class MACD extends TimeSeries {
    macd: number;
    signal: number;
    histogram: number;
}