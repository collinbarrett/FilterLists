import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';
import { ApiService } from '../api.service';
import { FilterListSummary } from '../filter-list-summary';
import { DirectoryTableDataSource } from './directory-table-datasource';

@Component({
  selector: 'filterlists-directory-table',
  templateUrl: './directory-table.component.html',
  styleUrls: ['./directory-table.component.css'],
})
export class DirectoryTableComponent implements AfterViewInit {
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) table!: MatTable<FilterListSummary>;
  dataSource: DirectoryTableDataSource;

  displayedColumns = [
    'name',
    'description',
    'software',
    'syntaxes',
    'languages',
    'tags',
    'maintainers',
    'license',
  ];

  constructor(api: ApiService) {
    this.dataSource = new DirectoryTableDataSource(api);
  }

  ngAfterViewInit(): void {
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
    this.table.dataSource = this.dataSource;
  }
}
