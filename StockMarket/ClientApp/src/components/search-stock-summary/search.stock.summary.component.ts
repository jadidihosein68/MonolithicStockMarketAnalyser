import { TimeSeriesService } from './../../services/time.series.service';
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
    , private TimeSeriesService: TimeSeriesService

  ) { }


  async SyncStockIndex() {

    console.log("Ok ! No problem !" + this.stockIndex);
    var result = await this.TimeSeriesService.SyncTimeSeries(this.stockIndex);
    this.modalService.dismissAll();
    this.sweetAlertService.getSwal(
      {
        type: 'success',
        title: this.stockIndex + ' Stock Index !',
        text: `A Total No. of ${result.totalCount} Records were extracted`,
        footer: 'Cheers !'
      }
    );
    this.StockSummaryDatatableComponent.refreshTable();

  }
}