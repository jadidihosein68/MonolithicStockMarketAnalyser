import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';



@Injectable()
export class MACDService{

constructor( private _http : HttpClient) {}

getMACD (){

    var result = this._http.get("https://localhost:44332/api/TimeSeries/generateMacd"); 
    return result;

}








}