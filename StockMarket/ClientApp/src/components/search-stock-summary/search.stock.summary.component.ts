import { Component, ViewChild } from '@angular/core';
import { StockSummaryDatatableComponent } from '../datatables/StockSummaryDatatable/stock.summary.datatable.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { sweetAlertService } from '../../services/sweetAlertService.service';

@Component({
  selector: 'Search-Stock-Summary',
  templateUrl: './search.stock.summary.component.html',
  styleUrls: ['./search.stock.summary.component.scss']
})
export class SearchStockSummaryComponent {
  closeResult: string;
  stockIndex: string;
  @ViewChild(StockSummaryDatatableComponent)
  StockSummaryDatatableComponent: StockSummaryDatatableComponent;

  constructor(private modalService: NgbModal
    , private sweetAlertService: sweetAlertService

  ) { }


  SyncStockIndex() {
    console.log("Ok ! No problem !");
    this.modalService.dismissAll();
  }
}