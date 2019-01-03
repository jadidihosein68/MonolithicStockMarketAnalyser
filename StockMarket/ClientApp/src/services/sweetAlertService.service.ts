import swal from '../../node_modules/sweetalert2/dist/sweetalert2.js'
import { Injectable } from '@angular/core';
import { swalOptions } from '../model/interface/swalOptions.js';


@Injectable()
export class sweetAlertService {

    constructor() { }

    public getSwal(obj: any) {
        return swal(obj);
    }

    public AJAXCallSwal(obj: any) {
        swal(obj);
        swal.enableLoading();
    }

    public closeSwal() {

        swal.close();
    }

}







