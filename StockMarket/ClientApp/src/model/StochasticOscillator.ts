import { TimeSeries } from './base/TimeSeries';

export class StochasticOscillator extends TimeSeries   {
    fastK :number ;
    fastD :number ;
    slowD :number ;
}