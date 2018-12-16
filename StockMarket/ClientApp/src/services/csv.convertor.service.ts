
import { MACD } from './../model/interface/MACD';
import { Angular5Csv } from 'angular5-csv/Angular5-csv';
import { RSI } from './../model/interface/RSI';
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


    public getGuppycsv (){


    }


    private getProperty(sample : any){
       
        let elements = [] ;
        for (var element in sample )
        {
            elements.push(element)
        }
        return elements;
    }

}