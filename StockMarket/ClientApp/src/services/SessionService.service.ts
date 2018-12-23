import { Injectable } from '@angular/core';

@Injectable()
export class SessionService {
    session : any[] = new Array<any>();
    constructor() { }

    public getSession (sessionKey:string){
        return this.session[sessionKey];
    }

    public SetSession (sessionKey:string, sessionValue : any){
        return this.session[sessionKey] = sessionValue;
    }

    public DeleteSession (sessionKey:string) {
        delete this.session[sessionKey];
    }



}