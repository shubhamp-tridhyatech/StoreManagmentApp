import { Component, OnInit } from '@angular/core';
import { AgGridAngular } from 'ag-grid-angular';
import { CellClickedEvent, ColDef, ColumnApi, GridApi, GridReadyEvent, RowModelType } from 'ag-grid-community';
import { CountryService } from '../country.services';

@Component({
  selector: 'app-country-list',
  templateUrl: './country-list.component.html',
  styleUrls: ['./country-list.component.css']
})
export class CountryListComponent implements OnInit {
  private gridColumnApi!: ColumnApi;
  private gridApi!: GridApi<any>;
  public paginationDet: any = {};
  public rowModelType: RowModelType = 'serverSide';

  constructor(private countryService: CountryService) {
    this.paginationDet = {
      pageNumber: 0,
      pageSize: 10,
      sortBy: 'id'
    };
  }

  columnDefs: ColDef[] = [
    { field: 'id', headerName: 'ID', minWidth: 70, maxWidth: 70 },
    {
      field: 'countryName', headerName: 'Country Name',
      floatingFilter: true,
      menuTabs: ['filterMenuTab', 'generalMenuTab', 'columnsMenuTab'],
      suppressMenu: true, suppressFiltersToolPanel: true, filter: true, resizable: true,
      floatingFilterComponentParams: {
        suppressFilterButton: true
      },
    }
  ];

  rowData = [];
  public defaultColDef: ColDef = {
    flex: 1,
    minWidth: 150,
    //filter: true,
  }

  ngOnInit(): void {
  }

  onPaginationChanged(event: any) {
    if (event.newPage) {
      this.paginationDet.pageNumber = this.gridApi.paginationGetCurrentPage() + 1;
      this.fetchData();
    }
  }

  onGridReady(params: GridReadyEvent<any>) {
    this.gridApi = params.api;

    this.gridColumnApi = params.columnApi;
    this.fetchData();
  }

  fetchData() {
    this.countryService.getCountryList(this.paginationDet)
      .subscribe({
        next: (res) => {
          if (res.isSuccess === true) {
            var datasource = this.createServerSideDatasource(res);
            this.gridApi.setServerSideDatasource(datasource);
            //this.rowData = res.data;
          }
          this.gridApi.sizeColumnsToFit();
        },
        error: (e) => console.error(e)
      });
  }

  createServerSideDatasource(data: any) {
    return {
      getRows: function (params: any) {
        setTimeout(function () {
          params.successCallback(data.data, 200);
        }, 500);
      },
    };
  }
}
