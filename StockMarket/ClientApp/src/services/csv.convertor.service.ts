import { StochasticOscillator } from './../model/interface/StochasticOscillator';
import { MACD } from './../model/interface/MACD';
import { Angular5Csv } from 'angular5-csv/Angular5-csv';
import { RSI } from './../model/interface/RSI';




export class csvConvertorService {

    private options = { 
        fieldSeparator: ',',
        quoteStrings: '"',
        decimalseparator: '.',
        showLabels: true, 
        showTitle: true,
        useBom: true,
        noDownload: true,
        headers: []
      };

    public getMACDcsv (MACD:MACD[]){


        this.options.headers= [""];

        new Angular5Csv(MACD, "MACD",  this.options);
    }



    public getRSIcsv (RSI:RSI[]){

        this.options.headers= [""];

        new Angular5Csv(RSI, "RSI", this.options);
    }



    public getSOcsv (SO:StochasticOscillator){
        this.options.headers= [""];
        new Angular5Csv(SO, "StochasticOscillator",this.options);
    }



    public getGuppycsv (){


    }

}