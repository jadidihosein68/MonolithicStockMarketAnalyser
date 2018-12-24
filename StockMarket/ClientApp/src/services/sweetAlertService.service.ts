import swal from '../../node_modules/sweetalert2/dist/sweetalert2.js'
import { Injectable } from '@angular/core';
import { swalOptions } from '../model/interface/swalOptions.js';


@Injectable()
export class sweetAlertService {

    constructor() {}

    public getSwal(obj:swalOptions){
        return swal(obj);
    }

}







