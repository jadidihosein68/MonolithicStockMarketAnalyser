import { tweets } from './../model/base/tweets';
import { guppy } from './../model/guppy';

import { MACD } from './../model/MACD';
import { Angular5Csv } from 'angular5-csv/Angular5-csv';
import { RSI } from './../model/RSI';
import { StochasticOscillator } from './../model/StochasticOscillator';

export class csvConvertorService {

    private options = { 
        fieldSeparator: ',',
        quoteStrings: '"',
        decimalseparator: '.',
        showLabels: true, 
        showTitle: false,
        useBom: true,
        noDownload: false,
        headers: []
      };

    public getMACDcsv (MACDData:MACD[]){
        
        this.options.headers= this.getProperty(MACDData[0]) ;
        new Angular5Csv(MACDData, "MACD",  this.options);
    }

    public getRSIcsv (RSI:RSI[]){

        this.options.headers= this.getProperty(RSI[0]) ;
        new Angular5Csv(RSI, "RSI", this.options);
    }

    public getSOcsv (SO:StochasticOscillator[]){
        this.options.headers= this.getProperty(SO[0]) ;
        new Angular5Csv(SO, "StochasticOscillator",this.options);
    }


    public getGuppycsv (Guppy:guppy[]){
        this.options.headers= this.getProperty(Guppy[0]) ;
        new Angular5Csv(Guppy, "Guppy",this.options);
    }


    private getProperty(sample : any){
       
        let elements = [] ;
        for (var element in sample )
        {
            elements.push(element)
        }
        return elements;
    }


    public getTweetsCsv (Tweets:tweets[] , Name:string){
        this.options.headers= this.getProperty(Tweets[0]) ;
        new Angular5Csv(Tweets, Name + " Tweets",this.options);
    }

}